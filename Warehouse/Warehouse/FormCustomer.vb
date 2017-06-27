Public Class FormCustomer

    Private Sub btnAddnew_Click(sender As Object, e As EventArgs) Handles btnAddnew.Click
        If txtAddCusId.Text = "" Or txtAddCusName.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtAddCusId.TextLength < 5 Then
            MsgBox("กรุณกรอกให้ครบ10")
            Return

        End If
        
    End Sub
End Class