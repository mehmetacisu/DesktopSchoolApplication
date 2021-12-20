
namespace OkulSistemi
{
    partial class FormOgrenciIslemler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciIslemler));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_Ara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.textBox_Soyad = new System.Windows.Forms.TextBox();
            this.textBox_KAdi = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.comboBox_Durum = new System.Windows.Forms.ComboBox();
            this.pictureBox_OgrenciFotograf = new System.Windows.Forms.PictureBox();
            this.button_FSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.textBox_Sifre = new System.Windows.Forms.TextBox();
            this.dataGridView_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogrenciler)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label_Cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label8.Location = new System.Drawing.Point(400, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 26;
            this.label8.Text = "Öğrenci İşlemleri";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(3, 3);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(21, 27);
            this.textBox_Id.TabIndex = 28;
            this.textBox_Id.Visible = false;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Cikis.Location = new System.Drawing.Point(871, 2);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 27;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label_Message);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 568);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 32);
            this.panel5.TabIndex = 0;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Message.Location = new System.Drawing.Point(3, 7);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(52, 19);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Mesaj";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_Ara);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 35);
            this.panel2.TabIndex = 1;
            // 
            // textBox_Ara
            // 
            this.textBox_Ara.Location = new System.Drawing.Point(396, 5);
            this.textBox_Ara.Name = "textBox_Ara";
            this.textBox_Ara.Size = new System.Drawing.Size(154, 27);
            this.textBox_Ara.TabIndex = 0;
            this.textBox_Ara.TextChanged += new System.EventHandler(this.textBox_Ara_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(244, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Kullanıcı Adıyla Ara";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 16);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 486);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 66);
            this.panel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Temizle);
            this.groupBox1.Controls.Add(this.button_Guncelle);
            this.groupBox1.Controls.Add(this.button_Sil);
            this.groupBox1.Controls.Add(this.button_Ekle);
            this.groupBox1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(192, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Temizle.FlatAppearance.BorderSize = 0;
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.ForeColor = System.Drawing.Color.White;
            this.button_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_Temizle.Image")));
            this.button_Temizle.Location = new System.Drawing.Point(378, 22);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(110, 38);
            this.button_Temizle.TabIndex = 11;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temizle.UseVisualStyleBackColor = false;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Guncelle.FlatAppearance.BorderSize = 0;
            this.button_Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Guncelle.ForeColor = System.Drawing.Color.White;
            this.button_Guncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_Guncelle.Image")));
            this.button_Guncelle.Location = new System.Drawing.Point(231, 22);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Guncelle.Size = new System.Drawing.Size(110, 38);
            this.button_Guncelle.TabIndex = 10;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Guncelle.UseVisualStyleBackColor = false;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Sil.FlatAppearance.BorderSize = 0;
            this.button_Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sil.ForeColor = System.Drawing.Color.White;
            this.button_Sil.Image = ((System.Drawing.Image)(resources.GetObject("button_Sil.Image")));
            this.button_Sil.Location = new System.Drawing.Point(121, 22);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(73, 38);
            this.button_Sil.TabIndex = 9;
            this.button_Sil.Text = "Sil";
            this.button_Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Sil.UseVisualStyleBackColor = false;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Ekle
            // 
            this.button_Ekle.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_Ekle.FlatAppearance.BorderSize = 0;
            this.button_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ekle.ForeColor = System.Drawing.Color.White;
            this.button_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("button_Ekle.Image")));
            this.button_Ekle.Location = new System.Drawing.Point(4, 22);
            this.button_Ekle.Name = "button_Ekle";
            this.button_Ekle.Size = new System.Drawing.Size(80, 38);
            this.button_Ekle.TabIndex = 8;
            this.button_Ekle.Text = "Ekle";
            this.button_Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Ekle.UseVisualStyleBackColor = false;
            this.button_Ekle.Click += new System.EventHandler(this.button_Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(266, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(323, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(297, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Durumu";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.Location = new System.Drawing.Point(64, 322);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(154, 27);
            this.textBox_Ad.TabIndex = 1;
            // 
            // textBox_Soyad
            // 
            this.textBox_Soyad.Location = new System.Drawing.Point(64, 378);
            this.textBox_Soyad.Name = "textBox_Soyad";
            this.textBox_Soyad.Size = new System.Drawing.Size(154, 27);
            this.textBox_Soyad.TabIndex = 2;
            // 
            // textBox_KAdi
            // 
            this.textBox_KAdi.Location = new System.Drawing.Point(369, 322);
            this.textBox_KAdi.Name = "textBox_KAdi";
            this.textBox_KAdi.Size = new System.Drawing.Size(154, 27);
            this.textBox_KAdi.TabIndex = 4;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(369, 378);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(154, 27);
            this.textBox_Mail.TabIndex = 5;
            // 
            // comboBox_Durum
            // 
            this.comboBox_Durum.FormattingEnabled = true;
            this.comboBox_Durum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboBox_Durum.Location = new System.Drawing.Point(369, 431);
            this.comboBox_Durum.Name = "comboBox_Durum";
            this.comboBox_Durum.Size = new System.Drawing.Size(157, 27);
            this.comboBox_Durum.TabIndex = 6;
            this.comboBox_Durum.Text = "Durumunu Seçiniz";
            // 
            // pictureBox_OgrenciFotograf
            // 
            this.pictureBox_OgrenciFotograf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_OgrenciFotograf.BackgroundImage")));
            this.pictureBox_OgrenciFotograf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_OgrenciFotograf.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_OgrenciFotograf.InitialImage")));
            this.pictureBox_OgrenciFotograf.Location = new System.Drawing.Point(641, 330);
            this.pictureBox_OgrenciFotograf.Name = "pictureBox_OgrenciFotograf";
            this.pictureBox_OgrenciFotograf.Size = new System.Drawing.Size(173, 120);
            this.pictureBox_OgrenciFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgrenciFotograf.TabIndex = 7;
            this.pictureBox_OgrenciFotograf.TabStop = false;
            // 
            // button_FSec
            // 
            this.button_FSec.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_FSec.FlatAppearance.BorderSize = 0;
            this.button_FSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FSec.ForeColor = System.Drawing.Color.White;
            this.button_FSec.Image = ((System.Drawing.Image)(resources.GetObject("button_FSec.Image")));
            this.button_FSec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_FSec.Location = new System.Drawing.Point(653, 451);
            this.button_FSec.Name = "button_FSec";
            this.button_FSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_FSec.Size = new System.Drawing.Size(147, 29);
            this.button_FSec.TabIndex = 7;
            this.button_FSec.Text = "Fotoğraf Seç";
            this.button_FSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_FSec.UseVisualStyleBackColor = false;
            this.button_FSec.Click += new System.EventHandler(this.button_FSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.ForeColor = System.Drawing.Color.White;
            this.label_Sifre.Location = new System.Drawing.Point(4, 431);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(54, 19);
            this.label_Sifre.TabIndex = 16;
            this.label_Sifre.Text = "Şifresi";
            // 
            // textBox_Sifre
            // 
            this.textBox_Sifre.Location = new System.Drawing.Point(64, 426);
            this.textBox_Sifre.Name = "textBox_Sifre";
            this.textBox_Sifre.Size = new System.Drawing.Size(154, 27);
            this.textBox_Sifre.TabIndex = 3;
            // 
            // dataGridView_Ogrenciler
            // 
            this.dataGridView_Ogrenciler.AllowUserToAddRows = false;
            this.dataGridView_Ogrenciler.AllowUserToDeleteRows = false;
            this.dataGridView_Ogrenciler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ogrenciler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Ogrenciler.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Ogrenciler.Name = "dataGridView_Ogrenciler";
            this.dataGridView_Ogrenciler.ReadOnly = true;
            this.dataGridView_Ogrenciler.Size = new System.Drawing.Size(900, 226);
            this.dataGridView_Ogrenciler.TabIndex = 0;
            this.dataGridView_Ogrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ogrenciler_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.dataGridView_Ogrenciler);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 226);
            this.panel6.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(668, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Öğrenci Fotoğrafı";
            // 
            // FormOgrenciIslemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_FSec);
            this.Controls.Add(this.pictureBox_OgrenciFotograf);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.comboBox_Durum);
            this.Controls.Add(this.textBox_Sifre);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_KAdi);
            this.Controls.Add(this.textBox_Soyad);
            this.Controls.Add(this.textBox_Ad);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgrenciIslemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciIslemler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogrenciler)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.TextBox textBox_Soyad;
        private System.Windows.Forms.TextBox textBox_KAdi;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.ComboBox comboBox_Durum;
        private System.Windows.Forms.PictureBox pictureBox_OgrenciFotograf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.Button button_FSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.TextBox textBox_Sifre;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Ara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_Ogrenciler;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
    }
}