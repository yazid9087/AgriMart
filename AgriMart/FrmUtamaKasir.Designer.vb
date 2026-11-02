
Imports System.Drawing
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtamaKasir
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    ' FORM UTAMA
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents pnlKonten As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblIdentitas As Label
    Friend WithEvents btnPenjualan As Button
    Friend WithEvents btnDaftarBarang As Button
    Friend WithEvents btnLogout As Button

    ' PANEL PENJUALAN
    Friend WithEvents pnlPenjualan As Panel
    Friend WithEvents pnlCariJual As Panel
    Friend WithEvents pnlTambah As Panel
    Friend WithEvents pnlBayar As Panel

    Friend WithEvents lblCariJual As Label
    Friend WithEvents txtCariJual As TextBox
    Friend WithEvents btnCariJual As Button
    Friend WithEvents dgvHasilCari As DataGridView

    Friend WithEvents lblJumlah As Label
    Friend WithEvents numJumlahJual As NumericUpDown
    Friend WithEvents btnTambahItem As Button
    Friend WithEvents dgvKeranjang As DataGridView

    ' PEMBAYARAN
    Friend WithEvents lblTotalJudul As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblMetode As Label
    Friend WithEvents cmbMetode As ComboBox
    Friend WithEvents lblBayar As Label
    Friend WithEvents numBayar As NumericUpDown
    Friend WithEvents lblKembaliJudul As Label
    Friend WithEvents lblKembalian As Label
    Friend WithEvents btnHapusItem As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents btnSimpanJual As Button

    ' PANEL DAFTAR BARANG
    Friend WithEvents pnlDaftarBarang As Panel
    Friend WithEvents pnlCariBarang As Panel
    Friend WithEvents lblCariBarang As Label
    Friend WithEvents txtCariBarang As TextBox
    Friend WithEvents btnCariBarang As Button
    Friend WithEvents btnRefreshBarang As Button
    Friend WithEvents dgvDaftarBarang As DataGridView

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
        Me.btnPenjualan = New System.Windows.Forms.Button()
        Me.btnDaftarBarang = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.pnlKonten = New System.Windows.Forms.Panel()
        Me.pnlDaftarBarang = New System.Windows.Forms.Panel()
        Me.dgvDaftarBarang = New System.Windows.Forms.DataGridView()
        Me.pnlCariBarang = New System.Windows.Forms.Panel()
        Me.lblCariBarang = New System.Windows.Forms.Label()
        Me.txtCariBarang = New System.Windows.Forms.TextBox()
        Me.btnCariBarang = New System.Windows.Forms.Button()
        Me.btnRefreshBarang = New System.Windows.Forms.Button()
        Me.pnlPenjualan = New System.Windows.Forms.Panel()
        Me.dgvKeranjang = New System.Windows.Forms.DataGridView()
        Me.pnlBayar = New System.Windows.Forms.Panel()
        Me.lblTotalJudul = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblMetode = New System.Windows.Forms.Label()
        Me.cmbMetode = New System.Windows.Forms.ComboBox()
        Me.lblBayar = New System.Windows.Forms.Label()
        Me.numBayar = New System.Windows.Forms.NumericUpDown()
        Me.lblKembaliJudul = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.btnHapusItem = New System.Windows.Forms.Button()
        Me.btnKosongkan = New System.Windows.Forms.Button()
        Me.btnSimpanJual = New System.Windows.Forms.Button()
        Me.pnlTambah = New System.Windows.Forms.Panel()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.numJumlahJual = New System.Windows.Forms.NumericUpDown()
        Me.btnTambahItem = New System.Windows.Forms.Button()
        Me.dgvHasilCari = New System.Windows.Forms.DataGridView()
        Me.pnlCariJual = New System.Windows.Forms.Panel()
        Me.lblCariJual = New System.Windows.Forms.Label()
        Me.txtCariJual = New System.Windows.Forms.TextBox()
        Me.btnCariJual = New System.Windows.Forms.Button()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblIdentitas = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlMain.SuspendLayout()
        Me.pnlKonten.SuspendLayout()
        Me.pnlDaftarBarang.SuspendLayout()
        CType(Me.dgvDaftarBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCariBarang.SuspendLayout()
        Me.pnlPenjualan.SuspendLayout()
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBayar.SuspendLayout()
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTambah.SuspendLayout()
        CType(Me.numJumlahJual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHasilCari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCariJual.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.lblBrand)
        Me.pnlSidebar.Controls.Add(Me.btnPenjualan)
        Me.pnlSidebar.Controls.Add(Me.btnDaftarBarang)
        Me.pnlSidebar.Controls.Add(Me.btnLogout)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 760)
        Me.pnlSidebar.TabIndex = 1
        '
        'lblBrand
        '
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.White
        Me.lblBrand.Location = New System.Drawing.Point(15, 35)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(200, 48)
        Me.lblBrand.TabIndex = 0
        Me.lblBrand.Text = "AGRIMARTT"
        '
        'btnPenjualan
        '
        Me.btnPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnPenjualan.FlatAppearance.BorderSize = 0
        Me.btnPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPenjualan.ForeColor = System.Drawing.Color.White
        Me.btnPenjualan.Location = New System.Drawing.Point(12, 145)
        Me.btnPenjualan.Name = "btnPenjualan"
        Me.btnPenjualan.Size = New System.Drawing.Size(195, 48)
        Me.btnPenjualan.TabIndex = 1
        Me.btnPenjualan.Text = "   Transaksi Penjualan"
        Me.btnPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPenjualan.UseVisualStyleBackColor = False
        '
        'btnDaftarBarang
        '
        Me.btnDaftarBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnDaftarBarang.FlatAppearance.BorderSize = 0
        Me.btnDaftarBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaftarBarang.ForeColor = System.Drawing.Color.White
        Me.btnDaftarBarang.Location = New System.Drawing.Point(12, 202)
        Me.btnDaftarBarang.Name = "btnDaftarBarang"
        Me.btnDaftarBarang.Size = New System.Drawing.Size(195, 48)
        Me.btnDaftarBarang.TabIndex = 2
        Me.btnDaftarBarang.Text = "   Daftar Barang"
        Me.btnDaftarBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDaftarBarang.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(0, 712)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(220, 48)
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
        Me.pnlMain.Location = New System.Drawing.Point(220, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1030, 760)
        Me.pnlMain.TabIndex = 0
        '
        'pnlKonten
        '
        Me.pnlKonten.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlKonten.Controls.Add(Me.pnlPenjualan)
        Me.pnlKonten.Controls.Add(Me.pnlDaftarBarang)
        Me.pnlKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKonten.Location = New System.Drawing.Point(0, 80)
        Me.pnlKonten.Name = "pnlKonten"
        Me.pnlKonten.Padding = New System.Windows.Forms.Padding(16)
        Me.pnlKonten.Size = New System.Drawing.Size(1030, 680)
        Me.pnlKonten.TabIndex = 0
        '
        'pnlDaftarBarang
        '
        Me.pnlDaftarBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlDaftarBarang.Controls.Add(Me.dgvDaftarBarang)
        Me.pnlDaftarBarang.Controls.Add(Me.pnlCariBarang)
        Me.pnlDaftarBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDaftarBarang.Location = New System.Drawing.Point(16, 16)
        Me.pnlDaftarBarang.Name = "pnlDaftarBarang"
        Me.pnlDaftarBarang.Size = New System.Drawing.Size(998, 648)
        Me.pnlDaftarBarang.TabIndex = 0
        '
        'dgvDaftarBarang
        '
        Me.dgvDaftarBarang.AllowUserToAddRows = False
        Me.dgvDaftarBarang.AllowUserToDeleteRows = False
        Me.dgvDaftarBarang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDaftarBarang.BackgroundColor = System.Drawing.Color.White
        Me.dgvDaftarBarang.ColumnHeadersHeight = 29
        Me.dgvDaftarBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDaftarBarang.Location = New System.Drawing.Point(0, 85)
        Me.dgvDaftarBarang.MultiSelect = False
        Me.dgvDaftarBarang.Name = "dgvDaftarBarang"
        Me.dgvDaftarBarang.ReadOnly = True
        Me.dgvDaftarBarang.RowHeadersVisible = False
        Me.dgvDaftarBarang.RowHeadersWidth = 51
        Me.dgvDaftarBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDaftarBarang.Size = New System.Drawing.Size(998, 563)
        Me.dgvDaftarBarang.TabIndex = 0
        '
        'pnlCariBarang
        '
        Me.pnlCariBarang.Controls.Add(Me.lblCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.txtCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnCariBarang)
        Me.pnlCariBarang.Controls.Add(Me.btnRefreshBarang)
        Me.pnlCariBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCariBarang.Location = New System.Drawing.Point(0, 0)
        Me.pnlCariBarang.Name = "pnlCariBarang"
        Me.pnlCariBarang.Size = New System.Drawing.Size(998, 85)
        Me.pnlCariBarang.TabIndex = 1
        '
        'lblCariBarang
        '
        Me.lblCariBarang.Location = New System.Drawing.Point(18, 8)
        Me.lblCariBarang.Name = "lblCariBarang"
        Me.lblCariBarang.Size = New System.Drawing.Size(270, 26)
        Me.lblCariBarang.TabIndex = 0
        Me.lblCariBarang.Text = "Cari Nama Barang"
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Location = New System.Drawing.Point(18, 38)
        Me.txtCariBarang.MaxLength = 100
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(350, 30)
        Me.txtCariBarang.TabIndex = 1
        '
        'btnCariBarang
        '
        Me.btnCariBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnCariBarang.FlatAppearance.BorderSize = 0
        Me.btnCariBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariBarang.ForeColor = System.Drawing.Color.White
        Me.btnCariBarang.Location = New System.Drawing.Point(380, 35)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(95, 38)
        Me.btnCariBarang.TabIndex = 2
        Me.btnCariBarang.Text = "Cari"
        Me.btnCariBarang.UseVisualStyleBackColor = False
        '
        'btnRefreshBarang
        '
        Me.btnRefreshBarang.Location = New System.Drawing.Point(485, 35)
        Me.btnRefreshBarang.Name = "btnRefreshBarang"
        Me.btnRefreshBarang.Size = New System.Drawing.Size(100, 38)
        Me.btnRefreshBarang.TabIndex = 3
        Me.btnRefreshBarang.Text = "Refresh"
        '
        'pnlPenjualan
        '
        Me.pnlPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.pnlPenjualan.Controls.Add(Me.dgvKeranjang)
        Me.pnlPenjualan.Controls.Add(Me.pnlBayar)
        Me.pnlPenjualan.Controls.Add(Me.pnlTambah)
        Me.pnlPenjualan.Controls.Add(Me.dgvHasilCari)
        Me.pnlPenjualan.Controls.Add(Me.pnlCariJual)
        Me.pnlPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlPenjualan.Location = New System.Drawing.Point(16, 16)
        Me.pnlPenjualan.Name = "pnlPenjualan"
        Me.pnlPenjualan.Size = New System.Drawing.Size(998, 648)
        Me.pnlPenjualan.TabIndex = 1
        '
        'dgvKeranjang
        '
        Me.dgvKeranjang.AllowUserToAddRows = False
        Me.dgvKeranjang.AllowUserToDeleteRows = False
        Me.dgvKeranjang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvKeranjang.BackgroundColor = System.Drawing.Color.White
        Me.dgvKeranjang.ColumnHeadersHeight = 29
        Me.dgvKeranjang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvKeranjang.Location = New System.Drawing.Point(0, 307)
        Me.dgvKeranjang.MultiSelect = False
        Me.dgvKeranjang.Name = "dgvKeranjang"
        Me.dgvKeranjang.ReadOnly = True
        Me.dgvKeranjang.RowHeadersVisible = False
        Me.dgvKeranjang.RowHeadersWidth = 51
        Me.dgvKeranjang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvKeranjang.Size = New System.Drawing.Size(998, 186)
        Me.dgvKeranjang.TabIndex = 0
        '
        'pnlBayar
        '
        Me.pnlBayar.BackColor = System.Drawing.Color.White
        Me.pnlBayar.Controls.Add(Me.lblTotalJudul)
        Me.pnlBayar.Controls.Add(Me.lblTotal)
        Me.pnlBayar.Controls.Add(Me.lblMetode)
        Me.pnlBayar.Controls.Add(Me.cmbMetode)
        Me.pnlBayar.Controls.Add(Me.lblBayar)
        Me.pnlBayar.Controls.Add(Me.numBayar)
        Me.pnlBayar.Controls.Add(Me.lblKembaliJudul)
        Me.pnlBayar.Controls.Add(Me.lblKembalian)
        Me.pnlBayar.Controls.Add(Me.btnHapusItem)
        Me.pnlBayar.Controls.Add(Me.btnKosongkan)
        Me.pnlBayar.Controls.Add(Me.btnSimpanJual)
        Me.pnlBayar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBayar.Location = New System.Drawing.Point(0, 493)
        Me.pnlBayar.Name = "pnlBayar"
        Me.pnlBayar.Size = New System.Drawing.Size(998, 155)
        Me.pnlBayar.TabIndex = 1
        '
        'lblTotalJudul
        '
        Me.lblTotalJudul.Location = New System.Drawing.Point(18, 10)
        Me.lblTotalJudul.Name = "lblTotalJudul"
        Me.lblTotalJudul.Size = New System.Drawing.Size(210, 25)
        Me.lblTotalJudul.TabIndex = 0
        Me.lblTotalJudul.Text = "TOTAL TRANSAKSI"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(18, 36)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(245, 48)
        Me.lblTotal.TabIndex = 1
        Me.lblTotal.Text = "Rp 0"
        '
        'lblMetode
        '
        Me.lblMetode.Location = New System.Drawing.Point(278, 10)
        Me.lblMetode.Name = "lblMetode"
        Me.lblMetode.Size = New System.Drawing.Size(180, 25)
        Me.lblMetode.TabIndex = 2
        Me.lblMetode.Text = "Metode Pembayaran"
        '
        'cmbMetode
        '
        Me.cmbMetode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMetode.Items.AddRange(New Object() {"Tunai", "QRIS"})
        Me.cmbMetode.Location = New System.Drawing.Point(278, 40)
        Me.cmbMetode.Name = "cmbMetode"
        Me.cmbMetode.Size = New System.Drawing.Size(140, 31)
        Me.cmbMetode.TabIndex = 3
        '
        'lblBayar
        '
        Me.lblBayar.Location = New System.Drawing.Point(435, 10)
        Me.lblBayar.Name = "lblBayar"
        Me.lblBayar.Size = New System.Drawing.Size(155, 25)
        Me.lblBayar.TabIndex = 4
        Me.lblBayar.Text = "Jumlah Bayar"
        '
        'numBayar
        '
        Me.numBayar.DecimalPlaces = 2
        Me.numBayar.Location = New System.Drawing.Point(435, 40)
        Me.numBayar.Maximum = New Decimal(New Integer() {276447231, 23283, 0, 131072})
        Me.numBayar.Name = "numBayar"
        Me.numBayar.Size = New System.Drawing.Size(170, 30)
        Me.numBayar.TabIndex = 5
        Me.numBayar.ThousandsSeparator = True
        '
        'lblKembaliJudul
        '
        Me.lblKembaliJudul.Location = New System.Drawing.Point(622, 10)
        Me.lblKembaliJudul.Name = "lblKembaliJudul"
        Me.lblKembaliJudul.Size = New System.Drawing.Size(155, 25)
        Me.lblKembaliJudul.TabIndex = 6
        Me.lblKembaliJudul.Text = "Kembalian"
        '
        'lblKembalian
        '
        Me.lblKembalian.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblKembalian.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblKembalian.Location = New System.Drawing.Point(622, 40)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(240, 35)
        Me.lblKembalian.TabIndex = 7
        Me.lblKembalian.Text = "Rp 0"
        '
        'btnHapusItem
        '
        Me.btnHapusItem.Location = New System.Drawing.Point(18, 104)
        Me.btnHapusItem.Name = "btnHapusItem"
        Me.btnHapusItem.Size = New System.Drawing.Size(125, 39)
        Me.btnHapusItem.TabIndex = 8
        Me.btnHapusItem.Text = "Hapus Item"
        '
        'btnKosongkan
        '
        Me.btnKosongkan.Location = New System.Drawing.Point(153, 104)
        Me.btnKosongkan.Name = "btnKosongkan"
        Me.btnKosongkan.Size = New System.Drawing.Size(125, 39)
        Me.btnKosongkan.TabIndex = 9
        Me.btnKosongkan.Text = "Kosongkan"
        '
        'btnSimpanJual
        '
        Me.btnSimpanJual.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSimpanJual.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnSimpanJual.FlatAppearance.BorderSize = 0
        Me.btnSimpanJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpanJual.ForeColor = System.Drawing.Color.White
        Me.btnSimpanJual.Location = New System.Drawing.Point(1473, 101)
        Me.btnSimpanJual.Name = "btnSimpanJual"
        Me.btnSimpanJual.Size = New System.Drawing.Size(205, 43)
        Me.btnSimpanJual.TabIndex = 10
        Me.btnSimpanJual.Text = "Simpan Penjualan"
        Me.btnSimpanJual.UseVisualStyleBackColor = False
        '
        'pnlTambah
        '
        Me.pnlTambah.BackColor = System.Drawing.Color.White
        Me.pnlTambah.Controls.Add(Me.lblJumlah)
        Me.pnlTambah.Controls.Add(Me.numJumlahJual)
        Me.pnlTambah.Controls.Add(Me.btnTambahItem)
        Me.pnlTambah.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTambah.Location = New System.Drawing.Point(0, 245)
        Me.pnlTambah.Name = "pnlTambah"
        Me.pnlTambah.Size = New System.Drawing.Size(998, 62)
        Me.pnlTambah.TabIndex = 2
        '
        'lblJumlah
        '
        Me.lblJumlah.Location = New System.Drawing.Point(18, 19)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(75, 28)
        Me.lblJumlah.TabIndex = 0
        Me.lblJumlah.Text = "Jumlah"
        '
        'numJumlahJual
        '
        Me.numJumlahJual.Location = New System.Drawing.Point(97, 15)
        Me.numJumlahJual.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.numJumlahJual.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numJumlahJual.Name = "numJumlahJual"
        Me.numJumlahJual.Size = New System.Drawing.Size(125, 30)
        Me.numJumlahJual.TabIndex = 1
        Me.numJumlahJual.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnTambahItem
        '
        Me.btnTambahItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnTambahItem.FlatAppearance.BorderSize = 0
        Me.btnTambahItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahItem.ForeColor = System.Drawing.Color.White
        Me.btnTambahItem.Location = New System.Drawing.Point(245, 11)
        Me.btnTambahItem.Name = "btnTambahItem"
        Me.btnTambahItem.Size = New System.Drawing.Size(210, 40)
        Me.btnTambahItem.TabIndex = 2
        Me.btnTambahItem.Text = "+ Tambah ke Keranjang"
        Me.btnTambahItem.UseVisualStyleBackColor = False
        '
        'dgvHasilCari
        '
        Me.dgvHasilCari.AllowUserToAddRows = False
        Me.dgvHasilCari.AllowUserToDeleteRows = False
        Me.dgvHasilCari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHasilCari.BackgroundColor = System.Drawing.Color.White
        Me.dgvHasilCari.ColumnHeadersHeight = 29
        Me.dgvHasilCari.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvHasilCari.Location = New System.Drawing.Point(0, 85)
        Me.dgvHasilCari.MultiSelect = False
        Me.dgvHasilCari.Name = "dgvHasilCari"
        Me.dgvHasilCari.ReadOnly = True
        Me.dgvHasilCari.RowHeadersVisible = False
        Me.dgvHasilCari.RowHeadersWidth = 51
        Me.dgvHasilCari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHasilCari.Size = New System.Drawing.Size(998, 160)
        Me.dgvHasilCari.TabIndex = 3
        '
        'pnlCariJual
        '
        Me.pnlCariJual.BackColor = System.Drawing.Color.White
        Me.pnlCariJual.Controls.Add(Me.lblCariJual)
        Me.pnlCariJual.Controls.Add(Me.txtCariJual)
        Me.pnlCariJual.Controls.Add(Me.btnCariJual)
        Me.pnlCariJual.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCariJual.Location = New System.Drawing.Point(0, 0)
        Me.pnlCariJual.Name = "pnlCariJual"
        Me.pnlCariJual.Size = New System.Drawing.Size(998, 85)
        Me.pnlCariJual.TabIndex = 4
        '
        'lblCariJual
        '
        Me.lblCariJual.Location = New System.Drawing.Point(18, 8)
        Me.lblCariJual.Name = "lblCariJual"
        Me.lblCariJual.Size = New System.Drawing.Size(300, 26)
        Me.lblCariJual.TabIndex = 0
        Me.lblCariJual.Text = "Cari Nama Barang"
        '
        'txtCariJual
        '
        Me.txtCariJual.Location = New System.Drawing.Point(18, 38)
        Me.txtCariJual.MaxLength = 100
        Me.txtCariJual.Name = "txtCariJual"
        Me.txtCariJual.Size = New System.Drawing.Size(425, 30)
        Me.txtCariJual.TabIndex = 1
        '
        'btnCariJual
        '
        Me.btnCariJual.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnCariJual.FlatAppearance.BorderSize = 0
        Me.btnCariJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariJual.ForeColor = System.Drawing.Color.White
        Me.btnCariJual.Location = New System.Drawing.Point(455, 35)
        Me.btnCariJual.Name = "btnCariJual"
        Me.btnCariJual.Size = New System.Drawing.Size(135, 38)
        Me.btnCariJual.TabIndex = 2
        Me.btnCariJual.Text = "Cari Barang"
        Me.btnCariJual.UseVisualStyleBackColor = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblJudul)
        Me.pnlHeader.Controls.Add(Me.lblIdentitas)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1030, 80)
        Me.pnlHeader.TabIndex = 1
        '
        'lblJudul
        '
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 21.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblJudul.Location = New System.Drawing.Point(22, 15)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(480, 50)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Transaksi Penjualan"
        '
        'lblIdentitas
        '
        Me.lblIdentitas.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblIdentitas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblIdentitas.Location = New System.Drawing.Point(800, 0)
        Me.lblIdentitas.Name = "lblIdentitas"
        Me.lblIdentitas.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.lblIdentitas.Size = New System.Drawing.Size(230, 80)
        Me.lblIdentitas.TabIndex = 1
        Me.lblIdentitas.Text = "Halo, Kasir!"
        Me.lblIdentitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmUtamaKasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 760)
        Me.Controls.Add(Me.pnlMain)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MinimumSize = New System.Drawing.Size(1100, 680)
        Me.Name = "FrmUtamaKasir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGRIMART | Dashboard Kasir"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlMain.ResumeLayout(False)
        Me.pnlKonten.ResumeLayout(False)
        Me.pnlDaftarBarang.ResumeLayout(False)
        CType(Me.dgvDaftarBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCariBarang.ResumeLayout(False)
        Me.pnlCariBarang.PerformLayout()
        Me.pnlPenjualan.ResumeLayout(False)
        CType(Me.dgvKeranjang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBayar.ResumeLayout(False)
        CType(Me.numBayar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTambah.ResumeLayout(False)
        CType(Me.numJumlahJual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHasilCari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCariJual.ResumeLayout(False)
        Me.pnlCariJual.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

End Class
