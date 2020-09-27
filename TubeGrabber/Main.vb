Imports System.IO
Imports YoutubeExplode
Imports YoutubeExplode.Videos.Streams
Imports YoutubeExplode.YoutubeClient
Imports System.Configuration
Imports Guna.UI2.WinForms
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices

Public Class Main
    Public ver As String = "0.5.3"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        checkadminrigths()
        Me.TopMost = False
        Guna2HtmlLabel1.Text = "TubeGrabber - " & ver & " - Alpha"
        Me.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size
        Guna2HtmlLabel1.Enabled = False
        If My.Settings.CustomFileLink = 0 Then
            My.Settings.FileLink = KnownFolders.GetPath(KnownFolder.Downloads)
        End If
        startingmenus()
        addForm(Home)
        addForm(Downloader)
        addForm(DownloadSettings)
        addForm(about)
        addForm(Home)
        DefendForSettings()
    End Sub
    Private Sub addForm(ByVal childform As Form)
        If PanelChildForms.Controls.Count > 0 Then
            For Each cont As Control In PanelChildForms.Controls
                If cont.Name = childform.Name Then
                    childform.BringToFront()
                    childform.Show()
                Else
                    childform.Dock = DockStyle.Fill
                    childform.FormBorderStyle = FormBorderStyle.None
                    childform.TopLevel = False
                    PanelChildForms.Tag = childform
                    PanelChildForms.Controls.Add(childform)
                    childform.BringToFront()
                    childform.Show()
                End If
            Next
        Else
            childform.Dock = DockStyle.Fill
            childform.FormBorderStyle = FormBorderStyle.None
            childform.TopLevel = False
            PanelChildForms.Tag = childform
            PanelChildForms.Controls.Add(childform)
            childform.BringToFront()
            childform.Show()
        End If
    End Sub
    Private Sub startingmenus()
        SettingsSubMenu.Visible = False
    End Sub
    Private Sub Hidemenu()
        If SettingsSubMenu.Visible = True Then
            SettingsSubMenu.Visible = False
        End If
    End Sub
    Private Sub ShowMenu(ByVal panel As Guna.UI2.WinForms.Guna2Panel)
        If panel.Visible = True Then
            Hidemenu()
            panel.Visible = False
        Else
            panel.Visible = True
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        For Each b As Control In PanelChildForms.Controls
            If b Is DownloadSettings Then

            End If
        Next
        My.Settings.Save()
        End
    End Sub

    Private Sub MaximizeBtn_Click(sender As Object, e As EventArgs) Handles MaximizeBtn.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        ShowMenu(SettingsSubMenu)
    End Sub

    Private Sub SettingsBtn_DoubleClick(sender As Object, e As EventArgs) Handles SettingsBtn.DoubleClick
        ShowMenu(SettingsSubMenu)
    End Sub

    Private Sub DownloaderBtn_Click(sender As Object, e As EventArgs) Handles DownloaderBtn.Click
        addForm(Downloader)
    End Sub

    Private Sub HomeBtn_Click(sender As Object, e As EventArgs) Handles HomeBtn.Click
        addForm(Home)
    End Sub

    Private Sub DownloadSettingBtn_Click(sender As Object, e As EventArgs) Handles DownloadSettingSubBtn.Click
        addForm(DownloadSettings)
    End Sub
    Private Sub DefendForSettings()
        If My.Settings.CustomFileLink > 1 Or My.Settings.CustomFileLink < 0 Then
            DownloadSettings.ResetSettings()
        ElseIf My.Settings.Use > 3 Or My.Settings.Use < 1 Then
            DownloadSettings.ResetSettings()
        End If
        Try
            Path.GetFullPath(My.Settings.FileLink)
        Catch ex As Exception
            DownloadSettings.ResetSettings()
        End Try
    End Sub

    Private Sub ChangelogBtn_Click(sender As Object, e As EventArgs) Handles ChangelogSubBtn.Click
        addForm(changelog)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles BlueColorButton.Click
        ApplyTheme(Color.Blue)
        Guna2PictureBox1.Image = My.Resources.logoblue
    End Sub
    Public Sub ApplyTheme(ByVal newcolor As Drawing.Color)
        For Each panel As Control In Me.Controls
            If TypeOf (panel) Is Guna.UI2.WinForms.Guna2Panel Then
                For Each panel2 As Control In panel.Controls
                    If TypeOf (panel2) Is Guna.UI2.WinForms.Guna2Button Then
                        Dim button As Guna2Button = panel2
                        If button.Parent Is LeftToolbar Or button.Parent Is ControlPanel Then
                            If Not button.Name.Contains("ColorButton") Then
                                button.FillColor = newcolor
                            End If
                        End If
                    End If
                Next
                If panel.Name = "PanelChildForms" Then
                    For Each panelextra In panel.Controls
                        For Each btn As Control In panelextra.controls
                            If TypeOf (btn) Is Guna2Button Then
                                TryCast(btn, Guna2Button).FillColor = newcolor
                            ElseIf TypeOf (btn) Is Guna2GroupBox Then
                                TryCast(btn, Guna2GroupBox).CustomBorderColor = newcolor
                            End If
                        Next
                    Next
                End If
            End If
        Next
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles GreenColorButton.Click
        ApplyTheme(Color.FromArgb(0, 192, 0))
        Guna2PictureBox1.Image = My.Resources.logogreen
    End Sub
    Private Sub checkadminrigths()
        If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Then

        Else
            MessageBox.Show("Its recommended to run it as adminstartor!!", "Info")
        End If
    End Sub

    Private Sub AboutSettingsSubBtn_Click(sender As Object, e As EventArgs) Handles AboutSettingsSubBtn.Click
        addForm(about)
    End Sub
End Class
