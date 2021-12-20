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
    public partial class FormOgrenciNotlari : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormOgrenciNotlari()
        {
            InitializeComponent();
            NotlariGetir();
            Temizle();
            GridAyarlariniGetir();
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_Notlar.Columns[0].Width = 50;
            dataGridView_Notlar.Columns[1].Width = 150;
            dataGridView_Notlar.Columns[2].Width = 255;
            dataGridView_Notlar.Columns[3].Width = 150;
            dataGridView_Notlar.Columns[4].Width = 150;
            dataGridView_Notlar.Columns[5].Width = 50;
            dataGridView_Notlar.Columns[6].Width = 50;
        }

        private void NotlariGetir()
        {
            try
            {
                var notlarim = (from not in db.tblNotlar
                                join ogretmen in db.tblOgretmen
                                on not.Ogretmen_id equals ogretmen.Id
                                join ogrenci in db.tblOgrenci
                                on not.Ogrenci_id equals ogrenci.Id
                                join ders in db.tblDers
                                on not.Ders_id equals ders.Id
                                select new
                                {
                                    Id = ogrenci.Id,
                                    DersAdi = ders.Ad,
                                    DersAciklamasi = ders.Aciklama,
                                    DersSahibi = ogretmen.Ad + " " + ogretmen.Soyad,
                                    Ogrenci = ogrenci.Ad + " " + ogrenci.Soyad,
                                    Vize = not.Vize,
                                    Final = not.Final,
                                }).ToList();
                dataGridView_Notlar.DataSource = notlarim;

            }
            catch (Exception hata)
            {
                label_Footer.Text = "";
                label_Message.Text = "Not verileri getirilirken hata : " + hata.Message;
            }
           
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void dataGridView_Notlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_DersAdi.Text = dataGridView_Notlar.CurrentRow.Cells["DersAdi"].Value.ToString();
                textBox_DersSahibi.Text = dataGridView_Notlar.CurrentRow.Cells["DersSahibi"].Value.ToString();
                richTextBox_Aciklamasi.Text = dataGridView_Notlar.CurrentRow.Cells["DersAciklamasi"].Value.ToString();
                textBox_Ogrenci.Text = dataGridView_Notlar.CurrentRow.Cells["Ogrenci"].Value.ToString();
                if (dataGridView_Notlar.CurrentRow.Cells["Vize"].Value == null)
                {
                    textBox_Vize.Text = "";
                }
                else
                {
                    textBox_Vize.Text = dataGridView_Notlar.CurrentRow.Cells["Vize"].Value.ToString();
                }
                if (dataGridView_Notlar.CurrentRow.Cells["Final"].Value == null)
                {
                    textBox_Final.Text = "";
                }
                else
                {
                    textBox_Final.Text = dataGridView_Notlar.CurrentRow.Cells["Final"].Value.ToString();
                }
               
            }
            catch (Exception hata)
            {
                label_Footer.Text = "";
                label_Message.Text = "Not verileri seçilirken hata : " + hata.Message;
            }
        }

        private void button_Temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            textBox_DersAdi.Text = "";
            textBox_DersSahibi.Text = "";
            richTextBox_Aciklamasi.Text = "";
            textBox_Ogrenci.Text = "";
            textBox_Vize.Text = "";
            textBox_Final.Text = "";
            label_Message.Text = "";
        }
    }
}

