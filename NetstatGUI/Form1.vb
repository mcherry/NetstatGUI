Imports System.IO
Imports System.Runtime.InteropServices

Public Class frmMain
    <DllImport("user32.dll")> _
    Public Shared Function LockWindowUpdate(ByVal hWndLock As IntPtr) As Boolean
    End Function
    '<DllImport("user32.dll")> _
    'Public Shared Function SetFocus(ByVal hwnd As Long) As Long
    'End Function
    'Declare Function PutFocus Lib "user32" Alias "SetFocus" (ByVal hwnd As Long) As Long


    Private boolNmap As Boolean = False
    Private boolTracert As Boolean = False
    Private boolPing As Boolean = False
    Private boolNslookup As Boolean = False
    Private boolPathPing As Boolean = False
    Private boolNetsh As Boolean = False

    Private m_SortingColumn As ColumnHeader


    Private Sub UpdateProcessList()
        Dim NetStats As List(Of NetStat) = New List(Of NetStat)
        Dim lstItem As ListViewItem
        Dim strListLine(9) As String
        Dim intTCPCount As Integer = 0
        Dim intUDPCount As Integer = 0

        LockWindowUpdate(lstData.Handle)
        lstData.Items.Clear()

        NetStats = GetStats()
        For Each item As NetStat In NetStats
            strListLine(0) = item.Protocol
            strListLine(1) = item.LocalAddress
            strListLine(2) = item.LocalPort
            strListLine(3) = item.RemoteAddress
            strListLine(4) = item.RemotePort
            strListLine(5) = item.State
            strListLine(6) = item.PID
            strListLine(7) = item.Owner
            strListLine(8) = item.WindowTitle

            If item.Protocol = "TCP" Then
                intTCPCount += 1
            End If

            If item.Protocol = "UDP" Then
                intUDPCount += 1
            End If

            lstItem = New ListViewItem(strListLine)
            lstData.Items.Add(lstItem)
        Next

        stsMain.Text = lstData.Items.Count.ToString & " total connections"
        stsTCP.Text = intTCPCount.ToString & " TCP"
        stsUDP.Text = intUDPCount.ToString & " UDP"


        ResizeColumns()
        ColorListView()
        LockWindowUpdate(0)
    End Sub

    Private Sub ResizeColumns()
        lstData.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize)
        lstData.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent)
        lstData.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize)
        lstData.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent)
        lstData.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize)
        lstData.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.ColumnContent)
        lstData.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.ColumnContent)
        lstData.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.ColumnContent)
        lstData.AutoResizeColumn(8, ColumnHeaderAutoResizeStyle.ColumnContent)
    End Sub

    Private Sub ColorListView()
        Dim RowColor As Color = Color.White
        Dim RowAlt As Color = Color.FromArgb(237, 237, 237)
        Dim Flag As Integer = 0

        For Each lstRow As ListViewItem In lstData.Items
            If Flag = 0 Then
                lstRow.BackColor = RowColor
                Flag = 1
            Else
                lstRow.BackColor = RowAlt
                Flag = 0
            End If
        Next
    End Sub

    Private Sub UpdateEthernetInfo()
        Dim NetInfo As EthernetInfo = GetEthernetInfo()

        lblBytesRX.Text = FormatNumber(NetInfo.BytesRX)
        lblBytesTX.Text = FormatNumber(NetInfo.BytesTX)

        lblUnicastRX.Text = FormatNumber(NetInfo.UnicastRX)
        lblUnicastTX.Text = FormatNumber(NetInfo.UnicastTX)

        lblNonUniRX.Text = FormatNumber(NetInfo.NonUnicastRX)
        lblNonUniTX.Text = FormatNumber(NetInfo.NonUnicastTX)

        lblDiscardsRX.Text = FormatNumber(NetInfo.DiscardsRX)
        lblDiscardsTX.Text = FormatNumber(NetInfo.DiscardsTX)

        lblErrorRX.Text = FormatNumber(NetInfo.ErrorsRX)
        lblErrorTX.Text = FormatNumber(NetInfo.ErrorsTX)

        lblUnknown.Text = FormatNumber(NetInfo.Unknown)
    End Sub

    Public Sub LogPrint(ByVal strLine As String)
        txtLog.Focus()

        txtLog.Text += strLine & vbCrLf

        ScrollLog()
    End Sub

    Public Sub ScrollLog()
        txtLog.Select(txtLog.Text.Length, 0)
        txtLog.ScrollToCaret()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strPaths() As String = Environment.GetEnvironmentVariable("PATH").Split(";")

        LogPrint("Looking for external tools...")

        For Each strItem As String In strPaths
            If File.Exists(strItem & "\nmap.exe") Then
                LogPrint("Found '" & strItem & "\nmap.exe'")
                boolNmap = True
            End If

            If File.Exists(strItem & "\tracert.exe") Then
                LogPrint("Found '" & strItem & "\tracert.exe'")
                boolTracert = True
            End If

            If File.Exists(strItem & "\ping.exe") Then
                LogPrint("Found '" & strItem & "\ping.exe'")
                boolPing = True
            End If

            If File.Exists(strItem & "\nslookup.exe") Then
                LogPrint("Found '" & strItem & "\nslookup.exe'")
                boolNslookup = True
            End If

            If File.Exists(strItem & "\pathping.exe") Then
                LogPrint("Found '" & strItem & "\pathping.exe'")
                boolPathPing = True
            End If

            If File.Exists(strItem & "\netsh.exe") Then
                LogPrint("Found '" & strItem & "\netsh.exe'")
                boolNetsh = True
            End If
        Next

        If boolNmap = True Then
            ListOpenPortsToolStripMenuItem.Enabled = True
            NmapToolStripMenuItem.Enabled = True
        Else
            ListOpenPortsToolStripMenuItem.Enabled = False
            NmapToolStripMenuItem.Enabled = False
            btnNmap.Enabled = False
            LogPrint("WARNING: 'nmap.exe' was not found in your system path. Port scanning disabled.")
        End If

        If boolTracert = True Then
            TracerouteToolStripMenuItem.Enabled = True
        Else
            TracerouteToolStripMenuItem.Enabled = False
            btnTracert.Enabled = False
            LogPrint("WARNING: 'tracert.exe' was not found in your system path. Trace routing disabled.")
        End If

        If boolPing = True Then
            PingToolStripMenuItem.Enabled = True
        Else
            PingToolStripMenuItem.Enabled = False
            btnPing.Enabled = False
            LogPrint("WARNING: 'ping.exe' was not found in your system path. Pinging disabled.")
        End If

        If boolNslookup = True Then
            NslookupToolStripMenuItem.Enabled = True
        Else
            NslookupToolStripMenuItem.Enabled = False
            btnNslookup.Enabled = False
            LogPrint("WARNING: 'nslookup.exe' was not found in your system path. Nslookup disabled.")
        End If

        If boolPathPing = True Then
            PathPingToolStripMenuItem.Enabled = True
            btnPathPing.Enabled = True
        Else
            PathPingToolStripMenuItem.Enabled = False
            btnPathPing.Enabled = False
            LogPrint("WARNING: 'pathping.exe' was not found in your system path. Pathping disabled.")
        End If

        If boolNetsh = True Then
            btnNetsh.Enabled = True
        Else
            btnNetsh.Enabled = False
            LogPrint("WARNING: 'netsh.exe' was not found in your system path. Net shell disabled.")
        End If

        LogPrint("Loading port information database...")
        LoadPortDB()
        LogPrint("Loaded " & FormatNumber(PortDB.Count) & " records")

        UpdateEthernetInfo()
        UpdateProcessList()
    End Sub

    Private Sub tmrEthernet_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrEthernet.Tick
        UpdateEthernetInfo()
    End Sub

    Private Sub tmrNetstat_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrNetstat.Tick
        UpdateProcessList()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        UpdateProcessList()
    End Sub

    Private Sub lstData_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstData.ColumnClick
        Dim new_sorting_column As ColumnHeader = lstData.Columns(e.Column)

        ' Figure out the new sorting order.
        Dim sort_order As System.Windows.Forms.SortOrder
        If m_SortingColumn Is Nothing Then
            ' New column. Sort ascending.
            sort_order = SortOrder.Ascending
        Else
            ' See if this is the same column.
            If new_sorting_column.Equals(m_SortingColumn) Then
                ' Same column. Switch the sort order.
                If m_SortingColumn.Text.EndsWith(" ▲") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending.
                sort_order = SortOrder.Ascending
            End If

            ' Remove the old sort indicator.
            m_SortingColumn.Text = m_SortingColumn.Text.Substring(0, m_SortingColumn.Text.Length - 2)
        End If

        ' Display the new sort order.
        m_SortingColumn = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            m_SortingColumn.Text = m_SortingColumn.Text & " ▲"
        Else
            m_SortingColumn.Text = m_SortingColumn.Text & " ▼"
        End If

        ' Create a comparer.
        lstData.ListViewItemSorter = New ListViewComparer(e.Column, sort_order)

        ' Sort.
        lstData.Sort()
        ResizeColumns()
        ColorListView()
    End Sub

    Private Sub lstData_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstData.KeyUp
        If (lstData.SelectedItems.Count > 0) Then
            If e.Control AndAlso e.KeyCode.ToString.ToUpper = "C" Then
                CopyToolStripMenuItem_Click(sender, e)
            End If

            If boolPing = True Then
                If e.Control AndAlso e.KeyCode.ToString.ToUpper = "P" Then
                    PingToolStripMenuItem_Click(sender, e)
                End If
            End If

            If boolPathPing = True Then
                If e.Control AndAlso e.KeyCode.ToString.ToUpper = "A" Then
                    PathPingToolStripMenuItem_Click(sender, e)
                End If
            End If

            If boolTracert = True Then
                If e.Control AndAlso e.KeyCode.ToString.ToUpper = "T" Then
                    TracerouteToolStripMenuItem_Click(sender, e)
                End If
            End If

            If boolNslookup = True Then
                If e.Control AndAlso e.KeyCode.ToString.ToUpper = "L" Then
                    NslookupToolStripMenuItem_Click(sender, e)
                End If
            End If

            If e.Control AndAlso e.KeyCode.ToString.ToUpper = "R" Then
                ResearchPortToolStripMenuItem1_Click(sender, e)
            End If

            If e.Control AndAlso e.KeyCode.ToString.ToUpper = "W" Then
                IPWhoisToolStripMenuItem_Click(sender, e)
            End If

            If e.Control AndAlso e.KeyCode.ToString.ToUpper = "O" Then
                ResearchToolStripMenuItem_Click(sender, e)
            End If

            If e.Control AndAlso e.KeyCode.ToString.ToUpper = "K" Then
                KillProcessToolStripMenuItem_Click(sender, e)
            End If

            If boolNmap = True Then
                If e.Control AndAlso e.KeyCode.ToString.ToUpper = "N" Then
                    ListOpenPortsToolStripMenuItem_Click(sender, e)
                End If

                If e.Alt AndAlso e.KeyCode.ToString.ToUpper = "N" Then
                    NmapToolStripMenuItem_Click(sender, e)
                End If
            End If

            If e.Alt AndAlso e.KeyCode.ToString.ToUpper = "R" Then
                ResearchPortToolStripMenuItem_Click(sender, e)
            End If

            If e.Alt AndAlso e.KeyCode.ToString.ToUpper = "C" Then
                CopyToolStripMenuItem1_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lstData_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstData.MouseClick
        If (lstData.SelectedItems.Count > 0) And (e.Button = Windows.Forms.MouseButtons.Right) Then
            ctmOptions.Show(MousePosition.X, MousePosition.Y)
        End If
    End Sub

    Private Sub lstData_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstData.MouseDoubleClick
        If (lstData.SelectedItems.Count > 0) And (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim NetstatEntry As NetStat
            Dim InfoForm As New frmInfo

            With NetstatEntry
                .Protocol = lstData.SelectedItems.Item(0).SubItems(0).Text
                .LocalAddress = lstData.SelectedItems.Item(0).SubItems(1).Text
                .LocalPort = lstData.SelectedItems.Item(0).SubItems(2).Text
                .RemoteAddress = lstData.SelectedItems.Item(0).SubItems(3).Text
                .RemotePort = lstData.SelectedItems.Item(0).SubItems(4).Text
                .State = lstData.SelectedItems.Item(0).SubItems(5).Text
                .PID = lstData.SelectedItems.Item(0).SubItems(6).Text
                .Owner = lstData.SelectedItems.Item(0).SubItems(7).Text
                .WindowTitle = lstData.SelectedItems.Item(0).SubItems(8).Text
            End With

            InfoForm.Init(NetstatEntry)
            InfoForm.Show()
        End If
    End Sub

    Private Sub ResearchPortToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResearchPortToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim strQuery As String = Nothing
            
            strQuery = lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower & " port " & lstData.SelectedItems.Item(0).SubItems(2).Text
            If PortDB.ContainsKey(lstData.SelectedItems.Item(0).SubItems(2).Text & "/" & lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower) Then
                strQuery += " " & PortDB(lstData.SelectedItems.Item(0).SubItems(2).Text & "/" & lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower).Split("|")(0)
            End If

            LogPrint("Researching local port '" & lstData.SelectedItems.Item(0).SubItems(2).Text & "'")
            GoogleSearch(strQuery)
        End If
    End Sub

    Private Sub ResearchPortToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResearchPortToolStripMenuItem1.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim strQuery As String = Nothing

            strQuery = lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower & " port " & lstData.SelectedItems.Item(0).SubItems(4).Text
            If PortDB.ContainsKey(lstData.SelectedItems.Item(0).SubItems(4).Text & "/" & lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower) Then
                strQuery += " " & PortDB(lstData.SelectedItems.Item(0).SubItems(4).Text & "/" & lstData.SelectedItems.Item(0).SubItems(0).Text.ToLower).Split("|")(0)
            End If

            LogPrint("Researching remote port '" & lstData.SelectedItems.Item(0).SubItems(4).Text & "'")
            GoogleSearch(strQuery)
        End If
    End Sub

    Private Sub IPWhoisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IPWhoisToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            LogPrint("Launching IP Whois for '" & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            IPWhoisSearch(lstData.SelectedItems.Item(0).SubItems(3).Text)
        End If
    End Sub

    Private Sub KillProcessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KillProcessToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim NetStatProc As Process = Process.GetProcessById(Int(lstData.SelectedItems.Item(0).SubItems(6).Text))

            Try
                NetStatProc.Kill()
                LogPrint("Killed PID '" & lstData.SelectedItems.Item(0).SubItems(6).Text & "' started by '" & lstData.SelectedItems.Item(0).SubItems(7).Text & "'")
            Catch ex As Exception
                'MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                LogPrint("ERROR: Tried to kill PID '" & lstData.SelectedItems.Item(0).SubItems(6).Text & "' started by '" & lstData.SelectedItems.Item(0).SubItems(7).Text & "'")
                LogPrint("ERROR: " & ex.Message)
            End Try

            UpdateProcessList()
        End If
    End Sub

    Private Sub ResearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResearchToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            LogPrint("Researching process '" & lstData.SelectedItems.Item(0).SubItems(7).Text & "'")
            GoogleSearch("windows process " & lstData.SelectedItems.Item(0).SubItems(7).Text)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub TracerouteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TracerouteToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim Console As New frmConsole

            LogPrint("Launching command 'tracert.exe " & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            Console.Init("tracert.exe", lstData.SelectedItems.Item(0).SubItems(3).Text)
            Console.Show()
        End If
    End Sub

    Private Sub PingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PingToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim Console As New frmConsole

            LogPrint("Launching command 'ping.exe " & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            Console.Init("ping.exe", lstData.SelectedItems.Item(0).SubItems(3).Text)
            Console.Show()
        End If
    End Sub

    Private Sub ListOpenPortsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOpenPortsToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim PortScanner As New frmConsole

            LogPrint("Launching command 'nmap.exe " & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            PortScanner.Init("nmap.exe", lstData.SelectedItems.Item(0).SubItems(3).Text)
            PortScanner.Show()
        End If
    End Sub

    Private Sub StatisticsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatisticsToolStripMenuItem.Click
        Dim Console As New frmConsole

        LogPrint("Launching command 'netstat.exe -s'")
        Console.Init("netstat.exe", "-s")
        Console.Show()
    End Sub

    Private Function GetEthernetStatsFile() As String
        Dim NetInfo As EthernetInfo = GetEthernetInfo()
        Dim strFileContents As String = Nothing

        strFileContents += "Interface Statistics" & vbCrLf & vbCrLf
        strFileContents += "Bytes" & vbTab & vbTab & vbTab & "RX: " & FormatNumber(NetInfo.BytesRX) & vbCrLf
        strFileContents += vbTab & vbTab & vbTab & "TX:" & FormatNumber(NetInfo.BytesTX) & vbCrLf & vbCrLf
        strFileContents += "Unicast Packets" & vbTab & vbTab & "RX: " & FormatNumber(NetInfo.UnicastRX) & vbCrLf
        strFileContents += vbTab & vbTab & vbTab & "TX: " & FormatNumber(NetInfo.UnicastTX) & vbCrLf & vbCrLf
        strFileContents += "Non-unicast Packets" & vbTab & "RX: " & FormatNumber(NetInfo.NonUnicastRX) & vbCrLf
        strFileContents += vbTab & vbTab & vbTab & "TX: " & FormatNumber(NetInfo.NonUnicastTX) & vbCrLf & vbCrLf
        strFileContents += "Discards" & vbTab & vbTab & "RX: " & FormatNumber(NetInfo.DiscardsRX) & vbCrLf
        strFileContents += vbTab & vbTab & vbTab & "TX: " & FormatNumber(NetInfo.DiscardsTX) & vbCrLf & vbCrLf
        strFileContents += "Errors" & vbTab & vbTab & vbTab & "RX: " & FormatNumber(NetInfo.ErrorsRX) & vbCrLf
        strFileContents += vbTab & vbTab & vbTab & "TX: " & FormatNumber(NetInfo.ErrorsTX) & vbCrLf & vbCrLf
        strFileContents += "Unknown Protocols" & vbTab & "RX: " & FormatNumber(NetInfo.Unknown)

        Return strFileContents
    End Function

    Private Sub EthernetInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EthernetInfoToolStripMenuItem.Click
        Dim strFilename As String = GetSaveFilename("Ethernet Info")

        If Not strFilename = Nothing Then
            Dim FileTest As String = WriteFile(GetEthernetStatsFile, strFilename)
            If FileTest = Nothing Then
                LogPrint("Saved Ethernet Info to '" & strFilename & "'")
            Else
                LogPrint("ERROR: Unable to save Ethernet Info")
                LogPrint("ERROR: " & FileTest)
            End If
        End If
    End Sub

    Private Sub LogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogToolStripMenuItem.Click
        Dim strFilename As String = GetSaveFilename("NetstatGUI Log")

        If Not strFilename = Nothing Then
            Dim FileTest As String = WriteFile(txtLog.Text, strFilename)
            If FileTest = Nothing Then
                LogPrint("Saved NetstatGUI Log to '" & strFilename & "'")
            Else
                LogPrint("ERROR: Unable to save NetstatGUI Log")
                LogPrint("ERROR: " & FileTest)
            End If
        End If
    End Sub

    Private Sub FullReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FullReportToolStripMenuItem.Click
        Dim strFilename As String = GetSaveFilename("NetstatGUI Log")

        If Not strFilename = Nothing Then
            Dim FileTest As String = WriteFile(GetEthernetStatsFile() & vbCrLf & vbCrLf & GetConnectionListFile() & vbCrLf & vbCrLf & txtLog.Text, strFilename)
            If FileTest = Nothing Then
                LogPrint("Saved Full Report to '" & strFilename & "'")
            Else
                LogPrint("ERROR: Unable to save Full Report")
                LogPrint("ERROR: " & FileTest)
            End If
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        UpdateEthernetInfo()
        UpdateProcessList()
    End Sub

    Private Sub NmapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmapToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim PortScanner As New frmConsole

            LogPrint("Launching command 'nmap.exe " & lstData.SelectedItems.Item(0).SubItems(1).Text & "'")
            PortScanner.Init("nmap.exe", lstData.SelectedItems.Item(0).SubItems(1).Text)
            PortScanner.Show()
        End If
    End Sub

    Private Function GetConnectionListFile() As String
        Dim NetStats As List(Of NetStat) = New List(Of NetStat)
        Dim intTCPCount As Integer = 0
        Dim intUDPCount As Integer = 0
        Dim strFileContents As String = Nothing

        NetStats = GetStats()
        For Each item As NetStat In NetStats
            strFileContents += item.Protocol & vbTab
            strFileContents += item.LocalAddress
            If item.LocalAddress.Length < 7 Then
                strFileContents += vbTab & vbTab
            Else
                strFileContents += vbTab
            End If

            strFileContents += item.LocalPort & vbTab
            strFileContents += item.RemoteAddress
            If item.RemoteAddress.Length < 7 Then
                strFileContents += vbTab & vbTab
            Else
                strFileContents += vbTab
            End If

            strFileContents += item.RemotePort & vbTab
            strFileContents += item.State & vbTab
            strFileContents += item.PID & vbTab
            strFileContents += item.Owner & vbTab
            strFileContents += item.WindowTitle & vbCrLf

            If item.Protocol = "TCP" Then
                intTCPCount += 1
            End If

            If item.Protocol = "UDP" Then
                intUDPCount += 1
            End If
        Next

        strFileContents += vbCrLf & "TCP Connections: " & intTCPCount.ToString & vbCrLf & "UDP Connections: " & intUDPCount.ToString

        Return strFileContents
    End Function

    Private Sub ConnectionListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectionListToolStripMenuItem.Click
        Dim strFilename As String = GetSaveFilename("Connection List")

        If Not strFilename = Nothing Then
            Dim FileTest As String = WriteFile(GetConnectionListFile(), strFilename)
            If FileTest = Nothing Then
                LogPrint("Saved Connection List to '" & strFilename & "'")
            Else
                LogPrint("ERROR: Unable to save Connection List")
                LogPrint("ERROR: " & FileTest)
            End If
        End If
    End Sub

    Private Sub NslookupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NslookupToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim PortScanner As New frmConsole

            LogPrint("Launching command 'nslookup.exe " & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            PortScanner.Init("nslookup.exe", lstData.SelectedItems.Item(0).SubItems(3).Text)
            PortScanner.Show()
        End If
    End Sub

    Private Sub btnIPWhois_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIPWhois.Click
        Dim strIP As String = InputBox("IP address to query WHOIS:", "IP Whois")
        If Not strIP = "" Then
            LogPrint("Launching IP Whois for '" & strIP & "'")
            IPWhoisSearch(strIP)
        End If
    End Sub

    Private Sub btnOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOther.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("", "", False, True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub btnTracert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTracert.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("tracert.exe", "", True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub btnPing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPing.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("ping.exe", "", True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub btnNslookup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNslookup.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("nslookup.exe", "", False, True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub btnNmap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNmap.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("nmap.exe", "", True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Clipboard.SetText(lstData.SelectedItems.Item(0).SubItems(3).Text)
            LogPrint("Copied remote IP '" & lstData.SelectedItems.Item(0).SubItems(3).Text & "' to the clipboard")
        End If
    End Sub

    Private Sub CopyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem1.Click
        If (lstData.SelectedItems.Count > 0) Then
            Clipboard.SetText(lstData.SelectedItems.Item(0).SubItems(1).Text)
            LogPrint("Copied local IP '" & lstData.SelectedItems.Item(0).SubItems(1).Text & "' to the clipboard")
        End If
    End Sub

    Private Sub PathPingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PathPingToolStripMenuItem.Click
        If (lstData.SelectedItems.Count > 0) Then
            Dim Console As New frmConsole

            LogPrint("Launching command 'pathping.exe " & lstData.SelectedItems.Item(0).SubItems(3).Text & "'")
            Console.Init("pathping.exe", lstData.SelectedItems.Item(0).SubItems(3).Text)
            Console.Show()
        End If
    End Sub

    Private Sub btnPathPing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathPing.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("pathping.exe", "", True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub btnNetsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNetsh.Click
        Dim frmNewCmd As frmLaunchCmd = New frmLaunchCmd

        frmNewCmd.Init("netsh.exe", "", True, True, True)
        frmNewCmd.ShowDialog()
    End Sub

    Private Sub frmMain_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        ScrollLog()
    End Sub
End Class
