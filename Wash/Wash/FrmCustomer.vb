Imports System.Globalization

Public Class FrmCustomer
    Dim wash_id As String
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initial_frm()
        init_combobox_group()
        init_combobox_category()
        AutoComplete()
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
        Try
            Dim vPriceRolled As Integer = 0
            If (cmbCategory.Text.Trim = "รีดอย่างเดียว") Then
                If (CheckHard.Checked = False And CheckMid.Checked = False And CheckEz.Checked = False) Then
                    MsgBox("กรุณาเลือก ง่าย กลาง ยาก", MsgBoxStyle.Information, "Wash System")
                    Return
                End If
                If (CheckEz.Checked = True) Then
                    vPriceRolled = 5
                ElseIf (CheckMid.Checked = True) Then
                    vPriceRolled = 10
                Else
                    vPriceRolled = 15
                End If
            End If

            Dim Number As Integer = 1
            If (dgv.Rows.Count > 0) Then
                Number = dgv.Item(0, dgv.Rows.Count - 1).Value + 1
            End If

            Dim vGroup As String = cmbGroup.SelectedValue & "-" & cmbGroup.Text
            Dim vList As String = cmbList.SelectedValue & "-" & cmbList.Text
            Dim vCategory As String = cmbCategory.SelectedValue & "-" & cmbCategory.Text
            Dim vCount As String = txtNum.Text
            Dim vUnit_price As Integer = ClassServiceDb.getProductPrice(cmbList.SelectedValue)
            Dim vPrice As String = (vUnit_price + vPriceRolled) * Convert.ToInt32(vCount)
            Dim Level As String = String.Empty
            If (cmbCategory.Text.Trim = "รีดอย่างเดียว") Then
                If (CheckEz.Checked) Then
                    Level = "ง่าย-5"
                ElseIf (CheckMid.Checked) Then
                    Level = "กลาง-10"
                Else
                    Level = "ยาก-15"
                End If
            End If
            Dim row As String() = New String() {Number, vGroup, vList, vCategory, Level, vCount, vUnit_price, vPrice}
            dgv.Rows.Add(row)
            assign_total_price()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End Try

    End Sub

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            dgv.Rows.Remove(row)
        Next
        assign_total_price()

    End Sub

    Private Sub btPrint_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If (Check_Data()) Then

            Dim result As Integer = MessageBox.Show("คุณต้องการบันทึกข้อมูลหรือไม่ ?", "Wash System", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Save_Data()
            End If

        End If
    End Sub
    Function Check_Data() As Boolean
        If (dgv.RowCount = 0) Then
            MsgBox("กรุณาใส่ข้อมูลการซักหรือการรีด", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
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
        If (ClassServiceDb.Check_Cus_Name_Data_Exist(txtName.Text.Trim())) Then
            Save_Header(ClassServiceDb.get_cus_id(txtName.Text.Trim()))
        Else
            Dim res() As String = ClassConnectDb.add_customer(txtName.Text.Trim, txtTel.Text).Split("|")
            If (res(0) = "OK") Then
                Save_Header(res(1))
            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            End If
        End If

    End Sub
    Private Sub PrintReport()
        FrmViewer.wash_id = wash_id
        FrmViewer.Show()
    End Sub
    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        If (cmbCategory.Text.Trim = "ซักอย่างเดียว") Then
            CheckMid.Checked = False
            CheckHard.Checked = False
            CheckEz.Checked = False
            pnlOption.Visible = False
        Else
            pnlOption.Visible = True
        End If
    End Sub
    Private Sub Save_Header(ByVal pCusID As String)
        Dim strDate = dtpDate.Value.ToString("dd/MM/yyyy", New CultureInfo("en-US"))
        Dim res() As String = ClassConnectDb.add_wash_header(pCusID, strDate, txtTotal_Price.Text).Split("|")
        If (res(0) = "OK") Then
            wash_id = res(1)
            Save_List(pCusID, res(1))
        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub
    Private Sub Save_List(ByVal pCusID As String, ByVal pWash_ID As String)
        Dim dt As DataTable = ConvertToDataTable()

        Dim res() As String = ClassServiceDb.add_wash_list(pCusID, pWash_ID, dt).Split("|")
        If (res(0) = "OK") Then
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
            Me.Close()
            FrmCusListGeneral.Show()
        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub
    Function ConvertToDataTable() As DataTable
        'Creating DataTable.
        Dim dt As New DataTable()

        'Adding the Columns.
        For Each column As DataGridViewColumn In dgv.Columns
            dt.Columns.Add(column.HeaderText)
        Next

        'Adding the Rows.
        For Each row As DataGridViewRow In dgv.Rows
            dt.Rows.Add()
            For Each cell As DataGridViewCell In row.Cells
                dt.Rows(dt.Rows.Count - 1)(cell.ColumnIndex) = cell.Value.ToString()
            Next
        Next
        Return dt
    End Function
    Private Sub btNew_Click(sender As Object, e As EventArgs) Handles btNew.Click
        dgv.Rows.Clear()
        txtTotal_Price.Text = 0
    End Sub
    Private Sub AutoComplete()
        Dim autoComp As New AutoCompleteStringCollection()
        Dim dt As DataTable = ClassServiceDb.Load_Name_Customer()
        For Each row As DataRow In dt.Rows
            autoComp.Add(row("name"))
        Next
        txtName.AutoCompleteMode = AutoCompleteMode.Suggest
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = autoComp
    End Sub
    Sub assign_total_price()
        txtTotal_Price.Text = 0
        Dim i As Integer = 0
        Try
            Do While dgv.RowCount > i
                txtTotal_Price.Text = CType(CType(txtTotal_Price.Text, Integer) + CType(dgv.Rows(i).Cells("price").Value, Integer), String)
                i = i + 1
            Loop
        Catch ex As Exception

        End Try
    End Sub
End Class