
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaAdmin
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' KONTROL UTAMA
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblIdentitas As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnDataBarang As Button
    Friend WithEvents btnBarangMasuk As Button
    Friend WithEvents btnLogout As Button

    ' DASHBOARD
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents tblStat As TableLayoutPanel
    Friend WithEvents lblTotalBarang As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents lblStokMenipis As Label
    Friend WithEvents lblRiwayat As Label
    Friend WithEvents btnRefreshDashboard As Button
    Friend WithEvents dgvRiwayatMasuk As DataGridView
    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents pnlRiwayatHeader As Panel

    ' DATA BARANG
    Friend WithEvents pnlDataBarang As Panel
    Friend WithEvents pnlCariBarang As Panel
    Friend WithEvents pnlEditorBarang As Panel
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents btnCariBarang As Button
    Friend WithEvents btnRefreshBarang As Button
    Friend WithEvents lblEditor As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtKategoriBarang As TextBox
    Friend WithEvents txtSatuanBarang As TextBox
    Friend WithEvents numHargaBeli As NumericUpDown
    Friend WithEvents numHargaJual As NumericUpDown
    Friend WithEvents btnSimpanBarang As Button
    Friend WithEvents btnBatalBarang As Button
    Friend WithEvents btnEditBarang As Button
    Friend WithEvents btnNonaktifBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents dgvBarang As DataGridView

    ' BARANG MASUK
    Friend WithEvents pnlBarangMasuk As Panel
    Friend WithEvents pnlMasukInput As Panel
    Friend WithEvents pnlMasukBawah As Panel
    Friend WithEvents txtKodeMasuk As TextBox
    Friend WithEvents txtNamaMasuk As TextBox
    Friend WithEvents txtKategoriMasuk As TextBox
    Friend WithEvents txtSatuanMasuk As TextBox
    Friend WithEvents numJumlahMasuk As NumericUpDown
    Friend WithEvents numHargaMasuk As NumericUpDown
    Friend WithEvents numHargaJualMasuk As NumericUpDown
    Friend WithEvents btnTambahMasuk As Button
    Friend WithEvents btnHapusMasuk As Button
    Friend WithEvents btnBersihkanMasuk As Button
    Friend WithEvents btnSimpanMasuk As Button
    Friend WithEvents lblRingkasanMasuk As Label
    Friend WithEvents dgvDetailMasuk As DataGridView

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.components = New System.ComponentModel.Container()

        Me.pnlSidebar = New Panel()
        Me.pnlMain = New Panel()
        Me.pnlHeader = New Panel()
        Me.pnlKonten = New Panel()
        Me.lblBrand = New Label()
        Me.lblJudul = New Label()
        Me.lblIdentitas = New Label()
        Me.btnDashboard = New Button()
        Me.btnDataBarang = New Button()
        Me.btnBarangMasuk = New Button()
        Me.btnLogout = New Button()

        Me.pnlDashboard = New Panel()
        Me.tblStat = New TableLayoutPanel()
        Me.lblTotalBarang = New Label()
        Me.lblTotalStok = New Label()
        Me.lblStokMenipis = New Label()
        Me.lblRiwayat = New Label()
        Me.btnRefreshDashboard = New Button()
        Me.dgvRiwayatMasuk = New DataGridView()
        Me.pnlRiwayat = New Panel()
        Me.pnlRiwayatHeader = New Panel()

        Me.pnlDataBarang = New Panel()
        Me.pnlCariBarang = New Panel()
        Me.pnlEditorBarang = New Panel()
        Me.txtCariBarang = New TextBox()
        Me.btnCariBarang = New Button()
        Me.btnRefreshBarang = New Button()
        Me.lblEditor = New Label()
        Me.txtKodeBarang = New TextBox()
        Me.txtNamaBarang = New TextBox()
        Me.txtKategoriBarang = New TextBox()
        Me.txtSatuanBarang = New TextBox()
        Me.numHargaBeli = New NumericUpDown()
        Me.numHargaJual = New NumericUpDown()
        Me.btnSimpanBarang = New Button()
        Me.btnBatalBarang = New Button()
        Me.btnEditBarang = New Button()
        Me.btnNonaktifBarang = New Button()
        Me.btnHapusBarang = New Button()
        Me.dgvBarang = New DataGridView()

        Me.pnlBarangMasuk = New Panel()
        Me.pnlMasukInput = New Panel()
        Me.pnlMasukBawah = New Panel()
        Me.txtKodeMasuk = New TextBox()
        Me.txtNamaMasuk = New TextBox()
        Me.txtKategoriMasuk = New TextBox()
        Me.txtSatuanMasuk = New TextBox()
        Me.numJumlahMasuk = New NumericUpDown()
        Me.numHargaMasuk = New NumericUpDown()
        Me.numHargaJualMasuk = New NumericUpDown()
        Me.btnTambahMasuk = New Button()
        Me.btnHapusMasuk = New Button()
        Me.btnBersihkanMasuk = New Button()
        Me.btnSimpanMasuk = New Button()
        Me.lblRingkasanMasuk = New Label()
        Me.dgvDetailMasuk = New DataGridView()

        ' NAMA KONTROL UNTUK DESIGNER
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlMain.Name = "pnlMain"
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlKonten.Name = "pnlKonten"
        Me.lblBrand.Name = "lblBrand"
        Me.lblJudul.Name = "lblJudul"
        Me.lblIdentitas.Name = "lblIdentitas"
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDataBarang.Name = "btnDataBarang"
        Me.btnBarangMasuk.Name = "btnBarangMasuk"
        Me.btnLogout.Name = "btnLogout"

        Me.pnlDashboard.Name = "pnlDashboard"
        Me.tblStat.Name = "tblStat"
        Me.lblTotalBarang.Name = "lblTotalBarang"
        Me.lblTotalStok.Name = "lblTotalStok"
        Me.lblStokMenipis.Name = "lblStokMenipis"
        Me.lblRiwayat.Name = "lblRiwayat"
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.dgvRiwayatMasuk.Name = "dgvRiwayatMasuk"
        Me.pnlRiwayat.Name = "pnlRiwayat"
        Me.pnlRiwayatHeader.Name = "pnlRiwayatHeader"

        Me.pnlDataBarang.Name = "pnlDataBarang"
        Me.pnlCariBarang.Name = "pnlCariBarang"
        Me.pnlEditorBarang.Name = "pnlEditorBarang"
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnRefreshBarang.Name = "btnRefreshBarang"
        Me.lblEditor.Name = "lblEditor"
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtKategoriBarang.Name = "txtKategoriBarang"
        Me.txtSatuanBarang.Name = "txtSatuanBarang"
        Me.numHargaBeli.Name = "numHargaBeli"
        Me.numHargaJual.Name = "numHargaJual"
        Me.btnSimpanBarang.Name = "btnSimpanBarang"
        Me.btnBatalBarang.Name = "btnBatalBarang"
        Me.btnEditBarang.Name = "btnEditBarang"
        Me.btnNonaktifBarang.Name = "btnNonaktifBarang"
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.dgvBarang.Name = "dgvBarang"

        Me.pnlBarangMasuk.Name = "pnlBarangMasuk"
        Me.pnlMasukInput.Name = "pnlMasukInput"
        Me.pnlMasukBawah.Name = "pnlMasukBawah"
        Me.txtKodeMasuk.Name = "txtKodeMasuk"
        Me.txtNamaMasuk.Name = "txtNamaMasuk"
        Me.txtKategoriMasuk.Name = "txtKategoriMasuk"
        Me.txtSatuanMasuk.Name = "txtSatuanMasuk"
        Me.numJumlahMasuk.Name = "numJumlahMasuk"
        Me.numHargaMasuk.Name = "numHargaMasuk"
        Me.numHargaJualMasuk.Name = "numHargaJualMasuk"
        Me.btnTambahMasuk.Name = "btnTambahMasuk"
        Me.btnHapusMasuk.Name = "btnHapusMasuk"
        Me.btnBersihkanMasuk.Name = "btnBersihkanMasuk"
        Me.btnSimpanMasuk.Name = "btnSimpanMasuk"
        Me.lblRingkasanMasuk.Name = "lblRingkasanMasuk"
        Me.dgvDetailMasuk.Name = "dgvDetailMasuk"

        Me.SuspendLayout()

        ' ===============================
        ' FORM
        ' ===============================
        Me.Name = "FrmUtamaAdmin"
        Me.Text = "AGRIMARTT | Dashboard Admin"
        Me.ClientSize = New Size(1250, 740)
        Me.MinimumSize = New Size(1150, 650)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Font = New Font("Segoe UI", 10.0!)
        Me.BackColor = Color.FromArgb(245, 248, 244)
        Me.AutoScaleMode = AutoScaleMode.Font

        ' ===============================
        ' SIDEBAR
        ' ===============================
        Me.pnlSidebar.Dock = DockStyle.Left
        Me.pnlSidebar.Width = 220
        Me.pnlSidebar.BackColor = Color.FromArgb(23, 82, 44)

        Me.lblBrand.Text = "AGRIMARTT"
        Me.lblBrand.Font = New Font(
            "Segoe UI", 20.0!, FontStyle.Bold)
        Me.lblBrand.ForeColor = Color.White
        Me.lblBrand.Location = New Point(15, 35)
        Me.lblBrand.Size = New Size(200, 45)

        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.Location = New Point(12, 145)
        Me.btnDashboard.Size = New Size(195, 47)
        Me.btnDashboard.BackColor = Color.FromArgb(55, 119, 80)

        Me.btnDataBarang.Text = "   Data Barang"
        Me.btnDataBarang.Location = New Point(12, 200)
        Me.btnDataBarang.Size = New Size(195, 47)
        Me.btnDataBarang.BackColor = Color.FromArgb(23, 82, 44)

        Me.btnBarangMasuk.Text = "   Barang Masuk"
        Me.btnBarangMasuk.Location = New Point(12, 255)
        Me.btnBarangMasuk.Size = New Size(195, 47)
        Me.btnBarangMasuk.BackColor = Color.FromArgb(23, 82, 44)

        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.Dock = DockStyle.Bottom
        Me.btnLogout.Height = 47
        Me.btnLogout.BackColor = Color.FromArgb(47, 102, 69)

        Me.btnDashboard.ForeColor = Color.White
        Me.btnDashboard.FlatStyle = FlatStyle.Flat
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False

        Me.btnDataBarang.ForeColor = Color.White
        Me.btnDataBarang.FlatStyle = FlatStyle.Flat
        Me.btnDataBarang.FlatAppearance.BorderSize = 0
        Me.btnDataBarang.TextAlign = ContentAlignment.MiddleLeft
        Me.btnDataBarang.UseVisualStyleBackColor = False

        Me.btnBarangMasuk.ForeColor = Color.White
        Me.btnBarangMasuk.FlatStyle = FlatStyle.Flat
        Me.btnBarangMasuk.FlatAppearance.BorderSize = 0
        Me.btnBarangMasuk.TextAlign = ContentAlignment.MiddleLeft
        Me.btnBarangMasuk.UseVisualStyleBackColor = False

        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.TextAlign = ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False

        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnDataBarang)
        Me.pnlSidebar.Controls.Add(Me.btnBarangMasuk)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)

        ' ===============================
        ' HEADER
        ' ===============================
        Me.pnlMain.Dock = DockStyle.Fill

        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 82
        Me.pnlHeader.BackColor = Color.White

        Me.lblJudul.Text = "Dashboard"
        Me.lblJudul.Font = New Font(
            "Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblJudul.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblJudul.Location = New Point(22, 16)
        Me.lblJudul.Size = New Size(360, 49)

        Me.lblIdentitas.Text = "Halo, Admin!"
        Me.lblIdentitas.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblIdentitas.TextAlign = ContentAlignment.MiddleRight
        Me.lblIdentitas.Dock = DockStyle.Right
        Me.lblIdentitas.Width = 275
        Me.lblIdentitas.Padding = New Padding(0, 0, 12, 0)

        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblIdentitas)

        Me.pnlKonten.Dock = DockStyle.Fill
        Me.pnlKonten.Padding = New Padding(18)

        ' ===============================
        ' PANEL 1: DASHBOARD
        ' ===============================
        Me.pnlDashboard.Dock = DockStyle.Fill

        Me.tblStat.Dock = DockStyle.Top
        Me.tblStat.Height = 135
        Me.tblStat.ColumnCount = 3
        Me.tblStat.RowCount = 1

        Me.tblStat.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 33.33!))
        Me.tblStat.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 33.33!))
        Me.tblStat.ColumnStyles.Add(
            New ColumnStyle(SizeType.Percent, 33.34!))

        Dim kartu1 As New Panel()
        Dim kartu2 As New Panel()
        Dim kartu3 As New Panel()

        kartu1.Dock = DockStyle.Fill
        kartu2.Dock = DockStyle.Fill
        kartu3.Dock = DockStyle.Fill

        kartu1.BackColor = Color.White
        kartu2.BackColor = Color.White
        kartu3.BackColor = Color.White

        kartu1.Margin = New Padding(0, 0, 8, 12)
        kartu2.Margin = New Padding(4, 0, 4, 12)
        kartu3.Margin = New Padding(8, 0, 0, 12)

        Me.lblTotalBarang.Text = "0"
        Me.lblTotalBarang.Font = New Font(
            "Segoe UI", 29.0!, FontStyle.Bold)
        Me.lblTotalBarang.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblTotalBarang.Location = New Point(16, 12)
        Me.lblTotalBarang.Size = New Size(230, 62)

        Me.lblTotalStok.Text = "0"
        Me.lblTotalStok.Font = New Font(
            "Segoe UI", 29.0!, FontStyle.Bold)
        Me.lblTotalStok.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblTotalStok.Location = New Point(16, 12)
        Me.lblTotalStok.Size = New Size(230, 62)

        Me.lblStokMenipis.Text = "0"
        Me.lblStokMenipis.Font = New Font(
            "Segoe UI", 29.0!, FontStyle.Bold)
        Me.lblStokMenipis.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblStokMenipis.Location = New Point(16, 12)
        Me.lblStokMenipis.Size = New Size(230, 62)

        Dim ket1 As New Label() With {
            .Text = "Total Barang Aktif",
            .Location = New Point(18, 86),
            .Size = New Size(240, 25)
        }

        Dim ket2 As New Label() With {
            .Text = "Total Unit Stok",
            .Location = New Point(18, 86),
            .Size = New Size(240, 25)
        }

        Dim ket3 As New Label() With {
            .Text = "Stok Menipis (<= 10)",
            .Location = New Point(18, 86),
            .Size = New Size(240, 25)
        }

        kartu1.Controls.Add(Me.lblTotalBarang)
        kartu1.Controls.Add(ket1)

        kartu2.Controls.Add(Me.lblTotalStok)
        kartu2.Controls.Add(ket2)

        kartu3.Controls.Add(Me.lblStokMenipis)
        kartu3.Controls.Add(ket3)

        Me.tblStat.Controls.Add(kartu1, 0, 0)
        Me.tblStat.Controls.Add(kartu2, 1, 0)
        Me.tblStat.Controls.Add(kartu3, 2, 0)

        ' RIWAYAT BARANG MASUK
        Me.pnlRiwayat.Dock = DockStyle.Fill
        Me.pnlRiwayat.Padding = New Padding(12)
        Me.pnlRiwayat.BackColor = Color.White

        Me.pnlRiwayatHeader.Dock = DockStyle.Top
        Me.pnlRiwayatHeader.Height = 48

        Me.lblRiwayat.Text = "Riwayat Barang Masuk"
        Me.lblRiwayat.Font = New Font(
            "Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblRiwayat.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblRiwayat.Location = New Point(4, 6)
        Me.lblRiwayat.Size = New Size(340, 35)

        Me.btnRefreshDashboard.Text = "Refresh"
        Me.btnRefreshDashboard.Location = New Point(705, 5)
        Me.btnRefreshDashboard.Size = New Size(100, 35)

        Me.pnlRiwayatHeader.Controls.Add(Me.lblRiwayat)
        Me.pnlRiwayatHeader.Controls.Add(Me.btnRefreshDashboard)

        Me.dgvRiwayatMasuk.Dock = DockStyle.Fill
        Me.dgvRiwayatMasuk.BackgroundColor = Color.White
        Me.dgvRiwayatMasuk.ReadOnly = True
        Me.dgvRiwayatMasuk.AllowUserToAddRows = False
        Me.dgvRiwayatMasuk.AllowUserToDeleteRows = False
        Me.dgvRiwayatMasuk.RowHeadersVisible = False
        Me.dgvRiwayatMasuk.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        Me.pnlRiwayat.Controls.Add(Me.dgvRiwayatMasuk)
        Me.pnlRiwayat.Controls.Add(Me.pnlRiwayatHeader)

        Me.pnlDashboard.Controls.Add(Me.pnlRiwayat)
        Me.pnlDashboard.Controls.Add(Me.tblStat)

        ' ===============================
        ' PANEL 2: DATA BARANG
        ' ===============================
        Me.pnlDataBarang.Dock = DockStyle.Fill
        Me.pnlDataBarang.BackColor = Color.FromArgb(245, 248, 244)
        Me.pnlDataBarang.Visible = True

        ' PENCARIAN
        Me.pnlCariBarang.Dock = DockStyle.Top
        Me.pnlCariBarang.Height = 65

        Me.txtCariBarang.Location = New Point(15, 15)
        Me.txtCariBarang.Size = New Size(300, 31)

        Me.btnCariBarang.Text = "Cari"
        Me.btnCariBarang.Location = New Point(329, 13)
        Me.btnCariBarang.Size = New Size(90, 36)
        Me.btnCariBarang.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnCariBarang.ForeColor = Color.White

        Me.btnRefreshBarang.Text = "Refresh"
        Me.btnRefreshBarang.Location = New Point(432, 13)
        Me.btnRefreshBarang.Size = New Size(100, 36)

        Me.pnlCariBarang.Controls.Add(Me.txtCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnRefreshBarang)

        ' EDITOR DATA BARANG
        Me.pnlEditorBarang.Dock = DockStyle.Top
        Me.pnlEditorBarang.Height = 197
        Me.pnlEditorBarang.BackColor = Color.White

        Me.lblEditor.Text = "TAMBAH BARANG (stok awal 0)"
        Me.lblEditor.Font = New Font(
            "Segoe UI", 12.0!, FontStyle.Bold)
        Me.lblEditor.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblEditor.Location = New Point(16, 10)
        Me.lblEditor.Size = New Size(650, 31)

        Dim lKode As New Label() With {
            .Text = "Kode Barang",
            .Location = New Point(16, 43),
            .AutoSize = True
        }

        Dim lNama As New Label() With {
            .Text = "Nama Barang",
            .Location = New Point(170, 43),
            .AutoSize = True
        }

        Dim lKategori As New Label() With {
            .Text = "Kategori",
            .Location = New Point(407, 43),
            .AutoSize = True
        }

        Dim lSatuan As New Label() With {
            .Text = "Satuan",
            .Location = New Point(601, 43),
            .AutoSize = True
        }

        Dim lBeli As New Label() With {
            .Text = "Harga Beli",
            .Location = New Point(16, 115),
            .AutoSize = True
        }

        Dim lJual As New Label() With {
            .Text = "Harga Jual",
            .Location = New Point(170, 115),
            .AutoSize = True
        }

        Me.txtKodeBarang.Location = New Point(16, 66)
        Me.txtKodeBarang.Size = New Size(140, 31)
        Me.txtKodeBarang.MaxLength = 20

        Me.txtNamaBarang.Location = New Point(170, 66)
        Me.txtNamaBarang.Size = New Size(220, 31)
        Me.txtNamaBarang.MaxLength = 100

        Me.txtKategoriBarang.Location = New Point(407, 66)
        Me.txtKategoriBarang.Size = New Size(176, 31)
        Me.txtKategoriBarang.MaxLength = 50

        Me.txtSatuanBarang.Location = New Point(601, 66)
        Me.txtSatuanBarang.Size = New Size(139, 31)
        Me.txtSatuanBarang.MaxLength = 20

        Me.numHargaBeli.Location = New Point(16, 140)
        Me.numHargaBeli.Size = New Size(140, 31)
        Me.numHargaBeli.Maximum = 9999999999D
        Me.numHargaBeli.DecimalPlaces = 2
        Me.numHargaBeli.ThousandsSeparator = True

        Me.numHargaJual.Location = New Point(170, 140)
        Me.numHargaJual.Size = New Size(140, 31)
        Me.numHargaJual.Maximum = 9999999999D
        Me.numHargaJual.DecimalPlaces = 2
        Me.numHargaJual.ThousandsSeparator = True

        Me.btnSimpanBarang.Text = "Simpan"
        Me.btnSimpanBarang.Location = New Point(323, 136)
        Me.btnSimpanBarang.Size = New Size(92, 40)
        Me.btnSimpanBarang.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnSimpanBarang.ForeColor = Color.White

        Me.btnBatalBarang.Text = "Bersihkan"
        Me.btnBatalBarang.Location = New Point(423, 136)
        Me.btnBatalBarang.Size = New Size(100, 40)

        Me.btnEditBarang.Text = "Edit Pilihan"
        Me.btnEditBarang.Location = New Point(531, 136)
        Me.btnEditBarang.Size = New Size(111, 40)

        Me.btnNonaktifBarang.Text = "Nonaktifkan"
        Me.btnNonaktifBarang.Location = New Point(650, 136)
        Me.btnNonaktifBarang.Size = New Size(121, 40)

        Me.btnHapusBarang.Text = "Hapus"
        Me.btnHapusBarang.Location = New Point(779, 136)
        Me.btnHapusBarang.Size = New Size(94, 40)
        Me.btnHapusBarang.BackColor = Color.FromArgb(185, 55, 55)
        Me.btnHapusBarang.ForeColor = Color.White

        Me.pnlEditorBarang.Controls.Add(Me.lblEditor)
        Me.pnlEditorBarang.Controls.Add(lKode)
        Me.pnlEditorBarang.Controls.Add(Me.txtKodeBarang)
        Me.pnlEditorBarang.Controls.Add(lNama)
        Me.pnlEditorBarang.Controls.Add(Me.txtNamaBarang)
        Me.pnlEditorBarang.Controls.Add(lKategori)
        Me.pnlEditorBarang.Controls.Add(Me.txtKategoriBarang)
        Me.pnlEditorBarang.Controls.Add(lSatuan)
        Me.pnlEditorBarang.Controls.Add(Me.txtSatuanBarang)
        Me.pnlEditorBarang.Controls.Add(lBeli)
        Me.pnlEditorBarang.Controls.Add(Me.numHargaBeli)
        Me.pnlEditorBarang.Controls.Add(lJual)
        Me.pnlEditorBarang.Controls.Add(Me.numHargaJual)
        Me.pnlEditorBarang.Controls.Add(Me.btnSimpanBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnBatalBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnEditBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnNonaktifBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnHapusBarang)

        ' TABEL DATA BARANG
        Me.dgvBarang.Dock = DockStyle.Fill
        Me.dgvBarang.BackgroundColor = Color.White
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        ' INI PENTING: SEMUA KONTROL MASUK KE
        ' PANEL DATA BARANG, BUKAN PANEL LAIN.
        Me.pnlDataBarang.Controls.Add(Me.dgvBarang)
        Me.pnlDataBarang.Controls.Add(Me.pnlEditorBarang)
        Me.pnlDataBarang.Controls.Add(Me.pnlCariBarang)

        ' ===============================
        ' PANEL 3: BARANG MASUK
        ' ===============================
        Me.pnlBarangMasuk.Dock = DockStyle.Fill
        Me.pnlBarangMasuk.BackColor = Color.FromArgb(245, 248, 244)
        Me.pnlBarangMasuk.Visible = True

        Me.pnlMasukInput.Dock = DockStyle.Top
        Me.pnlMasukInput.Height = 200
        Me.pnlMasukInput.BackColor = Color.White

        Dim lmKode As New Label() With {
            .Text = "Kode Barang",
            .Location = New Point(16, 12),
            .AutoSize = True
        }

        Dim lmNama As New Label() With {
            .Text = "Nama Barang",
            .Location = New Point(170, 12),
            .AutoSize = True
        }

        Dim lmKategori As New Label() With {
            .Text = "Kategori",
            .Location = New Point(407, 12),
            .AutoSize = True
        }

        Dim lmSatuan As New Label() With {
            .Text = "Satuan",
            .Location = New Point(601, 12),
            .AutoSize = True
        }

        Me.txtKodeMasuk.Location = New Point(16, 39)
        Me.txtKodeMasuk.Size = New Size(140, 31)
        Me.txtKodeMasuk.MaxLength = 20

        Me.txtNamaMasuk.Location = New Point(170, 39)
        Me.txtNamaMasuk.Size = New Size(220, 31)
        Me.txtNamaMasuk.MaxLength = 100

        Me.txtKategoriMasuk.Location = New Point(407, 39)
        Me.txtKategoriMasuk.Size = New Size(176, 31)
        Me.txtKategoriMasuk.MaxLength = 50

        Me.txtSatuanMasuk.Location = New Point(601, 39)
        Me.txtSatuanMasuk.Size = New Size(139, 31)
        Me.txtSatuanMasuk.MaxLength = 20

        Dim lmJumlah As New Label() With {
            .Text = "Jumlah Masuk",
            .Location = New Point(16, 97),
            .AutoSize = True
        }

        Dim lmBeli As New Label() With {
            .Text = "Harga Beli",
            .Location = New Point(170, 97),
            .AutoSize = True
        }

        Dim lmJual As New Label() With {
            .Text = "Harga Jual",
            .Location = New Point(350, 97),
            .AutoSize = True
        }

        Me.numJumlahMasuk.Location = New Point(16, 124)
        Me.numJumlahMasuk.Size = New Size(140, 31)
        Me.numJumlahMasuk.Minimum = 1D
        Me.numJumlahMasuk.Maximum = 1000000D
        Me.numJumlahMasuk.Value = 1D

        Me.numHargaMasuk.Location = New Point(170, 124)
        Me.numHargaMasuk.Size = New Size(165, 31)
        Me.numHargaMasuk.Maximum = 9999999999D
        Me.numHargaMasuk.DecimalPlaces = 2
        Me.numHargaMasuk.ThousandsSeparator = True

        Me.numHargaJualMasuk.Location = New Point(350, 124)
        Me.numHargaJualMasuk.Size = New Size(165, 31)
        Me.numHargaJualMasuk.Maximum = 9999999999D
        Me.numHargaJualMasuk.DecimalPlaces = 2
        Me.numHargaJualMasuk.ThousandsSeparator = True

        Me.btnTambahMasuk.Text = "+ Tambah ke Daftar"
        Me.btnTambahMasuk.Location = New Point(539, 120)
        Me.btnTambahMasuk.Size = New Size(182, 40)
        Me.btnTambahMasuk.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnTambahMasuk.ForeColor = Color.White

        Dim lmInfo As New Label() With {
            .Text = "Kode lama: data otomatis terisi. Kode baru: isi semua kolom.",
            .Location = New Point(16, 171),
            .Size = New Size(740, 25),
            .ForeColor = Color.DimGray
        }

        Me.pnlMasukInput.Controls.Add(lmKode)
        Me.pnlMasukInput.Controls.Add(Me.txtKodeMasuk)
        Me.pnlMasukInput.Controls.Add(lmNama)
        Me.pnlMasukInput.Controls.Add(Me.txtNamaMasuk)
        Me.pnlMasukInput.Controls.Add(lmKategori)
        Me.pnlMasukInput.Controls.Add(Me.txtKategoriMasuk)
        Me.pnlMasukInput.Controls.Add(lmSatuan)
        Me.pnlMasukInput.Controls.Add(Me.txtSatuanMasuk)
        Me.pnlMasukInput.Controls.Add(lmJumlah)
        Me.pnlMasukInput.Controls.Add(Me.numJumlahMasuk)
        Me.pnlMasukInput.Controls.Add(lmBeli)
        Me.pnlMasukInput.Controls.Add(Me.numHargaMasuk)
        Me.pnlMasukInput.Controls.Add(lmJual)
        Me.pnlMasukInput.Controls.Add(Me.numHargaJualMasuk)
        Me.pnlMasukInput.Controls.Add(Me.btnTambahMasuk)
        Me.pnlMasukInput.Controls.Add(lmInfo)

        ' TOMBOL BAWAH BARANG MASUK
        Me.pnlMasukBawah.Dock = DockStyle.Bottom
        Me.pnlMasukBawah.Height = 87
        Me.pnlMasukBawah.BackColor = Color.White

        Me.lblRingkasanMasuk.Text = "0 jenis barang - 0 unit"
        Me.lblRingkasanMasuk.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblRingkasanMasuk.Location = New Point(16, 8)
        Me.lblRingkasanMasuk.Size = New Size(430, 27)

        Me.btnHapusMasuk.Text = "Hapus Item"
        Me.btnHapusMasuk.Location = New Point(16, 40)
        Me.btnHapusMasuk.Size = New Size(124, 38)

        Me.btnBersihkanMasuk.Text = "Bersihkan"
        Me.btnBersihkanMasuk.Location = New Point(150, 40)
        Me.btnBersihkanMasuk.Size = New Size(124, 38)

        Me.btnSimpanMasuk.Text = "Simpan Barang Masuk"
        Me.btnSimpanMasuk.Location = New Point(695, 37)
        Me.btnSimpanMasuk.Size = New Size(190, 42)
        Me.btnSimpanMasuk.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnSimpanMasuk.ForeColor = Color.White

        Me.pnlMasukBawah.Controls.Add(Me.lblRingkasanMasuk)
        Me.pnlMasukBawah.Controls.Add(Me.btnHapusMasuk)
        Me.pnlMasukBawah.Controls.Add(Me.btnBersihkanMasuk)
        Me.pnlMasukBawah.Controls.Add(Me.btnSimpanMasuk)

        Me.dgvDetailMasuk.Dock = DockStyle.Fill
        Me.dgvDetailMasuk.BackgroundColor = Color.White
        Me.dgvDetailMasuk.ReadOnly = True
        Me.dgvDetailMasuk.AllowUserToAddRows = False
        Me.dgvDetailMasuk.AllowUserToDeleteRows = False
        Me.dgvDetailMasuk.RowHeadersVisible = False
        Me.dgvDetailMasuk.MultiSelect = False
        Me.dgvDetailMasuk.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailMasuk.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.Fill

        Me.pnlBarangMasuk.Controls.Add(Me.dgvDetailMasuk)
        Me.pnlBarangMasuk.Controls.Add(Me.pnlMasukBawah)
        Me.pnlBarangMasuk.Controls.Add(Me.pnlMasukInput)

        ' ===============================
        ' SUSUN SEMUA PANEL
        ' ===============================
        ' Data Barang sengaja di depan saat Designer dibuka.
        ' Ketika program berjalan, backend menampilkan Dashboard.
        Me.pnlKonten.Controls.Add(Me.pnlBarangMasuk)
        Me.pnlKonten.Controls.Add(Me.pnlDashboard)
        Me.pnlKonten.Controls.Add(Me.pnlDataBarang)

        Me.pnlMain.Controls.Add(Me.pnlKonten)
        Me.pnlMain.Controls.Add(Me.pnlHeader)

        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)

        Me.ResumeLayout(False)

    End Sub

End Class
