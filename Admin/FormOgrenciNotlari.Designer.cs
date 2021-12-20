
namespace OkulSistemi
{
    partial class FormOgrenciNotlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOgrenciNotlari));
            this.dataGridView_Notlar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DersAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DersSahibi = new System.Windows.Forms.TextBox();
            this.label_Baslik = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Footer = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox_Aciklamasi = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_DersBilgisi = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_Final = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Vize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Ogrenci = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Temizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notlar)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_DersBilgisi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Notlar
            // 
            this.dataGridView_Notlar.AllowUserToAddRows = false;
            this.dataGridView_Notlar.AllowUserToDeleteRows = false;
            this.dataGridView_Notlar.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Notlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Notlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Notlar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Notlar.Name = "dataGridView_Notlar";
            this.dataGridView_Notlar.ReadOnly = true;
            this.dataGridView_Notlar.Size = new System.Drawing.Size(900, 214);
            this.dataGridView_Notlar.TabIndex = 0;
            this.dataGridView_Notlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Notlar_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adı";
            // 
            // textBox_DersAdi
            // 
            this.textBox_DersAdi.Location = new System.Drawing.Point(79, 48);
            this.textBox_DersAdi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DersAdi.Name = "textBox_DersAdi";
            this.textBox_DersAdi.ReadOnly = true;
            this.textBox_DersAdi.Size = new System.Drawing.Size(232, 27);
            this.textBox_DersAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Öğretmeni";
            // 
            // textBox_DersSahibi
            // 
            this.textBox_DersSahibi.Location = new System.Drawing.Point(79, 104);
            this.textBox_DersSahibi.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DersSahibi.Name = "textBox_DersSahibi";
            this.textBox_DersSahibi.ReadOnly = true;
            this.textBox_DersSahibi.Size = new System.Drawing.Size(232, 27);
            this.textBox_DersSahibi.TabIndex = 2;
            // 
            // label_Baslik
            // 
            this.label_Baslik.AutoSize = true;
            this.label_Baslik.Location = new System.Drawing.Point(391, 7);
            this.label_Baslik.Name = "label_Baslik";
            this.label_Baslik.Size = new System.Drawing.Size(114, 19);
            this.label_Baslik.TabIndex = 32;
            this.label_Baslik.Text = "Öğrenci Notları";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.Location = new System.Drawing.Point(872, 3);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(25, 25);
            this.label_Cikis.TabIndex = 28;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label_Baslik);
            this.panel3.Controls.Add(this.label_Cikis);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 32);
            this.panel3.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Controls.Add(this.label_Footer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 568);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 29;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(12, 7);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(114, 19);
            this.label_Message.TabIndex = 33;
            this.label_Message.Text = "label_Message";
            // 
            // label_Footer
            // 
            this.label_Footer.AutoSize = true;
            this.label_Footer.Location = new System.Drawing.Point(344, 7);
            this.label_Footer.Name = "label_Footer";
            this.label_Footer.Size = new System.Drawing.Size(212, 19);
            this.label_Footer.TabIndex = 32;
            this.label_Footer.Text = "İstanbul Medipol Üniversitesi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_Notlar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 214);
            this.panel2.TabIndex = 30;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 246);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 16);
            this.panel4.TabIndex = 31;
            // 
            // richTextBox_Aciklamasi
            // 
            this.richTextBox_Aciklamasi.Location = new System.Drawing.Point(75, 157);
            this.richTextBox_Aciklamasi.Name = "richTextBox_Aciklamasi";
            this.richTextBox_Aciklamasi.ReadOnly = true;
            this.richTextBox_Aciklamasi.Size = new System.Drawing.Size(259, 118);
            this.richTextBox_Aciklamasi.TabIndex = 32;
            this.richTextBox_Aciklamasi.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(75, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Açıklaması";
            // 
            // groupBox_DersBilgisi
            // 
            this.groupBox_DersBilgisi.Controls.Add(this.label1);
            this.groupBox_DersBilgisi.Controls.Add(this.richTextBox_Aciklamasi);
            this.groupBox_DersBilgisi.Controls.Add(this.textBox_DersAdi);
            this.groupBox_DersBilgisi.Controls.Add(this.label2);
            this.groupBox_DersBilgisi.Controls.Add(this.textBox_DersSahibi);
            this.groupBox_DersBilgisi.Controls.Add(this.label7);
            this.groupBox_DersBilgisi.ForeColor = System.Drawing.Color.White;
            this.groupBox_DersBilgisi.Location = new System.Drawing.Point(12, 268);
            this.groupBox_DersBilgisi.Name = "groupBox_DersBilgisi";
            this.groupBox_DersBilgisi.Size = new System.Drawing.Size(405, 294);
            this.groupBox_DersBilgisi.TabIndex = 33;
            this.groupBox_DersBilgisi.TabStop = false;
            this.groupBox_DersBilgisi.Text = "Ders Bilgileri";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_Final);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_Vize);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Ogrenci);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(449, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 294);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci ve Not Bilgisi";
            // 
            // textBox_Final
            // 
            this.textBox_Final.Location = new System.Drawing.Point(52, 206);
            this.textBox_Final.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Final.Name = "textBox_Final";
            this.textBox_Final.ReadOnly = true;
            this.textBox_Final.Size = new System.Drawing.Size(232, 27);
            this.textBox_Final.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Final";
            // 
            // textBox_Vize
            // 
            this.textBox_Vize.Location = new System.Drawing.Point(52, 146);
            this.textBox_Vize.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Vize.Name = "textBox_Vize";
            this.textBox_Vize.ReadOnly = true;
            this.textBox_Vize.Size = new System.Drawing.Size(232, 27);
            this.textBox_Vize.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(52, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vize";
            // 
            // textBox_Ogrenci
            // 
            this.textBox_Ogrenci.Location = new System.Drawing.Point(52, 77);
            this.textBox_Ogrenci.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Ogrenci.Name = "textBox_Ogrenci";
            this.textBox_Ogrenci.ReadOnly = true;
            this.textBox_Ogrenci.Size = new System.Drawing.Size(232, 27);
            this.textBox_Ogrenci.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Soyad";
            // 
            // button_Temizle
            // 
            this.button_Temizle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Temizle.ForeColor = System.Drawing.Color.White;
            this.button_Temizle.Image = ((System.Drawing.Image)(resources.GetObject("button_Temizle.Image")));
            this.button_Temizle.Location = new System.Drawing.Point(786, 369);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(111, 94);
            this.button_Temizle.TabIndex = 35;
            this.button_Temizle.Text = "Seçimi Temizle";
            this.button_Temizle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Temizle.UseVisualStyleBackColor = true;
            this.button_Temizle.Click += new System.EventHandler(this.button_Temizle_Click);
            // 
            // FormOgrenciNotlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.button_Temizle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_DersBilgisi);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOgrenciNotlari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOgrenciNotlari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notlar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox_DersBilgisi.ResumeLayout(false);
            this.groupBox_DersBilgisi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Notlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_DersAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DersSahibi;
        private System.Windows.Forms.Label label_Baslik;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Footer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox_Aciklamasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox_DersBilgisi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Final;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Vize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Ogrenci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Label label_Message;
    }
}