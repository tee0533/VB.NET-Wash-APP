Imports System.Globalization

Public Class FrmPromotion
    Public Property promotion_name As String
    Public Property id As String
    Private Sub FrmPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPromotion.Text = promotion_name()
        initCombobox()
        lblID.Text = id

    End Sub
    Private Sub initCombobox()
        Dim dt As DataTable = ClassServiceDb.get_promotion()
        cbPromotion.Items.Clear()
        With cbPromotion
            .DisplayMember = "promotion_name"
            .ValueMember = "promotion_id"
            .DataSource = dt
        End With
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Dim promotion_id As String = String.Empty
        Dim balance As Integer
        Dim expire_date As String = Now.Date.ToString("yyyy-MM-dd", New CultureInfo("en-US"))
        Dim dt As DataTable = ClassServiceDb.get_wash_header_mao(id)
        If (dt.Rows.Count > 0) Then
            promotion_id = dt.Rows(0).Item("promotion_id").ToString()
            balance = dt.Rows(0).Item("balance").ToString()
            expire_date = dt.Rows(0).Item("expire_date").ToString()
        End If
        dt = ClassServiceDb.getType_Mao(cbPromotion.SelectedValue)
        If (promotion_id = "3") Then
            balance = 0
            If (Convert.ToDateTime(expire_date).Date > Now.Date) Then
                expire_date = Convert.ToDateTime(expire_date).AddDays(30).Date.ToString("yyyy-MM-dd", New CultureInfo("en-US"))
            End If
        Else
            expire_date = Convert.ToDateTime(expire_date).ToString("yyyy-MM-dd", New CultureInfo("en-US"))
            If (balance > 0) Then
                balance = balance + Convert.ToInt16(dt.Rows(0).Item("amount"))
            Else
                balance = Convert.ToInt16(dt.Rows(0).Item("amount"))
            End If
        End If
        If MsgBox("คุณต้องการต่อโปรโมชั่นเป็น " & cbPromotion.Text & " หรือไม่ ?", vbOKCancel + vbInformation) = vbOK Then
            Dim res() As String = ClassConnectDb.update_promotion(lblID.Text, txtPromotion.Text, cbPromotion.SelectedValue, cbPromotion.Text, expire_date, balance).Split("|")
            If (res(0) = "OK") Then
                MsgBox("ต่อโปรโมชั่นเรียบร้อย", MsgBoxStyle.Information, "Wash System")
                Me.Close()
            Else
                MsgBox(res(1), MsgBoxStyle.Critical, "Wash System")
            End If


        Else

        End If
    End Sub
End Class