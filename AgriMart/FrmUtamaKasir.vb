
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MySqlConnector

Public Class FrmUtamaKasir

    ' Data dari FormLogin
    Public Property KoneksiAktif As MySqlConnection
    Public Property IdPengguna As Integer
    Public Property NamaKasir As String = ""
    Public Property PeranPengguna As String = ""

    Private keranjang As New DataTable()

    ' =====================================
    ' SAAT FORM DIBUKA
    ' =====================================
    Private Sub FrmUtamaKasir_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        If KoneksiAktif Is Nothing Then
            MsgBox("Koneksi MySQL belum tersedia!")
            Me.Close()
            Exit Sub
        End If

        If KoneksiAktif.State <> ConnectionState.Open Then
            MsgBox("Koneksi MySQL tidak aktif!")
            Me.Close()
            Exit Sub
        End If

        If PeranPengguna <> "Kasir" Or IdPengguna <= 0 Then
            MsgBox("Akun ini bukan akun Kasir!")
            Me.Close()
            Exit Sub
        End If

        lblIdentitas.Text = "Halo, " & NamaKasir & "!"

        ' Kolom keranjang penjualan
        keranjang.Columns.Add("ID", GetType(Integer))
        keranjang.Columns.Add("Nama Barang", GetType(String))
        keranjang.Columns.Add("Harga Jual", GetType(Decimal))
        keranjang.Columns.Add("Jumlah", GetType(Integer))
        keranjang.Columns.Add("Subtotal", GetType(Decimal))

        dgvKeranjang.DataSource = keranjang
        dgvKeranjang.Columns("ID").Visible = False
        dgvKeranjang.Columns("Harga Jual").DefaultCellStyle.Format = "N2"
        dgvKeranjang.Columns("Subtotal").DefaultCellStyle.Format = "N2"

        cmbMetode.SelectedIndex = 0

        TampilkanPanel("Penjualan")
        MuatBarang("", dgvHasilCari)
        HitungTotal()

    End Sub

    ' =====================================
    ' NAVIGASI PANEL
    ' =====================================
    Private Sub TampilkanPanel(nama As String)

        pnlPenjualan.Visible = (nama = "Penjualan")
        pnlDaftarBarang.Visible = (nama = "Daftar Barang")

        If nama = "Penjualan" Then

            pnlPenjualan.BringToFront()
            lblJudul.Text = "Transaksi Penjualan"

        Else

            pnlDaftarBarang.BringToFront()
            lblJudul.Text = "Daftar Barang"

        End If

        btnPenjualan.BackColor =
            If(nama = "Penjualan",
               Color.FromArgb(55, 119, 80),
               Color.FromArgb(23, 82, 44))

        btnDaftarBarang.BackColor =
            If(nama = "Daftar Barang",
               Color.FromArgb(55, 119, 80),
               Color.FromArgb(23, 82, 44))

    End Sub

    Private Sub btnPenjualan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnPenjualan.Click

        TampilkanPanel("Penjualan")
        txtCariJual.Focus()

    End Sub

    Private Sub btnDaftarBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnDaftarBarang.Click

        TampilkanPanel("Daftar Barang")
        MuatBarang(txtCariBarang.Text, dgvDaftarBarang)

    End Sub

    ' =====================================
    ' MENCARI BARANG DARI MYSQL
    ' =====================================
    Private Sub MuatBarang(
        cari As String,
        tabel As DataGridView
    )

        Try

            Dim sql As String =
                "SELECT " &
                "id_barang AS ID, " &
                "nama_barang AS `Nama Barang`, " &
                "kategori AS Kategori, " &
                "satuan AS Satuan, " &
                "harga_jual AS `Harga Jual`, " &
                "stok AS Stok " &
                "FROM BARANG " &
                "WHERE status_aktif = 1 " &
                "AND (nama_barang LIKE @cari " &
                "OR kategori LIKE @cari) " &
                "ORDER BY nama_barang " &
                "LIMIT 100"

            Dim data As New DataTable()

            Using cmd As New MySqlCommand(sql, KoneksiAktif)

                cmd.Parameters.AddWithValue(
                    "@cari", "%" & cari.Trim() & "%"
                )

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(data)
                End Using

            End Using

            tabel.DataSource = data

            tabel.Columns("ID").Visible = False

            tabel.Columns(
                "Harga Jual"
            ).DefaultCellStyle.Format = "N2"

            tabel.ClearSelection()

        Catch ex As Exception

            MsgBox(
                "Gagal mencari barang: " & ex.Message
            )

        End Try

    End Sub

    ' =====================================
    ' PENCARIAN DI PANEL PENJUALAN
    ' =====================================
    Private Sub btnCariJual_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCariJual.Click

        MuatBarang(txtCariJual.Text, dgvHasilCari)

    End Sub

    ' TEKAN ENTER UNTUK MENCARI
    Private Sub txtCariJual_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtCariJual.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            MuatBarang(txtCariJual.Text, dgvHasilCari)

        End If

    End Sub

    ' =====================================
    ' PENCARIAN DI DAFTAR BARANG
    ' =====================================
    Private Sub btnCariBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCariBarang.Click

        MuatBarang(txtCariBarang.Text, dgvDaftarBarang)

    End Sub

    Private Sub btnRefreshBarang_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefreshBarang.Click

        txtCariBarang.Clear()
        MuatBarang("", dgvDaftarBarang)

    End Sub

    ' =====================================
    ' TAMBAH BARANG KE KERANJANG
    ' =====================================
    Private Sub btnTambahItem_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnTambahItem.Click

        If dgvHasilCari.SelectedRows.Count = 0 Then

            MsgBox("Pilih barang pada hasil pencarian!")
            Exit Sub

        End If

        Dim idBarang As Integer =
            CInt(
                dgvHasilCari.SelectedRows(0).
                Cells("ID").Value
            )

        TambahKeranjang(idBarang)

    End Sub

    ' DOUBLE-CLICK HASIL PENCARIAN
    Private Sub dgvHasilCari_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvHasilCari.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Dim idBarang As Integer =
            CInt(
                dgvHasilCari.Rows(e.RowIndex).
                Cells("ID").Value
            )

        TambahKeranjang(idBarang)

    End Sub

    ' DOUBLE-CLICK DARI DAFTAR BARANG
    Private Sub dgvDaftarBarang_CellDoubleClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvDaftarBarang.CellDoubleClick

        If e.RowIndex < 0 Then Exit Sub

        Dim idBarang As Integer =
            CInt(
                dgvDaftarBarang.Rows(e.RowIndex).
                Cells("ID").Value
            )

        TambahKeranjang(idBarang)
        TampilkanPanel("Penjualan")

    End Sub

    ' =====================================
    ' PROSES MENAMBAH KERANJANG
    ' =====================================
    Private Sub TambahKeranjang(idBarang As Integer)

        Try

            Dim nama As String = ""
            Dim harga As Decimal = 0D
            Dim stok As Integer = 0
            Dim ditemukan As Boolean = False

            ' Ambil data barang terbaru dari MySQL
            Dim sql As String =
                "SELECT nama_barang, harga_jual, stok " &
                "FROM BARANG " &
                "WHERE id_barang=@id AND status_aktif=1"

            Using cmd As New MySqlCommand(sql, KoneksiAktif)

                cmd.Parameters.AddWithValue("@id", idBarang)

                Using dr As MySqlDataReader =
                    cmd.ExecuteReader()

                    If dr.Read() Then

                        ditemukan = True
                        nama = dr("nama_barang").ToString()
                        harga = CDec(dr("harga_jual"))
                        stok = CInt(dr("stok"))

                    End If

                End Using

            End Using

            If Not ditemukan Then

                MsgBox("Barang tidak ditemukan atau nonaktif!")
                Exit Sub

            End If

            Dim jumlah As Integer =
                CInt(numJumlahJual.Value)

            If jumlah > stok Then

                MsgBox(
                    "Stok tidak mencukupi!" &
                    vbCrLf &
                    "Stok tersedia: " & stok
                )

                Exit Sub

            End If

            Dim sudahAda As Boolean = False

            ' Jika sudah di keranjang,
            ' tambahkan jumlahnya.
            For Each baris As DataRow In keranjang.Rows

                If CInt(baris("ID")) = idBarang Then

                    Dim jumlahBaru As Integer =
                        CInt(baris("Jumlah")) + jumlah

                    If jumlahBaru > stok Then

                        MsgBox(
                            "Jumlah melebihi stok tersedia!"
                        )

                        Exit Sub

                    End If

                    baris("Jumlah") = jumlahBaru
                    baris("Harga Jual") = harga
                    baris("Subtotal") = harga * jumlahBaru

                    sudahAda = True
                    Exit For

                End If

            Next

            If Not sudahAda Then

                keranjang.Rows.Add(
                    idBarang,
                    nama,
                    harga,
                    jumlah,
                    harga * jumlah
                )

            End If

            HitungTotal()

            numJumlahJual.Value = 1D
            dgvHasilCari.ClearSelection()

        Catch ex As Exception

            MsgBox(
                "Gagal menambah barang: " & ex.Message
            )

        End Try

    End Sub

    ' =====================================
    ' HAPUS ITEM KERANJANG
    ' =====================================
    Private Sub btnHapusItem_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnHapusItem.Click

        If dgvKeranjang.SelectedRows.Count = 0 Then

            MsgBox("Pilih barang dalam keranjang!")
            Exit Sub

        End If

        Dim baris As DataRowView =
            TryCast(
                dgvKeranjang.SelectedRows(0).DataBoundItem,
                DataRowView
            )

        If baris IsNot Nothing Then

            keranjang.Rows.Remove(baris.Row)

        End If

        HitungTotal()

    End Sub

    ' =====================================
    ' KOSONGKAN KERANJANG
    ' =====================================
    Private Sub btnKosongkan_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnKosongkan.Click

        If keranjang.Rows.Count = 0 Then Exit Sub

        If MsgBox(
            "Kosongkan seluruh keranjang?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question,
            "Konfirmasi"
        ) = MsgBoxResult.Yes Then

            keranjang.Clear()
            HitungTotal()

        End If

    End Sub

    ' =====================================
    ' HITUNG TOTAL DAN KEMBALIAN
    ' =====================================
    Private Sub HitungTotal()

        Dim total As Decimal = 0D

        For Each baris As DataRow In keranjang.Rows

            total += CDec(baris("Subtotal"))

        Next

        lblTotal.Text =
            "Rp " & total.ToString("N2")

        ' QRIS harus dibayar tepat.
        If cmbMetode.Text = "QRIS" Then

            If numBayar.Value <> total Then
                numBayar.Value = total
            End If

        End If

        Dim kembali As Decimal =
            numBayar.Value - total

        If kembali < 0D Then
            kembali = 0D
        End If

        lblKembalian.Text =
            "Rp " & kembali.ToString("N2")

    End Sub

    Private Sub cmbMetode_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbMetode.SelectedIndexChanged

        If cmbMetode.Text = "QRIS" Then

            numBayar.Enabled = False

        Else

            numBayar.Enabled = True

        End If

        HitungTotal()

    End Sub

    Private Sub numBayar_ValueChanged(
        sender As Object,
        e As EventArgs
    ) Handles numBayar.ValueChanged

        HitungTotal()

    End Sub

    ' =====================================
    ' SIMPAN PENJUALAN KE MYSQL
    ' =====================================
    Private Sub btnSimpanJual_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSimpanJual.Click

        If KoneksiAktif Is Nothing OrElse
           KoneksiAktif.State <> ConnectionState.Open Then

            MsgBox("Koneksi MySQL tidak aktif!")
            Exit Sub

        End If

        If keranjang.Rows.Count = 0 Then

            MsgBox("Keranjang masih kosong!")
            Exit Sub

        End If

        ' Hitung total dari keranjang
        Dim total As Decimal = 0D

        For Each baris As DataRow In keranjang.Rows

            total += CDec(baris("Subtotal"))

        Next

        Dim metode As String = cmbMetode.Text
        Dim bayar As Decimal = numBayar.Value

        If metode <> "Tunai" And metode <> "QRIS" Then

            MsgBox("Pilih metode pembayaran!")
            Exit Sub

        End If

        If bayar < total Then

            MsgBox("Jumlah bayar kurang!")
            Exit Sub

        End If

        If metode = "QRIS" And bayar <> total Then

            MsgBox("Pembayaran QRIS harus tepat!")
            Exit Sub

        End If

        If MsgBox(
            "Simpan transaksi penjualan?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question,
            "Konfirmasi"
        ) <> MsgBoxResult.Yes Then Exit Sub

        ' Nomor nota otomatis
        Dim nomor As String =
            "NT-" &
            DateTime.Now.ToString("yyyyMMddHHmmss") &
            "-" &
            Guid.NewGuid().ToString("N").Substring(0, 6)

        Try

            ' Header, detail, dan stok
            ' disimpan dalam satu transaksi MySQL.
            Using tr As MySqlTransaction =
                KoneksiAktif.BeginTransaction()

                Try

                    Dim idTransaksi As Long
                    Dim sql As String

                    ' 1. Simpan header nota
                    sql =
                        "INSERT INTO TRANSAKSI " &
                        "(no_nota, id_pengguna, " &
                        "metode_pembayaran, total_transaksi, " &
                        "jumlah_bayar) " &
                        "VALUES (@nota, @kasir, @metode, " &
                        "@total, @bayar)"

                    Using cmd As New MySqlCommand(
                        sql, KoneksiAktif, tr
                    )

                        cmd.Parameters.AddWithValue(
                            "@nota", nomor
                        )

                        cmd.Parameters.AddWithValue(
                            "@kasir", IdPengguna
                        )

                        cmd.Parameters.AddWithValue(
                            "@metode", metode
                        )

                        cmd.Parameters.AddWithValue(
                            "@total", total
                        )

                        cmd.Parameters.AddWithValue(
                            "@bayar", bayar
                        )

                        cmd.ExecuteNonQuery()

                        idTransaksi = cmd.LastInsertedId

                    End Using

                    ' 2. Proses semua item di keranjang
                    For Each baris As DataRow In
                        keranjang.Select("", "ID ASC")

                        Dim idBarang As Integer =
                            CInt(baris("ID"))

                        Dim jumlah As Integer =
                            CInt(baris("Jumlah"))

                        Dim hargaBeli As Decimal = 0D
                        Dim hargaJual As Decimal = 0D
                        Dim stok As Integer = 0
                        Dim aktif As Boolean = False

                        ' Periksa stok dan harga terbaru
                        sql =
                            "SELECT harga_beli, harga_jual, " &
                            "stok, status_aktif " &
                            "FROM BARANG " &
                            "WHERE id_barang=@id FOR UPDATE"

                        Using cmd As New MySqlCommand(
                            sql, KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@id", idBarang
                            )

                            Using dr As MySqlDataReader =
                                cmd.ExecuteReader()

                                If Not dr.Read() Then

                                    Throw New Exception(
                                        "Barang tidak ditemukan."
                                    )

                                End If

                                hargaBeli =
                                    CDec(dr("harga_beli"))

                                hargaJual =
                                    CDec(dr("harga_jual"))

                                stok =
                                    CInt(dr("stok"))

                                aktif =
                                    CBool(dr("status_aktif"))

                            End Using

                        End Using

                        If Not aktif Then

                            Throw New Exception(
                                "Ada barang yang sudah nonaktif."
                            )

                        End If

                        If stok < jumlah Then

                            Throw New Exception(
                                "Stok barang tidak mencukupi."
                            )

                        End If

                        If hargaJual <>
                           CDec(baris("Harga Jual")) Then

                            Throw New Exception(
                                "Harga barang berubah. " &
                                "Hapus item lalu tambahkan kembali."
                            )

                        End If

                        ' 3. Kurangi stok barang
                        sql =
                            "UPDATE BARANG SET " &
                            "stok=stok-@jumlah " &
                            "WHERE id_barang=@id " &
                            "AND stok>=@jumlah " &
                            "AND status_aktif=1"

                        Using cmd As New MySqlCommand(
                            sql, KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@jumlah", jumlah
                            )

                            cmd.Parameters.AddWithValue(
                                "@id", idBarang
                            )

                            If cmd.ExecuteNonQuery() <> 1 Then

                                Throw New Exception(
                                    "Gagal mengurangi stok."
                                )

                            End If

                        End Using

                        ' 4. Simpan detail penjualan
                        sql =
                            "INSERT INTO DETAIL_TRANSAKSI " &
                            "(id_transaksi, id_barang, jumlah, " &
                            "harga_beli, harga_jual) " &
                            "VALUES (@transaksi, @barang, " &
                            "@jumlah, @beli, @jual)"

                        Using cmd As New MySqlCommand(
                            sql, KoneksiAktif, tr
                        )

                            cmd.Parameters.AddWithValue(
                                "@transaksi", idTransaksi
                            )

                            cmd.Parameters.AddWithValue(
                                "@barang", idBarang
                            )

                            cmd.Parameters.AddWithValue(
                                "@jumlah", jumlah
                            )

                            cmd.Parameters.AddWithValue(
                                "@beli", hargaBeli
                            )

                            cmd.Parameters.AddWithValue(
                                "@jual", hargaJual
                            )

                            cmd.ExecuteNonQuery()

                        End Using

                    Next

                    ' Semua berhasil
                    tr.Commit()

                Catch

                    Try
                        tr.Rollback()
                    Catch
                        ' Koneksi bisa terputus.
                    End Try

                    Throw

                End Try

            End Using

            Dim kembalian As Decimal =
                bayar - total

            MsgBox(
                "Penjualan berhasil disimpan!" &
                vbCrLf &
                "No. Nota: " & nomor &
                vbCrLf &
                "Total: Rp " & total.ToString("N2") &
                vbCrLf &
                "Bayar: Rp " & bayar.ToString("N2") &
                vbCrLf &
                "Kembalian: Rp " &
                kembalian.ToString("N2")
            )

            ' Bersihkan setelah berhasil
            keranjang.Clear()
            numBayar.Value = 0D
            cmbMetode.SelectedIndex = 0
            numJumlahJual.Value = 1D
            txtCariJual.Clear()

            MuatBarang("", dgvHasilCari)
            HitungTotal()
            txtCariJual.Focus()

        Catch ex As Exception

            MsgBox(
                "Gagal menyimpan penjualan: " &
                ex.Message &
                vbCrLf &
                "Keranjang tetap disimpan sementara."
            )

        End Try

    End Sub

    ' =====================================
    ' LOGOUT
    ' =====================================
    Private Sub btnLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnLogout.Click

        If MsgBox(
            "Logout dari AGRIMARTT?",
            MsgBoxStyle.YesNo + MsgBoxStyle.Question,
            "Konfirmasi"
        ) = MsgBoxResult.Yes Then

            Me.Close()

        End If

    End Sub

    Private Sub FrmUtamaKasir_FormClosing(
        sender As Object,
        e As FormClosingEventArgs
    ) Handles MyBase.FormClosing

        If keranjang.Rows.Count > 0 Then

            If MsgBox(
                "Keranjang belum disimpan. Tetap keluar?",
                MsgBoxStyle.YesNo + MsgBoxStyle.Question,
                "Konfirmasi"
            ) = MsgBoxResult.No Then

                e.Cancel = True

            End If

        End If

    End Sub

End Class
