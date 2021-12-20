
namespace OkulSistemi
{
    partial class FormOgretmenIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgretmenIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel_Message = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_Arama = new System.Windows.Forms.TextBox();
            this.label_2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView_Ogretmenler = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_FSec = new System.Windows.Forms.Button();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_KAdi = new System.Windows.Forms.TextBox();
            this.pictureBox_OgretmenFotograf = new System.Windows.Forms.PictureBox();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.comboBox_Durum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_Islemler = new System.Windows.Forms.Panel();
            this.groupBox_Islemler = new System.Windows.Forms.GroupBox();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_Message.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogretmenler)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFotograf)).BeginInit();
            this.panel_Islemler.SuspendLayout();
            this.groupBox_Islemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            // 
            // textBox_Id
            // 
            this.textBox_Id.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_Id.Location = new System.Drawing.Point(3, 3);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(24, 27);
            this.textBox_Id.TabIndex = 1;
            this.textBox_Id.Visible = false;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Öğretmen İşlemleri";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.White;
            this.label_Cikis.Location = new System.Drawing.Point(870, 2);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 0;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel_Message
            // 
            this.panel_Message.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Message.Controls.Add(this.label_Message);
            this.panel_Message.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Message.Location = new System.Drawing.Point(0, 568);
            this.panel_Message.Name = "panel_Message";
            this.panel_Message.Size = new System.Drawing.Size(900, 32);
            this.panel_Message.TabIndex = 0;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(4, 8);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(52, 19);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Mesaj";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.textBox_Arama);
            this.panel3.Controls.Add(this.label_2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 35);
            this.panel3.TabIndex = 1;
            // 
            // textBox_Arama
            // 
            this.textBox_Arama.Location = new System.Drawing.Point(438, 5);
            this.textBox_Arama.Name = "textBox_Arama";
            this.textBox_Arama.Size = new System.Drawing.Size(154, 27);
            this.textBox_Arama.TabIndex = 8;
            this.textBox_Arama.TextChanged += new System.EventHandler(this.textBox_Arama_TextChanged);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_2.Location = new System.Drawing.Point(264, 9);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(168, 19);
            this.label_2.TabIndex = 0;
            this.label_2.Text = "Kullanıcı Adı ile Arama";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 16);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Controls.Add(this.dataGridView_Ogretmenler);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 485);
            this.panel5.TabIndex = 2;
            // 
            // dataGridView_Ogretmenler
            // 
            this.dataGridView_Ogretmenler.AllowUserToAddRows = false;
            this.dataGridView_Ogretmenler.AllowUserToDeleteRows = false;
            this.dataGridView_Ogretmenler.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Ogretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ogretmenler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Ogretmenler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Ogretmenler.Name = "dataGridView_Ogretmenler";
            this.dataGridView_Ogretmenler.ReadOnly = true;
            this.dataGridView_Ogretmenler.Size = new System.Drawing.Size(900, 229);
            this.dataGridView_Ogretmenler.TabIndex = 15;
            this.dataGridView_Ogretmenler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ogretmenler_CellClick_1);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.button_FSec);
            this.panel6.Controls.Add(this.textBox_Mail);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.textBox_KAdi);
            this.panel6.Controls.Add(this.pictureBox_OgretmenFotograf);
            this.panel6.Controls.Add(this.textBox_Sifre);
            this.panel6.Controls.Add(this.textBox_Soyad);
            this.panel6.Controls.Add(this.textBox_Ad);
            this.panel6.Controls.Add(this.comboBox_Durum);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.panel_Islemler);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 270);
            this.panel6.TabIndex = 1;
            // 
            // button_FSec
            // 
            this.button_FSec.BackColor = System.Drawing.Color.White;
            this.button_FSec.FlatAppearance.BorderSize = 0;
            this.button_FSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FSec.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_FSec.Image = ((System.Drawing.Image)(resources.GetObject("button_FSec.Image")));
            this.button_FSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_FSec.Location = new System.Drawing.Point(673, 166);
            this.button_FSec.Name = "button_FSec";
            this.button_FSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_FSec.Size = new System.Drawing.Size(147, 29);
            this.button_FSec.TabIndex = 7;
            this.button_FSec.Text = "Fotoğraf Seç";
            this.button_FSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_FSec.UseVisualStyleBackColor = false;
            this.button_FSec.Click += new System.EventHandler(this.button_FSec_Click);
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.ForeColor = System.Drawing.Color.Black;
            this.textBox_Mail.Location = new System.Drawing.Point(423, 85);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(154, 27);
            this.textBox_Mail.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(673, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Öğretmen Fotoğrafı";
            // 
            // textBox_KAdi
            // 
            this.textBox_KAdi.ForeColor = System.Drawing.Color.Black;
            this.textBox_KAdi.Location = new System.Drawing.Point(423, 37);
            this.textBox_KAdi.Name = "textBox_KAdi";
            this.textBox_KAdi.Size = new System.Drawing.Size(154, 27);
            this.textBox_KAdi.TabIndex = 4;
            // 
            // pictureBox_OgretmenFotograf
            // 
            this.pictureBox_OgretmenFotograf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_OgretmenFotograf.BackgroundImage")));
            this.pictureBox_OgretmenFotograf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_OgretmenFotograf.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_OgretmenFotograf.InitialImage")));
            this.pictureBox_OgretmenFotograf.Location = new System.Drawing.Point(660, 40);
            this.pictureBox_OgretmenFotograf.Name = "pictureBox_OgretmenFotograf";
            this.pictureBox_OgretmenFotograf.Size = new System.Drawing.Size(173, 120);
            this.pictureBox_OgretmenFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgretmenFotograf.TabIndex = 7;
            this.pictureBox_OgretmenFotograf.TabStop = false;
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.ForeColor = System.Drawing.Color.Black;
            this.textBox_Sifre.Location = new System.Drawing.Point(95, 133);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(154, 27);
            this.textBox_Sifre.TabIndex = 3;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.ForeColor = System.Drawing.Color.Black;
            this.textBox_Soyad.Location = new System.Drawing.Point(95, 85);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(154, 27);
            this.textBox_Soyad.TabIndex = 2;
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ad.Location = new System.Drawing.Point(95, 37);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(154, 27);
            this.textBox_Ad.TabIndex = 1;
            // 
            // comboBox_Durum
            // 
            this.comboBox_Durum.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Durum.FormattingEnabled = true;
            this.comboBox_Durum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboBox_Durum.Location = new System.Drawing.Point(423, 133);
            this.comboBox_Durum.Name = "comboBox_Durum";
            this.comboBox_Durum.Size = new System.Drawing.Size(154, 27);
            this.comboBox_Durum.TabIndex = 6;
            this.comboBox_Durum.Text = "Durumunu Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(350, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Durumu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(372, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mail ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(319, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label4.Location = new System.Drawing.Point(35, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(57, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // panel_Islemler
            // 
            this.panel_Islemler.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Islemler.Controls.Add(this.groupBox_Islemler);
            this.panel_Islemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Islemler.Location = new System.Drawing.Point(0, 199);
            this.panel_Islemler.Name = "panel_Islemler";
            this.panel_Islemler.Size = new System.Drawing.Size(900, 71);
            this.panel_Islemler.TabIndex = 0;
            // 
            // groupBox_Islemler
            // 
            this.groupBox_Islemler.Controls.Add(this.button_Temizle);
            this.groupBox_Islemler.Controls.Add(this.button_Guncelle);
            this.groupBox_Islemler.Controls.Add(this.button_Sil);
            this.groupBox_Islemler.Controls.Add(this.button_Ekle);
            this.groupBox_Islemler.ForeColor = System.Drawing.Color.White;
            this.groupBox_Islemler.Location = new System.Drawing.Point(182, 0);
            this.groupBox_Islemler.Name = "groupBox_Islemler";
            this.groupBox_Islemler.Size = new System.Drawing.Size(513, 71);
            this.groupBox_Islemler.TabIndex = 0;
            this.groupBox_Islemler.TabStop = false;
            this.groupBox_Islemler.Text = "İşlemler";
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.Color.White;
            this.button_Temizle.FlatAppearance.BorderSize = 0;
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_Temizle.Image")));
            this.button_Temizle.Location = new System.Drawing.Point(359, 23);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(110, 38);
            this.button_Temizle.TabIndex = 0;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temizle.UseVisualStyleBackColor = false;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.White;
            this.button_Guncelle.FlatAppearance.BorderSize = 0;
            this.button_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guncelle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_Guncelle.Image")));
            this.button_Guncelle.Location = new System.Drawing.Point(225, 23);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(110, 38);
            this.button_Guncelle.TabIndex = 0;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Guncelle.UseVisualStyleBackColor = false;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.White;
            this.button_Sil.FlatAppearance.BorderSize = 0;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sil.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Sil.Image")));
            this.button_Sil.Location = new System.Drawing.Point(119, 23);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(73, 38);
            this.button_Sil.TabIndex = 0;
            this.button_Sil.Text = "Sil";
            this.button_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.White;
            this.button_Ekle.FlatAppearance.BorderSize = 0;
            this.button_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ekle.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Ekle.Image")));
            this.button_Ekle.Location = new System.Drawing.Point(6, 23);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(80, 38);
            this.button_Ekle.TabIndex = 0;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // FormOgretmenIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Message);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgretmenIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOgretmenIslemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Message.ResumeLayout(false);
            this.panel_Message.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogretmenler)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFotograf)).EndInit();
            this.panel_Islemler.ResumeLayout(false);
            this.groupBox_Islemler.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Message;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel_Islemler;
        private System.Windows.Forms.GroupBox groupBox_Islemler;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button Temizle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.TextBox textBox_KAdi;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.ComboBox comboBox_Durum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_FSec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox_OgretmenFotograf;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.DataGridView dataGridView_Ogretmenler;
        private System.Windows.Forms.TextBox textBox_Arama;
        private System.Windows.Forms.Label label_2;
    }
}