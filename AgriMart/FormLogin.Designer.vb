
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlKiri As Panel
    Friend WithEvents pnlKanan As Panel
    Friend WithEvents pnlKartu As Panel
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblBrandSub As Label
    Friend WithEvents lblTagline As Label
    Friend WithEvents lblFitur As Label
    Friend WithEvents lblJudulLogin As Label
    Friend WithEvents lblDeskripsi As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbKasir As RadioButton
    Friend WithEvents rbOwner As RadioButton
    Friend WithEvents pnlRole As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtNamaPengguna As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtKataSandi As TextBox
    Friend WithEvents chkTampilkanPassword As CheckBox
    Friend WithEvents lblPesanLogin As Label
    Friend WithEvents btnMasuk As Button
    Friend WithEvents btnKeluar As Button

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.pnlKiri = New System.Windows.Forms.Panel()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblTagline = New System.Windows.Forms.Label()
        Me.lblFitur = New System.Windows.Forms.Label()
        Me.lblBrand = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.pnlKanan = New System.Windows.Forms.Panel()
        Me.pnlKartu = New System.Windows.Forms.Panel()
        Me.lblJudulLogin = New System.Windows.Forms.Label()
        Me.lblDeskripsi = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.pnlRole = New System.Windows.Forms.Panel()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbKasir = New System.Windows.Forms.RadioButton()
        Me.rbOwner = New System.Windows.Forms.RadioButton()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtNamaPengguna = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtKataSandi = New System.Windows.Forms.TextBox()
        Me.chkTampilkanPassword = New System.Windows.Forms.CheckBox()
        Me.lblPesanLogin = New System.Windows.Forms.Label()
        Me.btnMasuk = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.pnlKiri.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlKanan.SuspendLayout()
        Me.pnlKartu.SuspendLayout()
        Me.pnlRole.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlKiri
        '
        Me.pnlKiri.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.pnlKiri.Controls.Add(Me.lblBrandSub)
        Me.pnlKiri.Controls.Add(Me.lblTagline)
        Me.pnlKiri.Controls.Add(Me.lblFitur)
        Me.pnlKiri.Controls.Add(Me.lblBrand)
        Me.pnlKiri.Controls.Add(Me.picLogo)
        Me.pnlKiri.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlKiri.Location = New System.Drawing.Point(0, 0)
        Me.pnlKiri.Name = "pnlKiri"
        Me.pnlKiri.Size = New System.Drawing.Size(450, 640)
        Me.pnlKiri.TabIndex = 1
        '
        'lblBrandSub
        '
        Me.lblBrandSub.BackColor = System.Drawing.Color.Transparent
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 11.5!, System.Drawing.FontStyle.Bold)
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(35, 365)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(380, 64)
        Me.lblBrandSub.TabIndex = 2
        Me.lblBrandSub.Text = "SISTEM INFORMASI MANAJEMEN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TOKO PERTANIAN"
        Me.lblBrandSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTagline
        '
        Me.lblTagline.BackColor = System.Drawing.Color.Transparent
        Me.lblTagline.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblTagline.ForeColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.lblTagline.Location = New System.Drawing.Point(24, 441)
        Me.lblTagline.Name = "lblTagline"
        Me.lblTagline.Size = New System.Drawing.Size(402, 34)
        Me.lblTagline.TabIndex = 3
        Me.lblTagline.Text = "Kelola toko lebih praktis, modern, dan efisien."
        Me.lblTagline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFitur
        '
        Me.lblFitur.BackColor = System.Drawing.Color.Transparent
        Me.lblFitur.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblFitur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblFitur.Location = New System.Drawing.Point(47, 498)
        Me.lblFitur.Name = "lblFitur"
        Me.lblFitur.Size = New System.Drawing.Size(356, 43)
        Me.lblFitur.TabIndex = 4
        Me.lblFitur.Text = "INVENTORY    •    SALES    •    REPORTS"
        Me.lblFitur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBrand
        '
        Me.lblBrand.BackColor = System.Drawing.Color.Transparent
        Me.lblBrand.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblBrand.Location = New System.Drawing.Point(35, 271)
        Me.lblBrand.Name = "lblBrand"
        Me.lblBrand.Size = New System.Drawing.Size(380, 84)
        Me.lblBrand.TabIndex = 1
        Me.lblBrand.Text = "AgriMart"
        Me.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BackColor = System.Drawing.Color.Transparent
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(-106, -61)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(632, 454)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'pnlKanan
        '
        Me.pnlKanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.pnlKanan.Controls.Add(Me.pnlKartu)
        Me.pnlKanan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlKanan.Location = New System.Drawing.Point(450, 0)
        Me.pnlKanan.Name = "pnlKanan"
        Me.pnlKanan.Size = New System.Drawing.Size(630, 640)
        Me.pnlKanan.TabIndex = 0
        '
        'pnlKartu
        '
        Me.pnlKartu.BackColor = System.Drawing.Color.White
        Me.pnlKartu.Controls.Add(Me.lblJudulLogin)
        Me.pnlKartu.Controls.Add(Me.lblDeskripsi)
        Me.pnlKartu.Controls.Add(Me.lblRole)
        Me.pnlKartu.Controls.Add(Me.pnlRole)
        Me.pnlKartu.Controls.Add(Me.lblUsername)
        Me.pnlKartu.Controls.Add(Me.txtNamaPengguna)
        Me.pnlKartu.Controls.Add(Me.lblPassword)
        Me.pnlKartu.Controls.Add(Me.txtKataSandi)
        Me.pnlKartu.Controls.Add(Me.chkTampilkanPassword)
        Me.pnlKartu.Controls.Add(Me.lblPesanLogin)
        Me.pnlKartu.Controls.Add(Me.btnMasuk)
        Me.pnlKartu.Controls.Add(Me.btnKeluar)
        Me.pnlKartu.Location = New System.Drawing.Point(57, 30)
        Me.pnlKartu.Name = "pnlKartu"
        Me.pnlKartu.Size = New System.Drawing.Size(515, 575)
        Me.pnlKartu.TabIndex = 0
        '
        'lblJudulLogin
        '
        Me.lblJudulLogin.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudulLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblJudulLogin.Location = New System.Drawing.Point(35, 32)
        Me.lblJudulLogin.Name = "lblJudulLogin"
        Me.lblJudulLogin.Size = New System.Drawing.Size(445, 60)
        Me.lblJudulLogin.TabIndex = 0
        Me.lblJudulLogin.Text = "Welcome back!"
        '
        'lblDeskripsi
        '
        Me.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.lblDeskripsi.Location = New System.Drawing.Point(39, 102)
        Me.lblDeskripsi.Name = "lblDeskripsi"
        Me.lblDeskripsi.Size = New System.Drawing.Size(438, 27)
        Me.lblDeskripsi.TabIndex = 1
        Me.lblDeskripsi.Text = "Masuk untuk mengelola aktivitas toko pertanian."
        '
        'lblRole
        '
        Me.lblRole.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblRole.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.lblRole.Location = New System.Drawing.Point(39, 159)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(180, 25)
        Me.lblRole.TabIndex = 2
        Me.lblRole.Text = "PILIH ROLE"
        '
        'pnlRole
        '
        Me.pnlRole.Controls.Add(Me.rbAdmin)
        Me.pnlRole.Controls.Add(Me.rbKasir)
        Me.pnlRole.Controls.Add(Me.rbOwner)
        Me.pnlRole.Location = New System.Drawing.Point(39, 192)
        Me.pnlRole.Name = "pnlRole"
        Me.pnlRole.Size = New System.Drawing.Size(437, 48)
        Me.pnlRole.TabIndex = 3
        '
        'rbAdmin
        '
        Me.rbAdmin.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbAdmin.Location = New System.Drawing.Point(0, 0)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(137, 45)
        Me.rbAdmin.TabIndex = 0
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbAdmin.UseVisualStyleBackColor = False
        '
        'rbKasir
        '
        Me.rbKasir.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbKasir.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbKasir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbKasir.Location = New System.Drawing.Point(150, 0)
        Me.rbKasir.Name = "rbKasir"
        Me.rbKasir.Size = New System.Drawing.Size(137, 45)
        Me.rbKasir.TabIndex = 1
        Me.rbKasir.Text = "Kasir"
        Me.rbKasir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbKasir.UseVisualStyleBackColor = False
        '
        'rbOwner
        '
        Me.rbOwner.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbOwner.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.rbOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbOwner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.rbOwner.Location = New System.Drawing.Point(300, 0)
        Me.rbOwner.Name = "rbOwner"
        Me.rbOwner.Size = New System.Drawing.Size(137, 45)
        Me.rbOwner.TabIndex = 2
        Me.rbOwner.Text = "Owner"
        Me.rbOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOwner.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(39, 260)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(200, 25)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'txtNamaPengguna
        '
        Me.txtNamaPengguna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNamaPengguna.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtNamaPengguna.Location = New System.Drawing.Point(39, 292)
        Me.txtNamaPengguna.Name = "txtNamaPengguna"
        Me.txtNamaPengguna.Size = New System.Drawing.Size(437, 34)
        Me.txtNamaPengguna.TabIndex = 5
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(39, 348)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(200, 25)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        '
        'txtKataSandi
        '
        Me.txtKataSandi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKataSandi.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtKataSandi.Location = New System.Drawing.Point(39, 380)
        Me.txtKataSandi.Name = "txtKataSandi"
        Me.txtKataSandi.Size = New System.Drawing.Size(437, 34)
        Me.txtKataSandi.TabIndex = 7
        Me.txtKataSandi.UseSystemPasswordChar = True
        '
        'chkTampilkanPassword
        '
        Me.chkTampilkanPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.chkTampilkanPassword.Location = New System.Drawing.Point(39, 425)
        Me.chkTampilkanPassword.Name = "chkTampilkanPassword"
        Me.chkTampilkanPassword.Size = New System.Drawing.Size(235, 27)
        Me.chkTampilkanPassword.TabIndex = 8
        Me.chkTampilkanPassword.Text = "Tampilkan password"
        '
        'lblPesanLogin
        '
        Me.lblPesanLogin.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPesanLogin.Location = New System.Drawing.Point(39, 458)
        Me.lblPesanLogin.Name = "lblPesanLogin"
        Me.lblPesanLogin.Size = New System.Drawing.Size(437, 24)
        Me.lblPesanLogin.TabIndex = 9
        '
        'btnMasuk
        '
        Me.btnMasuk.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.btnMasuk.FlatAppearance.BorderSize = 0
        Me.btnMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMasuk.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnMasuk.ForeColor = System.Drawing.Color.White
        Me.btnMasuk.Location = New System.Drawing.Point(39, 489)
        Me.btnMasuk.Name = "btnMasuk"
        Me.btnMasuk.Size = New System.Drawing.Size(437, 46)
        Me.btnMasuk.TabIndex = 10
        Me.btnMasuk.Text = "MASUK "
        Me.btnMasuk.UseVisualStyleBackColor = False
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.Color.White
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.Color.Gray
        Me.btnKeluar.Location = New System.Drawing.Point(385, 545)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(91, 25)
        Me.btnKeluar.TabIndex = 11
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btnMasuk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1080, 640)
        Me.Controls.Add(Me.pnlKanan)
        Me.Controls.Add(Me.pnlKiri)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgriMart - Login"
        Me.pnlKiri.ResumeLayout(False)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlKanan.ResumeLayout(False)
        Me.pnlKartu.ResumeLayout(False)
        Me.pnlKartu.PerformLayout()
        Me.pnlRole.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLogo As PictureBox
End Class
