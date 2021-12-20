using Microsoft.Win32;
using OkulSistemi.Islemler;
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
    public partial class FormOgrenciIslemler : Form
    {

        string fotografAdi = "";
        string path = "";
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormOgrenciIslemler()
        {
            InitializeComponent();
            label_Message.Text = "";
            OgrencileriGetir();
            Temizle();
            dataGridView_Ogrenciler.Columns[3].Width = 155;
        }

        private void OgrencileriGetir()
        {
            try
            {
                dataGridView_Ogrenciler.DataSource = db.tblOgrenci.AsNoTracking()
                    .Select(s => new
                    {
                        Id = s.Id,
                        Ad = s.Ad,
                        Soyad = s.Soyad,
                        KullaniciAdi = s.KullaniciAdi,
                        Mail = s.Mail,
                        Sifre = s.Sifre,
                        Resim = s.Resim,
                        Durum = s.Durum == "A" ? "Aktif" : "Pasif"
                    })
                .ToList();
                dataGridView_Ogrenciler.Columns["Resim"].Visible = false;
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Öğrenciler Listenlirken Hata :" + hata.Message;
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
                    pictureBox_OgrenciFotograf.Image = Image.FromFile(fotografSec.FileName);
                    fotografAdi = Path.GetFileName(fotografSec.FileName);
                }
            }
        }
        private void button_Ekle_Click(object sender, EventArgs e)
        {
            tblOgrenci ogrenci = new tblOgrenci();
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
                else if (pictureBox_OgrenciFotograf.Image == null)
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Fotoğraf seçmelisiniz.";
                }
                else
                {
                    var kAdiVarMi = db.tblOgrenci.Where(o => o.KullaniciAdi == textBox_KAdi.Text).Count();
                    var mailVarMi = db.tblOgrenci.Where(o => o.Mail == textBox_Mail.Text).Count();
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
                            ogrenci.Durum = "A";

                        }
                        else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                        {
                            ogrenci.Durum = "P";
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
                        pictureBox_OgrenciFotograf.Image.Save(path, ImageFormat.Jpeg);
                        ogrenci.Ad = textBox_Ad.Text;
                        ogrenci.Soyad = textBox_Soyad.Text;
                        ogrenci.KullaniciAdi = textBox_KAdi.Text;
                        ogrenci.Sifre = textBox_Sifre.Text;
                        ogrenci.Mail = textBox_Mail.Text;
                        ogrenci.Resim = @"..\..\Fotograflar\" + fotografAdi;
                        db.tblOgrenci.Add(ogrenci);
                        db.SaveChanges();
                        label_Message.ForeColor = Color.LightSeaGreen;
                        label_Message.Text = "Öğrenci başarıyla eklendi.";
                        OgrencileriGetir();
                        Temizle();
                    }
                }

            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Hata oluştu : " + hata.Message;
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
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
                pictureBox_OgrenciFotograf.Image = null;
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

        private void dataGridView_Ogrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Id.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Id"].Value.ToString();
                textBox_Ad.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Ad"].Value.ToString();
                textBox_Soyad.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Soyad"].Value.ToString();
                textBox_KAdi.Text = dataGridView_Ogrenciler.CurrentRow.Cells["KullaniciAdi"].Value.ToString();
                textBox_Mail.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Mail"].Value.ToString();
                textBox_Sifre.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Sifre"].Value.ToString();
                comboBox_Durum.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Durum"].Value.ToString();
                pictureBox_OgrenciFotograf.Image = Image.FromFile(dataGridView_Ogrenciler.CurrentRow.Cells["Resim"].Value.ToString());
                label_Message.Text = "";
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Öğrenci Bilgileri Getirilirken Hata : " + hata.Message;
            }
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                tblOgrenci ogrenci = new tblOgrenci();
                int id = int.Parse(textBox_Id.Text);
                db.tblOgrenci.Remove(db.tblOgrenci.Find(id));
                db.SaveChanges();
                label_Message.ForeColor = Color.LightSeaGreen;
                label_Message.Text = "Silme işlemi başarılı.";
                OgrencileriGetir();
                Temizle();
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
                tblOgrenci ogrenci = db.tblOgrenci.Find(id);
                ogrenci.Ad = textBox_Ad.Text;
                ogrenci.Soyad = textBox_Soyad.Text;
                ogrenci.KullaniciAdi = textBox_KAdi.Text;
                ogrenci.Mail = textBox_Mail.Text;
                ogrenci.Sifre = textBox_Sifre.Text;
                if (comboBox_Durum.SelectedItem.ToString() == "Aktif")
                {
                    ogrenci.Durum = "A";

                }
                else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                {
                    ogrenci.Durum = "P";
                }
                db.SaveChanges();
                label_Message.ForeColor = Color.LightSeaGreen;
                label_Message.Text = "Güncelleme başarılı.";
                OgrencileriGetir();
                Temizle();
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Güncelleme işlemi başarısız : " + hata.Message;
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

        private void textBox_Ara_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Ara.Text))
            {
                OgrencileriGetir();
            }
            else
            {
                try
                {
                    dataGridView_Ogrenciler.DataSource = db.tblOgrenci.AsNoTracking().Select(
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
                        ).Where(r => r.KullaniciAdi.Contains(textBox_Ara.Text)).ToList();
                }
                catch (Exception hata)
                {
                    label_Message.Text = "Arama başarısız : " + hata.Message;
                }
            }
        }
    }
}
