

Imports System.Globalization
Imports System.Text

Public Class FrmCustomer_Mao_List
    Public id As String
    Public vname As String
    Public vPromotion As String
    Public vBalance As String

    Public Action As String = "add"
    Public frm_Action As String = "add"
    Public list_mao_id As String
    Public Sub AssingValue()
        lblID.Text = id
        txtName.Text = vname
        txtPromotion.Text = vPromotion
        If (Not String.IsNullOrEmpty(id)) Then
            vBalance = ClassServiceDb.get_promotion_balance(id)
            Dim history() As String = ClassServiceDb.get_promotion_history(id).Trim().Split("|")
            Dim wash_history() As String = ClassServiceDb.get_wash_history(id).Trim().Split("|")
            Dim builder As New StringBuilder
            If (history.Count > 0 And history(0) <> String.Empty) Then
                builder.AppendLine("โปรโมชั่นที่เคยสมัคร:")
                For Each item As String In history
                    builder.AppendLine(item)
                Next
                builder.AppendLine()

            End If
            If (wash_history.Count > 0) Then
                builder.AppendLine("******************************")
                builder.AppendLine("วันเวลาที่เคยมาซัก:")
                For Each item As String In wash_history
                    If (Not String.IsNullOrEmpty(item)) Then
                        builder.AppendLine(item)
                    End If
                Next
            End If
            txtDetail.Text = builder.ToString()
            txtBalance.Text = vBalance
            assign_balance()
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'FrmCusSearch.Search = txtName.Text.Trim
        FrmCusSearch.Show()
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
        clear_data()
        dtpDate.Value = Date.Today
        init_combobox_group()
        If (frm_Action = "edit") Then
            bind_data()
        End If
    End Sub

    Private Sub clear_data()
        dgv.Rows.Clear()
        txtName.Text = String.Empty
        txtPromotion.Text = String.Empty
        txtDetail.Text = String.Empty
        txtNum.Text = 1
        txtBalance.Text = String.Empty
    End Sub

    Private Sub bind_data()
        Dim wash_id As String = ClassServiceDb.get_wash_id_mao_edit(list_mao_id)
        Dim dt As DataTable = ClassServiceDb.load_wash_header_mao_wash(wash_id)
        dgv.Rows.Clear()
        Dim i As Integer = 1
        If (dt.Rows.Count > 0) Then
            id = dt.Rows("0").Item("cus_id").ToString()
            vname = dt.Rows("0").Item("name").ToString()
            vPromotion = dt.Rows("0").Item("promotion_name").ToString()
            AssingValue()
            Try
                Dim Iron_wash As Integer = 0
                Dim vGroup As String = String.Empty
                Dim vList As String = String.Empty
                Dim vCount As String = String.Empty
                Dim row As String() = New String() {1, 2, 3, 4}
                For index As Integer = 0 To dt.Rows.Count - 1
                    vGroup = dt.Rows(index).Item("group_id").ToString() & "-" & dt.Rows(index).Item("group_name").ToString()
                    vList = dt.Rows(index).Item("list_id").ToString() & "-" & dt.Rows(index).Item("list_name").ToString()
                    vCount = dt.Rows(index).Item("number").ToString()
                    row = New String() {i, vGroup, vList, vCount}
                    dgv.Rows.Add(row)
                Next index


                If (txtPromotion.Text.Trim <> "เหมา 1000 บาท ไม่จำกัดชิ้น") Then
                    assign_balance()
                End If
                i += i
            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub cmbGroup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroup.SelectedIndexChanged
        If cmbGroup.Text = String.Empty Then
            Exit Sub
        End If
        init_combobox_list(cmbGroup.SelectedValue)
    End Sub

    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click
        Try

            If (lblID.Text = "" Or txtName.Text = "") Then
                MsgBox("กรุณาเลือกลูกค้าก่อนครับ", MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
                Exit Sub
            End If
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
            If Action = "edit" Then
                If dgv.Rows.Count <= 0 Then Exit Sub
                Dim index As Integer = dgv.CurrentRow.Index
                Dim order = dgv.Rows(index).Cells("order").Value.ToString().Trim()
                For Each rows As DataGridViewRow In dgv.SelectedRows
                    dgv.Rows.Remove(rows)
                Next
                dgv.Rows.Add(row)
                Action = "add"
                Me.Text = "#การเพิ่มข้อมูล"
            Else
                dgv.Rows.Add(row)

            End If
            If (txtPromotion.Text.Trim <> "เหมา 1000 บาท ไม่จำกัดชิ้น") Then
                assign_balance()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End Try
    End Sub

    Private Sub assign_balance()
        txtBalance.Text = 0
        Dim i As Integer = 0
        Try
            Do While dgv.RowCount > i
                txtBalance.Text = (CType(CType(txtBalance.Text, Integer) + CType(dgv.Rows(i).Cells("total").Value, Integer), String))
                i = i + 1
            Loop
            txtBalance.Text = CType(vBalance, Integer) - CType(txtBalance.Text, Integer)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        If (Check_Data()) Then

            If (frm_Action = "edit") Then 'แก้ไข
                Dim wash_id = ClassServiceDb.get_wash_id_mao_edit(list_mao_id)
                edit_data(wash_id)
            Else 'เพิ่มข้อมูล
                Dim wash_id = ClassServiceDb.get_wash_id_mao(id)
                Save_Header(id, wash_id)
            End If

        End If

    End Sub

    Private Sub edit_data(wash_id As String)
        Dim vtel As String = ClassServiceDb.get_cus_tel(id)
        Dim total As Integer
        Dim i As Integer = 0
        Do While dgv.RowCount > i
            total = total + CType(dgv.Rows(i).Cells("total").Value, Integer)
            i = i + 1
        Loop
        Dim res() As String = ClassConnectDb.edit_wash_header_status(wash_id, dtpDate.Value.ToString("yyyy-MM-dd"), txtName.Text.Trim(), vtel, total).Split("|")
        If (res(0) = "OK") Then
            res = ClassServiceDb.wash_list_mao(wash_id).Split("|")
            If (res(0) = "OK") Then
                Save_List(id, wash_id)
            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
            End If
        End If
    End Sub

    Function Check_Data() As Boolean
        If (txtPromotion.Text.Trim <> "เหมา 1000 บาท ไม่จำกัดชิ้น") Then
            If (CType(txtBalance.Text, Integer) < 0) Then
                MsgBox("โปรโมชั่นคงเหลือไม่พอสำหรับการซัก", MsgBoxStyle.Information, "Wash System")
                Return False
            End If
        Else 'เหมา 1000 บาท ไม่จำกัดชิ้น
            Dim vExpire_Date As String = ClassServiceDb.get_promotion_expire_date(id)
            If (Convert.ToDateTime(vExpire_Date).Date <= Now.Date) Then
                MsgBox("โปรโมชั่นของลูกค้าท่านนี้หมดอายุแล้ว", MsgBoxStyle.Information, "Wash System")
                Return False
            End If
        End If
        If (dgv.RowCount = 0) Then
            MsgBox("กรุณาใส่ข้อมูลการซัก", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        If (txtName.Text = String.Empty) Then
            MsgBox("กรุณาระบุ ชื่อลูกค้า", MsgBoxStyle.Information, "Wash System")
            Return False
        End If

        Return True
    End Function
    Private Sub Save_Header(ByVal cus_id As String, ByVal pWash_ID As String)
        Dim vtel As String = ClassServiceDb.get_cus_tel(cus_id)
        Dim total As Integer
        Dim i As Integer = 0
        Do While dgv.RowCount > i
            total = total + CType(dgv.Rows(i).Cells("total").Value, Integer)
            i = i + 1
        Loop
        Dim res() As String = ClassConnectDb.add_wash_header_status(pWash_ID, dtpDate.Value.ToString("yyyy-MM-dd"), txtName.Text.Trim(), vtel, total).Split("|")
        If (res(0) = "OK") Then
            Save_List(cus_id, pWash_ID)
        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub
    Private Sub Save_List(ByVal pCusID As String, ByVal pWash_ID As String)
        Dim dt As DataTable = ConvertToDataTable()

        Dim res() As String = ClassServiceDb.add_wash_list_mao(pCusID, pWash_ID, dt).Split("|")
        If (res(0) = "OK") Then
            save_history(pWash_ID, txtBalance.Text)
            MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
            Try
                Me.Close()
                FrmCusListMao.Load_Data()
                FrmCusListMao.Show()
            Catch ex As Exception
            End Try

        Else
            MsgBox(res(1), MsgBoxStyle.Critical, "เกิดข้อผิดพลาด")
        End If
    End Sub

    Private Sub save_history(wash_id As String, balance As String)
        Dim vDate As String = DateTime.Now.ToString("dd/MM/yyyy", New CultureInfo("en-US"))
        Dim vTime As String = DateTime.Now.ToString("HH:mm:ss", New CultureInfo("en-US"))
        Dim vMsg As String = "|" + vDate + " " + vTime
        ClassConnectDb.save_history_mao(wash_id, vMsg, balance)
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

    Private Sub btDel_Click(sender As Object, e As EventArgs) Handles btDel.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            dgv.Rows.Remove(row)
        Next
        assign_balance()
    End Sub

    Private Sub btEdit_Click(sender As Object, e As EventArgs) Handles btEdit.Click
        For Each row As DataGridViewRow In dgv.SelectedRows
            Me.Text = "#การแก้ไขข้อมูล"
            Action = "edit"
            assign_data()
        Next
    End Sub
    Private Sub assign_data()
        If dgv.Rows.Count <= 0 Then Exit Sub
        Dim index As Integer = dgv.CurrentRow.Index
        Dim arrGroup = dgv.Rows(index).Cells("group").Value.ToString().Trim().Split("-")
        Dim arrList = dgv.Rows(index).Cells("list").Value.ToString().Trim().Split("-")
        cmbGroup.SelectedValue = arrGroup(0)
        cmbList.SelectedValue = arrList(0)
    End Sub
End Class