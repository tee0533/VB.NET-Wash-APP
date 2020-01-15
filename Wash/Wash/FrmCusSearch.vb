Public Class FrmCusSearch
    Public Search As String = String.Empty
    Private Sub btnSerach_Click(sender As Object, e As EventArgs) Handles btnSerach.Click
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim vSearch = txtName.Text.Trim()
        Dim dt As DataTable = ClassServiceDb.get_customer(vSearch)
        DataGridView1.Rows.Clear()
        For Each row As DataRow In dt.Rows
            Dim rows As String() = New String() {row("รหัส").ToString(), row("ชื่อลูกค้า").ToString(), row("เบอร์โทร").ToString(), row("โปรโมชั่น").ToString()}
            DataGridView1.Rows.Add(rows)
        Next


    End Sub

    Private Sub FrmCusSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Search
        Load_Data()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        CallValues()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        CallValues()
    End Sub
    Private Sub CallValues()
        If DataGridView1.Rows.Count <= 0 Then Exit Sub

        Dim index As Integer = DataGridView1.CurrentRow.Index
        Dim vCus_ID As String = Trim(DataGridView1.Rows(index).Cells("รหัส").Value.ToString)
        Dim vCus_Name As String = Trim(DataGridView1.Rows(index).Cells("ชื่อลูกค้า").Value.ToString)
        Dim vPromotion As String = Trim(DataGridView1.Rows(index).Cells("โปรโมชั่น").Value.ToString)
        Dim status As Boolean = ClassServiceDb.get_status_customer_mao(vCus_ID)
        If (status.Equals(False)) Then
            MsgBox("ลูกค้าชื่อ " & vCus_Name & " ยังไม่ชำระบริการ", MsgBoxStyle.Information, "Wash System")
            Exit Sub
        End If
        FrmCustomer_Mao_List.id = vCus_ID
        FrmCustomer_Mao_List.vname = vCus_Name
        FrmCustomer_Mao_List.vPromotion = vPromotion
        FrmCustomer_Mao_List.AssingValue()
        Me.Close()
    End Sub
End Class