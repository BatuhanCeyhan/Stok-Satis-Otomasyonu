using Stok.Bussinuss.Abstract;
using Stok.Model.Entity_Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Stok.WinUI
{
    public partial class frmLogin : Form
    {
        IGirisBs girisBs;
        public Giris Giris1 { get; set; }
        public string KOD { get; set; }

        public frmLogin(IGirisBs _girisBs)
        {
            girisBs = _girisBs;
            InitializeComponent();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            string KullanıcıAdi = txtKullaniciAdi.Text;
            string Sifre = txtSifre.Text;

            Giris Personel = girisBs.Get(x => x.KullaniciAdi == KullanıcıAdi && x.Sifre == Sifre && x.RolID == 1);
            Giris Admin = girisBs.Get(x => x.KullaniciAdi == KullanıcıAdi && x.Sifre == Sifre && x.RolID == 2);

            if (Personel != null)
            {
                frmPersonel frmPersonel = FormFactory.CreatefrmPersonel();
                frmPersonel.Show();
                this.Hide();


            }
            else if (Admin != null)
            {
                frmAdmin frmAdmin = FormFactory.CreatefrmAdmin();
                frmAdmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Kullanıcı Adı Geçersiz", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKullaniciAdi.Clear();
                txtSifre.Clear();
                txtKullaniciAdi.Focus();
            }

        }


        private void lblSifremiUnuttum_Click(object sender, EventArgs e)
        {
            grpSifirlama.Visible = true;
            grpGirisEkranı.Visible = false;

        }

        private void lblKayıtOlma_Click(object sender, EventArgs e)
        {
            grpGirisEkranı.Visible = false;
            grpKayıtOlma.Visible = true;

        }

        private void btnKayıtKayıtOlma_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            if (txtSifreKayitOlma.Text == txtSifreTekrarKayitOlma.Text)
            {
                giris.Sifre = txtSifreKayitOlma.Text;
            }
            else
            {
                MessageBox.Show("Şifreler Birbiri İle Aynı Değil", "Şifre Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            giris.KullaniciAdi = txtKullaniciAdiKayitOlma.Text;
            giris.RolID = 1;
            giris.Dogrulama = txtKaydetDogrulama.Text;
            giris.Adi = txtKaydetAdi.Text;
            giris.Soyadi = txtKaydetSoyadi.Text;



            girisBs.Insert(giris);

            MessageBox.Show("Başarılı Bir Şekilde Kayıt Olundu", "Kayıt Olma", MessageBoxButtons.OK, MessageBoxIcon.Information);
            grpKayıtOlma.Visible = false;
            grpGirisEkranı.Visible = true;

        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            string Kullanici = txtSifreSifirlaKullanici.Text;
            string Dogrulama = txtSifreSifirlaDogrulama.Text;

            Giris Personel = girisBs.Get(x => x.KullaniciAdi == Kullanici && x.Dogrulama == Dogrulama);
            if (KOD == txtKOD.Text)
            {
                if (Personel != null)
                {

                    label5.Visible = true;
                    label4.Visible = true;
                    txtSifreSifirlaSifre.Visible = true;
                    txtSifreSifirlaTekrarSifre.Visible = true;
                    btnKaydetSifreSıfırlama.Visible = true;
                    txtSifreSifirlaKullanici.Enabled = false;
                    txtSifreSifirlaDogrulama.Enabled = false;
                    Giris1 = Personel;

                }
                else
                {
                    MessageBox.Show("Doğrulama Veya Kullanıcı Adı Hatası", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Kod Hatalı Lütfen Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtKOD.Clear();
                txtSifreSifirlaKullanici.Focus();
            }

        }

        private void btnKaydetSifreSıfırlama_Click(object sender, EventArgs e)
        {
            Giris Giris = Giris1;
            if (Giris1 != null)
            {
                if (txtSifreSifirlaSifre.Text == txtSifreSifirlaTekrarSifre.Text)
                {
                    Giris.KullaniciAdi = txtSifreSifirlaKullanici.Text;
                    Giris.Dogrulama = txtSifreSifirlaDogrulama.Text;
                    Giris.RolID = 1;
                    Giris.Sifre = txtSifreSifirlaSifre.Text;
                    girisBs.Update(Giris);

                    MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Şifresi Değiştirildi", "Şifre Değiştirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    grpSifirlama.Visible = false;
                    grpGirisEkranı.Visible = true;
                }
                else
                {
                    MessageBox.Show("Şifreler Birbiri İle Benzer Değil", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(65, 122);
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            label10.Text = StrBuild.ToString();

            KOD = label10.Text;

        }

        private void btnGeriSıfreSıfırla_Click(object sender, EventArgs e)
        {
            txtSifreSifirlaKullanici.Clear();
            txtSifreSifirlaDogrulama.Clear();
            txtKOD.Clear();
            txtSifreSifirlaSifre.Clear();
            txtSifreSifirlaTekrarSifre.Clear();
            grpGirisEkranı.Visible = true;
            grpSifirlama.Visible = false;
        }

        private void btnGeriKayıtOlma_Click(object sender, EventArgs e)
        {
            txtKullaniciAdiKayitOlma.Clear();
            txtSifreKayitOlma.Clear();
            txtSifreTekrarKayitOlma.Clear();
            txtKaydetDogrulama.Clear();
            txtKaydetAdi.Clear();
            txtKaydetSoyadi.Clear();
            grpGirisEkranı.Visible = true;
            grpKayıtOlma.Visible = false;
        }

        private void btnGirisEkranıCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
