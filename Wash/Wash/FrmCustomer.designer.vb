<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCustomer
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
        Dim btSave As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer))
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btNew = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.cmbList = New System.Windows.Forms.ComboBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotal_Price = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btMenu = New System.Windows.Forms.Button()
        Me.CheckHard = New System.Windows.Forms.CheckBox()
        Me.CheckMid = New System.Windows.Forms.CheckBox()
        Me.CheckEz = New System.Windows.Forms.CheckBox()
        Me.pnlOption = New System.Windows.Forms.Panel()
        Me.order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.list = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        btSave = New System.Windows.Forms.Button()
        Me.pnlFooter.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.pnlOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'btSave
        '
        btSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        btSave.BackgroundImage = Global.Wash.My.Resources.Resources.บันทึก
        btSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        btSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        btSave.Location = New System.Drawing.Point(478, 0)
        btSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        btSave.Name = "btSave"
        btSave.Size = New System.Drawing.Size(137, 61)
        btSave.TabIndex = 44
        btSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        btSave.UseVisualStyleBackColor = True
        AddHandler btSave.Click, AddressOf Me.btPrint_Click
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlFooter.Controls.Add(Me.btNew)
        Me.pnlFooter.Controls.Add(Me.btEdit)
        Me.pnlFooter.Controls.Add(Me.btDel)
        Me.pnlFooter.Controls.Add(btSave)
        Me.pnlFooter.Controls.Add(Me.btBack)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 729)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1065, 66)
        Me.pnlFooter.TabIndex = 1
        '
        'btNew
        '
        Me.btNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNew.BackgroundImage = Global.Wash.My.Resources.Resources.รายการใหม้
        Me.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNew.Location = New System.Drawing.Point(907, 0)
        Me.btNew.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(154, 61)
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
        Me.btEdit.Location = New System.Drawing.Point(761, 0)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(145, 61)
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
        Me.btDel.Location = New System.Drawing.Point(616, 0)
        Me.btDel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(144, 61)
        Me.btDel.TabIndex = 45
        Me.btDel.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btBack.BackgroundImage = Global.Wash.My.Resources.Resources.กลับ
        Me.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btBack.Location = New System.Drawing.Point(0, 0)
        Me.btBack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(154, 61)
        Me.btBack.TabIndex = 43
        Me.btBack.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 106)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่มลูกค้าา
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlOption)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbCategory)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cmbGroup)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btAdd)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1065, 623)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 2
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(117, 316)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNum.Multiline = True
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(39, 36)
        Me.txtNum.TabIndex = 51
        Me.txtNum.Text = "1"
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCategory
        '
        Me.cmbCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(62, 168)
        Me.cmbCategory.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(179, 33)
        Me.cmbCategory.TabIndex = 47
        '
        'cmbList
        '
        Me.cmbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbList.FormattingEnabled = True
        Me.cmbList.Location = New System.Drawing.Point(62, 117)
        Me.cmbList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbList.Name = "cmbList"
        Me.cmbList.Size = New System.Drawing.Size(179, 33)
        Me.cmbList.TabIndex = 46
        '
        'cmbGroup
        '
        Me.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(62, 59)
        Me.cmbGroup.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(179, 33)
        Me.cmbGroup.TabIndex = 45
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่ม
        Me.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(36, 377)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(204, 63)
        Me.btAdd.TabIndex = 44
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order, Me.group, Me.list, Me.category, Me.level, Me.total, Me.unit_price, Me.price})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 41)
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
        Me.dgv.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(788, 534)
        Me.dgv.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.Wash.My.Resources.Resources.รวมเงินน
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.txtTotal_Price)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 575)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(788, 48)
        Me.Panel2.TabIndex = 1
        '
        'txtTotal_Price
        '
        Me.txtTotal_Price.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTotal_Price.ForeColor = System.Drawing.Color.Red
        Me.txtTotal_Price.Location = New System.Drawing.Point(588, 4)
        Me.txtTotal_Price.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTotal_Price.Multiline = True
        Me.txtTotal_Price.Name = "txtTotal_Price"
        Me.txtTotal_Price.Size = New System.Drawing.Size(121, 41)
        Me.txtTotal_Price.TabIndex = 52
        Me.txtTotal_Price.Text = "0"
        Me.txtTotal_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.BG
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 41)
        Me.Panel1.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(622, 4)
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
        Me.Label18.Location = New System.Drawing.Point(569, 6)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 24)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "วันที่"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(121, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.pnlHeader.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่มลูกต้า
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeader.Controls.Add(Me.txtTel)
        Me.pnlHeader.Controls.Add(Me.txtName)
        Me.pnlHeader.Controls.Add(Me.btMenu)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1065, 106)
        Me.pnlHeader.TabIndex = 0
        '
        'txtTel
        '
        Me.txtTel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtTel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(218, 59)
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
        Me.txtName.Location = New System.Drawing.Point(218, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(221, 35)
        Me.txtName.TabIndex = 43
        '
        'btMenu
        '
        Me.btMenu.BackgroundImage = Global.Wash.My.Resources.Resources.BT_Home
        Me.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMenu.Location = New System.Drawing.Point(16, 6)
        Me.btMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(88, 92)
        Me.btMenu.TabIndex = 38
        Me.btMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'CheckHard
        '
        Me.CheckHard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckHard.AutoSize = True
        Me.CheckHard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckHard.ForeColor = System.Drawing.SystemColors.Window
        Me.CheckHard.Location = New System.Drawing.Point(150, 15)
        Me.CheckHard.Name = "CheckHard"
        Me.CheckHard.Size = New System.Drawing.Size(15, 14)
        Me.CheckHard.TabIndex = 56
        Me.CheckHard.UseVisualStyleBackColor = True
        '
        'CheckMid
        '
        Me.CheckMid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckMid.AutoSize = True
        Me.CheckMid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckMid.ForeColor = System.Drawing.SystemColors.Window
        Me.CheckMid.Location = New System.Drawing.Point(77, 13)
        Me.CheckMid.Name = "CheckMid"
        Me.CheckMid.Size = New System.Drawing.Size(15, 14)
        Me.CheckMid.TabIndex = 55
        Me.CheckMid.UseVisualStyleBackColor = True
        '
        'CheckEz
        '
        Me.CheckEz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckEz.AutoSize = True
        Me.CheckEz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.CheckEz.ForeColor = System.Drawing.SystemColors.Window
        Me.CheckEz.Location = New System.Drawing.Point(8, 12)
        Me.CheckEz.Name = "CheckEz"
        Me.CheckEz.Size = New System.Drawing.Size(15, 14)
        Me.CheckEz.TabIndex = 54
        Me.CheckEz.UseVisualStyleBackColor = True
        '
        'pnlOption
        '
        Me.pnlOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlOption.BackColor = System.Drawing.Color.Transparent
        Me.pnlOption.Controls.Add(Me.CheckEz)
        Me.pnlOption.Controls.Add(Me.CheckMid)
        Me.pnlOption.Controls.Add(Me.CheckHard)
        Me.pnlOption.Location = New System.Drawing.Point(19, 222)
        Me.pnlOption.Name = "pnlOption"
        Me.pnlOption.Size = New System.Drawing.Size(228, 41)
        Me.pnlOption.TabIndex = 58
        Me.pnlOption.Visible = False
        '
        'order
        '
        Me.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.order.HeaderText = "ลำดับ"
        Me.order.MinimumWidth = 6
        Me.order.Name = "order"
        Me.order.ReadOnly = True
        Me.order.Width = 71
        '
        'group
        '
        Me.group.HeaderText = "กลุ่ม"
        Me.group.MinimumWidth = 6
        Me.group.Name = "group"
        Me.group.ReadOnly = True
        Me.group.Width = 6
        '
        'list
        '
        Me.list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.list.HeaderText = "รายการ"
        Me.list.MinimumWidth = 6
        Me.list.Name = "list"
        Me.list.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "ประเภท"
        Me.category.MinimumWidth = 6
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        Me.category.Width = 120
        '
        'level
        '
        Me.level.HeaderText = "ระดับ/ราคา"
        Me.level.MinimumWidth = 6
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        Me.level.Width = 90
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total.HeaderText = "จำนวน"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 79
        '
        'unit_price
        '
        Me.unit_price.HeaderText = "ราคา/หน่วย"
        Me.unit_price.MinimumWidth = 6
        Me.unit_price.Name = "unit_price"
        Me.unit_price.ReadOnly = True
        Me.unit_price.Width = 90
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.price.HeaderText = "ราคา"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 125
        '
        'FrmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 795)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการร้านซักรีด"
        Me.pnlFooter.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlOption.ResumeLayout(False)
        Me.pnlOption.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents btMenu As Button
    Friend WithEvents btBack As Button
    Friend WithEvents txtNum As TextBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents cmbList As ComboBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents btAdd As Button
    Friend WithEvents btNew As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDel As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtTotal_Price As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlOption As Panel
    Friend WithEvents CheckEz As CheckBox
    Friend WithEvents CheckMid As CheckBox
    Friend WithEvents CheckHard As CheckBox
    Friend WithEvents order As DataGridViewTextBoxColumn
    Friend WithEvents group As DataGridViewTextBoxColumn
    Friend WithEvents list As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents level As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents unit_price As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
