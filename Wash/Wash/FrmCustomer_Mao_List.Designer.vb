<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomer_Mao_List
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCustomer_Mao_List))
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.order = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.group = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.list = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.cmbList = New System.Windows.Forms.ComboBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btNew = New System.Windows.Forms.Button()
        Me.btAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.btDel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.txtDetail = New System.Windows.Forms.TextBox()
        Me.txtPromotion = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btMenu = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.order, Me.group, Me.list, Me.total})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 60)
        Me.dgv.Margin = New System.Windows.Forms.Padding(4)
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
        Me.dgv.Size = New System.Drawing.Size(1138, 435)
        Me.dgv.TabIndex = 97
        '
        'order
        '
        Me.order.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.order.HeaderText = "ลำดับ"
        Me.order.MinimumWidth = 6
        Me.order.Name = "order"
        Me.order.ReadOnly = True
        Me.order.Width = 84
        '
        'group
        '
        Me.group.HeaderText = "กลุ่ม"
        Me.group.MinimumWidth = 6
        Me.group.Name = "group"
        Me.group.ReadOnly = True
        Me.group.Width = 300
        '
        'list
        '
        Me.list.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.list.HeaderText = "รายการ"
        Me.list.MinimumWidth = 6
        Me.list.Name = "list"
        Me.list.ReadOnly = True
        '
        'total
        '
        Me.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.total.HeaderText = "จำนวน"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 97
        '
        'txtNum
        '
        Me.txtNum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNum.Location = New System.Drawing.Point(171, 219)
        Me.txtNum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNum.Multiline = True
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(66, 43)
        Me.txtNum.TabIndex = 51
        Me.txtNum.Text = "1"
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbList
        '
        Me.cmbList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbList.FormattingEnabled = True
        Me.cmbList.Location = New System.Drawing.Point(108, 145)
        Me.cmbList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbList.Name = "cmbList"
        Me.cmbList.Size = New System.Drawing.Size(267, 38)
        Me.cmbList.TabIndex = 46
        '
        'cmbGroup
        '
        Me.cmbGroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(107, 98)
        Me.cmbGroup.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(267, 38)
        Me.cmbGroup.TabIndex = 45
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 249)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(199, Byte), Integer))
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.กลุ่มรายการ
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNum)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(1537, 554)
        Me.SplitContainer1.SplitterDistance = 394
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 5
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
        Me.pnlFooter.Location = New System.Drawing.Point(0, 803)
        Me.pnlFooter.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(1537, 93)
        Me.pnlFooter.TabIndex = 4
        '
        'btNew
        '
        Me.btNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btNew.BackgroundImage = Global.Wash.My.Resources.Resources.รายการใหม้
        Me.btNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNew.Location = New System.Drawing.Point(1324, 4)
        Me.btNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(205, 80)
        Me.btNew.TabIndex = 47
        Me.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btNew.UseVisualStyleBackColor = True
        '
        'btAdd
        '
        Me.btAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAdd.BackgroundImage = Global.Wash.My.Resources.Resources.เพิ่ม
        Me.btAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAdd.Location = New System.Drawing.Point(76, 298)
        Me.btAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btAdd.Name = "btAdd"
        Me.btAdd.Size = New System.Drawing.Size(272, 86)
        Me.btAdd.TabIndex = 44
        Me.btAdd.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.Wash.My.Resources.Resources.คงเหลือ
        Me.Panel2.Controls.Add(Me.txtBalance)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 495)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1138, 59)
        Me.Panel2.TabIndex = 1
        '
        'txtBalance
        '
        Me.txtBalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(771, 4)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBalance.Multiline = True
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.Size = New System.Drawing.Size(185, 50)
        Me.txtBalance.TabIndex = 52
        Me.txtBalance.Text = "0"
        Me.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.BGG
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1138, 60)
        Me.Panel1.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(917, 14)
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
        Me.Label18.Location = New System.Drawing.Point(787, 14)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 29)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "วันที่มาซัก"
        '
        'btEdit
        '
        Me.btEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btEdit.BackgroundImage = Global.Wash.My.Resources.Resources.แก้ไข1
        Me.btEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(1115, 4)
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
        Me.btDel.Location = New System.Drawing.Point(904, 4)
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
        Me.btSave.Location = New System.Drawing.Point(695, 5)
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
        Me.btBack.Location = New System.Drawing.Point(7, 4)
        Me.btBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(205, 80)
        Me.btBack.TabIndex = 43
        Me.btBack.UseVisualStyleBackColor = True
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.pnlHeader.BackgroundImage = Global.Wash.My.Resources.Resources.ค้นเหมา
        Me.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlHeader.Controls.Add(Me.txtDetail)
        Me.pnlHeader.Controls.Add(Me.txtPromotion)
        Me.pnlHeader.Controls.Add(Me.lblID)
        Me.pnlHeader.Controls.Add(Me.btnSearch)
        Me.pnlHeader.Controls.Add(Me.txtName)
        Me.pnlHeader.Controls.Add(Me.btMenu)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1537, 249)
        Me.pnlHeader.TabIndex = 3
        '
        'txtDetail
        '
        Me.txtDetail.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtDetail.Location = New System.Drawing.Point(367, 130)
        Me.txtDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDetail.Multiline = True
        Me.txtDetail.Name = "txtDetail"
        Me.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetail.Size = New System.Drawing.Size(611, 98)
        Me.txtDetail.TabIndex = 49
        '
        'txtPromotion
        '
        Me.txtPromotion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtPromotion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtPromotion.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.txtPromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPromotion.Location = New System.Drawing.Point(367, 74)
        Me.txtPromotion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPromotion.Name = "txtPromotion"
        Me.txtPromotion.ReadOnly = True
        Me.txtPromotion.Size = New System.Drawing.Size(611, 49)
        Me.txtPromotion.TabIndex = 48
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(1492, 14)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 17)
        Me.lblID.TabIndex = 46
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = Global.Wash.My.Resources.Resources.ค้นหา1
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(769, 7)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(139, 62)
        Me.btnSearch.TabIndex = 45
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(367, 14)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(394, 49)
        Me.txtName.TabIndex = 43
        '
        'btMenu
        '
        Me.btMenu.BackgroundImage = Global.Wash.My.Resources.Resources.BT_Home
        Me.btMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btMenu.Location = New System.Drawing.Point(18, 32)
        Me.btMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btMenu.Name = "btMenu"
        Me.btMenu.Size = New System.Drawing.Size(137, 137)
        Me.btMenu.TabIndex = 38
        Me.btMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btMenu.UseVisualStyleBackColor = True
        '
        'FrmCustomer_Mao_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1537, 896)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCustomer_Mao_List"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการร้านซักรีด"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnlFooter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtNum As TextBox
    Friend WithEvents cmbList As ComboBox
    Friend WithEvents cmbGroup As ComboBox
    Friend WithEvents btMenu As Button
    Friend WithEvents btNew As Button
    Friend WithEvents btEdit As Button
    Friend WithEvents btDel As Button
    Friend WithEvents btSave As Button
    Friend WithEvents btAdd As Button
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btBack As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblID As Label
    Friend WithEvents txtPromotion As TextBox
    Friend WithEvents order As DataGridViewTextBoxColumn
    Friend WithEvents group As DataGridViewTextBoxColumn
    Friend WithEvents list As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents txtDetail As TextBox
End Class
