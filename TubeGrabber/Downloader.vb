Imports System.Threading
Imports YoutubeExplode
Imports YoutubeExplode.Videos.Streams
Public Class Downloader
    Dim downloading As Integer = 0
    Private Sub Downloader_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListView1.FullRowSelect = True
    End Sub
    Private Sub LviAdded(ListViewItem) Handles ListView1.ItemAdded
        UrlAdder.Text = ""
        AddButton.Enabled = True
        If ListView1.Items.Count > 1 Then
            DownloadAllButton.Enabled = True
        Else
            DownloadAllButton.Enabled = False
        End If
    End Sub
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim link2 As String = UrlAdder.Text
        UrlAdder.ReadOnly = True
        AddButton.Enabled = False
        addvideoAsync(link2)
    End Sub
    Dim currentrow As Integer = 0
    Dim ytclient As New YoutubeClient
    Private Async Sub addvideoAsync(ByVal link As String)
        Dim add As Integer = 0
        Try
            Dim videotodownload = Await ytclient.Videos.GetAsync(link)
            Dim videotitle = videotodownload.Title
            Dim videolength = videotodownload.Duration
            If ListView1.Items.Count > 0 Then
                For Each b As ListViewItem In ListView1.Items
                    If Not b.Text = link Then
                        add += 1
                    Else
                        MessageBox.Show("The provided link is already added", "Error:04", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        UrlAdder.Text = ""
                        AddButton.Enabled = True
                        Exit For
                    End If
                Next
            End If
            If add = ListView1.Items.Count Then
                createrowAsync(link)
            End If
        Catch ex As Exception
            MessageBox.Show("Unvaild youtube video link", "Error:01", MessageBoxButtons.OK, MessageBoxIcon.Error)
            AddButton.Enabled = True
        End Try
        UrlAdder.ReadOnly = False
    End Sub
    Dim cts As CancellationTokenSource
    Private Async Sub downloadvideo(ByVal link As String)
        downloading = 1
        DownloadSelctedBtn.Enabled = False
        DownloadingPrompt.resetform()
        cts = New CancellationTokenSource()
        Dim use = My.Settings.Use
        Dim videotemp = Await ytclient.Videos.GetAsync(link)
        Dim disabledchar As New List(Of String)({"/", "\", "*", ":", "?", Chr(34), "<", ">", "|"})
        'HERE WHERE THE DOWNLOAD TYPES COMES

#Region "If you want to download it as MP4 (Video)"
        If use = 1 Then
            Dim streamManifest = Await ytclient.Videos.Streams.GetManifestAsync(link)
            Dim streamInfo = streamManifest.GetMuxed.WithHighestVideoQuality()
            If streamInfo IsNot Nothing Then
                cts = New CancellationTokenSource()
                Dim stream = Await ytclient.Videos.Streams.GetAsync(streamInfo)
                Dim progress = New Progress(Of Double)(Function(p)
                                                           Dim value As Integer = p * 100
                                                           DownloadingPrompt.DownloadProgress.Value = value
                                                           Dim value2 As String = $"{p:P0}"
                                                           finisheddownloading(value)
                                                           DownloadingPrompt.DownloadType.Text = "MP4"
                                                           DownloadingPrompt.Precentege.Text = value2
                                                           DownloadingPrompt.VideoTitle.Text = videotemp.Title
                                                           If value = 0 Then
                                                               DownloadingPrompt.Show()
                                                           End If
                                                       End Function)
                Dim oldtitle As String = videotemp.Title
                Dim editedtitle As String
                For Each element In disabledchar
                    If oldtitle.Contains(element) Then
                        oldtitle = oldtitle.Replace(element, "_")
                    End If
                Next
                editedtitle = oldtitle
                DownloadingPrompt.cts = cts
                ' DownloadingPrompt.Show()
                StatusLabel.Text = "Status: Downloading"
                Try
                    Await ytclient.Videos.Streams.DownloadAsync(streamInfo, My.Settings.FileLink & "\" & editedtitle & ".mp4", progress, cts.Token)
                Catch ex As Exception
                    MessageBox.Show("The video/audio had been cancelled", "Error:03", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                downloading = 0
            End If
#End Region
#Region "If you want to download it as WEBM (Video)"
        ElseIf use = 2 Then
            Dim streamManifest = Await ytclient.Videos.Streams.GetManifestAsync(link)
            Dim streamInfo = streamManifest.GetMuxed.WithHighestVideoQuality()
            If streamInfo IsNot Nothing Then
                cts = New CancellationTokenSource()
                Dim stream = Await ytclient.Videos.Streams.GetAsync(streamInfo)
                Dim progress = New Progress(Of Double)(Function(p)
                                                           Dim value As Integer = p * 100
                                                           DownloadingPrompt.DownloadProgress.Value = value
                                                           Dim value2 As String = $"{p:P0}"
                                                           finisheddownloading(value)
                                                           DownloadingPrompt.DownloadType.Text = "WEBM"
                                                           DownloadingPrompt.Precentege.Text = value2
                                                           DownloadingPrompt.VideoTitle.Text = videotemp.Title
                                                           If value = 0 Then
                                                               DownloadingPrompt.Show()
                                                           End If
                                                       End Function)
                Dim oldtitle As String = videotemp.Title
                Dim editedtitle As String
                For Each element In disabledchar
                    If oldtitle.Contains(element) Then
                        oldtitle = oldtitle.Replace(element, "_")
                    End If
                Next
                editedtitle = oldtitle
                'DownloadingPrompt.Show()
                StatusLabel.Text = "Status: Downloading"
                DownloadingPrompt.cts = cts
                Try
                    Await ytclient.Videos.Streams.DownloadAsync(streamInfo, My.Settings.FileLink & "\" & editedtitle & ".webm", progress, cts.Token)
                Catch ex As Exception
                    MessageBox.Show("The video/audio had been cancelled", "Error:03", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
#End Region
#Region "If you want to download it as MP3 (Audio)"
        ElseIf use = 3 Then

            Dim streamManifest = Await ytclient.Videos.Streams.GetManifestAsync(link)
            Dim streamInfo = streamManifest.GetAudioOnly().WithHighestBitrate()


            If streamInfo IsNot Nothing Then
                cts = New CancellationTokenSource()
                Dim stream = Await ytclient.Videos.Streams.GetAsync(streamInfo)
                Dim progress = New Progress(Of Double)(Function(p)
                                                           Dim value As Integer = p * 100
                                                           DownloadingPrompt.DownloadProgress.Value = value
                                                           Dim value2 As String = $"{p:P0}"
                                                           DownloadingPrompt.DownloadType.Text = "MP3"
                                                           finisheddownloading(value)
                                                           DownloadingPrompt.Precentege.Text = value2
                                                           DownloadingPrompt.VideoTitle.Text = videotemp.Title
                                                           If value = 0 Then
                                                               DownloadingPrompt.Show()
                                                           End If
                                                       End Function)
                Dim oldtitle As String = videotemp.Title
                Dim editedtitle As String
                For Each element In disabledchar
                    If oldtitle.Contains(element) Then
                        oldtitle = oldtitle.Replace(element, "_")
                    End If
                Next
                editedtitle = oldtitle
                DownloadingPrompt.TopMost = True
                DownloadingPrompt.StartPosition = FormStartPosition.CenterScreen
                'DownloadingPrompt.Show()
                DownloadingPrompt.cts = cts
                StatusLabel.Text = "Status: Downloading"
                Try
                    Await ytclient.Videos.Streams.DownloadAsync(streamInfo, My.Settings.FileLink & "\" & editedtitle & ".mp3", progress, cts.Token)
                Catch ex As Exception
                    MessageBox.Show("The video/audio had been cancelled", "Error:03", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
#End Region
            downloading = 0
        End If
    End Sub
    Private Sub DownloadSelectedBtn_Click(sender As Object, e As EventArgs) Handles DownloadSelctedBtn.Click
        If ListView1.SelectedItems.Count > 0 Then
            downloadvideo(ListView1.SelectedItems(0).Text)
        End If
    End Sub
    Private Sub finisheddownloading(ByVal value As Integer)
        If value = 100 Then
            DownloadSelctedBtn.Enabled = True
            DownloadingPrompt.Hide()
            StatusLabel.Text = "Status: Finished downloading"
            Thread.Sleep(300)
            StatusLabel.Text = "Status : Ready"
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            If DownloadingPrompt.Visible = True Or downloading = 1 Then
                DownloadSelctedBtn.Enabled = False
            Else
                DownloadSelctedBtn.Enabled = True
            End If
        Else
            DownloadSelctedBtn.Enabled = False
        End If
    End Sub

    Private Sub Downloader_Click(sender As Object, e As EventArgs) Handles Me.Click
        If DownloadingPrompt.Visible = True Then
            DownloadingPrompt.BringToFront()
        Else

        End If

    End Sub
    Private Async Sub createrowAsync(ByVal link As String)
        Dim videotodownload = Await ytclient.Videos.GetAsync(link)
        Dim videotitle = videotodownload.Title
        Dim videolength = videotodownload.Duration
        Dim vi As New ListViewItem(link)
        ListView1.Items.Add(vi)
        ListView1.Items(currentrow).SubItems.Add(videotitle)
        ListView1.Items(currentrow).SubItems.Add(videolength.ToString)
        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        currentrow += 1
    End Sub
End Class