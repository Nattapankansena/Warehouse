Public Class FormOrder

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub FormOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopupCusId.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PopupCusId.Show()

    End Sub
End Class