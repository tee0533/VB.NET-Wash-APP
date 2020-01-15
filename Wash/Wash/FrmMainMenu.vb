Public Class FrmMainMenu
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("ท่านต้องการออกจากโปรแกรมใช่หรือไม่", vbInformation + vbYesNo) = vbYes Then
            Application.Exit()
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
        FrmCustomer.ShowDialog()
    End Sub

    Private Sub MenuGeneral_Click_1(sender As Object, e As EventArgs) Handles MenuGeneral.Click
        FrmCusListGeneral.ShowDialog()
    End Sub

    Private Sub MenuAddCusMao_Click(sender As Object, e As EventArgs) Handles MenuAddCusMao.Click
        FrmCustomer_Mao.ShowDialog()
    End Sub

    Private Sub FrmMainMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub MenuCusMao_Click(sender As Object, e As EventArgs) Handles MenuCusMao.Click
        Try
            FrmCusListMao.Close()
            FrmCusListMao.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MenuCusMao_Cometowash_Click(sender As Object, e As EventArgs) Handles MenuCusMao_Cometowash.Click
        Try
            FrmCustomer_Mao_List.frm_Action = "add"
            FrmCustomer_Mao_List.list_mao_id = 0
            FrmCustomer_Mao_List.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MenuCusMao_Status_Click(sender As Object, e As EventArgs) Handles MenuCusMao_Status.Click
        FrmCusListMao_Status.ShowDialog()
    End Sub
End Class