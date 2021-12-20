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
    public partial class FormOgrencilerim : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormOgrencilerim()
        {
            InitializeComponent();
            label_Message.Text = "";
            NotlariGetir();
            GridAyarlariniGetir();
            button_NotVer.Enabled = false;
            button_NotGuncelle.Enabled = false;
            button_Temizle.Enabled = false;
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_Ogrenciler.Columns[1].Width = 242;
            dataGridView_Ogrenciler.Columns[2].Width = 200;
            dataGridView_Ogrenciler.Columns[3].Width = 200;
            dataGridView_Ogrenciler.Columns[4].Width = 100;
            dataGridView_Ogrenciler.Columns[5].Width = 100;
        }
        private void NotlariGetir()
        {
            var notlariGetir = (from notlar in db.tblNotlar
                                join ogrenci in db.tblOgrenci
                                on notlar.Ogrenci_id equals ogrenci.Id
                                join ogretmen in db.tblOgretmen
                                on notlar.Ogretmen_id equals ogretmen.Id
                                join ders in db.tblDers
                                on notlar.Ders_id equals ders.Id
                                select new
                                {
                                    Id = ogretmen.Id,
                                    Ogrenci = ogrenci.Ad + " " + ogrenci.Soyad,
                                    Numara = ogrenci.KullaniciAdi,
                                    Ders = ders.Ad,
                                    Vize = notlar.Vize,
                                    Final = notlar.Final,
                                    OgrR = ogrenci.Resim,
                                    NotId = notlar.Id,
                                }).Where(w => w.Id == Login.Id).ToList();
            dataGridView_Ogrenciler.DataSource = notlariGetir;
            dataGridView_Ogrenciler.Columns["Id"].Visible = false;
            dataGridView_Ogrenciler.Columns["OgrR"].Visible = false;
            dataGridView_Ogrenciler.Columns["NotId"].Visible = false;
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOgretmen formOgretmen = new FormOgretmen();
            formOgretmen.Show();
        }

        private void dataGridView_Ogrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_AdSoyad.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Ogrenci"].Value.ToString();
            textBox_Numarasi.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Numara"].Value.ToString();
            textBox_DersAdi.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Ders"].Value.ToString();
            textBox_NotId.Text = dataGridView_Ogrenciler.CurrentRow.Cells["NotId"].Value.ToString();
            if (dataGridView_Ogrenciler.CurrentRow.Cells["Vize"].Value == null)
            {
                textBox_VizeNotu.Text = "";
            }
            else
            {
                textBox_VizeNotu.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Vize"].Value.ToString();
            }
            if (dataGridView_Ogrenciler.CurrentRow.Cells["Final"].Value == null)
            {
                textBox_FinalNotu.Text = "";
            }
            else
            {
                textBox_FinalNotu.Text = dataGridView_Ogrenciler.CurrentRow.Cells["Final"].Value.ToString();
            }
            pictureBox_OgrenciFoto.Image = Image.FromFile(dataGridView_Ogrenciler.CurrentRow.Cells["OgrR"].Value.ToString());
        }

        private void button_NotVer_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView_Ogrenciler.CurrentRow.Cells["NotId"].Value.ToString());
                tblNotlar not = db.tblNotlar.Find(id);
                if (textBox_VizeNotu.Text == "" || string.IsNullOrEmpty(textBox_VizeNotu.Text))
                {
                    label_Message.Text = "Lütfen geçerli değer giriniz.";
                }
                else if (textBox_FinalNotu.Text == "" || string.IsNullOrEmpty(textBox_FinalNotu.Text))
                {
                    label_Message.Text = "Lütfen geçerli değer giriniz.";
                }
                else
                {
                    if (int.Parse(textBox_VizeNotu.Text) > 100 || int.Parse(textBox_VizeNotu.Text) < 0)
                    {
                        label_Message.Text = "Notlandırma değerleri geçersiz.";
                    }
                    else if (int.Parse(textBox_FinalNotu.Text) > 100 || int.Parse(textBox_FinalNotu.Text) < 0)
                    {
                        label_Message.Text = "Notlandırma değerleri geçersiz.";
                    }
                    else
                    {
                        not.Vize = int.Parse(textBox_VizeNotu.Text);
                        not.Final = int.Parse(textBox_FinalNotu.Text);
                        db.SaveChanges();
                        label_Message.Text = "Not verme işlemi başarılı.";
                        NotlariGetir();
                        Temizle();
                    }
                }
            }
            catch (Exception hata)
            {
                label_Message.Text = "Not verme işlemi başarısız :" + hata.Message;
            }
        }

        private void Temizle()
        {
            textBox_AdSoyad.Text = "";
            textBox_DersAdi.Text = "";
            textBox_FinalNotu.Text = "";
            textBox_VizeNotu.Text = "";
            textBox_Numarasi.Text = "";
            textBox_NotId.Text = "";
            pictureBox_OgrenciFoto.Image = null;
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button_NotGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataGridView_Ogrenciler.CurrentRow.Cells["NotId"].Value.ToString());
                tblNotlar not = db.tblNotlar.Find(id);
                if (textBox_VizeNotu.Text == "" || string.IsNullOrEmpty(textBox_VizeNotu.Text))
                {
                    label_Message.Text = "Lütfen geçerli değer giriniz.";
                }
                else if (textBox_FinalNotu.Text == "" || string.IsNullOrEmpty(textBox_FinalNotu.Text))
                {
                    label_Message.Text = "Lütfen geçerli değer giriniz.";
                }
                else
                {
                    if (int.Parse(textBox_VizeNotu.Text) > 100 || int.Parse(textBox_VizeNotu.Text) < 0)
                    {
                        label_Message.Text = "Notlandırma değerleri geçersiz.";
                    }
                    else if (int.Parse(textBox_FinalNotu.Text) > 100 || int.Parse(textBox_FinalNotu.Text) < 0)
                    {
                        label_Message.Text = "Notlandırma değerleri geçersiz.";
                    }
                    else
                    {
                        not.Vize = int.Parse(textBox_VizeNotu.Text);
                        not.Final = int.Parse(textBox_FinalNotu.Text);
                        db.SaveChanges();
                        label_Message.Text = "Not güncelleme başarılı.";
                        NotlariGetir();
                        Temizle();
                    }
                }
            }
            catch (Exception hata)
            {
                label_Message.Text = "Not güncelleme başarısız :" + hata.Message;
            }

        }
        private void textBox_NotId_TextChanged(object sender, EventArgs e)
        {
            if (textBox_NotId.Text == "" || textBox_NotId.Text == "0")
            {
                button_NotGuncelle.Enabled = false;
                button_NotVer.Enabled = false;
                button_Temizle.Enabled = false;
            }
            else
            {
                button_NotGuncelle.Enabled = true;
                button_NotVer.Enabled = true;
                button_Temizle.Enabled = true;
            }
        }
    }
}
