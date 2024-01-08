
using Stok.WinUI.PersonelIslemleri;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok.WinUI
{
    public partial class frmPersonel : Form
    {

        public frmPersonel()
        {
            InitializeComponent();
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UrunIslemleri urunIslemleri = FormFactory.CreateUrunIslem();
            urunIslemleri.Islem1 = "UrunEkleme";
            panel1.Controls.Add(urunIslemleri);

        }

        private void ürünSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UrunIslemleri urunIslemleri = FormFactory.CreateUrunIslem();
            urunIslemleri.Islem1 = "UrunSilme";
            panel1.Controls.Add(urunIslemleri);

        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UrunIslemleri urunIslemleri = FormFactory.CreateUrunIslem();
            urunIslemleri.Islem1 = "UrunGuncelleme";
            panel1.Controls.Add(urunIslemleri);
        }

        private void ürünBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UrunIslemleri urunIslemleri = FormFactory.CreateUrunIslem();
            urunIslemleri.Islem1 = "UrunBilgi";
            panel1.Controls.Add(urunIslemleri);
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            SatısIslemleri satısIslemleri = FormFactory.CreateSatisIslemleri();
            panel1.Controls.Add(satısIslemleri);
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            StokIslemleri stokIslemleri = FormFactory.CreateStokIslemleri();
            panel1.Controls.Add(stokIslemleri);
        }

        private void iadeİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            IadeIslemleri ıadeIslemleri = FormFactory.CreateIadeIslemleri();
            panel1.Controls.Add(ıadeIslemleri);
        }
    }
}
