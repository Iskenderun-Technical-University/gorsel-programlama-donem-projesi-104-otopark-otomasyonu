namespace OtoparkOtomasyon_yeni_
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.home = new FontAwesome.Sharp.IconButton();
            this.acil = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.Vale = new FontAwesome.Sharp.IconButton();
            this.kucultmeBtn = new FontAwesome.Sharp.IconButton();
            this.closingBtn = new FontAwesome.Sharp.IconButton();
            this.yoneticiGirisi = new FontAwesome.Sharp.IconButton();
            this.gecmis = new FontAwesome.Sharp.IconButton();
            this.musteri = new FontAwesome.Sharp.IconButton();
            this.parkYerleri = new FontAwesome.Sharp.IconButton();
            this.Gelir = new FontAwesome.Sharp.IconButton();
            this.IconBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.Label();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.home);
            this.panelMenu.Controls.Add(this.acil);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Controls.Add(this.Vale);
            this.panelMenu.Controls.Add(this.kucultmeBtn);
            this.panelMenu.Controls.Add(this.closingBtn);
            this.panelMenu.Controls.Add(this.yoneticiGirisi);
            this.panelMenu.Controls.Add(this.gecmis);
            this.panelMenu.Controls.Add(this.musteri);
            this.panelMenu.Controls.Add(this.parkYerleri);
            this.panelMenu.Controls.Add(this.Gelir);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(304, 829);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // home
            // 
            this.home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.home.Enabled = false;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.home.ForeColor = System.Drawing.Color.Gainsboro;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.DodgerBlue;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(12, 75);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(277, 112);
            this.home.TabIndex = 1;
            this.home.Text = "  POLHEM";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // acil
            // 
            this.acil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.acil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.acil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.acil.ForeColor = System.Drawing.Color.Gainsboro;
            this.acil.IconChar = FontAwesome.Sharp.IconChar.Ambulance;
            this.acil.IconColor = System.Drawing.Color.Gainsboro;
            this.acil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.acil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acil.Location = new System.Drawing.Point(12, 198);
            this.acil.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.acil.Name = "acil";
            this.acil.Size = new System.Drawing.Size(135, 75);
            this.acil.TabIndex = 11;
            this.acil.Text = "Acil";
            this.acil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.acil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.acil.UseVisualStyleBackColor = false;
            this.acil.Click += new System.EventHandler(this.acil_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(58, 794);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "SoftwareStellar Yazılım";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ıconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.ıconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 70;
            this.ıconButton1.Location = new System.Drawing.Point(102, 709);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ıconButton1.Size = new System.Drawing.Size(92, 75);
            this.ıconButton1.TabIndex = 14;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = false;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // Vale
            // 
            this.Vale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Vale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Vale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Vale.ForeColor = System.Drawing.Color.Gainsboro;
            this.Vale.IconChar = FontAwesome.Sharp.IconChar.HandshakeAngle;
            this.Vale.IconColor = System.Drawing.Color.Gainsboro;
            this.Vale.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Vale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vale.Location = new System.Drawing.Point(153, 198);
            this.Vale.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Vale.Name = "Vale";
            this.Vale.Size = new System.Drawing.Size(137, 75);
            this.Vale.TabIndex = 9;
            this.Vale.Text = "Vale";
            this.Vale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Vale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Vale.UseVisualStyleBackColor = false;
            this.Vale.Click += new System.EventHandler(this.Vale_Click);
            // 
            // kucultmeBtn
            // 
            this.kucultmeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kucultmeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.kucultmeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kucultmeBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.kucultmeBtn.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.kucultmeBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.kucultmeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kucultmeBtn.IconSize = 90;
            this.kucultmeBtn.Location = new System.Drawing.Point(12, 711);
            this.kucultmeBtn.Name = "kucultmeBtn";
            this.kucultmeBtn.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.kucultmeBtn.Size = new System.Drawing.Size(84, 75);
            this.kucultmeBtn.TabIndex = 4;
            this.kucultmeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kucultmeBtn.UseVisualStyleBackColor = false;
            this.kucultmeBtn.Click += new System.EventHandler(this.kucultmeBtn_Click);
            // 
            // closingBtn
            // 
            this.closingBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.closingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closingBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.closingBtn.IconChar = FontAwesome.Sharp.IconChar.X;
            this.closingBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.closingBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closingBtn.Location = new System.Drawing.Point(200, 709);
            this.closingBtn.Name = "closingBtn";
            this.closingBtn.Size = new System.Drawing.Size(88, 75);
            this.closingBtn.TabIndex = 13;
            this.closingBtn.UseVisualStyleBackColor = false;
            this.closingBtn.Click += new System.EventHandler(this.closingBtn_Click_1);
            // 
            // yoneticiGirisi
            // 
            this.yoneticiGirisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yoneticiGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.yoneticiGirisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoneticiGirisi.ForeColor = System.Drawing.Color.Gainsboro;
            this.yoneticiGirisi.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.yoneticiGirisi.IconColor = System.Drawing.Color.Gainsboro;
            this.yoneticiGirisi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yoneticiGirisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yoneticiGirisi.Location = new System.Drawing.Point(12, 284);
            this.yoneticiGirisi.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.yoneticiGirisi.Name = "yoneticiGirisi";
            this.yoneticiGirisi.Size = new System.Drawing.Size(278, 75);
            this.yoneticiGirisi.TabIndex = 12;
            this.yoneticiGirisi.Text = "Yönetici Girişi";
            this.yoneticiGirisi.UseVisualStyleBackColor = false;
            this.yoneticiGirisi.Click += new System.EventHandler(this.yoneticiGirisi_Click);
            // 
            // gecmis
            // 
            this.gecmis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gecmis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.gecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gecmis.ForeColor = System.Drawing.Color.Gainsboro;
            this.gecmis.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.gecmis.IconColor = System.Drawing.Color.Gainsboro;
            this.gecmis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gecmis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gecmis.Location = new System.Drawing.Point(12, 628);
            this.gecmis.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.gecmis.Name = "gecmis";
            this.gecmis.Size = new System.Drawing.Size(278, 75);
            this.gecmis.TabIndex = 5;
            this.gecmis.Text = "   Geçmiş";
            this.gecmis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gecmis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gecmis.UseVisualStyleBackColor = false;
            this.gecmis.Click += new System.EventHandler(this.gecmis_Click);
            // 
            // musteri
            // 
            this.musteri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.musteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri.ForeColor = System.Drawing.Color.Gainsboro;
            this.musteri.IconChar = FontAwesome.Sharp.IconChar.User;
            this.musteri.IconColor = System.Drawing.Color.Gainsboro;
            this.musteri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.musteri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteri.Location = new System.Drawing.Point(12, 370);
            this.musteri.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.musteri.Name = "musteri";
            this.musteri.Size = new System.Drawing.Size(276, 75);
            this.musteri.TabIndex = 3;
            this.musteri.Text = "Müşteri İşlemleri";
            this.musteri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.musteri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.musteri.UseVisualStyleBackColor = false;
            this.musteri.Click += new System.EventHandler(this.musteri_Click);
            // 
            // parkYerleri
            // 
            this.parkYerleri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.parkYerleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.parkYerleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.parkYerleri.ForeColor = System.Drawing.Color.Gainsboro;
            this.parkYerleri.IconChar = FontAwesome.Sharp.IconChar.Automobile;
            this.parkYerleri.IconColor = System.Drawing.Color.Gainsboro;
            this.parkYerleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.parkYerleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkYerleri.Location = new System.Drawing.Point(12, 542);
            this.parkYerleri.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.parkYerleri.Name = "parkYerleri";
            this.parkYerleri.Size = new System.Drawing.Size(278, 75);
            this.parkYerleri.TabIndex = 1;
            this.parkYerleri.Text = "Park Yerleri";
            this.parkYerleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parkYerleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.parkYerleri.UseVisualStyleBackColor = false;
            this.parkYerleri.Click += new System.EventHandler(this.parkYerleri_Click);
            // 
            // Gelir
            // 
            this.Gelir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gelir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Gelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Gelir.ForeColor = System.Drawing.Color.Gainsboro;
            this.Gelir.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.Gelir.IconColor = System.Drawing.Color.Gainsboro;
            this.Gelir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Gelir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gelir.Location = new System.Drawing.Point(12, 456);
            this.Gelir.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.Gelir.Name = "Gelir";
            this.Gelir.Size = new System.Drawing.Size(278, 75);
            this.Gelir.TabIndex = 4;
            this.Gelir.Text = "    Gelir";
            this.Gelir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Gelir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Gelir.UseVisualStyleBackColor = false;
            this.Gelir.Click += new System.EventHandler(this.Gelir_Click);
            // 
            // IconBox1
            // 
            this.IconBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.IconBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.IconBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.IconBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconBox1.IconSize = 50;
            this.IconBox1.Location = new System.Drawing.Point(306, 0);
            this.IconBox1.Name = "IconBox1";
            this.IconBox1.Size = new System.Drawing.Size(50, 50);
            this.IconBox1.TabIndex = 3;
            this.IconBox1.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDesktop.AutoScroll = true;
            this.panelDesktop.Controls.Add(this.label7);
            this.panelDesktop.Controls.Add(this.label6);
            this.panelDesktop.Controls.Add(this.tarih);
            this.panelDesktop.Controls.Add(this.ıconPictureBox1);
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Location = new System.Drawing.Point(310, 65);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1300, 800);
            this.panelDesktop.TabIndex = 4;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(410, 387);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ücretimiz Sabit 10 liradır*.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(387, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 120);
            this.label6.TabIndex = 7;
            this.label6.Text = "\r\n\r\n3-6 saat arası park etme ücretinde %25,\r\n   6-12 saat park etme ücretinde %35" +
    ",\r\n    12+ saat park etme ücretinde %50 \r\n            indirim bulunmaktadır\r\n";
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.ForeColor = System.Drawing.Color.Gainsboro;
            this.tarih.Location = new System.Drawing.Point(374, 305);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(0, 38);
            this.tarih.TabIndex = 4;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.DodgerBlue;
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 98;
            this.ıconPictureBox1.Location = new System.Drawing.Point(474, 35);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(103, 98);
            this.ıconPictureBox1.TabIndex = 3;
            this.ıconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(345, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "SİSTEMLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(243, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(609, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "POLHEM OTOPARK ";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.homeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.homeLabel.Location = new System.Drawing.Point(356, 8);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(179, 36);
            this.homeLabel.TabIndex = 5;
            this.homeLabel.Text = "ANASAYFA";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.ClientSize = new System.Drawing.Size(1362, 829);
            this.Controls.Add(this.homeLabel);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.IconBox1);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimumSize = new System.Drawing.Size(1380, 876);
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Anasayfa_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox IconBox1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private FontAwesome.Sharp.IconButton home;
        private FontAwesome.Sharp.IconButton acil;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconButton Vale;
        private FontAwesome.Sharp.IconButton kucultmeBtn;
        private FontAwesome.Sharp.IconButton closingBtn;
        private FontAwesome.Sharp.IconButton yoneticiGirisi;
        private FontAwesome.Sharp.IconButton gecmis;
        private FontAwesome.Sharp.IconButton musteri;
        private FontAwesome.Sharp.IconButton parkYerleri;
        private FontAwesome.Sharp.IconButton Gelir;
    }
}

