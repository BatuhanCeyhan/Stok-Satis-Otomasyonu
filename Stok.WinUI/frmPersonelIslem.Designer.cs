namespace Stok.WinUI
{
    partial class frmPersonelIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelIslem));
            grpKayıtOlma = new GroupBox();
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
            grpKayıtOlma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // grpKayıtOlma
            // 
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
            grpKayıtOlma.Location = new Point(31, 12);
            grpKayıtOlma.Name = "grpKayıtOlma";
            grpKayıtOlma.Size = new Size(464, 478);
            grpKayıtOlma.TabIndex = 12;
            grpKayıtOlma.TabStop = false;
            grpKayıtOlma.Text = "Peronel Kayıt Olma";
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
            // frmPersonelIslem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 521);
            Controls.Add(grpKayıtOlma);
            Name = "frmPersonelIslem";
            Text = "Personel İşlemi";
            Load += frmPersonelIslem_Load;
            grpKayıtOlma.ResumeLayout(false);
            grpKayıtOlma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpKayıtOlma;
        private Label label15;
        private Label label14;
        private TextBox txtKaydetSoyadi;
        private Label label13;
        private TextBox txtKaydetAdi;
        private Label lable;
        private TextBox txtKaydetDogrulama;
        private Button btnKayıtKayıtOlma;
        private Label label8;
        private Label label9;
        private TextBox txtSifreTekrarKayitOlma;
        private TextBox txtSifreKayitOlma;
        private TextBox txtKullaniciAdiKayitOlma;
        private Label label11;
        private PictureBox pictureBox3;
    }
}