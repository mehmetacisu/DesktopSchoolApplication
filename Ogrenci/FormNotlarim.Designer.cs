
namespace OkulSistemi
{
    partial class FormNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotlar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Cikis = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_Message = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox_NotBilgileri = new System.Windows.Forms.GroupBox();
            this.richTextBox_Aciklama = new System.Windows.Forms.RichTextBox();
            this.textBox_DersAdi = new System.Windows.Forms.TextBox();
            this.textBox_BasariDurumu = new System.Windows.Forms.TextBox();
            this.textBox_Final = new System.Windows.Forms.TextBox();
            this.button_SecimiTemizle = new System.Windows.Forms.Button();
            this.textBox_Vize = new System.Windows.Forms.TextBox();
            this.textBox_DersSahibi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView_Notlar = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox_NotBilgileri.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notlar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_Cikis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notlarım";
            // 
            // label_Cikis
            // 
            this.label_Cikis.AutoSize = true;
            this.label_Cikis.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cikis.Location = new System.Drawing.Point(870, 2);
            this.label_Cikis.Name = "label_Cikis";
            this.label_Cikis.Size = new System.Drawing.Size(28, 29);
            this.label_Cikis.TabIndex = 0;
            this.label_Cikis.Text = "X";
            this.label_Cikis.Click += new System.EventHandler(this.label_Cikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.label_Message);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 568);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 32);
            this.panel2.TabIndex = 1;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.Location = new System.Drawing.Point(5, 7);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(114, 19);
            this.label_Message.TabIndex = 1;
            this.label_Message.Text = "label_Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "İstanbul Medipol Üniversitesi";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(900, 16);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 552);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 16);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel5.Controls.Add(this.groupBox_NotBilgileri);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(900, 504);
            this.panel5.TabIndex = 3;
            // 
            // groupBox_NotBilgileri
            // 
            this.groupBox_NotBilgileri.Controls.Add(this.richTextBox_Aciklama);
            this.groupBox_NotBilgileri.Controls.Add(this.textBox_DersAdi);
            this.groupBox_NotBilgileri.Controls.Add(this.textBox_BasariDurumu);
            this.groupBox_NotBilgileri.Controls.Add(this.textBox_Final);
            this.groupBox_NotBilgileri.Controls.Add(this.button_SecimiTemizle);
            this.groupBox_NotBilgileri.Controls.Add(this.textBox_Vize);
            this.groupBox_NotBilgileri.Controls.Add(this.textBox_DersSahibi);
            this.groupBox_NotBilgileri.Controls.Add(this.label7);
            this.groupBox_NotBilgileri.Controls.Add(this.label6);
            this.groupBox_NotBilgileri.Controls.Add(this.label5);
            this.groupBox_NotBilgileri.Controls.Add(this.label4);
            this.groupBox_NotBilgileri.Controls.Add(this.label8);
            this.groupBox_NotBilgileri.Controls.Add(this.label3);
            this.groupBox_NotBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBox_NotBilgileri.Location = new System.Drawing.Point(25, 301);
            this.groupBox_NotBilgileri.Name = "groupBox_NotBilgileri";
            this.groupBox_NotBilgileri.Size = new System.Drawing.Size(853, 201);
            this.groupBox_NotBilgileri.TabIndex = 1;
            this.groupBox_NotBilgileri.TabStop = false;
            this.groupBox_NotBilgileri.Text = "Ders ve Not Bilgileri";
            // 
            // richTextBox_Aciklama
            // 
            this.richTextBox_Aciklama.Location = new System.Drawing.Point(135, 58);
            this.richTextBox_Aciklama.Name = "richTextBox_Aciklama";
            this.richTextBox_Aciklama.ReadOnly = true;
            this.richTextBox_Aciklama.Size = new System.Drawing.Size(192, 93);
            this.richTextBox_Aciklama.TabIndex = 10;
            this.richTextBox_Aciklama.Text = "";
            // 
            // textBox_DersAdi
            // 
            this.textBox_DersAdi.Location = new System.Drawing.Point(135, 25);
            this.textBox_DersAdi.Name = "textBox_DersAdi";
            this.textBox_DersAdi.ReadOnly = true;
            this.textBox_DersAdi.Size = new System.Drawing.Size(192, 27);
            this.textBox_DersAdi.TabIndex = 1;
            // 
            // textBox_BasariDurumu
            // 
            this.textBox_BasariDurumu.Location = new System.Drawing.Point(462, 141);
            this.textBox_BasariDurumu.Name = "textBox_BasariDurumu";
            this.textBox_BasariDurumu.ReadOnly = true;
            this.textBox_BasariDurumu.Size = new System.Drawing.Size(192, 27);
            this.textBox_BasariDurumu.TabIndex = 1;
            // 
            // textBox_Final
            // 
            this.textBox_Final.Location = new System.Drawing.Point(462, 91);
            this.textBox_Final.Name = "textBox_Final";
            this.textBox_Final.ReadOnly = true;
            this.textBox_Final.Size = new System.Drawing.Size(192, 27);
            this.textBox_Final.TabIndex = 1;
            // 
            // button_SecimiTemizle
            // 
            this.button_SecimiTemizle.FlatAppearance.BorderSize = 0;
            this.button_SecimiTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SecimiTemizle.Image = ((System.Drawing.Image)(resources.GetObject("button_SecimiTemizle.Image")));
            this.button_SecimiTemizle.Location = new System.Drawing.Point(737, 87);
            this.button_SecimiTemizle.Name = "button_SecimiTemizle";
            this.button_SecimiTemizle.Size = new System.Drawing.Size(75, 64);
            this.button_SecimiTemizle.TabIndex = 9;
            this.button_SecimiTemizle.UseVisualStyleBackColor = true;
            this.button_SecimiTemizle.Click += new System.EventHandler(this.button_SecimiTemizle_Click);
            // 
            // textBox_Vize
            // 
            this.textBox_Vize.Location = new System.Drawing.Point(462, 42);
            this.textBox_Vize.Name = "textBox_Vize";
            this.textBox_Vize.ReadOnly = true;
            this.textBox_Vize.Size = new System.Drawing.Size(192, 27);
            this.textBox_Vize.TabIndex = 1;
            // 
            // textBox_DersSahibi
            // 
            this.textBox_DersSahibi.Location = new System.Drawing.Point(135, 163);
            this.textBox_DersSahibi.Name = "textBox_DersSahibi";
            this.textBox_DersSahibi.ReadOnly = true;
            this.textBox_DersSahibi.Size = new System.Drawing.Size(192, 27);
            this.textBox_DersSahibi.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Başarı Durumu ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Final Notu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vize Notu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ders Adi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ders Açıklaması";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ders Sahibi";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView_Notlar);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 48);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(900, 281);
            this.panel6.TabIndex = 3;
            // 
            // dataGridView_Notlar
            // 
            this.dataGridView_Notlar.AllowUserToAddRows = false;
            this.dataGridView_Notlar.AllowUserToDeleteRows = false;
            this.dataGridView_Notlar.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_Notlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Notlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Notlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_Notlar.Name = "dataGridView_Notlar";
            this.dataGridView_Notlar.ReadOnly = true;
            this.dataGridView_Notlar.Size = new System.Drawing.Size(900, 281);
            this.dataGridView_Notlar.TabIndex = 0;
            this.dataGridView_Notlar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Notlar_CellClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 329);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(900, 16);
            this.panel7.TabIndex = 4;
            // 
            // FormNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNotlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNotlar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox_NotBilgileri.ResumeLayout(false);
            this.groupBox_NotBilgileri.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Notlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView_Notlar;
        private System.Windows.Forms.GroupBox groupBox_NotBilgileri;
        private System.Windows.Forms.TextBox textBox_DersAdi;
        private System.Windows.Forms.TextBox textBox_BasariDurumu;
        private System.Windows.Forms.TextBox textBox_Final;
        private System.Windows.Forms.Button button_SecimiTemizle;
        private System.Windows.Forms.TextBox textBox_Vize;
        private System.Windows.Forms.TextBox textBox_DersSahibi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RichTextBox richTextBox_Aciklama;
        private System.Windows.Forms.Label label8;
    }
}