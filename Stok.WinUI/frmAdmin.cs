using Stok.Bussinuss.Abstract;
using Stok.Bussinuss.Concrete;
using Stok.Model.Entity_Framework;
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
    public partial class frmAdmin : Form
    {
        IGirisBs girisBs;

        public frmAdmin(IGirisBs _girisBs)
        {
            girisBs = _girisBs;

            InitializeComponent();
        }
        public void VerileriCekme()
        {
            dataGridView1.DataSource = girisBs.GetAll();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            VerileriCekme();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris Personel = dataGridView1.SelectedRows[0].DataBoundItem as Giris;

            if (Personel != null)
            {

                DialogResult dr = MessageBox.Show($"{Personel.Adi} {Personel.Soyadi} Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Giris SilinecekPersonel = girisBs.Get(x => x.ID == Personel.ID);
                    girisBs.Delete(SilinecekPersonel);
                    VerileriCekme();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelIslem frmPersonelIslem = FormFactory.CreatefrmPersonelIslem();
            frmPersonelIslem.ShowDialog();
            // this.Close();
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Giris Personel = dataGridView1.SelectedRows[0].DataBoundItem as Giris;
            frmPersonelIslem frmPersonelIslem = FormFactory.CreatefrmPersonelIslem();
            frmPersonelIslem.PersonelBilgi = Personel;
            frmPersonelIslem.Islem = "Bilgi";
            frmPersonelIslem.Show();

        }


        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giris Personel = dataGridView1.SelectedRows[0].DataBoundItem as Giris;
            frmPersonelIslem frmPersonelIslem = FormFactory.CreatefrmPersonelIslem();
            frmPersonelIslem.PersonelBilgi = Personel;
            frmPersonelIslem.Show();
            //this.Close();

        }
    }
}
