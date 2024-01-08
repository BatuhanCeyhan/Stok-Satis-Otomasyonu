namespace Stok.WinUI.PersonelIslemleri
{
    partial class IadeIslemleri
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
            dataGridView1 = new DataGridView();
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
            pbFotograf = new PictureBox();
            label5 = new Label();
            txtAra = new TextBox();
            btnAra = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(697, 460);
            dataGridView1.TabIndex = 0;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(519, 0);
            label8.Name = "label8";
            label8.Size = new Size(297, 41);
            label8.TabIndex = 67;
            label8.Text = "Ürün İade İşlemleri";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(962, 430);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 66;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(994, 364);
            label7.Name = "label7";
            label7.Size = new Size(100, 20);
            label7.TabIndex = 65;
            label7.Text = "Ürün Var mı?: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1094, 364);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 64;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1022, 200);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 63;
            label4.Text = "Ürün Not:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1012, 171);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 62;
            label3.Text = "Ürün Fiyatı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1007, 125);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 61;
            label2.Text = "Ürün Adedi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1024, 82);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 60;
            label1.Text = "Ürün Adı:";
            // 
            // cmbUrunVarmı
            // 
            cmbUrunVarmı.Enabled = false;
            cmbUrunVarmı.FormattingEnabled = true;
            cmbUrunVarmı.Items.AddRange(new object[] { "Var", "Yok" });
            cmbUrunVarmı.Location = new Point(1097, 361);
            cmbUrunVarmı.Name = "cmbUrunVarmı";
            cmbUrunVarmı.Size = new Size(151, 28);
            cmbUrunVarmı.TabIndex = 59;
            // 
            // txtUrunNotu
            // 
            txtUrunNotu.Enabled = false;
            txtUrunNotu.Location = new Point(1097, 197);
            txtUrunNotu.Multiline = true;
            txtUrunNotu.Name = "txtUrunNotu";
            txtUrunNotu.Size = new Size(280, 143);
            txtUrunNotu.TabIndex = 58;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Enabled = false;
            txtUrunFiyati.Location = new Point(1097, 164);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(151, 27);
            txtUrunFiyati.TabIndex = 57;
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Location = new Point(1097, 122);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(151, 27);
            txtUrunAdedi.TabIndex = 56;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Enabled = false;
            txtUrunAdi.Location = new Point(1097, 79);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(151, 27);
            txtUrunAdi.TabIndex = 55;
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(793, 76);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(182, 144);
            pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
            pbFotograf.TabIndex = 53;
            pbFotograf.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 51);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 68;
            label5.Text = "Arama:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(75, 49);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(125, 27);
            txtAra.TabIndex = 69;
            // 
            // btnAra
            // 
            btnAra.Location = new Point(206, 49);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(94, 29);
            btnAra.TabIndex = 70;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // IadeIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAra);
            Controls.Add(txtAra);
            Controls.Add(label5);
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
            Controls.Add(pbFotograf);
            Controls.Add(dataGridView1);
            Name = "IadeIslemleri";
            Size = new Size(1428, 545);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
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
        private PictureBox pbFotograf;
        private Label label5;
        private TextBox txtAra;
        private Button btnAra;
    }
}
