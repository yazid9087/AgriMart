
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaOwner
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNamaOwner As Label
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnLaporan As Button
    Friend WithEvents btnLogout As Button

    Friend WithEvents pnlDashboard As Panel
    Friend WithEvents pnlDashAtas As Panel
    Friend WithEvents lblPeriodeDashboard As Label
    Friend WithEvents btnRefreshDashboard As Button
    Friend WithEvents tblStat As TableLayoutPanel
    Friend WithEvents pnlStatOmzet As Panel
    Friend WithEvents pnlStatModal As Panel
    Friend WithEvents pnlStatLaba As Panel
    Friend WithEvents pnlStatNota As Panel
    Friend WithEvents lblOmzet As Label
    Friend WithEvents lblTotalModal As Label
    Friend WithEvents lblLabaKotor As Label
    Friend WithEvents lblJumlahTransaksi As Label
    Friend WithEvents lblKetOmzet As Label
    Friend WithEvents lblKetModal As Label
    Friend WithEvents lblKetLaba As Label
    Friend WithEvents lblKetNota As Label
    Friend WithEvents tblBawah As TableLayoutPanel
    Friend WithEvents pnlHarian As Panel
    Friend WithEvents pnlStok As Panel
    Friend WithEvents lblHarian As Label
    Friend WithEvents lblStok As Label
    Friend WithEvents dgvPenjualanHarian As DataGridView
    Friend WithEvents dgvStokMenipis As DataGridView

    Friend WithEvents pnlLaporan As Panel
    Friend WithEvents pnlFilter As Panel
    Friend WithEvents lblAwal As Label
    Friend WithEvents lblAkhir As Label
    Friend WithEvents dtpTanggalAwal As DateTimePicker
    Friend WithEvents dtpTanggalAkhir As DateTimePicker
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnBulanIni As Button
    Friend WithEvents lblInfoLaporan As Label
    Friend WithEvents tabLaporan As TabControl
    Friend WithEvents tabPenjualan As TabPage
    Friend WithEvents tabLaba As TabPage
    Friend WithEvents dgvPenjualan As DataGridView
    Friend WithEvents dgvLaba As DataGridView

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
        Me.lblNamaOwner = New Label()
        Me.btnDashboard = New Button()
        Me.btnLaporan = New Button()
        Me.btnLogout = New Button()

        Me.pnlDashboard = New Panel()
        Me.pnlDashAtas = New Panel()
        Me.lblPeriodeDashboard = New Label()
        Me.btnRefreshDashboard = New Button()
        Me.tblStat = New TableLayoutPanel()
        Me.pnlStatOmzet = New Panel()
        Me.pnlStatModal = New Panel()
        Me.pnlStatLaba = New Panel()
        Me.pnlStatNota = New Panel()
        Me.lblOmzet = New Label()
        Me.lblTotalModal = New Label()
        Me.lblLabaKotor = New Label()
        Me.lblJumlahTransaksi = New Label()
        Me.lblKetOmzet = New Label()
        Me.lblKetModal = New Label()
        Me.lblKetLaba = New Label()
        Me.lblKetNota = New Label()
        Me.tblBawah = New TableLayoutPanel()
        Me.pnlHarian = New Panel()
        Me.pnlStok = New Panel()
        Me.lblHarian = New Label()
        Me.lblStok = New Label()
        Me.dgvPenjualanHarian = New DataGridView()
        Me.dgvStokMenipis = New DataGridView()

        Me.pnlLaporan = New Panel()
        Me.pnlFilter = New Panel()
        Me.lblAwal = New Label()
        Me.lblAkhir = New Label()
        Me.dtpTanggalAwal = New DateTimePicker()
        Me.dtpTanggalAkhir = New DateTimePicker()
        Me.btnTampilkan = New Button()
        Me.btnBulanIni = New Button()
        Me.lblInfoLaporan = New Label()
        Me.tabLaporan = New TabControl()
        Me.tabPenjualan = New TabPage()
        Me.tabLaba = New TabPage()
        Me.dgvPenjualan = New DataGridView()
        Me.dgvLaba = New DataGridView()

        CType(Me.dgvPenjualanHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        ' FORM
        Me.Name = "FrmUtamaOwner"
        Me.Text = "AGRIMART | Owner"
        Me.ClientSize = New Size(1200, 730)
        Me.MinimumSize = New Size(1060, 630)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Font = New Font("Segoe UI", 10.0!)
        Me.BackColor = Color.FromArgb(245, 248, 244)
        Me.AutoScaleMode = AutoScaleMode.Font

        ' SIDEBAR
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Dock = DockStyle.Left
        Me.pnlSidebar.Width = 215
        Me.pnlSidebar.BackColor = Color.FromArgb(23, 82, 44)

        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Text = "AGRIMART"
        Me.lblBrand.Font = New Font("Segoe UI", 19.0!, FontStyle.Bold)
        Me.lblBrand.ForeColor = Color.White
        Me.lblBrand.Location = New Point(15, 35)
        Me.lblBrand.Size = New Size(195, 47)

        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.Location = New Point(12, 145)
        Me.btnDashboard.Size = New Size(190, 46)
        Me.btnDashboard.BackColor = Color.FromArgb(55, 119, 80)
        Me.btnDashboard.ForeColor = Color.White
        Me.btnDashboard.FlatStyle = FlatStyle.Flat
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False

        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.Location = New Point(12, 201)
        Me.btnLaporan.Size = New Size(190, 46)
        Me.btnLaporan.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnLaporan.ForeColor = Color.White
        Me.btnLaporan.FlatStyle = FlatStyle.Flat
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.TextAlign = ContentAlignment.MiddleLeft
        Me.btnLaporan.UseVisualStyleBackColor = False

        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.Dock = DockStyle.Bottom
        Me.btnLogout.Height = 46
        Me.btnLogout.BackColor = Color.FromArgb(47, 102, 69)
        Me.btnLogout.ForeColor = Color.White
        Me.btnLogout.FlatStyle = FlatStyle.Flat
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.TextAlign = ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False

        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnLaporan)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)

        ' HEADER
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Dock = DockStyle.Fill
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Dock = DockStyle.Top
        Me.pnlHeader.Height = 80
        Me.pnlHeader.BackColor = Color.White

        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Text = "Dashboard Owner"
        Me.lblJudul.Font = New Font("Segoe UI", 21.0!, FontStyle.Bold)
        Me.lblJudul.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblJudul.Location = New Point(22, 15)
        Me.lblJudul.Size = New Size(470, 50)

        Me.lblNamaOwner.Name = "lblNamaOwner"
        Me.lblNamaOwner.Text = "Halo, Owner!"
        Me.lblNamaOwner.Dock = DockStyle.Right
        Me.lblNamaOwner.Width = 225
        Me.lblNamaOwner.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblNamaOwner.TextAlign = ContentAlignment.MiddleRight
        Me.lblNamaOwner.Padding = New Padding(0, 0, 15, 0)

        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblNamaOwner)

        Me.pnlKonten.Name = "pnlKonten"
        Me.pnlKonten.Dock = DockStyle.Fill
        Me.pnlKonten.Padding = New Padding(16)
        Me.pnlKonten.BackColor = Color.FromArgb(245, 248, 244)

        ' DASHBOARD
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Dock = DockStyle.Fill

        Me.pnlDashAtas.Name = "pnlDashAtas"
        Me.pnlDashAtas.Dock = DockStyle.Top
        Me.pnlDashAtas.Height = 49
        Me.lblPeriodeDashboard.Name = "lblPeriodeDashboard"
        Me.lblPeriodeDashboard.Text = "Ringkasan bulan berjalan"
        Me.lblPeriodeDashboard.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblPeriodeDashboard.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.lblPeriodeDashboard.Location = New Point(4, 12)
        Me.lblPeriodeDashboard.Size = New Size(470, 28)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Text = "Refresh"
        Me.btnRefreshDashboard.Location = New Point(780, 7)
        Me.btnRefreshDashboard.Size = New Size(100, 35)
        Me.btnRefreshDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.pnlDashAtas.Controls.Add(Me.lblPeriodeDashboard)
        Me.pnlDashAtas.Controls.Add(Me.btnRefreshDashboard)

        Me.tblStat.Name = "tblStat"
        Me.tblStat.Dock = DockStyle.Top
        Me.tblStat.Height = 135
        Me.tblStat.ColumnCount = 4
        Me.tblStat.RowCount = 1
        Me.tblStat.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 25.0!))

        Me.pnlStatOmzet.Name = "pnlStatOmzet"
        Me.pnlStatModal.Name = "pnlStatModal"
        Me.pnlStatLaba.Name = "pnlStatLaba"
        Me.pnlStatNota.Name = "pnlStatNota"
        Me.pnlStatOmzet.Dock = DockStyle.Fill
        Me.pnlStatModal.Dock = DockStyle.Fill
        Me.pnlStatLaba.Dock = DockStyle.Fill
        Me.pnlStatNota.Dock = DockStyle.Fill
        Me.pnlStatOmzet.BackColor = Color.White
        Me.pnlStatModal.BackColor = Color.White
        Me.pnlStatLaba.BackColor = Color.White
        Me.pnlStatNota.BackColor = Color.White
        Me.pnlStatOmzet.Margin = New Padding(0, 0, 5, 10)
        Me.pnlStatModal.Margin = New Padding(5, 0, 5, 10)
        Me.pnlStatLaba.Margin = New Padding(5, 0, 5, 10)
        Me.pnlStatNota.Margin = New Padding(5, 0, 0, 10)

        Me.lblOmzet.Name = "lblOmzet"
        Me.lblOmzet.Text = "Rp 0"
        Me.lblOmzet.Font = New Font("Segoe UI", 17.0!, FontStyle.Bold)
        Me.lblOmzet.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblOmzet.Location = New Point(10, 18)
        Me.lblOmzet.Size = New Size(215, 50)
        Me.lblTotalModal.Name = "lblTotalModal"
        Me.lblTotalModal.Text = "Rp 0"
        Me.lblTotalModal.Font = New Font("Segoe UI", 17.0!, FontStyle.Bold)
        Me.lblTotalModal.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblTotalModal.Location = New Point(10, 18)
        Me.lblTotalModal.Size = New Size(215, 50)
        Me.lblLabaKotor.Name = "lblLabaKotor"
        Me.lblLabaKotor.Text = "Rp 0"
        Me.lblLabaKotor.Font = New Font("Segoe UI", 17.0!, FontStyle.Bold)
        Me.lblLabaKotor.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblLabaKotor.Location = New Point(10, 18)
        Me.lblLabaKotor.Size = New Size(215, 50)
        Me.lblJumlahTransaksi.Name = "lblJumlahTransaksi"
        Me.lblJumlahTransaksi.Text = "0"
        Me.lblJumlahTransaksi.Font = New Font("Segoe UI", 20.0!, FontStyle.Bold)
        Me.lblJumlahTransaksi.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblJumlahTransaksi.Location = New Point(10, 18)
        Me.lblJumlahTransaksi.Size = New Size(215, 50)

        Me.lblKetOmzet.Name = "lblKetOmzet"
        Me.lblKetOmzet.Text = "Omzet Penjualan"
        Me.lblKetOmzet.Location = New Point(12, 84)
        Me.lblKetOmzet.Size = New Size(210, 26)
        Me.lblKetModal.Name = "lblKetModal"
        Me.lblKetModal.Text = "Modal Barang Terjual"
        Me.lblKetModal.Location = New Point(12, 84)
        Me.lblKetModal.Size = New Size(210, 26)
        Me.lblKetLaba.Name = "lblKetLaba"
        Me.lblKetLaba.Text = "Laba Kotor"
        Me.lblKetLaba.Location = New Point(12, 84)
        Me.lblKetLaba.Size = New Size(210, 26)
        Me.lblKetNota.Name = "lblKetNota"
        Me.lblKetNota.Text = "Jumlah Nota"
        Me.lblKetNota.Location = New Point(12, 84)
        Me.lblKetNota.Size = New Size(210, 26)

        Me.pnlStatOmzet.Controls.Add(Me.lblOmzet)
        Me.pnlStatOmzet.Controls.Add(Me.lblKetOmzet)
        Me.pnlStatModal.Controls.Add(Me.lblTotalModal)
        Me.pnlStatModal.Controls.Add(Me.lblKetModal)
        Me.pnlStatLaba.Controls.Add(Me.lblLabaKotor)
        Me.pnlStatLaba.Controls.Add(Me.lblKetLaba)
        Me.pnlStatNota.Controls.Add(Me.lblJumlahTransaksi)
        Me.pnlStatNota.Controls.Add(Me.lblKetNota)
        Me.tblStat.Controls.Add(Me.pnlStatOmzet, 0, 0)
        Me.tblStat.Controls.Add(Me.pnlStatModal, 1, 0)
        Me.tblStat.Controls.Add(Me.pnlStatLaba, 2, 0)
        Me.tblStat.Controls.Add(Me.pnlStatNota, 3, 0)

        ' REKAP HARIAN DAN STOK MENIPIS
        Me.tblBawah.Name = "tblBawah"
        Me.tblBawah.Dock = DockStyle.Fill
        Me.tblBawah.ColumnCount = 2
        Me.tblBawah.RowCount = 1
        Me.tblBawah.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.0!))
        Me.tblBawah.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0!))

        Me.pnlHarian.Name = "pnlHarian"
        Me.pnlHarian.Dock = DockStyle.Fill
        Me.pnlHarian.BackColor = Color.White
        Me.pnlHarian.Padding = New Padding(10)
        Me.pnlHarian.Margin = New Padding(0, 0, 6, 0)
        Me.lblHarian.Name = "lblHarian"
        Me.lblHarian.Text = "Rekap Penjualan Harian (Bulan Ini)"
        Me.lblHarian.Dock = DockStyle.Top
        Me.lblHarian.Height = 42
        Me.lblHarian.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblHarian.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.dgvPenjualanHarian.Name = "dgvPenjualanHarian"
        Me.dgvPenjualanHarian.Dock = DockStyle.Fill
        Me.dgvPenjualanHarian.ReadOnly = True
        Me.dgvPenjualanHarian.AllowUserToAddRows = False
        Me.dgvPenjualanHarian.AllowUserToDeleteRows = False
        Me.dgvPenjualanHarian.RowHeadersVisible = False
        Me.dgvPenjualanHarian.BackgroundColor = Color.White
        Me.dgvPenjualanHarian.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.pnlHarian.Controls.Add(Me.dgvPenjualanHarian)
        Me.pnlHarian.Controls.Add(Me.lblHarian)

        Me.pnlStok.Name = "pnlStok"
        Me.pnlStok.Dock = DockStyle.Fill
        Me.pnlStok.BackColor = Color.White
        Me.pnlStok.Padding = New Padding(10)
        Me.pnlStok.Margin = New Padding(6, 0, 0, 0)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Text = "Stok Menipis (0-10 Unit)"
        Me.lblStok.Dock = DockStyle.Top
        Me.lblStok.Height = 42
        Me.lblStok.ForeColor = Color.FromArgb(23, 82, 44)
        Me.lblStok.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.dgvStokMenipis.Name = "dgvStokMenipis"
        Me.dgvStokMenipis.Dock = DockStyle.Fill
        Me.dgvStokMenipis.ReadOnly = True
        Me.dgvStokMenipis.AllowUserToAddRows = False
        Me.dgvStokMenipis.AllowUserToDeleteRows = False
        Me.dgvStokMenipis.RowHeadersVisible = False
        Me.dgvStokMenipis.BackgroundColor = Color.White
        Me.dgvStokMenipis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.pnlStok.Controls.Add(Me.dgvStokMenipis)
        Me.pnlStok.Controls.Add(Me.lblStok)
        Me.tblBawah.Controls.Add(Me.pnlHarian, 0, 0)
        Me.tblBawah.Controls.Add(Me.pnlStok, 1, 0)

        Me.pnlDashboard.Controls.Add(Me.tblBawah)
        Me.pnlDashboard.Controls.Add(Me.tblStat)
        Me.pnlDashboard.Controls.Add(Me.pnlDashAtas)

        ' LAPORAN - FILTER PERIODE
        Me.pnlLaporan.Name = "pnlLaporan"
        Me.pnlLaporan.Dock = DockStyle.Fill
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Dock = DockStyle.Top
        Me.pnlFilter.Height = 94
        Me.pnlFilter.BackColor = Color.White
        Me.lblAwal.Name = "lblAwal"
        Me.lblAwal.Text = "Tanggal Awal"
        Me.lblAwal.Location = New Point(15, 10)
        Me.lblAwal.Size = New Size(150, 25)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Location = New Point(15, 38)
        Me.dtpTanggalAwal.Size = New Size(175, 31)
        Me.dtpTanggalAwal.Format = DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.CustomFormat = "dd/MM/yyyy"

        Me.lblAkhir.Name = "lblAkhir"
        Me.lblAkhir.Text = "Tanggal Akhir"
        Me.lblAkhir.Location = New Point(207, 10)
        Me.lblAkhir.Size = New Size(150, 25)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Location = New Point(207, 38)
        Me.dtpTanggalAkhir.Size = New Size(175, 31)
        Me.dtpTanggalAkhir.Format = DateTimePickerFormat.Custom
        Me.dtpTanggalAkhir.CustomFormat = "dd/MM/yyyy"

        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.Location = New Point(402, 36)
        Me.btnTampilkan.Size = New Size(115, 37)
        Me.btnTampilkan.BackColor = Color.FromArgb(23, 82, 44)
        Me.btnTampilkan.ForeColor = Color.White
        Me.btnTampilkan.FlatStyle = FlatStyle.Flat
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.UseVisualStyleBackColor = False

        Me.btnBulanIni.Name = "btnBulanIni"
        Me.btnBulanIni.Text = "Bulan Ini"
        Me.btnBulanIni.Location = New Point(528, 36)
        Me.btnBulanIni.Size = New Size(110, 37)
        Me.pnlFilter.Controls.Add(Me.lblAwal)
        Me.pnlFilter.Controls.Add(Me.dtpTanggalAwal)
        Me.pnlFilter.Controls.Add(Me.lblAkhir)
        Me.pnlFilter.Controls.Add(Me.dtpTanggalAkhir)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.btnBulanIni)

        Me.lblInfoLaporan.Name = "lblInfoLaporan"
        Me.lblInfoLaporan.Dock = DockStyle.Bottom
        Me.lblInfoLaporan.Height = 35
        Me.lblInfoLaporan.Text = "Maksimal 500 nota per tabel. Sempitkan periode bila hasil lebih banyak."
        Me.lblInfoLaporan.ForeColor = Color.DimGray
        Me.lblInfoLaporan.TextAlign = ContentAlignment.MiddleLeft
        Me.lblInfoLaporan.Padding = New Padding(8, 0, 0, 0)

        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Dock = DockStyle.Fill
        Me.tabPenjualan.Name = "tabPenjualan"
        Me.tabPenjualan.Text = "Laporan Penjualan"
        Me.tabPenjualan.BackColor = Color.White
        Me.tabLaba.Name = "tabLaba"
        Me.tabLaba.Text = "Laporan Laba Kotor"
        Me.tabLaba.BackColor = Color.White

        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.Dock = DockStyle.Fill
        Me.dgvPenjualan.ReadOnly = True
        Me.dgvPenjualan.AllowUserToAddRows = False
        Me.dgvPenjualan.AllowUserToDeleteRows = False
        Me.dgvPenjualan.RowHeadersVisible = False
        Me.dgvPenjualan.BackgroundColor = Color.White
        Me.dgvPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaba.Name = "dgvLaba"
        Me.dgvLaba.Dock = DockStyle.Fill
        Me.dgvLaba.ReadOnly = True
        Me.dgvLaba.AllowUserToAddRows = False
        Me.dgvLaba.AllowUserToDeleteRows = False
        Me.dgvLaba.RowHeadersVisible = False
        Me.dgvLaba.BackgroundColor = Color.White
        Me.dgvLaba.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Me.tabPenjualan.Controls.Add(Me.dgvPenjualan)
        Me.tabLaba.Controls.Add(Me.dgvLaba)
        Me.tabLaporan.Controls.Add(Me.tabPenjualan)
        Me.tabLaporan.Controls.Add(Me.tabLaba)
        Me.pnlLaporan.Controls.Add(Me.tabLaporan)
        Me.pnlLaporan.Controls.Add(Me.pnlFilter)
        Me.pnlLaporan.Controls.Add(Me.lblInfoLaporan)

        ' SATU FORM, DUA PANEL
        Me.pnlKonten.Controls.Add(Me.pnlLaporan)
        Me.pnlKonten.Controls.Add(Me.pnlDashboard)
        Me.pnlMain.Controls.Add(Me.pnlKonten)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)

        CType(Me.dgvPenjualanHarian, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
End Class
