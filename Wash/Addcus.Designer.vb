<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btAdd = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btPrint = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.cmbList = New System.Windows.Forms.ComboBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btNew = New System.Windows.Forms.Button()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.LbDate = New System.Windows.Forms.Label()
        Me.CheckEz = New System.Windows.Forms.CheckBox()
        Me.CheckMid = New System.Windows.Forms.CheckBox()
        Me.CheckHard = New System.Windows.Forms.CheckBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.chkAutoRun = New System.Windows.Forms.CheckBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btAdd
        '
        Me.btAdd.Location = New System.Drawing.Point(238, 477)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(118, 48)
        Me.btAdd.TabIndex = 23
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(880, 576)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(118, 48)
        Me.btEdit.TabIndex = 22
        Me.btEdit.Text = "แก้ไข"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(713, 576)
        Me.btDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(118, 48)
        Me.btDel.TabIndex = 21
        Me.btDel.Text = "ลบ"
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btPrint
        '
        Me.btPrint.Location = New System.Drawing.Point(549, 576)
        Me.btPrint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(118, 48)
        Me.btPrint.TabIndex = 20
        Me.btPrint.Text = "พิมพ์"
        Me.btPrint.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Location = New System.Drawing.Point(64, 576)
        Me.btBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(118, 48)
        Me.btBack.TabIndex = 19
        Me.btBack.Text = "ย้อนกลับ"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Location = New System.Drawing.Point(549, 136)
        Me.dgvList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowHeadersWidth = 51
        Me.dgvList.RowTemplate.Height = 24
        Me.dgvList.Size = New System.Drawing.Size(616, 381)
        Me.dgvList.TabIndex = 18
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(238, 166)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(221, 41)
        Me.txtTel.TabIndex = 16
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(238, 121)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 41)
        Me.txtName.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(185, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "เบอร์โทร"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ชื่อลูกค้า"
        '
        'btMenu
        '
        Me.btMenu.Location = New System.Drawing.Point(64, 77)
        Me.btMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(56, 61)
        Me.btMenu.TabIndex = 12
        Me.btMenu.Text = "เมนูหลัก"
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'cmbGroup
        '
        Me.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(191, 260)
        Me.cmbGroup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(204, 21)
        Me.cmbGroup.TabIndex = 24
        '
        'cmbList
        '
        Me.cmbList.FormattingEnabled = True
        Me.cmbList.Location = New System.Drawing.Point(191, 304)
        Me.cmbList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbList.Name = "cmbList"
        Me.cmbList.Size = New System.Drawing.Size(204, 21)
        Me.cmbList.TabIndex = 25
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(191, 348)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(204, 21)
        Me.cmbCategory.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(148, 262)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "กลุ่ม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 307)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "รายการ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 351)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ประเภท"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(192, 425)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNum.Multiline = True
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(140, 36)
        Me.txtNum.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 428)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "จำนวน"
        '
        'btNew
        '
        Me.btNew.Location = New System.Drawing.Point(1047, 576)
        Me.btNew.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(118, 48)
        Me.btNew.TabIndex = 32
        Me.btNew.Text = "รายการใหม่"
        Me.btNew.UseVisualStyleBackColor = True
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(238, 76)
        Me.txtNo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNo.Multiline = True
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(221, 41)
        Me.txtNo.TabIndex = 33
        '
        'LbDate
        '
        Me.LbDate.AutoSize = True
        Me.LbDate.Location = New System.Drawing.Point(1135, 101)
        Me.LbDate.Name = "LbDate"
        Me.LbDate.Size = New System.Drawing.Size(30, 13)
        Me.LbDate.TabIndex = 34
        Me.LbDate.Text = "Date"
        '
        'CheckEz
        '
        Me.CheckEz.AutoSize = True
        Me.CheckEz.Location = New System.Drawing.Point(147, 389)
        Me.CheckEz.Name = "CheckEz"
        Me.CheckEz.Size = New System.Drawing.Size(43, 17)
        Me.CheckEz.TabIndex = 35
        Me.CheckEz.Text = "ง่าย"
        Me.CheckEz.UseVisualStyleBackColor = True
        '
        'CheckMid
        '
        Me.CheckMid.AutoSize = True
        Me.CheckMid.Location = New System.Drawing.Point(238, 389)
        Me.CheckMid.Name = "CheckMid"
        Me.CheckMid.Size = New System.Drawing.Size(49, 17)
        Me.CheckMid.TabIndex = 36
        Me.CheckMid.Text = "กลาง"
        Me.CheckMid.UseVisualStyleBackColor = True
        '
        'CheckHard
        '
        Me.CheckHard.AutoSize = True
        Me.CheckHard.Location = New System.Drawing.Point(328, 389)
        Me.CheckHard.Name = "CheckHard"
        Me.CheckHard.Size = New System.Drawing.Size(45, 17)
        Me.CheckHard.TabIndex = 37
        Me.CheckHard.Text = "ยาก"
        Me.CheckHard.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(944, 521)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(221, 41)
        Me.txtPrice.TabIndex = 38
        '
        'chkAutoRun
        '
        Me.chkAutoRun.AutoSize = True
        Me.chkAutoRun.Checked = True
        Me.chkAutoRun.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAutoRun.Location = New System.Drawing.Point(463, 88)
        Me.chkAutoRun.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkAutoRun.Name = "chkAutoRun"
        Me.chkAutoRun.Size = New System.Drawing.Size(71, 17)
        Me.chkAutoRun.TabIndex = 39
        Me.chkAutoRun.Text = "Auto Run"
        Me.chkAutoRun.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1426, 839)
        Me.Controls.Add(Me.chkAutoRun)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.CheckHard)
        Me.Controls.Add(Me.CheckMid)
        Me.Controls.Add(Me.CheckEz)
        Me.Controls.Add(Me.LbDate)
        Me.Controls.Add(Me.txtNo)
        Me.Controls.Add(Me.btNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCategory)
        Me.Controls.Add(Me.cmbList)
        Me.Controls.Add(Me.cmbGroup)
        Me.Controls.Add(Me.btAdd)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btPrint)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btMenu)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btAdd As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDel As Button
    Friend WithEvents btPrint As Button
    Friend WithEvents btBack As Button
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btMenu As Button
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents cmbList As ComboBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btNew As Button
    Friend WithEvents txtNo As TextBox
    Friend WithEvents LbDate As Label
    Friend WithEvents CheckEz As CheckBox
    Friend WithEvents CheckMid As CheckBox
    Friend WithEvents CheckHard As CheckBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents chkAutoRun As CheckBox
End Class
