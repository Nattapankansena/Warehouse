Public Class FormProduct


  


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim popupProduct = New PopupProduct("add", "")
        popupProduct.ShowDialog()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Try
            Dim goodId = listView.Items(listView.FocusedItem.Index).SubItems(0).Text()
            Dim popupProduct = New PopupProduct("edit", goodId)
            popupProduct.ShowDialog()
        Catch ex As Exception

        End Try


    End Sub

    
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim goodId = listView.Items(listView.FocusedItem.Index).SubItems(0).Text()


            ' Delete where goodId == goodId
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress

        Dim search = txtSearch.Text.Trim()

        Dim query As String
        query = "Select * from product_tb where goodId Like '%" + search + "%' or goodName Like '%" + search + "%'"

    End Sub
End Class
