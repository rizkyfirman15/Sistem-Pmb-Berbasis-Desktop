Public Class frmPendaftar

    Private Sub cmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBaru.Click
        hapus()
        txtNo.Focus()
    End Sub

    Sub hapus()
        txtNo.Text = ""
        txtNama.Text = ""
        cmbJenis.Text = ""
        txtTmpt.Text = ""
        dtTanggal.Value = Now
        cmbAgama.Text = ""
        txtAlamat.Text = ""
        txtAyah.Text = ""
        txtIbu.Text = ""
        txtPAyah.Text = ""
        txtPIbu.Text = ""
    End Sub

    Dim WithEvents daftar As New DB_MYSQL
    Dim sql As String = "select * from pendaftar order by no"

    Private Sub frmPendaftar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        daftar.NamaDatabase = "spkjurusan"
        daftar.NamaTabel = "pendaftar"

        Dim des() As String = {"no", "nama", "jeniskelamin", "tempatlahir", "tanggallahir", "agama", "alamat", "namaayah", "namaibu", "pekerjaanayah", "pekerjaanibu"}
        Dim va() = {txtNo, txtNama, cmbJenis, txtTmpt, dtTanggal, cmbAgama, txtAlamat, txtAyah, txtIbu, txtPAyah, txtPIbu}

        Dim deslv() As String = {"Nomor Penerimaan", "Nama Mahasiswa", "Jenis Kelamin", "Tempat Lahir", "Tanggal Lahir", "Agama", "Alamat", "Nama Ayah", "Nama Ibu", "Pekerjaan Ayah", "Pekerjaan Ibu"}
        Dim size() As Integer = {100, 300, 200, 200}

        daftar.DeskripsiTAbel = des
        daftar.ObjekTabelValue = va
        daftar.ListViewKu.Tambah(Me.ListView1, deslv, size, sql)
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        daftar.Aksi = DB_MYSQL.enumAksi.Simpan
        hapus()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        daftar.Aksi = DB_MYSQL.enumAksi.Edit
        hapus()
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        daftar.Aksi = DB_MYSQL.enumAksi.Hapus
        hapus()
    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        hapus()
        cmdBaru.Focus()
    End Sub

    Private Sub cmdKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub daftar_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Teredit
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub daftar_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Terhapus
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub daftar_Setelah_Data_Terkoneksi(ByVal Pesan As String) Handles daftar.Setelah_Data_Terkoneksi

    End Sub

    Private Sub daftar_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles daftar.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        daftar.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 1 Then
            With ListView1.SelectedItems(0)
                txtNo.Text = .SubItems(1).Text
                txtNama.Text = .SubItems(2).Text
                cmbJenis.Text = .SubItems(3).Text
                txtTmpt.Text = .SubItems(4).Text
                dtTanggal.Value = DateValue(.SubItems(5).Text)
                cmbAgama.Text = .SubItems(6).Text
                txtAlamat.Text = .SubItems(7).Text
                txtAyah.Text = .SubItems(8).Text
                txtIbu.Text = .SubItems(9).Text
                txtPAyah.Text = .SubItems(10).Text
                txtPIbu.Text = .SubItems(11).Text
            End With
        End If
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
