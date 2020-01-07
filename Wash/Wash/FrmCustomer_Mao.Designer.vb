<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomer_Mao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btNew = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbType_Mao = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeMao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal_Price = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.pnlFooter.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFooter.Controls.Add(Me.btNew)
        Me.pnlFooter.Controls.Add(Me.btEdit)
        Me.pnlFooter.Controls.Add(Me.btDel)
        Me.pnlFooter.Controls.Add(Me.btSave)
        Me.pnlFooter.Controls.Add(Me.btBack)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 694)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1125, 65)
        Me.pnlFooter.TabIndex = 4
        '
        'btNew
        '
        Me.btNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btNew.Image = Global.Wash.My.Resources.Resources.verified_account
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNew.Location = New System.Drawing.Point(969, 2)
        Me.btNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(133, 48)
        Me.btNew.TabIndex = 47
        Me.btNew.Text = "รายการใหม่"
        Me.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNew.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEdit.Image = Global.Wash.My.Resources.Resources.user
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(830, 2)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(135, 48)
        Me.btEdit.TabIndex = 46
        Me.btEdit.Text = "แก้ไข"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDel
        '
        Me.btDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDel.Image = Global.Wash.My.Resources.Resources.unfollow
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(706, 2)
        Me.btDel.Margin = New System.Windows.Forms.Padding(2)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(118, 48)
        Me.btDel.TabIndex = 45
        Me.btDel.Text = "ลบ"
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.Image = Global.Wash.My.Resources.Resources.save
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSave.Location = New System.Drawing.Point(370, 4)
        Me.btSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(143, 48)
        Me.btSave.TabIndex = 44
        Me.btSave.Text = "บันทึกข้อมูล"
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btBack.Image = Global.Wash.My.Resources.Resources.arrow
        Me.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBack.Location = New System.Drawing.Point(9, 4)
        Me.btBack.Margin = New System.Windows.Forms.Padding(2)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(138, 48)
        Me.btBack.TabIndex = 43
        Me.btBack.Text = "ย้อนกลับ"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(665, 11)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(151, 31)
        Me.dtpDate.TabIndex = 105
        Me.dtpDate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(613, 14)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 24)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "วันที่"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(143, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "ชื่อลูกค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(138, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "เบอร์โทร"
        '
        'txtTel
        '
        Me.txtTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(216, 52)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(221, 35)
        Me.txtTel.TabIndex = 44
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(216, 11)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 35)
        Me.txtName.TabIndex = 43
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 100)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbType_Mao)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btAdd)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1125, 594)
        Me.SplitContainer1.SplitterDistance = 289
        Me.SplitContainer1.TabIndex = 7
        '
        'cbType_Mao
        '
        Me.cbType_Mao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType_Mao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbType_Mao.FormattingEnabled = True
        Me.cbType_Mao.Location = New System.Drawing.Point(18, 83)
        Me.cbType_Mao.Name = "cbType_Mao"
        Me.cbType_Mao.Size = New System.Drawing.Size(252, 33)
        Me.cbType_Mao.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(14, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "เลือกชนิดการเหมา"
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btAdd.Image = Global.Wash.My.Resources.Resources.follow
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(119, 145)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(151, 48)
        Me.btAdd.TabIndex = 44
        Me.btAdd.Text = "เพิ่ม"
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeight = 35
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order, Me.TypeMao, Me.piece, Me.price, Me.condition})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 48)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(832, 498)
        Me.dgv.TabIndex = 97
        '
        'order
        '
        Me.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.order.HeaderText = "ลำดับ"
        Me.order.Name = "order"
        Me.order.ReadOnly = True
        Me.order.Width = 71
        '
        'TypeMao
        '
        Me.TypeMao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TypeMao.HeaderText = "ชนิดการเหมา"
        Me.TypeMao.Name = "TypeMao"
        Me.TypeMao.ReadOnly = True
        Me.TypeMao.Width = 126
        '
        'piece
        '
        Me.piece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.piece.HeaderText = "จำนวน ชิ้น/ตัว/ผืน"
        Me.piece.Name = "piece"
        Me.piece.ReadOnly = True
        Me.piece.Width = 152
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.price.HeaderText = "ราคา"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'condition
        '
        Me.condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.condition.HeaderText = "เงื่อนไข"
        Me.condition.Name = "condition"
        Me.condition.ReadOnly = True
        Me.condition.Width = 86
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtTotal_Price)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 546)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(832, 48)
        Me.Panel2.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Window
        Me.Label10.Location = New System.Drawing.Point(723, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 25)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "บาท"
        '
        'txtTotal_Price
        '
        Me.txtTotal_Price.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal_Price.ForeColor = System.Drawing.Color.Red
        Me.txtTotal_Price.Location = New System.Drawing.Point(577, 2)
        Me.txtTotal_Price.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotal_Price.Multiline = True
        Me.txtTotal_Price.Name = "txtTotal_Price"
        Me.txtTotal_Price.Size = New System.Drawing.Size(140, 41)
        Me.txtTotal_Price.TabIndex = 52
        Me.txtTotal_Price.Text = "0"
        Me.txtTotal_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Window
        Me.Label9.Location = New System.Drawing.Point(486, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "รวมเงิน"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.dtpDate)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(832, 48)
        Me.Panel10.TabIndex = 0
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeader.Controls.Add(Me.txtTel)
        Me.pnlHeader.Controls.Add(Me.txtName)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.btMenu)
        Me.pnlHeader.Controls.Add(Me.Label7)
        Me.pnlHeader.Controls.Add(Me.Label2)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1125, 100)
        Me.pnlHeader.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(790, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "เพิ่มลูกค้าเหมา"
        '
        'btMenu
        '
        Me.btMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btMenu.Image = Global.Wash.My.Resources.Resources.menu
        Me.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMenu.Location = New System.Drawing.Point(16, 14)
        Me.btMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(123, 61)
        Me.btMenu.TabIndex = 38
        Me.btMenu.Text = "เมนูหลัก"
        Me.btMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'FrmCustomer_Mao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 759)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.Name = "FrmCustomer_Mao"
        Me.Text = "FrmCustomer_Mao"
        Me.pnlFooter.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btNew As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDel As Button
    Friend WithEvents btSave As Button
    Friend WithEvents btBack As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents btMenu As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btAdd As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotal_Price As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbType_Mao As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents order As DataGridViewTextBoxColumn
    Friend WithEvents TypeMao As DataGridViewTextBoxColumn
    Friend WithEvents piece As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents condition As DataGridViewTextBoxColumn
End Class
