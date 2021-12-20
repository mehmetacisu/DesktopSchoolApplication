using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulSistemi
{
    public partial class FormOgretmenIslemleri : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        string fotografAdi = "";
        string path = "";
        public FormOgretmenIslemleri()
        {
            InitializeComponent();
            label_Message.Text = "";
            OgretmenleriGetir();
            Temizlee();
            GridAyarlariniGetir();
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_Ogretmenler.Columns[0].Width = 50;
            dataGridView_Ogretmenler.Columns[3].Width = 137;
            dataGridView_Ogretmenler.Columns[4].Width = 170;
        }

        private void Temizlee()
        {
            try
            {
                textBox_Id.Text = "";
                textBox_Ad.Text = "";
                textBox_Soyad.Text = "";
                textBox_KAdi.Text = "";
                textBox_Mail.Text = "";
                textBox_Sifre.Text = "";
                comboBox_Durum.Text = "Durumunu Seçiniz";
                pictureBox_OgretmenFotograf.Image = null;
                button_Guncelle.Enabled = false;
                button_Sil.Enabled = false;
                button_Temizle.Enabled = false;
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Temizleme işlemi başarısız : " + hata.Message;
            }
        }

        private void OgretmenleriGetir()
        {
            try
            {
                dataGridView_Ogretmenler.DataSource = db.tblOgretmen.AsNoTracking()
                    .Select(o => new
                    {
                        Id = o.Id,
                        Ad = o.Ad,
                        Soyad = o.Soyad,
                        KullaniciAdi = o.KullaniciAdi,
                        Mail = o.Mail,
                        Sifre = o.Sifre,
                        Resim = o.Resim,
                        Durum = o.Durum == "A" ? "Aktif" : "Pasif"
                    }).ToList();
                dataGridView_Ogretmenler.Columns["Resim"].Visible = false;
            }
            catch (Exception hata)
            {
                label_Message.Text = "Öğretmenler Listelenirken Hata : " + hata.Message;
            }
        }

        private void button_FSec_Click(object sender, EventArgs e)
        {
            string defaultPath = @"C:\";
            try
            {
                defaultPath = @"C:\";

            }
            catch (Exception hata)
            {
                label_Message.Text = hata.Message;
            }
            using (OpenFileDialog fotografSec = new OpenFileDialog())
            {
                fotografSec.Title = "Fotoğraf Seçimi";
                fotografSec.Filter = "Fotograf Türleri (*.gif; *.jpg; *.jpeg; *.png; *bmp) | *.gif;*.jpg;*.jpeg;*.png;*bmp";
                fotografSec.InitialDirectory = defaultPath;
                DialogResult pencere = fotografSec.ShowDialog();
                if (pencere == DialogResult.OK)
                {
                    string yol = fotografSec.FileName.ToString().Substring(0, fotografSec.FileName.ToString().LastIndexOf("\\"));
                    Registry.CurrentUser.SetValue("Resim", yol);
                    pictureBox_OgretmenFotograf.Image = Image.FromFile(fotografSec.FileName);
                    fotografAdi = Path.GetFileName(fotografSec.FileName);
                }
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizlee();
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            tblOgretmen ogretmen = new tblOgretmen();
            try
            {
                if (textBox_Ad.Text == "" || string.IsNullOrEmpty(textBox_Ad.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Adı boş olamaz.";
                }
                else if (textBox_Soyad.Text == "" || string.IsNullOrEmpty(textBox_Soyad.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Soyadı boş olamaz.";
                }
                else if (textBox_KAdi.Text == "" || string.IsNullOrEmpty(textBox_KAdi.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Kullanıcı Adı boş olamaz.";
                }
                else if (textBox_Sifre.Text == "" || string.IsNullOrEmpty(textBox_Sifre.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Şifre boş olamaz.";
                }
                else if (textBox_Mail.Text == "" || string.IsNullOrEmpty(textBox_Mail.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Mail boş olamaz.";
                }
                else if (comboBox_Durum.Text == "Durumunu Seçiniz")
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Durum Boş Olamaz";
                }
                else if (pictureBox_OgretmenFotograf.Image == null)
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Fotoğraf seçmelisiniz.";
                }
                else
                {
                    var kAdiVarMi = db.tblOgretmen.Where(o => o.KullaniciAdi == textBox_KAdi.Text).Count();
                    var mailVarMi = db.tblOgretmen.Where(o => o.Mail == textBox_Mail.Text).Count();
                    if (kAdiVarMi >= 1)
                    {
                        label_Message.Text = "Bu kullanıcı adıyla kayıt bulunmaktadır.";
                    }
                    else if (mailVarMi >= 1)
                    {
                        label_Message.Text = "Bu mail adresiye kayıt bulunmaktadır.";
                    }
                    else
                    {
                        if (comboBox_Durum.SelectedItem.ToString() == "Aktif")
                        {
                            ogretmen.Durum = "A";

                        }
                        else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                        {
                            ogretmen.Durum = "P";
                        }
                        path = "";
                        path = @"..\..\Fotograflar\";
                        Random rnd = new Random();
                        if (File.Exists(path))
                        {
                            path += @"\";
                            if (!File.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                            }
                        }
                        else
                        {
                            path += @"\";
                            Directory.CreateDirectory(path);
                        }
                        fotografAdi = fotografAdi.Split('.')[0] + rnd.Next(999999) + ".jpeg"; ;
                        path = path + "\\" + fotografAdi;
                        pictureBox_OgretmenFotograf.Image.Save(path, ImageFormat.Jpeg);
                        ogretmen.Ad = textBox_Ad.Text;
                        ogretmen.Soyad = textBox_Soyad.Text;
                        ogretmen.KullaniciAdi = textBox_KAdi.Text;
                        ogretmen.Sifre = textBox_Sifre.Text;
                        ogretmen.Mail = textBox_Mail.Text;
                        ogretmen.Resim = @"..\..\Fotograflar\" + fotografAdi;
                        db.tblOgretmen.Add(ogretmen);
                        db.SaveChanges();
                        label_Message.ForeColor = Color.White;
                        label_Message.Text = "Öğretmen başarıyla eklendi.";
                        OgretmenleriGetir();
                        Temizlee();
                    }

                }
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Öğretmen eklerken Hata oluştu : " + hata.Message;
            }
        }

        private void dataGridView_Ogretmenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Id.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Id"].Value.ToString();
                textBox_Ad.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Ad"].Value.ToString();
                textBox_Soyad.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Soyad"].Value.ToString();
                textBox_KAdi.Text = dataGridView_Ogretmenler.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
                textBox_Mail.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Mail"].Value.ToString();
                textBox_Sifre.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Sifre"].Value.ToString();
                comboBox_Durum.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Durum"].Value.ToString();
                pictureBox_OgretmenFotograf.Image = Image.FromFile(dataGridView_Ogretmenler.CurrentRow.Cells["Resim"].Value.ToString());
                label_Message.Text = "";
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Öğretmen Bilgileri Getirilirken Hata : " + hata.Message; ;
            }
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "0" || textBox_Id.Text == "")
            {
                button_Guncelle.Enabled = false;
                button_Sil.Enabled = false;
                button_Temizle.Enabled = false;
                button_FSec.Enabled = true;
            }
            else
            {
                button_Guncelle.Enabled = true;
                button_Sil.Enabled = true;
                button_Temizle.Enabled = true;
                button_FSec.Enabled = false;
            }
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_Id.Text);
                db.tblOgretmen.Remove(db.tblOgretmen.Find(id));
                db.SaveChanges();
                label_Message.ForeColor = Color.White;
                label_Message.Text = "Silme işlemi başarılı.";
                OgretmenleriGetir();
                Temizlee();
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Silme işlemi başarısız : " + hata.Message;
            }
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_Id.Text);
                tblOgretmen ogretmen = db.tblOgretmen.Find(id);
                ogretmen.Ad = textBox_Ad.Text;
                ogretmen.Soyad = textBox_Soyad.Text;
                ogretmen.KullaniciAdi = textBox_KAdi.Text;
                ogretmen.Mail = textBox_Mail.Text;
                ogretmen.Sifre = textBox_Sifre.Text;
                if (comboBox_Durum.SelectedItem.ToString() == "Aktif")
                {
                    ogretmen.Durum = "A";

                }
                else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                {
                    ogretmen.Durum = "P";
                }
                db.SaveChanges();
                label_Message.ForeColor = Color.White;
                label_Message.Text = "Güncelleme başarılı.";
                OgretmenleriGetir();
                Temizlee();
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Güncelleme işlemi başarısız : " + hata.Message;
            }
        }
        private void textBox_Arama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Arama.Text))
            {
                OgretmenleriGetir();
            }
            else
            {
                try
                {
                    dataGridView_Ogretmenler.DataSource = db.tblOgretmen.AsNoTracking().Select(
                       s => new
                       {
                           Id = s.Id,
                           Ad = s.Ad,
                           Soyad = s.Soyad,
                           KullaniciAdi = s.KullaniciAdi,
                           Mail = s.Mail,
                           Sifre = s.Sifre,
                           Resim = s.Resim,
                           Durum = s.Durum == "A" ? "Aktif" : "Pasif"
                       }
                       ).Where(r => r.KullaniciAdi.Contains(textBox_Arama.Text)).ToList();
                }
                catch (Exception hata)
                {
                    label_Message.Text = "Arama sırasında hata : " + hata.Message;
                }
            }
        }

        private void dataGridView_Ogretmenler_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Id.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Id"].Value.ToString();
                textBox_Ad.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Ad"].Value.ToString();
                textBox_Soyad.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Soyad"].Value.ToString();
                textBox_KAdi.Text = dataGridView_Ogretmenler.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
                textBox_Mail.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Mail"].Value.ToString();
                textBox_Sifre.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Sifre"].Value.ToString();
                comboBox_Durum.Text = dataGridView_Ogretmenler.CurrentRow.Cells["Durum"].Value.ToString();
                pictureBox_OgretmenFotograf.Image = Image.FromFile(dataGridView_Ogretmenler.CurrentRow.Cells["Resim"].Value.ToString());
                label_Message.Text = "";
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Öğretmen Bilgileri Getirilirken Hata : " + hata.Message;
            }
        }
    }
}
