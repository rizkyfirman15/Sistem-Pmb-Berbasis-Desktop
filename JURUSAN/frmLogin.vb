Public Class frmLogin

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If txtUser.Text = "admin" And txtLogi.Text = "admin" Then
            Me.Hide()
            MDIParent1.Show()
        End If
    End Sub

    Private Sub cmdKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeluar.Click
        End
    End Sub

    Private Sub txtLogi_TextChanged(sender As Object, e As EventArgs) Handles txtLogi.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txtLogi.PasswordChar = ""
        Else
            txtLogi.PasswordChar = "*"
        End If
    End Sub
End Class