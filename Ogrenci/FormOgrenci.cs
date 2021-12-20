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
    public partial class FormOgrenci : Form
    {
        OkulSistemiEntities db = new OkulSistemiEntities();
        public FormOgrenci()
        {
            InitializeComponent();
            timer_Saat.Start();
            int id = Login.Id;
            label_AdSoyad.Text = Login.Ad + " " + Login.Soyad;
            tblOgrenci ogrenci = db.tblOgrenci.Find(id);
            pictureBox_OgrenciResim.Image = Image.FromFile(ogrenci.Resim);
            label_AldigimDersSayisi.Text = db.tblAlinanDersler.Where(w => w.Ogrenci_id == Login.Id).Count().ToString();
        }
        private void timer_Saat_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Saat.Text = dt.ToString("HH:mm:ss");
        }

        private void button_AldigimDersler_Click(object sender, EventArgs e)
        {
            FormAldigimDersler formAldigim = new FormAldigimDersler();
            formAldigim.Show();
            this.Close();
        }

        private void button_Notlarim_Click(object sender, EventArgs e)
        {
            FormNotlar formNotlar = new FormNotlar();
            formNotlar.Show();
            this.Close();
        }

        private void pictureBox_Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_ADSayisi_Click(object sender, EventArgs e)
        {
            FormAldigimDersler formAldigim = new FormAldigimDersler();
            formAldigim.Show();
            this.Close();
        }
    }
}
