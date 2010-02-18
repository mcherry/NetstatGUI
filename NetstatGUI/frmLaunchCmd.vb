Imports System.IO

Public Class frmLaunchCmd
    Private strCmd As String = Nothing
    Private strPrm As String = Nothing

    Public Sub Init(Optional ByVal strCommand As String = "", Optional ByVal strParams As String = "", Optional ByVal boolHelp As Boolean = False, Optional ByVal boolDos As Boolean = False, Optional ByVal boolCheckDos As Boolean = False)
        strCmd = strCommand
        strPrm = strParams

        If Not strCmd = "" Then
            txtCmd.Text = strCmd
            txtCmd.Enabled = False
            Label1.Text = "Enter parameters to the command '" & strCmd & "':"
        End If

        If boolDos = True Then
            chkDos.Visible = True
        Else
            chkDos.Visible = False
        End If

        If boolCheckDos = True Then
            chkDos.Checked = True
        Else
            chkDos.Checked = False
        End If

        If boolHelp = False Then
            Me.Height = 145
            Me.Width = 358
        Else
            Me.Height = 450
            Me.Width = 630
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.SizeGripStyle = Windows.Forms.SizeGripStyle.Show

            Dim Proc As Process
            Dim strHelp As String = Nothing

            Proc = New Process()
            With Proc
                .StartInfo.FileName = strCmd
                If strCmd = "nmap.exe" Then
                    .StartInfo.Arguments = "--help"
                Else
                    .StartInfo.Arguments = "/?"
                End If
                .StartInfo.UseShellExecute = False
                .StartInfo.CreateNoWindow = True
                .StartInfo.RedirectStandardOutput = True
                .StartInfo.RedirectStandardError = True
                .Start()
            End With

            Dim sOut As StreamReader = Proc.StandardOutput
            While Not (sOut.EndOfStream)
                strHelp += sOut.ReadLine & vbCrLf
            End While

            sOut.Close()
            sOut = Proc.StandardError
            While Not (sOut.EndOfStream)
                strHelp += sOut.ReadLine & vbCrLf
            End While

            sOut.Close()
            Proc.Close()

            txtHelp.Text = strHelp
        End If

        txtParam.Text = strPrm
    End Sub

    Private Sub frmLaunchCmd_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If txtCmd.Text = "" Then
            txtCmd.Focus()
        Else
            txtParam.Focus()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim boolCmd As Boolean = False
        If Not txtCmd.Text = "" Then
            If Not txtCmd.Text.Contains(":") Then
                Dim strPaths() As String = Environment.GetEnvironmentVariable("PATH").Split(";")
                For Each strItem As String In strPaths
                    If File.Exists(strItem & "\" & txtCmd.Text) Then
                        boolCmd = True
                    End If
                Next
            Else
                If File.Exists(txtCmd.Text) Then
                    boolCmd = True
                End If
            End If

            If boolCmd = True Then
                Dim strLogLine As String = txtCmd.Text
                If Not txtParam.Text = "" Then
                    strLogLine += " " & txtParam.Text
                End If

                frmMain.LogPrint("Launching command '" & strLogLine & "'")

                If chkDos.Checked = False Then
                    Dim frmNewCmd As frmConsole = New frmConsole
                    frmConsole.Init(txtCmd.Text, txtParam.Text)
                    frmConsole.Show()
                Else
                    Dim Proc As Process
                    Dim strHelp As String = Nothing

                    Proc = New Process()
                    With Proc
                        .StartInfo.FileName = strCmd
                        .StartInfo.Arguments = strPrm
                        .StartInfo.UseShellExecute = True
                        
                        .Start()
                        '.WaitForExit()
                    End With
                End If

                Me.Close()
            Else
                MsgBox("File not found.", MsgBoxStyle.Critical, "Error")
                txtCmd.Focus()
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub frmLaunchCmd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub chkDos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDos.CheckedChanged
        If txtCmd.Text = "" Then
            txtCmd.Focus()
        Else
            txtParam.Focus()
        End If
    End Sub
End Class