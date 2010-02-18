Public Class frmInfo
    Public Sub Init(ByVal NetstatEntry As NetStat)
        'Me.Text = "Netstat Entry - " & NetstatEntry.RemoteAddress
        Dim strInfo As String = Nothing
        Dim strPortInfo() As String

        txtProtocol.Text = NetstatEntry.Protocol
        txtLocalIP.Text = NetstatEntry.LocalAddress
        txtLocalPort.Text = NetstatEntry.LocalPort

        If PortDB.ContainsKey(NetstatEntry.LocalPort.ToString & "/" & NetstatEntry.Protocol.ToLower) Then
            strPortInfo = PortDB(NetstatEntry.LocalPort.ToString & "/" & NetstatEntry.Protocol.ToLower).Split("|")
            txtLocalService.Text = strPortInfo(1)
        Else
            txtLocalService.Text = "Unknown port"
        End If

        txtLocalHost.Text = IPToHostName(NetstatEntry.LocalAddress)
        txtRemoteIP.Text = NetstatEntry.RemoteAddress
        txtRemotePort.Text = NetstatEntry.RemotePort

        If PortDB.ContainsKey(NetstatEntry.RemotePort.ToString & "/" & NetstatEntry.Protocol.ToLower) Then
            strPortInfo = PortDB(NetstatEntry.RemotePort.ToString & "/" & NetstatEntry.Protocol.ToLower).Split("|")
            txtRemoteService.Text = strPortInfo(1)
        Else
            txtRemoteService.Text = "Unknown port"
        End If

        txtRemoteHost.Text = IPToHostName(NetstatEntry.RemoteAddress)

        txtConnection.Text = NetstatEntry.State
        Select Case NetstatEntry.State
            Case "CLOSE_WAIT"
                txtConnDesc.Text = "Waiting for a connection termination request from the local user."
            Case "CLOSED"
                txtConnDesc.Text = "No connection state at all."
            Case "ESTABLISHED"
                txtConnDesc.Text = "Open connection, data received can be delivered to the user."
            Case "FIN_WAIT_1"
                txtConnDesc.Text = "Waiting for a connection termination request from the remote TCP, or an acknowledgment of the one previously sent."
            Case "FIN_WAIT_2"
                txtConnDesc.Text = "Waiting for a connection termination request from the remote TCP."
            Case "LAST_ACK"
                txtConnDesc.Text = "Waiting for an acknowledgment of the connection termination request previously sent to the remote TCP."
            Case "LISTENING"
                txtConnDesc.Text = "Waiting for a connection request from any remote TCP and port."
            Case "SYN_RECEIVED"
                txtConnDesc.Text = "Waiting for a confirming connection request acknowledgment after having both received and sent a connection request."
            Case "SYN_SENT"
                txtConnDesc.Text = "Waiting for a matching connection request after having sent a connection request."
            Case "TIME_WAIT"
                txtConnDesc.Text = "Waiting for enough time to pass to be sure the remote TCP received the acknowledgment of its connection termination request."
        End Select

        txtPID.Text = NetstatEntry.PID
        txtOwner.Text = NetstatEntry.Owner
        txtTitle.Text = NetstatEntry.WindowTitle

        txtProtocol.SelectionStart = 0
    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Dim strItem As String = Nothing

        strItem += "Protocol: " & txtProtocol.Text & vbCrLf
        strItem += "Local IP: " & txtLocalIP.Text & ":" & txtLocalPort.Text & vbCrLf
        strItem += "Possible Description: " & txtLocalService.Text & vbCrLf
        strItem += "Local Host: " & txtLocalHost.Text & vbCrLf
        strItem += "Remote IP: " & txtRemoteIP.Text & ":" & txtRemotePort.Text & vbCrLf
        strItem += "Possible Description: " & txtRemoteService.Text & vbCrLf
        strItem += "Remote Host: " & txtRemoteHost.Text & vbCrLf
        strItem += "Connection State: " & txtConnection.Text & vbCrLf
        strItem += "Description: " & txtConnDesc.Text & vbCrLf
        strItem += "Process ID: " & txtPID.Text & vbCrLf
        strItem += "Process Owner: " & txtOwner.Text & vbCrLf
        strItem += "Window Title: " & txtTitle.Text

        Clipboard.SetText(strItem)
    End Sub
End Class