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
    public partial class FormOgretmen : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormOgretmen()
        {
            InitializeComponent();
            timer_Saat.Start();
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            int id = Login.Id;
            tblOgretmen ogretmen = db.tblOgretmen.Find(id);
            pictureBox_OgretmenResim.Image = Image.FromFile(ogretmen.Resim);
            label_AdSoyad.Text = Login.Ad + " " + Login.Soyad;
            int ogrenciSayi = db.tblAlinanDersler.Where(w => w.Ogretmen_id == Login.Id).Count();
            label_OgrenciSayisi.Text = ogrenciSayi.ToString();
            int dersSayisi = db.tblVerilenDersler.Where(w => w.Ogretmen_id == Login.Id).Count();
            label_DersSayisi.Text = dersSayisi.ToString();
        }
        private void timer_Saat_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Saat.Text = dt.ToString("HH:mm:ss");
        }

        private void button_Ogrencilerim_Click(object sender, EventArgs e)
        {
            FormOgrencilerim formOgrencilerim = new FormOgrencilerim();
            formOgrencilerim.Show();
            this.Hide();
        }

        private void button_Derslerim_Click(object sender, EventArgs e)
        {
            FormVerdigiDersler formVerdigiDersler = new FormVerdigiDersler();
            formVerdigiDersler.Show();
            this.Hide();
        }

        private void pictureBox_OgrIcon_Click(object sender, EventArgs e)
        {
            FormOgrencilerim formOgrencilerim = new FormOgrencilerim();
            formOgrencilerim.Show();
            this.Hide();
        }

        private void pictureBox_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_VDSayisi_Click(object sender, EventArgs e)
        {
            FormVerdigiDersler formVerdigiDersler = new FormVerdigiDersler();
            formVerdigiDersler.Show();
            this.Hide();
        }
    }
}
