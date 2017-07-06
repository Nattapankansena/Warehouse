Public Class FormOrder
    Public Sub clear_from()
        txtAddGoodId.Text = ""
        txtAddGoodName.Text = ""
        txtAddGoodCost.Text = ""
        'DateTimeDocDate.Format = ""
        'DateTimeOrdDate.Format = ""
        'DateTimeFinDate.Format = ""
        txtAmont.Text = ""

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click

    End Sub

    Private Sub FormOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopupCusId.TopMost = True
        PopupCusId.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PopupCusId.Show()

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtAddGoodId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtAddGoodId.TextLength < 10 Then
            MsgBox("กรุณกรอกรหัสลูกค้าให้ครบ 5 หลัก")
        ElseIf txtAddGoodId.TextLength > 10 Then
            MsgBox("กรอกรหัสลูกค้าเกิน 5 หลัก")
            Return
        End If

        Sql = "select * from GOODS_NAME where Goods_id= '" & txtAddGoodId.Text & "' "
        Dim GoodsOrder As DataTable = cmd_excuteDataTable()




        txtAddGoodId.Text = GoodsOrder.Rows(0)("Goods_id")
        txtAddGoodName.Text = GoodsOrder.Rows(0)("Goods_name")
        txtAddGoodCost.Text = GoodsOrder.Rows(0)("cost_unit")



        'Sql = "select * from CUS_NAME where (Goods_id, Goods_name, cost_unit) values(@id,@name,@cost)"

        'cmd = New SqlClient.SqlCommand(Sql, cn)
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("id", txtAddGoodId.Text)
        'cmd.Parameters.AddWithValue("name", txtAddGoodName.Text)
        'cmd.Parameters.AddWithValue("cost", txtAddGoodCost.Text)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSaveOrder_Click(sender As Object, e As EventArgs) Handles btnSaveOrder.Click
        If txtAddGoodId.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtAddGoodId.TextLength < 10 Then
            MsgBox("กรุณกรอกรหัสลูกค้าให้ครบ 5 หลัก")
        ElseIf txtAddGoodId.TextLength > 10 Then
            MsgBox("กรอกรหัสลูกค้าเกิน 5 หลัก")
            Return
        End If

        If Not IsNumeric(txtAmont.Text) Then
            MsgBox("กรุณากรอกจำนวนสินค้าเป็นตัวเลข")
            Return
        End If

        If txtAmont.Text = "" Then
            MsgBox("กรุณากรอกจำนวนสินค้า")
            Return
        End If

        Dim array_item(8) As String
        array_item(0) = ListView1.Items.Count + 1
        array_item(1) = txtAddGoodId.Text
        array_item(2) = txtAddGoodName.Text
        array_item(3) = DateTimeDocDate.Text
        array_item(4) = DateTimeOrdDate.Text

        If chkFinDate.Checked Then
            'array_item(5) = DateTimeFinDate.Value.Date.ToString("yyyy MM dd")
            array_item(5) = DateTimeFinDate.Text
        End If


        array_item(6) = txtAmont.Text
        array_item(7) = txtAddGoodCost.Text
        array_item(8) = array_item(7) * array_item(6)

        Dim itm As New ListViewItem(array_item)
        ListView1.Items.Add(itm)
        clear_from()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        ' Insert Header 
        Dim CusID = lbl_CusId.Text.Trim()
        Sql = "insert into H_ORDER(Cus_id) values (@Cus_id)"
        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("Cus_id", CusID)
        cmd.ExecuteNonQuery()



        ' Select Last Id Header
        Sql = "SELECT TOP (1) [Seq_no] ,[Cus_id]  FROM [H_ORDER]ORDER BY [Seq_no] DESC"
        Dim dts As DataTable = cmd_excuteDataTable()
        Dim lastSeqNo = dts.Rows(0)("Seq_no")




        ' Insert Items
        Dim items = ListView1.Items()
        For Each item As ListViewItem In items

            Dim รหัสสินค้า = item.SubItems(1).Text.Trim()
            Dim วันที่สั่งสินค้า = item.SubItems(3).Text.Trim()
            Dim วันกำหนดส่ง = item.SubItems(4).Text.Trim()

            Dim วันส่งสินค้า
            If String.IsNullOrWhiteSpace(item.SubItems(5).Text.Trim()) = False Then
                วันส่งสินค้า = item.SubItems(5).Text.Trim()
            Else
                วันส่งสินค้า = DBNull.Value
            End If

            Dim จำนวนสั่ง = item.SubItems(6).Text.Trim()


            Sql = "insert into D_ORDER(Seq_no, Goods_id, Doc_date, Ord_date, Fin_date, Amount) values(@Seq,@GoodsId,@DocDate,@OrdDate,@FinDate,@Amount)"
            cmd = New SqlClient.SqlCommand(Sql, cn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("Seq", lastSeqNo)
            cmd.Parameters.AddWithValue("GoodsId", รหัสสินค้า)
            cmd.Parameters.AddWithValue("DocDate", วันที่สั่งสินค้า)
            cmd.Parameters.AddWithValue("OrdDate", วันกำหนดส่ง)
            cmd.Parameters.AddWithValue("FinDate", วันส่งสินค้า)
            cmd.Parameters.AddWithValue("Amount", จำนวนสั่ง)


            If cmd.ExecuteNonQuery = 0 Then
                MsgBox("บันทึกการสั่ง/รับสินค้า ไม่สำเร็จ")
            Else
                MsgBox("บันทึกการสั่ง/รับสิน ค้าสำเร็จ")
                'refresh_CUS()
                'chang_dataid_column()
                clear_from()
            End If

        Next


      

    End Sub

    Private Sub chkFinDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinDate.CheckedChanged
        If chkFinDate.Checked Then
            DateTimeFinDate.Enabled = True
        Else
            DateTimeFinDate.Enabled = False
        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        'If MsgBox("คุณต้องการยกเลิก การขายนี้หรือไม่") = vbNo Then Return
        'ListView1.Items.Clear()

        Dim result As Integer = MessageBox.Show("ต้องการลบ การขายนี้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return

        ElseIf result = DialogResult.Yes Then
            ListView1.Items.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDeleteSelect.Click

        Dim result As Integer = MessageBox.Show("ต้องการลบ รายการที่เลือกนี้หรือไม่", "ยืนยัน", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return

        ElseIf result = DialogResult.Yes Then
            ListView1.Items.Remove(ListView1.FocusedItem)
        End If
    End Sub
End Class