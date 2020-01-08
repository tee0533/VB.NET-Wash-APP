

Public Class FrmCustomer_Mao_List
    Public id As String
    Public vname As String
    Public Sub AssingValue()
        lblID.Text = id
        txtName.Text = vname
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FrmCusSearch.Search = txtName.Text.Trim
        FrmCusSearch.ShowDialog()
    End Sub
    Private Sub init_combobox_group()
        Dim dt As DataTable = ClassServiceDb.getgroup_cloth()
        With cmbGroup
            .DisplayMember = "groupname"
            .ValueMember = "groupid"
            .DataSource = dt
        End With
    End Sub
    Private Sub init_combobox_list(pGroupID As String)
        Dim dt As DataTable = ClassServiceDb.getList(pGroupID)

        With cmbList
            .DisplayMember = "ListName"
            .ValueMember = "ListNo"
            .DataSource = dt
        End With
    End Sub

    Private Sub FrmCustomer_Mao_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_combobox_group()
    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If cmbGroup.Text = String.Empty Then
            Exit Sub
        End If
        init_combobox_list(cmbGroup.SelectedValue)
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try


            Dim Number As Integer = 1
            If (dgv.Rows.Count > 0) Then
                Number = dgv.Item(0, dgv.Rows.Count - 1).Value + 1
            End If
            Dim Iron_wash As Integer = 0

            Dim vGroup As String = cmbGroup.SelectedValue & "-" & cmbGroup.Text
            Dim vList As String = cmbList.SelectedValue & "-" & cmbList.Text
            Dim vCount As String = txtNum.Text
            Dim Level As String = String.Empty

            Dim row As String() = New String() {Number, vGroup, vList, vCount}
            dgv.Rows.Add(row)
            assign_balance()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End Try
    End Sub

    Private Sub assign_balance()

    End Sub
End Class