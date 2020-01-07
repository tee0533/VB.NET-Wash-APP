Public Class FrmLogin
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Check_Data() Then
            If (txtUsername.Text.ToUpper = "ADMIN") And (txtPassword.Text.ToUpper = "ADMIN") Then
                vLogInSuccess = True
                Me.Hide()
                FrmMainMenu.UseWaitCursor = False
                FrmMainMenu.Show()
            Else
                vLogInSuccess = False
            End If
        End If
    End Sub
    Function Check_Data() As Boolean
        If (txtUsername.Text = String.Empty) Then
            MsgBox("กรุณาระบุ ชื่อผู้ใช้งาน", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        If (txtUsername.Text = String.Empty) Then
            MsgBox("กรุณาระบุ รหัสผ่าน", MsgBoxStyle.Information, "Wash System")
            Return False
        End If
        Return True
    End Function
    Private Sub Login()
        If (txtUsername.Text = String.Empty) Then
            MessageBox.Show("กรุณาระบุ ชื่อผู้ใช้งาน")
        End If
        If (txtUsername.Text = String.Empty) Then
            MessageBox.Show("กรุณาระบุ รหัสผ่าน")
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub FrmLogin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If vLogInSuccess Then
            Dim Mainmenu As New FrmMainMenu
            Mainmenu.Show()
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class