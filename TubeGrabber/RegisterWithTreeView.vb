
Public Class RegisterWithTreeView

    Private WithEvents ListViewNewEventVb1 As New NewListView.ListViewNewEventVb()

    Public Sub New(ByVal lv As System.Windows.Forms.ListView)

        Me.ListViewNewEventVb1 = CType(lv, NewListView.ListViewNewEventVb)

    End Sub

    Private Sub ItemAdded(ByVal lvi As System.Windows.Forms.ListViewItem) Handles ListViewNewEventVb1.ItemAdded

        'System.Windows.Forms.MessageBox.Show("Item Added Event caught in Data Access Class for the Item - " & lvi.SubItems(0).Text)

    End Sub

    Private Sub ItemRangeAdded(ByVal lvi As System.Windows.Forms.ListViewItem()) Handles ListViewNewEventVb1.ItemRangeAdded
        Dim item As ListViewItem
        For Each item In lvi
            '  System.Windows.Forms.MessageBox.Show("Item Range Added Event caught in Data Access Class for the Item - " & item.SubItems(0).Text)
        Next

    End Sub

    Private Sub ItemRemoved(ByVal lvi As System.Windows.Forms.ListViewItem) Handles ListViewNewEventVb1.ItemRemoved
        ' System.Windows.Forms.MessageBox.Show("Item Removed Event caught in Data Access Class for the Item - " & lvi.SubItems(0).Text)
    End Sub

    Private Sub ItemRemovedAt(ByVal index As Integer, ByVal lvi As System.Windows.Forms.ListViewItem) Handles ListViewNewEventVb1.ItemRemovedAt
        'System.Windows.Forms.MessageBox.Show("Item RemovedAt  Event caught in Data Access Class for the Item - " + lvi.SubItems(0).Text)
    End Sub


End Class
