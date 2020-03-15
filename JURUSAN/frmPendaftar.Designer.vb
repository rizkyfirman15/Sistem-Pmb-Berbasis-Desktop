<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPendaftar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmdKeluar = New System.Windows.Forms.Button()
        Me.cmdBatal = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdBaru = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.cmbAgama = New System.Windows.Forms.ComboBox()
        Me.cmbJenis = New System.Windows.Forms.ComboBox()
        Me.txtPIbu = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtAyah = New System.Windows.Forms.TextBox()
        Me.txtTmpt = New System.Windows.Forms.TextBox()
        Me.txtPAyah = New System.Windows.Forms.TextBox()
        Me.txtIbu = New System.Windows.Forms.TextBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("MV Boli", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(5, 452)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(132, 20)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(158, 15)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Created By: Rizky Firmansyah"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdKeluar)
        Me.Panel3.Controls.Add(Me.cmdBatal)
        Me.Panel3.Controls.Add(Me.cmdHapus)
        Me.Panel3.Controls.Add(Me.cmdEdit)
        Me.Panel3.Controls.Add(Me.cmdSimpan)
        Me.Panel3.Controls.Add(Me.cmdBaru)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(424, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(505, 57)
        Me.Panel3.TabIndex = 3
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Location = New System.Drawing.Point(417, 8)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(75, 37)
        Me.cmdKeluar.TabIndex = 0
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(336, 8)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 37)
        Me.cmdBatal.TabIndex = 0
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(255, 8)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 37)
        Me.cmdHapus.TabIndex = 0
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(174, 8)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 37)
        Me.cmdEdit.TabIndex = 0
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(93, 8)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 37)
        Me.cmdSimpan.TabIndex = 0
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdBaru
        '
        Me.cmdBaru.Location = New System.Drawing.Point(12, 8)
        Me.cmdBaru.Name = "cmdBaru"
        Me.cmdBaru.Size = New System.Drawing.Size(75, 37)
        Me.cmdBaru.TabIndex = 0
        Me.cmdBaru.Text = "Baru"
        Me.cmdBaru.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel2.Controls.Add(Me.dtTanggal)
        Me.Panel2.Controls.Add(Me.cmbAgama)
        Me.Panel2.Controls.Add(Me.cmbJenis)
        Me.Panel2.Controls.Add(Me.txtPIbu)
        Me.Panel2.Controls.Add(Me.txtAlamat)
        Me.Panel2.Controls.Add(Me.txtAyah)
        Me.Panel2.Controls.Add(Me.txtTmpt)
        Me.Panel2.Controls.Add(Me.txtPAyah)
        Me.Panel2.Controls.Add(Me.txtIbu)
        Me.Panel2.Controls.Add(Me.txtNo)
        Me.Panel2.Controls.Add(Me.txtNama)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Font = New System.Drawing.Font("MV Boli", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(5, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 447)
        Me.Panel2.TabIndex = 1
        '
        'dtTanggal
        '
        Me.dtTanggal.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTanggal.Location = New System.Drawing.Point(111, 125)
        Me.dtTanggal.Name = "dtTanggal"
        Me.dtTanggal.Size = New System.Drawing.Size(200, 28)
        Me.dtTanggal.TabIndex = 23
        '
        'cmbAgama
        '
        Me.cmbAgama.FormattingEnabled = True
        Me.cmbAgama.Items.AddRange(New Object() {"Islam", "Kristen Protestan", "Kristen Khatolik", "Hindu", "Budha"})
        Me.cmbAgama.Location = New System.Drawing.Point(111, 151)
        Me.cmbAgama.Name = "cmbAgama"
        Me.cmbAgama.Size = New System.Drawing.Size(142, 25)
        Me.cmbAgama.TabIndex = 21
        '
        'cmbJenis
        '
        Me.cmbJenis.FormattingEnabled = True
        Me.cmbJenis.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJenis.Location = New System.Drawing.Point(111, 68)
        Me.cmbJenis.Name = "cmbJenis"
        Me.cmbJenis.Size = New System.Drawing.Size(169, 25)
        Me.cmbJenis.TabIndex = 22
        '
        'txtPIbu
        '
        Me.txtPIbu.Location = New System.Drawing.Point(111, 331)
        Me.txtPIbu.Name = "txtPIbu"
        Me.txtPIbu.Size = New System.Drawing.Size(255, 28)
        Me.txtPIbu.TabIndex = 16
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(111, 179)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(255, 63)
        Me.txtAlamat.TabIndex = 15
        '
        'txtAyah
        '
        Me.txtAyah.Location = New System.Drawing.Point(111, 248)
        Me.txtAyah.Name = "txtAyah"
        Me.txtAyah.Size = New System.Drawing.Size(236, 28)
        Me.txtAyah.TabIndex = 14
        '
        'txtTmpt
        '
        Me.txtTmpt.Location = New System.Drawing.Point(111, 96)
        Me.txtTmpt.Name = "txtTmpt"
        Me.txtTmpt.Size = New System.Drawing.Size(287, 28)
        Me.txtTmpt.TabIndex = 17
        '
        'txtPAyah
        '
        Me.txtPAyah.Location = New System.Drawing.Point(111, 304)
        Me.txtPAyah.Name = "txtPAyah"
        Me.txtPAyah.Size = New System.Drawing.Size(255, 28)
        Me.txtPAyah.TabIndex = 20
        '
        'txtIbu
        '
        Me.txtIbu.Location = New System.Drawing.Point(111, 277)
        Me.txtIbu.Name = "txtIbu"
        Me.txtIbu.Size = New System.Drawing.Size(236, 28)
        Me.txtIbu.TabIndex = 19
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(111, 16)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(226, 28)
        Me.txtNo.TabIndex = 18
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(111, 42)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(226, 28)
        Me.txtNama.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 334)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 17)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Pekerjaan Ibu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Nama Ayah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Pekerjaan Ayah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Agama"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 280)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama Ibu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "No Penerima"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nama Penerima"
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(429, 5)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(505, 447)
        Me.ListView1.TabIndex = 2
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'frmPendaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 514)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmPendaftar"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FORM PENERIMAAN"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJenis As System.Windows.Forms.ComboBox
    Friend WithEvents txtPIbu As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtAyah As System.Windows.Forms.TextBox
    Friend WithEvents txtTmpt As System.Windows.Forms.TextBox
    Friend WithEvents txtPAyah As System.Windows.Forms.TextBox
    Friend WithEvents txtIbu As System.Windows.Forms.TextBox
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdBaru As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
