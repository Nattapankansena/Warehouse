
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
        refresh_Goods()
        Try
            connect_open()
            MsgBox("เชื่อมต่อPass")
        Catch ex As Exception
            MsgBox("เชื่อมต่อfail" + ex.ToString)
        End Try
    End Sub
End Class
