Public Class Home

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Home_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Guna2HtmlLabel1.Left = Me.Size.Width / 2.5
        If Me.Size.Width > 907 Then
            Guna2HtmlLabel2.Left = Me.Size.Width / 3.8
        Else
            Guna2HtmlLabel2.Left = Me.Size.Width / 9
        End If

    End Sub
End Class