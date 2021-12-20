using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class FormSifremiUnuttum : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormSifremiUnuttum()
        {
            InitializeComponent();
            label_Message.Text = "";
        }

        private void button_Gonder_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Mail.Text == "" || string.IsNullOrEmpty(textBox_Mail.Text))
                {
                    label_Message.Text = "Mail adresinizi giriniz.";
                }
                else
                {
                    var ogrenci = db.tblOgrenci.Where(ogrnc => ogrnc.Mail == textBox_Mail.Text || ogrnc.KullaniciAdi == textBox_Mail.Text).FirstOrDefault();
                    var ogretmen = db.tblOgretmen.Where(o => o.Mail == textBox_Mail.Text || o.KullaniciAdi == textBox_Mail.Text).FirstOrDefault();
                    var admin = db.tblAdmin.Where(p => p.Mail == textBox_Mail.Text || p.KullaniciAdi == textBox_Mail.Text).FirstOrDefault();

                    if (ogrenci != null && ogrenci.Durum == "A")
                    {
                        MailGonder(textBox_Mail.Text,
                            "Sevgili Öğrencimiz : " + ogrenci.Ad + " " + ogrenci.Soyad + " " +
                            "Şifreniz: " + ogrenci.Sifre);
                        label_Message.Text = "Şifreniz Mailinize gönderilmiştir.";
                    }
                    else if (ogretmen != null && ogretmen.Durum == "A")
                    {
                        MailGonder(textBox_Mail.Text,
                           "Sayın Öğretmenimiz : " + ogretmen.Ad + " " + ogretmen.Soyad
                           + "Şifreniz: " + ogretmen.Sifre);
                        label_Message.Text = "Şifreniz Mailinize gönderilmiştir.";
                    }
                    else if (admin != null && admin.Durum == "A")
                    {
                        MailGonder(textBox_Mail.Text,
                         "Sayın Yöneticimiz  : " + admin.Ad + " " + admin.Soyad
                         + "Şifreniz: " + admin.Sifre);
                        label_Message.Text = "Şifreniz Mailinize gönderilmiştir.";
                    }
                    else
                    {
                        label_Message.Text = "Böyle bir kullanıcı bulunmamaktadır.";
                    }
                }
            }
            catch (Exception hata)
            {

                label_Message.Text = "Mail gönderilirken hata : " + hata.Message;
            }

        }

        public void MailGonder(string user, string icerik)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(user);
            mail.From = new MailAddress("Mail Adress", "Okul Sistemi");
            mail.Subject = "Okul Sistemi Şifre Talebi";
            mail.Body = icerik;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential(System.Configuration.ConfigurationSettings.AppSettings["Email"], System.Configuration.ConfigurationSettings.AppSettings["Parola"]);
            smtp.Send(mail);
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormGiris frmGrs = new FormGiris();
            frmGrs.Show();
        }
    }
}
