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
End Class