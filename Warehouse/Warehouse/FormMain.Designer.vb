<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.หนาจอประจำวนToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.บนทกการสงรบสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.หนาจออางองToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายละเอยดลกคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายละเอยดสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานตางๆToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.รายงานกำหนดสงสนคาToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ระบบสินค้าคงคลัง"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.หนาจอประจำวนToolStripMenuItem, Me.หนาจออางองToolStripMenuItem, Me.รายงานตางๆToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(315, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'หนาจอประจำวนToolStripMenuItem
        '
        Me.หนาจอประจำวนToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.บนทกการสงรบสนคาToolStripMenuItem, Me.btnExit})
        Me.หนาจอประจำวนToolStripMenuItem.Name = "หนาจอประจำวนToolStripMenuItem"
        Me.หนาจอประจำวนToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.หนาจอประจำวนToolStripMenuItem.Text = "หน้าจอประจำวัน"
        '
        'บนทกการสงรบสนคาToolStripMenuItem
        '
        Me.บนทกการสงรบสนคาToolStripMenuItem.Name = "บนทกการสงรบสนคาToolStripMenuItem"
        Me.บนทกการสงรบสนคาToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.บนทกการสงรบสนคาToolStripMenuItem.Text = "บันทึกการสั่ง / รับสินค้า"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(178, 22)
        Me.btnExit.Text = "ออกจากระบบ"
        '
        'หนาจออางองToolStripMenuItem
        '
        Me.หนาจออางองToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายละเอยดลกคาToolStripMenuItem, Me.รายละเอยดสนคาToolStripMenuItem})
        Me.หนาจออางองToolStripMenuItem.Name = "หนาจออางองToolStripMenuItem"
        Me.หนาจออางองToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.หนาจออางองToolStripMenuItem.Text = "หน้าจออ้างอิง"
        '
        'รายละเอยดลกคาToolStripMenuItem
        '
        Me.รายละเอยดลกคาToolStripMenuItem.Name = "รายละเอยดลกคาToolStripMenuItem"
        Me.รายละเอยดลกคาToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.รายละเอยดลกคาToolStripMenuItem.Text = "รายละเอียดลูกค้า"
        '
        'รายละเอยดสนคาToolStripMenuItem
        '
        Me.รายละเอยดสนคาToolStripMenuItem.Name = "รายละเอยดสนคาToolStripMenuItem"
        Me.รายละเอยดสนคาToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.รายละเอยดสนคาToolStripMenuItem.Text = "รายละเอียดสินค้า"
        '
        'รายงานตางๆToolStripMenuItem
        '
        Me.รายงานตางๆToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.รายงานกำหนดสงสนคาToolStripMenuItem})
        Me.รายงานตางๆToolStripMenuItem.Name = "รายงานตางๆToolStripMenuItem"
        Me.รายงานตางๆToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.รายงานตางๆToolStripMenuItem.Text = "รายงานต่างๆ"
        '
        'รายงานกำหนดสงสนคาToolStripMenuItem
        '
        Me.รายงานกำหนดสงสนคาToolStripMenuItem.Name = "รายงานกำหนดสงสนคาToolStripMenuItem"
        Me.รายงานกำหนดสงสนคาToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.รายงานกำหนดสงสนคาToolStripMenuItem.Text = "รายงานกำหนดส่งสินค้า"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 179)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormMain"
        Me.Text = "ระบบสินค้าคงคลัง"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents หนาจอประจำวนToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents บนทกการสงรบสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents หนาจออางองToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายละเอยดลกคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายละเอยดสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานตางๆToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents รายงานกำหนดสงสนคาToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
