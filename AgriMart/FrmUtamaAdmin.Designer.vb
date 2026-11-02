
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaAdmin
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' FORM DAN NAVIGASI
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblIdentitas As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnDataBarang As Button
    Friend WithEvents btnBarangMasuk As Button
    Friend WithEvents btnLogout As Button

    ' DASHBOARD
    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents pnlRingkasanBarang As Panel
    Friend WithEvents pnlRingkasanStok As Panel
    Friend WithEvents pnlRingkasanMenipis As Panel
    Friend WithEvents lblJudulTotalBarang As Label
    Friend WithEvents lblJudulTotalStok As Label
    Friend WithEvents lblJudulStokMenipis As Label
    Friend WithEvents lblTotalBarang As Label
    Friend WithEvents lblTotalStok As Label
    Friend WithEvents lblStokMenipis As Label
    Friend WithEvents pnlRiwayat As Panel
    Friend WithEvents lblRiwayat As Label
    Friend WithEvents btnRefreshDashboard As Button
    Friend WithEvents dgvRiwayatMasuk As DataGridView

    ' DATA BARANG
    Friend WithEvents pnlDataBarang As Panel
    Friend WithEvents pnlCariBarang As Panel
    Friend WithEvents lblCariBarang As Label
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents btnCariBarang As Button
    Friend WithEvents btnRefreshBarang As Button
    Friend WithEvents pnlEditorBarang As Panel
    Friend WithEvents lblEditor As Label
    Friend WithEvents lblKodeBarang As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents lblNamaBarang As Label
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents lblKategoriBarang As Label
    Friend WithEvents txtKategoriBarang As TextBox
    Friend WithEvents lblSatuanBarang As Label
    Friend WithEvents txtSatuanBarang As TextBox
    Friend WithEvents lblHargaBeli As Label
    Friend WithEvents numHargaBeli As NumericUpDown
    Friend WithEvents lblHargaJual As Label
    Friend WithEvents numHargaJual As NumericUpDown
    Friend WithEvents btnSimpanBarang As Button
    Friend WithEvents btnBatalBarang As Button
    Friend WithEvents btnEditBarang As Button
    Friend WithEvents btnNonaktifBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents pnlTabelBarang As Panel
    Friend WithEvents dgvBarang As DataGridView

    ' BARANG MASUK
    Friend WithEvents pnlBarangMasuk As Panel
    Friend WithEvents pnlInputMasuk As Panel
    Friend WithEvents lblJudulMasuk As Label
    Friend WithEvents lblPetunjukMasuk As Label
    Friend WithEvents lblKodeMasuk As Label
    Friend WithEvents txtKodeMasuk As TextBox
    Friend WithEvents lblNamaMasuk As Label
    Friend WithEvents txtNamaMasuk As TextBox
    Friend WithEvents lblKategoriMasuk As Label
    Friend WithEvents txtKategoriMasuk As TextBox
    Friend WithEvents lblSatuanMasuk As Label
    Friend WithEvents txtSatuanMasuk As TextBox
    Friend WithEvents lblJumlahMasuk As Label
    Friend WithEvents numJumlahMasuk As NumericUpDown
    Friend WithEvents lblHargaMasuk As Label
    Friend WithEvents numHargaMasuk As NumericUpDown
    Friend WithEvents lblHargaJualMasuk As Label
    Friend WithEvents numHargaJualMasuk As NumericUpDown
    Friend WithEvents btnTambahMasuk As Button
    Friend WithEvents pnlDaftarMasuk As Panel
    Friend WithEvents lblDaftarMasuk As Label
    Friend WithEvents dgvDetailMasuk As DataGridView
    Friend WithEvents pnlAksiMasuk As Panel
    Friend WithEvents lblRingkasanMasuk As Label
    Friend WithEvents btnHapusMasuk As Button
    Friend WithEvents btnBersihkanMasuk As Button
    Friend WithEvents btnSimpanMasuk As Button

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
        Me.lblTanggal = New Label()
        Me.btnDashboard = New Button()
        Me.btnDataBarang = New Button()
        Me.btnBarangMasuk = New Button()
        Me.btnLogout = New Button()

        Me.pnlDashboard = New Panel()
        Me.pnlKartu = New Panel()
        Me.pnlRingkasanBarang = New Panel()
        Me.pnlRingkasanStok = New Panel()
        Me.pnlRingkasanMenipis = New Panel()
        Me.lblJudulTotalBarang = New Label()
        Me.lblJudulTotalStok = New Label()
        Me.lblJudulStokMenipis = New Label()
        Me.lblTotalBarang = New Label()
        Me.lblTotalStok = New Label()
        Me.lblStokMenipis = New Label()
        Me.pnlRiwayat = New Panel()
        Me.lblRiwayat = New Label()
        Me.btnRefreshDashboard = New Button()
        Me.dgvRiwayatMasuk = New DataGridView()

        Me.pnlDataBarang = New Panel()
        Me.pnlCariBarang = New Panel()
        Me.lblCariBarang = New Label()
        Me.txtCariBarang = New TextBox()
        Me.btnCariBarang = New Button()
        Me.btnRefreshBarang = New Button()
        Me.pnlEditorBarang = New Panel()
        Me.lblEditor = New Label()
        Me.lblKodeBarang = New Label()
        Me.txtKodeBarang = New TextBox()
        Me.lblNamaBarang = New Label()
        Me.txtNamaBarang = New TextBox()
        Me.lblKategoriBarang = New Label()
        Me.txtKategoriBarang = New TextBox()
        Me.lblSatuanBarang = New Label()
        Me.txtSatuanBarang = New TextBox()
        Me.lblHargaBeli = New Label()
        Me.numHargaBeli = New NumericUpDown()
        Me.lblHargaJual = New Label()
        Me.numHargaJual = New NumericUpDown()
        Me.btnSimpanBarang = New Button()
        Me.btnBatalBarang = New Button()
        Me.btnEditBarang = New Button()
        Me.btnNonaktifBarang = New Button()
        Me.btnHapusBarang = New Button()
        Me.pnlTabelBarang = New Panel()
        Me.dgvBarang = New DataGridView()

        Me.pnlBarangMasuk = New Panel()
        Me.pnlInputMasuk = New Panel()
        Me.lblJudulMasuk = New Label()
        Me.lblPetunjukMasuk = New Label()
        Me.lblKodeMasuk = New Label()
        Me.txtKodeMasuk = New TextBox()
        Me.lblNamaMasuk = New Label()
        Me.txtNamaMasuk = New TextBox()
        Me.lblKategoriMasuk = New Label()
        Me.txtKategoriMasuk = New TextBox()
        Me.lblSatuanMasuk = New Label()
        Me.txtSatuanMasuk = New TextBox()
        Me.lblJumlahMasuk = New Label()
        Me.numJumlahMasuk = New NumericUpDown()
        Me.lblHargaMasuk = New Label()
        Me.numHargaMasuk = New NumericUpDown()
        Me.lblHargaJualMasuk = New Label()
        Me.numHargaJualMasuk = New NumericUpDown()
        Me.btnTambahMasuk = New Button()
        Me.pnlDaftarMasuk = New Panel()
        Me.lblDaftarMasuk = New Label()
        Me.dgvDetailMasuk = New DataGridView()
        Me.pnlAksiMasuk = New Panel()
        Me.lblRingkasanMasuk = New Label()
        Me.btnHapusMasuk = New Button()
        Me.btnBersihkanMasuk = New Button()
        Me.btnSimpanMasuk = New Button()

        CType(Me.dgvRiwayatMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDetailMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaBeli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numJumlahMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numHargaJualMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' ======================================
        ' FORM DAN SIDEBAR
        ' ======================================
        Me.Name = "FrmUtamaAdmin"
        Me.Text = "AGRIMARTT | Dashboard Admin"
        Me.ClientSize = New Size(1250, 760)
        Me.MinimumSize = New Size(1120, 700)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Font = New Font("Segoe UI", 10.0!)
        Me.BackColor = Color.FromArgb(245, 248, 244)
        Me.AutoScaleMode = AutoScaleMode.Font

        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Dock = DockStyle.Left
        Me.pnlSidebar.Width = 220
        Me.pnlSidebar.BackColor = Color.FromArgb(23, 82, 44)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Text = "AGRIMARTT"
        Me.lblBrand.Font = New Font("Segoe UI", 20.0!, FontStyle.Bold)
        Me.lblBrand.ForeColor = Color.White
        Me.lblBrand.Location = New Point(18, 38)
        Me.lblBrand.Size = New Size(190, 48)

        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.Location = New Point(8, 170)
        Me.btnDashboard.Size = New Size(204, 48)
        Me.btnDashboard.FlatStyle = FlatStyle.Flat
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.ForeColor = Color.White
        Me.btnDashboard.BackColor = Color.FromArgb(55, 119, 80)
        Me.btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False

        Me.btnDataBarang.Name = "btnDataBarang"
        Me.btnDataBarang.Text = "   Data Barang"
        Me.btnDataBarang.Location = New Point(8, 228)
        Me.btnDataBarang.Size = New Size(204, 48)
        Me.btnDataBarang.FlatStyle = FlatStyle.Flat
        Me.btnDataBarang.FlatAppearance.BorderSize = 0
        Me.btnDataBarang.ForeColor = Color.White
        Me.btnDataBarang.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnDataBarang.TextAlign = ContentAlignment.MiddleLeft
        Me.btnDataBarang.UseVisualStyleBackColor = False

        Me.btnBarangMasuk.Name = "btnBarangMasuk"
        Me.btnBarangMasuk.Text = "   Barang Masuk"
        Me.btnBarangMasuk.Location = New Point(8, 286)
        Me.btnBarangMasuk.Size = New Size(204, 48)
        Me.btnBarangMasuk.FlatStyle = FlatStyle.Flat
        Me.btnBarangMasuk.FlatAppearance.BorderSize = 0
        Me.btnBarangMasuk.ForeColor = Color.White
        Me.btnBarangMasuk.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnBarangMasuk.TextAlign = ContentAlignment.MiddleLeft
        Me.btnBarangMasuk.UseVisualStyleBackColor = False

        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.Dock = DockStyle.Bottom
        Me.btnLogout.Height = 48
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.BackColor = Color.FromArgb(47, 102, 69)
        Me.btnLogout.TextAlign = ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False

        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnDataBarang)
        Me.pnlSidebar.Controls.Add(Me.btnBarangMasuk)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)

        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 84
        Me.pnlHeader.BackColor = Color.White
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Text = "Dashboard Admin"
        Me.lblJudul.Font = New Font("Segoe UI", 22.0!, FontStyle.Bold)
        Me.lblJudul.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblJudul.Location = New Point(25, 15)
        Me.lblJudul.Size = New Size(500, 50)
        Me.lblIdentitas.Name = "lblIdentitas"
        Me.lblIdentitas.Text = "Halo, Admin!"
        Me.lblIdentitas.Dock = DockStyle.Right
        Me.lblIdentitas.Width = 215
        Me.lblIdentitas.TextAlign = ContentAlignment.MiddleRight
        Me.lblIdentitas.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblIdentitas.Padding = New Padding(0, 0, 12, 0)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Text = ""
        Me.lblTanggal.Location = New Point(540, 57)
        Me.lblTanggal.Size = New Size(230, 21)
        Me.lblTanggal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.lblTanggal.ForeColor = Color.DimGray
        Me.lblTanggal.TextAlign = ContentAlignment.MiddleRight
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblTanggal)
        Me.pnlHeader.Controls.Add(Me.lblIdentitas)

        Me.pnlKonten.Name = "pnlKonten"
        Me.pnlKonten.Dock = DockStyle.Fill
        Me.pnlKonten.Padding = New Padding(18)
        Me.pnlKonten.BackColor = Color.FromArgb(245, 248, 244)

        ' ======================================
        ' DASHBOARD - KARTU DAN RIWAYAT
        ' ======================================
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Dock = DockStyle.Fill
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Dock = DockStyle.Top
        Me.pnlKartu.Height = 140
        Me.pnlKartu.BackColor = Color.FromArgb(245, 248, 244)

        Me.pnlRingkasanBarang.Name = "pnlRingkasanBarang"
        Me.pnlRingkasanBarang.Location = New Point(0, 6)
        Me.pnlRingkasanBarang.Size = New Size(265, 118)
        Me.pnlRingkasanBarang.BackColor = Color.White
        Me.lblJudulTotalBarang.Name = "lblJudulTotalBarang"
        Me.lblJudulTotalBarang.Text = "Total Barang Aktif"
        Me.lblJudulTotalBarang.Location = New Point(17, 15)
        Me.lblJudulTotalBarang.Size = New Size(220, 27)
        Me.lblTotalBarang.Name = "lblTotalBarang"
        Me.lblTotalBarang.Text = "0"
        Me.lblTotalBarang.Font = New Font("Segoe UI", 25.0!, FontStyle.Bold)
        Me.lblTotalBarang.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblTotalBarang.Location = New Point(17, 47)
        Me.lblTotalBarang.Size = New Size(220, 54)
        Me.pnlRingkasanBarang.Controls.Add(Me.lblJudulTotalBarang)
        Me.pnlRingkasanBarang.Controls.Add(Me.lblTotalBarang)

        Me.pnlRingkasanStok.Name = "pnlRingkasanStok"
        Me.pnlRingkasanStok.Location = New Point(278, 6)
        Me.pnlRingkasanStok.Size = New Size(265, 118)
        Me.pnlRingkasanStok.BackColor = Color.White
        Me.lblJudulTotalStok.Name = "lblJudulTotalStok"
        Me.lblJudulTotalStok.Text = "Total Stok"
        Me.lblJudulTotalStok.Location = New Point(17, 15)
        Me.lblJudulTotalStok.Size = New Size(220, 27)
        Me.lblTotalStok.Name = "lblTotalStok"
        Me.lblTotalStok.Text = "0"
        Me.lblTotalStok.Font = New Font("Segoe UI", 25.0!, FontStyle.Bold)
        Me.lblTotalStok.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblTotalStok.Location = New Point(17, 47)
        Me.lblTotalStok.Size = New Size(220, 54)
        Me.pnlRingkasanStok.Controls.Add(Me.lblJudulTotalStok)
        Me.pnlRingkasanStok.Controls.Add(Me.lblTotalStok)

        Me.pnlRingkasanMenipis.Name = "pnlRingkasanMenipis"
        Me.pnlRingkasanMenipis.Location = New Point(556, 6)
        Me.pnlRingkasanMenipis.Size = New Size(265, 118)
        Me.pnlRingkasanMenipis.BackColor = Color.White
        Me.lblJudulStokMenipis.Name = "lblJudulStokMenipis"
        Me.lblJudulStokMenipis.Text = "Barang Stok Menipis (<= 10)"
        Me.lblJudulStokMenipis.Location = New Point(17, 15)
        Me.lblJudulStokMenipis.Size = New Size(235, 27)
        Me.lblStokMenipis.Name = "lblStokMenipis"
        Me.lblStokMenipis.Text = "0"
        Me.lblStokMenipis.Font = New Font("Segoe UI", 25.0!, FontStyle.Bold)
        Me.lblStokMenipis.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblStokMenipis.Location = New Point(17, 47)
        Me.lblStokMenipis.Size = New Size(220, 54)
        Me.pnlRingkasanMenipis.Controls.Add(Me.lblJudulStokMenipis)
        Me.pnlRingkasanMenipis.Controls.Add(Me.lblStokMenipis)

        Me.pnlKartu.Controls.Add(Me.pnlRingkasanBarang)
        Me.pnlKartu.Controls.Add(Me.pnlRingkasanStok)
        Me.pnlKartu.Controls.Add(Me.pnlRingkasanMenipis)

        Me.pnlRiwayat.Name = "pnlRiwayat"
        Me.pnlRiwayat.Dock = DockStyle.Fill
        Me.pnlRiwayat.BackColor = Color.White
        Me.lblRiwayat.Name = "lblRiwayat"
        Me.lblRiwayat.Text = "Riwayat Barang Masuk Terbaru"
        Me.lblRiwayat.Location = New Point(18, 13)
        Me.lblRiwayat.Size = New Size(390, 31)
        Me.lblRiwayat.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblRiwayat.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Text = "Refresh"
        Me.btnRefreshDashboard.Location = New Point(770, 12)
        Me.btnRefreshDashboard.Size = New Size(110, 38)
        Me.btnRefreshDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.dgvRiwayatMasuk.Name = "dgvRiwayatMasuk"
        Me.dgvRiwayatMasuk.Location = New Point(12, 57)
        Me.dgvRiwayatMasuk.Size = New Size(868, 420)
        Me.dgvRiwayatMasuk.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.dgvRiwayatMasuk.BackgroundColor = Color.White
        Me.dgvRiwayatMasuk.ReadOnly = True
        Me.dgvRiwayatMasuk.AllowUserToAddRows = False
        Me.dgvRiwayatMasuk.AllowUserToDeleteRows = False
        Me.dgvRiwayatMasuk.RowHeadersVisible = False
        Me.dgvRiwayatMasuk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvRiwayatMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.pnlRiwayat.Controls.Add(Me.lblRiwayat)
        Me.pnlRiwayat.Controls.Add(Me.btnRefreshDashboard)
        Me.pnlRiwayat.Controls.Add(Me.dgvRiwayatMasuk)
        Me.pnlDashboard.Controls.Add(Me.pnlRiwayat)
        Me.pnlDashboard.Controls.Add(Me.pnlKartu)

        ' ======================================
        ' DATA BARANG - PENCARIAN DENGAN LABEL
        ' ======================================
        Me.pnlDataBarang.Name = "pnlDataBarang"
        Me.pnlDataBarang.Dock = DockStyle.Fill
        Me.pnlCariBarang.Name = "pnlCariBarang"
        Me.pnlCariBarang.Dock = DockStyle.Top
        Me.pnlCariBarang.Height = 84
        Me.lblCariBarang.Name = "lblCariBarang"
        Me.lblCariBarang.Text = "Cari Barang (Kode / Nama / Kategori)"
        Me.lblCariBarang.Location = New Point(18, 4)
        Me.lblCariBarang.Size = New Size(400, 26)
        Me.lblCariBarang.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblCariBarang.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Location = New Point(18, 33)
        Me.txtCariBarang.Size = New Size(340, 31)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Text = "Cari"
        Me.btnCariBarang.Location = New Point(372, 30)
        Me.btnCariBarang.Size = New Size(95, 38)
        Me.btnCariBarang.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnCariBarang.ForeColor = Color.White
        Me.btnCariBarang.FlatStyle = FlatStyle.Flat
        Me.btnCariBarang.FlatAppearance.BorderSize = 0
        Me.btnCariBarang.UseVisualStyleBackColor = False
        Me.btnRefreshBarang.Name = "btnRefreshBarang"
        Me.btnRefreshBarang.Text = "Refresh"
        Me.btnRefreshBarang.Location = New Point(482, 30)
        Me.btnRefreshBarang.Size = New Size(110, 38)
        Me.pnlCariBarang.Controls.Add(Me.lblCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.txtCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnRefreshBarang)

        ' EDITOR DATA BARANG
        Me.pnlEditorBarang.Name = "pnlEditorBarang"
        Me.pnlEditorBarang.Dock = DockStyle.Top
        Me.pnlEditorBarang.Height = 246
        Me.pnlEditorBarang.BackColor = Color.White
        Me.lblEditor.Name = "lblEditor"
        Me.lblEditor.Text = "TAMBAH BARANG (stok awal 0)"
        Me.lblEditor.Location = New Point(18, 11)
        Me.lblEditor.Size = New Size(600, 29)
        Me.lblEditor.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblEditor.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)

        Me.lblKodeBarang.Name = "lblKodeBarang"
        Me.lblKodeBarang.Text = "Kode Barang"
        Me.lblKodeBarang.Location = New Point(18, 44)
        Me.lblKodeBarang.Size = New Size(175, 23)
        Me.lblKodeBarang.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtKodeBarang.Name = "txtKodeBarang"
        Me.txtKodeBarang.Location = New Point(18, 68)
        Me.txtKodeBarang.Size = New Size(175, 31)
        Me.txtKodeBarang.MaxLength = 20

        Me.lblNamaBarang.Name = "lblNamaBarang"
        Me.lblNamaBarang.Text = "Nama Barang"
        Me.lblNamaBarang.Location = New Point(211, 44)
        Me.lblNamaBarang.Size = New Size(254, 23)
        Me.lblNamaBarang.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtNamaBarang.Name = "txtNamaBarang"
        Me.txtNamaBarang.Location = New Point(211, 68)
        Me.txtNamaBarang.Size = New Size(254, 31)
        Me.txtNamaBarang.MaxLength = 100

        Me.lblKategoriBarang.Name = "lblKategoriBarang"
        Me.lblKategoriBarang.Text = "Kategori"
        Me.lblKategoriBarang.Location = New Point(482, 44)
        Me.lblKategoriBarang.Size = New Size(183, 23)
        Me.lblKategoriBarang.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtKategoriBarang.Name = "txtKategoriBarang"
        Me.txtKategoriBarang.Location = New Point(482, 68)
        Me.txtKategoriBarang.Size = New Size(183, 31)
        Me.txtKategoriBarang.MaxLength = 50

        Me.lblSatuanBarang.Name = "lblSatuanBarang"
        Me.lblSatuanBarang.Text = "Satuan"
        Me.lblSatuanBarang.Location = New Point(682, 44)
        Me.lblSatuanBarang.Size = New Size(155, 23)
        Me.lblSatuanBarang.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtSatuanBarang.Name = "txtSatuanBarang"
        Me.txtSatuanBarang.Location = New Point(682, 68)
        Me.txtSatuanBarang.Size = New Size(155, 31)
        Me.txtSatuanBarang.MaxLength = 20

        Me.lblHargaBeli.Name = "lblHargaBeli"
        Me.lblHargaBeli.Text = "Harga Beli (Rp)"
        Me.lblHargaBeli.Location = New Point(18, 113)
        Me.lblHargaBeli.Size = New Size(175, 23)
        Me.lblHargaBeli.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.numHargaBeli.Name = "numHargaBeli"
        Me.numHargaBeli.Location = New Point(18, 139)
        Me.numHargaBeli.Size = New Size(175, 31)
        Me.numHargaBeli.Maximum = 999999999999D
        Me.numHargaBeli.DecimalPlaces = 2
        Me.numHargaBeli.ThousandsSeparator = True

        Me.lblHargaJual.Name = "lblHargaJual"
        Me.lblHargaJual.Text = "Harga Jual (Rp)"
        Me.lblHargaJual.Location = New Point(211, 113)
        Me.lblHargaJual.Size = New Size(175, 23)
        Me.lblHargaJual.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.numHargaJual.Name = "numHargaJual"
        Me.numHargaJual.Location = New Point(211, 139)
        Me.numHargaJual.Size = New Size(175, 31)
        Me.numHargaJual.Maximum = 999999999999D
        Me.numHargaJual.DecimalPlaces = 2
        Me.numHargaJual.ThousandsSeparator = True

        Me.btnSimpanBarang.Name = "btnSimpanBarang"
        Me.btnSimpanBarang.Text = "Simpan"
        Me.btnSimpanBarang.Location = New Point(18, 189)
        Me.btnSimpanBarang.Size = New Size(110, 38)
        Me.btnSimpanBarang.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnSimpanBarang.ForeColor = Color.White
        Me.btnSimpanBarang.FlatStyle = FlatStyle.Flat
        Me.btnSimpanBarang.FlatAppearance.BorderSize = 0
        Me.btnSimpanBarang.UseVisualStyleBackColor = False
        Me.btnBatalBarang.Name = "btnBatalBarang"
        Me.btnBatalBarang.Text = "Bersihkan"
        Me.btnBatalBarang.Location = New Point(138, 189)
        Me.btnBatalBarang.Size = New Size(115, 38)
        Me.btnEditBarang.Name = "btnEditBarang"
        Me.btnEditBarang.Text = "Edit Pilihan"
        Me.btnEditBarang.Location = New Point(263, 189)
        Me.btnEditBarang.Size = New Size(123, 38)
        Me.btnNonaktifBarang.Name = "btnNonaktifBarang"
        Me.btnNonaktifBarang.Text = "Nonaktifkan"
        Me.btnNonaktifBarang.Location = New Point(396, 189)
        Me.btnNonaktifBarang.Size = New Size(131, 38)
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.btnHapusBarang.Text = "Hapus"
        Me.btnHapusBarang.Location = New Point(537, 189)
        Me.btnHapusBarang.Size = New Size(105, 38)
        Me.btnHapusBarang.BackColor = Color.FromArgb(180, 50, 50)
        Me.btnHapusBarang.ForeColor = Color.White
        Me.btnHapusBarang.FlatStyle = FlatStyle.Flat
        Me.btnHapusBarang.FlatAppearance.BorderSize = 0
        Me.btnHapusBarang.UseVisualStyleBackColor = False

        Me.pnlEditorBarang.Controls.Add(Me.lblEditor)
        Me.pnlEditorBarang.Controls.Add(Me.lblKodeBarang)
        Me.pnlEditorBarang.Controls.Add(Me.txtKodeBarang)
        Me.pnlEditorBarang.Controls.Add(Me.lblNamaBarang)
        Me.pnlEditorBarang.Controls.Add(Me.txtNamaBarang)
        Me.pnlEditorBarang.Controls.Add(Me.lblKategoriBarang)
        Me.pnlEditorBarang.Controls.Add(Me.txtKategoriBarang)
        Me.pnlEditorBarang.Controls.Add(Me.lblSatuanBarang)
        Me.pnlEditorBarang.Controls.Add(Me.txtSatuanBarang)
        Me.pnlEditorBarang.Controls.Add(Me.lblHargaBeli)
        Me.pnlEditorBarang.Controls.Add(Me.numHargaBeli)
        Me.pnlEditorBarang.Controls.Add(Me.lblHargaJual)
        Me.pnlEditorBarang.Controls.Add(Me.numHargaJual)
        Me.pnlEditorBarang.Controls.Add(Me.btnSimpanBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnBatalBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnEditBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnNonaktifBarang)
        Me.pnlEditorBarang.Controls.Add(Me.btnHapusBarang)

        Me.pnlTabelBarang.Name = "pnlTabelBarang"
        Me.pnlTabelBarang.Dock = DockStyle.Fill
        Me.pnlTabelBarang.Padding = New Padding(0, 9, 0, 0)
        Me.dgvBarang.Name = "dgvBarang"
        Me.dgvBarang.Dock = DockStyle.Fill
        Me.dgvBarang.BackgroundColor = Color.White
        Me.dgvBarang.ReadOnly = True
        Me.dgvBarang.AllowUserToAddRows = False
        Me.dgvBarang.AllowUserToDeleteRows = False
        Me.dgvBarang.RowHeadersVisible = False
        Me.dgvBarang.MultiSelect = False
        Me.dgvBarang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.pnlTabelBarang.Controls.Add(Me.dgvBarang)
        Me.pnlDataBarang.Controls.Add(Me.pnlTabelBarang)
        Me.pnlDataBarang.Controls.Add(Me.pnlEditorBarang)
        Me.pnlDataBarang.Controls.Add(Me.pnlCariBarang)

        ' ======================================
        ' BARANG MASUK - SETIAP INPUT ADA LABEL
        ' ======================================
        Me.pnlBarangMasuk.Name = "pnlBarangMasuk"
        Me.pnlBarangMasuk.Dock = DockStyle.Fill
        Me.pnlInputMasuk.Name = "pnlInputMasuk"
        Me.pnlInputMasuk.Dock = DockStyle.Top
        Me.pnlInputMasuk.Height = 242
        Me.pnlInputMasuk.BackColor = Color.White
        Me.lblJudulMasuk.Name = "lblJudulMasuk"
        Me.lblJudulMasuk.Text = "TAMBAH BARANG MASUK"
        Me.lblJudulMasuk.Location = New Point(18, 10)
        Me.lblJudulMasuk.Size = New Size(380, 28)
        Me.lblJudulMasuk.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.lblJudulMasuk.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblPetunjukMasuk.Name = "lblPetunjukMasuk"
        Me.lblPetunjukMasuk.Text = "Kode lama: tambah stok. Kode baru: daftarkan barang baru."
        Me.lblPetunjukMasuk.Location = New Point(18, 36)
        Me.lblPetunjukMasuk.Size = New Size(720, 22)
        Me.lblPetunjukMasuk.ForeColor = Color.DimGray
        Me.lblPetunjukMasuk.Font = New Font("Segoe UI", 9.0!)

        Me.lblKodeMasuk.Name = "lblKodeMasuk"
        Me.lblKodeMasuk.Text = "Kode Barang"
        Me.lblKodeMasuk.Location = New Point(18, 63)
        Me.lblKodeMasuk.Size = New Size(175, 23)
        Me.lblKodeMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtKodeMasuk.Name = "txtKodeMasuk"
        Me.txtKodeMasuk.Location = New Point(18, 87)
        Me.txtKodeMasuk.Size = New Size(175, 31)
        Me.txtKodeMasuk.MaxLength = 20

        Me.lblNamaMasuk.Name = "lblNamaMasuk"
        Me.lblNamaMasuk.Text = "Nama Barang"
        Me.lblNamaMasuk.Location = New Point(211, 63)
        Me.lblNamaMasuk.Size = New Size(250, 23)
        Me.lblNamaMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtNamaMasuk.Name = "txtNamaMasuk"
        Me.txtNamaMasuk.Location = New Point(211, 87)
        Me.txtNamaMasuk.Size = New Size(250, 31)
        Me.txtNamaMasuk.MaxLength = 100

        Me.lblKategoriMasuk.Name = "lblKategoriMasuk"
        Me.lblKategoriMasuk.Text = "Kategori"
        Me.lblKategoriMasuk.Location = New Point(479, 63)
        Me.lblKategoriMasuk.Size = New Size(174, 23)
        Me.lblKategoriMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtKategoriMasuk.Name = "txtKategoriMasuk"
        Me.txtKategoriMasuk.Location = New Point(479, 87)
        Me.txtKategoriMasuk.Size = New Size(174, 31)
        Me.txtKategoriMasuk.MaxLength = 50

        Me.lblSatuanMasuk.Name = "lblSatuanMasuk"
        Me.lblSatuanMasuk.Text = "Satuan"
        Me.lblSatuanMasuk.Location = New Point(671, 63)
        Me.lblSatuanMasuk.Size = New Size(160, 23)
        Me.lblSatuanMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.txtSatuanMasuk.Name = "txtSatuanMasuk"
        Me.txtSatuanMasuk.Location = New Point(671, 87)
        Me.txtSatuanMasuk.Size = New Size(160, 31)
        Me.txtSatuanMasuk.MaxLength = 20

        Me.lblJumlahMasuk.Name = "lblJumlahMasuk"
        Me.lblJumlahMasuk.Text = "Jumlah Barang Masuk"
        Me.lblJumlahMasuk.Location = New Point(18, 132)
        Me.lblJumlahMasuk.Size = New Size(175, 23)
        Me.lblJumlahMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.numJumlahMasuk.Name = "numJumlahMasuk"
        Me.numJumlahMasuk.Location = New Point(18, 158)
        Me.numJumlahMasuk.Size = New Size(175, 31)
        Me.numJumlahMasuk.Minimum = 1D
        Me.numJumlahMasuk.Maximum = 1000000D
        Me.numJumlahMasuk.Value = 1D

        Me.lblHargaMasuk.Name = "lblHargaMasuk"
        Me.lblHargaMasuk.Text = "Harga Beli / Unit (Rp)"
        Me.lblHargaMasuk.Location = New Point(211, 132)
        Me.lblHargaMasuk.Size = New Size(185, 23)
        Me.lblHargaMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.numHargaMasuk.Name = "numHargaMasuk"
        Me.numHargaMasuk.Location = New Point(211, 158)
        Me.numHargaMasuk.Size = New Size(185, 31)
        Me.numHargaMasuk.Maximum = 999999999999D
        Me.numHargaMasuk.DecimalPlaces = 2
        Me.numHargaMasuk.ThousandsSeparator = True

        Me.lblHargaJualMasuk.Name = "lblHargaJualMasuk"
        Me.lblHargaJualMasuk.Text = "Harga Jual / Unit (Rp)"
        Me.lblHargaJualMasuk.Location = New Point(414, 132)
        Me.lblHargaJualMasuk.Size = New Size(185, 23)
        Me.lblHargaJualMasuk.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.numHargaJualMasuk.Name = "numHargaJualMasuk"
        Me.numHargaJualMasuk.Location = New Point(414, 158)
        Me.numHargaJualMasuk.Size = New Size(185, 31)
        Me.numHargaJualMasuk.Maximum = 999999999999D
        Me.numHargaJualMasuk.DecimalPlaces = 2
        Me.numHargaJualMasuk.ThousandsSeparator = True

        Me.btnTambahMasuk.Name = "btnTambahMasuk"
        Me.btnTambahMasuk.Text = "+ Tambah ke Daftar"
        Me.btnTambahMasuk.Location = New Point(617, 155)
        Me.btnTambahMasuk.Size = New Size(192, 39)
        Me.btnTambahMasuk.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnTambahMasuk.ForeColor = Color.White
        Me.btnTambahMasuk.FlatStyle = FlatStyle.Flat
        Me.btnTambahMasuk.FlatAppearance.BorderSize = 0
        Me.btnTambahMasuk.UseVisualStyleBackColor = False

        Me.pnlInputMasuk.Controls.Add(Me.lblJudulMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblPetunjukMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblKodeMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.txtKodeMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblNamaMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.txtNamaMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblKategoriMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.txtKategoriMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblSatuanMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.txtSatuanMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblJumlahMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.numJumlahMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblHargaMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.numHargaMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.lblHargaJualMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.numHargaJualMasuk)
        Me.pnlInputMasuk.Controls.Add(Me.btnTambahMasuk)

        Me.pnlDaftarMasuk.Name = "pnlDaftarMasuk"
        Me.pnlDaftarMasuk.Dock = DockStyle.Fill
        Me.pnlDaftarMasuk.Padding = New Padding(0, 5, 0, 0)
        Me.lblDaftarMasuk.Name = "lblDaftarMasuk"
        Me.lblDaftarMasuk.Text = "DAFTAR PENERIMAAN BARANG"
        Me.lblDaftarMasuk.Dock = DockStyle.Top
        Me.lblDaftarMasuk.Height = 34
        Me.lblDaftarMasuk.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblDaftarMasuk.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.dgvDetailMasuk.Name = "dgvDetailMasuk"
        Me.dgvDetailMasuk.Dock = DockStyle.Fill
        Me.dgvDetailMasuk.BackgroundColor = Color.White
        Me.dgvDetailMasuk.ReadOnly = True
        Me.dgvDetailMasuk.AllowUserToAddRows = False
        Me.dgvDetailMasuk.AllowUserToDeleteRows = False
        Me.dgvDetailMasuk.RowHeadersVisible = False
        Me.dgvDetailMasuk.MultiSelect = False
        Me.dgvDetailMasuk.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.dgvDetailMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.pnlDaftarMasuk.Controls.Add(Me.dgvDetailMasuk)
        Me.pnlDaftarMasuk.Controls.Add(Me.lblDaftarMasuk)

        Me.pnlAksiMasuk.Name = "pnlAksiMasuk"
        Me.pnlAksiMasuk.Dock = DockStyle.Bottom
        Me.pnlAksiMasuk.Height = 72
        Me.pnlAksiMasuk.BackColor = Color.White
        Me.lblRingkasanMasuk.Name = "lblRingkasanMasuk"
        Me.lblRingkasanMasuk.Text = "0 barang di daftar"
        Me.lblRingkasanMasuk.Location = New Point(18, 21)
        Me.lblRingkasanMasuk.Size = New Size(310, 30)
        Me.lblRingkasanMasuk.ForeColor = Color.FromArgb(23, 82, 44)
        Me.btnHapusMasuk.Name = "btnHapusMasuk"
        Me.btnHapusMasuk.Text = "Hapus Item"
        Me.btnHapusMasuk.Location = New Point(355, 16)
        Me.btnHapusMasuk.Size = New Size(130, 39)
        Me.btnBersihkanMasuk.Name = "btnBersihkanMasuk"
        Me.btnBersihkanMasuk.Text = "Kosongkan"
        Me.btnBersihkanMasuk.Location = New Point(495, 16)
        Me.btnBersihkanMasuk.Size = New Size(130, 39)
        Me.btnSimpanMasuk.Name = "btnSimpanMasuk"
        Me.btnSimpanMasuk.Text = "Simpan Barang Masuk"
        Me.btnSimpanMasuk.Location = New Point(635, 16)
        Me.btnSimpanMasuk.Size = New Size(205, 39)
        Me.btnSimpanMasuk.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnSimpanMasuk.ForeColor = Color.White
        Me.btnSimpanMasuk.FlatStyle = FlatStyle.Flat
        Me.btnSimpanMasuk.FlatAppearance.BorderSize = 0
        Me.btnSimpanMasuk.UseVisualStyleBackColor = False
        Me.pnlAksiMasuk.Controls.Add(Me.lblRingkasanMasuk)
        Me.pnlAksiMasuk.Controls.Add(Me.btnHapusMasuk)
        Me.pnlAksiMasuk.Controls.Add(Me.btnBersihkanMasuk)
        Me.pnlAksiMasuk.Controls.Add(Me.btnSimpanMasuk)
        Me.pnlBarangMasuk.Controls.Add(Me.pnlDaftarMasuk)
        Me.pnlBarangMasuk.Controls.Add(Me.pnlAksiMasuk)
        Me.pnlBarangMasuk.Controls.Add(Me.pnlInputMasuk)

        ' ======================================
        ' SEMUA PANEL KE SATU FORM
        ' ======================================
        Me.pnlKonten.Controls.Add(Me.pnlBarangMasuk)
        Me.pnlKonten.Controls.Add(Me.pnlDashboard)
        Me.pnlKonten.Controls.Add(Me.pnlDataBarang)
        Me.pnlMain.Controls.Add(Me.pnlKonten)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)

        CType(Me.dgvRiwayatMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDetailMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaBeli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numJumlahMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numHargaJualMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
