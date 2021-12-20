
namespace OkulSistemi
{
    partial class FormAldigimDersler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAldigimDersler));
            this.panel_Ust = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.dataGridView_AldigimDersler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox_DersBilgileri = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_OgretmenFoto = new System.Windows.Forms.PictureBox();
            this.button_SecimiTemizle = new System.Windows.Forms.Button();
            this.richTextBox_DersAciklamasi = new System.Windows.Forms.RichTextBox();
            this.textBox_DersinHocasi = new System.Windows.Forms.TextBox();
            this.textBox_DersAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel_Ust.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AldigimDersler)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox_DersBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Ust
            // 
            this.panel_Ust.BackColor = System.Drawing.Color.White;
            this.panel_Ust.Controls.Add(this.label1);
            this.panel_Ust.Controls.Add(this.label_Cikis);
            this.panel_Ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Ust.Location = new System.Drawing.Point(0, 0);
            this.panel_Ust.Name = "panel_Ust";
            this.panel_Ust.Size = new System.Drawing.Size(900, 30);
            this.panel_Ust.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(383, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aldığım Dersler";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Cikis.Location = new System.Drawing.Point(870, 1);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 2;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label_Message);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 570);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 30);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label5.Location = new System.Drawing.Point(322, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "İstanbul Medipol Üniversitesi";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label_Message.Location = new System.Drawing.Point(3, 5);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(52, 19);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Mesaj";
            // 
            // dataGridView_AldigimDersler
            // 
            this.dataGridView_AldigimDersler.AllowUserToAddRows = false;
            this.dataGridView_AldigimDersler.AllowUserToDeleteRows = false;
            this.dataGridView_AldigimDersler.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_AldigimDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_AldigimDersler.GridColor = System.Drawing.Color.Black;
            this.dataGridView_AldigimDersler.Location = new System.Drawing.Point(-1, 75);
            this.dataGridView_AldigimDersler.Name = "dataGridView_AldigimDersler";
            this.dataGridView_AldigimDersler.ReadOnly = true;
            this.dataGridView_AldigimDersler.Size = new System.Drawing.Size(900, 263);
            this.dataGridView_AldigimDersler.TabIndex = 2;
            this.dataGridView_AldigimDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_AldigimDersler_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox_DersBilgileri);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 231);
            this.panel2.TabIndex = 3;
            // 
            // groupBox_DersBilgileri
            // 
            this.groupBox_DersBilgileri.Controls.Add(this.label6);
            this.groupBox_DersBilgileri.Controls.Add(this.pictureBox_OgretmenFoto);
            this.groupBox_DersBilgileri.Controls.Add(this.button_SecimiTemizle);
            this.groupBox_DersBilgileri.Controls.Add(this.richTextBox_DersAciklamasi);
            this.groupBox_DersBilgileri.Controls.Add(this.textBox_DersinHocasi);
            this.groupBox_DersBilgileri.Controls.Add(this.textBox_DersAdi);
            this.groupBox_DersBilgileri.Controls.Add(this.label3);
            this.groupBox_DersBilgileri.Controls.Add(this.label4);
            this.groupBox_DersBilgileri.Controls.Add(this.label2);
            this.groupBox_DersBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_DersBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBox_DersBilgileri.Location = new System.Drawing.Point(0, 0);
            this.groupBox_DersBilgileri.Name = "groupBox_DersBilgileri";
            this.groupBox_DersBilgileri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox_DersBilgileri.Size = new System.Drawing.Size(900, 231);
            this.groupBox_DersBilgileri.TabIndex = 3;
            this.groupBox_DersBilgileri.TabStop = false;
            this.groupBox_DersBilgileri.Text = "Ders Bilgileri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Öğretmen Fotoğrafı";
            // 
            // pictureBox_OgretmenFoto
            // 
            this.pictureBox_OgretmenFoto.BackColor = System.Drawing.Color.White;
            this.pictureBox_OgretmenFoto.Location = new System.Drawing.Point(452, 88);
            this.pictureBox_OgretmenFoto.Name = "pictureBox_OgretmenFoto";
            this.pictureBox_OgretmenFoto.Size = new System.Drawing.Size(255, 137);
            this.pictureBox_OgretmenFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_OgretmenFoto.TabIndex = 10;
            this.pictureBox_OgretmenFoto.TabStop = false;
            // 
            // button_SecimiTemizle
            // 
            this.button_SecimiTemizle.FlatAppearance.BorderSize = 0;
            this.button_SecimiTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SecimiTemizle.Image = ((System.Drawing.Image)(resources.GetObject("button_SecimiTemizle.Image")));
            this.button_SecimiTemizle.Location = new System.Drawing.Point(773, 134);
            this.button_SecimiTemizle.Name = "button_SecimiTemizle";
            this.button_SecimiTemizle.Size = new System.Drawing.Size(75, 64);
            this.button_SecimiTemizle.TabIndex = 9;
            this.button_SecimiTemizle.UseVisualStyleBackColor = true;
            this.button_SecimiTemizle.Click += new System.EventHandler(this.button_SecimiTemizle_Click);
            // 
            // richTextBox_DersAciklamasi
            // 
            this.richTextBox_DersAciklamasi.Location = new System.Drawing.Point(105, 98);
            this.richTextBox_DersAciklamasi.Name = "richTextBox_DersAciklamasi";
            this.richTextBox_DersAciklamasi.ReadOnly = true;
            this.richTextBox_DersAciklamasi.Size = new System.Drawing.Size(255, 127);
            this.richTextBox_DersAciklamasi.TabIndex = 8;
            this.richTextBox_DersAciklamasi.Text = "";
            // 
            // textBox_DersinHocasi
            // 
            this.textBox_DersinHocasi.Location = new System.Drawing.Point(452, 38);
            this.textBox_DersinHocasi.Name = "textBox_DersinHocasi";
            this.textBox_DersinHocasi.ReadOnly = true;
            this.textBox_DersinHocasi.Size = new System.Drawing.Size(255, 27);
            this.textBox_DersinHocasi.TabIndex = 6;
            // 
            // textBox_DersAdi
            // 
            this.textBox_DersAdi.Location = new System.Drawing.Point(105, 38);
            this.textBox_DersAdi.Name = "textBox_DersAdi";
            this.textBox_DersAdi.ReadOnly = true;
            this.textBox_DersAdi.Size = new System.Drawing.Size(255, 27);
            this.textBox_DersAdi.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(452, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Öğretmen Adı Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(105, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Açıklaması";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(105, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı ";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 15);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 15);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 15);
            this.panel5.TabIndex = 5;
            // 
            // FormAldigimDersler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView_AldigimDersler);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Ust);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAldigimDersler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAldigimDersler";
            this.panel_Ust.ResumeLayout(false);
            this.panel_Ust.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_AldigimDersler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox_DersBilgileri.ResumeLayout(false);
            this.groupBox_DersBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_OgretmenFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Ust;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.DataGridView dataGridView_AldigimDersler;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox_DersBilgileri;
        private System.Windows.Forms.RichTextBox richTextBox_DersAciklamasi;
        private System.Windows.Forms.TextBox textBox_DersinHocasi;
        private System.Windows.Forms.TextBox textBox_DersAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_SecimiTemizle;
        private System.Windows.Forms.PictureBox pictureBox_OgretmenFoto;
        private System.Windows.Forms.Label label6;
    }
}