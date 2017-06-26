
Public Class FormProduct

    'ฟังชันแสดงข้องมูลใน DataGridc และทำการ refresh 
    Public Sub refresh_Goods()
        Sql = "select Goods_id, Goods_name, Cost_Unit from GOODS_NAME"
        datagridGoods.DataSource = cmd_excuteDataTable()
        chang_dataid_column()
    End Sub

    'ฟังชั่นเปลี่ยนชื่อหัว header
    Public Sub chang_dataid_column()
        Dim column_text() As String = {"รหัสสินค้า", "รายละเอียดสินค้า", "ราคาต่อหน่วยสินค้า"}
        For i As Integer = 0 To datagridGoods.ColumnCount - 1
            datagridGoods.Columns(i).HeaderText = column_text(i)
        Next
    End Sub

    'ฟังชั้นล้างค่าในช่องtxt
    Public Sub clear_from()
        txtAddGoodid.Text = ""
        txtAddGoodname.Text = ""
        txtAddcoust.Text = ""
        txtSearch.Text = ""

        txtDeleteGoodid.Text = ""
        txtDeleteGoodname.Text = ""
        txtDeletecost.Text = ""



    End Sub

    Private Sub btnAddnew_Click(sender As Object, e As EventArgs) Handles btnAddnew.Click
        If txtAddGoodid.Text = "" Or txtAddGoodname.Text = "" Or txtAddcoust.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        If txtAddGoodid.TextLength < 10 Then
            MsgBox("กรุณกรอกให้ครบ10")
            Return

        End If
        If Not IsNumeric(txtAddcoust.Text) Then
            MsgBox("กรุณกรอกตัวเลข")
            Return
        End If


        Sql = "insert into GOODS_NAME(Goods_id, Goods_name, cost_unit) values(@id,@name,@cost)"

        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtAddGoodid.Text)
        cmd.Parameters.AddWithValue("name", txtAddGoodname.Text)
        cmd.Parameters.AddWithValue("cost", txtAddcoust.Text)


        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("เพิ่มค่าไม่สำเร็จ")
        Else
            MsgBox("เพิ่มสำเร็จ")
            refresh_Goods()
            chang_dataid_column()
            clear_from()
        End If
        'cmd.ExecuteNonQuery()

    End Sub


    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'refresh_Goods()
        'Try
        '    connect_open()
        '    MsgBox("เชื่อมต่อPass")
        'Catch ex As Exception
        '    MsgBox("เชื่อมต่อfail" + ex.ToString)
        'End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Sql = "select Goods_id, Goods_name, cost_unit from GOODS_NAME where Goods_id like '%" & txtSearch.Text & "%' or Goods_name like '%" & txtSearch.Text & "%' or cost_unit like '%" & txtSearch.Text & "%' "
        datagridGoods.DataSource = cmd_excuteDataTable()
        chang_dataid_column()
    End Sub

    Private Sub datagridGoods_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridGoods.CellClick
        'กำหนดเพื่อให้รู้ว่าคลิกแถวที่เท่าไรเพื่อที่จะนำไป คิวรี่
        Dim select_row As Integer = datagridGoods.CurrentRow.Index
        Dim Goods_id As String = datagridGoods.Item(0, select_row).Value
        Sql = "select * from GOODS_NAME where Goods_id='" & Goods_id & "'"
        'data_keepจะมีข้อมูลตามที่เราคลิกเลือกใน datagrid
        Dim data_keep As DataTable = cmd_excuteDataTable()

        txtEditGoodid.Text = data_keep.Rows(0)("Goods_id")
        txtEditGoodname.Text = data_keep.Rows(0)("Goods_name")
        txtEditcoust.Text = data_keep.Rows(0)("cost_unit")


        txtDeleteGoodid.Text = data_keep.Rows(0)("Goods_id")
        txtDeleteGoodname.Text = data_keep.Rows(0)("Goods_name")
        txtDeletecost.Text = data_keep.Rows(0)("cost_unit")


    End Sub

   

    Private Sub btnAddEdit_Click(sender As Object, e As EventArgs) Handles btnAddEdit.Click
        If txtEditGoodname.Text = "" Or txtEditcoust.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If



        If Not IsNumeric(txtEditcoust.Text) Then
            MsgBox("กรุณกรอกตัวเลข")
            Return
        End If

        Sql = "update GOODS_NAME set Goods_id=@id, Goods_name=@name, cost_unit=@cost where Goods_id=@id"


        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtEditGoodid.Text)
        cmd.Parameters.AddWithValue("name", txtEditGoodname.Text)
        cmd.Parameters.AddWithValue("cost", txtEditcoust.Text)


        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("แก้ค่าไม่สำเร็จ")
        Else
            MsgBox("แก้สำเร็จ")
            refresh_Goods()
            chang_dataid_column()
            clear_from()
        End If


    End Sub

    Private Sub btnAddDelete_Click(sender As Object, e As EventArgs) Handles btnAddDelete.Click
        Dim select_id As Integer = datagridGoods.CurrentRow.Index
        Dim Goods_id As String = datagridGoods.Item(0, select_id).Value

        'Sql = "delete from GOODS_NAME where Goods_id='" & Goods_id & "'"


        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return

        ElseIf result = DialogResult.Yes Then
            Sql = "delete from GOODS_NAME where Goods_id='" & Goods_id & "'"
            cmd_excuteNonquery()
            refresh_Goods()
            chang_dataid_column()
            clear_from()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormMain.Show()
        Me.Close()

    End Sub
End Class
