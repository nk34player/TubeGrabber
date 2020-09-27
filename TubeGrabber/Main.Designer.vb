<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ControlPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.GreenColorButton = New Guna.UI2.WinForms.Guna2Button()
        Me.BlueColorButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.MinimizeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.MaximizeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.LeftToolbar = New Guna.UI2.WinForms.Guna2Panel()
        Me.SettingsSubMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.AboutSettingsSubBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ChangelogSubBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DownloadSettingSubBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SettingsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DownloaderBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.HomeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelChildForms = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.ControlPanel.SuspendLayout()
        Me.LeftToolbar.SuspendLayout()
        Me.SettingsSubMenu.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ControlPanel
        '
        Me.ControlPanel.BackColor = System.Drawing.Color.Black
        Me.ControlPanel.Controls.Add(Me.GreenColorButton)
        Me.ControlPanel.Controls.Add(Me.BlueColorButton)
        Me.ControlPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.ControlPanel.Controls.Add(Me.MinimizeBtn)
        Me.ControlPanel.Controls.Add(Me.MaximizeBtn)
        Me.ControlPanel.Controls.Add(Me.CloseBtn)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.ControlPanel.FillColor = System.Drawing.Color.Black
        Me.ControlPanel.Location = New System.Drawing.Point(0, 0)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.ShadowDecoration.Parent = Me.ControlPanel
        Me.ControlPanel.Size = New System.Drawing.Size(1037, 34)
        Me.ControlPanel.TabIndex = 0
        '
        'GreenColorButton
        '
        Me.GreenColorButton.CheckedState.Parent = Me.GreenColorButton
        Me.GreenColorButton.CustomImages.Parent = Me.GreenColorButton
        Me.GreenColorButton.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GreenColorButton.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.GreenColorButton.ForeColor = System.Drawing.Color.White
        Me.GreenColorButton.HoverState.Parent = Me.GreenColorButton
        Me.GreenColorButton.Location = New System.Drawing.Point(38, 3)
        Me.GreenColorButton.Name = "GreenColorButton"
        Me.GreenColorButton.ShadowDecoration.Parent = Me.GreenColorButton
        Me.GreenColorButton.Size = New System.Drawing.Size(29, 28)
        Me.GreenColorButton.TabIndex = 10
        Me.GreenColorButton.Text = "G"
        '
        'BlueColorButton
        '
        Me.BlueColorButton.CheckedState.Parent = Me.BlueColorButton
        Me.BlueColorButton.CustomImages.Parent = Me.BlueColorButton
        Me.BlueColorButton.FillColor = System.Drawing.Color.Blue
        Me.BlueColorButton.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BlueColorButton.ForeColor = System.Drawing.Color.White
        Me.BlueColorButton.HoverState.Parent = Me.BlueColorButton
        Me.BlueColorButton.Location = New System.Drawing.Point(3, 3)
        Me.BlueColorButton.Name = "BlueColorButton"
        Me.BlueColorButton.ShadowDecoration.Parent = Me.BlueColorButton
        Me.BlueColorButton.Size = New System.Drawing.Size(29, 28)
        Me.BlueColorButton.TabIndex = 9
        Me.BlueColorButton.Text = "B"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(364, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(301, 28)
        Me.Guna2HtmlLabel1.TabIndex = 8
        Me.Guna2HtmlLabel1.Text = "TubeGrabber - V - Alpha"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeBtn.CheckedState.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.CustomImages.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.FillColor = System.Drawing.Color.Red
        Me.MinimizeBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.MinimizeBtn.ForeColor = System.Drawing.Color.White
        Me.MinimizeBtn.HoverState.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.Location = New System.Drawing.Point(936, 3)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.ShadowDecoration.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.Size = New System.Drawing.Size(29, 28)
        Me.MinimizeBtn.TabIndex = 7
        Me.MinimizeBtn.Text = "_"
        '
        'MaximizeBtn
        '
        Me.MaximizeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaximizeBtn.CheckedState.Parent = Me.MaximizeBtn
        Me.MaximizeBtn.CustomImages.Parent = Me.MaximizeBtn
        Me.MaximizeBtn.FillColor = System.Drawing.Color.Red
        Me.MaximizeBtn.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBtn.ForeColor = System.Drawing.Color.White
        Me.MaximizeBtn.HoverState.Parent = Me.MaximizeBtn
        Me.MaximizeBtn.Location = New System.Drawing.Point(971, 3)
        Me.MaximizeBtn.Name = "MaximizeBtn"
        Me.MaximizeBtn.ShadowDecoration.Parent = Me.MaximizeBtn
        Me.MaximizeBtn.Size = New System.Drawing.Size(29, 28)
        Me.MaximizeBtn.TabIndex = 6
        Me.MaximizeBtn.Text = "□"
        Me.MaximizeBtn.TextOffset = New System.Drawing.Point(0, -4)
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.Red
        Me.CloseBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(1006, 3)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(29, 28)
        Me.CloseBtn.TabIndex = 5
        Me.CloseBtn.Text = "X"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.ControlPanel
        '
        'LeftToolbar
        '
        Me.LeftToolbar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LeftToolbar.Controls.Add(Me.SettingsSubMenu)
        Me.LeftToolbar.Controls.Add(Me.SettingsBtn)
        Me.LeftToolbar.Controls.Add(Me.DownloaderBtn)
        Me.LeftToolbar.Controls.Add(Me.HomeBtn)
        Me.LeftToolbar.Controls.Add(Me.Guna2PictureBox1)
        Me.LeftToolbar.FillColor = System.Drawing.Color.Black
        Me.LeftToolbar.Location = New System.Drawing.Point(0, 33)
        Me.LeftToolbar.Name = "LeftToolbar"
        Me.LeftToolbar.ShadowDecoration.Parent = Me.LeftToolbar
        Me.LeftToolbar.Size = New System.Drawing.Size(129, 549)
        Me.LeftToolbar.TabIndex = 13
        '
        'SettingsSubMenu
        '
        Me.SettingsSubMenu.Controls.Add(Me.AboutSettingsSubBtn)
        Me.SettingsSubMenu.Controls.Add(Me.ChangelogSubBtn)
        Me.SettingsSubMenu.Controls.Add(Me.DownloadSettingSubBtn)
        Me.SettingsSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsSubMenu.FillColor = System.Drawing.Color.Gray
        Me.SettingsSubMenu.Location = New System.Drawing.Point(0, 187)
        Me.SettingsSubMenu.Name = "SettingsSubMenu"
        Me.SettingsSubMenu.ShadowDecoration.Parent = Me.SettingsSubMenu
        Me.SettingsSubMenu.Size = New System.Drawing.Size(129, 88)
        Me.SettingsSubMenu.TabIndex = 18
        '
        'AboutSettingsSubBtn
        '
        Me.AboutSettingsSubBtn.BackColor = System.Drawing.Color.Transparent
        Me.AboutSettingsSubBtn.CheckedState.Parent = Me.AboutSettingsSubBtn
        Me.AboutSettingsSubBtn.CustomImages.Parent = Me.AboutSettingsSubBtn
        Me.AboutSettingsSubBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.AboutSettingsSubBtn.FillColor = System.Drawing.Color.Gray
        Me.AboutSettingsSubBtn.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.AboutSettingsSubBtn.ForeColor = System.Drawing.Color.White
        Me.AboutSettingsSubBtn.HoverState.Parent = Me.AboutSettingsSubBtn
        Me.AboutSettingsSubBtn.Location = New System.Drawing.Point(0, 58)
        Me.AboutSettingsSubBtn.Name = "AboutSettingsSubBtn"
        Me.AboutSettingsSubBtn.ShadowDecoration.Parent = Me.AboutSettingsSubBtn
        Me.AboutSettingsSubBtn.Size = New System.Drawing.Size(129, 29)
        Me.AboutSettingsSubBtn.TabIndex = 21
        Me.AboutSettingsSubBtn.Text = "About"
        Me.AboutSettingsSubBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ChangelogSubBtn
        '
        Me.ChangelogSubBtn.BackColor = System.Drawing.Color.Transparent
        Me.ChangelogSubBtn.CheckedState.Parent = Me.ChangelogSubBtn
        Me.ChangelogSubBtn.CustomImages.Parent = Me.ChangelogSubBtn
        Me.ChangelogSubBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.ChangelogSubBtn.FillColor = System.Drawing.Color.Transparent
        Me.ChangelogSubBtn.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.ChangelogSubBtn.ForeColor = System.Drawing.Color.White
        Me.ChangelogSubBtn.HoverState.Parent = Me.ChangelogSubBtn
        Me.ChangelogSubBtn.Location = New System.Drawing.Point(0, 29)
        Me.ChangelogSubBtn.Name = "ChangelogSubBtn"
        Me.ChangelogSubBtn.ShadowDecoration.Parent = Me.ChangelogSubBtn
        Me.ChangelogSubBtn.Size = New System.Drawing.Size(129, 29)
        Me.ChangelogSubBtn.TabIndex = 20
        Me.ChangelogSubBtn.Text = "Changelog"
        Me.ChangelogSubBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DownloadSettingSubBtn
        '
        Me.DownloadSettingSubBtn.BackColor = System.Drawing.Color.Transparent
        Me.DownloadSettingSubBtn.CheckedState.Parent = Me.DownloadSettingSubBtn
        Me.DownloadSettingSubBtn.CustomImages.Parent = Me.DownloadSettingSubBtn
        Me.DownloadSettingSubBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DownloadSettingSubBtn.FillColor = System.Drawing.Color.Transparent
        Me.DownloadSettingSubBtn.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.DownloadSettingSubBtn.ForeColor = System.Drawing.Color.White
        Me.DownloadSettingSubBtn.HoverState.Parent = Me.DownloadSettingSubBtn
        Me.DownloadSettingSubBtn.Location = New System.Drawing.Point(0, 0)
        Me.DownloadSettingSubBtn.Name = "DownloadSettingSubBtn"
        Me.DownloadSettingSubBtn.ShadowDecoration.Parent = Me.DownloadSettingSubBtn
        Me.DownloadSettingSubBtn.Size = New System.Drawing.Size(129, 29)
        Me.DownloadSettingSubBtn.TabIndex = 19
        Me.DownloadSettingSubBtn.Text = "Downloads"
        Me.DownloadSettingSubBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'SettingsBtn
        '
        Me.SettingsBtn.CheckedState.Parent = Me.SettingsBtn
        Me.SettingsBtn.CustomImages.Parent = Me.SettingsBtn
        Me.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.SettingsBtn.FillColor = System.Drawing.Color.Red
        Me.SettingsBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SettingsBtn.ForeColor = System.Drawing.Color.White
        Me.SettingsBtn.HoverState.Parent = Me.SettingsBtn
        Me.SettingsBtn.Location = New System.Drawing.Point(0, 158)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.ShadowDecoration.Parent = Me.SettingsBtn
        Me.SettingsBtn.Size = New System.Drawing.Size(129, 29)
        Me.SettingsBtn.TabIndex = 17
        Me.SettingsBtn.Text = "Settings"
        '
        'DownloaderBtn
        '
        Me.DownloaderBtn.CheckedState.Parent = Me.DownloaderBtn
        Me.DownloaderBtn.CustomImages.Parent = Me.DownloaderBtn
        Me.DownloaderBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.DownloaderBtn.FillColor = System.Drawing.Color.Red
        Me.DownloaderBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DownloaderBtn.ForeColor = System.Drawing.Color.White
        Me.DownloaderBtn.HoverState.Parent = Me.DownloaderBtn
        Me.DownloaderBtn.Location = New System.Drawing.Point(0, 129)
        Me.DownloaderBtn.Margin = New System.Windows.Forms.Padding(5)
        Me.DownloaderBtn.Name = "DownloaderBtn"
        Me.DownloaderBtn.ShadowDecoration.Parent = Me.DownloaderBtn
        Me.DownloaderBtn.Size = New System.Drawing.Size(129, 29)
        Me.DownloaderBtn.TabIndex = 16
        Me.DownloaderBtn.Text = "Downloader"
        '
        'HomeBtn
        '
        Me.HomeBtn.CheckedState.Parent = Me.HomeBtn
        Me.HomeBtn.CustomImages.Parent = Me.HomeBtn
        Me.HomeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.HomeBtn.FillColor = System.Drawing.Color.Red
        Me.HomeBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.HomeBtn.ForeColor = System.Drawing.Color.White
        Me.HomeBtn.HoverState.Parent = Me.HomeBtn
        Me.HomeBtn.Location = New System.Drawing.Point(0, 100)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.ShadowDecoration.Parent = Me.HomeBtn
        Me.HomeBtn.Size = New System.Drawing.Size(129, 29)
        Me.HomeBtn.TabIndex = 15
        Me.HomeBtn.Text = "Home"
        '
        'PanelChildForms
        '
        Me.PanelChildForms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelChildForms.FillColor = System.Drawing.Color.Transparent
        Me.PanelChildForms.Location = New System.Drawing.Point(129, 33)
        Me.PanelChildForms.Name = "PanelChildForms"
        Me.PanelChildForms.ShadowDecoration.Parent = Me.PanelChildForms
        Me.PanelChildForms.Size = New System.Drawing.Size(907, 549)
        Me.PanelChildForms.TabIndex = 14
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2PictureBox1.Image = Global.TubeGrabber.My.Resources.Resources.logored
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(129, 100)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1037, 582)
        Me.Controls.Add(Me.PanelChildForms)
        Me.Controls.Add(Me.ControlPanel)
        Me.Controls.Add(Me.LeftToolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1037, 582)
        Me.Name = "Main"
        Me.Text = "MP3Youtube"
        Me.ControlPanel.ResumeLayout(False)
        Me.LeftToolbar.ResumeLayout(False)
        Me.SettingsSubMenu.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ControlPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents MinimizeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents MaximizeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents LeftToolbar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents HomeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SettingsSubMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents SettingsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DownloaderBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DownloadSettingSubBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AboutSettingsSubBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ChangelogSubBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelChildForms As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GreenColorButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BlueColorButton As Guna.UI2.WinForms.Guna2Button
End Class
