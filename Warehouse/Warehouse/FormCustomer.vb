Public Class FormCustomer

    Private Sub btnAddnew_Click(sender As Object, e As EventArgs) Handles btnAddnew.Click
        If txtAddCusId.Text = "" Or txtAddCusName.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtAddCusId.TextLength < 5 Then
            MsgBox("กรุณกรอกรหัสลูกค้าให้ครบ 5 หลัก")
        ElseIf txtAddCusId.TextLength > 5 Then
            MsgBox("กรอกรหัสลูกค้าเกิน 5 หลัก")
            Return

        End If
        
    End Sub
End Class