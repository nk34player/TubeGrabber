<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadingPrompt
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.DownloadProgress = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Precentege = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VideoTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DownloadType = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'DownloadProgress
        '
        Me.DownloadProgress.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.DownloadProgress.Location = New System.Drawing.Point(12, 12)
        Me.DownloadProgress.Name = "DownloadProgress"
        Me.DownloadProgress.ShadowDecoration.Parent = Me.DownloadProgress
        Me.DownloadProgress.Size = New System.Drawing.Size(625, 30)
        Me.DownloadProgress.TabIndex = 19
        Me.DownloadProgress.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Precentege
        '
        Me.Precentege.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Precentege.BackColor = System.Drawing.Color.Transparent
        Me.Precentege.Enabled = False
        Me.Precentege.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Precentege.Location = New System.Drawing.Point(506, 104)
        Me.Precentege.Name = "Precentege"
        Me.Precentege.Size = New System.Drawing.Size(20, 22)
        Me.Precentege.TabIndex = 20
        Me.Precentege.Text = "0%"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Enabled = False
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 48)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(172, 28)
        Me.Guna2HtmlLabel2.TabIndex = 21
        Me.Guna2HtmlLabel2.Text = "Downloading info:"
        '
        'VideoTitle
        '
        Me.VideoTitle.BackColor = System.Drawing.Color.Transparent
        Me.VideoTitle.Enabled = False
        Me.VideoTitle.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VideoTitle.Location = New System.Drawing.Point(12, 79)
        Me.VideoTitle.Name = "VideoTitle"
        Me.VideoTitle.Size = New System.Drawing.Size(69, 20)
        Me.VideoTitle.TabIndex = 22
        Me.VideoTitle.Text = "Video Title"
        '
        'CancelBtn
        '
        Me.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.CancelBtn.FillColor = System.Drawing.Color.DarkGray
        Me.CancelBtn.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(532, 103)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(105, 27)
        Me.CancelBtn.TabIndex = 23
        Me.CancelBtn.Text = "Cancel"
        '
        'DownloadType
        '
        Me.DownloadType.BackColor = System.Drawing.Color.Transparent
        Me.DownloadType.Enabled = False
        Me.DownloadType.Font = New System.Drawing.Font("Trebuchet MS", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DownloadType.Location = New System.Drawing.Point(12, 111)
        Me.DownloadType.Name = "DownloadType"
        Me.DownloadType.Size = New System.Drawing.Size(96, 20)
        Me.DownloadType.TabIndex = 24
        Me.DownloadType.Text = "Download Type"
        '
        'DownloadingPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(649, 143)
        Me.Controls.Add(Me.DownloadType)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.VideoTitle)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Precentege)
        Me.Controls.Add(Me.DownloadProgress)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DownloadingPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DownloadingPrompt"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents DownloadProgress As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Precentege As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents VideoTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DownloadType As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
