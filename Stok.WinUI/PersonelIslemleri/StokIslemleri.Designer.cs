namespace Stok.WinUI.PersonelIslemleri
{
    partial class StokIslemleri
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
            lblArama = new Label();
            txtArama = new TextBox();
            txtAra = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1169, 438);
            dataGridView1.TabIndex = 0;
            // 
            // lblArama
            // 
            lblArama.AutoSize = true;
            lblArama.Location = new Point(14, 88);
            lblArama.Name = "lblArama";
            lblArama.Size = new Size(56, 20);
            lblArama.TabIndex = 1;
            lblArama.Text = "Arama:";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(69, 86);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 2;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(200, 88);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(94, 29);
            txtAra.TabIndex = 3;
            txtAra.Text = "Ara";
            txtAra.UseVisualStyleBackColor = true;
            txtAra.Click += txtAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(506, 16);
            label1.Name = "label1";
            label1.Size = new Size(170, 38);
            label1.TabIndex = 4;
            label1.Text = "Ürün Listesi";
            // 
            // StokIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(txtAra);
            Controls.Add(txtArama);
            Controls.Add(lblArama);
            Controls.Add(dataGridView1);
            Name = "StokIslemleri";
            Size = new Size(1169, 561);
            Load += StokIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblArama;
        private TextBox txtArama;
        private Button txtAra;
        private Label label1;
    }
}
