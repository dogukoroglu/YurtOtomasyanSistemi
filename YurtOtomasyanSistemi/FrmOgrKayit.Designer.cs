namespace YurtOtomasyanSistemi
{
    partial class FrmOgrKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrKayit));
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrAd = new System.Windows.Forms.TextBox();
            this.txtOgrSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskOgrTc = new System.Windows.Forms.MaskedTextBox();
            this.mskOgrTel = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbOgrBolum = new System.Windows.Forms.ComboBox();
            this.txtOgrMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbOdaNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVeliadsoyad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskVeliTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rchAdres = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(44, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ad:";
            // 
            // txtOgrAd
            // 
            this.txtOgrAd.Location = new System.Drawing.Point(150, 22);
            this.txtOgrAd.Name = "txtOgrAd";
            this.txtOgrAd.Size = new System.Drawing.Size(189, 28);
            this.txtOgrAd.TabIndex = 1;
            // 
            // txtOgrSoyad
            // 
            this.txtOgrSoyad.Location = new System.Drawing.Point(150, 56);
            this.txtOgrSoyad.Name = "txtOgrSoyad";
            this.txtOgrSoyad.Size = new System.Drawing.Size(189, 28);
            this.txtOgrSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(45, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci TC:";
            // 
            // mskOgrTc
            // 
            this.mskOgrTc.Location = new System.Drawing.Point(150, 90);
            this.mskOgrTc.Mask = "00000000000";
            this.mskOgrTc.Name = "mskOgrTc";
            this.mskOgrTc.Size = new System.Drawing.Size(189, 28);
            this.mskOgrTc.TabIndex = 5;
            this.mskOgrTc.ValidatingType = typeof(int);
            // 
            // mskOgrTel
            // 
            this.mskOgrTel.Location = new System.Drawing.Point(150, 124);
            this.mskOgrTel.Mask = "(999) 000-0000";
            this.mskOgrTel.Name = "mskOgrTel";
            this.mskOgrTel.Size = new System.Drawing.Size(189, 28);
            this.mskOgrTel.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Öğrenci Telefon:";
            // 
            // mskDogumTarihi
            // 
            this.mskDogumTarihi.Location = new System.Drawing.Point(150, 158);
            this.mskDogumTarihi.Mask = "00/00/0000";
            this.mskDogumTarihi.Name = "mskDogumTarihi";
            this.mskDogumTarihi.Size = new System.Drawing.Size(189, 28);
            this.mskDogumTarihi.TabIndex = 9;
            this.mskDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(26, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Doğum Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Öğrenci Bölüm:";
            // 
            // cmbOgrBolum
            // 
            this.cmbOgrBolum.FormattingEnabled = true;
            this.cmbOgrBolum.Location = new System.Drawing.Point(150, 192);
            this.cmbOgrBolum.Name = "cmbOgrBolum";
            this.cmbOgrBolum.Size = new System.Drawing.Size(189, 29);
            this.cmbOgrBolum.TabIndex = 11;
            // 
            // txtOgrMail
            // 
            this.txtOgrMail.Location = new System.Drawing.Point(150, 227);
            this.txtOgrMail.Name = "txtOgrMail";
            this.txtOgrMail.Size = new System.Drawing.Size(189, 28);
            this.txtOgrMail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(32, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 12;
            this.label7.Text = "Öğrenci Mail:";
            // 
            // cmbOdaNo
            // 
            this.cmbOdaNo.FormattingEnabled = true;
            this.cmbOdaNo.Location = new System.Drawing.Point(150, 261);
            this.cmbOdaNo.Name = "cmbOdaNo";
            this.cmbOdaNo.Size = new System.Drawing.Size(189, 29);
            this.cmbOdaNo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(5, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 21);
            this.label8.TabIndex = 14;
            this.label8.Text = "Öğrenci Oda No:";
            // 
            // txtVeliadsoyad
            // 
            this.txtVeliadsoyad.Location = new System.Drawing.Point(150, 296);
            this.txtVeliadsoyad.Name = "txtVeliadsoyad";
            this.txtVeliadsoyad.Size = new System.Drawing.Size(189, 28);
            this.txtVeliadsoyad.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(23, 299);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 21);
            this.label9.TabIndex = 16;
            this.label9.Text = "Veli Ad-Soyad:";
            // 
            // mskVeliTelefon
            // 
            this.mskVeliTelefon.Location = new System.Drawing.Point(150, 330);
            this.mskVeliTelefon.Mask = "(999) 000-0000";
            this.mskVeliTelefon.Name = "mskVeliTelefon";
            this.mskVeliTelefon.Size = new System.Drawing.Size(189, 28);
            this.mskVeliTelefon.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(40, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Veli Telefon:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(40, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Veli Adres:";
            // 
            // rchAdres
            // 
            this.rchAdres.Location = new System.Drawing.Point(150, 364);
            this.rchAdres.Name = "rchAdres";
            this.rchAdres.Size = new System.Drawing.Size(189, 83);
            this.rchAdres.TabIndex = 21;
            this.rchAdres.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(173, 453);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 35);
            this.btnKaydet.TabIndex = 22;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 21);
            this.label12.TabIndex = 23;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // FrmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(354, 512);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.rchAdres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mskVeliTelefon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVeliadsoyad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbOdaNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOgrMail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbOgrBolum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskDogumTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mskOgrTel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mskOgrTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOgrSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOgrAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgrKayit";
            this.Text = "Öğrenci Kayıt";
            this.Load += new System.EventHandler(this.FrmOgrKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrAd;
        private System.Windows.Forms.TextBox txtOgrSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskOgrTc;
        private System.Windows.Forms.MaskedTextBox mskOgrTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskDogumTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbOgrBolum;
        private System.Windows.Forms.TextBox txtOgrMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbOdaNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVeliadsoyad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskVeliTelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rchAdres;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label12;
    }
}

