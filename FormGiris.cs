using OkulSistemi.Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class FormGiris : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormGiris()
        {
            InitializeComponent();
            label_Message.Text = "";
        }

        private void button_Giris_Click(object sender, EventArgs e)
        {
            var ogrenci = db.tblOgrenci.Where(ogrnc => ogrnc.KullaniciAdi == textBox_KAdiMail.Text || ogrnc.Mail == textBox_KAdiMail.Text && ogrnc.Sifre == textBox_Sifre.Text).FirstOrDefault();
            var ogretmen = db.tblOgretmen.Where(o => o.KullaniciAdi == textBox_KAdiMail.Text || o.Mail == textBox_KAdiMail.Text && o.Sifre == textBox_Sifre.Text).FirstOrDefault();
            var admin = db.tblAdmin.Where(a => a.KullaniciAdi == textBox_KAdiMail.Text || a.Mail == textBox_KAdiMail.Text && a.Sifre == textBox_Sifre.Text).FirstOrDefault();

            if (textBox_KAdiMail.Text == "" || string.IsNullOrEmpty(textBox_KAdiMail.Text))
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Kullanıcı adınızı veya Mail adresinizi giriniz.";
            }
            else if (textBox_Sifre.Text == "" || string.IsNullOrEmpty(textBox_Sifre.Text))
            {
                label_Message.Text = "Şifrenizi giriniz.";
            }
            else if (ogrenci != null && (ogrenci.KullaniciAdi == textBox_KAdiMail.Text || ogrenci.Mail == textBox_KAdiMail.Text) && ogrenci.Sifre == textBox_Sifre.Text && ogrenci.Durum == "A")
            {
                Login.Id = ogrenci.Id;
                Login.Ad = ogrenci.Ad;
                Login.Soyad = ogrenci.Soyad;
                Login.Mail = ogrenci.Mail;
                Login.KullaniciAdi = ogrenci.KullaniciAdi;
                Login.Sifre = ogrenci.Sifre;
                FormOgrenci formOgrenci = new FormOgrenci();
                formOgrenci.Show();
                this.Hide();
                textBox_KAdiMail.Text = "";
                textBox_Sifre.Text = "";
            }
            else if (ogretmen != null && (ogretmen.KullaniciAdi == textBox_KAdiMail.Text || ogretmen.Mail == textBox_KAdiMail.Text) && ogretmen.Sifre == textBox_Sifre.Text && ogretmen.Durum == "A")
            {
                Login.Id = ogretmen.Id;
                Login.Ad = ogretmen.Ad;
                Login.Soyad = ogretmen.Soyad;
                Login.Mail = ogretmen.Mail;
                Login.KullaniciAdi = ogretmen.KullaniciAdi;
                Login.Sifre = ogretmen.Sifre;
                FormOgretmen formOgretmen = new FormOgretmen();
                formOgretmen.Show();
                this.Hide();
                textBox_KAdiMail.Text = "";
                textBox_Sifre.Text = "";
            }
            else if (admin!= null && (admin.KullaniciAdi == textBox_KAdiMail.Text || admin.Mail == textBox_KAdiMail.Text) && admin.Sifre == textBox_Sifre.Text && admin.Durum =="A")
            {
                Login.Id = admin.Id;
                Login.Ad = admin.Ad;
                Login.Soyad = admin.Soyad;
                Login.Mail = admin.Mail;
                Login.KullaniciAdi = admin.KullaniciAdi;
                Login.Sifre = admin.Sifre;
                this.Hide();
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                textBox_KAdiMail.Text = "";
                textBox_Sifre.Text = "";
            }
            else
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Kullanıcı bilgileri hatalı.";
            }
        }

        private void linkLabel_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            FormSifremiUnuttum frmSifre = new FormSifremiUnuttum();
            this.Hide();
            frmSifre.Show();

        }
        private void pictureBox_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}