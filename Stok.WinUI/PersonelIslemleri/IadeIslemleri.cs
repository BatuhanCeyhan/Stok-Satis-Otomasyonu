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

namespace Stok.WinUI.PersonelIslemleri
{
    public partial class IadeIslemleri : UserControl
    {
        IUrunBs urunBs;

        public Urun Urun1 { get; set; }
        public IadeIslemleri(IUrunBs _urunBs)
        {

            urunBs = _urunBs;
            InitializeComponent();
            VerileriAl();
        }
        public void VerileriAl()
        {
            dataGridView1.DataSource = urunBs.GetAll();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string Aratxt = txtAra.Text.Trim().ToUpper();

            int j = -1;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)

            {

                foreach (DataGridViewRow row in dataGridView1.Rows)

                {

                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)

                    {

                        if (cell.Value != null)

                        {

                            if (cell.Value.ToString().ToUpper() == Aratxt)

                            {
                                cell.Style.BackColor = Color.Yellow;

                                j = 0;

                                break;
                            }
                        }
                    }
                }
            }
            if (j == -1)

            {
                MessageBox.Show("Kayıt bulunamadı!", "Bulunamadı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Urun UrunBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            txtUrunAdi.Text = UrunBilgi.UrunAdi;
            txtUrunAdedi.Text = UrunBilgi.UrunAdedi.ToString();
            txtUrunFiyati.Text = UrunBilgi.UrunFiyati.ToString();
            txtUrunNotu.Text = UrunBilgi.UrunNotu;
            cmbUrunVarmı.Text = UrunBilgi.Aktif;
            pbFotograf.ImageLocation = Application.StartupPath + UrunBilgi.Resim;
            

            Urun1= UrunBilgi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Urun UrunGuncelleme = Urun1;

            UrunGuncelleme.UrunAdi = txtUrunAdi.Text;
            UrunGuncelleme.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
            UrunGuncelleme.UrunNotu = txtUrunNotu.Text;
            UrunGuncelleme.UrunAdedi = Convert.ToInt32(txtUrunAdedi.Text);

            if (UrunGuncelleme.UrunAdedi > 0)
            {
                UrunGuncelleme.Aktif = "Var";
            }
            else
            {
                UrunGuncelleme.Aktif = "Yok";
            }

            urunBs.Update(UrunGuncelleme);
            MessageBox.Show("İade Başarılı Bir Şekilde Olmuştur ", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            VerileriAl();
        }
    }
}
