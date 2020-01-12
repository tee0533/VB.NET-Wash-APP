Public Class FrmPromotion
    Public Property promotion_name As String
    Public Property id As String
    Private Sub FrmPromotion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPromotion.Text = promotion_name()
        lblID.Text = id
        Dim dt As DataTable = ClassServiceDb.get_promotion()
        cbPromotion.Items.Clear()
        With cbPromotion
            .DisplayMember = "promotion_name"
            .ValueMember = "promotion_id"
            .DataSource = dt
        End With
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If MsgBox("คุณต้องการต่อโปรโมชั่นเป็น " & cbPromotion.Text & " หรือไม่ ?", vbOKCancel + vbInformation) = vbOK Then
            Dim res() As String = ClassConnectDb.update_promotion(lblID.Text, txtPromotion.Text, cbPromotion.SelectedValue, cbPromotion.Text).Split("|")
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