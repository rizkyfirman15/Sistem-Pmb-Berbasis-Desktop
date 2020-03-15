Imports System.Math

Public Class frmPenilaian
    Dim WithEvents nilai As New DB_MYSQL
    Dim sql As String = "select no_pendaftar,nama,minatBDKMSI,minatBPB,utpBDKMSI,utpBPB,ukBDKMSI,ukBPB,w1,w2,w3 from penilaian,pendaftar where penilaian.no_pendaftar=pendaftar.no"

    Dim WithEvents daftar As New DB_MYSQL

    Private Sub frmPenilaian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        nilai.NamaDatabase = "spkjurusan"
        nilai.NamaTabel = "penilaian"

        Dim des() As String = {"no_pendaftar", "minatBDKMSI", "minatBPB", "utpBDKMSI", "utpBPB", "ukBDKMSI", "ukBPB", "w1", "w2", "w3"}
        Dim va() = {cmbNoDaftar, c1(c1a.Checked), c1(c1b.Checked), c2a, c2b, c3a, c3b, w1, w2, w3}

        Dim desLv() As String = {"No Pendaftar", "Nama Mahasiswa", "Minat BDKMSI", "Minat BPB", "UTS BDKMSI", "UTS BPB", "UK BDKMSI", "UK BPB", "W1", "W2", "W3"}
        Dim siz() As Integer = {100, 200, 100}

        nilai.DeskripsiTAbel = des
        nilai.ObjekTabelValue = va

        nilai.ListViewKu.Tambah(Me.ListView1, desLv, siz, sql)
        nilai.TeksContainer.Tambah(Me.cmbNoDaftar, "no", "pendaftar")

        daftar.NamaDatabase = "spkjurusan"
        daftar.NamaTabel = "pendaftar"

        Dim des2() As String = {"no", "nama", "jeniskelamin", "tempatlahir", "tanggallahir", "alamat", "agama", "namaayah", "namaibu", "pekerjaanayah", "pekerjaanibu"}
        Dim va2() = {cmbNoDaftar}

        daftar.DeskripsiTAbel = des2
        daftar.ObjekTabelValue = va2
    End Sub


    Function c1(ByVal d As Boolean) As String
        If d Then
            Return "m"
        Else
            Return "t"
        End If
    End Function

    Sub hapus()
        cmbNoDaftar.Text = ""
        txtNama.Text = ""
        c2a.Text = ""
        c2b.Text = ""
        c3a.Text = ""
        c3b.Text = ""
        w1.Text = ""
        w2.Text = ""
        w3.Text = ""
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        nilai.Aksi = DB_MYSQL.enumAksi.Simpan

    End Sub

    Private Sub cmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBatal.Click
        hapus()
    End Sub

    Private Sub cmdKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeluar.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        nilai.Aksi = DB_MYSQL.enumAksi.Edit
    End Sub

    Dim seleksi As Boolean = False

    Private Sub ListView1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If ListView1.SelectedItems.Count = 1 Then
            With ListView1.SelectedItems(0)
                cmbNoDaftar.Text = .SubItems(1).Text
                If .SubItems(3).Text = "m" Then c1a.Checked = True
                If .SubItems(4).Text = "m" Then c1b.Checked = True
                c2a.Text = .SubItems(5).Text
                c2b.Text = .SubItems(6).Text
                c3a.Text = .SubItems(7).Text
                c3b.Text = .SubItems(8).Text
                w1.Text = .SubItems(9).Text
                w2.Text = .SubItems(10).Text
                w3.Text = .SubItems(11).Text
            End With
            seleksi = True
        Else
            seleksi = False
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub nilai_Setelah_Data_Teredit(ByVal Pesan As String, ByVal isError As Boolean) Handles nilai.Setelah_Data_Teredit
        MsgBox(Pesan)
        nilai.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub nilai_Setelah_Data_Terhapus(ByVal Pesan As String, ByVal isError As Boolean) Handles nilai.Setelah_Data_Terhapus
        MsgBox(Pesan)
        nilai.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub nilai_Setelah_Data_Tersimpan(ByVal Pesan As String, ByVal isError As Boolean) Handles nilai.Setelah_Data_Tersimpan
        MsgBox(Pesan)
        nilai.ListViewKu.SegarkanSemua()
    End Sub

    Private Sub cmbNoDaftar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNoDaftar.Click
        daftar.Cari()
    End Sub

    Private Sub cmdProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProses.Click
        If cmbNoDaftar.Text <> "" Then
            Dim x(1, 2) As Double

            If c1a.Checked Then
                x(0, 0) = 1
                x(1, 0) = 0
            Else
                x(1, 0) = 1
                x(0, 0) = 0
            End If

            If Val(c2a.Text) < 55 Then
                x(0, 1) = 0
            ElseIf Val(c2a.Text) >= 56 And Val(c2a.Text) <= 65 Then
                x(0, 1) = 0.25
            ElseIf Val(c2a.Text) >= 66 And Val(c2a.Text) <= 75 Then
                x(0, 1) = 0.5
            ElseIf Val(c2a.Text) >= 76 And Val(c2a.Text) <= 85 Then
                x(0, 1) = 0.75
            Else
                x(0, 1) = 1
            End If

            If Val(c2b.Text) < 55 Then
                x(1, 1) = 0
            ElseIf Val(c2b.Text) >= 56 And Val(c2b.Text) <= 65 Then
                x(1, 1) = 0.25
            ElseIf Val(c2b.Text) >= 66 And Val(c2b.Text) <= 75 Then
                x(1, 1) = 0.5
            ElseIf Val(c2b.Text) >= 76 And Val(c2b.Text) <= 85 Then
                x(1, 1) = 0.75
            Else
                x(1, 1) = 1
            End If

            If Val(c3a.Text) < 55 Then
                x(0, 2) = 0
            ElseIf Val(c3a.Text) >= 56 And Val(c3a.Text) <= 65 Then
                x(0, 2) = 0.25
            ElseIf Val(c3a.Text) >= 66 And Val(c3a.Text) <= 75 Then
                x(0, 2) = 0.5
            ElseIf Val(c3a.Text) >= 76 And Val(c3a.Text) <= 85 Then
                x(0, 2) = 0.75
            Else
                x(0, 2) = 1
            End If

            If Val(c3b.Text) < 55 Then
                x(1, 2) = 0
            ElseIf Val(c3b.Text) >= 56 And Val(c3b.Text) <= 65 Then
                x(1, 2) = 0.25
            ElseIf Val(c3b.Text) >= 66 And Val(c3b.Text) <= 75 Then
                x(1, 2) = 0.5
            ElseIf Val(c3b.Text) >= 76 And Val(c3b.Text) <= 85 Then
                x(1, 2) = 0.75
            Else
                x(1, 2) = 1
            End If



            Dim w() As Double = {Val(w1.Text), Val(w2.Text), Val(w3.Text)}

            Dim r(1, 2) As Double

            For i As Integer = 0 To 2
                r(0, i) = x(0, i) / Max(x(0, i), x(1, i))
                r(1, i) = x(1, i) / Max(x(0, i), x(1, i))
            Next

            Dim v(1) As Double
            v(0) = r(0, 0) * w(0) + r(0, 1) * w(1) + r(0, 2) * w(2)
            v(1) = r(1, 0) * w(0) + r(1, 1) * w(1) + r(1, 2) * w(2)

            Dim hasil As String

            If v(0) > v(1) Then
                hasil = "BDKMSI nilai=" & v(0)
            Else
                hasil = "BPB nilai=" & v(1)
            End If

            txtHasil.Text = hasil
        Else
            MsgBox("Mohon isi Mahasiswa")
        End If
    End Sub

    Private Sub daftar_Setelah_Mencari(ByVal isNotNull As Boolean, ByVal Isi() As String) Handles daftar.Setelah_Mencari
        If isNotNull Then
            txtNama.Text = Isi(1)
        End If
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub c1a_CheckedChanged(sender As Object, e As EventArgs) Handles c1a.CheckedChanged

    End Sub

    Private Sub c1b_CheckedChanged(sender As Object, e As EventArgs) Handles c1b.CheckedChanged

    End Sub
End Class