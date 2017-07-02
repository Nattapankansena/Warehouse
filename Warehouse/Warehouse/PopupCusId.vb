Public Class PopupCusId

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txtCusId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtCusId.TextLength < 5 Then
            MsgBox("กรุณกรอกรหัสลูกค้าให้ครบ 5 หลัก")
        ElseIf txtCusId.TextLength > 5 Then
            MsgBox("กรอกรหัสลูกค้าเกิน 5 หลัก")
            Return
        End If

        Sql = "select * from CUS_NAME where Cus_id= '" & txtCusId.Text & "'"
        Dim dts As DataTable = cmd_excuteDataTable()




        FormOrder.lbl_CusId.Text = dts.Rows(0)("Cus_id")
        FormOrder.lbl_CusName.Text = dts.Rows(0)("Cus_name")

        FormOrder.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormOrder.Show()
        Close()

    End Sub
End Class