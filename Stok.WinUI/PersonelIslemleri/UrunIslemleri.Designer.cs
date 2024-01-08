namespace Stok.WinUI.PersonelIslemleri
{
    partial class UrunIslemleri
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
            label8 = new Label();
            btnKaydet = new Button();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbUrunVarmı = new ComboBox();
            txtUrunNotu = new TextBox();
            txtUrunFiyati = new TextBox();
            txtUrunAdedi = new TextBox();
            txtUrunAdi = new TextBox();
            btnResimEkle = new Button();
            pbFotograf = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            bilgiToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(444, 14);
            label8.Name = "label8";
            label8.Size = new Size(206, 41);
            label8.TabIndex = 52;
            label8.Text = "Ürün Ekleme";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(537, 451);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 51;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(639, 367);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 50;
            label7.Text = "Ürün Var mı?: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(739, 367);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(667, 203);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 47;
            label4.Text = "Ürün Not:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 174);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 46;
            label3.Text = "Ürün Fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(652, 128);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 45;
            label2.Text = "Ürün Adedi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(669, 85);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 44;
            label1.Text = "Ürün Adı:";
            // 
            // cmbUrunVarmı
            // 
            cmbUrunVarmı.FormattingEnabled = true;
            cmbUrunVarmı.Items.AddRange(new object[] { "Var", "Yok" });
            cmbUrunVarmı.Location = new Point(742, 364);
            cmbUrunVarmı.Name = "cmbUrunVarmı";
            cmbUrunVarmı.Size = new Size(151, 28);
            cmbUrunVarmı.TabIndex = 43;
            // 
            // txtUrunNotu
            // 
            txtUrunNotu.Location = new Point(742, 200);
            txtUrunNotu.Multiline = true;
            txtUrunNotu.Name = "txtUrunNotu";
            txtUrunNotu.Size = new Size(280, 143);
            txtUrunNotu.TabIndex = 41;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(742, 167);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(151, 27);
            txtUrunFiyati.TabIndex = 40;
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Location = new Point(742, 125);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(151, 27);
            txtUrunAdedi.TabIndex = 39;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(742, 82);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(151, 27);
            txtUrunAdi.TabIndex = 38;
            // 
            // btnResimEkle
            // 
            btnResimEkle.Location = new Point(269, 241);
            btnResimEkle.Name = "btnResimEkle";
            btnResimEkle.Size = new Size(94, 29);
            btnResimEkle.TabIndex = 37;
            btnResimEkle.Text = "Resim Ekle";
            btnResimEkle.UseVisualStyleBackColor = true;
            btnResimEkle.Click += btnResimEkle_Click;
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(231, 82);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(182, 144);
            pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotograf.TabIndex = 36;
            pbFotograf.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 509);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1220, 356);
            dataGridView1.TabIndex = 53;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, bilgiToolStripMenuItem, güncelleToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(136, 76);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(135, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // bilgiToolStripMenuItem
            // 
            bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            bilgiToolStripMenuItem.Size = new Size(135, 24);
            bilgiToolStripMenuItem.Text = "Bilgi";
            bilgiToolStripMenuItem.Click += bilgiToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(135, 24);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // UrunIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(btnKaydet);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbUrunVarmı);
            Controls.Add(txtUrunNotu);
            Controls.Add(txtUrunFiyati);
            Controls.Add(txtUrunAdedi);
            Controls.Add(txtUrunAdi);
            Controls.Add(btnResimEkle);
            Controls.Add(pbFotograf);
            Name = "UrunIslemleri";
            Size = new Size(1220, 865);
            Load += UrunIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button btnKaydet;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbUrunVarmı;
        private TextBox txtUrunNotu;
        private TextBox txtUrunFiyati;
        private TextBox txtUrunAdedi;
        private TextBox txtUrunAdi;
        private Button btnResimEkle;
        private PictureBox pbFotograf;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem bilgiToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
    }
}
