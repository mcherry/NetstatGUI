<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lstData = New System.Windows.Forms.ListView
        Me.colProtocol = New System.Windows.Forms.ColumnHeader
        Me.colLocalAdd = New System.Windows.Forms.ColumnHeader
        Me.colLocalPort = New System.Windows.Forms.ColumnHeader
        Me.colRemoteAdd = New System.Windows.Forms.ColumnHeader
        Me.colRemotePort = New System.Windows.Forms.ColumnHeader
        Me.colState = New System.Windows.Forms.ColumnHeader
        Me.colPID = New System.Windows.Forms.ColumnHeader
        Me.colOwner = New System.Windows.Forms.ColumnHeader
        Me.colWindowTitle = New System.Windows.Forms.ColumnHeader
        Me.lblBytesRX = New System.Windows.Forms.Label
        Me.lblBytesTX = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUnicastRX = New System.Windows.Forms.Label
        Me.lblUnicastTX = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblNonUniTX = New System.Windows.Forms.Label
        Me.lblNonUniRX = New System.Windows.Forms.Label
        Me.lblDiscardsTX = New System.Windows.Forms.Label
        Me.lblDiscardsRX = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblErrorRX = New System.Windows.Forms.Label
        Me.lblErrorTX = New System.Windows.Forms.Label
        Me.lblUnknown = New System.Windows.Forms.Label
        Me.tmrEthernet = New System.Windows.Forms.Timer(Me.components)
        Me.tmrNetstat = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ctmOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.KillProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.LocalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator
        Me.ResearchPortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator
        Me.NmapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator
        Me.ResearchPortToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.IPWhoisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.TracerouteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PathPingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NslookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListOpenPortsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.stsMain = New System.Windows.Forms.ToolStripStatusLabel
        Me.stsTCP = New System.Windows.Forms.ToolStripStatusLabel
        Me.stsUDP = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EthernetInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.FullReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.btnIPWhois = New System.Windows.Forms.Button
        Me.btnTracert = New System.Windows.Forms.Button
        Me.btnPing = New System.Windows.Forms.Button
        Me.btnNslookup = New System.Windows.Forms.Button
        Me.btnPathPing = New System.Windows.Forms.Button
        Me.btnOther = New System.Windows.Forms.Button
        Me.btnNmap = New System.Windows.Forms.Button
        Me.btnNetsh = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctmOptions.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstData
        '
        Me.lstData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstData.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProtocol, Me.colLocalAdd, Me.colLocalPort, Me.colRemoteAdd, Me.colRemotePort, Me.colState, Me.colPID, Me.colOwner, Me.colWindowTitle})
        Me.lstData.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstData.FullRowSelect = True
        Me.lstData.GridLines = True
        Me.lstData.Location = New System.Drawing.Point(12, 148)
        Me.lstData.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstData.MultiSelect = False
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(860, 266)
        Me.lstData.TabIndex = 0
        Me.lstData.UseCompatibleStateImageBehavior = False
        Me.lstData.View = System.Windows.Forms.View.Details
        '
        'colProtocol
        '
        Me.colProtocol.Text = "Protocol"
        '
        'colLocalAdd
        '
        Me.colLocalAdd.Text = "Local"
        Me.colLocalAdd.Width = 85
        '
        'colLocalPort
        '
        Me.colLocalPort.Text = "Port"
        '
        'colRemoteAdd
        '
        Me.colRemoteAdd.Text = "Remote"
        Me.colRemoteAdd.Width = 97
        '
        'colRemotePort
        '
        Me.colRemotePort.Text = "Port"
        '
        'colState
        '
        Me.colState.Text = "State"
        '
        'colPID
        '
        Me.colPID.Text = "PID"
        '
        'colOwner
        '
        Me.colOwner.Text = "Name"
        '
        'colWindowTitle
        '
        Me.colWindowTitle.Text = "Window Title"
        '
        'lblBytesRX
        '
        Me.lblBytesRX.AutoSize = True
        Me.lblBytesRX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBytesRX.Location = New System.Drawing.Point(89, 0)
        Me.lblBytesRX.Name = "lblBytesRX"
        Me.lblBytesRX.Size = New System.Drawing.Size(54, 12)
        Me.lblBytesRX.TabIndex = 1
        Me.lblBytesRX.Text = "BytesRX"
        '
        'lblBytesTX
        '
        Me.lblBytesTX.AutoSize = True
        Me.lblBytesTX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBytesTX.Location = New System.Drawing.Point(89, 11)
        Me.lblBytesTX.Name = "lblBytesTX"
        Me.lblBytesTX.Size = New System.Drawing.Size(54, 12)
        Me.lblBytesTX.TabIndex = 3
        Me.lblBytesTX.Text = "BytesTX"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unicast:"
        '
        'lblUnicastRX
        '
        Me.lblUnicastRX.AutoSize = True
        Me.lblUnicastRX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnicastRX.Location = New System.Drawing.Point(89, 28)
        Me.lblUnicastRX.Name = "lblUnicastRX"
        Me.lblUnicastRX.Size = New System.Drawing.Size(68, 12)
        Me.lblUnicastRX.TabIndex = 5
        Me.lblUnicastRX.Text = "UnicastRX"
        '
        'lblUnicastTX
        '
        Me.lblUnicastTX.AutoSize = True
        Me.lblUnicastTX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnicastTX.Location = New System.Drawing.Point(89, 39)
        Me.lblUnicastTX.Name = "lblUnicastTX"
        Me.lblUnicastTX.Size = New System.Drawing.Size(68, 12)
        Me.lblUnicastTX.TabIndex = 6
        Me.lblUnicastTX.Text = "UnicastTX"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "RX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 12)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TX"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 12)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "RX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Non-unicast:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-2, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 12)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Discards:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(93, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "TX"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(93, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 12)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "RX"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(93, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 12)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "TX"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(93, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 12)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "RX"
        '
        'lblNonUniTX
        '
        Me.lblNonUniTX.AutoSize = True
        Me.lblNonUniTX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNonUniTX.Location = New System.Drawing.Point(118, 11)
        Me.lblNonUniTX.Name = "lblNonUniTX"
        Me.lblNonUniTX.Size = New System.Drawing.Size(61, 12)
        Me.lblNonUniTX.TabIndex = 18
        Me.lblNonUniTX.Text = "NonUniTX"
        '
        'lblNonUniRX
        '
        Me.lblNonUniRX.AutoSize = True
        Me.lblNonUniRX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNonUniRX.Location = New System.Drawing.Point(118, 0)
        Me.lblNonUniRX.Name = "lblNonUniRX"
        Me.lblNonUniRX.Size = New System.Drawing.Size(61, 12)
        Me.lblNonUniRX.TabIndex = 17
        Me.lblNonUniRX.Text = "NonUniRX"
        '
        'lblDiscardsTX
        '
        Me.lblDiscardsTX.AutoSize = True
        Me.lblDiscardsTX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscardsTX.Location = New System.Drawing.Point(118, 39)
        Me.lblDiscardsTX.Name = "lblDiscardsTX"
        Me.lblDiscardsTX.Size = New System.Drawing.Size(75, 12)
        Me.lblDiscardsTX.TabIndex = 20
        Me.lblDiscardsTX.Text = "DiscardsTX"
        '
        'lblDiscardsRX
        '
        Me.lblDiscardsRX.AutoSize = True
        Me.lblDiscardsRX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscardsRX.Location = New System.Drawing.Point(118, 28)
        Me.lblDiscardsRX.Name = "lblDiscardsRX"
        Me.lblDiscardsRX.Size = New System.Drawing.Size(75, 12)
        Me.lblDiscardsRX.TabIndex = 19
        Me.lblDiscardsRX.Text = "DiscardsRX"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 12)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Errors:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(0, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 12)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Unknown:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(67, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 12)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "TX"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(67, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 12)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "RX"
        '
        'lblErrorRX
        '
        Me.lblErrorRX.AutoSize = True
        Me.lblErrorRX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorRX.Location = New System.Drawing.Point(92, 0)
        Me.lblErrorRX.Name = "lblErrorRX"
        Me.lblErrorRX.Size = New System.Drawing.Size(54, 12)
        Me.lblErrorRX.TabIndex = 25
        Me.lblErrorRX.Text = "ErrorRX"
        '
        'lblErrorTX
        '
        Me.lblErrorTX.AutoSize = True
        Me.lblErrorTX.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorTX.Location = New System.Drawing.Point(92, 11)
        Me.lblErrorTX.Name = "lblErrorTX"
        Me.lblErrorTX.Size = New System.Drawing.Size(54, 12)
        Me.lblErrorTX.TabIndex = 26
        Me.lblErrorTX.Text = "ErrorTX"
        '
        'lblUnknown
        '
        Me.lblUnknown.AutoSize = True
        Me.lblUnknown.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnknown.Location = New System.Drawing.Point(67, 28)
        Me.lblUnknown.Name = "lblUnknown"
        Me.lblUnknown.Size = New System.Drawing.Size(54, 12)
        Me.lblUnknown.TabIndex = 27
        Me.lblUnknown.Text = "Unknown"
        '
        'tmrEthernet
        '
        Me.tmrEthernet.Enabled = True
        Me.tmrEthernet.Interval = 2000
        '
        'tmrNetstat
        '
        Me.tmrNetstat.Enabled = True
        Me.tmrNetstat.Interval = 120000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 27)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(860, 61)
        Me.TableLayoutPanel1.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblBytesRX)
        Me.Panel1.Controls.Add(Me.lblBytesTX)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblUnicastRX)
        Me.Panel1.Controls.Add(Me.lblUnicastTX)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(265, 53)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bytes:"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.lblNonUniRX)
        Me.Panel2.Controls.Add(Me.lblNonUniTX)
        Me.Panel2.Controls.Add(Me.lblDiscardsTX)
        Me.Panel2.Controls.Add(Me.lblDiscardsRX)
        Me.Panel2.Location = New System.Drawing.Point(274, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 53)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.lblUnknown)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.lblErrorTX)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.lblErrorRX)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(545, 4)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(265, 53)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(816, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(41, 53)
        Me.Panel4.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.NetstatGUI.My.Resources.Resources.Button_Refresh_icon
        Me.PictureBox1.Location = New System.Drawing.Point(20, 33)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ctmOptions
        '
        Me.ctmOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessToolStripMenuItem, Me.ToolStripMenuItem1, Me.LocalToolStripMenuItem, Me.RemoteToolStripMenuItem1})
        Me.ctmOptions.Name = "ctmOptions"
        Me.ctmOptions.Size = New System.Drawing.Size(136, 76)
        '
        'ProcessToolStripMenuItem
        '
        Me.ProcessToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResearchToolStripMenuItem, Me.ToolStripMenuItem2, Me.KillProcessToolStripMenuItem})
        Me.ProcessToolStripMenuItem.Name = "ProcessToolStripMenuItem"
        Me.ProcessToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ProcessToolStripMenuItem.Text = "&Process"
        '
        'ResearchToolStripMenuItem
        '
        Me.ResearchToolStripMenuItem.Name = "ResearchToolStripMenuItem"
        Me.ResearchToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ResearchToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ResearchToolStripMenuItem.Text = "&Research"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 6)
        '
        'KillProcessToolStripMenuItem
        '
        Me.KillProcessToolStripMenuItem.Name = "KillProcessToolStripMenuItem"
        Me.KillProcessToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.K), System.Windows.Forms.Keys)
        Me.KillProcessToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.KillProcessToolStripMenuItem.Text = "&Kill"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
        '
        'LocalToolStripMenuItem
        '
        Me.LocalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem1, Me.ToolStripMenuItem9, Me.ResearchPortToolStripMenuItem, Me.ToolStripMenuItem6, Me.NmapToolStripMenuItem})
        Me.LocalToolStripMenuItem.Name = "LocalToolStripMenuItem"
        Me.LocalToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.LocalToolStripMenuItem.Text = "&Local IP"
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.CopyToolStripMenuItem1.Text = "&Copy"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(185, 6)
        '
        'ResearchPortToolStripMenuItem
        '
        Me.ResearchPortToolStripMenuItem.Name = "ResearchPortToolStripMenuItem"
        Me.ResearchPortToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResearchPortToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ResearchPortToolStripMenuItem.Text = "Research &Port"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(185, 6)
        '
        'NmapToolStripMenuItem
        '
        Me.NmapToolStripMenuItem.Name = "NmapToolStripMenuItem"
        Me.NmapToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NmapToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.NmapToolStripMenuItem.Text = "&Nmap"
        '
        'RemoteToolStripMenuItem1
        '
        Me.RemoteToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.ToolStripMenuItem8, Me.ResearchPortToolStripMenuItem1, Me.IPWhoisToolStripMenuItem, Me.ToolStripMenuItem3, Me.TracerouteToolStripMenuItem, Me.PingToolStripMenuItem, Me.PathPingToolStripMenuItem, Me.NslookupToolStripMenuItem, Me.ListOpenPortsToolStripMenuItem})
        Me.RemoteToolStripMenuItem1.Name = "RemoteToolStripMenuItem1"
        Me.RemoteToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.RemoteToolStripMenuItem1.Text = "&Remote IP"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(189, 6)
        '
        'ResearchPortToolStripMenuItem1
        '
        Me.ResearchPortToolStripMenuItem1.Name = "ResearchPortToolStripMenuItem1"
        Me.ResearchPortToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResearchPortToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ResearchPortToolStripMenuItem1.Text = "Research &Port"
        '
        'IPWhoisToolStripMenuItem
        '
        Me.IPWhoisToolStripMenuItem.Name = "IPWhoisToolStripMenuItem"
        Me.IPWhoisToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.IPWhoisToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.IPWhoisToolStripMenuItem.Text = "IP &Whois"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(189, 6)
        '
        'TracerouteToolStripMenuItem
        '
        Me.TracerouteToolStripMenuItem.Name = "TracerouteToolStripMenuItem"
        Me.TracerouteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TracerouteToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.TracerouteToolStripMenuItem.Text = "&Traceroute"
        '
        'PingToolStripMenuItem
        '
        Me.PingToolStripMenuItem.Name = "PingToolStripMenuItem"
        Me.PingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PingToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PingToolStripMenuItem.Text = "P&ing"
        '
        'PathPingToolStripMenuItem
        '
        Me.PathPingToolStripMenuItem.Name = "PathPingToolStripMenuItem"
        Me.PathPingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.PathPingToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.PathPingToolStripMenuItem.Text = "P&ath Ping"
        '
        'NslookupToolStripMenuItem
        '
        Me.NslookupToolStripMenuItem.Name = "NslookupToolStripMenuItem"
        Me.NslookupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.NslookupToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NslookupToolStripMenuItem.Text = "Ns&lookup"
        '
        'ListOpenPortsToolStripMenuItem
        '
        Me.ListOpenPortsToolStripMenuItem.Name = "ListOpenPortsToolStripMenuItem"
        Me.ListOpenPortsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.ListOpenPortsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ListOpenPortsToolStripMenuItem.Text = "N&map"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stsMain, Me.stsTCP, Me.stsUDP})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(884, 22)
        Me.StatusStrip1.TabIndex = 29
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stsMain
        '
        Me.stsMain.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(837, 17)
        Me.stsMain.Spring = True
        Me.stsMain.Text = " "
        Me.stsMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'stsTCP
        '
        Me.stsTCP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stsTCP.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsTCP.Name = "stsTCP"
        Me.stsTCP.Size = New System.Drawing.Size(16, 17)
        Me.stsTCP.Text = " "
        '
        'stsUDP
        '
        Me.stsUDP.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.stsUDP.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stsUDP.Name = "stsUDP"
        Me.stsUDP.Size = New System.Drawing.Size(16, 17)
        Me.stsUDP.Text = " "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(884, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ToolStripMenuItem7, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EthernetInfoToolStripMenuItem, Me.ConnectionListToolStripMenuItem, Me.LogToolStripMenuItem, Me.ToolStripMenuItem4, Me.FullReportToolStripMenuItem})
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'EthernetInfoToolStripMenuItem
        '
        Me.EthernetInfoToolStripMenuItem.Name = "EthernetInfoToolStripMenuItem"
        Me.EthernetInfoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.EthernetInfoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EthernetInfoToolStripMenuItem.Text = "&Ethernet Info"
        '
        'ConnectionListToolStripMenuItem
        '
        Me.ConnectionListToolStripMenuItem.Name = "ConnectionListToolStripMenuItem"
        Me.ConnectionListToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.ConnectionListToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ConnectionListToolStripMenuItem.Text = "&Connection List"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.LogToolStripMenuItem.Text = "&Log"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(198, 6)
        '
        'FullReportToolStripMenuItem
        '
        Me.FullReportToolStripMenuItem.Name = "FullReportToolStripMenuItem"
        Me.FullReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.FullReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FullReportToolStripMenuItem.Text = "&Full Report"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem5, Me.StatisticsToolStripMenuItem})
        Me.ViewToolStripMenuItem.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(163, 6)
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StatisticsToolStripMenuItem.Text = "&Statistics"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'txtLog
        '
        Me.txtLog.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLog.BackColor = System.Drawing.Color.Black
        Me.txtLog.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLog.ForeColor = System.Drawing.Color.White
        Me.txtLog.Location = New System.Drawing.Point(12, 422)
        Me.txtLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(860, 106)
        Me.txtLog.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(860, 50)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tools"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5008!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49955!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49562!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnIPWhois, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnTracert, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPing, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNslookup, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPathPing, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnOther, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNmap, 6, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnNetsh, 5, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(854, 28)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnIPWhois
        '
        Me.btnIPWhois.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIPWhois.Location = New System.Drawing.Point(3, 3)
        Me.btnIPWhois.Name = "btnIPWhois"
        Me.btnIPWhois.Size = New System.Drawing.Size(100, 22)
        Me.btnIPWhois.TabIndex = 0
        Me.btnIPWhois.Text = "IP Whois"
        Me.btnIPWhois.UseVisualStyleBackColor = True
        '
        'btnTracert
        '
        Me.btnTracert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTracert.Location = New System.Drawing.Point(109, 3)
        Me.btnTracert.Name = "btnTracert"
        Me.btnTracert.Size = New System.Drawing.Size(100, 22)
        Me.btnTracert.TabIndex = 1
        Me.btnTracert.Text = "Traceroute"
        Me.btnTracert.UseVisualStyleBackColor = True
        '
        'btnPing
        '
        Me.btnPing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPing.Location = New System.Drawing.Point(215, 3)
        Me.btnPing.Name = "btnPing"
        Me.btnPing.Size = New System.Drawing.Size(100, 22)
        Me.btnPing.TabIndex = 2
        Me.btnPing.Text = "Ping"
        Me.btnPing.UseVisualStyleBackColor = True
        '
        'btnNslookup
        '
        Me.btnNslookup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNslookup.Location = New System.Drawing.Point(427, 3)
        Me.btnNslookup.Name = "btnNslookup"
        Me.btnNslookup.Size = New System.Drawing.Size(100, 22)
        Me.btnNslookup.TabIndex = 3
        Me.btnNslookup.Text = "Nslookup"
        Me.btnNslookup.UseVisualStyleBackColor = True
        '
        'btnPathPing
        '
        Me.btnPathPing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPathPing.Location = New System.Drawing.Point(321, 3)
        Me.btnPathPing.Name = "btnPathPing"
        Me.btnPathPing.Size = New System.Drawing.Size(100, 22)
        Me.btnPathPing.TabIndex = 6
        Me.btnPathPing.Text = "Path Ping"
        Me.btnPathPing.UseVisualStyleBackColor = True
        '
        'btnOther
        '
        Me.btnOther.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOther.Location = New System.Drawing.Point(745, 3)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(106, 22)
        Me.btnOther.TabIndex = 5
        Me.btnOther.Text = "Other..."
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnNmap
        '
        Me.btnNmap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNmap.Location = New System.Drawing.Point(639, 3)
        Me.btnNmap.Name = "btnNmap"
        Me.btnNmap.Size = New System.Drawing.Size(100, 22)
        Me.btnNmap.TabIndex = 4
        Me.btnNmap.Text = "Nmap"
        Me.btnNmap.UseVisualStyleBackColor = True
        '
        'btnNetsh
        '
        Me.btnNetsh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNetsh.Location = New System.Drawing.Point(533, 3)
        Me.btnNetsh.Name = "btnNetsh"
        Me.btnNetsh.Size = New System.Drawing.Size(100, 22)
        Me.btnNetsh.TabIndex = 7
        Me.btnNetsh.Text = "Net Shell"
        Me.btnNetsh.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 562)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtLog)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.Text = "NetstatGUI"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctmOptions.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstData As System.Windows.Forms.ListView
    Friend WithEvents colProtocol As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLocalAdd As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRemoteAdd As System.Windows.Forms.ColumnHeader
    Friend WithEvents colState As System.Windows.Forms.ColumnHeader
    Friend WithEvents colPID As System.Windows.Forms.ColumnHeader
    Friend WithEvents colLocalPort As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRemotePort As System.Windows.Forms.ColumnHeader
    Friend WithEvents colOwner As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblBytesRX As System.Windows.Forms.Label
    Friend WithEvents lblBytesTX As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUnicastRX As System.Windows.Forms.Label
    Friend WithEvents lblUnicastTX As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblNonUniTX As System.Windows.Forms.Label
    Friend WithEvents lblNonUniRX As System.Windows.Forms.Label
    Friend WithEvents lblDiscardsTX As System.Windows.Forms.Label
    Friend WithEvents lblDiscardsRX As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblErrorRX As System.Windows.Forms.Label
    Friend WithEvents lblErrorTX As System.Windows.Forms.Label
    Friend WithEvents lblUnknown As System.Windows.Forms.Label
    Friend WithEvents tmrEthernet As System.Windows.Forms.Timer
    Friend WithEvents tmrNetstat As System.Windows.Forms.Timer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents colWindowTitle As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ctmOptions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents stsMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsTCP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents stsUDP As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LocalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResearchPortToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResearchPortToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IPWhoisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KillProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TracerouteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ListOpenPortsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthernetInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FullReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NmapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NslookupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnIPWhois As System.Windows.Forms.Button
    Friend WithEvents btnTracert As System.Windows.Forms.Button
    Friend WithEvents btnPing As System.Windows.Forms.Button
    Friend WithEvents btnNslookup As System.Windows.Forms.Button
    Friend WithEvents btnNmap As System.Windows.Forms.Button
    Friend WithEvents btnOther As System.Windows.Forms.Button
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnPathPing As System.Windows.Forms.Button
    Friend WithEvents btnNetsh As System.Windows.Forms.Button
    Friend WithEvents PathPingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
