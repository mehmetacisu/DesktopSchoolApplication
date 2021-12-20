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
    public partial class FormAlinanDersler : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormAlinanDersler()
        {
            InitializeComponent();
            label_Message.Text = "";
            AlinanDersleriGetir();
            GridAyarlarinigetir();
        }

        private void GridAyarlarinigetir()
        {
            dataGridView_AlinanDersler.Columns[2].Width = 150;
            dataGridView_AlinanDersler.Columns[6].Width = 200;
            dataGridView_AlinanDersler.Columns[7].Width = 300;

        }

        private void AlinanDersleriGetir()
        {
            var alinanDersler = (from alinanders in db.tblAlinanDersler
                                 join ogretmen in db.tblOgretmen
                                 on alinanders.Ogretmen_id equals ogretmen.Id
                                 join ders in db.tblDers
                                 on alinanders.Ders_id equals ders.Id
                                 join ogrenci in db.tblOgrenci
                                 on alinanders.Ogrenci_id equals ogrenci.Id
                                 select new
                                 {
                                     Id = alinanders.Ders_id,
                                     OgrId = ogrenci.Id,
                                     Ogrenci = ogrenci.Ad + " " + ogrenci.Soyad,
                                     OgrFoto = ogrenci.Resim,
                                     DersSahibi = ogretmen.Ad + " " + ogretmen.Soyad,
                                     DersSahibiFoto = ogretmen.Resim,
                                     DersAdi = ders.Ad,
                                     DersAciklamasi = ders.Aciklama,
                                 }).ToList();
            dataGridView_AlinanDersler.DataSource = alinanDersler;
            dataGridView_AlinanDersler.Columns["OgrId"].Visible = false;
            dataGridView_AlinanDersler.Columns["OgrFoto"].Visible = false;
            dataGridView_AlinanDersler.Columns["DersSahibiFoto"].Visible = false;
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormAdmin admin = new FormAdmin();
            admin.Show();
        }

        private void dataGridView_AlinanDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_OgrenciAdi.Text = dataGridView_AlinanDersler.CurrentRow.Cells["Ogrenci"].Value.ToString();
                pictureBox_OgrenciFoto.Image = Image.FromFile(dataGridView_AlinanDersler.CurrentRow.Cells["OgrFoto"].Value.ToString());
                textBox_DersinHocasi.Text = dataGridView_AlinanDersler.CurrentRow.Cells["DersSahibi"].Value.ToString();
                textBox_DersAdi.Text = dataGridView_AlinanDersler.CurrentRow.Cells["DersAdi"].Value.ToString();
                richTextBox_DersAciklamasi.Text = dataGridView_AlinanDersler.CurrentRow.Cells["DersAciklamasi"].Value.ToString();
                pictureBox_OgretmenFoto.Image = Image.FromFile(dataGridView_AlinanDersler.CurrentRow.Cells["DersSahibiFoto"].Value.ToString());
            }
            catch (Exception hata)
            {
                label_Message.Text = "Seçilen ders getirilirken hata : " + hata.Message;
            }
        }


    }
}

