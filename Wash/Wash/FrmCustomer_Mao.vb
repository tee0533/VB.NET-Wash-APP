Public Class FrmCustomer_Mao
    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_Mao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_combobox()
    End Sub
    Private Sub init_combobox()
        Dim dt As DataTable = ClassServiceDb.getType_Mao()
        With cbType_Mao
            .ValueMember = "promotion_id"
            .DisplayMember = "promotion_name"
            .DataSource = dt
        End With
    End Sub

    Private Sub BtAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        add_to_datagrid()
    End Sub

    Private Sub add_to_datagrid()
        Try
            Dim Number As Integer = 1
            If (dgv.Rows.Count > 0) Then
                Number = dgv.Item(0, dgv.Rows.Count - 1).Value + 1
            End If
            Dim vMao As String = cbType_Mao.SelectedValue & "-" & cbType_Mao.Text
            Dim dt As DataTable = ClassServiceDb.getType_Mao(cbType_Mao.SelectedValue)
            Dim vPrice As String = dt.Rows(0).Item("price").ToString()
            Dim vDescriptions As String = dt.Rows(0).Item("descriptions").ToString()
            Dim row As String() = New String() {Number, vMao, vPrice, vDescriptions}
            If (dgv.Rows.Count > 0) Then
                MsgBox("มีข้อมูลในรายการแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            dgv.Rows.Add(row)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End Try
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        save_data()
    End Sub

    Private Sub save_data()
        If (ClassServiceDb.Check_Cus_Name_Data_Exist(txtName.Text.Trim())) Then

        Else
            Dim res() As String = ClassConnectDb.add_customer(txtName.Text.Trim, txtTel.Text, 2).Split("|")
            If (res(0) = "OK") Then

            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub
End Class