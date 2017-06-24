Public Class PopupProduct


    Dim _mode As String
    Dim _goodId As String

    Public Sub New(ByVal mode As String, ByVal goodId As String)
        InitializeComponent()
        _mode = mode


        If mode = "edit" Then
            _goodId = goodId
            LoadProduct()
        End If


    End Sub


    Private Sub LoadProduct()

        ' Select * from Product  where goodId = _goodId

        txtGoodID.Text = "0001"
        txtGoodName.Text = "ดินสอ"
        txtCostUnit.Text = "500"

    End Sub


   

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim goodId = txtGoodID.Text.Trim()
        Dim goodName = txtGoodName.Text.Trim()
        Dim costUnit = txtCostUnit.Text.Trim()

        If _mode = "edit" Then
            ' Update To Database
            MsgBox("แก้ไขสินค้า เรียบร้อย")
        Else
            ' Add To Database
            MsgBox("เพิ่มสินค้า เรียบร้อย")
        End If


        Close()

    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class