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
    public partial class FormAdmin : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormAdmin()
        {
            InitializeComponent();
            timer_Saat.Start();
            Dashboard();
            label_AdSoyad.Text = "Hoşgeldiniz : " + Login.Ad + " " + Login.Soyad;

        }

        private void Dashboard()
        {
            int ogrenciSayisi = db.tblOgrenci.Count();
            label_OgrenciSayisi.Text = ogrenciSayisi.ToString();
            int ogretmenSayisi = db.tblOgretmen.Count();
            label_OgretmenSayisi.Text = ogretmenSayisi.ToString();
            int dersSayisi = db.tblDers.Count();
            label_DersSayisi.Text = dersSayisi.ToString();
            int notSayisi = db.tblNotlar.Count();
            label_Notlar.Text = notSayisi.ToString();
        }
        private void label_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Saat_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Saat.Text = dt.ToString("HH:mm:ss");
        }

        private void button_OgrenciIslem_Click(object sender, EventArgs e)
        {
            FormOgrenciIslemler ogrenci = new FormOgrenciIslemler();
            ogrenci.Show();
            this.Close();
        }

        private void button_OgretmenIslem_Click(object sender, EventArgs e)
        {
            FormOgretmenIslemleri ogretmen = new FormOgretmenIslemleri();
            ogretmen.Show();
            this.Close();

        }

        private void pictureBox_Ogrenci_Click(object sender, EventArgs e)
        {
            FormOgrenciIslemler ogrenci = new FormOgrenciIslemler();
            ogrenci.Show();
            this.Close();

        }

        private void pictureBox_Ogretmen_Click(object sender, EventArgs e)
        {
            FormOgretmenIslemleri ogretmen = new FormOgretmenIslemleri();
            ogretmen.Show();
            this.Close();

        }

        private void pictureBox_Ders_Click(object sender, EventArgs e)
        {
            FormDersIslemleri ders = new FormDersIslemleri();
            ders.Show();
            this.Close();

        }

        private void button_DersIslem_Click(object sender, EventArgs e)
        {
            FormDersIslemleri ders = new FormDersIslemleri();
            ders.Show();
            this.Close();

        }

        private void button_AlinanDersler_Click(object sender, EventArgs e)
        {
            FormAlinanDersler alinanDersler = new FormAlinanDersler();
            alinanDersler.Show();
            this.Close();

        }

        private void button_OgrNot_Click(object sender, EventArgs e)
        {
            FormOgrenciNotlari ogrenciNotlari = new FormOgrenciNotlari();
            ogrenciNotlari.Show();
            this.Close();

        }

        private void pictureBox_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Notlar_Click(object sender, EventArgs e)
        {
            FormOgrenciNotlari ogrenciNotlari = new FormOgrenciNotlari();
            ogrenciNotlari.Show();
            this.Close();

        }
    }
}
