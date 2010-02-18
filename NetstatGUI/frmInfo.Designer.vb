<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfo))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtProtocol = New System.Windows.Forms.TextBox
        Me.txtLocalIP = New System.Windows.Forms.TextBox
        Me.txtLocalPort = New System.Windows.Forms.TextBox
        Me.txtLocalHost = New System.Windows.Forms.TextBox
        Me.txtRemoteIP = New System.Windows.Forms.TextBox
        Me.txtRemotePort = New System.Windows.Forms.TextBox
        Me.txtRemoteHost = New System.Windows.Forms.TextBox
        Me.txtConnection = New System.Windows.Forms.TextBox
        Me.txtPID = New System.Windows.Forms.TextBox
        Me.txtOwner = New System.Windows.Forms.TextBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtLocalService = New System.Windows.Forms.TextBox
        Me.txtRemoteService = New System.Windows.Forms.TextBox
        Me.txtConnDesc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.btnCopy = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Protocol:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Local IP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Local Host:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(14, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Remote Host:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(14, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 12)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Remote IP:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(14, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Connection State:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(14, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Process ID:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 12)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Process Owner:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(14, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 12)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Window Title:"
        '
        'txtProtocol
        '
        Me.txtProtocol.BackColor = System.Drawing.Color.Black
        Me.txtProtocol.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProtocol.ForeColor = System.Drawing.Color.White
        Me.txtProtocol.Location = New System.Drawing.Point(172, 14)
        Me.txtProtocol.Name = "txtProtocol"
        Me.txtProtocol.ReadOnly = True
        Me.txtProtocol.Size = New System.Drawing.Size(300, 19)
        Me.txtProtocol.TabIndex = 11
        '
        'txtLocalIP
        '
        Me.txtLocalIP.BackColor = System.Drawing.Color.Black
        Me.txtLocalIP.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalIP.ForeColor = System.Drawing.Color.White
        Me.txtLocalIP.Location = New System.Drawing.Point(172, 40)
        Me.txtLocalIP.Name = "txtLocalIP"
        Me.txtLocalIP.ReadOnly = True
        Me.txtLocalIP.Size = New System.Drawing.Size(239, 19)
        Me.txtLocalIP.TabIndex = 12
        '
        'txtLocalPort
        '
        Me.txtLocalPort.BackColor = System.Drawing.Color.Black
        Me.txtLocalPort.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalPort.ForeColor = System.Drawing.Color.White
        Me.txtLocalPort.Location = New System.Drawing.Point(417, 40)
        Me.txtLocalPort.Name = "txtLocalPort"
        Me.txtLocalPort.ReadOnly = True
        Me.txtLocalPort.Size = New System.Drawing.Size(55, 19)
        Me.txtLocalPort.TabIndex = 13
        '
        'txtLocalHost
        '
        Me.txtLocalHost.BackColor = System.Drawing.Color.Black
        Me.txtLocalHost.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalHost.ForeColor = System.Drawing.Color.White
        Me.txtLocalHost.Location = New System.Drawing.Point(172, 92)
        Me.txtLocalHost.Name = "txtLocalHost"
        Me.txtLocalHost.ReadOnly = True
        Me.txtLocalHost.Size = New System.Drawing.Size(300, 19)
        Me.txtLocalHost.TabIndex = 14
        '
        'txtRemoteIP
        '
        Me.txtRemoteIP.BackColor = System.Drawing.Color.Black
        Me.txtRemoteIP.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoteIP.ForeColor = System.Drawing.Color.White
        Me.txtRemoteIP.Location = New System.Drawing.Point(172, 118)
        Me.txtRemoteIP.Name = "txtRemoteIP"
        Me.txtRemoteIP.ReadOnly = True
        Me.txtRemoteIP.Size = New System.Drawing.Size(239, 19)
        Me.txtRemoteIP.TabIndex = 15
        '
        'txtRemotePort
        '
        Me.txtRemotePort.BackColor = System.Drawing.Color.Black
        Me.txtRemotePort.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemotePort.ForeColor = System.Drawing.Color.White
        Me.txtRemotePort.Location = New System.Drawing.Point(417, 118)
        Me.txtRemotePort.Name = "txtRemotePort"
        Me.txtRemotePort.ReadOnly = True
        Me.txtRemotePort.Size = New System.Drawing.Size(55, 19)
        Me.txtRemotePort.TabIndex = 16
        '
        'txtRemoteHost
        '
        Me.txtRemoteHost.BackColor = System.Drawing.Color.Black
        Me.txtRemoteHost.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoteHost.ForeColor = System.Drawing.Color.White
        Me.txtRemoteHost.Location = New System.Drawing.Point(172, 170)
        Me.txtRemoteHost.Name = "txtRemoteHost"
        Me.txtRemoteHost.ReadOnly = True
        Me.txtRemoteHost.Size = New System.Drawing.Size(300, 19)
        Me.txtRemoteHost.TabIndex = 17
        '
        'txtConnection
        '
        Me.txtConnection.BackColor = System.Drawing.Color.Black
        Me.txtConnection.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnection.ForeColor = System.Drawing.Color.White
        Me.txtConnection.Location = New System.Drawing.Point(172, 196)
        Me.txtConnection.Name = "txtConnection"
        Me.txtConnection.ReadOnly = True
        Me.txtConnection.Size = New System.Drawing.Size(300, 19)
        Me.txtConnection.TabIndex = 18
        '
        'txtPID
        '
        Me.txtPID.BackColor = System.Drawing.Color.Black
        Me.txtPID.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPID.ForeColor = System.Drawing.Color.White
        Me.txtPID.Location = New System.Drawing.Point(172, 274)
        Me.txtPID.Name = "txtPID"
        Me.txtPID.ReadOnly = True
        Me.txtPID.Size = New System.Drawing.Size(300, 19)
        Me.txtPID.TabIndex = 19
        '
        'txtOwner
        '
        Me.txtOwner.BackColor = System.Drawing.Color.Black
        Me.txtOwner.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOwner.ForeColor = System.Drawing.Color.White
        Me.txtOwner.Location = New System.Drawing.Point(172, 300)
        Me.txtOwner.Name = "txtOwner"
        Me.txtOwner.ReadOnly = True
        Me.txtOwner.Size = New System.Drawing.Size(300, 19)
        Me.txtOwner.TabIndex = 20
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Black
        Me.txtTitle.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.ForeColor = System.Drawing.Color.White
        Me.txtTitle.Location = New System.Drawing.Point(172, 326)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTitle.Size = New System.Drawing.Size(300, 104)
        Me.txtTitle.TabIndex = 21
        '
        'txtLocalService
        '
        Me.txtLocalService.BackColor = System.Drawing.Color.Black
        Me.txtLocalService.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLocalService.ForeColor = System.Drawing.Color.White
        Me.txtLocalService.Location = New System.Drawing.Point(172, 66)
        Me.txtLocalService.Name = "txtLocalService"
        Me.txtLocalService.ReadOnly = True
        Me.txtLocalService.Size = New System.Drawing.Size(300, 19)
        Me.txtLocalService.TabIndex = 22
        '
        'txtRemoteService
        '
        Me.txtRemoteService.BackColor = System.Drawing.Color.Black
        Me.txtRemoteService.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoteService.ForeColor = System.Drawing.Color.White
        Me.txtRemoteService.Location = New System.Drawing.Point(172, 144)
        Me.txtRemoteService.Name = "txtRemoteService"
        Me.txtRemoteService.ReadOnly = True
        Me.txtRemoteService.Size = New System.Drawing.Size(300, 19)
        Me.txtRemoteService.TabIndex = 23
        '
        'txtConnDesc
        '
        Me.txtConnDesc.BackColor = System.Drawing.Color.Black
        Me.txtConnDesc.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnDesc.ForeColor = System.Drawing.Color.White
        Me.txtConnDesc.Location = New System.Drawing.Point(172, 222)
        Me.txtConnDesc.Multiline = True
        Me.txtConnDesc.Name = "txtConnDesc"
        Me.txtConnDesc.ReadOnly = True
        Me.txtConnDesc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtConnDesc.Size = New System.Drawing.Size(300, 46)
        Me.txtConnDesc.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Possible Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 12)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Possible Description:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(14, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 12)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Description:"
        '
        'btnCopy
        '
        Me.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopy.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopy.ForeColor = System.Drawing.Color.White
        Me.btnCopy.Location = New System.Drawing.Point(16, 403)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 27)
        Me.btnCopy.TabIndex = 28
        Me.btnCopy.Text = "&Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'frmInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(487, 446)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtConnDesc)
        Me.Controls.Add(Me.txtRemoteService)
        Me.Controls.Add(Me.txtLocalService)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtOwner)
        Me.Controls.Add(Me.txtPID)
        Me.Controls.Add(Me.txtConnection)
        Me.Controls.Add(Me.txtRemoteHost)
        Me.Controls.Add(Me.txtRemotePort)
        Me.Controls.Add(Me.txtRemoteIP)
        Me.Controls.Add(Me.txtLocalHost)
        Me.Controls.Add(Me.txtLocalPort)
        Me.Controls.Add(Me.txtLocalIP)
        Me.Controls.Add(Me.txtProtocol)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInfo"
        Me.Text = "Netstat Entry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProtocol As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalIP As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalPort As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalHost As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoteIP As System.Windows.Forms.TextBox
    Friend WithEvents txtRemotePort As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoteHost As System.Windows.Forms.TextBox
    Friend WithEvents txtConnection As System.Windows.Forms.TextBox
    Friend WithEvents txtPID As System.Windows.Forms.TextBox
    Friend WithEvents txtOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalService As System.Windows.Forms.TextBox
    Friend WithEvents txtRemoteService As System.Windows.Forms.TextBox
    Friend WithEvents txtConnDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCopy As System.Windows.Forms.Button
End Class
