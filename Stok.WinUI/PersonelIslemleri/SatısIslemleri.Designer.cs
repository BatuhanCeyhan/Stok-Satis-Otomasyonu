namespace Stok.WinUI.PersonelIslemleri
{
    partial class SatısIslemleri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            bilgiToolStripMenuItem = new ToolStripMenuItem();
            silToolStripMenuItem = new ToolStripMenuItem();
            txtAra = new TextBox();
            label1 = new Label();
            btnAra = new Button();
            label2 = new Label();
            rbUrun = new RadioButton();
            rbSatıs = new RadioButton();
            txtSatisUrunAdi = new TextBox();
            txtSatisBirimFiyati = new TextBox();
            txtSatisUrunAdedi = new TextBox();
            txtSatisSatisyeri = new TextBox();
            txtSatisToplamFiyat = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSatis = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            txtSatisFaturaKodu = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            cmbUrunVarmı = new ComboBox();
            txtUrunNotu = new TextBox();
            txtUrunFiyati = new TextBox();
            txtUrunAdedi = new TextBox();
            txtUrunAdi = new TextBox();
            pbFotograf = new PictureBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(3, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(878, 394);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { bilgiToolStripMenuItem, silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(109, 52);
            // 
            // bilgiToolStripMenuItem
            // 
            bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            bilgiToolStripMenuItem.Size = new Size(108, 24);
            bilgiToolStripMenuItem.Text = "Bilgi";
            bilgiToolStripMenuItem.Click += bilgiToolStripMenuItem_Click;
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(108, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(84, 82);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 85);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 2;
            label1.Text = "Arama:";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(215, 81);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 3;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(708, 11);
            label2.Name = "label2";
            label2.Size = new Size(199, 38);
            label2.TabIndex = 4;
            label2.Text = "Satış İşlemleri";
            // 
            // rbUrun
            // 
            rbUrun.AutoSize = true;
            rbUrun.Location = new Point(615, 81);
            rbUrun.Name = "rbUrun";
            rbUrun.Size = new Size(105, 24);
            rbUrun.TabIndex = 5;
            rbUrun.TabStop = true;
            rbUrun.Text = "Ürün Listesi";
            rbUrun.UseVisualStyleBackColor = true;
            rbUrun.CheckedChanged += rbUrun_CheckedChanged;
            // 
            // rbSatıs
            // 
            rbSatıs.AutoSize = true;
            rbSatıs.Location = new Point(738, 81);
            rbSatıs.Name = "rbSatıs";
            rbSatıs.Size = new Size(105, 24);
            rbSatıs.TabIndex = 6;
            rbSatıs.TabStop = true;
            rbSatıs.Text = "Satış Listesi";
            rbSatıs.UseVisualStyleBackColor = true;
            rbSatıs.CheckedChanged += rbSatıs_CheckedChanged;
            // 
            // txtSatisUrunAdi
            // 
            txtSatisUrunAdi.Enabled = false;
            txtSatisUrunAdi.Location = new Point(134, 35);
            txtSatisUrunAdi.Name = "txtSatisUrunAdi";
            txtSatisUrunAdi.Size = new Size(125, 27);
            txtSatisUrunAdi.TabIndex = 7;
            // 
            // txtSatisBirimFiyati
            // 
            txtSatisBirimFiyati.Enabled = false;
            txtSatisBirimFiyati.Location = new Point(134, 77);
            txtSatisBirimFiyati.Name = "txtSatisBirimFiyati";
            txtSatisBirimFiyati.Size = new Size(125, 27);
            txtSatisBirimFiyati.TabIndex = 8;
            // 
            // txtSatisUrunAdedi
            // 
            txtSatisUrunAdedi.Enabled = false;
            txtSatisUrunAdedi.Location = new Point(134, 122);
            txtSatisUrunAdedi.Name = "txtSatisUrunAdedi";
            txtSatisUrunAdedi.Size = new Size(125, 27);
            txtSatisUrunAdedi.TabIndex = 9;
            // 
            // txtSatisSatisyeri
            // 
            txtSatisSatisyeri.Enabled = false;
            txtSatisSatisyeri.Location = new Point(134, 168);
            txtSatisSatisyeri.Name = "txtSatisSatisyeri";
            txtSatisSatisyeri.Size = new Size(125, 27);
            txtSatisSatisyeri.TabIndex = 10;
            // 
            // txtSatisToplamFiyat
            // 
            txtSatisToplamFiyat.Enabled = false;
            txtSatisToplamFiyat.Location = new Point(134, 210);
            txtSatisToplamFiyat.Name = "txtSatisToplamFiyat";
            txtSatisToplamFiyat.Size = new Size(125, 27);
            txtSatisToplamFiyat.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 38);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Ürün Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 80);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 13;
            label4.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 125);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 14;
            label5.Text = "Ürün Adedi:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 171);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 15;
            label6.Text = "Satış Yeri:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(0, 212);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 16;
            label7.Text = "Toplam Satış Fiyat:";
            // 
            // btnSatis
            // 
            btnSatis.Location = new Point(143, 294);
            btnSatis.Name = "btnSatis";
            btnSatis.Size = new Size(94, 65);
            btnSatis.TabIndex = 17;
            btnSatis.Text = "Satış Gerçekleştir";
            btnSatis.UseVisualStyleBackColor = true;
            btnSatis.Visible = false;
            btnSatis.Click += btnSatis_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtSatisFaturaKodu);
            groupBox1.Controls.Add(txtSatisUrunAdi);
            groupBox1.Controls.Add(btnSatis);
            groupBox1.Controls.Add(txtSatisBirimFiyati);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtSatisUrunAdedi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtSatisSatisyeri);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSatisToplamFiyat);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(1397, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 550);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Satış";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 252);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 20;
            label10.Text = "Fatura Kodu:";
            // 
            // txtSatisFaturaKodu
            // 
            txtSatisFaturaKodu.Enabled = false;
            txtSatisFaturaKodu.Location = new Point(134, 248);
            txtSatisFaturaKodu.Name = "txtSatisFaturaKodu";
            txtSatisFaturaKodu.Size = new Size(125, 27);
            txtSatisFaturaKodu.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 494);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 65;
            label8.Text = "Ürün Var mı?: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(32, 482);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 64;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(63, 330);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 62;
            label11.Text = "Ürün Not:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(53, 301);
            label12.Name = "label12";
            label12.Size = new Size(82, 20);
            label12.TabIndex = 61;
            label12.Text = "Ürün Fiyatı:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(48, 255);
            label13.Name = "label13";
            label13.Size = new Size(87, 20);
            label13.TabIndex = 60;
            label13.Text = "Ürün Adedi:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(65, 212);
            label14.Name = "label14";
            label14.Size = new Size(70, 20);
            label14.TabIndex = 59;
            label14.Text = "Ürün Adı:";
            // 
            // cmbUrunVarmı
            // 
            cmbUrunVarmı.Enabled = false;
            cmbUrunVarmı.FormattingEnabled = true;
            cmbUrunVarmı.Items.AddRange(new object[] { "Var", "Yok" });
            cmbUrunVarmı.Location = new Point(138, 491);
            cmbUrunVarmı.Name = "cmbUrunVarmı";
            cmbUrunVarmı.Size = new Size(151, 28);
            cmbUrunVarmı.TabIndex = 58;
            // 
            // txtUrunNotu
            // 
            txtUrunNotu.Enabled = false;
            txtUrunNotu.Location = new Point(138, 327);
            txtUrunNotu.Multiline = true;
            txtUrunNotu.Name = "txtUrunNotu";
            txtUrunNotu.Size = new Size(280, 143);
            txtUrunNotu.TabIndex = 56;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Enabled = false;
            txtUrunFiyati.Location = new Point(138, 294);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(151, 27);
            txtUrunFiyati.TabIndex = 55;
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Enabled = false;
            txtUrunAdedi.Location = new Point(138, 252);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(151, 27);
            txtUrunAdedi.TabIndex = 54;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Enabled = false;
            txtUrunAdi.Location = new Point(138, 209);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(151, 27);
            txtUrunAdi.TabIndex = 53;
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(123, 38);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(182, 144);
            pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotograf.TabIndex = 51;
            pbFotograf.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pbFotograf);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtUrunAdi);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtUrunAdedi);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtUrunFiyati);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtUrunNotu);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(cmbUrunVarmı);
            groupBox2.Controls.Add(label14);
            groupBox2.Location = new Point(939, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 550);
            groupBox2.TabIndex = 66;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Bilgileri";
            // 
            // SatısIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(rbSatıs);
            Controls.Add(rbUrun);
            Controls.Add(label2);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Controls.Add(dataGridView1);
            Name = "SatısIslemleri";
            Size = new Size(1856, 665);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtAra;
        private Label label1;
        private Button btnAra;
        private Label label2;
        private RadioButton rbUrun;
        private RadioButton rbSatıs;
        private TextBox txtSatisUrunAdi;
        private TextBox txtSatisBirimFiyati;
        private TextBox txtSatisUrunAdedi;
        private TextBox txtSatisSatisyeri;
        private TextBox txtSatisToplamFiyat;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSatis;
        private GroupBox groupBox1;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cmbUrunVarmı;
        private TextBox txtUrunNotu;
        private TextBox txtUrunFiyati;
        private TextBox txtUrunAdedi;
        private TextBox txtUrunAdi;
        private PictureBox pbFotograf;
        private GroupBox groupBox2;
        private Label label10;
        private TextBox txtSatisFaturaKodu;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem bilgiToolStripMenuItem;
        private ToolStripMenuItem silToolStripMenuItem;
    }
}
