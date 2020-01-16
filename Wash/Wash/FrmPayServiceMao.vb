Public Class FrmPayServiceMao
    Public cus_id As String
    Private Sub txtPay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPay.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' ปุ่ม Backspace = 8,ปุ่ม Enter = 13, ปุ่มDelete = 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub FrmPayServicevb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChange.Text = String.Empty
        txtPay.Text = String.Empty
        Load_Data(cus_id)
        dgv.ClearSelection()
    End Sub

    Private Sub Load_Data(cus_id As String)
        Dim dt As DataTable = ClassServiceDb.getWash_Detail_Mao(cus_id)
        If (dt.Rows.Count > 0) Then
            txtName.Text = dt.Rows(0).Item("name").ToString()
            txtTel.Text = dt.Rows(0).Item("tel").ToString()
            txtAmount.Text = dt.Rows(0).Item("price").ToString()
            lblPriceTotal.Text = dt.Rows(0).Item("price").ToString()
        End If

        dt = ClassServiceDb.getWash_List_Mao(cus_id)
        dgv.DataSource = dt

        lbltotal.Text = dgv.Rows.Count

        For i = 0 To dgv.ColumnCount - 1
            Dim col As New DataGridViewColumn
            col = dgv.Columns(i)
            If (i = 1) Then
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Else
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End If

        Next
        dgv.CurrentCell = Nothing
        dt = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtChange.Text = String.Empty
        txtPay.Text = String.Empty
    End Sub

    Private Sub btnFit_Click(sender As Object, e As EventArgs) Handles btnFit.Click
        txtPay.Text = txtAmount.Text
    End Sub

    Private Sub btn100_Click(sender As Object, e As EventArgs) Handles btn100.Click
        If (txtPay.Text = String.Empty) Then
            txtPay.Text = +100
        Else
            txtPay.Text = Convert.ToDouble(txtPay.Text) + 100
        End If
    End Sub

    Private Sub btn500_Click(sender As Object, e As EventArgs) Handles btn500.Click
        If (txtPay.Text = String.Empty) Then
            txtPay.Text = +500
        Else
            txtPay.Text = Convert.ToDouble(txtPay.Text) + 500
        End If
    End Sub

    Private Sub btn1000_Click(sender As Object, e As EventArgs) Handles btn1000.Click
        If (txtPay.Text = String.Empty) Then
            txtPay.Text = +1000
        Else
            txtPay.Text = Convert.ToDouble(txtPay.Text) + 1000
        End If
    End Sub

    Private Sub btnPayService_Click(sender As Object, e As EventArgs) Handles btnPayService.Click
        If Check_Data() Then
            txtChange.Text = Convert.ToDouble(txtPay.Text) - Convert.ToDouble(txtAmount.Text).ToString
            Dim res() As String = ClassServiceDb.change_status_wash_mao(cus_id, txtPay.Text, txtChange.Text).Split("|")
            If (res(0) = "OK") Then
                MsgBox("บันทึกข้อมูลเรียบร้อย", MsgBoxStyle.Information, "Wash System")
                If MsgBox("คุณต้องการพิมพ์ใบเสร็จหรือไม่ ?", vbOKCancel + vbInformation) = vbOK Then

                    Try
                        Me.Close()
                        FrmViewer.cus_id = cus_id
                        FrmViewer.report_name = "รายงานใบเสร็จลูกค้าเหมา"
                        FrmViewer.ShowDialog()
                        FrmCusListMao.Load_Data()
                        FrmCusListMao.ShowDialog()
                    Catch ex As Exception

                    End Try
                Else
                    Try
                        Me.Close()
                        FrmCusListMao.Load_Data()
                        FrmCusListMao.ShowDialog()
                    Catch ex As Exception

                    End Try

                End If
            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "Wash System")
            End If

        End If
    End Sub
    Function Check_Data() As Boolean
        If (txtPay.Text = String.Empty) Then
            MsgBox("กรุณาระบุ จำนวนที่รับชำระ", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        If (Convert.ToDouble(txtPay.Text) < Convert.ToDouble(txtAmount.Text)) Then
            MsgBox("จำนวนที่รับชำระน้อยกว่าเงินที่ต้องชำระ", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        Return True
    End Function
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            FrmViewer.wash_id = cus_id
            FrmViewer.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Try
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub
End Class