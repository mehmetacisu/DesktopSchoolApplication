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
    public partial class FormAldigimDersler : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormAldigimDersler()
        {
            InitializeComponent();
            label_Message.Text = "";
            AldigimDersleriGetir();
            GridAyarlariniGetir();
        }

        private void GridAyarlariniGetir()
        {
            dataGridView_AldigimDersler.Columns[2].Width = 140;
            dataGridView_AldigimDersler.Columns[4].Width = 200;
            dataGridView_AldigimDersler.Columns[5].Width = 515;
        }

        private void AldigimDersleriGetir()
        {
            var derslerim = (from alinanders in db.tblAlinanDersler
                             join ogretmen in db.tblOgretmen
                             on alinanders.Ogretmen_id equals ogretmen.Id
                             join ders in db.tblDers
                             on alinanders.Ders_id equals ders.Id
                             join ogrenci in db.tblOgrenci
                             on alinanders.Ogrenci_id equals ogrenci.Id
                             select new
                             {
                                 Id = alinanders.Ders_id,
                                 OgrId=ogrenci.Id,
                                 DersSahibi =ogretmen.Ad + " "+ogretmen.Soyad,
                                 DersSahibiFoto = ogretmen.Resim,
                                 DersAdi = ders.Ad,
                                 DersAciklamasi = ders.Aciklama,
                             }).Where(w=> w.OgrId == Login.Id).ToList();
            dataGridView_AldigimDersler.DataSource = derslerim;
            dataGridView_AldigimDersler.Columns["Id"].Visible = false;
            dataGridView_AldigimDersler.Columns["OgrId"].Visible = false;
            dataGridView_AldigimDersler.Columns["DersSahibiFoto"].Visible = false;
        }
        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOgrenci ogrenci = new FormOgrenci();
            ogrenci.Show();
        }

        private void dataGridView_AldigimDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_DersinHocasi.Text = dataGridView_AldigimDersler.CurrentRow.Cells["DersSahibi"].Value.ToString();
                textBox_DersAdi.Text = dataGridView_AldigimDersler.CurrentRow.Cells["DersAdi"].Value.ToString();
                richTextBox_DersAciklamasi.Text = dataGridView_AldigimDersler.CurrentRow.Cells["DersAciklamasi"].Value.ToString();
                pictureBox_OgretmenFoto.Image = Image.FromFile(dataGridView_AldigimDersler.CurrentRow.Cells["DersSahibiFoto"].Value.ToString());
            }
            catch (Exception hata)
            {
                label_Message.Text = "Seçilen ders getirilirken hata : "+hata.Message;
            }
        }

        private void button_SecimiTemizle_Click(object sender, EventArgs e)
        {
            textBox_DersAdi.Text = "";
            textBox_DersinHocasi.Text = "";
            richTextBox_DersAciklamasi.Text = "";
            pictureBox_OgretmenFoto.Image =null;
        }
    }
}
