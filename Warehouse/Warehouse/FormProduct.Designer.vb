<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.datagridGoods = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnAddnew = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddcoust = New System.Windows.Forms.TextBox()
        Me.txtAddGoodname = New System.Windows.Forms.TextBox()
        Me.txtAddGoodid = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAddEdit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEditcoust = New System.Windows.Forms.TextBox()
        Me.txtEditGoodname = New System.Windows.Forms.TextBox()
        Me.txtEditGoodid = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnAddDelete = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDeletecost = New System.Windows.Forms.TextBox()
        Me.txtDeleteGoodname = New System.Windows.Forms.TextBox()
        Me.txtDeleteGoodid = New System.Windows.Forms.TextBox()
        CType(Me.datagridGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(670, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "ออก"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(73, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(346, 20)
        Me.txtSearch.TabIndex = 5
        '
        'datagridGoods
        '
        Me.datagridGoods.AllowUserToAddRows = False
        Me.datagridGoods.AllowUserToDeleteRows = False
        Me.datagridGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridGoods.Location = New System.Drawing.Point(12, 62)
        Me.datagridGoods.Name = "datagridGoods"
        Me.datagridGoods.ReadOnly = True
        Me.datagridGoods.RowHeadersWidth = 20
        Me.datagridGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridGoods.Size = New System.Drawing.Size(444, 310)
        Me.datagridGoods.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Search"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(462, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(287, 314)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnAddnew)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtAddcoust)
        Me.TabPage1.Controls.Add(Me.txtAddGoodname)
        Me.TabPage1.Controls.Add(Me.txtAddGoodid)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(279, 288)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่มสินค้า"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAddnew
        '
        Me.btnAddnew.Location = New System.Drawing.Point(142, 246)
        Me.btnAddnew.Name = "btnAddnew"
        Me.btnAddnew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddnew.TabIndex = 9
        Me.btnAddnew.Text = "บันทึก"
        Me.btnAddnew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ราคา/หน่วยสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "รายละเอียดสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "รหัสสินค้า"
        '
        'txtAddcoust
        '
        Me.txtAddcoust.Location = New System.Drawing.Point(116, 198)
        Me.txtAddcoust.Name = "txtAddcoust"
        Me.txtAddcoust.Size = New System.Drawing.Size(124, 20)
        Me.txtAddcoust.TabIndex = 2
        '
        'txtAddGoodname
        '
        Me.txtAddGoodname.Location = New System.Drawing.Point(116, 74)
        Me.txtAddGoodname.Multiline = True
        Me.txtAddGoodname.Name = "txtAddGoodname"
        Me.txtAddGoodname.Size = New System.Drawing.Size(124, 106)
        Me.txtAddGoodname.TabIndex = 1
        '
        'txtAddGoodid
        '
        Me.txtAddGoodid.Location = New System.Drawing.Point(116, 30)
        Me.txtAddGoodid.Name = "txtAddGoodid"
        Me.txtAddGoodid.Size = New System.Drawing.Size(124, 20)
        Me.txtAddGoodid.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAddEdit)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtEditcoust)
        Me.TabPage2.Controls.Add(Me.txtEditGoodname)
        Me.TabPage2.Controls.Add(Me.txtEditGoodid)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(279, 288)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขสินค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAddEdit
        '
        Me.btnAddEdit.Location = New System.Drawing.Point(142, 250)
        Me.btnAddEdit.Name = "btnAddEdit"
        Me.btnAddEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnAddEdit.TabIndex = 16
        Me.btnAddEdit.Text = "แก้ไข"
        Me.btnAddEdit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "ราคา/หน่วยสินค้า"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "รายละเอียดสินค้า"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(47, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "รหัสสินค้า"
        '
        'txtEditcoust
        '
        Me.txtEditcoust.Location = New System.Drawing.Point(116, 202)
        Me.txtEditcoust.Name = "txtEditcoust"
        Me.txtEditcoust.Size = New System.Drawing.Size(124, 20)
        Me.txtEditcoust.TabIndex = 12
        '
        'txtEditGoodname
        '
        Me.txtEditGoodname.Location = New System.Drawing.Point(116, 78)
        Me.txtEditGoodname.Multiline = True
        Me.txtEditGoodname.Name = "txtEditGoodname"
        Me.txtEditGoodname.Size = New System.Drawing.Size(124, 106)
        Me.txtEditGoodname.TabIndex = 11
        '
        'txtEditGoodid
        '
        Me.txtEditGoodid.Location = New System.Drawing.Point(116, 34)
        Me.txtEditGoodid.Name = "txtEditGoodid"
        Me.txtEditGoodid.ReadOnly = True
        Me.txtEditGoodid.Size = New System.Drawing.Size(124, 20)
        Me.txtEditGoodid.TabIndex = 10
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAddDelete)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.txtDeletecost)
        Me.TabPage3.Controls.Add(Me.txtDeleteGoodname)
        Me.TabPage3.Controls.Add(Me.txtDeleteGoodid)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(279, 288)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบสินค้า"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAddDelete
        '
        Me.btnAddDelete.Location = New System.Drawing.Point(142, 243)
        Me.btnAddDelete.Name = "btnAddDelete"
        Me.btnAddDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnAddDelete.TabIndex = 23
        Me.btnAddDelete.Text = "ลบ"
        Me.btnAddDelete.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "ราคา/หน่วยสินค้า"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "รายละเอียดสินค้า"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "รหัสสินค้า"
        '
        'txtDeletecost
        '
        Me.txtDeletecost.Location = New System.Drawing.Point(116, 195)
        Me.txtDeletecost.Name = "txtDeletecost"
        Me.txtDeletecost.ReadOnly = True
        Me.txtDeletecost.Size = New System.Drawing.Size(124, 20)
        Me.txtDeletecost.TabIndex = 19
        '
        'txtDeleteGoodname
        '
        Me.txtDeleteGoodname.Location = New System.Drawing.Point(116, 71)
        Me.txtDeleteGoodname.Multiline = True
        Me.txtDeleteGoodname.Name = "txtDeleteGoodname"
        Me.txtDeleteGoodname.ReadOnly = True
        Me.txtDeleteGoodname.Size = New System.Drawing.Size(124, 106)
        Me.txtDeleteGoodname.TabIndex = 18
        '
        'txtDeleteGoodid
        '
        Me.txtDeleteGoodid.Location = New System.Drawing.Point(116, 27)
        Me.txtDeleteGoodid.Name = "txtDeleteGoodid"
        Me.txtDeleteGoodid.ReadOnly = True
        Me.txtDeleteGoodid.Size = New System.Drawing.Size(124, 20)
        Me.txtDeleteGoodid.TabIndex = 17
        '
        'FormProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 391)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.datagridGoods)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "FormProduct"
        Me.Text = "สินค้า"
        CType(Me.datagridGoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents datagridGoods As System.Windows.Forms.DataGridView


    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAddcoust As System.Windows.Forms.TextBox
    Friend WithEvents txtAddGoodname As System.Windows.Forms.TextBox
    Friend WithEvents txtAddGoodid As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnAddnew As System.Windows.Forms.Button
    Friend WithEvents btnAddEdit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEditcoust As System.Windows.Forms.TextBox
    Friend WithEvents txtEditGoodname As System.Windows.Forms.TextBox
    Friend WithEvents txtEditGoodid As System.Windows.Forms.TextBox
    Friend WithEvents btnAddDelete As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDeletecost As System.Windows.Forms.TextBox
    Friend WithEvents txtDeleteGoodname As System.Windows.Forms.TextBox
    Friend WithEvents txtDeleteGoodid As System.Windows.Forms.TextBox

End Class
