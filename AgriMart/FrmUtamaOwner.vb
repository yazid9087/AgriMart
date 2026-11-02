
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySqlConnector

Public Class FrmUtamaOwner

    ' Diisi oleh FormLogin, sama seperti Dashboard Admin/Kasir.
    Public Property KoneksiAktif As MySqlConnection
    Public Property IdPengguna As Integer
    Public Property NamaOwner As String = ""
    Public Property PeranPengguna As String = ""

    Private Sub FrmUtamaOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If KoneksiAktif Is Nothing OrElse KoneksiAktif.State <> ConnectionState.Open Then
            MsgBox("Koneksi MySQL belum aktif. Silakan login kembali.")
            Me.Close()
            Exit Sub
        End If

        If IdPengguna <= 0 OrElse PeranPengguna <> "Owner" Then
            MsgBox("Akun ini bukan akun Owner.")
            Me.Close()
            Exit Sub
        End If

        lblNamaOwner.Text = "Halo, " & NamaOwner & "!"
        dtpTanggalAwal.Value = New Date(Today.Year, Today.Month, 1)
        dtpTanggalAkhir.Value = Today
        TampilkanPanel("Dashboard")
        MuatDashboard()
    End Sub

    Private Sub TampilkanPanel(nama As String)
        pnlDashboard.Visible = (nama = "Dashboard")
        pnlLaporan.Visible = (nama = "Laporan")

        If nama = "Dashboard" Then
            pnlDashboard.BringToFront()
            lblJudul.Text = "Dashboard Owner"
        Else
            pnlLaporan.BringToFront()
            lblJudul.Text = "Laporan Owner"
        End If

        btnDashboard.BackColor = If(nama = "Dashboard", Color.FromArgb(55, 119, 80), Color.FromArgb(23, 82, 44))
        btnLaporan.BackColor = If(nama = "Laporan", Color.FromArgb(55, 119, 80), Color.FromArgb(23, 82, 44))
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        TampilkanPanel("Dashboard")
        MuatDashboard()
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        TampilkanPanel("Laporan")
        MuatLaporan()
    End Sub

    Private Sub btnRefreshDashboard_Click(sender As Object, e As EventArgs) Handles btnRefreshDashboard.Click
        MuatDashboard()
    End Sub

    ' Angka dashboard dan rekap menggunakan data bulan berjalan.
    Private Sub MuatDashboard()
        Try
            Dim awal As Date = New Date(Today.Year, Today.Month, 1)
            Dim akhir As Date = awal.AddMonths(1)
            lblPeriodeDashboard.Text = "Ringkasan bulan " & Today.ToString("MMMM yyyy")

            Dim sql As String =
                "SELECT COALESCE(SUM(total_transaksi),0) AS omzet, " &
                "COUNT(*) AS jumlah_nota FROM v_laporan_penjualan " &
                "WHERE tanggal_transaksi >= @awal AND tanggal_transaksi < @akhir"

            Using cmd As New MySqlCommand(sql, KoneksiAktif)
                cmd.Parameters.AddWithValue("@awal", awal)
                cmd.Parameters.AddWithValue("@akhir", akhir)
                Using baca As MySqlDataReader = cmd.ExecuteReader()
                    If baca.Read() Then
                        lblOmzet.Text = "Rp " & CDec(baca("omzet")).ToString("N0")
                        lblJumlahTransaksi.Text = CInt(baca("jumlah_nota")).ToString("N0")
                    End If
                End Using
            End Using

            sql = "SELECT COALESCE(SUM(total_modal),0) AS modal, " &
                  "COALESCE(SUM(laba_kotor),0) AS laba " &
                  "FROM v_laporan_laba " &
                  "WHERE tanggal_transaksi >= @awal AND tanggal_transaksi < @akhir"

            Using cmd As New MySqlCommand(sql, KoneksiAktif)
                cmd.Parameters.AddWithValue("@awal", awal)
                cmd.Parameters.AddWithValue("@akhir", akhir)
                Using baca As MySqlDataReader = cmd.ExecuteReader()
                    If baca.Read() Then
                        lblTotalModal.Text = "Rp " & CDec(baca("modal")).ToString("N0")
                        lblLabaKotor.Text = "Rp " & CDec(baca("laba")).ToString("N0")
                    End If
                End Using
            End Using

            sql = "SELECT DATE(tanggal_transaksi) AS Tanggal, " &
                  "COUNT(*) AS `Jumlah Nota`, " &
                  "SUM(total_transaksi) AS Omzet " &
                  "FROM v_laporan_penjualan " &
                  "WHERE tanggal_transaksi >= @awal AND tanggal_transaksi < @akhir " &
                  "GROUP BY DATE(tanggal_transaksi) ORDER BY Tanggal DESC"

            Dim harian As New DataTable()
            Using cmd As New MySqlCommand(sql, KoneksiAktif)
                cmd.Parameters.AddWithValue("@awal", awal)
                cmd.Parameters.AddWithValue("@akhir", akhir)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(harian)
                End Using
            End Using
            dgvPenjualanHarian.DataSource = harian
            dgvPenjualanHarian.Columns("Tanggal").DefaultCellStyle.Format = "dd/MM/yyyy"
            dgvPenjualanHarian.Columns("Omzet").DefaultCellStyle.Format = "N0"
            dgvPenjualanHarian.ClearSelection()

            ' Akun Owner hanya boleh membaca kolom BARANG yang diberi GRANT.
            sql = "SELECT kode_barang AS Kode, nama_barang AS `Nama Barang`, " &
                  "stok AS Stok, satuan AS Satuan FROM BARANG " &
                  "WHERE status_aktif = 1 AND stok <= 10 " &
                  "ORDER BY stok, nama_barang LIMIT 100"

            Dim menipis As New DataTable()
            Using da As New MySqlDataAdapter(sql, KoneksiAktif)
                da.Fill(menipis)
            End Using
            dgvStokMenipis.DataSource = menipis
            dgvStokMenipis.ClearSelection()

        Catch ex As Exception
            MsgBox("Gagal memuat Dashboard Owner: " & ex.Message)
        End Try
    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        MuatLaporan()
    End Sub

    Private Sub btnBulanIni_Click(sender As Object, e As EventArgs) Handles btnBulanIni.Click
        dtpTanggalAwal.Value = New Date(Today.Year, Today.Month, 1)
        dtpTanggalAkhir.Value = Today
        MuatLaporan()
    End Sub

    ' Laporan dibatasi 500 baris supaya tabel tidak berat.
    Private Sub MuatLaporan()
        If dtpTanggalAwal.Value.Date > dtpTanggalAkhir.Value.Date Then
            MsgBox("Tanggal awal tidak boleh melebihi tanggal akhir.")
            Exit Sub
        End If

        Try
            Dim awal As Date = dtpTanggalAwal.Value.Date
            Dim akhir As Date = dtpTanggalAkhir.Value.Date.AddDays(1)

            Dim sql As String =
                "SELECT no_nota AS `No Nota`, tanggal_transaksi AS Tanggal, " &
                "kasir AS Kasir, metode_pembayaran AS Metode, " &
                "total_transaksi AS Total, jumlah_bayar AS Bayar, " &
                "kembalian AS Kembalian FROM v_laporan_penjualan " &
                "WHERE tanggal_transaksi >= @awal AND tanggal_transaksi < @akhir " &
                "ORDER BY tanggal_transaksi DESC, no_nota DESC LIMIT 500"

            Dim penjualan As New DataTable()
            Using cmd As New MySqlCommand(sql, KoneksiAktif)
                cmd.Parameters.AddWithValue("@awal", awal)
                cmd.Parameters.AddWithValue("@akhir", akhir)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(penjualan)
                End Using
            End Using
            dgvPenjualan.DataSource = penjualan
            dgvPenjualan.Columns("Tanggal").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dgvPenjualan.Columns("Total").DefaultCellStyle.Format = "N0"
            dgvPenjualan.Columns("Bayar").DefaultCellStyle.Format = "N0"
            dgvPenjualan.Columns("Kembalian").DefaultCellStyle.Format = "N0"
            dgvPenjualan.ClearSelection()

            sql = "SELECT no_nota AS `No Nota`, tanggal_transaksi AS Tanggal, " &
                  "kasir AS Kasir, omzet AS Omzet, " &
                  "total_modal AS Modal, laba_kotor AS `Laba Kotor` " &
                  "FROM v_laporan_laba " &
                  "WHERE tanggal_transaksi >= @awal AND tanggal_transaksi < @akhir " &
                  "ORDER BY tanggal_transaksi DESC, no_nota DESC LIMIT 500"

            Dim laba As New DataTable()
            Using cmd As New MySqlCommand(sql, KoneksiAktif)
                cmd.Parameters.AddWithValue("@awal", awal)
                cmd.Parameters.AddWithValue("@akhir", akhir)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(laba)
                End Using
            End Using
            dgvLaba.DataSource = laba
            dgvLaba.Columns("Tanggal").DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"
            dgvLaba.Columns("Omzet").DefaultCellStyle.Format = "N0"
            dgvLaba.Columns("Modal").DefaultCellStyle.Format = "N0"
            dgvLaba.Columns("Laba Kotor").DefaultCellStyle.Format = "N0"
            dgvLaba.ClearSelection()

        Catch ex As Exception
            MsgBox("Gagal menampilkan laporan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Logout dari AGRIMARTT?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Konfirmasi") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
