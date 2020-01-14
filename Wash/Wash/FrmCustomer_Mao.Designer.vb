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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.cbType_Mao = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeMao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condition = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal_Price = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.btNew = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
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
        Me.pnlFooter.BackColor = System.Drawing.Color.HotPink
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFooter.Controls.Add(Me.btNew)
        Me.pnlFooter.Controls.Add(Me.btEdit)
        Me.pnlFooter.Controls.Add(Me.btDel)
        Me.pnlFooter.Controls.Add(Me.btSave)
        Me.pnlFooter.Controls.Add(Me.btBack)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 890)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1420, 89)
        Me.pnlFooter.TabIndex = 4
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 130)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.เลือกชนิดเหมาา
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbType_Mao)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btAdd)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel10)
        Me.SplitContainer1.Size = New System.Drawing.Size(1420, 760)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 7
        '
        'cbType_Mao
        '
        Me.cbType_Mao.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbType_Mao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cbType_Mao.FormattingEnabled = True
        Me.cbType_Mao.Location = New System.Drawing.Point(25, 124)
        Me.cbType_Mao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbType_Mao.Name = "cbType_Mao"
        Me.cbType_Mao.Size = New System.Drawing.Size(314, 38)
        Me.cbType_Mao.TabIndex = 46
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv.ColumnHeadersHeight = 35
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order, Me.TypeMao, Me.piece, Me.price, Me.condition})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 58)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidth = 51
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1051, 643)
        Me.dgv.TabIndex = 97
        '
        'order
        '
        Me.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.order.HeaderText = "ลำดับ"
        Me.order.MinimumWidth = 6
        Me.order.Name = "order"
        Me.order.ReadOnly = True
        Me.order.Width = 84
        '
        'TypeMao
        '
        Me.TypeMao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.TypeMao.HeaderText = "ชนิดการเหมา"
        Me.TypeMao.MinimumWidth = 6
        Me.TypeMao.Name = "TypeMao"
        Me.TypeMao.ReadOnly = True
        Me.TypeMao.Width = 148
        '
        'piece
        '
        Me.piece.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.piece.HeaderText = "จำนวน ชิ้น/ตัว/ผืน"
        Me.piece.MinimumWidth = 6
        Me.piece.Name = "piece"
        Me.piece.ReadOnly = True
        Me.piece.Width = 190
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.price.HeaderText = "ราคา"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'condition
        '
        Me.condition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.condition.HeaderText = "เงื่อนไข"
        Me.condition.MinimumWidth = 6
        Me.condition.Name = "condition"
        Me.condition.ReadOnly = True
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่ม
        Me.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(60, 183)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(237, 83)
        Me.btAdd.TabIndex = 44
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.Wash.My.Resources.Resources.รวมเ
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.txtTotal_Price)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 701)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1051, 59)
        Me.Panel2.TabIndex = 1
        '
        'txtTotal_Price
        '
        Me.txtTotal_Price.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal_Price.ForeColor = System.Drawing.Color.Red
        Me.txtTotal_Price.Location = New System.Drawing.Point(764, 5)
        Me.txtTotal_Price.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTotal_Price.Multiline = True
        Me.txtTotal_Price.Name = "txtTotal_Price"
        Me.txtTotal_Price.Size = New System.Drawing.Size(129, 50)
        Me.txtTotal_Price.TabIndex = 52
        Me.txtTotal_Price.Text = "0"
        Me.txtTotal_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Panel10.BackgroundImage = Global.Wash.My.Resources.Resources.BGG
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.dtpDate)
        Me.Panel10.Controls.Add(Me.Label18)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1051, 58)
        Me.Panel10.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(830, 10)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 37)
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
        Me.Label18.Location = New System.Drawing.Point(760, 13)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 29)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "วันที่"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Black
        Me.pnlHeader.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่มลูกค้าเหมา1
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeader.Controls.Add(Me.txtTel)
        Me.pnlHeader.Controls.Add(Me.txtName)
        Me.pnlHeader.Controls.Add(Me.btMenu)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1420, 130)
        Me.pnlHeader.TabIndex = 5
        '
        'txtTel
        '
        Me.txtTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(288, 66)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTel.MaxLength = 10
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(293, 41)
        Me.txtTel.TabIndex = 44
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(288, 16)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(293, 41)
        Me.txtName.TabIndex = 43
        '
        'btMenu
        '
        Me.btMenu.BackgroundImage = Global.Wash.My.Resources.Resources.BT_Home
        Me.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMenu.Location = New System.Drawing.Point(37, 12)
        Me.btMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(113, 105)
        Me.btMenu.TabIndex = 38
        Me.btMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'btNew
        '
        Me.btNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNew.BackgroundImage = Global.Wash.My.Resources.Resources.รายการใหม้
        Me.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNew.Location = New System.Drawing.Point(1209, 3)
        Me.btNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(205, 80)
        Me.btNew.TabIndex = 47
        Me.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNew.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEdit.BackgroundImage = Global.Wash.My.Resources.Resources.แก้ไข
        Me.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(1003, 3)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(205, 80)
        Me.btEdit.TabIndex = 46
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'btDel
        '
        Me.btDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btDel.BackgroundImage = Global.Wash.My.Resources.Resources.ลบบ
        Me.btDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(796, 3)
        Me.btDel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(205, 80)
        Me.btDel.TabIndex = 45
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btSave
        '
        Me.btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btSave.BackgroundImage = Global.Wash.My.Resources.Resources.บันทึก
        Me.btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btSave.Location = New System.Drawing.Point(590, 3)
        Me.btSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(205, 80)
        Me.btSave.TabIndex = 44
        Me.btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btBack.BackgroundImage = Global.Wash.My.Resources.Resources.กลับ
        Me.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBack.Location = New System.Drawing.Point(3, 3)
        Me.btBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(205, 80)
        Me.btBack.TabIndex = 43
        Me.btBack.UseVisualStyleBackColor = True
        '
        'FrmCustomer_Mao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1420, 979)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlFooter)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmCustomer_Mao"
        Me.Text = "FrmCustomer_Mao"
        Me.pnlFooter.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
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
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btAdd As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTotal_Price As TextBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents cbType_Mao As ComboBox
    Friend WithEvents order As DataGridViewTextBoxColumn
    Friend WithEvents TypeMao As DataGridViewTextBoxColumn
    Friend WithEvents piece As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents condition As DataGridViewTextBoxColumn
    Friend WithEvents btMenu As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents pnlHeader As Panel
End Class
