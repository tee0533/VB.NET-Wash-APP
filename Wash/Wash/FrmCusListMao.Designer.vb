<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusListMao
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvHeader = New System.Windows.Forms.DataGridView()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnPayService = New System.Windows.Forms.Button()
        Me.btnPerpromotion = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.dgvHeader)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1062, 499)
        Me.Panel4.TabIndex = 5
        '
        'dgvHeader
        '
        Me.dgvHeader.AllowUserToAddRows = False
        Me.dgvHeader.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvHeader.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHeader.Location = New System.Drawing.Point(0, 0)
        Me.dgvHeader.Name = "dgvHeader"
        Me.dgvHeader.ReadOnly = True
        Me.dgvHeader.RowHeadersVisible = False
        Me.dgvHeader.RowHeadersWidth = 200
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvHeader.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHeader.RowTemplate.Height = 30
        Me.dgvHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHeader.Size = New System.Drawing.Size(1058, 495)
        Me.dgvHeader.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(593, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 40)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "ลบข้อมุล"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 17)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(141, 40)
        Me.btnBack.TabIndex = 7
        Me.btnBack.Text = "ย้อนกลับ"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(905, 17)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(119, 40)
        Me.btnAddCustomer.TabIndex = 6
        Me.btnAddCustomer.Text = "เพิ่มลูกค้า"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnPayService)
        Me.Panel2.Controls.Add(Me.btnPerpromotion)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnAddCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 591)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 71)
        Me.Panel2.TabIndex = 4
        '
        'btnPayService
        '
        Me.btnPayService.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPayService.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPayService.Location = New System.Drawing.Point(436, 16)
        Me.btnPayService.Name = "btnPayService"
        Me.btnPayService.Size = New System.Drawing.Size(141, 40)
        Me.btnPayService.TabIndex = 11
        Me.btnPayService.Text = "ชำระบริการ"
        Me.btnPayService.UseVisualStyleBackColor = True
        '
        'btnPerpromotion
        '
        Me.btnPerpromotion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPerpromotion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPerpromotion.Location = New System.Drawing.Point(268, 16)
        Me.btnPerpromotion.Name = "btnPerpromotion"
        Me.btnPerpromotion.Size = New System.Drawing.Size(141, 40)
        Me.btnPerpromotion.TabIndex = 10
        Me.btnPerpromotion.Text = "ต่อโปรโมชั่น"
        Me.btnPerpromotion.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(746, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(141, 40)
        Me.btnEdit.TabIndex = 9
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(282, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 40)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(63, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(213, 40)
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(673, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(361, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "รายการลูกค้าเหมา"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 92)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Wash.My.Resources.Resources.menu
        Me.PictureBox1.Location = New System.Drawing.Point(12, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'FrmCusListMao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 662)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCusListMao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCusListMao"
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvHeader As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPerpromotion As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnPayService As Button
End Class
