Public Class FrmCusListMao_Status
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Public Sub Load_Data()
        Dim vSearch = txtSearch.Text.Trim()
        Dim dt As DataTable = ClassServiceDb.getWash_Header_Mao_status(vSearch)
        dgvHeader.Rows.Clear()
        For Each row As DataRow In dt.Rows
            Dim rows As String() = New String() {row("wash_date").ToString(), row("id").ToString(), row("cus_name").ToString(), row("cus_tel").ToString(), row("number").ToString(), row("status").ToString()}
            dgvHeader.Rows.Add(rows)
        Next
        For i = 0 To dgvHeader.Rows.Count - 1
            Dim vStatus = dgvHeader.Rows(i).Cells("status").Value.ToString()
            If vStatus = "ส่งคืนแล้ว" Then
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Green
            Else
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub FrmCusListMao_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        If MsgBox("คุณต้องการส่งคืนผ้าหรือไม่ ?", vbOKCancel + vbInformation) = vbOK Then
            ClassServiceDb.change_status_wash_mao_status(id)
            Load_Data()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim cus_id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        If MsgBox("คุณต้องการลบรหัส " & cus_id & " ?", vbOKCancel + vbInformation) = vbOK Then
            Dim res As String = ClassServiceDb.Delete_Wash_Mao(cus_id)
            Load_Data()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        Dim status As String = Trim(dgvHeader.Rows(index).Cells("status").Value.ToString)
        If (status = "ส่งคืนแล้ว") Then
            MsgBox("ไม่สามารถแก้ไขได้ เนื่องจาก สถานะส่งคืนแล้ว", MsgBoxStyle.Information, "เกิดข้อผิดพลาด")
            Exit Sub
        End If
        FrmCustomer_Mao_List.list_mao_id = id
        FrmCustomer_Mao_List.frm_Action = "edit"
        FrmCustomer_Mao_List.ShowDialog()
        Load_Data()
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        FrmCustomer_Mao.ShowDialog()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Load_Data()
    End Sub
End Class