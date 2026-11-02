
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySqlConnector

Public Class FrmUtamaAdmin

    ' Diisi oleh FormLogin sebelum Dashboard ditampilkan.
    Public Property KoneksiAktif As MySqlConnection
    Public Property IdPengguna As Integer
    Public Property NamaAdmin As String = ""
    Public Property PeranPengguna As String = ""

    Private idBarangEdit As Integer = 0
    Private ReadOnly keranjang As New DataTable()

    ' ======================================
    ' CEK SESI ADMIN
    ' ======================================
    Private Function SesiValid() As Boolean

        Return IdPengguna > 0 AndAlso
               String.Equals(
                   PeranPengguna,
                   "Admin",
                   StringComparison.OrdinalIgnoreCase
               ) AndAlso
               KoneksiAktif IsNot Nothing AndAlso
               KoneksiAktif.State = ConnectionState.Open

    End Function

    ' ======================================
    ' LOAD DASHBOARD
    ' ======================================
    Private Sub FrmUtamaAdmin_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If Not SesiValid() Then

            MessageBox.Show(
                "Sesi Admin tidak valid. " &
                "Buka melalui FormLogin.",
                "AGRIMARTT"
            )

            Me.Close()
            Return

        End If

        lblIdentitas.Text = "Halo, " & NamaAdmin & "!"

        ' Buat tabel sementara untuk daftar Barang Masuk.
        keranjang.Columns.Add("Kode", GetType(String))
        keranjang.Columns.Add("Barang", GetType(String))
        keranjang.Columns.Add("Kategori", GetType(String))
        keranjang.Columns.Add("Satuan", GetType(String))
        keranjang.Columns.Add("Jumlah", GetType(Integer))
        keranjang.Columns.Add("Harga Beli", GetType(Decimal))
        keranjang.Columns.Add("Harga Jual", GetType(Decimal))

        dgvDetailMasuk.DataSource = keranjang

        dgvDetailMasuk.Columns(
            "Harga Beli"
        ).DefaultCellStyle.Format = "N2"

        dgvDetailMasuk.Columns(
            "Harga Jual"
        ).DefaultCellStyle.Format = "N2"

        BersihkanInputBarang()
        PerbaruiRingkasanMasuk()

        ' Saat runtime dimulai dari Dashboard.
        TampilkanPanel("Dashboard")
        MuatDashboard()

    End Sub

    ' ======================================
    ' NAVIGASI TIGA PANEL
    ' ======================================
    Private Sub TampilkanPanel(nama As String)

        pnlDashboard.Visible = False
        pnlDataBarang.Visible = False
        pnlBarangMasuk.Visible = False

        Select Case nama

            Case "Dashboard"
                pnlDashboard.Visible = True
                pnlDashboard.BringToFront()

            Case "Data Barang"
                pnlDataBarang.Visible = True
                pnlDataBarang.BringToFront()

            Case "Barang Masuk"
                pnlBarangMasuk.Visible = True
                pnlBarangMasuk.BringToFront()

        End Select

        lblJudul.Text = nama

        btnDashboard.BackColor =
            If(nama = "Dashboard",
               Color.FromArgb(55, 119, 80),
               Color.FromArgb(23, 82, 44))

        btnDataBarang.BackColor =
            If(nama = "Data Barang",
               Color.FromArgb(55, 119, 80),
               Color.FromArgb(23, 82, 44))

        btnBarangMasuk.BackColor =
            If(nama = "Barang Masuk",
               Color.FromArgb(55, 119, 80),
               Color.FromArgb(23, 82, 44))

    End Sub

    Private Sub btnDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDashboard.Click

        TampilkanPanel("Dashboard")
        MuatDashboard()

    End Sub

    Private Sub btnDataBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDataBarang.Click

        TampilkanPanel("Data Barang")
        MuatDataBarang(txtCariBarang.Text)

    End Sub

    Private Sub btnBarangMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBarangMasuk.Click

        TampilkanPanel("Barang Masuk")
        txtKodeMasuk.Focus()

    End Sub

    ' ======================================
    ' DASHBOARD - STATISTIK DAN RIWAYAT
    ' ======================================
    Private Sub MuatDashboard()

        If Not SesiValid() Then Return

        Try

            Dim sql As String =
                "SELECT COUNT(*) AS total_barang, " &
                "COALESCE(SUM(stok),0) AS total_stok, " &
                "COALESCE(SUM(CASE WHEN stok <= 10 " &
                "THEN 1 ELSE 0 END),0) AS menipis " &
                "FROM BARANG WHERE status_aktif=1"

            Using cmd As New MySqlCommand(
                sql, KoneksiAktif
            )

                Using r As MySqlDataReader =
                    cmd.ExecuteReader()

                    If r.Read() Then

                        lblTotalBarang.Text =
                            Convert.ToInt64(
                                r("total_barang")
                            ).ToString("N0")

                        lblTotalStok.Text =
                            Convert.ToInt64(
                                r("total_stok")
                            ).ToString("N0")

                        lblStokMenipis.Text =
                            Convert.ToInt64(
                                r("menipis")
                            ).ToString("N0")

                    End If

                End Using

            End Using

            ' RIWAYAT BARANG MASUK TERBARU
            sql =
                "SELECT " &
                "bm.no_penerimaan AS `No Penerimaan`, " &
                "DATE_FORMAT(bm.tanggal_masuk, " &
                "'%d-%m-%Y %H:%i') AS `Tanggal`, " &
                "p.nama_pengguna AS `Admin`, " &
                "b.nama_barang AS `Barang`, " &
                "d.jumlah AS `Jumlah`, " &
                "d.harga_beli AS `Harga Beli` " &
                "FROM BARANG_MASUK bm " &
                "JOIN PENGGUNA p " &
                "ON p.id_pengguna=bm.id_pengguna " &
                "JOIN DETAIL_BARANG_MASUK d " &
                "ON d.id_barang_masuk=bm.id_barang_masuk " &
                "JOIN BARANG b " &
                "ON b.id_barang=d.id_barang " &
                "ORDER BY bm.tanggal_masuk DESC, " &
                "d.id_detail_masuk DESC LIMIT 20"

            Dim tabel As New DataTable()

            Using cmd As New MySqlCommand(
                sql, KoneksiAktif
            )

                Using r As MySqlDataReader =
                    cmd.ExecuteReader()

                    tabel.Load(r)

                End Using

            End Using

            dgvRiwayatMasuk.DataSource = tabel

            dgvRiwayatMasuk.Columns(
                "Harga Beli"
            ).DefaultCellStyle.Format = "N2"

            dgvRiwayatMasuk.ClearSelection()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat Dashboard: " & ex.Message,
                "AGRIMARTT"
            )

        End Try

    End Sub

    Private Sub btnRefreshDashboard_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefreshDashboard.Click

        MuatDashboard()

    End Sub

    ' ======================================
    ' DATA BARANG - MEMUAT TABEL
    ' ======================================
    Private Sub MuatDataBarang(
        Optional cari As String = ""
    )

        If Not SesiValid() Then Return

        Try

            Dim sql As String =
                "SELECT " &
                "id_barang AS ID, " &
                "kode_barang AS Kode, " &
                "nama_barang AS `Nama Barang`, " &
                "kategori AS Kategori, " &
                "satuan AS Satuan, " &
                "harga_beli AS `Harga Beli`, " &
                "harga_jual AS `Harga Jual`, " &
                "stok AS Stok, " &
                "CASE WHEN status_aktif=1 " &
                "THEN 'Aktif' ELSE 'Nonaktif' " &
                "END AS Status " &
                "FROM BARANG " &
                "WHERE kode_barang LIKE @cari " &
                "OR nama_barang LIKE @cari " &
                "OR kategori LIKE @cari " &
                "ORDER BY nama_barang"

            Dim tabel As New DataTable()

            Using cmd As New MySqlCommand(
                sql, KoneksiAktif
            )

                cmd.Parameters.AddWithValue(
                    "@cari",
                    "%" & cari.Trim() & "%"
                )

                Using r As MySqlDataReader =
                    cmd.ExecuteReader()

                    tabel.Load(r)

                End Using

            End Using

            dgvBarang.DataSource = tabel

            dgvBarang.Columns("ID").Visible = False

            dgvBarang.Columns(
                "Harga Beli"
            ).DefaultCellStyle.Format = "N2"

            dgvBarang.Columns(
                "Harga Jual"
            ).DefaultCellStyle.Format = "N2"

            dgvBarang.ClearSelection()

        Catch ex As Exception

            MessageBox.Show(
                "Gagal memuat Data Barang: " & ex.Message,
                "AGRIMARTT"
            )

        End Try

    End Sub

    Private Sub btnCariBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCariBarang.Click

        MuatDataBarang(txtCariBarang.Text)

    End Sub

    Private Sub btnRefreshBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefreshBarang.Click

        txtCariBarang.Clear()
        BersihkanInputBarang()
        MuatDataBarang()

    End Sub

    ' ======================================
    ' DATA BARANG - BERSIHKAN INPUT
    ' ======================================
    Private Sub BersihkanInputBarang()

        idBarangEdit = 0

        txtKodeBarang.Clear()
        txtNamaBarang.Clear()
        txtKategoriBarang.Clear()
        txtSatuanBarang.Clear()

        numHargaBeli.Value = 0D
        numHargaJual.Value = 0D

        lblEditor.Text = "TAMBAH BARANG (stok awal 0)"
        btnSimpanBarang.Text = "Simpan"

    End Sub

    Private Sub btnBatalBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBatalBarang.Click

        BersihkanInputBarang()

    End Sub

    ' ======================================
    ' DATA BARANG - EDIT
    ' ======================================
    Private Sub IsiEditorDariBaris(
        baris As DataGridViewRow
    )

        idBarangEdit =
            Convert.ToInt32(baris.Cells("ID").Value)

        txtKodeBarang.Text =
            Convert.ToString(baris.Cells("Kode").Value)

        txtNamaBarang.Text =
            Convert.ToString(
                baris.Cells("Nama Barang").Value
            )

        txtKategoriBarang.Text =
            Convert.ToString(
                baris.Cells("Kategori").Value
            )

        txtSatuanBarang.Text =
            Convert.ToString(
                baris.Cells("Satuan").Value
            )

        numHargaBeli.Value =
            Convert.ToDecimal(
                baris.Cells("Harga Beli").Value
            )

        numHargaJual.Value =
            Convert.ToDecimal(
                baris.Cells("Harga Jual").Value
            )

        lblEditor.Text = "EDIT DATA BARANG"
        btnSimpanBarang.Text = "Update"

        txtKodeBarang.Focus()

    End Sub

    Private Sub btnEditBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEditBarang.Click

        If dgvBarang.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Pilih satu baris barang.",
                "AGRIMARTT"
            )
            Return

        End If

        IsiEditorDariBaris(
            dgvBarang.SelectedRows(0)
        )

    End Sub

    ' DOUBLE-CLICK TABEL MENGISI TEXTBOX
    Private Sub dgvBarang_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvBarang.CellDoubleClick

        If e.RowIndex < 0 Then Return

        dgvBarang.ClearSelection()
        dgvBarang.Rows(e.RowIndex).Selected = True

        IsiEditorDariBaris(
            dgvBarang.Rows(e.RowIndex)
        )

    End Sub

    ' ======================================
    ' DATA BARANG - SIMPAN / UPDATE
    ' ======================================
    Private Sub btnSimpanBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpanBarang.Click

        If Not SesiValid() Then Return

        Dim kode As String = txtKodeBarang.Text.Trim()
        Dim nama As String = txtNamaBarang.Text.Trim()

        Dim kategori As String =
            txtKategoriBarang.Text.Trim()

        Dim satuan As String =
            txtSatuanBarang.Text.Trim()

        If kode = "" OrElse nama = "" OrElse
           kategori = "" OrElse satuan = "" Then

            MessageBox.Show(
                "Kode, nama, kategori, dan satuan harus diisi.",
                "AGRIMARTT"
            )

            Return

        End If

        If numHargaJual.Value <= 0D Then

            MessageBox.Show(
                "Harga jual harus lebih dari nol.",
                "AGRIMARTT"
            )

            Return

        End If

        Try

            Dim sql As String

            If idBarangEdit = 0 Then

                sql =
                    "INSERT INTO BARANG " &
                    "(kode_barang,nama_barang,kategori," &
                    "satuan,harga_beli,harga_jual," &
                    "stok,status_aktif) " &
                    "VALUES (@kode,@nama,@kategori," &
                    "@satuan,@beli,@jual,0,1)"

            Else

                sql =
                    "UPDATE BARANG SET " &
                    "kode_barang=@kode," &
                    "nama_barang=@nama," &
                    "kategori=@kategori," &
                    "satuan=@satuan," &
                    "harga_beli=@beli," &
                    "harga_jual=@jual " &
                    "WHERE id_barang=@id"

            End If

            Using cmd As New MySqlCommand(
                sql, KoneksiAktif
            )

                cmd.Parameters.AddWithValue(
                    "@kode", kode
                )

                cmd.Parameters.AddWithValue(
                    "@nama", nama
                )

                cmd.Parameters.AddWithValue(
                    "@kategori", kategori
                )

                cmd.Parameters.AddWithValue(
                    "@satuan", satuan
                )

                cmd.Parameters.AddWithValue(
                    "@beli", numHargaBeli.Value
                )

                cmd.Parameters.AddWithValue(
                    "@jual", numHargaJual.Value
                )

                If idBarangEdit <> 0 Then

                    cmd.Parameters.AddWithValue(
                        "@id", idBarangEdit
                    )

                End If

                cmd.ExecuteNonQuery()

            End Using

            BersihkanInputBarang()
            MuatDataBarang(txtCariBarang.Text)

            MessageBox.Show(
                "Data barang berhasil disimpan.",
                "AGRIMARTT"
            )

        Catch ex As MySqlException When ex.Number = 1062

            MessageBox.Show(
                "Kode barang sudah digunakan.",
                "AGRIMARTT"
            )

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan barang: " &
                ex.Message,
                "AGRIMARTT"
            )

        End Try

    End Sub

    ' ======================================
    ' DATA BARANG - NONAKTIFKAN
    ' ======================================

    ' AKTIFKAN / NONAKTIFKAN BARANG
    Private Sub btnNonaktifBarang_Click(
    sender As Object,
    e As EventArgs
) Handles btnNonaktifBarang.Click

        If Not SesiValid() Then
            MsgBox("Koneksi database tidak aktif!")
            Exit Sub
        End If

        If dgvBarang.SelectedRows.Count = 0 Then
            MsgBox("Pilih barang terlebih dahulu!")
            Exit Sub
        End If

        Dim baris As DataGridViewRow =
        dgvBarang.SelectedRows(0)

        Dim id As Integer =
        CInt(baris.Cells("ID").Value)

        Dim status As String =
        baris.Cells("Status").Value.ToString()

        Dim statusBaru As Integer
        Dim pesan As String

        If status = "Aktif" Then
            statusBaru = 0
            pesan = "Nonaktifkan barang ini?"
        Else
            statusBaru = 1
            pesan = "Aktifkan kembali barang ini?"
        End If

        If MsgBox(pesan,
              MsgBoxStyle.YesNo + MsgBoxStyle.Question,
              "Konfirmasi") = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Dim sql As String =
            "UPDATE BARANG SET status_aktif=@status " &
            "WHERE id_barang=@id"

            Dim cmd As New MySqlCommand(sql, KoneksiAktif)

            cmd.Parameters.AddWithValue("@status", statusBaru)
            cmd.Parameters.AddWithValue("@id", id)

            cmd.ExecuteNonQuery()
            cmd.Dispose()

            MsgBox("Status barang berhasil diperbarui!")

            BersihkanInputBarang()
            MuatDataBarang(txtCariBarang.Text)

        Catch ex As Exception
            MsgBox("Gagal mengubah status: " & ex.Message)
        End Try

    End Sub


    ' ======================================
    ' DATA BARANG - HAPUS PERMANEN
    ' ======================================
    Private Sub btnHapusBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnHapusBarang.Click

        If Not SesiValid() Then Return

        If dgvBarang.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Pilih barang yang ingin dihapus.",
                "AGRIMARTT"
            )

            Return

        End If

        Dim baris As DataGridViewRow =
            dgvBarang.SelectedRows(0)

        Dim id As Integer =
            Convert.ToInt32(
                baris.Cells("ID").Value
            )

        Dim nama As String =
            Convert.ToString(
                baris.Cells("Nama Barang").Value
            )

        Dim stok As Integer =
            Convert.ToInt32(
                baris.Cells("Stok").Value
            )

        ' Hanya barang dengan stok 0 boleh
        ' dihapus secara permanen.
        If stok <> 0 Then

            MessageBox.Show(
                "Barang masih memiliki stok." &
                vbCrLf &
                "Gunakan tombol Nonaktifkan.",
                "AGRIMARTT"
            )

            Return

        End If

        If MessageBox.Show(
            "Hapus permanen '" & nama & "'?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        ) <> DialogResult.Yes Then Return

        Try

            Using cmd As New MySqlCommand(
                "DELETE FROM BARANG " &
                "WHERE id_barang=@id AND stok=0",
                KoneksiAktif
            )

                cmd.Parameters.AddWithValue(
                    "@id", id
                )

                If cmd.ExecuteNonQuery() = 0 Then

                    MessageBox.Show(
                        "Barang tidak ditemukan atau " &
                        "stok sudah berubah.",
                        "AGRIMARTT"
                    )

                    MuatDataBarang(txtCariBarang.Text)
                    Return

                End If

            End Using

            BersihkanInputBarang()
            MuatDataBarang(txtCariBarang.Text)

            MessageBox.Show(
                "Barang berhasil dihapus permanen.",
                "AGRIMARTT"
            )

        Catch ex As MySqlException When ex.Number = 1451

            MessageBox.Show(
                "Barang memiliki riwayat transaksi " &
                "atau penerimaan." & vbCrLf &
                "Gunakan tombol Nonaktifkan.",
                "AGRIMARTT"
            )



        Catch ex As Exception

            MessageBox.Show(
                "Gagal menghapus barang: " &
                ex.Message,
                "AGRIMARTT"
            )

        End Try

    End Sub

    ' ======================================
    ' BARANG MASUK - CEK KODE BARANG
    ' ======================================
    Private Sub txtKodeMasuk_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtKodeMasuk.TextChanged

        txtNamaMasuk.Clear()
        txtKategoriMasuk.Clear()
        txtSatuanMasuk.Clear()

        numHargaMasuk.Value = 0D
        numHargaJualMasuk.Value = 0D

    End Sub

    Private Sub txtKodeMasuk_Leave(
        sender As Object,
        e As EventArgs
    ) Handles txtKodeMasuk.Leave

        If Not SesiValid() OrElse
           txtKodeMasuk.Text.Trim() = "" Then Return

        Try

            Using cmd As New MySqlCommand(
                "SELECT nama_barang,kategori,satuan," &
                "harga_beli,harga_jual,status_aktif " &
                "FROM BARANG " &
                "WHERE kode_barang=@kode LIMIT 1",
                KoneksiAktif
            )

                cmd.Parameters.AddWithValue(
                    "@kode", txtKodeMasuk.Text.Trim()
                )

                Using r As MySqlDataReader =
                    cmd.ExecuteReader()

                    If r.Read() Then

                        If Not Convert.ToBoolean(
                            r("status_aktif")
                        ) Then

                            MessageBox.Show(
                                "Barang ini nonaktif." &
                                vbCrLf &
                                "Tidak dapat menerima stok.",
                                "AGRIMARTT"
                            )

                            Return

                        End If

                        txtNamaMasuk.Text =
                            Convert.ToString(
                                r("nama_barang")
                            )

                        txtKategoriMasuk.Text =
                            Convert.ToString(
                                r("kategori")
                            )

                        txtSatuanMasuk.Text =
                            Convert.ToString(
                                r("satuan")
                            )

                        numHargaMasuk.Value =
                            Math.Min(
                                numHargaMasuk.Maximum,
                                Convert.ToDecimal(
                                    r("harga_beli")
                                )
                            )

                        numHargaJualMasuk.Value =
                            Math.Min(
                                numHargaJualMasuk.Maximum,
                                Convert.ToDecimal(
                                    r("harga_jual")
                                )
                            )

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show(
                "Gagal mengecek kode barang: " &
                ex.Message,
                "AGRIMARTT"
            )

        End Try

    End Sub

    ' ======================================
    ' BARANG MASUK - TAMBAH KE DAFTAR
    ' ======================================
    Private Sub btnTambahMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnTambahMasuk.Click

        If Not SesiValid() Then Return

        Dim kode As String =
            txtKodeMasuk.Text.Trim()

        Dim nama As String =
            txtNamaMasuk.Text.Trim()

        Dim kategori As String =
            txtKategoriMasuk.Text.Trim()

        Dim satuan As String =
            txtSatuanMasuk.Text.Trim()

        If kode = "" OrElse nama = "" OrElse
           kategori = "" OrElse satuan = "" Then

            MessageBox.Show(
                "Isi kode, nama, kategori, dan satuan.",
                "AGRIMARTT"
            )

            Return

        End If

        If numHargaJualMasuk.Value <= 0D Then

            MessageBox.Show(
                "Harga jual harus lebih dari nol.",
                "AGRIMARTT"
            )

            Return

        End If

        ' Cegah kode ganda dalam satu penerimaan.
        For Each r As DataRow In keranjang.Rows

            If String.Equals(
                Convert.ToString(r("Kode")),
                kode,
                StringComparison.OrdinalIgnoreCase
            ) Then

                MessageBox.Show(
                    "Kode sudah ada di daftar Barang Masuk.",
                    "AGRIMARTT"
                )

                Return

            End If

        Next

        keranjang.Rows.Add(
            kode,
            nama,
            kategori,
            satuan,
            Convert.ToInt32(numJumlahMasuk.Value),
            numHargaMasuk.Value,
            numHargaJualMasuk.Value
        )

        PerbaruiRingkasanMasuk()

        txtKodeMasuk.Clear()
        numJumlahMasuk.Value = 1D
        txtKodeMasuk.Focus()

    End Sub

    Private Sub PerbaruiRingkasanMasuk()

        Dim total As Long = 0

        For Each r As DataRow In keranjang.Rows
            total += Convert.ToInt64(
                r("Jumlah")
            )
        Next

        lblRingkasanMasuk.Text =
            keranjang.Rows.Count.ToString() &
            " jenis barang - " &
            total.ToString("N0") & " unit"

    End Sub

    ' ======================================
    ' BARANG MASUK - HAPUS ITEM DAFTAR
    ' ======================================
    Private Sub btnHapusMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnHapusMasuk.Click

        If dgvDetailMasuk.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Pilih item yang ingin dihapus.",
                "AGRIMARTT"
            )

            Return

        End If

        Dim r As DataRowView =
            TryCast(
                dgvDetailMasuk.SelectedRows(0).DataBoundItem,
                DataRowView
            )

        If r IsNot Nothing Then
            keranjang.Rows.Remove(r.Row)
        End If

        PerbaruiRingkasanMasuk()

    End Sub

    Private Sub btnBersihkanMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBersihkanMasuk.Click

        If keranjang.Rows.Count = 0 Then Return

        If MessageBox.Show(
            "Kosongkan seluruh daftar penerimaan?",
            "Konfirmasi",
            MessageBoxButtons.YesNo
        ) = DialogResult.Yes Then

            keranjang.Clear()
            PerbaruiRingkasanMasuk()

        End If

    End Sub

    ' ======================================
    ' BARANG MASUK - SIMPAN MYSQL
    ' ======================================
    Private Sub btnSimpanMasuk_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpanMasuk.Click

        If Not SesiValid() Then

            MessageBox.Show(
                "Koneksi MySQL tidak aktif. Login ulang.",
                "AGRIMARTT"
            )
            Return

        End If

        If keranjang.Rows.Count = 0 Then

            MessageBox.Show(
                "Daftar Barang Masuk kosong.",
                "AGRIMARTT"
            )
            Return

        End If

        If MessageBox.Show(
            "Simpan penerimaan dan tambah stok?",
            "Konfirmasi",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        ) <> DialogResult.Yes Then Return

        Dim nomor As String =
            "BM-" &
            DateTime.Now.ToString("yyyyMMdd-HHmmss") &
            "-" &
            Guid.NewGuid().ToString("N").Substring(0, 8)

        Try

            Using tr As MySqlTransaction =
                KoneksiAktif.BeginTransaction()

                Try

                    Dim idMasuk As Long

                    ' 1. SIMPAN HEADER BARANG MASUK
                    Using cmd As New MySqlCommand(
                        "INSERT INTO BARANG_MASUK " &
                        "(no_penerimaan,id_pengguna) " &
                        "VALUES (@nomor,@user)",
                        KoneksiAktif, tr
                    )

                        cmd.Parameters.AddWithValue(
                            "@nomor", nomor
                        )

                        cmd.Parameters.AddWithValue(
                            "@user", IdPengguna
                        )

                        cmd.ExecuteNonQuery()
                        idMasuk = cmd.LastInsertedId

                    End Using

                    ' 2. PROSES SETIAP BARANG
                    For Each r As DataRow In keranjang.Rows

                        Dim kode As String =
                            Convert.ToString(r("Kode"))

                        Dim jumlah As Integer =
                            Convert.ToInt32(r("Jumlah"))

                        Dim beli As Decimal =
                            Convert.ToDecimal(r("Harga Beli"))

                        Dim jual As Decimal =
                            Convert.ToDecimal(r("Harga Jual"))

                        If jumlah <= 0 OrElse
                           beli < 0D OrElse jual <= 0D Then

                            Throw New InvalidOperationException(
                                "Jumlah atau harga tidak valid: " &
                                kode
                            )

                        End If

                        Dim idBarang As Long = 0
                        Dim aktif As Boolean = True

                        ' 3. CARI BARANG BERDASARKAN KODE
                        Using cmd As New MySqlCommand(
                            "SELECT id_barang,status_aktif " &
                            "FROM BARANG " &
                            "WHERE kode_barang=@kode " &
                            "LIMIT 1 FOR UPDATE",
                            KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@kode", kode
                            )

                            Using baca As MySqlDataReader =
                                cmd.ExecuteReader()

                                If baca.Read() Then

                                    idBarang =
                                        Convert.ToInt64(
                                            baca("id_barang")
                                        )

                                    aktif =
                                        Convert.ToBoolean(
                                            baca("status_aktif")
                                        )

                                End If

                            End Using

                        End Using

                        If Not aktif Then

                            Throw New InvalidOperationException(
                                "Barang nonaktif: " & kode
                            )

                        End If

                        ' 4. JIKA BARU, INSERT KE BARANG
                        If idBarang = 0 Then

                            Using cmd As New MySqlCommand(
                                "INSERT INTO BARANG " &
                                "(kode_barang,nama_barang," &
                                "kategori,satuan,harga_beli," &
                                "harga_jual,stok,status_aktif) " &
                                "VALUES (@kode,@nama,@kategori," &
                                "@satuan,@beli,@jual,0,1)",
                                KoneksiAktif, tr
                            )

                                cmd.Parameters.AddWithValue(
                                    "@kode", kode
                                )

                                cmd.Parameters.AddWithValue(
                                    "@nama",
                                    Convert.ToString(
                                        r("Barang")
                                    )
                                )

                                cmd.Parameters.AddWithValue(
                                    "@kategori",
                                    Convert.ToString(
                                        r("Kategori")
                                    )
                                )

                                cmd.Parameters.AddWithValue(
                                    "@satuan",
                                    Convert.ToString(
                                        r("Satuan")
                                    )
                                )

                                cmd.Parameters.AddWithValue(
                                    "@beli", beli
                                )

                                cmd.Parameters.AddWithValue(
                                    "@jual", jual
                                )

                                cmd.ExecuteNonQuery()
                                idBarang = cmd.LastInsertedId

                            End Using

                        End If

                        ' 5. UPDATE STOK
                        Using cmd As New MySqlCommand(
                            "UPDATE BARANG SET " &
                            "stok=stok+@jumlah," &
                            "harga_beli=@beli " &
                            "WHERE id_barang=@id " &
                            "AND status_aktif=1",
                            KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@jumlah", jumlah
                            )

                            cmd.Parameters.AddWithValue(
                                "@beli", beli
                            )

                            cmd.Parameters.AddWithValue(
                                "@id", idBarang
                            )

                            If cmd.ExecuteNonQuery() <> 1 Then

                                Throw New InvalidOperationException(
                                    "Stok gagal ditambah: " &
                                    kode
                                )

                            End If

                        End Using

                        ' 6. SIMPAN DETAIL PENERIMAAN
                        Using cmd As New MySqlCommand(
                            "INSERT INTO DETAIL_BARANG_MASUK " &
                            "(id_barang_masuk,id_barang," &
                            "jumlah,harga_beli) " &
                            "VALUES (@masuk,@barang," &
                            "@jumlah,@beli)",
                            KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@masuk", idMasuk
                            )

                            cmd.Parameters.AddWithValue(
                                "@barang", idBarang
                            )

                            cmd.Parameters.AddWithValue(
                                "@jumlah", jumlah
                            )

                            cmd.Parameters.AddWithValue(
                                "@beli", beli
                            )

                            cmd.ExecuteNonQuery()

                        End Using

                    Next

                    ' 7. SEMUA BERHASIL
                    tr.Commit()

                Catch

                    Try
                        tr.Rollback()
                    Catch
                        ' Koneksi mungkin terputus.
                    End Try

                    Throw

                End Try

            End Using

            keranjang.Clear()
            PerbaruiRingkasanMasuk()
            txtKodeMasuk.Clear()
            numJumlahMasuk.Value = 1D

            MessageBox.Show(
                "Barang masuk berhasil disimpan." &
                vbCrLf &
                "Nomor: " & nomor,
                "AGRIMARTT"
            )

        Catch ex As Exception

            MessageBox.Show(
                "Gagal menyimpan Barang Masuk: " &
                ex.Message &
                vbCrLf &
                "Daftar belum dihapus agar bisa diperiksa.",
                "AGRIMARTT"
            )

        End Try

    End Sub

    ' ======================================
    ' LOGOUT
    ' ======================================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        If MessageBox.Show(
            "Logout dari AGRIMARTT?",
            "Konfirmasi",
            MessageBoxButtons.YesNo
        ) = DialogResult.Yes Then

            Me.Close()

        End If

    End Sub

    Private Sub FrmUtamaAdmin_FormClosing(
        sender As Object,
        e As FormClosingEventArgs
    ) Handles MyBase.FormClosing

        If keranjang.Rows.Count > 0 Then

            If MessageBox.Show(
                "Ada Barang Masuk yang belum disimpan. " &
                "Tetap keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo
            ) <> DialogResult.Yes Then

                e.Cancel = True

            End If

        End If

    End Sub


    ' TOMBOL BERUBAH SESUAI STATUS BARANG
    Private Sub dgvBarang_SelectionChanged(
    sender As Object,
    e As EventArgs
) Handles dgvBarang.SelectionChanged

        btnNonaktifBarang.Text = "Nonaktifkan"

        If dgvBarang.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        If Not dgvBarang.Columns.Contains("Status") Then
            Exit Sub
        End If

        Dim status As String =
        dgvBarang.SelectedRows(0).Cells("Status").Value.ToString()

        If status = "Nonaktif" Then
            btnNonaktifBarang.Text = "Aktifkan"
        Else
            btnNonaktifBarang.Text = "Nonaktifkan"
        End If

    End Sub


End Class
