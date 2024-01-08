using Core.CrossCuttingConcern.Utility;
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
    public partial class UrunIslemleri : UserControl
    {
        IUrunBs urunbs;
        string photopath;
        public string Islem1 { get; set; }
        public Urun Urun1 { get; set; }

        public UrunIslemleri(IUrunBs _urunbs)
        {
            urunbs = _urunbs;
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Urun1 == null)
            {
                Urun urunEkleme = new Urun();

                urunEkleme.Aktif = cmbUrunVarmı.Text;
                urunEkleme.UrunAdi = txtUrunAdi.Text;
                urunEkleme.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
                urunEkleme.UrunNotu = txtUrunNotu.Text;
                urunEkleme.UrunAdedi = Convert.ToInt32(txtUrunAdedi.Text);
                urunEkleme.Resim = photopath;
                urunEkleme.Aktif = cmbUrunVarmı.Text;

                urunbs.Insert(urunEkleme);
                MessageBox.Show("Ürün Başarılı Bir Şekilde Eklenmiştir ", "Ürün Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriAl();
            }
            else
            {
                Urun UrunGuncelleme = Urun1;

                UrunGuncelleme.UrunAdi = txtUrunAdi.Text;
                UrunGuncelleme.UrunFiyati = Convert.ToDecimal(txtUrunFiyati.Text);
                UrunGuncelleme.UrunNotu = txtUrunNotu.Text;
                UrunGuncelleme.UrunAdedi = Convert.ToInt32(txtUrunAdedi.Text);
                UrunGuncelleme.Resim = photopath;
                UrunGuncelleme.Aktif = cmbUrunVarmı.Text;

                urunbs.Update(UrunGuncelleme);
                MessageBox.Show("Ürün Başarılı Bir Şekilde Güncellenmiştir ", "Ürün Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriAl();

            }
        }

        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            VerileriAl();
            if (Islem1 == "UrunBilgi")
            {
                label8.Text = "Ürün Bilgileri";
                txtUrunAdi.Enabled = false;
                txtUrunAdedi.Enabled = false;
                txtUrunFiyati.Enabled = false;
                txtUrunNotu.Enabled = false;
                cmbUrunVarmı.Enabled = false;
                btnKaydet.Visible = false;
                btnResimEkle.Visible = false;


            }
            else if (Islem1 == "UrunSilme")
            {
                label8.Text = "Ürün Silme";
                dataGridView1.Dock = DockStyle.Fill;
            }
            else if (Islem1 == "UrunGuncelleme")
            {
                label8.Text = "Ürün Güncelleme";

            }
            else
            {
                label8.Text = "Ürün Ekleme";
            }
        }
        public void VerileriAl()
        {
            dataGridView1.DataSource = urunbs.GetAll();
            dataGridView1.Columns[5].Visible = false;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {

                string extension = Path.GetExtension(openFileDialog1.FileName).ToLower();
                if (extension == ".jpg" || extension == ".jpge" || extension == ".png")
                {
                    string filename = RandomValueGenerator.GenerateFileName(extension);

                    photopath = "/images/Urun/" + filename;

                    string destination = Application.StartupPath + photopath;

                    File.Copy(openFileDialog1.FileName, destination);

                    pbFotograf.ImageLocation = destination;
                }
                else
                {
                    MessageBox.Show("Lütfen Sadece Resim Seçiniz..");
                }

            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun urunsil = dataGridView1.SelectedRows[0].DataBoundItem as Urun;

            if (urunsil != null)
            {

                DialogResult dr = MessageBox.Show($"{urunsil.UrunAdi} Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Urun SilinecekUrun = urunbs.Get(x => x.ID == urunsil.ID);
                    urunbs.Delete(SilinecekUrun);
                    VerileriAl();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun UrunBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            txtUrunAdi.Text = UrunBilgi.UrunAdi;
            txtUrunAdedi.Text = UrunBilgi.UrunAdedi.ToString();
            txtUrunFiyati.Text = UrunBilgi.UrunFiyati.ToString();
            txtUrunNotu.Text = UrunBilgi.UrunNotu;
            cmbUrunVarmı.Text = UrunBilgi.Aktif;
            pbFotograf.ImageLocation = Application.StartupPath + UrunBilgi.Resim;

            txtUrunAdi.Enabled = false;
            txtUrunAdedi.Enabled = false;
            txtUrunFiyati.Enabled = false;
            txtUrunNotu.Enabled = false;
            cmbUrunVarmı.Enabled = false;
            btnKaydet.Visible = false;
            btnResimEkle.Visible = false;
            label8.Text = "Ürün Bilgi";



        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urun UrunGuncelleme = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
            txtUrunAdi.Text = UrunGuncelleme.UrunAdi;
            txtUrunAdedi.Text = UrunGuncelleme.UrunAdedi.ToString();
            txtUrunFiyati.Text = UrunGuncelleme.UrunFiyati.ToString();
            txtUrunNotu.Text = UrunGuncelleme.UrunNotu;
            cmbUrunVarmı.Text = UrunGuncelleme.Aktif;
            pbFotograf.ImageLocation = Application.StartupPath + UrunGuncelleme.Resim;

            label8.Text = "Ürün Güncelleme";
            Urun1 = UrunGuncelleme;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (Islem1 == "UrunGuncelleme")
            {
                Urun UrunGuncelleme = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
                txtUrunAdi.Text = UrunGuncelleme.UrunAdi;
                txtUrunAdedi.Text = UrunGuncelleme.UrunAdedi.ToString();
                txtUrunFiyati.Text = UrunGuncelleme.UrunFiyati.ToString();
                txtUrunNotu.Text = UrunGuncelleme.UrunNotu;
                cmbUrunVarmı.Text = UrunGuncelleme.Aktif;
                pbFotograf.ImageLocation = Application.StartupPath + UrunGuncelleme.Resim;

                Urun1 = UrunGuncelleme;
            }
            else
            {
                Urun UrunBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
                txtUrunAdi.Text = UrunBilgi.UrunAdi;
                txtUrunAdedi.Text = UrunBilgi.UrunAdedi.ToString();
                txtUrunFiyati.Text = UrunBilgi.UrunFiyati.ToString();
                txtUrunNotu.Text = UrunBilgi.UrunNotu;
                cmbUrunVarmı.Text = UrunBilgi.Aktif;
                pbFotograf.ImageLocation = Application.StartupPath + UrunBilgi.Resim;


            }

        }
    }
}
