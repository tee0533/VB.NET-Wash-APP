Public Class FrmCustomer
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initial_frm()
        init_combobox_group()
        init_combobox_category()
    End Sub
    Private Sub Initial_frm()
        dtpDate.Value = Date.Today
        Load_Data()
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
    Private Sub init_combobox_category()
        Dim dt As DataTable = ClassServiceDb.getgroup_category()

        With cmbCategory
            .DisplayMember = "CategoryName"
            .ValueMember = "CategoryID"
            .DataSource = dt
        End With
    End Sub
    Private Sub Load_Data()
        Dim dt As DataTable = ClassConnectDb.Query_TBL("
SELECT TOP (1000) [groupid]
      ,[groupname]
  FROM [WashingStore].[dbo].[groupcloth]")

    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If cmbGroup.Text = String.Empty Then
            Exit Sub
        End If
        init_combobox_list(cmbGroup.SelectedValue)
    End Sub

    Private Sub txtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกค่าเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Select
    End Sub

    Private Sub txtNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกค่าเป็นตัวเลข", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Select
    End Sub

    Private Sub CheckEz_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEz.CheckedChanged
        If (CheckEz.Checked = True) Then
            CheckHard.Checked = False
            CheckMid.Checked = False
        End If
    End Sub

    Private Sub CheckMid_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMid.CheckedChanged
        If (CheckMid.Checked = True) Then
            CheckHard.Checked = False
            CheckEz.Checked = False
        End If
    End Sub

    Private Sub CheckHard_CheckedChanged(sender As Object, e As EventArgs) Handles CheckHard.CheckedChanged
        If (CheckHard.Checked = True) Then
            CheckMid.Checked = False
            CheckEz.Checked = False
        End If
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        Dim Number As Integer = 1
        If (dgv.Rows.Count > 0) Then
            Number = dgv.Item(0, dgv.Rows.Count - 1).Value + 1
        End If

        Dim vGroup As String = cmbGroup.Text
        Dim vList As String = cmbList.Text
        Dim vCategory As String = cmbCategory.Text
        Dim vCount As String = txtNum.Text
        Dim vPrice As String = 10 * Convert.ToInt32(vCount)
        Dim row As String() = New String() {Number, vGroup, vList, vCategory, vCount, vPrice}
        dgv.Rows.Add(row)
    End Sub

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            dgv.Rows.Remove(row)
        Next
    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        If (Check_Data()) Then
            Save_Data()
        End If
    End Sub
    Function Check_Data() As Boolean
        If (txtName.Text = String.Empty) Then
            MsgBox("กรุณาระบุ ชื่อลูกค้า", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        If (txtTel.Text = String.Empty) Then
            MsgBox("กรุณาระบุ เบอร์โทร", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        Return True
    End Function
    Private Sub Save_Data()

        Dim res() As String = ClassConnectDb.add_customer(txtName.Text.Trim, txtTel.Text).Split("|")
        If (res(0) = "OK") Then
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
        Else
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Critical, "Wash System")
        End If
    End Sub
End Class