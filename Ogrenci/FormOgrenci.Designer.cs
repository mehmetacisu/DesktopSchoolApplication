
namespace OkulSistemi
{
    partial class FormOgrenci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenci));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox_DersSayisi = new System.Windows.Forms.GroupBox();
            this.label_AldigimDersSayisi = new System.Windows.Forms.Label();
            this.pictureBox_ADSayisi = new System.Windows.Forms.PictureBox();
            this.label_12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_AdSoyad = new System.Windows.Forms.Label();
            this.pictureBox_OgrenciResim = new System.Windows.Forms.PictureBox();
            this.label_Saat = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_Notlarim = new System.Windows.Forms.Button();
            this.button_AldigimDersler = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_Cikis = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_Saat = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox_DersSayisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ADSayisi)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciResim)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cikis)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox_DersSayisi);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel6.Location = new System.Drawing.Point(0, 428);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 140);
            this.panel6.TabIndex = 33;
            // 
            // groupBox_DersSayisi
            // 
            this.groupBox_DersSayisi.Controls.Add(this.label_AldigimDersSayisi);
            this.groupBox_DersSayisi.Controls.Add(this.pictureBox_ADSayisi);
            this.groupBox_DersSayisi.Controls.Add(this.label_12);
            this.groupBox_DersSayisi.Location = new System.Drawing.Point(10, 12);
            this.groupBox_DersSayisi.Name = "groupBox_DersSayisi";
            this.groupBox_DersSayisi.Size = new System.Drawing.Size(234, 114);
            this.groupBox_DersSayisi.TabIndex = 35;
            this.groupBox_DersSayisi.TabStop = false;
            // 
            // label_AldigimDersSayisi
            // 
            this.label_AldigimDersSayisi.AutoSize = true;
            this.label_AldigimDersSayisi.Location = new System.Drawing.Point(113, 63);
            this.label_AldigimDersSayisi.Name = "label_AldigimDersSayisi";
            this.label_AldigimDersSayisi.Size = new System.Drawing.Size(0, 19);
            this.label_AldigimDersSayisi.TabIndex = 2;
            // 
            // pictureBox_ADSayisi
            // 
            this.pictureBox_ADSayisi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_ADSayisi.Image")));
            this.pictureBox_ADSayisi.Location = new System.Drawing.Point(15, 15);
            this.pictureBox_ADSayisi.Name = "pictureBox_ADSayisi";
            this.pictureBox_ADSayisi.Size = new System.Drawing.Size(42, 36);
            this.pictureBox_ADSayisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ADSayisi.TabIndex = 1;
            this.pictureBox_ADSayisi.TabStop = false;
            this.pictureBox_ADSayisi.Click += new System.EventHandler(this.pictureBox_ADSayisi_Click);
            // 
            // label_12
            // 
            this.label_12.AutoSize = true;
            this.label_12.Location = new System.Drawing.Point(65, 23);
            this.label_12.Name = "label_12";
            this.label_12.Size = new System.Drawing.Size(146, 19);
            this.label_12.TabIndex = 0;
            this.label_12.Text = "Aldığım Ders Sayısı";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_AdSoyad);
            this.panel5.Controls.Add(this.pictureBox_OgrenciResim);
            this.panel5.Controls.Add(this.label_Saat);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Location = new System.Drawing.Point(0, 32);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 140);
            this.panel5.TabIndex = 33;
            // 
            // label_AdSoyad
            // 
            this.label_AdSoyad.AutoSize = true;
            this.label_AdSoyad.Location = new System.Drawing.Point(21, 107);
            this.label_AdSoyad.Name = "label_AdSoyad";
            this.label_AdSoyad.Size = new System.Drawing.Size(73, 19);
            this.label_AdSoyad.TabIndex = 4;
            this.label_AdSoyad.Text = "AdSoyad";
            // 
            // pictureBox_OgrenciResim
            // 
            this.pictureBox_OgrenciResim.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pictureBox_OgrenciResim.Location = new System.Drawing.Point(14, 6);
            this.pictureBox_OgrenciResim.Name = "pictureBox_OgrenciResim";
            this.pictureBox_OgrenciResim.Size = new System.Drawing.Size(125, 98);
            this.pictureBox_OgrenciResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgrenciResim.TabIndex = 3;
            this.pictureBox_OgrenciResim.TabStop = false;
            // 
            // label_Saat
            // 
            this.label_Saat.AutoSize = true;
            this.label_Saat.Location = new System.Drawing.Point(790, 6);
            this.label_Saat.Name = "label_Saat";
            this.label_Saat.Size = new System.Drawing.Size(83, 19);
            this.label_Saat.TabIndex = 31;
            this.label_Saat.Text = "HH:MM:ss";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.button_Notlarim);
            this.panel4.Controls.Add(this.button_AldigimDersler);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 536);
            this.panel4.TabIndex = 33;
            // 
            // button_Notlarim
            // 
            this.button_Notlarim.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Notlarim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Notlarim.Image = ((System.Drawing.Image)(resources.GetObject("button_Notlarim.Image")));
            this.button_Notlarim.Location = new System.Drawing.Point(2, 273);
            this.button_Notlarim.Name = "button_Notlarim";
            this.button_Notlarim.Size = new System.Drawing.Size(160, 55);
            this.button_Notlarim.TabIndex = 33;
            this.button_Notlarim.Text = "Notlarım";
            this.button_Notlarim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Notlarim.UseVisualStyleBackColor = true;
            this.button_Notlarim.Click += new System.EventHandler(this.button_Notlarim_Click);
            // 
            // button_AldigimDersler
            // 
            this.button_AldigimDersler.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AldigimDersler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AldigimDersler.Image = ((System.Drawing.Image)(resources.GetObject("button_AldigimDersler.Image")));
            this.button_AldigimDersler.Location = new System.Drawing.Point(2, 199);
            this.button_AldigimDersler.Name = "button_AldigimDersler";
            this.button_AldigimDersler.Size = new System.Drawing.Size(160, 55);
            this.button_AldigimDersler.TabIndex = 34;
            this.button_AldigimDersler.Text = "Aldığım Dersler";
            this.button_AldigimDersler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_AldigimDersler.UseVisualStyleBackColor = true;
            this.button_AldigimDersler.Click += new System.EventHandler(this.button_AldigimDersler_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 568);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 32);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "İstanbul Medipol Üniversitesi";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.pictureBox_Cikis);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 32);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox_Cikis
            // 
            this.pictureBox_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Cikis.Image")));
            this.pictureBox_Cikis.Location = new System.Drawing.Point(867, 0);
            this.pictureBox_Cikis.Name = "pictureBox_Cikis";
            this.pictureBox_Cikis.Size = new System.Drawing.Size(31, 31);
            this.pictureBox_Cikis.TabIndex = 2;
            this.pictureBox_Cikis.TabStop = false;
            this.pictureBox_Cikis.Click += new System.EventHandler(this.pictureBox_Cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(381, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğrenci Anasayfa";
            // 
            // timer_Saat
            // 
            this.timer_Saat.Interval = 10;
            this.timer_Saat.Tick += new System.EventHandler(this.timer_Saat_Tick);
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgrenci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Anasayfa";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox_DersSayisi.ResumeLayout(false);
            this.groupBox_DersSayisi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ADSayisi)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciResim)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Cikis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_OgrenciResim;
        private System.Windows.Forms.Label label_AdSoyad;
        private System.Windows.Forms.Label label_Saat;
        private System.Windows.Forms.Timer timer_Saat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox_DersSayisi;
        private System.Windows.Forms.Label label_AldigimDersSayisi;
        private System.Windows.Forms.PictureBox pictureBox_ADSayisi;
        private System.Windows.Forms.Label label_12;
        private System.Windows.Forms.Button button_Notlarim;
        private System.Windows.Forms.Button button_AldigimDersler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox_Cikis;
    }
}