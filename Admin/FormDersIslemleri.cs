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
    public partial class FormDersIslemleri : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormDersIslemleri()
        {
            InitializeComponent();
            Temizle();
            label_Message.Text = "";
            DersleriGetir();
            GridAyarlariniGetir();
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_Ders.Columns[0].Width = 40;
            dataGridView_Ders.Columns[1].Width = 170;
            dataGridView_Ders.Columns[2].Width = 550;
            dataGridView_Ders.Columns[3].Width = 95;
        }

        private void DersleriGetir()
        {
            try
            {
                dataGridView_Ders.DataSource = db.tblDers.AsNoTracking()
                    .Select(d => new
                    {
                        Id = d.Id,
                        Ad = d.Ad,
                        Aciklama = d.Aciklama,
                        Durum = d.Durum == "A" ? "Aktif" : "Pasif"
                    }).ToList();
            }
            catch (Exception hata)
            {
                label_Message.Text = "Dersler Listelenirken Hata : " + hata.Message;
            }
        }

        private void Temizle()
        {
            try
            {
                textBox_Id.Text = "";
                textBox_Ad.Text = "";
                richTextBox_Aciklama.Text = "";
                comboBox_Durum.Text = "Durumunu Seçiniz";
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

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox_Id.Text);
                tblDers ders = db.tblDers.Find(id);
                ders.Ad = textBox_Ad.Text;
                ders.Aciklama = richTextBox_Aciklama.Text;
                if (comboBox_Durum.SelectedItem.ToString() == "Aktif")
                {
                    ders.Durum = "A";

                }
                else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                {
                    ders.Durum = "P";
                }
                db.SaveChanges();
                label_Message.ForeColor = Color.White;
                label_Message.Text = "Güncelleme başarılı.";
                DersleriGetir();
                Temizle();
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Güncelleme işlemi başarısız : " + hata.Message;
            }
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                tblOgretmen ogretmen = new tblOgretmen();
                int id = int.Parse(textBox_Id.Text);
                db.tblDers.Remove(db.tblDers.Find(id));
                db.SaveChanges();
                label_Message.ForeColor = Color.White;
                label_Message.Text = "Silme işlemi başarılı.";
                DersleriGetir();
                Temizle();
            }
            catch (Exception hata)
            {
                label_Message.ForeColor = Color.Red;
                label_Message.Text = "Silme işlemi başarısız : " + hata.Message;
            }
        }

        private void button_Ekle_Click(object sender, EventArgs e)
        {
            tblDers ders = new tblDers();
            try
            {
                if (textBox_Ad.Text == "" || string.IsNullOrEmpty(textBox_Ad.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Adı boş olamaz.";
                }
                else if (richTextBox_Aciklama.Text ==""||string.IsNullOrEmpty(richTextBox_Aciklama.Text))
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Açıklama boş olamaz.";
                }
                else if (comboBox_Durum.Text == "Durumunu Seçiniz")
                {
                    label_Message.ForeColor = Color.Red;
                    label_Message.Text = "Durum Boş Olamaz";
                }
                else
                {
                    if (comboBox_Durum.SelectedItem.ToString() == "Aktif")
                    {
                        ders.Durum = "A";

                    }
                    else if (comboBox_Durum.SelectedItem.ToString() == "Pasif")
                    {
                        ders.Durum = "P";
                    }
                    ders.Ad = textBox_Ad.Text;
                    ders.Aciklama = richTextBox_Aciklama.Text;
                    db.tblDers.Add(ders);
                    db.SaveChanges();
                    label_Message.ForeColor = Color.White;
                    label_Message.Text = "Ders başarıyla eklendi.";
                    DersleriGetir();
                    Temizle();
                }
            }
            catch (Exception hata)
            {
                label_Message.Text = "Ders Eklenirken Hata"+hata.Message;
            }
        }

        private void textBox_Id_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Id.Text == "0" || textBox_Id.Text == "")
            {
                button_Guncelle.Enabled = false;
                button_Sil.Enabled = false;
                button_Temizle.Enabled = false;
            }
            else
            {
                button_Guncelle.Enabled = true;
                button_Sil.Enabled = true;
                button_Temizle.Enabled = true;
            }
        }

        private void dataGridView_Ders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_Id.Text = dataGridView_Ders.CurrentRow.Cells["Id"].Value.ToString();
            textBox_Ad.Text = dataGridView_Ders.CurrentRow.Cells["Ad"].Value.ToString();
            richTextBox_Aciklama.Text = dataGridView_Ders.CurrentRow.Cells["Aciklama"].Value.ToString();
            comboBox_Durum.Text = dataGridView_Ders.CurrentRow.Cells["Durum"].Value.ToString();
            label_Message.Text = "";
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin admin = new FormAdmin();
            admin.Show();

        }

        private void textBox_Arama_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Arama.Text))
            {
                DersleriGetir();
            }
            else
            {
                try
                {
                    dataGridView_Ders.DataSource = db.tblDers.AsNoTracking().Select(
                       s => new
                       {
                           Id = s.Id,
                           Ad = s.Ad,
                           Aciklama = s.Aciklama,
                           Durum = s.Durum == "A" ? "Aktif" : "Pasif"
                       }
                       ).Where(r => r.Ad.Contains(textBox_Arama.Text)).ToList();
                }
                catch (Exception hata)
                {
                    label_Message.Text = "Arama sırasında hata : " + hata.Message;
                }
            }
        }
    }
}
