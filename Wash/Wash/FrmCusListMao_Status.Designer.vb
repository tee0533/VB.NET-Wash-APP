<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusListMao_Status
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dgvHeader = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.วันที่รับ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.รหัส = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อลูกค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เบอร์โทร = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.จำนวนผ้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Wash.My.Resources.Resources.menu
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'dgvHeader
        '
        Me.dgvHeader.AllowUserToAddRows = False
        Me.dgvHeader.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvHeader.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHeader.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.วันที่รับ, Me.รหัส, Me.ชื่อลูกค้า, Me.เบอร์โทร, Me.จำนวนผ้า, Me.status})
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
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dgvHeader.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvHeader.RowTemplate.Height = 30
        Me.dgvHeader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHeader.Size = New System.Drawing.Size(1092, 490)
        Me.dgvHeader.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.dgvHeader)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 159)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1096, 494)
        Me.Panel4.TabIndex = 5
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAddCustomer.Location = New System.Drawing.Point(939, 16)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(119, 40)
        Me.btnAddCustomer.TabIndex = 6
        Me.btnAddCustomer.Text = "เพิ่มลูกค้า"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(254, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "ส่งคืนแล้ว"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ยังไมส่งคืน"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(178, 35)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(75, 29)
        Me.Panel6.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Red
        Me.Panel5.ForeColor = System.Drawing.Color.Red
        Me.Panel5.Location = New System.Drawing.Point(15, 35)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(75, 29)
        Me.Panel5.TabIndex = 1
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSend.Location = New System.Drawing.Point(476, 16)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(141, 40)
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "ส่งคืนผ้า"
        Me.btnSend.UseVisualStyleBackColor = True
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "สถานะการคืนสินค้า"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(424, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 40)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(124, 23)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(294, 40)
        Me.txtSearch.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(719, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "สถานะลูกค้าเหมา"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(729, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(329, 85)
        Me.Panel3.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnSend)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.btnAddCustomer)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 653)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 71)
        Me.Panel2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 159)
        Me.Panel1.TabIndex = 3
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(626, 16)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(141, 40)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(778, 16)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(141, 40)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(61, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "ค้นหา"
        '
        'วันที่รับ
        '
        Me.วันที่รับ.HeaderText = "วันที่รับ"
        Me.วันที่รับ.Name = "วันที่รับ"
        Me.วันที่รับ.ReadOnly = True
        Me.วันที่รับ.Width = 150
        '
        'รหัส
        '
        Me.รหัส.HeaderText = "รหัส"
        Me.รหัส.Name = "รหัส"
        Me.รหัส.ReadOnly = True
        '
        'ชื่อลูกค้า
        '
        Me.ชื่อลูกค้า.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ชื่อลูกค้า.HeaderText = "ชื่อลูกค้า"
        Me.ชื่อลูกค้า.Name = "ชื่อลูกค้า"
        Me.ชื่อลูกค้า.ReadOnly = True
        '
        'เบอร์โทร
        '
        Me.เบอร์โทร.HeaderText = "เบอร์โทร"
        Me.เบอร์โทร.Name = "เบอร์โทร"
        Me.เบอร์โทร.ReadOnly = True
        Me.เบอร์โทร.Width = 200
        '
        'จำนวนผ้า
        '
        Me.จำนวนผ้า.HeaderText = "จำนวนผ้า"
        Me.จำนวนผ้า.Name = "จำนวนผ้า"
        Me.จำนวนผ้า.ReadOnly = True
        Me.จำนวนผ้า.Width = 150
        '
        'status
        '
        Me.status.HeaderText = "สถานะ"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 130
        '
        'FrmCusListMao_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 724)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmCusListMao_Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCusListMao_Status"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvHeader As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnSend As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents วันที่รับ As DataGridViewTextBoxColumn
    Friend WithEvents รหัส As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อลูกค้า As DataGridViewTextBoxColumn
    Friend WithEvents เบอร์โทร As DataGridViewTextBoxColumn
    Friend WithEvents จำนวนผ้า As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
