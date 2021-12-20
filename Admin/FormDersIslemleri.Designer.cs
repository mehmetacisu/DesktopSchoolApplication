
namespace OkulSistemi
{
    partial class FormDersIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDersIslemleri));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel_Butonlar = new System.Windows.Forms.Panel();
            this.groupBox_Islemler = new System.Windows.Forms.GroupBox();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Ekle = new System.Windows.Forms.Button();
            this.panel_Arama = new System.Windows.Forms.Panel();
            this.textBox_Arama = new System.Windows.Forms.TextBox();
            this.label_Arama = new System.Windows.Forms.Label();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel_Alt = new System.Windows.Forms.Panel();
            this.dataGridView_Ders = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox_Aciklama = new System.Windows.Forms.RichTextBox();
            this.textBox_Ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Durum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel_Butonlar.SuspendLayout();
            this.groupBox_Islemler.SuspendLayout();
            this.panel_Arama.SuspendLayout();
            this.panel_Footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.textBox_Id);
            this.panel1.Controls.Add(this.label3);
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
            this.textBox_Id.Location = new System.Drawing.Point(3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(24, 27);
            this.textBox_Id.TabIndex = 1;
            this.textBox_Id.Visible = false;
            this.textBox_Id.TextChanged += new System.EventHandler(this.textBox_Id_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(360, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ders İşlemleri";
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
            // panel_Butonlar
            // 
            this.panel_Butonlar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Butonlar.Controls.Add(this.groupBox_Islemler);
            this.panel_Butonlar.Location = new System.Drawing.Point(0, 461);
            this.panel_Butonlar.Name = "panel_Butonlar";
            this.panel_Butonlar.Size = new System.Drawing.Size(900, 75);
            this.panel_Butonlar.TabIndex = 0;
            // 
            // groupBox_Islemler
            // 
            this.groupBox_Islemler.Controls.Add(this.button_Temizle);
            this.groupBox_Islemler.Controls.Add(this.button_Guncelle);
            this.groupBox_Islemler.Controls.Add(this.button_Sil);
            this.groupBox_Islemler.Controls.Add(this.button_Ekle);
            this.groupBox_Islemler.ForeColor = System.Drawing.Color.White;
            this.groupBox_Islemler.Location = new System.Drawing.Point(187, 3);
            this.groupBox_Islemler.Name = "groupBox_Islemler";
            this.groupBox_Islemler.Size = new System.Drawing.Size(513, 69);
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
            // panel_Arama
            // 
            this.panel_Arama.Controls.Add(this.textBox_Arama);
            this.panel_Arama.Controls.Add(this.label_Arama);
            this.panel_Arama.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Arama.Location = new System.Drawing.Point(0, 32);
            this.panel_Arama.Name = "panel_Arama";
            this.panel_Arama.Size = new System.Drawing.Size(900, 32);
            this.panel_Arama.TabIndex = 0;
            // 
            // textBox_Arama
            // 
            this.textBox_Arama.Location = new System.Drawing.Point(425, 3);
            this.textBox_Arama.Name = "textBox_Arama";
            this.textBox_Arama.Size = new System.Drawing.Size(158, 27);
            this.textBox_Arama.TabIndex = 1;
            this.textBox_Arama.TextChanged += new System.EventHandler(this.textBox_Arama_TextChanged);
            // 
            // label_Arama
            // 
            this.label_Arama.AutoSize = true;
            this.label_Arama.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Arama.Location = new System.Drawing.Point(321, 7);
            this.label_Arama.Name = "label_Arama";
            this.label_Arama.Size = new System.Drawing.Size(92, 19);
            this.label_Arama.TabIndex = 0;
            this.label_Arama.Text = "Ders Arama";
            // 
            // panel_Footer
            // 
            this.panel_Footer.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Footer.Controls.Add(this.label_Message);
            this.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Footer.Location = new System.Drawing.Point(0, 568);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Size = new System.Drawing.Size(900, 32);
            this.panel_Footer.TabIndex = 0;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Message.ForeColor = System.Drawing.Color.White;
            this.label_Message.Location = new System.Drawing.Point(4, 7);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(52, 19);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Mesaj";
            // 
            // panel_Alt
            // 
            this.panel_Alt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Alt.Location = new System.Drawing.Point(0, 536);
            this.panel_Alt.Name = "panel_Alt";
            this.panel_Alt.Size = new System.Drawing.Size(900, 32);
            this.panel_Alt.TabIndex = 0;
            // 
            // dataGridView_Ders
            // 
            this.dataGridView_Ders.AllowUserToAddRows = false;
            this.dataGridView_Ders.AllowUserToDeleteRows = false;
            this.dataGridView_Ders.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Ders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_Ders.Location = new System.Drawing.Point(0, 64);
            this.dataGridView_Ders.Name = "dataGridView_Ders";
            this.dataGridView_Ders.ReadOnly = true;
            this.dataGridView_Ders.Size = new System.Drawing.Size(900, 245);
            this.dataGridView_Ders.TabIndex = 0;
            this.dataGridView_Ders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Ders_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox_Aciklama);
            this.panel2.Controls.Add(this.textBox_Ad);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox_Durum);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 154);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox_Aciklama
            // 
            this.richTextBox_Aciklama.Location = new System.Drawing.Point(645, 13);
            this.richTextBox_Aciklama.Name = "richTextBox_Aciklama";
            this.richTextBox_Aciklama.Size = new System.Drawing.Size(233, 96);
            this.richTextBox_Aciklama.TabIndex = 4;
            this.richTextBox_Aciklama.Text = "";
            // 
            // textBox_Ad
            // 
            this.textBox_Ad.ForeColor = System.Drawing.Color.Black;
            this.textBox_Ad.Location = new System.Drawing.Point(54, 49);
            this.textBox_Ad.Name = "textBox_Ad";
            this.textBox_Ad.Size = new System.Drawing.Size(154, 27);
            this.textBox_Ad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(542, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı";
            // 
            // comboBox_Durum
            // 
            this.comboBox_Durum.ForeColor = System.Drawing.Color.Black;
            this.comboBox_Durum.FormattingEnabled = true;
            this.comboBox_Durum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboBox_Durum.Location = new System.Drawing.Point(346, 49);
            this.comboBox_Durum.Name = "comboBox_Durum";
            this.comboBox_Durum.Size = new System.Drawing.Size(154, 27);
            this.comboBox_Durum.TabIndex = 2;
            this.comboBox_Durum.Text = "Durumunu Seçiniz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(265, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Durumu";
            // 
            // FormDersIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_Ders);
            this.Controls.Add(this.panel_Alt);
            this.Controls.Add(this.panel_Footer);
            this.Controls.Add(this.panel_Arama);
            this.Controls.Add(this.panel_Butonlar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDersIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDersIslemleri";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Butonlar.ResumeLayout(false);
            this.groupBox_Islemler.ResumeLayout(false);
            this.panel_Arama.ResumeLayout(false);
            this.panel_Arama.PerformLayout();
            this.panel_Footer.ResumeLayout(false);
            this.panel_Footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Butonlar;
        private System.Windows.Forms.Panel panel_Arama;
        private System.Windows.Forms.Panel panel_Footer;
        private System.Windows.Forms.Panel panel_Alt;
        private System.Windows.Forms.DataGridView dataGridView_Ders;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Arama;
        private System.Windows.Forms.TextBox textBox_Arama;
        private System.Windows.Forms.GroupBox groupBox_Islemler;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Ekle;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox_Aciklama;
        private System.Windows.Forms.ComboBox comboBox_Durum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Label label3;
    }
}