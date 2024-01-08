namespace Stok.WinUI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            pictureBox1 = new PictureBox();
            txtKullaniciAdi = new TextBox();
            txtSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGiris = new Button();
            lblSifremiUnuttum = new Label();
            label3 = new Label();
            lblKayıtOlma = new Label();
            grpGirisEkranı = new GroupBox();
            btnGirisEkranıCıkıs = new Button();
            grpKayıtOlma = new GroupBox();
            btnGeriKayıtOlma = new Button();
            label15 = new Label();
            label14 = new Label();
            txtKaydetSoyadi = new TextBox();
            label13 = new Label();
            txtKaydetAdi = new TextBox();
            lable = new Label();
            txtKaydetDogrulama = new TextBox();
            btnKayıtKayıtOlma = new Button();
            label8 = new Label();
            label9 = new Label();
            txtSifreTekrarKayitOlma = new TextBox();
            txtSifreKayitOlma = new TextBox();
            txtKullaniciAdiKayitOlma = new TextBox();
            label11 = new Label();
            pictureBox3 = new PictureBox();
            grpSifirlama = new GroupBox();
            btnGeriSıfreSıfırla = new Button();
            txtKOD = new TextBox();
            label10 = new Label();
            btnKaydetSifreSıfırlama = new Button();
            label7 = new Label();
            btnKontrol = new Button();
            txtSifreSifirlaDogrulama = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txtSifreSifirlaTekrarSifre = new TextBox();
            txtSifreSifirlaSifre = new TextBox();
            txtSifreSifirlaKullanici = new TextBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpGirisEkranı.SuspendLayout();
            grpKayıtOlma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            grpSifirlama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(135, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(135, 122);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(125, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(135, 155);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(125, 27);
            txtSifre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 129);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 158);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(144, 234);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // lblSifremiUnuttum
            // 
            lblSifremiUnuttum.AutoSize = true;
            lblSifremiUnuttum.ForeColor = SystemColors.MenuHighlight;
            lblSifremiUnuttum.Location = new Point(72, 200);
            lblSifremiUnuttum.Name = "lblSifremiUnuttum";
            lblSifremiUnuttum.Size = new Size(117, 20);
            lblSifremiUnuttum.TabIndex = 6;
            lblSifremiUnuttum.Text = "Şifremi Unuttum";
            lblSifremiUnuttum.Click += lblSifremiUnuttum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 200);
            label3.Name = "label3";
            label3.Size = new Size(15, 20);
            label3.TabIndex = 7;
            label3.Text = "/";
            // 
            // lblKayıtOlma
            // 
            lblKayıtOlma.AutoSize = true;
            lblKayıtOlma.ForeColor = SystemColors.MenuHighlight;
            lblKayıtOlma.Location = new Point(195, 200);
            lblKayıtOlma.Name = "lblKayıtOlma";
            lblKayıtOlma.Size = new Size(82, 20);
            lblKayıtOlma.TabIndex = 8;
            lblKayıtOlma.Text = "Kayıt Olma";
            lblKayıtOlma.Click += lblKayıtOlma_Click;
            // 
            // grpGirisEkranı
            // 
            grpGirisEkranı.Controls.Add(btnGirisEkranıCıkıs);
            grpGirisEkranı.Controls.Add(pictureBox1);
            grpGirisEkranı.Controls.Add(lblKayıtOlma);
            grpGirisEkranı.Controls.Add(txtKullaniciAdi);
            grpGirisEkranı.Controls.Add(label3);
            grpGirisEkranı.Controls.Add(txtSifre);
            grpGirisEkranı.Controls.Add(lblSifremiUnuttum);
            grpGirisEkranı.Controls.Add(label1);
            grpGirisEkranı.Controls.Add(btnGiris);
            grpGirisEkranı.Controls.Add(label2);
            grpGirisEkranı.Location = new Point(45, 21);
            grpGirisEkranı.Name = "grpGirisEkranı";
            grpGirisEkranı.Size = new Size(402, 325);
            grpGirisEkranı.TabIndex = 9;
            grpGirisEkranı.TabStop = false;
            grpGirisEkranı.Text = "Giriş Ekranı";
            // 
            // btnGirisEkranıCıkıs
            // 
            btnGirisEkranıCıkıs.Location = new Point(144, 271);
            btnGirisEkranıCıkıs.Name = "btnGirisEkranıCıkıs";
            btnGirisEkranıCıkıs.Size = new Size(94, 29);
            btnGirisEkranıCıkıs.TabIndex = 9;
            btnGirisEkranıCıkıs.Text = "Çıkış";
            btnGirisEkranıCıkıs.UseVisualStyleBackColor = true;
            btnGirisEkranıCıkıs.Click += btnGirisEkranıCıkıs_Click;
            // 
            // grpKayıtOlma
            // 
            grpKayıtOlma.Controls.Add(btnGeriKayıtOlma);
            grpKayıtOlma.Controls.Add(label15);
            grpKayıtOlma.Controls.Add(label14);
            grpKayıtOlma.Controls.Add(txtKaydetSoyadi);
            grpKayıtOlma.Controls.Add(label13);
            grpKayıtOlma.Controls.Add(txtKaydetAdi);
            grpKayıtOlma.Controls.Add(lable);
            grpKayıtOlma.Controls.Add(txtKaydetDogrulama);
            grpKayıtOlma.Controls.Add(btnKayıtKayıtOlma);
            grpKayıtOlma.Controls.Add(label8);
            grpKayıtOlma.Controls.Add(label9);
            grpKayıtOlma.Controls.Add(txtSifreTekrarKayitOlma);
            grpKayıtOlma.Controls.Add(txtSifreKayitOlma);
            grpKayıtOlma.Controls.Add(txtKullaniciAdiKayitOlma);
            grpKayıtOlma.Controls.Add(label11);
            grpKayıtOlma.Controls.Add(pictureBox3);
            grpKayıtOlma.Location = new Point(45, 6);
            grpKayıtOlma.Name = "grpKayıtOlma";
            grpKayıtOlma.Size = new Size(464, 478);
            grpKayıtOlma.TabIndex = 11;
            grpKayıtOlma.TabStop = false;
            grpKayıtOlma.Text = "Kayıt Olma";
            grpKayıtOlma.Visible = false;
            // 
            // btnGeriKayıtOlma
            // 
            btnGeriKayıtOlma.Location = new Point(189, 380);
            btnGeriKayıtOlma.Name = "btnGeriKayıtOlma";
            btnGeriKayıtOlma.Size = new Size(94, 29);
            btnGeriKayıtOlma.TabIndex = 26;
            btnGeriKayıtOlma.Text = "Geri";
            btnGeriKayıtOlma.UseVisualStyleBackColor = true;
            btnGeriKayıtOlma.Click += btnGeriKayıtOlma_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(309, 238);
            label15.Name = "label15";
            label15.Size = new Size(132, 20);
            label15.TabIndex = 28;
            label15.Text = "Doğrulama Sorusu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(115, 305);
            label14.Name = "label14";
            label14.Size = new Size(57, 20);
            label14.TabIndex = 27;
            label14.Text = "Soyadı:";
            // 
            // txtKaydetSoyadi
            // 
            txtKaydetSoyadi.Location = new Point(178, 301);
            txtKaydetSoyadi.Name = "txtKaydetSoyadi";
            txtKaydetSoyadi.Size = new Size(125, 27);
            txtKaydetSoyadi.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(137, 272);
            label13.Name = "label13";
            label13.Size = new Size(35, 20);
            label13.TabIndex = 25;
            label13.Text = "Adı:";
            // 
            // txtKaydetAdi
            // 
            txtKaydetAdi.Location = new Point(178, 268);
            txtKaydetAdi.Name = "txtKaydetAdi";
            txtKaydetAdi.Size = new Size(125, 27);
            txtKaydetAdi.TabIndex = 24;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(47, 239);
            lable.Name = "lable";
            lable.Size = new Size(125, 20);
            lable.TabIndex = 19;
            lable.Text = "En Sevdiğin Renk:";
            // 
            // txtKaydetDogrulama
            // 
            txtKaydetDogrulama.Location = new Point(178, 235);
            txtKaydetDogrulama.Name = "txtKaydetDogrulama";
            txtKaydetDogrulama.Size = new Size(125, 27);
            txtKaydetDogrulama.TabIndex = 18;
            // 
            // btnKayıtKayıtOlma
            // 
            btnKayıtKayıtOlma.Location = new Point(189, 345);
            btnKayıtKayıtOlma.Name = "btnKayıtKayıtOlma";
            btnKayıtKayıtOlma.Size = new Size(94, 29);
            btnKayıtKayıtOlma.TabIndex = 17;
            btnKayıtKayıtOlma.Text = "Kaydet";
            btnKayıtKayıtOlma.UseVisualStyleBackColor = true;
            btnKayıtKayıtOlma.Click += btnKayıtKayıtOlma_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 204);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 16;
            label8.Text = "Şifre Tekrar:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 169);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 15;
            label9.Text = "Şifre:";
            // 
            // txtSifreTekrarKayitOlma
            // 
            txtSifreTekrarKayitOlma.Location = new Point(178, 200);
            txtSifreTekrarKayitOlma.Name = "txtSifreTekrarKayitOlma";
            txtSifreTekrarKayitOlma.Size = new Size(125, 27);
            txtSifreTekrarKayitOlma.TabIndex = 14;
            // 
            // txtSifreKayitOlma
            // 
            txtSifreKayitOlma.Location = new Point(178, 165);
            txtSifreKayitOlma.Name = "txtSifreKayitOlma";
            txtSifreKayitOlma.Size = new Size(125, 27);
            txtSifreKayitOlma.TabIndex = 13;
            // 
            // txtKullaniciAdiKayitOlma
            // 
            txtKullaniciAdiKayitOlma.Location = new Point(178, 132);
            txtKullaniciAdiKayitOlma.Name = "txtKullaniciAdiKayitOlma";
            txtKullaniciAdiKayitOlma.Size = new Size(125, 27);
            txtKullaniciAdiKayitOlma.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(77, 140);
            label11.Name = "label11";
            label11.Size = new Size(95, 20);
            label11.TabIndex = 10;
            label11.Text = "Kullanıcı Adı:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(178, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // grpSifirlama
            // 
            grpSifirlama.Controls.Add(btnGeriSıfreSıfırla);
            grpSifirlama.Controls.Add(txtKOD);
            grpSifirlama.Controls.Add(label10);
            grpSifirlama.Controls.Add(btnKaydetSifreSıfırlama);
            grpSifirlama.Controls.Add(label7);
            grpSifirlama.Controls.Add(btnKontrol);
            grpSifirlama.Controls.Add(txtSifreSifirlaDogrulama);
            grpSifirlama.Controls.Add(label4);
            grpSifirlama.Controls.Add(label5);
            grpSifirlama.Controls.Add(txtSifreSifirlaTekrarSifre);
            grpSifirlama.Controls.Add(txtSifreSifirlaSifre);
            grpSifirlama.Controls.Add(txtSifreSifirlaKullanici);
            grpSifirlama.Controls.Add(label6);
            grpSifirlama.Controls.Add(pictureBox2);
            grpSifirlama.Location = new Point(28, 18);
            grpSifirlama.Name = "grpSifirlama";
            grpSifirlama.Size = new Size(362, 478);
            grpSifirlama.TabIndex = 18;
            grpSifirlama.TabStop = false;
            grpSifirlama.Text = "Şifre Sıfırlama";
            grpSifirlama.Visible = false;
            // 
            // btnGeriSıfreSıfırla
            // 
            btnGeriSıfreSıfırla.Location = new Point(141, 433);
            btnGeriSıfreSıfırla.Name = "btnGeriSıfreSıfırla";
            btnGeriSıfreSıfırla.Size = new Size(94, 29);
            btnGeriSıfreSıfırla.TabIndex = 25;
            btnGeriSıfreSıfırla.Text = "Geri";
            btnGeriSıfreSıfırla.UseVisualStyleBackColor = true;
            btnGeriSıfreSıfırla.Click += btnGeriSıfreSıfırla_Click;
            // 
            // txtKOD
            // 
            txtKOD.Location = new Point(141, 244);
            txtKOD.Name = "txtKOD";
            txtKOD.Size = new Size(125, 27);
            txtKOD.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Stencil", 18F, FontStyle.Italic | FontStyle.Strikeout, GraphicsUnit.Point);
            label10.Location = new Point(132, 204);
            label10.Name = "label10";
            label10.Size = new Size(138, 35);
            label10.TabIndex = 23;
            label10.Text = "label10";
            // 
            // btnKaydetSifreSıfırlama
            // 
            btnKaydetSifreSıfırlama.Location = new Point(141, 398);
            btnKaydetSifreSıfırlama.Name = "btnKaydetSifreSıfırlama";
            btnKaydetSifreSıfırlama.Size = new Size(94, 29);
            btnKaydetSifreSıfırlama.TabIndex = 22;
            btnKaydetSifreSıfırlama.Text = "Kaydet";
            btnKaydetSifreSıfırlama.UseVisualStyleBackColor = true;
            btnKaydetSifreSıfırlama.Visible = false;
            btnKaydetSifreSıfırlama.Click += btnKaydetSifreSıfırlama_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 176);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 21;
            label7.Text = "En Sevdiğin Renk:";
            // 
            // btnKontrol
            // 
            btnKontrol.Location = new Point(153, 277);
            btnKontrol.Name = "btnKontrol";
            btnKontrol.Size = new Size(94, 29);
            btnKontrol.TabIndex = 17;
            btnKontrol.Text = "Kontrol";
            btnKontrol.UseVisualStyleBackColor = true;
            btnKontrol.Click += btnKontrol_Click;
            // 
            // txtSifreSifirlaDogrulama
            // 
            txtSifreSifirlaDogrulama.Location = new Point(141, 173);
            txtSifreSifirlaDogrulama.Name = "txtSifreSifirlaDogrulama";
            txtSifreSifirlaDogrulama.Size = new Size(125, 27);
            txtSifreSifirlaDogrulama.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 356);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 16;
            label4.Text = "Şifre Tekrar:";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(93, 323);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 15;
            label5.Text = "Şifre:";
            label5.Visible = false;
            // 
            // txtSifreSifirlaTekrarSifre
            // 
            txtSifreSifirlaTekrarSifre.Location = new Point(141, 356);
            txtSifreSifirlaTekrarSifre.Name = "txtSifreSifirlaTekrarSifre";
            txtSifreSifirlaTekrarSifre.Size = new Size(125, 27);
            txtSifreSifirlaTekrarSifre.TabIndex = 14;
            txtSifreSifirlaTekrarSifre.Visible = false;
            // 
            // txtSifreSifirlaSifre
            // 
            txtSifreSifirlaSifre.Location = new Point(141, 323);
            txtSifreSifirlaSifre.Name = "txtSifreSifirlaSifre";
            txtSifreSifirlaSifre.Size = new Size(125, 27);
            txtSifreSifirlaSifre.TabIndex = 13;
            txtSifreSifirlaSifre.Visible = false;
            // 
            // txtSifreSifirlaKullanici
            // 
            txtSifreSifirlaKullanici.Location = new Point(141, 140);
            txtSifreSifirlaKullanici.Name = "txtSifreSifirlaKullanici";
            txtSifreSifirlaKullanici.Size = new Size(125, 27);
            txtSifreSifirlaKullanici.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 144);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 10;
            label6.Text = "Kullanıcı Adı:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(141, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(582, 548);
            Controls.Add(grpSifirlama);
            Controls.Add(grpKayıtOlma);
            Controls.Add(grpGirisEkranı);
            Name = "frmLogin";
            Text = "Giriş Ekranı";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpGirisEkranı.ResumeLayout(false);
            grpGirisEkranı.PerformLayout();
            grpKayıtOlma.ResumeLayout(false);
            grpKayıtOlma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            grpSifirlama.ResumeLayout(false);
            grpSifirlama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtKullaniciAdi;
        private TextBox txtSifre;
        private Label label1;
        private Label label2;
        private Button btnGiris;
        private Label lblSifremiUnuttum;
        private Label label3;
        private Label lblKayıtOlma;
        private GroupBox grpGirisEkranı;
        private TextBox txtSifreTekrarSifreSifirlama;
        private Label lable;
        private GroupBox grpKayıtOlma;
        private Button btnKayıtKayıtOlma;
        private Label label8;
        private Label label9;
        private TextBox txtSifreTekrarKayitOlma;
        private TextBox txtSifreKayitOlma;
        private TextBox txtKullaniciAdiKayitOlma;
        private Label label11;
        private PictureBox pictureBox3;
        private GroupBox grpSifirlama;
        private Button btnKontrol;
        private Label label4;
        private Label label5;
        private TextBox txtSifreSifirlaTekrarSifre;
        private TextBox txtSifreSifirlaSifre;
        private TextBox txtSifreSifirlaKullanici;
        private Label label6;
        private PictureBox pictureBox2;
        private TextBox txtKaydetDogrulama;
        private Label label7;
        private TextBox txtSifreSifirlaDogrulama;
        private Button btnKaydetSifreSıfırlama;
        private Label label14;
        private TextBox txtKaydetSoyadi;
        private Label label13;
        private TextBox txtKaydetAdi;
        private Label label15;
        private Label label10;
        private TextBox txtKOD;
        private Button btnGeriKayıtOlma;
        private Button btnGeriSıfreSıfırla;
        private Button btnGirisEkranıCıkıs;
    }
}