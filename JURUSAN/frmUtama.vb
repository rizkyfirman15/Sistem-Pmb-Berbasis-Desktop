Imports System.Windows.Forms

Public Class MDIParent1


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub DataPendaftarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPendaftarToolStripMenuItem.Click
        frmPendaftar.MdiParent = Me
        frmPendaftar.Show()
        frmPendaftar.BringToFront()
    End Sub

    Private Sub DataPenilaianPenjurusanSAWToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataPenilaianPenjurusanSAWToolStripMenuItem.Click
        frmPenilaian.MdiParent = Me
        frmPenilaian.Show()
        frmPenilaian.BringToFront()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Enabled = True
        Timer3.Enabled = False
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmTentang.MdiParent = Me
        frmTentang.Show()
        frmTentang.BringToFront()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label1.Left >= Panel1.Width Then
            Label1.Left = Panel1.Width
            Timer2.Enabled = False
            Timer3.Enabled = True
        Else
            Label1.Left = Label1.Left + 8
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Label1.Left <= -Label1.Width Then
            Label1.Left = -Label1.Width
            Timer3.Enabled = False
            Timer2.Enabled = True
        Else
            Label1.Left = Label1.Left - 8
        End If
    End Sub
End Class
