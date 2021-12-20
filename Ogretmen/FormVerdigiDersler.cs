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
    public partial class FormVerdigiDersler : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormVerdigiDersler()
        {
            InitializeComponent();
            VerdigimDersleriGetir();
            GridAyarlariniGetir();
        }
        private void GridAyarlariniGetir()
        {
            dataGridView_VerdigimDersler.Columns[1].Width = 200;
            dataGridView_VerdigimDersler.Columns[2].Width = 450;
        }

        private void VerdigimDersleriGetir()
        {
            var verdigimDersler = (from verilenders in db.tblVerilenDersler
                                   join ders in db.tblDers
                                   on verilenders.Ders_id equals ders.Id
                                   join ogretmen in db.tblOgretmen
                                   on verilenders.Ogretmen_id equals ogretmen.Id
                                   select new
                                   {
                                       Id = ogretmen.Id,
                                       DersAdi = ders.Ad,
                                       DersAciklamasi = ders.Aciklama,
                                   }).Where(w => w.Id == Login.Id).ToList();
            dataGridView_VerdigimDersler.DataSource = verdigimDersler;
            dataGridView_VerdigimDersler.Columns["Id"].Visible = false;
        }

        private void label_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
            FormOgretmen formOgretmen = new FormOgretmen();
            formOgretmen.Show();
        }

        private void dataGridView_VerdigimDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox_Adi.Text = dataGridView_VerdigimDersler.CurrentRow.Cells["DersAdi"].Value.ToString();
                richTextBox_Aciklamasi.Text= dataGridView_VerdigimDersler.CurrentRow.Cells["DersAciklamasi"].Value.ToString();
            }
            catch (Exception hata)
            {
                label_Footer.Text = "";
                label_Message.Text = "Dersler Getirilemedi " + hata.Message;
            }

        }
    }
}
