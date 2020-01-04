Public Class FrmCusListGeneral
    Private Sub FrmCusList_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim dt As DataTable = ClassServiceDb.getWash_Header()
        dgvHeader.DataSource = dt
        Dim column As DataGridViewColumn = dgvHeader.Columns("ชื่อลูกค้า")
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        column = dgvHeader.Columns("วันที่รับ")
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        column = dgvHeader.Columns("เบอร์โทร")
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        column = dgvHeader.Columns("ราคา")
        column.Width = 120
        column = dgvHeader.Columns("สถานะ")
        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        For i = 0 To dgvHeader.Rows.Count - 1
            Dim vStatus = dgvHeader.Rows(i).Cells("สถานะ").Value.ToString
            If vStatus = "ส่งคืนแล้ว" Then
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Green
            Else
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim vWash_ID As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)


        If MsgBox("คุณต้องการลบรหัส " & vWash_ID & " ?", vbOKCancel + vbInformation) = vbOK Then
            Delete_Data(vWash_ID)
            Load_Data()

        End If
    End Sub

    Private Sub Delete_Data(vWash_ID As String)
        Dim Res() As String = ClassServiceDb.Delete_Wash_Header(vWash_ID).Split("|")
        If (Res(0) = "OK") Then
            MsgBox("ลบข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
        Else
            MsgBox(Res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim vWash_ID As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        FrmViewer.wash_id = vWash_ID
        FrmViewer.ShowDialog()
    End Sub
End Class