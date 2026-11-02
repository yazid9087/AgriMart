
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnLaporan = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlKonten = New System.Windows.Forms.Panel()
        Me.pnlLaporan = New System.Windows.Forms.Panel()
        Me.tabLaporan = New System.Windows.Forms.TabControl()
        Me.tabPenjualan = New System.Windows.Forms.TabPage()
        Me.dgvPenjualan = New System.Windows.Forms.DataGridView()
        Me.tabLaba = New System.Windows.Forms.TabPage()
        Me.dgvLaba = New System.Windows.Forms.DataGridView()
        Me.pnlFilter = New System.Windows.Forms.Panel()
        Me.lblAwal = New System.Windows.Forms.Label()
        Me.dtpTanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.lblAkhir = New System.Windows.Forms.Label()
        Me.dtpTanggalAkhir = New System.Windows.Forms.DateTimePicker()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnBulanIni = New System.Windows.Forms.Button()
        Me.lblInfoLaporan = New System.Windows.Forms.Label()
        Me.pnlDashboard = New System.Windows.Forms.Panel()
        Me.tblBawah = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlHarian = New System.Windows.Forms.Panel()
        Me.dgvPenjualanHarian = New System.Windows.Forms.DataGridView()
        Me.lblHarian = New System.Windows.Forms.Label()
        Me.pnlStok = New System.Windows.Forms.Panel()
        Me.dgvStokMenipis = New System.Windows.Forms.DataGridView()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.tblStat = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStatOmzet = New System.Windows.Forms.Panel()
        Me.lblOmzet = New System.Windows.Forms.Label()
        Me.lblKetOmzet = New System.Windows.Forms.Label()
        Me.pnlStatModal = New System.Windows.Forms.Panel()
        Me.lblTotalModal = New System.Windows.Forms.Label()
        Me.lblKetModal = New System.Windows.Forms.Label()
        Me.pnlStatLaba = New System.Windows.Forms.Panel()
        Me.lblLabaKotor = New System.Windows.Forms.Label()
        Me.lblKetLaba = New System.Windows.Forms.Label()
        Me.pnlStatNota = New System.Windows.Forms.Panel()
        Me.lblJumlahTransaksi = New System.Windows.Forms.Label()
        Me.lblKetNota = New System.Windows.Forms.Label()
        Me.pnlDashAtas = New System.Windows.Forms.Panel()
        Me.lblPeriodeDashboard = New System.Windows.Forms.Label()
        Me.btnRefreshDashboard = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblNamaOwner = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlKonten.SuspendLayout()
        Me.pnlLaporan.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        Me.tabPenjualan.SuspendLayout()
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabLaba.SuspendLayout()
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFilter.SuspendLayout()
        Me.pnlDashboard.SuspendLayout()
        Me.tblBawah.SuspendLayout()
        Me.pnlHarian.SuspendLayout()
        CType(Me.dgvPenjualanHarian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlStok.SuspendLayout()
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblStat.SuspendLayout()
        Me.pnlStatOmzet.SuspendLayout()
        Me.pnlStatModal.SuspendLayout()
        Me.pnlStatLaba.SuspendLayout()
        Me.pnlStatNota.SuspendLayout()
        Me.pnlDashAtas.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.btnDashboard)
        Me.pnlSidebar.Controls.Add(Me.btnLaporan)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(215, 730)
        Me.pnlSidebar.TabIndex = 1
        '
        'lblBrand
        '
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 19.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(15, 35)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(195, 47)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "AGRIMART"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(12, 145)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(190, 46)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "   Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'btnLaporan
        '
        Me.btnLaporan.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnLaporan.FlatAppearance.BorderSize = 0
        Me.btnLaporan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporan.ForeColor = System.Drawing.Color.White
        Me.btnLaporan.Location = New System.Drawing.Point(12, 201)
        Me.btnLaporan.Name = "btnLaporan"
        Me.btnLaporan.Size = New System.Drawing.Size(190, 46)
        Me.btnLaporan.TabIndex = 2
        Me.btnLaporan.Text = "   Laporan"
        Me.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaporan.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 684)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(215, 46)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "   Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlMain
        '
        Me.pnlMain.Controls.Add(Me.pnlKonten)
        Me.pnlMain.Controls.Add(Me.pnlHeader)
        Me.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMain.Location = New System.Drawing.Point(215, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(985, 730)
        Me.pnlMain.TabIndex = 0
        '
        'pnlKonten
        '
        Me.pnlKonten.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlKonten.Controls.Add(Me.pnlDashboard)
        Me.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKonten.Location = New System.Drawing.Point(0, 80)
        Me.pnlKonten.Name = "pnlKonten"
        Me.pnlKonten.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlKonten.Size = New System.Drawing.Size(985, 650)
        Me.pnlKonten.TabIndex = 0
        '
        'pnlLaporan
        '
        Me.pnlLaporan.Controls.Add(Me.tabLaporan)
        Me.pnlLaporan.Controls.Add(Me.pnlFilter)
        Me.pnlLaporan.Controls.Add(Me.lblInfoLaporan)
        Me.pnlLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLaporan.Location = New System.Drawing.Point(0, 184)
        Me.pnlLaporan.Name = "pnlLaporan"
        Me.pnlLaporan.Size = New System.Drawing.Size(953, 434)
        Me.pnlLaporan.TabIndex = 0
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.tabPenjualan)
        Me.tabLaporan.Controls.Add(Me.tabLaba)
        Me.tabLaporan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabLaporan.Location = New System.Drawing.Point(0, 94)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.SelectedIndex = 0
        Me.tabLaporan.Size = New System.Drawing.Size(953, 305)
        Me.tabLaporan.TabIndex = 0
        '
        'tabPenjualan
        '
        Me.tabPenjualan.BackColor = System.Drawing.Color.White
        Me.tabPenjualan.Controls.Add(Me.dgvPenjualan)
        Me.tabPenjualan.Location = New System.Drawing.Point(4, 32)
        Me.tabPenjualan.Name = "tabPenjualan"
        Me.tabPenjualan.Size = New System.Drawing.Size(945, 269)
        Me.tabPenjualan.TabIndex = 0
        Me.tabPenjualan.Text = "Laporan Penjualan"
        '
        'dgvPenjualan
        '
        Me.dgvPenjualan.AllowUserToAddRows = False
        Me.dgvPenjualan.AllowUserToDeleteRows = False
        Me.dgvPenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPenjualan.BackgroundColor = System.Drawing.Color.White
        Me.dgvPenjualan.ColumnHeadersHeight = 29
        Me.dgvPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPenjualan.Location = New System.Drawing.Point(0, 0)
        Me.dgvPenjualan.Name = "dgvPenjualan"
        Me.dgvPenjualan.ReadOnly = True
        Me.dgvPenjualan.RowHeadersVisible = False
        Me.dgvPenjualan.RowHeadersWidth = 51
        Me.dgvPenjualan.Size = New System.Drawing.Size(945, 269)
        Me.dgvPenjualan.TabIndex = 0
        '
        'tabLaba
        '
        Me.tabLaba.BackColor = System.Drawing.Color.White
        Me.tabLaba.Controls.Add(Me.dgvLaba)
        Me.tabLaba.Location = New System.Drawing.Point(4, 32)
        Me.tabLaba.Name = "tabLaba"
        Me.tabLaba.Size = New System.Drawing.Size(160, 0)
        Me.tabLaba.TabIndex = 1
        Me.tabLaba.Text = "Laporan Laba Kotor"
        '
        'dgvLaba
        '
        Me.dgvLaba.AllowUserToAddRows = False
        Me.dgvLaba.AllowUserToDeleteRows = False
        Me.dgvLaba.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLaba.BackgroundColor = System.Drawing.Color.White
        Me.dgvLaba.ColumnHeadersHeight = 29
        Me.dgvLaba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLaba.Location = New System.Drawing.Point(0, 0)
        Me.dgvLaba.Name = "dgvLaba"
        Me.dgvLaba.ReadOnly = True
        Me.dgvLaba.RowHeadersVisible = False
        Me.dgvLaba.RowHeadersWidth = 51
        Me.dgvLaba.Size = New System.Drawing.Size(160, 0)
        Me.dgvLaba.TabIndex = 0
        '
        'pnlFilter
        '
        Me.pnlFilter.BackColor = System.Drawing.Color.White
        Me.pnlFilter.Controls.Add(Me.lblAwal)
        Me.pnlFilter.Controls.Add(Me.dtpTanggalAwal)
        Me.pnlFilter.Controls.Add(Me.lblAkhir)
        Me.pnlFilter.Controls.Add(Me.dtpTanggalAkhir)
        Me.pnlFilter.Controls.Add(Me.btnTampilkan)
        Me.pnlFilter.Controls.Add(Me.btnBulanIni)
        Me.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFilter.Location = New System.Drawing.Point(0, 0)
        Me.pnlFilter.Name = "pnlFilter"
        Me.pnlFilter.Size = New System.Drawing.Size(953, 94)
        Me.pnlFilter.TabIndex = 1
        '
        'lblAwal
        '
        Me.lblAwal.Location = New System.Drawing.Point(15, 10)
        Me.lblAwal.Name = "lblAwal"
        Me.lblAwal.Size = New System.Drawing.Size(150, 25)
        Me.lblAwal.TabIndex = 0
        Me.lblAwal.Text = "Tanggal Awal"
        '
        'dtpTanggalAwal
        '
        Me.dtpTanggalAwal.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAwal.Location = New System.Drawing.Point(15, 38)
        Me.dtpTanggalAwal.Name = "dtpTanggalAwal"
        Me.dtpTanggalAwal.Size = New System.Drawing.Size(175, 30)
        Me.dtpTanggalAwal.TabIndex = 1
        '
        'lblAkhir
        '
        Me.lblAkhir.Location = New System.Drawing.Point(207, 10)
        Me.lblAkhir.Name = "lblAkhir"
        Me.lblAkhir.Size = New System.Drawing.Size(150, 25)
        Me.lblAkhir.TabIndex = 2
        Me.lblAkhir.Text = "Tanggal Akhir"
        '
        'dtpTanggalAkhir
        '
        Me.dtpTanggalAkhir.CustomFormat = "dd/MM/yyyy"
        Me.dtpTanggalAkhir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTanggalAkhir.Location = New System.Drawing.Point(207, 38)
        Me.dtpTanggalAkhir.Name = "dtpTanggalAkhir"
        Me.dtpTanggalAkhir.Size = New System.Drawing.Size(175, 30)
        Me.dtpTanggalAkhir.TabIndex = 3
        '
        'btnTampilkan
        '
        Me.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnTampilkan.FlatAppearance.BorderSize = 0
        Me.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTampilkan.ForeColor = System.Drawing.Color.White
        Me.btnTampilkan.Location = New System.Drawing.Point(402, 36)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(115, 37)
        Me.btnTampilkan.TabIndex = 4
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = False
        '
        'btnBulanIni
        '
        Me.btnBulanIni.Location = New System.Drawing.Point(528, 36)
        Me.btnBulanIni.Name = "btnBulanIni"
        Me.btnBulanIni.Size = New System.Drawing.Size(110, 37)
        Me.btnBulanIni.TabIndex = 5
        Me.btnBulanIni.Text = "Bulan Ini"
        '
        'lblInfoLaporan
        '
        Me.lblInfoLaporan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblInfoLaporan.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoLaporan.Location = New System.Drawing.Point(0, 399)
        Me.lblInfoLaporan.Name = "lblInfoLaporan"
        Me.lblInfoLaporan.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.lblInfoLaporan.Size = New System.Drawing.Size(953, 35)
        Me.lblInfoLaporan.TabIndex = 2
        Me.lblInfoLaporan.Text = "Maksimal 500 nota per tabel. Sempitkan periode bila hasil lebih banyak."
        Me.lblInfoLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlDashboard
        '
        Me.pnlDashboard.Controls.Add(Me.pnlLaporan)
        Me.pnlDashboard.Controls.Add(Me.tblBawah)
        Me.pnlDashboard.Controls.Add(Me.tblStat)
        Me.pnlDashboard.Controls.Add(Me.pnlDashAtas)
        Me.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDashboard.Location = New System.Drawing.Point(16, 16)
        Me.pnlDashboard.Name = "pnlDashboard"
        Me.pnlDashboard.Size = New System.Drawing.Size(953, 618)
        Me.pnlDashboard.TabIndex = 1
        '
        'tblBawah
        '
        Me.tblBawah.ColumnCount = 2
        Me.tblBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.tblBawah.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.tblBawah.Controls.Add(Me.pnlHarian, 0, 0)
        Me.tblBawah.Controls.Add(Me.pnlStok, 1, 0)
        Me.tblBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblBawah.Location = New System.Drawing.Point(0, 184)
        Me.tblBawah.Name = "tblBawah"
        Me.tblBawah.RowCount = 1
        Me.tblBawah.Size = New System.Drawing.Size(953, 434)
        Me.tblBawah.TabIndex = 0
        '
        'pnlHarian
        '
        Me.pnlHarian.BackColor = System.Drawing.Color.White
        Me.pnlHarian.Controls.Add(Me.dgvPenjualanHarian)
        Me.pnlHarian.Controls.Add(Me.lblHarian)
        Me.pnlHarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlHarian.Location = New System.Drawing.Point(0, 0)
        Me.pnlHarian.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.pnlHarian.Name = "pnlHarian"
        Me.pnlHarian.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlHarian.Size = New System.Drawing.Size(518, 434)
        Me.pnlHarian.TabIndex = 0
        '
        'dgvPenjualanHarian
        '
        Me.dgvPenjualanHarian.AllowUserToAddRows = False
        Me.dgvPenjualanHarian.AllowUserToDeleteRows = False
        Me.dgvPenjualanHarian.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPenjualanHarian.BackgroundColor = System.Drawing.Color.White
        Me.dgvPenjualanHarian.ColumnHeadersHeight = 29
        Me.dgvPenjualanHarian.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPenjualanHarian.Location = New System.Drawing.Point(10, 52)
        Me.dgvPenjualanHarian.Name = "dgvPenjualanHarian"
        Me.dgvPenjualanHarian.ReadOnly = True
        Me.dgvPenjualanHarian.RowHeadersVisible = False
        Me.dgvPenjualanHarian.RowHeadersWidth = 51
        Me.dgvPenjualanHarian.Size = New System.Drawing.Size(498, 372)
        Me.dgvPenjualanHarian.TabIndex = 0
        '
        'lblHarian
        '
        Me.lblHarian.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHarian.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblHarian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblHarian.Location = New System.Drawing.Point(10, 10)
        Me.lblHarian.Name = "lblHarian"
        Me.lblHarian.Size = New System.Drawing.Size(498, 42)
        Me.lblHarian.TabIndex = 1
        Me.lblHarian.Text = "Rekap Penjualan Harian (Bulan Ini)"
        '
        'pnlStok
        '
        Me.pnlStok.BackColor = System.Drawing.Color.White
        Me.pnlStok.Controls.Add(Me.dgvStokMenipis)
        Me.pnlStok.Controls.Add(Me.lblStok)
        Me.pnlStok.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStok.Location = New System.Drawing.Point(530, 0)
        Me.pnlStok.Margin = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.pnlStok.Name = "pnlStok"
        Me.pnlStok.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlStok.Size = New System.Drawing.Size(423, 434)
        Me.pnlStok.TabIndex = 1
        '
        'dgvStokMenipis
        '
        Me.dgvStokMenipis.AllowUserToAddRows = False
        Me.dgvStokMenipis.AllowUserToDeleteRows = False
        Me.dgvStokMenipis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStokMenipis.BackgroundColor = System.Drawing.Color.White
        Me.dgvStokMenipis.ColumnHeadersHeight = 29
        Me.dgvStokMenipis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStokMenipis.Location = New System.Drawing.Point(10, 52)
        Me.dgvStokMenipis.Name = "dgvStokMenipis"
        Me.dgvStokMenipis.ReadOnly = True
        Me.dgvStokMenipis.RowHeadersVisible = False
        Me.dgvStokMenipis.RowHeadersWidth = 51
        Me.dgvStokMenipis.Size = New System.Drawing.Size(403, 372)
        Me.dgvStokMenipis.TabIndex = 0
        '
        'lblStok
        '
        Me.lblStok.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStok.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblStok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblStok.Location = New System.Drawing.Point(10, 10)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(403, 42)
        Me.lblStok.TabIndex = 1
        Me.lblStok.Text = "Stok Menipis (0-10 Unit)"
        '
        'tblStat
        '
        Me.tblStat.ColumnCount = 4
        Me.tblStat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblStat.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblStat.Controls.Add(Me.pnlStatOmzet, 0, 0)
        Me.tblStat.Controls.Add(Me.pnlStatModal, 1, 0)
        Me.tblStat.Controls.Add(Me.pnlStatLaba, 2, 0)
        Me.tblStat.Controls.Add(Me.pnlStatNota, 3, 0)
        Me.tblStat.Dock = System.Windows.Forms.DockStyle.Top
        Me.tblStat.Location = New System.Drawing.Point(0, 49)
        Me.tblStat.Name = "tblStat"
        Me.tblStat.RowCount = 1
        Me.tblStat.Size = New System.Drawing.Size(953, 135)
        Me.tblStat.TabIndex = 1
        '
        'pnlStatOmzet
        '
        Me.pnlStatOmzet.BackColor = System.Drawing.Color.White
        Me.pnlStatOmzet.Controls.Add(Me.lblOmzet)
        Me.pnlStatOmzet.Controls.Add(Me.lblKetOmzet)
        Me.pnlStatOmzet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatOmzet.Location = New System.Drawing.Point(0, 0)
        Me.pnlStatOmzet.Margin = New System.Windows.Forms.Padding(0, 0, 5, 10)
        Me.pnlStatOmzet.Name = "pnlStatOmzet"
        Me.pnlStatOmzet.Size = New System.Drawing.Size(233, 125)
        Me.pnlStatOmzet.TabIndex = 0
        '
        'lblOmzet
        '
        Me.lblOmzet.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblOmzet.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblOmzet.Location = New System.Drawing.Point(10, 18)
        Me.lblOmzet.Name = "lblOmzet"
        Me.lblOmzet.Size = New System.Drawing.Size(215, 50)
        Me.lblOmzet.TabIndex = 0
        Me.lblOmzet.Text = "Rp 0"
        '
        'lblKetOmzet
        '
        Me.lblKetOmzet.Location = New System.Drawing.Point(12, 84)
        Me.lblKetOmzet.Name = "lblKetOmzet"
        Me.lblKetOmzet.Size = New System.Drawing.Size(210, 26)
        Me.lblKetOmzet.TabIndex = 1
        Me.lblKetOmzet.Text = "Omzet Penjualan"
        '
        'pnlStatModal
        '
        Me.pnlStatModal.BackColor = System.Drawing.Color.White
        Me.pnlStatModal.Controls.Add(Me.lblTotalModal)
        Me.pnlStatModal.Controls.Add(Me.lblKetModal)
        Me.pnlStatModal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatModal.Location = New System.Drawing.Point(243, 0)
        Me.pnlStatModal.Margin = New System.Windows.Forms.Padding(5, 0, 5, 10)
        Me.pnlStatModal.Name = "pnlStatModal"
        Me.pnlStatModal.Size = New System.Drawing.Size(228, 125)
        Me.pnlStatModal.TabIndex = 1
        '
        'lblTotalModal
        '
        Me.lblTotalModal.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalModal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblTotalModal.Location = New System.Drawing.Point(10, 18)
        Me.lblTotalModal.Name = "lblTotalModal"
        Me.lblTotalModal.Size = New System.Drawing.Size(215, 50)
        Me.lblTotalModal.TabIndex = 0
        Me.lblTotalModal.Text = "Rp 0"
        '
        'lblKetModal
        '
        Me.lblKetModal.Location = New System.Drawing.Point(12, 84)
        Me.lblKetModal.Name = "lblKetModal"
        Me.lblKetModal.Size = New System.Drawing.Size(210, 26)
        Me.lblKetModal.TabIndex = 1
        Me.lblKetModal.Text = "Modal Barang Terjual"
        '
        'pnlStatLaba
        '
        Me.pnlStatLaba.BackColor = System.Drawing.Color.White
        Me.pnlStatLaba.Controls.Add(Me.lblLabaKotor)
        Me.pnlStatLaba.Controls.Add(Me.lblKetLaba)
        Me.pnlStatLaba.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatLaba.Location = New System.Drawing.Point(481, 0)
        Me.pnlStatLaba.Margin = New System.Windows.Forms.Padding(5, 0, 5, 10)
        Me.pnlStatLaba.Name = "pnlStatLaba"
        Me.pnlStatLaba.Size = New System.Drawing.Size(228, 125)
        Me.pnlStatLaba.TabIndex = 2
        '
        'lblLabaKotor
        '
        Me.lblLabaKotor.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Bold)
        Me.lblLabaKotor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblLabaKotor.Location = New System.Drawing.Point(10, 18)
        Me.lblLabaKotor.Name = "lblLabaKotor"
        Me.lblLabaKotor.Size = New System.Drawing.Size(215, 50)
        Me.lblLabaKotor.TabIndex = 0
        Me.lblLabaKotor.Text = "Rp 0"
        '
        'lblKetLaba
        '
        Me.lblKetLaba.Location = New System.Drawing.Point(12, 84)
        Me.lblKetLaba.Name = "lblKetLaba"
        Me.lblKetLaba.Size = New System.Drawing.Size(210, 26)
        Me.lblKetLaba.TabIndex = 1
        Me.lblKetLaba.Text = "Laba Kotor"
        '
        'pnlStatNota
        '
        Me.pnlStatNota.BackColor = System.Drawing.Color.White
        Me.pnlStatNota.Controls.Add(Me.lblJumlahTransaksi)
        Me.pnlStatNota.Controls.Add(Me.lblKetNota)
        Me.pnlStatNota.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlStatNota.Location = New System.Drawing.Point(719, 0)
        Me.pnlStatNota.Margin = New System.Windows.Forms.Padding(5, 0, 0, 10)
        Me.pnlStatNota.Name = "pnlStatNota"
        Me.pnlStatNota.Size = New System.Drawing.Size(234, 125)
        Me.pnlStatNota.TabIndex = 3
        '
        'lblJumlahTransaksi
        '
        Me.lblJumlahTransaksi.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblJumlahTransaksi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblJumlahTransaksi.Location = New System.Drawing.Point(10, 18)
        Me.lblJumlahTransaksi.Name = "lblJumlahTransaksi"
        Me.lblJumlahTransaksi.Size = New System.Drawing.Size(215, 50)
        Me.lblJumlahTransaksi.TabIndex = 0
        Me.lblJumlahTransaksi.Text = "0"
        '
        'lblKetNota
        '
        Me.lblKetNota.Location = New System.Drawing.Point(12, 84)
        Me.lblKetNota.Name = "lblKetNota"
        Me.lblKetNota.Size = New System.Drawing.Size(210, 26)
        Me.lblKetNota.TabIndex = 1
        Me.lblKetNota.Text = "Jumlah Nota"
        '
        'pnlDashAtas
        '
        Me.pnlDashAtas.Controls.Add(Me.lblPeriodeDashboard)
        Me.pnlDashAtas.Controls.Add(Me.btnRefreshDashboard)
        Me.pnlDashAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDashAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlDashAtas.Name = "pnlDashAtas"
        Me.pnlDashAtas.Size = New System.Drawing.Size(953, 49)
        Me.pnlDashAtas.TabIndex = 2
        '
        'lblPeriodeDashboard
        '
        Me.lblPeriodeDashboard.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPeriodeDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblPeriodeDashboard.Location = New System.Drawing.Point(4, 12)
        Me.lblPeriodeDashboard.Name = "lblPeriodeDashboard"
        Me.lblPeriodeDashboard.Size = New System.Drawing.Size(470, 28)
        Me.lblPeriodeDashboard.TabIndex = 0
        Me.lblPeriodeDashboard.Text = "Ringkasan bulan berjalan"
        '
        'btnRefreshDashboard
        '
        Me.btnRefreshDashboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefreshDashboard.Location = New System.Drawing.Point(1533, 7)
        Me.btnRefreshDashboard.Name = "btnRefreshDashboard"
        Me.btnRefreshDashboard.Size = New System.Drawing.Size(100, 35)
        Me.btnRefreshDashboard.TabIndex = 1
        Me.btnRefreshDashboard.Text = "Refresh"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblNamaOwner)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(985, 80)
        Me.pnlHeader.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblJudul.Location = New System.Drawing.Point(22, 15)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(470, 50)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Dashboard Owner"
        '
        'lblNamaOwner
        '
        Me.lblNamaOwner.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblNamaOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblNamaOwner.Location = New System.Drawing.Point(760, 0)
        Me.lblNamaOwner.Name = "lblNamaOwner"
        Me.lblNamaOwner.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblNamaOwner.Size = New System.Drawing.Size(225, 80)
        Me.lblNamaOwner.TabIndex = 1
        Me.lblNamaOwner.Text = "Halo, Owner!"
        Me.lblNamaOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUtamaOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 730)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MinimumSize = New System.Drawing.Size(1060, 630)
        Me.Name = "FrmUtamaOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGRIMART | Owner"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlKonten.ResumeLayout(False)
        Me.pnlLaporan.ResumeLayout(False)
        Me.tabLaporan.ResumeLayout(False)
        Me.tabPenjualan.ResumeLayout(False)
        CType(Me.dgvPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabLaba.ResumeLayout(False)
        CType(Me.dgvLaba, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFilter.ResumeLayout(False)
        Me.pnlDashboard.ResumeLayout(False)
        Me.tblBawah.ResumeLayout(False)
        Me.pnlHarian.ResumeLayout(False)
        CType(Me.dgvPenjualanHarian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlStok.ResumeLayout(False)
        CType(Me.dgvStokMenipis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblStat.ResumeLayout(False)
        Me.pnlStatOmzet.ResumeLayout(False)
        Me.pnlStatModal.ResumeLayout(False)
        Me.pnlStatLaba.ResumeLayout(False)
        Me.pnlStatNota.ResumeLayout(False)
        Me.pnlDashAtas.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
