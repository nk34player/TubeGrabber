Imports System.Threading
Public Class DownloadingPrompt
    Public cts As CancellationTokenSource
    Public Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        CancelDownload(cts)
        Me.Hide()
        Me.resetform()
    End Sub
    Public Sub CancelDownload(ctss As CancellationTokenSource)
        If cts IsNot Nothing Then
            cts.Cancel()
        End If
    End Sub
    Public Sub resetform()
        DownloadProgress.Value = 0
        Precentege.Text = "0%"
        VideoTitle.Text = "Video Title"
    End Sub
End Class