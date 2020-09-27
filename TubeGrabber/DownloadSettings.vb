Imports System.IO
Public Class DownloadSettings
    Dim newfilelink As String = ""
    Dim opf As New FolderBrowserDialog
    Private Sub DownloadSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadsavedconfig()
    End Sub

    Private Sub ChangeBtn_Click(sender As Object, e As EventArgs) Handles ChangeBtn.Click

        If opf.ShowDialog = DialogResult.OK Then
            Try
                newfilelink = opf.SelectedPath
                Guna2TextBox1.Text = newfilelink
            Catch ex As Exception
                MessageBox.Show("Cann't change download folder" + vbNewLine + "Please report it in forums" + vbNewLine + vbNewLine + "LogFile has been created", "Error:02")
                File.WriteAllText(Application.StartupPath & "log.txt", ex.ToString)
            End Try
        End If
    End Sub
    Private Sub reloadsavedconfig()
        If My.Settings.Use = 1 Then
            MP4.Checked = True
            Webm.Checked = False
            MP3.Checked = False
        ElseIf My.Settings.Use = 2 Then
            MP4.Checked = False
            Webm.Checked = True
            MP3.Checked = False
        ElseIf My.Settings.Use = 3 Then
            MP4.Checked = False
            Webm.Checked = False
            MP3.Checked = True
        End If
        If My.Settings.CustomFileLink = 1 Then
            customtrue.Checked = True
        ElseIf My.Settings.CustomFileLink = 0 Then
            customfalse.Checked = True
        End If
        Guna2TextBox1.ReadOnly = True
        Guna2TextBox1.Text = My.Settings.FileLink
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ResetSettings()
    End Sub
    Public Sub ResetSettings()
        Try
            My.Settings.FileLink = KnownFolders.GetPath(KnownFolder.Downloads)
            My.Settings.CustomFileLink = 0
            My.Settings.Use = 3
            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            MessageBox.Show("Can't find downloads folder, the path will be the primary drive", "Error: 03", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If MP4.Checked = True Then
            My.Settings.Use = 1
        ElseIf Webm.Checked = True Then
            My.Settings.Use = 2
        ElseIf MP3.Checked = True Then
            My.Settings.Use = 3
        End If
        If customtrue.Checked = True Then
            My.Settings.CustomFileLink = 1
            If opf.SelectedPath = Nothing Or opf.SelectedPath = "" Or Not Directory.Exists(opf.SelectedPath) Then

            Else
                My.Settings.FileLink = opf.SelectedPath
            End If
        ElseIf customfalse.Checked = True Then
            My.Settings.CustomFileLink = 0
            My.Settings.FileLink = KnownFolders.GetPath(KnownFolder.Downloads)
        End If
        My.Settings.Save()
        My.Settings.Reload()
        reloadsavedconfig()
    End Sub
End Class