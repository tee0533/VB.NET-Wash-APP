Public Class FrmCusListMao
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
    Public Sub Load_Data()
        Dim vSearch = txtSearch.Text.Trim()
        Dim dt As DataTable = ClassServiceDb.getWash_Header_Mao(vSearch)
        dgvHeader.DataSource = dt
        Dim column As DataGridViewColumn = dgvHeader.Columns("รหัส")
        For i = 0 To dgvHeader.ColumnCount - 1
            Dim col As New DataGridViewColumn
            col = dgvHeader.Columns(i)
            If (i = 3) Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Else
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End If
        Next
        For i = 0 To dgvHeader.Rows.Count - 1
            Dim vStatus = dgvHeader.Rows(i).Cells("สถานะ").Value.ToString
            If vStatus = "ชำระแล้ว" Then
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Green
            Else
                dgvHeader.Rows(i).DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub

    Private Sub FrmCusListMao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Load_Data()
    End Sub

    Private Sub BtnPayService_Click(sender As Object, e As EventArgs) Handles btnPayService.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim cus_id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        If (dgvHeader.Rows(index).Cells("สถานะ").Value.ToString() = "ชำระแล้ว") Then
            MsgBox("รหัส " & cus_id & " ชำระค่าบริการแล้ว", MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            Exit Sub
        End If
        FrmPayServiceMao.cus_id = cus_id
        FrmPayServiceMao.ShowDialog()
    End Sub

    Private Sub BtnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        FrmCustomer_Mao.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim cus_id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        Dim res As String = ClassServiceDb.Delete_Wash_Mao(cus_id)
        Load_Data()
    End Sub

    Private Sub btnPerpromotion_Click(sender As Object, e As EventArgs) Handles btnPerpromotion.Click
        If dgvHeader.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgvHeader.CurrentRow.Index
        Dim cus_id As String = Trim(dgvHeader.Rows(index).Cells("รหัส").Value.ToString)
        Dim promotion_name As String = Trim(dgvHeader.Rows(index).Cells("โปรโมชั่น").Value.ToString)
        FrmPromotion.promotion_name = promotion_name
        FrmPromotion.id = cus_id
        FrmPromotion.Show()
    End Sub
End Class