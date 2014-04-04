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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ntfyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NsTheme1 = New Synology_DDSM.NSTheme()
        Me.imgSSH = New System.Windows.Forms.PictureBox()
        Me.imgSettings = New System.Windows.Forms.PictureBox()
        Me.btnMin = New Synology_DDSM.NSControlButton()
        Me.btnMax = New Synology_DDSM.NSControlButton()
        Me.btnClose = New Synology_DDSM.NSControlButton()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnSSH = New Synology_DDSM.NSButton()
        Me.btnSettings = New Synology_DDSM.NSButton()
        Me.NsTheme1.SuspendLayout()
        CType(Me.imgSSH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ntfyIcon
        '
        Me.ntfyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ntfyIcon.BalloonTipText = "Minimized to system tray"
        Me.ntfyIcon.BalloonTipTitle = "Synology DSM"
        Me.ntfyIcon.Icon = CType(resources.GetObject("ntfyIcon.Icon"), System.Drawing.Icon)
        Me.ntfyIcon.Text = "Synology DSM"
        Me.ntfyIcon.Visible = True
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New Synology_DDSM.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.imgSSH)
        Me.NsTheme1.Controls.Add(Me.imgSettings)
        Me.NsTheme1.Controls.Add(Me.btnMin)
        Me.NsTheme1.Controls.Add(Me.btnMax)
        Me.NsTheme1.Controls.Add(Me.btnClose)
        Me.NsTheme1.Controls.Add(Me.WebBrowser1)
        Me.NsTheme1.Controls.Add(Me.btnSSH)
        Me.NsTheme1.Controls.Add(Me.btnSettings)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.MinimumSize = New System.Drawing.Size(400, 400)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = True
        Me.NsTheme1.Sizable = True
        Me.NsTheme1.Size = New System.Drawing.Size(650, 400)
        Me.NsTheme1.SmartBounds = False
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.NsTheme1.TabIndex = 0
        Me.NsTheme1.Text = "Synology Desktop DSM"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'imgSSH
        '
        Me.imgSSH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgSSH.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.imgSSH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgSSH.Image = Global.Synology_DDSM.My.Resources.Resources.terminal
        Me.imgSSH.Location = New System.Drawing.Point(500, 4)
        Me.imgSSH.Name = "imgSSH"
        Me.imgSSH.Size = New System.Drawing.Size(20, 20)
        Me.imgSSH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSSH.TabIndex = 2
        Me.imgSSH.TabStop = False
        '
        'imgSettings
        '
        Me.imgSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.imgSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgSettings.Image = Global.Synology_DDSM.My.Resources.Resources.cog
        Me.imgSettings.Location = New System.Drawing.Point(417, 4)
        Me.imgSettings.Name = "imgSettings"
        Me.imgSettings.Size = New System.Drawing.Size(22, 20)
        Me.imgSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgSettings.TabIndex = 2
        Me.imgSettings.TabStop = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.ControlButton = Synology_DDSM.NSControlButton.Button.Minimize
        Me.btnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMin.Location = New System.Drawing.Point(590, 4)
        Me.btnMin.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMin.MaximumSize = New System.Drawing.Size(18, 20)
        Me.btnMin.MinimumSize = New System.Drawing.Size(18, 20)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(18, 20)
        Me.btnMin.TabIndex = 1
        Me.btnMin.Text = "NsControlButton1"
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.ControlButton = Synology_DDSM.NSControlButton.Button.MaximizeRestore
        Me.btnMax.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMax.Location = New System.Drawing.Point(608, 4)
        Me.btnMax.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMax.MaximumSize = New System.Drawing.Size(18, 20)
        Me.btnMax.MinimumSize = New System.Drawing.Size(18, 20)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(18, 20)
        Me.btnMax.TabIndex = 1
        Me.btnMax.Text = "NsControlButton1"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.ControlButton = Synology_DDSM.NSControlButton.Button.Close
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(626, 4)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.MaximumSize = New System.Drawing.Size(18, 20)
        Me.btnClose.MinimumSize = New System.Drawing.Size(18, 20)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(18, 20)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "NsControlButton1"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 30)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(644, 367)
        Me.WebBrowser1.TabIndex = 0
        '
        'btnSSH
        '
        Me.btnSSH.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSSH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSSH.Location = New System.Drawing.Point(497, 2)
        Me.btnSSH.Name = "btnSSH"
        Me.btnSSH.Size = New System.Drawing.Size(58, 23)
        Me.btnSSH.TabIndex = 4
        Me.btnSSH.Text = "     SSH"
        '
        'btnSettings
        '
        Me.btnSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.Location = New System.Drawing.Point(414, 2)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(79, 23)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "      Settings"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 400)
        Me.ControlBox = False
        Me.Controls.Add(Me.NsTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.NsTheme1.ResumeLayout(False)
        CType(Me.imgSSH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NsTheme1 As Synology_DDSM.NSTheme
    Friend WithEvents btnMin As Synology_DDSM.NSControlButton
    Friend WithEvents btnMax As Synology_DDSM.NSControlButton
    Friend WithEvents btnClose As Synology_DDSM.NSControlButton
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents imgSettings As System.Windows.Forms.PictureBox
    Friend WithEvents btnSettings As Synology_DDSM.NSButton
    Friend WithEvents imgSSH As System.Windows.Forms.PictureBox
    Friend WithEvents btnSSH As Synology_DDSM.NSButton
    Friend WithEvents ntfyIcon As System.Windows.Forms.NotifyIcon

End Class
