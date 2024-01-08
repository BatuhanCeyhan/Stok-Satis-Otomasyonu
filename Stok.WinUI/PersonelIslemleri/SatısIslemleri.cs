using Stok.Bussinuss.Abstract;
using Core.CrossCuttingConcern.Utility;
using Stok.Bussinuss.Concrete;
using Stok.DataAccsess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stok.Model.Entity_Framework;

namespace Stok.WinUI.PersonelIslemleri
{
    public partial class SatısIslemleri : UserControl
    {
        ISatısBs satisBs;
        IUrunBs urunBs;
        string FaturaKodu;
        public Urun UrunGuncelle { get; set; }
        public SatısIslemleri(IUrunBs _urunBs, ISatısBs _satisBS)
        {
            this.satisBs = _satisBS;
            this.urunBs = _urunBs;
            InitializeComponent();

        }

        public void UrunVerileriCekme()
        {
            dataGridView1.DataSource = urunBs.GetAll(x=>x.Aktif=="Var");


        }
        public void SatisVerileriCekme()
        {
            dataGridView1.DataSource = satisBs.GetAll();

        }


        private void rbUrun_CheckedChanged(object sender, EventArgs e)
        {
            UrunVerileriCekme();
            contextMenuStrip1.Enabled = false;
        }

        private void rbSatıs_CheckedChanged(object sender, EventArgs e)
        {
            SatisVerileriCekme();
            contextMenuStrip1.Enabled = true;
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
        public void FaturaKoduYaratma()
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(65, 122);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            FaturaKodu = StrBuild.ToString();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (rbUrun.Checked == true)
            {
                Urun UrunBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Urun;
                txtUrunAdi.Text = UrunBilgi.UrunAdi;
                txtUrunAdedi.Text = UrunBilgi.UrunAdedi.ToString();
                txtUrunFiyati.Text = UrunBilgi.UrunFiyati.ToString();
                txtUrunNotu.Text = UrunBilgi.UrunNotu;
                cmbUrunVarmı.Text = UrunBilgi.Aktif;
                pbFotograf.ImageLocation = Application.StartupPath + UrunBilgi.Resim;



                txtSatisUrunAdi.Text = UrunBilgi.UrunAdi;
                txtSatisBirimFiyati.Text = UrunBilgi.UrunFiyati.ToString();
                UrunGuncelle = UrunBilgi;
                btnSatis.Visible = true;
                txtSatisFaturaKodu.Visible = false;
                label10.Visible = false;
                txtSatisToplamFiyat.Visible = false;
                label7.Visible = false;
                txtSatisUrunAdedi.Enabled = true;
                txtSatisSatisyeri.Enabled = true;
                txtSatisToplamFiyat.Enabled = true;



            }
            else
            {
                Satıs satısBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Satıs;

                txtSatisUrunAdi.Text = satısBilgi.SatisUrunAdi;
                txtSatisBirimFiyati.Text = satısBilgi.SatisUrunFiyati.ToString();
                txtSatisUrunAdedi.Text = satısBilgi.SatisUrunAdedi.ToString();
                txtSatisSatisyeri.Text = satısBilgi.SatısYerleri.ToString();
                txtSatisToplamFiyat.Text = satısBilgi.ToplamSatıs.ToString();
                txtSatisFaturaKodu.Text = satısBilgi.FaturaKodu.ToString();
                btnSatis.Visible = false;
                txtSatisFaturaKodu.Visible = true;
                label10.Visible = true;
                txtSatisToplamFiyat.Visible = true;
                label7.Visible = true;
                txtSatisUrunAdedi.Enabled = false;
                txtSatisSatisyeri.Enabled = false;
                txtSatisToplamFiyat.Enabled = false;
                txtSatisFaturaKodu.Enabled = false;

            }


        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            decimal ToplamFiyatSatis;
            int yeniUrunAdedi;


            Satıs satisKaydet = new Satıs();

            satisKaydet.SatisUrunAdi = txtSatisUrunAdi.Text;
            satisKaydet.SatisUrunFiyati = Convert.ToDecimal(txtSatisBirimFiyati.Text);
            satisKaydet.SatisUrunAdedi = Convert.ToInt32(txtSatisUrunAdedi.Text);
            satisKaydet.SatısYerleri = txtSatisSatisyeri.Text;
            satisKaydet.Tarih = DateTime.Now;

            ToplamFiyatSatis = Convert.ToDecimal(txtSatisBirimFiyati.Text) * Convert.ToDecimal(txtSatisUrunAdedi.Text);
            satisKaydet.ToplamSatıs = ToplamFiyatSatis;

            FaturaKoduYaratma();
            satisKaydet.FaturaKodu = FaturaKodu;

            Urun urun = UrunGuncelle;
            yeniUrunAdedi = Convert.ToInt32(txtUrunAdedi.Text) - Convert.ToInt32(txtSatisUrunAdedi.Text);
            urun.UrunAdedi = yeniUrunAdedi;

            if (urun.UrunAdedi > 0)
            {
                satisBs.Insert(satisKaydet);
                urunBs.Update(urun);
            }
            else if (urun.UrunAdedi == 0)
            {
                MessageBox.Show("Ürün Adedi 0 olmuştur", "Ürün Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                urun.Aktif = "Yok";
                satisBs.Insert(satisKaydet);
                urunBs.Update(urun);
            }
            else
            {
                MessageBox.Show("Yeterli Ürün Bulunmamaktadır", "Ürün Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SatisVerileriCekme();
            UrunVerileriCekme();



        }


        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Satıs satısBilgi = dataGridView1.SelectedRows[0].DataBoundItem as Satıs;

            txtSatisUrunAdi.Text = satısBilgi.SatisUrunAdi;
            txtSatisBirimFiyati.Text = satısBilgi.SatisUrunFiyati.ToString();
            txtSatisUrunAdedi.Text = satısBilgi.SatisUrunAdedi.ToString();
            txtSatisSatisyeri.Text = satısBilgi.SatısYerleri.ToString();
            txtSatisToplamFiyat.Text = satısBilgi.ToplamSatıs.ToString();
            txtSatisFaturaKodu.Text = satısBilgi.FaturaKodu.ToString();
            btnSatis.Visible = false;
            txtSatisFaturaKodu.Visible = true;
            label10.Visible = true;
            txtSatisToplamFiyat.Visible = true;
            label7.Visible = true;
            txtSatisUrunAdedi.Enabled = false;
            txtSatisSatisyeri.Enabled = false;
            txtSatisToplamFiyat.Enabled = false;
            txtSatisFaturaKodu.Enabled = false;


        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satıs satisSil = dataGridView1.SelectedRows[0].DataBoundItem as Satıs;

            if (satisSil != null)
            {

                DialogResult dr = MessageBox.Show($"{satisSil.SatisUrunAdi} Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Satıs SilinecekSatis = satisBs.Get(x => x.ID == satisSil.ID);
                    satisBs.Delete(SilinecekSatis);
                    SatisVerileriCekme();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }
        }
    }
}
