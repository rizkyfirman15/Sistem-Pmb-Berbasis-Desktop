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
End Class