<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCusSearch
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
        Me.btnSerach = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.รหัส = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ชื่อลูกค้า = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.เบอร์โทร = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.โปรโมชั่น = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSerach
        '
        Me.btnSerach.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSerach.Image = Global.Wash.My.Resources.Resources.search
        Me.btnSerach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSerach.Location = New System.Drawing.Point(399, 25)
        Me.btnSerach.Name = "btnSerach"
        Me.btnSerach.Size = New System.Drawing.Size(128, 49)
        Me.btnSerach.TabIndex = 48
        Me.btnSerach.Text = "ค้นหา"
        Me.btnSerach.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtName.Location = New System.Drawing.Point(106, 27)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(287, 44)
        Me.txtName.TabIndex = 47
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(38, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 25)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "ค้นหา"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.รหัส, Me.ชื่อลูกค้า, Me.เบอร์โทร, Me.โปรโมชั่น})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(29, 90)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(900, 388)
        Me.DataGridView1.TabIndex = 49
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(423, 484)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(77, 35)
        Me.btnSelect.TabIndex = 50
        Me.btnSelect.Text = "เลือก"
        Me.btnSelect.UseVisualStyleBackColor = True
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
        Me.เบอร์โทร.Width = 150
        '
        'โปรโมชั่น
        '
        Me.โปรโมชั่น.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.โปรโมชั่น.HeaderText = "โปรโมชั่น"
        Me.โปรโมชั่น.Name = "โปรโมชั่น"
        Me.โปรโมชั่น.ReadOnly = True
        '
        'FrmCusSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 531)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSerach)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label7)
        Me.MaximizeBox = False
        Me.Name = "FrmCusSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCusSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSerach As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents รหัส As DataGridViewTextBoxColumn
    Friend WithEvents ชื่อลูกค้า As DataGridViewTextBoxColumn
    Friend WithEvents เบอร์โทร As DataGridViewTextBoxColumn
    Friend WithEvents โปรโมชั่น As DataGridViewTextBoxColumn
End Class
