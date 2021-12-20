
namespace OkulSistemi
{
    partial class FormAlinanDersler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAlinanDersler));
            this.label5 = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_Ust = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView_AlinanDersler = new System.Windows.Forms.DataGridView();
            this.groupBox_DersBilgileri = new System.Windows.Forms.GroupBox();
            this.richTextBox_DersAciklamasi = new System.Windows.Forms.RichTextBox();
            this.textBox_DersAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DersinHocasi = new System.Windows.Forms.TextBox();
            this.pictureBox_OgretmenFoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_OgrenciAdi = new System.Windows.Forms.TextBox();
            this.pictureBox_OgrenciFoto = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_Ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlinanDersler)).BeginInit();
            this.groupBox_DersBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(336, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "İstanbul Medipol Üniversitesi";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Message.Location = new System.Drawing.Point(4, 7);
            this.label_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(52, 19);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Mesaj";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 30);
            this.panel1.TabIndex = 2;
            // 
            // panel_Ust
            // 
            this.panel_Ust.BackColor = System.Drawing.Color.White;
            this.panel_Ust.Controls.Add(this.label3);
            this.panel_Ust.Controls.Add(this.label_Cikis);
            this.panel_Ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ust.Location = new System.Drawing.Point(0, 0);
            this.panel_Ust.Name = "panel_Ust";
            this.panel_Ust.Size = new System.Drawing.Size(900, 30);
            this.panel_Ust.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label3.Location = new System.Drawing.Point(383, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Alınan Dersler";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Cikis.Location = new System.Drawing.Point(871, 1);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 2;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 15);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView_AlinanDersler
            // 
            this.dataGridView_AlinanDersler.AllowUserToAddRows = false;
            this.dataGridView_AlinanDersler.AllowUserToDeleteRows = false;
            this.dataGridView_AlinanDersler.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_AlinanDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AlinanDersler.GridColor = System.Drawing.Color.Black;
            this.dataGridView_AlinanDersler.Location = new System.Drawing.Point(8, 70);
            this.dataGridView_AlinanDersler.Name = "dataGridView_AlinanDersler";
            this.dataGridView_AlinanDersler.ReadOnly = true;
            this.dataGridView_AlinanDersler.Size = new System.Drawing.Size(900, 231);
            this.dataGridView_AlinanDersler.TabIndex = 9;
            this.dataGridView_AlinanDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AlinanDersler_CellClick);
            // 
            // groupBox_DersBilgileri
            // 
            this.groupBox_DersBilgileri.Controls.Add(this.richTextBox_DersAciklamasi);
            this.groupBox_DersBilgileri.Controls.Add(this.textBox_DersAdi);
            this.groupBox_DersBilgileri.Controls.Add(this.label4);
            this.groupBox_DersBilgileri.Controls.Add(this.label2);
            this.groupBox_DersBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBox_DersBilgileri.Location = new System.Drawing.Point(-1, 307);
            this.groupBox_DersBilgileri.Name = "groupBox_DersBilgileri";
            this.groupBox_DersBilgileri.Size = new System.Drawing.Size(304, 260);
            this.groupBox_DersBilgileri.TabIndex = 10;
            this.groupBox_DersBilgileri.TabStop = false;
            this.groupBox_DersBilgileri.Text = "Ders Bilgileri";
            // 
            // richTextBox_DersAciklamasi
            // 
            this.richTextBox_DersAciklamasi.Location = new System.Drawing.Point(23, 90);
            this.richTextBox_DersAciklamasi.Name = "richTextBox_DersAciklamasi";
            this.richTextBox_DersAciklamasi.ReadOnly = true;
            this.richTextBox_DersAciklamasi.Size = new System.Drawing.Size(255, 140);
            this.richTextBox_DersAciklamasi.TabIndex = 17;
            this.richTextBox_DersAciklamasi.Text = "";
            // 
            // textBox_DersAdi
            // 
            this.textBox_DersAdi.Location = new System.Drawing.Point(23, 38);
            this.textBox_DersAdi.Name = "textBox_DersAdi";
            this.textBox_DersAdi.ReadOnly = true;
            this.textBox_DersAdi.Size = new System.Drawing.Size(255, 27);
            this.textBox_DersAdi.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Adı ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_DersinHocasi);
            this.groupBox1.Controls.Add(this.pictureBox_OgretmenFoto);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(309, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 260);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "Fotoğrafı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Adı Soyadı";
            // 
            // textBox_DersinHocasi
            // 
            this.textBox_DersinHocasi.Location = new System.Drawing.Point(25, 41);
            this.textBox_DersinHocasi.Name = "textBox_DersinHocasi";
            this.textBox_DersinHocasi.ReadOnly = true;
            this.textBox_DersinHocasi.Size = new System.Drawing.Size(255, 27);
            this.textBox_DersinHocasi.TabIndex = 22;
            // 
            // pictureBox_OgretmenFoto
            // 
            this.pictureBox_OgretmenFoto.BackColor = System.Drawing.Color.White;
            this.pictureBox_OgretmenFoto.Location = new System.Drawing.Point(25, 93);
            this.pictureBox_OgretmenFoto.Name = "pictureBox_OgretmenFoto";
            this.pictureBox_OgretmenFoto.Size = new System.Drawing.Size(255, 137);
            this.pictureBox_OgretmenFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgretmenFoto.TabIndex = 24;
            this.pictureBox_OgretmenFoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox_OgrenciAdi);
            this.groupBox2.Controls.Add(this.pictureBox_OgrenciFoto);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(615, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 260);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fotoğrafı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 21;
            this.label8.Text = "Adı Soyadı";
            // 
            // textBox_OgrenciAdi
            // 
            this.textBox_OgrenciAdi.Location = new System.Drawing.Point(14, 41);
            this.textBox_OgrenciAdi.Name = "textBox_OgrenciAdi";
            this.textBox_OgrenciAdi.ReadOnly = true;
            this.textBox_OgrenciAdi.Size = new System.Drawing.Size(255, 27);
            this.textBox_OgrenciAdi.TabIndex = 22;
            // 
            // pictureBox_OgrenciFoto
            // 
            this.pictureBox_OgrenciFoto.BackColor = System.Drawing.Color.White;
            this.pictureBox_OgrenciFoto.Location = new System.Drawing.Point(14, 93);
            this.pictureBox_OgrenciFoto.Name = "pictureBox_OgrenciFoto";
            this.pictureBox_OgrenciFoto.Size = new System.Drawing.Size(255, 137);
            this.pictureBox_OgrenciFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgrenciFoto.TabIndex = 24;
            this.pictureBox_OgrenciFoto.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 16);
            this.panel2.TabIndex = 12;
            // 
            // FormAlinanDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_DersBilgileri);
            this.Controls.Add(this.dataGridView_AlinanDersler);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_Ust);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAlinanDersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAlinanDersler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Ust.ResumeLayout(false);
            this.panel_Ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AlinanDersler)).EndInit();
            this.groupBox_DersBilgileri.ResumeLayout(false);
            this.groupBox_DersBilgileri.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgrenciFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Ust;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView_AlinanDersler;
        private System.Windows.Forms.GroupBox groupBox_DersBilgileri;
        private System.Windows.Forms.RichTextBox richTextBox_DersAciklamasi;
        private System.Windows.Forms.TextBox textBox_DersAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DersinHocasi;
        private System.Windows.Forms.PictureBox pictureBox_OgretmenFoto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_OgrenciAdi;
        private System.Windows.Forms.PictureBox pictureBox_OgrenciFoto;
        private System.Windows.Forms.Panel panel2;
    }
}