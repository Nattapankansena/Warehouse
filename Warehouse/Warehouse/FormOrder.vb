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

        'Sql = "insert into D_ORDER(Seq_no, Goods_id, Doc_date, Ord_date, Fin_date, Amount) values(@Seq,@GoodsId,@DocDate,@OrdDate,@FinDate,@Amount)"

        'cmd = New SqlClient.SqlCommand(Sql, cn)
        'cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("Seq", ColumnHeader1.Text)
        'cmd.Parameters.AddWithValue("GoodsId", ColumnHeader2.Text)
        'cmd.Parameters.AddWithValue("DocDate", ColumnHeader4.Text)
        'cmd.Parameters.AddWithValue("OrdDate", ColumnHeader5.Text)
        'cmd.Parameters.AddWithValue("FinDate", ColumnHeader6.Text)
        'cmd.Parameters.AddWithValue("Amount", ColumnHeader7.Text)

        'If cmd.ExecuteNonQuery = 0 Then
        '    MsgBox("เพิ่มการสั่งไม่สำเร็จ")
        'Else
        '    MsgBox("เพิ่มการสั่งสำเร็จ")

        '    'chang_dataid_column()
        '    clear_from()
        'End If

    End Sub

    Private Sub chkFinDate_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinDate.CheckedChanged
        If chkFinDate.Checked Then
            DateTimeFinDate.Enabled = True
        Else
            DateTimeFinDate.Enabled = False
        End If
    End Sub
End Class