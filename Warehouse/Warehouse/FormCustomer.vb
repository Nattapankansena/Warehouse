Public Class FormCustomer
    'ฟังชันแสดงข้องมูลใน DataGridc และทำการ refresh 
    Public Sub refresh_CUS()
        Sql = "select Cus_id, Cus_name from CUS_NAME"
        datagridCus.DataSource = cmd_excuteDataTable()
        chang_dataid_column()
    End Sub

    'ฟังชั่นเปลี่ยนชื่อหัว header
    Public Sub chang_dataid_column()
        Dim column_text() As String = {"รหัสลูกค้า", "รายละเอียดลูกค้า"}
        For i As Integer = 0 To datagridCus.ColumnCount - 1
            datagridCus.Columns(i).HeaderText = column_text(i)
        Next
    End Sub



    'ฟังชั้นล้างค่าในช่องtxt
    Public Sub clear_from()
        txtAddCusId.Text = ""
        txtAddCusName.Text = ""
        txtSearch.Text = ""




    End Sub
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

        Sql = "insert into CUS_NAME(Cus_id, Cus_name) values(@id,@name)"

        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtAddCusId.Text)
        cmd.Parameters.AddWithValue("name", txtAddCusName.Text)

        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("เพิ่มลูกค้าไม่สำเร็จ")
        Else
            MsgBox("เพิ่มลูกค้าสำเร็จ")
            refresh_CUS()
            'chang_dataid_column()
            clear_from()
        End If

    End Sub

    Private Sub FormCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_from()
        refresh_CUS()
        'Try
        '    connect_open()
        '    MsgBox("เชื่อมต่อPass")
        'Catch ex As Exception
        '    MsgBox("เชื่อมต่อfail" + ex.ToString)
        'End Try
    End Sub

    Private Sub datagridCus_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridCus.CellClick
        'กำหนดเพื่อให้รู้ว่าคลิกแถวที่เท่าไรเพื่อที่จะนำไป คิวรี่
        Dim select_row As Integer = datagridCus.CurrentRow.Index
        Dim Cus_id As String = datagridCus.Item(0, select_row).Value
        Sql = "select * from CUS_NAME where Cus_id='" & Cus_id & "'"
        'data_keepจะมีข้อมูลตามที่เราคลิกเลือกใน datagrid
        Dim data_keep As DataTable = cmd_excuteDataTable()

        txtEditCusId.Text = data_keep.Rows(0)("Cus_id")
        txtEditCusName.Text = data_keep.Rows(0)("Cus_name")


        txtDeleteCusId.Text = data_keep.Rows(0)("Cus_id")
        txtDeleteCusName.Text = data_keep.Rows(0)("Cus_name")

    End Sub



    Private Sub datagridCus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagridCus.CellContentClick

    End Sub

    Private Sub btnAddEdit_Click(sender As Object, e As EventArgs) Handles btnAddEdit.Click
        If txtEditCusId.Text = "" Or txtEditCusName.Text = "" Then
            MsgBox("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If
        Sql = "update CUS_NAME set Cus_id=@id, Cus_name=@name where Cus_id=@id"

        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txtEditCusId.Text)
        cmd.Parameters.AddWithValue("name", txtEditCusName.Text)



        If cmd.ExecuteNonQuery = 0 Then
            MsgBox("แก้ค่าไม่สำเร็จ")
        Else
            MsgBox("แก้สำเร็จ")
            refresh_CUS()
            chang_dataid_column()
            clear_from()
        End If

    End Sub

    Private Sub btnAddDelete_Click(sender As Object, e As EventArgs) Handles btnAddDelete.Click
        Dim select_id As Integer = datagridCus.CurrentRow.Index
        Dim Cus_id As String = datagridCus.Item(0, select_id).Value

        'Sql = "delete from GOODS_NAME where Goods_id='" & Goods_id & "'"


        Dim result As Integer = MessageBox.Show("ต้องการลบข้อมูลหรือไม่", "ยืนยัน", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            Return

        ElseIf result = DialogResult.Yes Then
            Sql = "delete from CUS_NAME where Cus_id='" & Cus_id & "'"
            cmd_excuteNonquery()
            refresh_CUS()
            chang_dataid_column()
            clear_from()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Sql = "select Cus_id, Cus_name from CUS_NAME where Cus_id like '%" & txtSearch.Text & "%' or Cus_name like '%" & txtSearch.Text & "%'"
        datagridCus.DataSource = cmd_excuteDataTable()
        chang_dataid_column()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        FormMain.Show()
        Me.Close()
    End Sub
End Class