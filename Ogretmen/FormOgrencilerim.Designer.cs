
namespace OkulSistemi
{
    partial class FormOgrencilerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrencilerim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.textBox_NotId = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView_Ogrenciler = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox_Bilgiler = new System.Windows.Forms.GroupBox();
            this.pictureBox_OgrenciFoto = new System.Windows.Forms.PictureBox();
            this.textBox_VizeNotu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_DersAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_FinalNotu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Numarasi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_AdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_NotGuncelle = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_NotVer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogrenciler)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox_Bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFoto)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label_Cikis);
            this.panel1.Controls.Add(this.textBox_NotId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(401, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "Öğrencilerim";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.White;
            this.label_Cikis.Location = new System.Drawing.Point(871, 2);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 0;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // textBox_NotId
            // 
            this.textBox_NotId.BackColor = System.Drawing.Color.LightSeaGreen;
            this.textBox_NotId.Location = new System.Drawing.Point(3, 1);
            this.textBox_NotId.Name = "textBox_NotId";
            this.textBox_NotId.ReadOnly = true;
            this.textBox_NotId.Size = new System.Drawing.Size(29, 27);
            this.textBox_NotId.TabIndex = 28;
            this.textBox_NotId.Visible = false;
            this.textBox_NotId.TextChanged += new System.EventHandler(this.textBox_NotId_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label_Message);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 32);
            this.panel2.TabIndex = 0;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(2, 9);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(114, 19);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "label_Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İstanbul Medipol Üniversitesi";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 16);
            this.panel3.TabIndex = 1;
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
            // dataGridView_Ogrenciler
            // 
            this.dataGridView_Ogrenciler.AllowUserToAddRows = false;
            this.dataGridView_Ogrenciler.AllowUserToDeleteRows = false;
            this.dataGridView_Ogrenciler.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Ogrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ogrenciler.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Ogrenciler.Location = new System.Drawing.Point(0, 48);
            this.dataGridView_Ogrenciler.Name = "dataGridView_Ogrenciler";
            this.dataGridView_Ogrenciler.ReadOnly = true;
            this.dataGridView_Ogrenciler.Size = new System.Drawing.Size(900, 228);
            this.dataGridView_Ogrenciler.TabIndex = 2;
            this.dataGridView_Ogrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ogrenciler_CellClick);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.groupBox_Bilgiler);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 276);
            this.panel6.TabIndex = 4;
            // 
            // groupBox_Bilgiler
            // 
            this.groupBox_Bilgiler.Controls.Add(this.pictureBox_OgrenciFoto);
            this.groupBox_Bilgiler.Controls.Add(this.textBox_VizeNotu);
            this.groupBox_Bilgiler.Controls.Add(this.label5);
            this.groupBox_Bilgiler.Controls.Add(this.textBox_DersAdi);
            this.groupBox_Bilgiler.Controls.Add(this.label4);
            this.groupBox_Bilgiler.Controls.Add(this.textBox_FinalNotu);
            this.groupBox_Bilgiler.Controls.Add(this.label7);
            this.groupBox_Bilgiler.Controls.Add(this.label6);
            this.groupBox_Bilgiler.Controls.Add(this.textBox_Numarasi);
            this.groupBox_Bilgiler.Controls.Add(this.label3);
            this.groupBox_Bilgiler.Controls.Add(this.textBox_AdSoyad);
            this.groupBox_Bilgiler.Controls.Add(this.label2);
            this.groupBox_Bilgiler.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox_Bilgiler.Location = new System.Drawing.Point(4, 3);
            this.groupBox_Bilgiler.Name = "groupBox_Bilgiler";
            this.groupBox_Bilgiler.Size = new System.Drawing.Size(891, 191);
            this.groupBox_Bilgiler.TabIndex = 18;
            this.groupBox_Bilgiler.TabStop = false;
            this.groupBox_Bilgiler.Text = "Öğrenci Bilgileri";
            // 
            // pictureBox_OgrenciFoto
            // 
            this.pictureBox_OgrenciFoto.Location = new System.Drawing.Point(692, 35);
            this.pictureBox_OgrenciFoto.Name = "pictureBox_OgrenciFoto";
            this.pictureBox_OgrenciFoto.Size = new System.Drawing.Size(192, 127);
            this.pictureBox_OgrenciFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgrenciFoto.TabIndex = 29;
            this.pictureBox_OgrenciFoto.TabStop = false;
            // 
            // textBox_VizeNotu
            // 
            this.textBox_VizeNotu.Location = new System.Drawing.Point(201, 135);
            this.textBox_VizeNotu.MaxLength = 3;
            this.textBox_VizeNotu.Name = "textBox_VizeNotu";
            this.textBox_VizeNotu.Size = new System.Drawing.Size(173, 27);
            this.textBox_VizeNotu.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Vize Notu";
            // 
            // textBox_DersAdi
            // 
            this.textBox_DersAdi.Location = new System.Drawing.Point(401, 58);
            this.textBox_DersAdi.Name = "textBox_DersAdi";
            this.textBox_DersAdi.ReadOnly = true;
            this.textBox_DersAdi.Size = new System.Drawing.Size(217, 27);
            this.textBox_DersAdi.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ders Adı";
            // 
            // textBox_FinalNotu
            // 
            this.textBox_FinalNotu.Location = new System.Drawing.Point(12, 135);
            this.textBox_FinalNotu.MaxLength = 3;
            this.textBox_FinalNotu.Name = "textBox_FinalNotu";
            this.textBox_FinalNotu.Size = new System.Drawing.Size(173, 27);
            this.textBox_FinalNotu.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(716, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Öğrenci Fotoğrafı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Final Notu";
            // 
            // textBox_Numarasi
            // 
            this.textBox_Numarasi.Location = new System.Drawing.Point(201, 58);
            this.textBox_Numarasi.Name = "textBox_Numarasi";
            this.textBox_Numarasi.ReadOnly = true;
            this.textBox_Numarasi.Size = new System.Drawing.Size(173, 27);
            this.textBox_Numarasi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Numarası";
            // 
            // textBox_AdSoyad
            // 
            this.textBox_AdSoyad.Location = new System.Drawing.Point(12, 58);
            this.textBox_AdSoyad.Name = "textBox_AdSoyad";
            this.textBox_AdSoyad.ReadOnly = true;
            this.textBox_AdSoyad.Size = new System.Drawing.Size(173, 27);
            this.textBox_AdSoyad.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Adı Soyadı";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel7.Controls.Add(this.button_NotGuncelle);
            this.panel7.Controls.Add(this.button_Temizle);
            this.panel7.Controls.Add(this.button_NotVer);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 470);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(900, 82);
            this.panel7.TabIndex = 5;
            // 
            // button_NotGuncelle
            // 
            this.button_NotGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_NotGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotGuncelle.ForeColor = System.Drawing.Color.White;
            this.button_NotGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("button_NotGuncelle.Image")));
            this.button_NotGuncelle.Location = new System.Drawing.Point(371, 10);
            this.button_NotGuncelle.Name = "button_NotGuncelle";
            this.button_NotGuncelle.Size = new System.Drawing.Size(158, 59);
            this.button_NotGuncelle.TabIndex = 0;
            this.button_NotGuncelle.Text = "Notu Güncelle";
            this.button_NotGuncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_NotGuncelle.UseVisualStyleBackColor = true;
            this.button_NotGuncelle.Click += new System.EventHandler(this.button_NotGuncelle_Click);
            // 
            // button_Temizle
            // 
            this.button_Temizle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.ForeColor = System.Drawing.Color.White;
            this.button_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_Temizle.Image")));
            this.button_Temizle.Location = new System.Drawing.Point(558, 10);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(106, 59);
            this.button_Temizle.TabIndex = 0;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // button_NotVer
            // 
            this.button_NotVer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_NotVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NotVer.ForeColor = System.Drawing.Color.White;
            this.button_NotVer.Image = ((System.Drawing.Image)(resources.GetObject("button_NotVer.Image")));
            this.button_NotVer.Location = new System.Drawing.Point(205, 10);
            this.button_NotVer.Name = "button_NotVer";
            this.button_NotVer.Size = new System.Drawing.Size(136, 59);
            this.button_NotVer.TabIndex = 0;
            this.button_NotVer.Text = "Not Ver";
            this.button_NotVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_NotVer.UseVisualStyleBackColor = true;
            this.button_NotVer.Click += new System.EventHandler(this.button_NotVer_Click);
            // 
            // FormOgrencilerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.dataGridView_Ogrenciler);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgrencilerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOgrencilerim";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ogrenciler)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox_Bilgiler.ResumeLayout(false);
            this.groupBox_Bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFoto)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView_Ogrenciler;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox_Bilgiler;
        private System.Windows.Forms.PictureBox pictureBox_OgrenciFoto;
        private System.Windows.Forms.TextBox textBox_VizeNotu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_DersAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_FinalNotu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Numarasi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_AdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_NotVer;
        private System.Windows.Forms.Button button_NotGuncelle;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.TextBox textBox_NotId;
        private System.Windows.Forms.Label label8;
    }
}