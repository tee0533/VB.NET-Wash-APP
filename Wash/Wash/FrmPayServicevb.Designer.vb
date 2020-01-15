<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayServicevb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPayServicevb))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnFit = New System.Windows.Forms.Button()
        Me.btn1000 = New System.Windows.Forms.Button()
        Me.btn500 = New System.Windows.Forms.Button()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btnPayService = New System.Windows.Forms.Button()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtPay = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblPriceTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 724)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1065, 71)
        Me.Panel2.TabIndex = 4
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.BackgroundImage = Global.Wash.My.Resources.Resources.กลับ
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(1, 1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(154, 65)
        Me.btnBack.TabIndex = 7
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackgroundImage = Global.Wash.My.Resources.Resources.พิมพ์
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(906, 0)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(154, 65)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 159)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.ชำระค่าบริการนะ
        Me.SplitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClear)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnFit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn1000)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn500)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn100)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPayService)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtChange)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPay)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtAmount)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgv)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1065, 565)
        Me.SplitContainer1.SplitterDistance = 357
        Me.SplitContainer1.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnClear.BackgroundImage = Global.Wash.My.Resources.Resources.ล้าง
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnClear.Location = New System.Drawing.Point(177, 296)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(141, 48)
        Me.btnClear.TabIndex = 57
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnFit
        '
        Me.btnFit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFit.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.btnFit.BackgroundImage = Global.Wash.My.Resources.Resources.พอดี
        Me.btnFit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnFit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnFit.Location = New System.Drawing.Point(30, 296)
        Me.btnFit.Name = "btnFit"
        Me.btnFit.Size = New System.Drawing.Size(141, 48)
        Me.btnFit.TabIndex = 56
        Me.btnFit.UseVisualStyleBackColor = False
        '
        'btn1000
        '
        Me.btn1000.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1000.BackgroundImage = Global.Wash.My.Resources.Resources._1000
        Me.btn1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn1000.Location = New System.Drawing.Point(239, 229)
        Me.btn1000.Name = "btn1000"
        Me.btn1000.Size = New System.Drawing.Size(98, 55)
        Me.btn1000.TabIndex = 55
        Me.btn1000.UseVisualStyleBackColor = True
        '
        'btn500
        '
        Me.btn500.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn500.BackgroundImage = Global.Wash.My.Resources.Resources._500
        Me.btn500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn500.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn500.Location = New System.Drawing.Point(124, 229)
        Me.btn500.Name = "btn500"
        Me.btn500.Size = New System.Drawing.Size(100, 55)
        Me.btn500.TabIndex = 54
        Me.btn500.UseVisualStyleBackColor = True
        '
        'btn100
        '
        Me.btn100.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn100.BackgroundImage = Global.Wash.My.Resources.Resources._100
        Me.btn100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn100.Location = New System.Drawing.Point(10, 229)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(99, 55)
        Me.btn100.TabIndex = 53
        Me.btn100.UseVisualStyleBackColor = True
        '
        'btnPayService
        '
        Me.btnPayService.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnPayService.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPayService.BackgroundImage = Global.Wash.My.Resources.Resources.จ่ายเงิน1
        Me.btnPayService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPayService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPayService.Location = New System.Drawing.Point(69, 452)
        Me.btnPayService.Name = "btnPayService"
        Me.btnPayService.Size = New System.Drawing.Size(190, 77)
        Me.btnPayService.TabIndex = 52
        Me.btnPayService.UseVisualStyleBackColor = False
        '
        'txtChange
        '
        Me.txtChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtChange.Location = New System.Drawing.Point(15, 390)
        Me.txtChange.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtChange.Multiline = True
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(217, 41)
        Me.txtChange.TabIndex = 50
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPay
        '
        Me.txtPay.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPay.Location = New System.Drawing.Point(15, 165)
        Me.txtPay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPay.Multiline = True
        Me.txtPay.Name = "txtPay"
        Me.txtPay.Size = New System.Drawing.Size(217, 41)
        Me.txtPay.TabIndex = 47
        Me.txtPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(15, 65)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAmount.Multiline = True
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(217, 41)
        Me.txtAmount.TabIndex = 44
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(0, 0)
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
        Me.dgv.Size = New System.Drawing.Size(704, 496)
        Me.dgv.TabIndex = 98
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BackgroundImage = Global.Wash.My.Resources.Resources.ชรำระค่าบริการรวม
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.lblPriceTotal)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 496)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 69)
        Me.Panel3.TabIndex = 0
        '
        'lbltotal
        '
        Me.lbltotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(587, 7)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(25, 25)
        Me.lbltotal.TabIndex = 45
        Me.lbltotal.Text = "0"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPriceTotal
        '
        Me.lblPriceTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPriceTotal.AutoSize = True
        Me.lblPriceTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblPriceTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPriceTotal.Location = New System.Drawing.Point(587, 34)
        Me.lblPriceTotal.Name = "lblPriceTotal"
        Me.lblPriceTotal.Size = New System.Drawing.Size(25, 25)
        Me.lblPriceTotal.TabIndex = 44
        Me.lblPriceTotal.Text = "0"
        Me.lblPriceTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.Panel1.BackgroundImage = Global.Wash.My.Resources.Resources.ชำระค่าบริการ
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.dtpDate)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1065, 159)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.txtTel)
        Me.Panel4.Controls.Add(Me.txtName)
        Me.Panel4.Location = New System.Drawing.Point(134, 36)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(379, 115)
        Me.Panel4.TabIndex = 108
        '
        'txtTel
        '
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtTel.Location = New System.Drawing.Point(115, 63)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTel.Multiline = True
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(221, 41)
        Me.txtTel.TabIndex = 44
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 3)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(221, 41)
        Me.txtName.TabIndex = 43
        '
        'dtpDate
        '
        Me.dtpDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(895, 115)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(151, 31)
        Me.dtpDate.TabIndex = 107
        Me.dtpDate.Value = New Date(2015, 3, 16, 16, 23, 2, 0)
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(826, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 24)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "วันที่รับ"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Wash.My.Resources.Resources.BT_Home
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(18, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 111)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FrmPayServicevb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 795)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPayServicevb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการร้านซักรีด"
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnFit As Button
    Friend WithEvents btn1000 As Button
    Friend WithEvents btn500 As Button
    Friend WithEvents btn100 As Button
    Friend WithEvents btnPayService As Button
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtPay As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblPriceTotal As Label
End Class
