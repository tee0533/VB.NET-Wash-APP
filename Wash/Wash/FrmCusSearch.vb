Public Class FrmCusSearch
    Public Search As String = String.Empty
    Private Sub btnSerach_Click(sender As Object, e As EventArgs) Handles btnSerach.Click
        Load_Data()
    End Sub

    Private Sub Load_Data()
        Dim vSearch = txtName.Text.Trim()
        Dim dt As DataTable = ClassServiceDb.get_customer(vSearch)
        DataGridView1.DataSource = dt
        Dim column As DataGridViewColumn = DataGridView1.Columns("รหัส")
        For i = 0 To DataGridView1.ColumnCount - 1
            Dim col As New DataGridViewColumn
            col = DataGridView1.Columns(i)
            If (i = 1) Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If
        Next
    End Sub

    Private Sub FrmCusSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = Search
        Load_Data()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If DataGridView1.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = DataGridView1.CurrentRow.Index
        Dim vCus_ID As String = Trim(DataGridView1.Rows(index).Cells("รหัส").Value.ToString)
        Dim vCus_Name As String = Trim(DataGridView1.Rows(index).Cells("ชื่อ").Value.ToString)
        FrmCustomer_Mao_List.id = vCus_ID
        FrmCustomer_Mao_List.vname = vCus_Name
        FrmCustomer_Mao_List.AssingValue()
        Me.Close()
    End Sub
End Class