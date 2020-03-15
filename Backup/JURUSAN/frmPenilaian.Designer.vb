<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenilaian
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.c3b = New System.Windows.Forms.TextBox
        Me.c3a = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.c2b = New System.Windows.Forms.TextBox
        Me.c2a = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.c1b = New System.Windows.Forms.RadioButton
        Me.c1a = New System.Windows.Forms.RadioButton
        Me.cmbNoDaftar = New System.Windows.Forms.ComboBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.w3 = New System.Windows.Forms.TextBox
        Me.w2 = New System.Windows.Forms.TextBox
        Me.w1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdProses = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtHasil = New System.Windows.Forms.TextBox
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdBatal = New System.Windows.Forms.Button
        Me.cmdKeluar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Pendaftaran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Siswa"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 272)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kriteria"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.c3b)
        Me.GroupBox4.Controls.Add(Me.c3a)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 180)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(299, 82)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ujian Test Kompetensi (Praktek) (C3)"
        '
        'c3b
        '
        Me.c3b.Location = New System.Drawing.Point(89, 52)
        Me.c3b.Name = "c3b"
        Me.c3b.Size = New System.Drawing.Size(180, 20)
        Me.c3b.TabIndex = 4
        '
        'c3a
        '
        Me.c3a.Location = New System.Drawing.Point(89, 27)
        Me.c3a.Name = "c3a"
        Me.c3a.Size = New System.Drawing.Size(180, 20)
        Me.c3a.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "BUN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "APTH"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.c2b)
        Me.GroupBox3.Controls.Add(Me.c2a)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 80)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ujian Test Penjurusan Tertulis (C2)"
        '
        'c2b
        '
        Me.c2b.Location = New System.Drawing.Point(89, 49)
        Me.c2b.Name = "c2b"
        Me.c2b.Size = New System.Drawing.Size(180, 20)
        Me.c2b.TabIndex = 1
        '
        'c2a
        '
        Me.c2a.Location = New System.Drawing.Point(89, 24)
        Me.c2a.Name = "c2a"
        Me.c2a.Size = New System.Drawing.Size(180, 20)
        Me.c2a.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "BUN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "APTH"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.c1b)
        Me.GroupBox2.Controls.Add(Me.c1a)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 69)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Minat (C1)"
        '
        'c1b
        '
        Me.c1b.AutoSize = True
        Me.c1b.Location = New System.Drawing.Point(17, 42)
        Me.c1b.Name = "c1b"
        Me.c1b.Size = New System.Drawing.Size(48, 17)
        Me.c1b.TabIndex = 0
        Me.c1b.TabStop = True
        Me.c1b.Text = "BUN"
        Me.c1b.UseVisualStyleBackColor = True
        '
        'c1a
        '
        Me.c1a.AutoSize = True
        Me.c1a.Location = New System.Drawing.Point(17, 19)
        Me.c1a.Name = "c1a"
        Me.c1a.Size = New System.Drawing.Size(54, 17)
        Me.c1a.TabIndex = 0
        Me.c1a.TabStop = True
        Me.c1a.Text = "APTH"
        Me.c1a.UseVisualStyleBackColor = True
        '
        'cmbNoDaftar
        '
        Me.cmbNoDaftar.FormattingEnabled = True
        Me.cmbNoDaftar.Location = New System.Drawing.Point(100, 6)
        Me.cmbNoDaftar.Name = "cmbNoDaftar"
        Me.cmbNoDaftar.Size = New System.Drawing.Size(227, 21)
        Me.cmbNoDaftar.TabIndex = 3
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(100, 38)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(227, 20)
        Me.txtNama.TabIndex = 4
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.w3)
        Me.GroupBox5.Controls.Add(Me.w2)
        Me.GroupBox5.Controls.Add(Me.w1)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(344, 68)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(323, 151)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Bobot"
        '
        'w3
        '
        Me.w3.Location = New System.Drawing.Point(45, 115)
        Me.w3.Name = "w3"
        Me.w3.Size = New System.Drawing.Size(100, 20)
        Me.w3.TabIndex = 1
        '
        'w2
        '
        Me.w2.Location = New System.Drawing.Point(45, 72)
        Me.w2.Name = "w2"
        Me.w2.Size = New System.Drawing.Size(100, 20)
        Me.w2.TabIndex = 1
        '
        'w1
        '
        Me.w1.Location = New System.Drawing.Point(45, 27)
        Me.w1.Name = "w1"
        Me.w1.Size = New System.Drawing.Size(100, 20)
        Me.w1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "W3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "W2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "W1"
        '
        'cmdProses
        '
        Me.cmdProses.Location = New System.Drawing.Point(263, 346)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(75, 23)
        Me.cmdProses.TabIndex = 5
        Me.cmdProses.Text = "Proses"
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(47, 378)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Hasil Jurusan"
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(123, 375)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(180, 20)
        Me.txtHasil.TabIndex = 5
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(344, 225)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(323, 240)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(11, 442)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 23)
        Me.cmdSimpan.TabIndex = 5
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(92, 442)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.cmdEdit.TabIndex = 5
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdBatal
        '
        Me.cmdBatal.Location = New System.Drawing.Point(173, 442)
        Me.cmdBatal.Name = "cmdBatal"
        Me.cmdBatal.Size = New System.Drawing.Size(75, 23)
        Me.cmdBatal.TabIndex = 5
        Me.cmdBatal.Text = "Batal"
        Me.cmdBatal.UseVisualStyleBackColor = True
        '
        'cmdKeluar
        '
        Me.cmdKeluar.Location = New System.Drawing.Point(254, 442)
        Me.cmdKeluar.Name = "cmdKeluar"
        Me.cmdKeluar.Size = New System.Drawing.Size(75, 23)
        Me.cmdKeluar.TabIndex = 5
        Me.cmdKeluar.Text = "Keluar"
        Me.cmdKeluar.UseVisualStyleBackColor = True
        '
        'frmPenilaian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 477)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.cmdKeluar)
        Me.Controls.Add(Me.cmdBatal)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdProses)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.cmbNoDaftar)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPenilaian"
        Me.Text = "frmPenilaian"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c3b As System.Windows.Forms.TextBox
    Friend WithEvents c3a As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c2b As System.Windows.Forms.TextBox
    Friend WithEvents c2a As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents c1b As System.Windows.Forms.RadioButton
    Friend WithEvents c1a As System.Windows.Forms.RadioButton
    Friend WithEvents cmbNoDaftar As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents w3 As System.Windows.Forms.TextBox
    Friend WithEvents w2 As System.Windows.Forms.TextBox
    Friend WithEvents w1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdProses As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtHasil As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdBatal As System.Windows.Forms.Button
    Friend WithEvents cmdKeluar As System.Windows.Forms.Button
End Class
