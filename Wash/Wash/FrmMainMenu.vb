Public Class FrmMainMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FrmLogin.ShowDialog()

    End Sub

    Private Sub MenuGeneral_Click(sender As Object, e As EventArgs) Handles MenuGeneral.Click
        FrmCustomer.Show()
    End Sub
End Class