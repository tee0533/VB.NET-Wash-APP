Imports System.Globalization

Public Class FrmCustomer_Mao
    Public Action As String = "add"
    Public Frm_Action As String = "add"
    Public cus_id As String = "add"
    Private Sub BtMenu_Click(sender As Object, e As EventArgs) Handles btMenu.Click
        Me.Close()
    End Sub

    Private Sub FrmCustomer_Mao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear_data()
        init_combobox()
        dtpDate.Value = Date.Today
        If (Frm_Action = "edit") Then
            btAdd.Visible = False
            bind_data()
        Else
            btAdd.Visible = True
        End If
    End Sub

    Private Sub clear_data()
        dgv.Rows.Clear()
        txtName.Text = String.Empty
        txtTel.Text = String.Empty

    End Sub

    Private Sub bind_data()
        Dim dt As DataTable = ClassServiceDb.load_wash_header_mao(cus_id)
        dgv.Rows.Clear()
        If (dt.Rows.Count > 0) Then
            txtName.Text = dt.Rows(0).Item("name")
            txtTel.Text = dt.Rows(0).Item("tel")
            cbType_Mao.SelectedValue = dt.Rows(0).Item("promotion_id")
            Try
                Dim Number As Integer = 1
                Dim vMao As String = dt.Rows(0).Item("promotion_id") & "-" & dt.Rows(0).Item("promotion_name")
                Dim vPrice As String = dt.Rows(0).Item("price").ToString()
                Dim vAmount As String = dt.Rows(0).Item("amount").ToString()
                Dim vDescriptions As String = dt.Rows(0).Item("description").ToString()
                Dim row As String() = New String() {Number, vMao, vAmount, vPrice, vDescriptions}
                dgv.Rows.Add(row)
                assign_total_price()
            Catch ex As Exception

            End Try
        End If
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
            If (Frm_Action = "edit") Then
                save_customer()
            Else
                save_data()
            End If

        End If

    End Sub

    Private Sub save_customer()
        Dim res() As String = ClassServiceDb.update_customer(cus_id, txtName.Text.Trim(), txtTel.Text.Trim()).Split("|")
        If (res(0) = "OK") Then
            MsgBox("บันทึกข้อมูลเรียบร้อยแล้ว", MsgBoxStyle.Information, "การบันทึกข้อมูล")
            FrmCusListMao.Load_Data()
            Me.Close()

        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
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
        Dim vExpire_Date As Date = Today.AddDays(30)
        Dim Expire As String = String.Empty

        If (cbType_Mao.SelectedValue = 3) Then
            vExpire_Date = Today.AddDays(30)
            Expire = vExpire_Date.ToString("yyy-MM-dd", New CultureInfo("en-US"))
        Else
            Expire = Now.ToString("yyy-MM-dd", New CultureInfo("en-US"))
        End If
        Dim res() As String = ClassConnectDb.add_wash_header_mao(pCusID, Expire, dt).Split("|")
        If (res(0) = "OK") Then
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
            Me.Close()
            Dim result As Integer = MessageBox.Show("ต้องการชำระบริการหรือไม่?", "Wash System", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Try
                    FrmPayServiceMao.cus_id = pCusID
                    FrmPayServiceMao.ShowDialog()
                Catch ex As Exception

                End Try

            Else
                Try
                    FrmCusListMao.Load_Data()
                    FrmCusListMao.ShowDialog()
                Catch ex As Exception

                End Try
            End If

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