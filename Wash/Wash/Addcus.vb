Imports System.Data
Imports System.Data.OleDb
'เนมสเปซ สำหรับจัดการข้อความ
Imports System.Text
Public Class Form4
    Dim Conn As New OleDbConnection 'สำหรับเชื่อมต่อกับฐานข้อมูล
    Dim Com As New OleDbCommand     'ทำหน้าที่รัน (Run) ชุดคำสั่ง SQL
    Dim dr As OleDbDataReader
    Dim DA As New OleDbDataAdapter 'ทำหน้าที่รัน (Run) ชุดคำสั่ง SQL ประเภทสอบถามข้อมูล 
    Dim DT As DataTable             'ทำหน้าที่เก็บผลลัพธ์ข้อมูล (Result set) ที่ดึงมาจากฐานข้อมูล


    'สำหรับจัดการ SQL Statement
    Dim sb As New StringBuilder("")
    Dim sql As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ตรวจสอบการการเชื่อมต่อกับฐานข้อมุล
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        'ผูกข้อมูล ประเภทหนังสือ เข้ากับ cmbGroup
        sql = "SELECT GroupName, ListFk, ListNo, ListName FROM GroupCloth left join ListCloth on GroupCloth.ListFk=ListCloth.ListNo"
        DA = New OleDbDataAdapter(sql, Conn)
        DT = New DataTable
        DA.Fill(DT)
        With cmbGroup
            .DataSource = DT
            .ValueMember = "ListFk"
            .DisplayMember = "GroupName"
        End With
        With cmbList
            .DataSource = DT
            .ValueMember = "ListNo"
            .DisplayMember = "ListName"
        End With

        Me.ShowcusList()
        Me.FormatdgvList()
    End Sub
    Private Sub ShowcusList()
        'สร้าง SQL Statement สำหรับดึงข้อมูลแบบไม่มีเงื่อนไข
        sb.Remove(0, sb.Length)
        sb.Append("SELECT * ")
        sb.Append(" FROM CustomerList")
        sql = sb.ToString

        'รัน คำสั่ง SQL 
        DA = New OleDbDataAdapter(sql, Conn)
        DT = New DataTable  'สร้างออปเจ็กต์ DataTable ขึ้นใหม่
        DA.Fill(DT)         'เก็บข้อมูลที่ได้จาก DataAdapter เก็บไว้ที่ DataTable

        'ตรวจสอบว่ามีข้อมุลในอยู่ใน DataTable หรือไม่ ก่อนที่จะผู้ข้อมูลเข้ากับคอนโทรล DataGridView
        If DT.Rows.Count > 0 Then
            dgvList.DataSource = DT
        Else
            dgvList.DataSource = Nothing
        End If
    End Sub
    Private Sub FormatdgvList()
        With dgvList
            .Columns(0).HeaderText = "ลำดับ"
            .Columns(1).HeaderText = "รายการ"
            .Columns(2).HeaderText = "ประเภท"
            .Columns(3).HeaderText = "จำนวน"
            .Columns(4).HeaderText = "ราคา"
            .Columns(5).HeaderText = "สำนักพิมพ์"

            .Columns(0).Width = 60
            .Columns(1).Width = 100
            .Columns(2).Width = 200
            .Columns(3).Width = 110
            .Columns(4).Width = 90
            '.Columns(5).Width = 100
            '.Columns(6).Width = 100
            '.Columns(7).Width = 110
            '.Columns(8).Width = 0
            '.Columns(8).Width = 0 'ซ่อนคอลัมน์ BookTypeID
            '.Columns(9).Width = 0 'ซ่อนคอลัมน์ AuthorID
            '.Columns(10).Width = 0 'ซ่อนคอลัมน์ PublisherID
        End With
    End Sub
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        If chkAutoRun.Checked = True Then
            Me.AutoRunNo()
        End If
        'สร้าง SQL Statement สำหรับเพิ่มข้อมูล ไว้ที่ตัวแปร sb
        sb.Remove(0, sb.Length)
        sb.Append("INSERT INTO CustomerList(No,List,Category,Number)")
        sb.Append(" VALUES (?, ?, ?, ?)")
        sql = sb.ToString 'ทำให้เป็น SQL Statement ที่เก็บไว้ใน sb เป็นข้อความทั่วไทที่พร้อมทำงาน

        'ตรวจสอบการการเชื่อมต่อกับฐานข้อมุล
        With Conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strConn
            .Open()
        End With

        'สร้างชุดคำสั่งให้กับตัวแปร Command เพื่อรับค่าพารามิเตอร์ และทำรันชุดคำสั่ง SQL
        With Com
            .CommandType = CommandType.Text
            .CommandText = sql
            .Connection = Conn
            .Parameters.Clear() 'ล้างค้าพารามิเตอร์ที่มีอยู่ หรือ ทำให้เป็นค่าว่างก่อน
            'กำหนดค่าให้กับพารามิเตอร์ ให้เรียงลำดับตาม SQL Statement โดยรับค่าจากฟอร์ม
            .Parameters.Add("?", OleDbType.VarWChar).Value = CStr(txtNo.Text)
            .Parameters.Add("?", OleDbType.VarWChar).Value = CStr(cmbList.SelectedValue)
            .Parameters.Add("?", OleDbType.VarWChar).Value = CStr(cmbCategory.SelectedValue)
            .Parameters.Add("?", OleDbType.VarWChar).Value = CStr(txtNum.Text)
            .ExecuteNonQuery() 'คำสั่งสำหรับเพิ่มข้อมูลไปยังฐานข้อมูล
        End With

        'เรียกใช้ซับรูทีน หรือโปรแกรมย่อยที่สร้างขึ้น
        Me.ShowcusList()
    End Sub
    Private Sub AutoRunNo()
        sql = "SELECT TOP(1) No FROM CustomerList ORDER BY No DESC"
        Com = New OleDbCommand(sql, Conn)
        dr = Com.ExecuteReader
        If dr.Read Then
            txtNo.Text = CInt(dr.Item("No")) + 1
            dr.Close()
        End If
    End Sub
    Private Sub chkAutoRun_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoRun.CheckedChanged
        If chkAutoRun.Checked = True Then
            txtNo.ReadOnly = True
            txtName.Focus()
            txtName.Select()
        Else
            txtNo.ReadOnly = False
            txtNo.Focus()
            txtNo.Select()
        End If
    End Sub
    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        If (MessageBox.Show("คุณต้องการ ลบ ข้อมูลใช่หรือไม่?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes) Then
            'สร้าง sql Statement สำหรับ การลบ
            sb.Remove(0, sb.Length)
            sb.Append("DELETE FROM CustomerList ")
            sb.Append(" WHERE (No=?)")
            sql = sb.ToString
            'ตรวจสอบการการเชื่อมต่อกับฐานข้อมุล
            With Conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strConn
                .Open()
            End With

            With Com
                .CommandType = CommandType.Text
                .CommandText = sql
                .Connection = Conn
                .Parameters.Clear()
                .Parameters.Add("?", OleDbType.Integer).Value = CInt(txtNo.Text)
                .ExecuteNonQuery()
            End With

            Me.ShowcusList()
            'ข้อความแจ้งผลการทำงาน
            MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "การทำงาน", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtName.Focus()
            txtName.Select()
        End If
    End Sub
    Private Sub dgvList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvList.CellMouseClick
        If e.RowIndex > -1 Then 'ตรวจสอบว่าบริเวณที่คลิกมาส์นั้น เป็นแถวข้อมูล ไม่ใช่บริเวณอื่นของ GridView
            'เลือกค่าจากแถวที่กำลังเลือก ให้ ไปแสดงที่ คอนโทรล
            txtNo.Text = dgvList.Rows(e.RowIndex).Cells(0).Value

            cmbGroup.SelectedValue = dgvList.Rows(e.RowIndex).Cells(1).Value
            cmbList.SelectedValue = dgvList.Rows(e.RowIndex).Cells(2).Value
            cmbCategory.SelectedValue = dgvList.Rows(e.RowIndex).Cells(3).Value

            txtNo.ReadOnly = True

            btAdd.Enabled = False
            btEdit.Enabled = True
            btDel.Enabled = True
        End If

    End Sub
End Class