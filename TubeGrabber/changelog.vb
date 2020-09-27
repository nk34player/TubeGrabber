Imports System.Runtime.InteropServices

Public Class changelog
    Dim i As Integer = 0
    Dim j As Integer = 0
    <DllImport("user32")>
    Private Shared Function HideCaret(ByVal hWnd As IntPtr) As Integer
    End Function
    Private Sub changelog_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub changelog_Scroll(sender As Object, e As ScrollEventArgs) Handles Me.Scroll
        ' Guna2TextBox1.ScrollY = Guna2TextBox1.VerticalScroll.Value
    End Sub
End Class