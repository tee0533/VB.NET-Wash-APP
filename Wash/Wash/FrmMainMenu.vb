Public Class FrmMainMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
    End Sub

    Private Sub MenuGeneral_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuAddCusGeneral_Click(sender As Object, e As EventArgs) Handles MenuAddCusGeneral.Click
        FrmCustomer.Show()
    End Sub

    Private Sub MenuGeneral_Click_1(sender As Object, e As EventArgs) Handles MenuGeneral.Click
        FrmCusListGeneral.Show()
    End Sub

    Private Sub MenuAddCusMao_Click(sender As Object, e As EventArgs) Handles MenuAddCusMao.Click
        FrmCustomer_Mao.Show()
    End Sub

    Private Sub FrmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub MenuCusMao_Click(sender As Object, e As EventArgs) Handles MenuCusMao.Click
        FrmCusListMao.Show()
    End Sub
End Class