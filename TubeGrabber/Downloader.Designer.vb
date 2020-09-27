<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Downloader
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.rtv = New RegisterWithTreeView(Me.ListView1)

    End Sub
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
    Private rtv As RegisterWithTreeView
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListView1 = New NewListView.ListViewNewEventVb()
        Me.Link = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Name2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DownloadAllButton = New Guna.UI2.WinForms.Guna2Button()
        Me.DownloadSelctedBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UrlAdder = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StatusLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Link, Me.Name2, Me.Time})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(5, 39)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(786, 506)
        Me.ListView1.TabIndex = 17
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Link
        '
        Me.Link.Text = "Link"
        Me.Link.Width = 179
        '
        'Name2
        '
        Me.Name2.DisplayIndex = 2
        Me.Name2.Text = "Title"
        Me.Name2.Width = 201
        '
        'Time
        '
        Me.Time.DisplayIndex = 1
        Me.Time.Text = "Length"
        Me.Time.Width = 158
        '
        'DownloadAllButton
        '
        Me.DownloadAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadAllButton.CheckedState.Parent = Me.DownloadAllButton
        Me.DownloadAllButton.CustomImages.Parent = Me.DownloadAllButton
        Me.DownloadAllButton.Enabled = False
        Me.DownloadAllButton.FillColor = System.Drawing.Color.Red
        Me.DownloadAllButton.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DownloadAllButton.ForeColor = System.Drawing.Color.White
        Me.DownloadAllButton.HoverState.Parent = Me.DownloadAllButton
        Me.DownloadAllButton.Location = New System.Drawing.Point(796, 102)
        Me.DownloadAllButton.Name = "DownloadAllButton"
        Me.DownloadAllButton.ShadowDecoration.Parent = Me.DownloadAllButton
        Me.DownloadAllButton.Size = New System.Drawing.Size(104, 57)
        Me.DownloadAllButton.TabIndex = 16
        Me.DownloadAllButton.Text = "Download all"
        '
        'DownloadSelctedBtn
        '
        Me.DownloadSelctedBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DownloadSelctedBtn.CheckedState.Parent = Me.DownloadSelctedBtn
        Me.DownloadSelctedBtn.CustomImages.Parent = Me.DownloadSelctedBtn
        Me.DownloadSelctedBtn.Enabled = False
        Me.DownloadSelctedBtn.FillColor = System.Drawing.Color.Red
        Me.DownloadSelctedBtn.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DownloadSelctedBtn.ForeColor = System.Drawing.Color.White
        Me.DownloadSelctedBtn.HoverState.Parent = Me.DownloadSelctedBtn
        Me.DownloadSelctedBtn.Location = New System.Drawing.Point(796, 39)
        Me.DownloadSelctedBtn.Name = "DownloadSelctedBtn"
        Me.DownloadSelctedBtn.ShadowDecoration.Parent = Me.DownloadSelctedBtn
        Me.DownloadSelctedBtn.Size = New System.Drawing.Size(104, 57)
        Me.DownloadSelctedBtn.TabIndex = 15
        Me.DownloadSelctedBtn.Text = "Download selected"
        '
        'AddButton
        '
        Me.AddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddButton.CheckedState.Parent = Me.AddButton
        Me.AddButton.CustomImages.Parent = Me.AddButton
        Me.AddButton.FillColor = System.Drawing.Color.Red
        Me.AddButton.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.HoverState.Parent = Me.AddButton
        Me.AddButton.Location = New System.Drawing.Point(796, 4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.ShadowDecoration.Parent = Me.AddButton
        Me.AddButton.Size = New System.Drawing.Size(105, 27)
        Me.AddButton.TabIndex = 14
        Me.AddButton.Text = "Add"
        '
        'UrlAdder
        '
        Me.UrlAdder.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UrlAdder.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UrlAdder.DefaultText = ""
        Me.UrlAdder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UrlAdder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UrlAdder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UrlAdder.DisabledState.Parent = Me.UrlAdder
        Me.UrlAdder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UrlAdder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UrlAdder.FocusedState.Parent = Me.UrlAdder
        Me.UrlAdder.ForeColor = System.Drawing.Color.Black
        Me.UrlAdder.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UrlAdder.HoverState.Parent = Me.UrlAdder
        Me.UrlAdder.Location = New System.Drawing.Point(5, 4)
        Me.UrlAdder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UrlAdder.Name = "UrlAdder"
        Me.UrlAdder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UrlAdder.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UrlAdder.PlaceholderText = "Youtube video url"
        Me.UrlAdder.SelectedText = ""
        Me.UrlAdder.ShadowDecoration.Parent = Me.UrlAdder
        Me.UrlAdder.Size = New System.Drawing.Size(786, 27)
        Me.UrlAdder.TabIndex = 13
        '
        'StatusLabel
        '
        Me.StatusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.StatusLabel.Enabled = False
        Me.StatusLabel.Location = New System.Drawing.Point(796, 165)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(83, 18)
        Me.StatusLabel.TabIndex = 18
        Me.StatusLabel.Text = "Status: Ready"
        '
        'Downloader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(907, 549)
        Me.Controls.Add(Me.StatusLabel)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.DownloadAllButton)
        Me.Controls.Add(Me.DownloadSelctedBtn)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.UrlAdder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Downloader"
        Me.Text = "childtemplate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As NewListView.ListViewNewEventVb
    Friend WithEvents Link As ColumnHeader
    Friend WithEvents Name2 As ColumnHeader
    Friend WithEvents Time As ColumnHeader
    Friend WithEvents DownloadAllButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DownloadSelctedBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UrlAdder As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StatusLabel As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
