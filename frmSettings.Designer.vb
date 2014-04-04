<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Me.NsTheme1 = New Synology_DDSM.NSTheme()
        Me.NsCheckBox1 = New Synology_DDSM.NSCheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NsButton1 = New Synology_DDSM.NSButton()
        Me.txtIP = New Synology_DDSM.NSTextBox()
        Me.btnClose = New Synology_DDSM.NSControlButton()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Synology_DDSM.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsCheckBox1)
        Me.NsTheme1.Controls.Add(Me.Label2)
        Me.NsTheme1.Controls.Add(Me.Label1)
        Me.NsTheme1.Controls.Add(Me.NsButton1)
        Me.NsTheme1.Controls.Add(Me.txtIP)
        Me.NsTheme1.Controls.Add(Me.btnClose)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(235, 141)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Settings"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsCheckBox1
        '
        Me.NsCheckBox1.Checked = False
        Me.NsCheckBox1.Location = New System.Drawing.Point(48, 81)
        Me.NsCheckBox1.Name = "NsCheckBox1"
        Me.NsCheckBox1.Size = New System.Drawing.Size(174, 23)
        Me.NsCheckBox1.TabIndex = 6
        Me.NsCheckBox1.Text = "Enable Automatic Updates"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Created by Cyanlabs"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Synology IP Address:"
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(125, 114)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(97, 23)
        Me.NsButton1.TabIndex = 4
        Me.NsButton1.Text = "Apply Settings"
        '
        'txtIP
        '
        Me.txtIP.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtIP.Location = New System.Drawing.Point(11, 49)
        Me.txtIP.MaxLength = 32767
        Me.txtIP.Multiline = False
        Me.txtIP.Name = "txtIP"
        Me.txtIP.ReadOnly = False
        Me.txtIP.Size = New System.Drawing.Size(212, 23)
        Me.txtIP.TabIndex = 3
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtIP.UseSystemPasswordChar = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ControlButton = Synology_DDSM.NSControlButton.Button.Close
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(211, 3)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.MaximumSize = New System.Drawing.Size(18, 20)
        Me.btnClose.MinimumSize = New System.Drawing.Size(18, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 20)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "NsControlButton1"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 141)
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.TopMost = True
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsTheme1 As Synology_DDSM.NSTheme
    Friend WithEvents txtIP As Synology_DDSM.NSTextBox
    Friend WithEvents btnClose As Synology_DDSM.NSControlButton
    Friend WithEvents NsButton1 As Synology_DDSM.NSButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NsCheckBox1 As Synology_DDSM.NSCheckBox
End Class
