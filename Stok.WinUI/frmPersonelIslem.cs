using Stok.Bussinuss.Abstract;
using Stok.Bussinuss.Concrete;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok.WinUI
{
    public partial class frmPersonelIslem : Form
    {
        IGirisBs girisBs;
        public Giris PersonelBilgi { get; set; }
        public string Islem { get; set; }
        public frmPersonelIslem(IGirisBs _giriBs)
        {
            girisBs = _giriBs;
            InitializeComponent();
        }

        private void btnKayıtKayıtOlma_Click(object sender, EventArgs e)
        {
            if (PersonelBilgi == null)
            {
                Giris giris = new Giris();

                if (txtSifreKayitOlma.Text == txtSifreTekrarKayitOlma.Text)
                {
                    giris.KullaniciAdi = txtKullaniciAdiKayitOlma.Text;
                    giris.Adi = txtKaydetAdi.Text;
                    giris.Soyadi = txtKaydetSoyadi.Text;
                    giris.Dogrulama = txtKaydetDogrulama.Text;
                    giris.Sifre = txtSifreKayitOlma.Text;
                    giris.RolID = 1;

                    girisBs.Insert(giris);

                    frmAdmin frmAdmin = FormFactory.CreatefrmAdmin();
                    frmAdmin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen Şifreler Birbirleri İle Aynı Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtSifreKayitOlma.Text == txtSifreTekrarKayitOlma.Text)
                {
                    Giris girisguncelleme = PersonelBilgi;

                    girisguncelleme.KullaniciAdi = txtKullaniciAdiKayitOlma.Text;
                    girisguncelleme.Adi = txtKaydetAdi.Text;
                    girisguncelleme.Soyadi = txtKaydetSoyadi.Text;
                    girisguncelleme.Dogrulama = txtKaydetDogrulama.Text;
                    girisguncelleme.Sifre = txtSifreKayitOlma.Text;
                    girisguncelleme.RolID = 1;


                    girisBs.Update(girisguncelleme);
                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde  Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmAdmin frmAdmin = FormFactory.CreatefrmAdmin();
                    frmAdmin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Girilen Şifreler Birbirleri İle Aynı Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }




        }

        private void frmPersonelIslem_Load(object sender, EventArgs e)
        {
            if (Islem == "Bilgi")
            {
                if (PersonelBilgi != null)
                {
                    txtKaydetAdi.Text = PersonelBilgi.Adi;
                    txtKaydetSoyadi.Text = PersonelBilgi.Soyadi;
                    txtKullaniciAdiKayitOlma.Text = PersonelBilgi.KullaniciAdi;
                    txtSifreKayitOlma.Text = PersonelBilgi.Sifre;
                    txtKaydetDogrulama.Text = PersonelBilgi.Dogrulama;
                    txtSifreTekrarKayitOlma.Text = PersonelBilgi.Sifre;

                    btnKayıtKayıtOlma.Visible = false;
                    txtKaydetAdi.Enabled = false;
                    txtKaydetSoyadi.Enabled = false;
                    txtKullaniciAdiKayitOlma.Enabled = false;
                    txtSifreKayitOlma.Enabled = false;
                    txtKaydetDogrulama.Enabled = false;
                    txtSifreTekrarKayitOlma.Enabled = false;
                    grpKayıtOlma.Text = "Personel Bilgisi";


                }
            }
            else
            {
                if (PersonelBilgi != null)
                {
                    txtKaydetAdi.Text = PersonelBilgi.Adi;
                    txtKaydetSoyadi.Text = PersonelBilgi.Soyadi;
                    txtKullaniciAdiKayitOlma.Text = PersonelBilgi.KullaniciAdi;
                    txtSifreKayitOlma.Text = PersonelBilgi.Sifre;
                    txtKaydetDogrulama.Text = PersonelBilgi.Dogrulama;
                    txtSifreTekrarKayitOlma.Text = PersonelBilgi.Sifre;
                    btnKayıtKayıtOlma.Text = "Güncelle";

                    btnKayıtKayıtOlma.Visible = true;
                    txtKaydetAdi.Enabled = true;
                    txtKaydetSoyadi.Enabled = true;
                    txtKullaniciAdiKayitOlma.Enabled = true;
                    txtSifreKayitOlma.Enabled = true;
                    txtKaydetDogrulama.Enabled = true;
                    txtSifreTekrarKayitOlma.Enabled = true;
                    grpKayıtOlma.Text = "Personel Güncelleme";

                }
            }



        }
    }
}
