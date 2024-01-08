namespace Stok.WinUI
{
    partial class frmPersonel
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
            menuStrip1 = new MenuStrip();
            ürünİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünSilToolStripMenuItem = new ToolStripMenuItem();
            ürünGüncelleToolStripMenuItem = new ToolStripMenuItem();
            ürünBilgileriToolStripMenuItem = new ToolStripMenuItem();
            satışİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            stokToolStripMenuItem = new ToolStripMenuItem();
            iadeİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ürünİşlemleriToolStripMenuItem, satışİşlemleriToolStripMenuItem, stokToolStripMenuItem, iadeİşlemleriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1300, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ürünİşlemleriToolStripMenuItem
            // 
            ürünİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem, ürünSilToolStripMenuItem, ürünGüncelleToolStripMenuItem, ürünBilgileriToolStripMenuItem });
            ürünİşlemleriToolStripMenuItem.Name = "ürünİşlemleriToolStripMenuItem";
            ürünİşlemleriToolStripMenuItem.Size = new Size(114, 24);
            ürünİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(184, 26);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ürünSilToolStripMenuItem
            // 
            ürünSilToolStripMenuItem.Name = "ürünSilToolStripMenuItem";
            ürünSilToolStripMenuItem.Size = new Size(184, 26);
            ürünSilToolStripMenuItem.Text = "Ürün Sil";
            ürünSilToolStripMenuItem.Click += ürünSilToolStripMenuItem_Click;
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            ürünGüncelleToolStripMenuItem.Size = new Size(184, 26);
            ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            ürünGüncelleToolStripMenuItem.Click += ürünGüncelleToolStripMenuItem_Click;
            // 
            // ürünBilgileriToolStripMenuItem
            // 
            ürünBilgileriToolStripMenuItem.Name = "ürünBilgileriToolStripMenuItem";
            ürünBilgileriToolStripMenuItem.Size = new Size(184, 26);
            ürünBilgileriToolStripMenuItem.Text = "Ürün Bilgileri";
            ürünBilgileriToolStripMenuItem.Click += ürünBilgileriToolStripMenuItem_Click;
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            satışİşlemleriToolStripMenuItem.Size = new Size(114, 24);
            satışİşlemleriToolStripMenuItem.Text = "Satış İşlemleri";
            satışİşlemleriToolStripMenuItem.Click += satışİşlemleriToolStripMenuItem_Click;
            // 
            // stokToolStripMenuItem
            // 
            stokToolStripMenuItem.Name = "stokToolStripMenuItem";
            stokToolStripMenuItem.Size = new Size(52, 24);
            stokToolStripMenuItem.Text = "Stok";
            stokToolStripMenuItem.Click += stokToolStripMenuItem_Click;
            // 
            // iadeİşlemleriToolStripMenuItem
            // 
            iadeİşlemleriToolStripMenuItem.Name = "iadeİşlemleriToolStripMenuItem";
            iadeİşlemleriToolStripMenuItem.Size = new Size(112, 24);
            iadeİşlemleriToolStripMenuItem.Text = "İade İşlemleri";
            iadeİşlemleriToolStripMenuItem.Click += iadeİşlemleriToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 1027);
            panel1.TabIndex = 1;
            // 
            // frmPersonel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 1055);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPersonel";
            Text = "Personel";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ürünİşlemleriToolStripMenuItem;
        private ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private ToolStripMenuItem stokToolStripMenuItem;
        private ToolStripMenuItem iadeİşlemleriToolStripMenuItem;
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünSilToolStripMenuItem;
        private ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private ToolStripMenuItem ürünBilgileriToolStripMenuItem;
        private Panel panel1;
    }
}