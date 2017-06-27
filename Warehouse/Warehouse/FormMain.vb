Public Class FormMain

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            connect_open()
            MsgBox("เชื่อมต่อ DATABASE Pass")
        Catch ex As Exception
            MsgBox("เชื่อมต่อ DATABASE Fail" + ex.ToString)
        End Try
    End Sub

    Private Sub รายละเอยดสนคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายละเอยดสนคาToolStripMenuItem.Click
        FormProduct.Show()
        Me.Hide()
    End Sub

    Private Sub รายละเอยดลกคาToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles รายละเอยดลกคาToolStripMenuItem.Click
        FormCustomer.Show()
        Me.Hide()
    End Sub
End Class