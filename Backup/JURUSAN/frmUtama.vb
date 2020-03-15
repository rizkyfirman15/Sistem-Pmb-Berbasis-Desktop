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
End Class
