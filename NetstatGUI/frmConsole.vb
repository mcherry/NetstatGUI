Imports System.IO
Imports System.Threading

Public Class frmConsole
    Private strCmd As String = Nothing
    Private strPrm As String = Nothing
    Private cmdPID As Integer = 0
    Private TextLine As String = ""

    Public Sub Init(ByVal strCommand As String, ByVal strParams As String)
        strCmd = strCommand
        strPrm = strParams
    End Sub

    Private Sub frmConsole_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not cmdPID = 0 Then
            Dim cmdProc As Process = Process.GetProcessById(cmdPID)
            cmdProc.Kill()
        End If
    End Sub
    Private Sub frmConsole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub frmConsole_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Dim threadCommand As New Thread(AddressOf Me.StartProcess)

        Me.Text = strCmd & " " & strPrm
        Me.BringToFront()

        threadCommand.IsBackground = True
        threadCommand.Start()
    End Sub

    Private Sub StartProcess()
        Dim Proc As Process
        Dim strLine As String = Nothing

        Proc = New Process()
        With Proc
            .StartInfo.FileName = strCmd
            .StartInfo.Arguments = strPrm
            .StartInfo.UseShellExecute = False
            .StartInfo.CreateNoWindow = True
            .StartInfo.RedirectStandardOutput = True
            .StartInfo.RedirectStandardError = True
            .Start()

            cmdPID = .Id
        End With

        Dim sOut As StreamReader = Proc.StandardOutput
        While Not (sOut.EndOfStream)
            strLine = sOut.ReadLine

            TextLine = strLine
            AccessControl()
        End While

        sOut.Close()
        sOut = Proc.StandardError
        While Not (sOut.EndOfStream)
            strLine = sOut.ReadLine

            TextLine = strLine
            AccessControl()
        End While

        sOut.Close()
        Proc.Close()

        cmdPID = 0
    End Sub

    Private Sub AccessControl()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf AccessControl))
        Else
            txtOutput.Text += TextLine & vbNewLine
            txtOutput.SelectionStart = txtOutput.Text.Length
            txtOutput.ScrollToCaret()

            TextLine = ""
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim strFilename As String = GetSaveFilename("Connection List")

        If Not strFilename = Nothing Then
            Dim FileTest As String = WriteFile(txtOutput.Text, strFilename)
            If FileTest = Nothing Then
                frmMain.LogPrint("Saved output of '" & Me.Text & "' to '" & strFilename & "'")
            Else
                frmMain.LogPrint("ERROR: Unable to save output of '" & Me.Text & "'")
                frmMain.LogPrint("ERROR: " & FileTest)
            End If
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class