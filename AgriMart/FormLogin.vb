
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySqlConnector

Public Class FormLogin

    ' =====================================
    ' SAAT FORM LOGIN DIBUKA
    ' =====================================
    Private Sub FormLogin_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        rbAdmin.Checked = True
        txtKataSandi.UseSystemPasswordChar = True
        chkTampilkanPassword.Checked = False

        lblPesanLogin.Text = ""

        ' Tombol Enter untuk login
        Me.AcceptButton = btnMasuk

        PerbaruiPilihanRole()

    End Sub

    ' =====================================
    ' WARNA PILIHAN ROLE
    ' =====================================
    Private Sub PerbaruiPilihanRole()

        For Each rb As RadioButton In
            New RadioButton() {rbAdmin, rbKasir, rbOwner}

            If rb.Checked Then

                rb.BackColor = Color.FromArgb(47, 102, 69)
                rb.ForeColor = Color.White

            Else

                rb.BackColor = Color.FromArgb(231, 242, 231)
                rb.ForeColor = Color.FromArgb(23, 82, 44)

            End If

        Next

    End Sub

    Private Sub Role_Changed(
        sender As Object,
        e As EventArgs
    ) Handles rbAdmin.CheckedChanged,
              rbKasir.CheckedChanged,
              rbOwner.CheckedChanged

        PerbaruiPilihanRole()

    End Sub

    ' =====================================
    ' TAMPILKAN / SEMBUNYIKAN PASSWORD
    ' =====================================
    Private Sub chkTampilkanPassword_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkTampilkanPassword.CheckedChanged

        txtKataSandi.UseSystemPasswordChar =
            Not chkTampilkanPassword.Checked

    End Sub

    ' =====================================
    ' TOMBOL MASUK
    ' =====================================
    Private Sub btnMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnMasuk.Click

        lblPesanLogin.Text = ""

        Dim username As String =
            txtNamaPengguna.Text.Trim()

        Dim password As String =
            txtKataSandi.Text

        ' Periksa input
        If username = "" OrElse password = "" Then

            lblPesanLogin.Text =
                "Username dan password wajib diisi."

            Exit Sub

        End If

        ' Role yang dipilih pengguna
        Dim roleDipilih As String = ""

        If rbAdmin.Checked Then

            roleDipilih = "Admin"

        ElseIf rbKasir.Checked Then

            roleDipilih = "Kasir"

        ElseIf rbOwner.Checked Then

            roleDipilih = "Owner"

        Else

            lblPesanLogin.Text =
                "Pilih role terlebih dahulu."

            Exit Sub

        End If

        btnMasuk.Enabled = False

        Try

            ' =================================
            ' KONEKSI MYSQL
            ' =================================
            Dim pengaturan As New MySqlConnectionStringBuilder With {
                .Server = "localhost",
                .Port = 3306,
                .Database = "db_toko_pertanian",
                .UserID = username,
                .Password = password,
                .Pooling = False,
                .ConnectionTimeout = 10
            }

            Using koneksi As New MySqlConnection(
                pengaturan.ConnectionString
            )

                ' Username dan password MySQL
                ' diperiksa di sini.
                koneksi.Open()

                ' =================================
                ' AMBIL DATA PENGGUNA
                ' =================================
                Dim idPengguna As Integer = 0
                Dim namaPengguna As String = ""
                Dim peran As String = ""
                Dim aktif As Boolean = False

                Dim sql As String =
                    "SELECT id_pengguna, nama_pengguna, " &
                    "peran, status_aktif " &
                    "FROM PENGGUNA " &
                    "WHERE nama_pengguna = @username"

                Using cmd As New MySqlCommand(sql, koneksi)

                    cmd.Parameters.AddWithValue(
                        "@username", username
                    )

                    Using dr As MySqlDataReader =
                        cmd.ExecuteReader()

                        If dr.Read() Then

                            idPengguna =
                                CInt(dr("id_pengguna"))

                            namaPengguna =
                                dr("nama_pengguna").ToString()

                            peran =
                                dr("peran").ToString()

                            aktif =
                                CBool(dr("status_aktif"))

                        End If

                    End Using

                End Using

                ' =================================
                ' VALIDASI AKUN
                ' =================================
                If idPengguna = 0 Then

                    lblPesanLogin.Text =
                        "Akun tidak ditemukan di tabel PENGGUNA."

                    Exit Sub

                End If

                If Not aktif Then

                    lblPesanLogin.Text =
                        "Akun sedang dinonaktifkan."

                    Exit Sub

                End If

                If Not String.Equals(
                    peran,
                    roleDipilih,
                    StringComparison.OrdinalIgnoreCase
                ) Then

                    lblPesanLogin.Text =
                        "Akun tidak sesuai dengan role yang dipilih."

                    Exit Sub

                End If

                ' =================================
                ' PILIH DASHBOARD SESUAI ROLE
                ' =================================
                Dim halaman As Form = Nothing

                Select Case peran

                    Case "Admin"

                        Dim admin As New FrmUtamaAdmin()

                        admin.KoneksiAktif = koneksi
                        admin.IdPengguna = idPengguna
                        admin.NamaAdmin = namaPengguna
                        admin.PeranPengguna = peran

                        halaman = admin

                    Case "Kasir"

                        Dim kasir As New FrmUtamaKasir()

                        kasir.KoneksiAktif = koneksi
                        kasir.IdPengguna = idPengguna
                        kasir.NamaKasir = namaPengguna
                        kasir.PeranPengguna = peran

                        halaman = kasir

                    Case "Owner"

                        Dim owner As New FrmUtamaOwner()

                        owner.KoneksiAktif = koneksi
                        owner.IdPengguna = idPengguna
                        owner.NamaOwner = namaPengguna
                        owner.PeranPengguna = peran

                        halaman = owner

                End Select

                If halaman Is Nothing Then

                    lblPesanLogin.Text =
                        "Role pengguna tidak dikenali."

                    Exit Sub

                End If

                ' =================================
                ' BUKA DASHBOARD
                ' =================================
                Me.Hide()

                Try

                    Using dashboard As Form = halaman

                        dashboard.ShowDialog()

                    End Using

                Finally

                    ' Kembali ke Login setelah Logout
                    txtKataSandi.Clear()
                    lblPesanLogin.Text = ""

                    Me.Show()
                    txtNamaPengguna.Focus()

                End Try

            End Using

        Catch ex As MySqlException

            If ex.Number = 1045 Then

                lblPesanLogin.Text =
                    "Username atau password MySQL salah."

            ElseIf ex.Number = 1049 Then

                lblPesanLogin.Text =
                    "Database db_toko_pertanian tidak ditemukan."

            ElseIf ex.Number = 1142 OrElse ex.Number = 1143 Then

                lblPesanLogin.Text =
                    "Akun MySQL belum memiliki izin akses."

            Else

                lblPesanLogin.Text =
                    "Koneksi MySQL gagal: " & ex.Message

            End If

        Catch ex As Exception

            lblPesanLogin.Text =
                "Gagal login: " & ex.Message

        Finally

            btnMasuk.Enabled = True

        End Try

    End Sub

    ' =====================================
    ' TOMBOL KELUAR
    ' =====================================
    Private Sub btnKeluar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnKeluar.Click

        Me.Close()

    End Sub

End Class
