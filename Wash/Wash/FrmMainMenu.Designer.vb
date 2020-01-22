<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMainMenu))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuGeneral = New System.Windows.Forms.Button()
        Me.MenuAddCusGeneral = New System.Windows.Forms.Button()
        Me.MenuCusMao_Status = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuCusMao_Cometowash = New System.Windows.Forms.Button()
        Me.MenuCusMao = New System.Windows.Forms.Button()
        Me.MenuAddCusMao = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuGeneral)
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuAddCusGeneral)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuCusMao_Status)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnExit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuCusMao_Cometowash)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuCusMao)
        Me.SplitContainer1.Panel2.Controls.Add(Me.MenuAddCusMao)
        Me.SplitContainer1.Size = New System.Drawing.Size(1676, 665)
        Me.SplitContainer1.SplitterDistance = 956
        Me.SplitContainer1.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.BackgroundImage = Global.Wash.My.Resources.Resources.BT_report
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(0, 421)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(956, 198)
        Me.Button3.TabIndex = 29
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuGeneral
        '
        Me.MenuGeneral.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuGeneral.BackgroundImage = Global.Wash.My.Resources.Resources.BT_รายการลูกค้าาา
        Me.MenuGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuGeneral.ForeColor = System.Drawing.SystemColors.Control
        Me.MenuGeneral.Location = New System.Drawing.Point(0, 206)
        Me.MenuGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuGeneral.Name = "MenuGeneral"
        Me.MenuGeneral.Size = New System.Drawing.Size(956, 215)
        Me.MenuGeneral.TabIndex = 28
        Me.MenuGeneral.UseVisualStyleBackColor = False
        '
        'MenuAddCusGeneral
        '
        Me.MenuAddCusGeneral.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuAddCusGeneral.BackgroundImage = Global.Wash.My.Resources.Resources.BT_เพิ่มลูกค้าธรรมดา_vbvb
        Me.MenuAddCusGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuAddCusGeneral.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuAddCusGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuAddCusGeneral.ForeColor = System.Drawing.SystemColors.Control
        Me.MenuAddCusGeneral.Location = New System.Drawing.Point(0, 0)
        Me.MenuAddCusGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuAddCusGeneral.Name = "MenuAddCusGeneral"
        Me.MenuAddCusGeneral.Size = New System.Drawing.Size(956, 206)
        Me.MenuAddCusGeneral.TabIndex = 24
        Me.MenuAddCusGeneral.UseVisualStyleBackColor = False
        '
        'MenuCusMao_Status
        '
        Me.MenuCusMao_Status.BackColor = System.Drawing.Color.Green
        Me.MenuCusMao_Status.BackgroundImage = Global.Wash.My.Resources.Resources.Bt_สถานะรับคืน
        Me.MenuCusMao_Status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCusMao_Status.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuCusMao_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuCusMao_Status.ForeColor = System.Drawing.Color.White
        Me.MenuCusMao_Status.Location = New System.Drawing.Point(0, 434)
        Me.MenuCusMao_Status.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCusMao_Status.Name = "MenuCusMao_Status"
        Me.MenuCusMao_Status.Size = New System.Drawing.Size(716, 135)
        Me.MenuCusMao_Status.TabIndex = 31
        Me.MenuCusMao_Status.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.BackgroundImage = Global.Wash.My.Resources.Resources.Btclose
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(461, 588)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(244, 66)
        Me.btnExit.TabIndex = 30
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MenuCusMao_Cometowash
        '
        Me.MenuCusMao_Cometowash.BackColor = System.Drawing.Color.Green
        Me.MenuCusMao_Cometowash.BackgroundImage = Global.Wash.My.Resources.Resources.Bt_ค้าเหมามาซัก
        Me.MenuCusMao_Cometowash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCusMao_Cometowash.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuCusMao_Cometowash.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuCusMao_Cometowash.ForeColor = System.Drawing.Color.White
        Me.MenuCusMao_Cometowash.Location = New System.Drawing.Point(0, 287)
        Me.MenuCusMao_Cometowash.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCusMao_Cometowash.Name = "MenuCusMao_Cometowash"
        Me.MenuCusMao_Cometowash.Size = New System.Drawing.Size(716, 147)
        Me.MenuCusMao_Cometowash.TabIndex = 29
        Me.MenuCusMao_Cometowash.UseVisualStyleBackColor = False
        '
        'MenuCusMao
        '
        Me.MenuCusMao.BackColor = System.Drawing.Color.Green
        Me.MenuCusMao.BackgroundImage = Global.Wash.My.Resources.Resources.Bt_รายการเหมา
        Me.MenuCusMao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuCusMao.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuCusMao.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuCusMao.ForeColor = System.Drawing.Color.White
        Me.MenuCusMao.Location = New System.Drawing.Point(0, 143)
        Me.MenuCusMao.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuCusMao.Name = "MenuCusMao"
        Me.MenuCusMao.Size = New System.Drawing.Size(716, 144)
        Me.MenuCusMao.TabIndex = 28
        Me.MenuCusMao.UseVisualStyleBackColor = False
        '
        'MenuAddCusMao
        '
        Me.MenuAddCusMao.BackColor = System.Drawing.Color.Green
        Me.MenuAddCusMao.BackgroundImage = Global.Wash.My.Resources.Resources.Bt_เพิ่มลูกค้าทั่วไปปป
        Me.MenuAddCusMao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuAddCusMao.CausesValidation = False
        Me.MenuAddCusMao.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MenuAddCusMao.Dock = System.Windows.Forms.DockStyle.Top
        Me.MenuAddCusMao.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.MenuAddCusMao.ForeColor = System.Drawing.Color.White
        Me.MenuAddCusMao.Location = New System.Drawing.Point(0, 0)
        Me.MenuAddCusMao.Margin = New System.Windows.Forms.Padding(2)
        Me.MenuAddCusMao.Name = "MenuAddCusMao"
        Me.MenuAddCusMao.Size = New System.Drawing.Size(716, 143)
        Me.MenuAddCusMao.TabIndex = 27
        Me.MenuAddCusMao.UseVisualStyleBackColor = False
        '
        'FrmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1676, 665)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ระบบบริหารจัดการร้านซักรีด"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuAddCusGeneral As Button
    Friend WithEvents MenuCusMao_Status As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuCusMao_Cometowash As Button
    Friend WithEvents MenuCusMao As Button
    Friend WithEvents MenuAddCusMao As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuGeneral As Button
End Class
