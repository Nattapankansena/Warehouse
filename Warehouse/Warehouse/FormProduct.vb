
Public Class FormProduct

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


        Sql = "insert into GOODS_NAME(Goods_id, Goods_name, cout_unit) values(@id,@name,@cost)"

        cmd = New SqlClient.SqlCommand(Sql, cn)
        cmd.Parameters.Clear()
        'cmd.Parameters.AddWithValue("id", txtAddGoodid.Text)
        'cmd.Parameters.AddWithValue("name", txtAddGoodname.Text)
        'cmd.Parameters.AddWithValue("cost", txtAddcoust.Text)
  
    End Sub


    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connect_open()
            MsgBox("เชื่อมต่อPass")
        Catch ex As Exception
            MsgBox("เชื่อมต่อfail")
        End Try
    End Sub
End Class
