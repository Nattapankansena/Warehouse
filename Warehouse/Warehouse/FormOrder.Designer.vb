<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormOrder
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_CusId = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_CusName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddGoodId = New System.Windows.Forms.TextBox()
        Me.txtAddGoodName = New System.Windows.Forms.TextBox()
        Me.txtAddGoodCost = New System.Windows.Forms.TextBox()
        Me.DateTimeDocDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeOrdDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimeFinDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAmont = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.txtProces = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Dock = System.Windows.Forms.DockStyle.Top
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_CusId, Me.ToolStripStatusLabel3, Me.lbl_CusName})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(957, 26)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(56, 21)
        Me.ToolStripStatusLabel1.Text = "รหัสลูกค้า :"
        '
        'lbl_CusId
        '
        Me.lbl_CusId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CusId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_CusId.Name = "lbl_CusId"
        Me.lbl_CusId.Size = New System.Drawing.Size(37, 21)
        Me.lbl_CusId.Text = "xxx"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(51, 21)
        Me.ToolStripStatusLabel3.Text = "ชื่อลูกค้า :"
        '
        'lbl_CusName
        '
        Me.lbl_CusName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CusName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_CusName.Name = "lbl_CusName"
        Me.lbl_CusName.Size = New System.Drawing.Size(37, 21)
        Me.lbl_CusName.Text = "xxx"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(757, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "ป้อนรหัสลูกค้า"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "บันทึกการสั่ง / รับสินค้า"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(877, 60)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(715, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "รหัสสินค้า"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(680, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "รายละเอียดสินค้า"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(704, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ราคา/หน่วย"
        '
        'txtAddGoodId
        '
        Me.txtAddGoodId.Location = New System.Drawing.Point(773, 63)
        Me.txtAddGoodId.Name = "txtAddGoodId"
        Me.txtAddGoodId.Size = New System.Drawing.Size(100, 20)
        Me.txtAddGoodId.TabIndex = 7
        '
        'txtAddGoodName
        '
        Me.txtAddGoodName.Location = New System.Drawing.Point(773, 90)
        Me.txtAddGoodName.Multiline = True
        Me.txtAddGoodName.Name = "txtAddGoodName"
        Me.txtAddGoodName.ReadOnly = True
        Me.txtAddGoodName.Size = New System.Drawing.Size(100, 51)
        Me.txtAddGoodName.TabIndex = 8
        '
        'txtAddGoodCost
        '
        Me.txtAddGoodCost.Location = New System.Drawing.Point(773, 155)
        Me.txtAddGoodCost.Name = "txtAddGoodCost"
        Me.txtAddGoodCost.ReadOnly = True
        Me.txtAddGoodCost.Size = New System.Drawing.Size(100, 20)
        Me.txtAddGoodCost.TabIndex = 9
        '
        'DateTimeDocDate
        '
        Me.DateTimeDocDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeDocDate.Location = New System.Drawing.Point(773, 206)
        Me.DateTimeDocDate.Name = "DateTimeDocDate"
        Me.DateTimeDocDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeDocDate.TabIndex = 10
        '
        'DateTimeOrdDate
        '
        Me.DateTimeOrdDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeOrdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeOrdDate.Location = New System.Drawing.Point(773, 245)
        Me.DateTimeOrdDate.Name = "DateTimeOrdDate"
        Me.DateTimeOrdDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeOrdDate.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(702, 213)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "วันที่สั่งสินค้า"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(701, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "วันกำหนดส่ง"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(701, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "วันที่ส่งสินค้า"
        '
        'DateTimeFinDate
        '
        Me.DateTimeFinDate.CustomFormat = "yyyy-MM-dd"
        Me.DateTimeFinDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeFinDate.Location = New System.Drawing.Point(773, 281)
        Me.DateTimeFinDate.Name = "DateTimeFinDate"
        Me.DateTimeFinDate.Size = New System.Drawing.Size(100, 20)
        Me.DateTimeFinDate.TabIndex = 14
        '
        'txtAmont
        '
        Me.txtAmont.Location = New System.Drawing.Point(773, 325)
        Me.txtAmont.Name = "txtAmont"
        Me.txtAmont.Size = New System.Drawing.Size(100, 20)
        Me.txtAmont.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(701, 328)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "จำนวนที่สั่ง"
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Location = New System.Drawing.Point(771, 362)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(102, 23)
        Me.btnSaveOrder.TabIndex = 18
        Me.btnSaveOrder.Text = "เพิ่มรายการสินค้า"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'txtProces
        '
        Me.txtProces.Location = New System.Drawing.Point(12, 401)
        Me.txtProces.Name = "txtProces"
        Me.txtProces.Size = New System.Drawing.Size(75, 23)
        Me.txtProces.TabIndex = 19
        Me.txtProces.Text = "ประมวลผล"
        Me.txtProces.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(23, 78)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(629, 307)
        Me.ListView1.TabIndex = 20
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "*"
        Me.ColumnHeader1.Width = 30
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "รหัสสินค้า"
        Me.ColumnHeader2.Width = 70
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "รายละเอียดสินค้า"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "วันที่สั่งสินค้า"
        Me.ColumnHeader4.Width = 75
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "วันกำหนดส่ง"
        Me.ColumnHeader5.Width = 80
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "วันที่ส่งสิ้นค้า"
        Me.ColumnHeader6.Width = 70
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "จำนวนสั่ง"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ราคา/หน่วย"
        Me.ColumnHeader8.Width = 70
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "ราคารวม"
        Me.ColumnHeader9.Width = 70
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(577, 401)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FormOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 455)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtProces)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtAmont)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimeFinDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimeOrdDate)
        Me.Controls.Add(Me.DateTimeDocDate)
        Me.Controls.Add(Me.txtAddGoodCost)
        Me.Controls.Add(Me.txtAddGoodName)
        Me.Controls.Add(Me.txtAddGoodId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "FormOrder"
        Me.Text = "FormOrder"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_CusId As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_CusName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddGoodId As System.Windows.Forms.TextBox
    Friend WithEvents txtAddGoodName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddGoodCost As System.Windows.Forms.TextBox
    Friend WithEvents DateTimeDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeOrdDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimeFinDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAmont As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents txtProces As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
