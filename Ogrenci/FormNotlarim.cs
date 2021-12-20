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
    public partial class FormNotlar : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormNotlar()
        {
            InitializeComponent();
            label_Message.Text = "";
            NotlariGetir();
            Temizle();
            GridAyarlariniGetir();
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_Notlar.Columns[1].Width = 200;
            dataGridView_Notlar.Columns[2].Width = 300;
            dataGridView_Notlar.Columns[3].Width = 150;
            dataGridView_Notlar.Columns[4].Width = 100;
            dataGridView_Notlar.Columns[5].Width = 100;
        }

        private void Temizle()
        {
            textBox_DersAdi.Text = "";
            richTextBox_Aciklama.Text = "";
            textBox_DersSahibi.Text = "";
            textBox_Vize.Text = "";
            textBox_Final.Text = "";
            textBox_BasariDurumu.Text = "";
            label_Message.Text = "";
        }

        private void NotlariGetir()
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
                                Vize = not.Vize,
                                Final = not.Final,
                            }).Where(w => w.Id == Login.Id).ToList();
            dataGridView_Notlar.DataSource = notlarim;
            dataGridView_Notlar.Columns["Id"].Visible = false;
        }

        private void button_SecimiTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void dataGridView_Notlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_DersSahibi.Text = dataGridView_Notlar.CurrentRow.Cells["DersSahibi"].Value.ToString();
                textBox_DersAdi.Text = dataGridView_Notlar.CurrentRow.Cells["DersAdi"].Value.ToString();
                richTextBox_Aciklama.Text = dataGridView_Notlar.CurrentRow.Cells["DersAciklamasi"].Value.ToString();
                textBox_Vize.Text = dataGridView_Notlar.CurrentRow.Cells["Vize"].Value.ToString();
                textBox_Final.Text = dataGridView_Notlar.CurrentRow.Cells["Final"].Value.ToString();
                double vizeNotu = double.Parse(dataGridView_Notlar.CurrentRow.Cells["Vize"].Value.ToString());
                double finalNotu = double.Parse(dataGridView_Notlar.CurrentRow.Cells["Final"].Value.ToString());
                double ortalama = (vizeNotu * 0.4) + (finalNotu * 0.6);
                if (ortalama < 50 || finalNotu < 50)
                {
                    textBox_BasariDurumu.Text = (ortalama + " ortalama ile kaldınız.");
                }
                else
                {
                    textBox_BasariDurumu.Text = (ortalama + " ortalama ile geçtiniz.");
                }
            }
            catch (Exception hata)
            {

                label_Message.Text = "Notlar Getirilemedi : " + hata.Message;
            }

        }
        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOgrenci formOgrenci = new FormOgrenci();
            formOgrenci.Show();
        }
    }
}
