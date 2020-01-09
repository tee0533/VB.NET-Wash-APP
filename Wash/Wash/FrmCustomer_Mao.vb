Public Class FrmCustomer_Mao
    Public Action As String = "add"
    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_Mao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_combobox()
        dtpDate.Value = Date.Today
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
            Dim vAmount As String = dt.Rows(0).Item("amount").ToString()
            Dim vDescriptions As String = dt.Rows(0).Item("descriptions").ToString()
            Dim row As String() = New String() {Number, vMao, vAmount, vPrice, vDescriptions}
            If Action = "edit" Then
                dgv.Rows.Clear()
                dgv.Rows.Add(row)
                assign_total_price()
                Action = "add"
                Me.Text = "#การเพิ่มข้อมูล"
            Else
                If (dgv.Rows.Count > 0) Then
                    MsgBox("มีข้อมูลในรายการแล้ว", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                dgv.Rows.Add(row)
                assign_total_price()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End Try
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If Check_Data() Then
            save_data()
        End If

    End Sub

    Private Sub save_data()
        If (ClassServiceDb.Check_Cus_Name_Data_Exist_Mao(txtName.Text.Trim())) Then
            MsgBox("ลูกค้าชื่อ " & txtName.Text & " มีอยู่ในระบบลูกค้าเหมาแล้ว", MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        Else
            Dim res() As String = ClassConnectDb.add_customer(txtName.Text.Trim(), txtTel.Text, 2).Split("|")
            If (res(0) = "OK") Then
                save_list(res(1))
            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub

    Private Sub save_list(pCusID As String)
        Dim dt As DataTable = ConvertToDataTable()

        Dim res() As String = ClassServiceDb.add_wash_header_mao(pCusID, dt).Split("|")
        If (res(0) = "OK") Then
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
            Me.Close()
            Dim result As Integer = MessageBox.Show("ต้องการชำระบริการหรือไม่?", "Wash System", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                FrmPayServiceMao.cus_id = pCusID
                FrmPayServiceMao.Show()
            End If
            FrmCusListMao.Load_Data()
            FrmCusListMao.Show()
        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub
    Function ConvertToDataTable() As DataTable
        'Creating DataTable.
        Dim dt As New DataTable()

        'Adding the Columns.
        For Each column As DataGridViewColumn In dgv.Columns
            dt.Columns.Add(column.Name)
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

    Function Check_Data() As Boolean
        If (dgv.RowCount = 0) Then
            MsgBox("กรุณาใส่ข้อมูลเลือกชนิดการเหมา", MsgBoxStyle.Information, "Wash System")
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

    Private Sub BtDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            dgv.Rows.Remove(row)
        Next
        assign_total_price()
    End Sub

    Private Sub BtEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            Me.Text = "#การแก้ไขข้อมูล"
            Action = "edit"
            assign_data()
        Next

    End Sub

    Private Sub assign_data()
        If dgv.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgv.CurrentRow.Index
        Dim arrTypeMao = dgv.Rows(index).Cells("TypeMao").Value.ToString().Trim().Split("-")
        cbType_Mao.SelectedValue = arrTypeMao(0)
    End Sub

    Private Sub BtBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        Me.Close()
    End Sub

    Private Sub TxtTel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTel.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class