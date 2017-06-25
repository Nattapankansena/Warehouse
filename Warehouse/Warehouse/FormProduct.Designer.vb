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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        CType(Me.datagridGoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(582, 17)
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
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(279, 288)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไขสินค้า"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(279, 288)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "ลบสินค้า"
        Me.TabPage3.UseVisualStyleBackColor = True
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

End Class
