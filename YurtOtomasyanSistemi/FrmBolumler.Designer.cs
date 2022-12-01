namespace YurtOtomasyanSistemi
{
    partial class FrmBolumler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBolumler));
            this.pcbBolumEkle = new System.Windows.Forms.PictureBox();
            this.pcbBolumGuncelle = new System.Windows.Forms.PictureBox();
            this.pcbBolumSil = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBolumid = new System.Windows.Forms.TextBox();
            this.txtBolumad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bolumidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bolumlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yurtOtomasyonDataSet = new YurtOtomasyanSistemi.YurtOtomasyonDataSet();
            this.bolumlerTableAdapter = new YurtOtomasyanSistemi.YurtOtomasyonDataSetTableAdapters.BolumlerTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbBolumEkle
            // 
            this.pcbBolumEkle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumEkle.Image")));
            this.pcbBolumEkle.Location = new System.Drawing.Point(343, 47);
            this.pcbBolumEkle.Name = "pcbBolumEkle";
            this.pcbBolumEkle.Size = new System.Drawing.Size(71, 44);
            this.pcbBolumEkle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumEkle.TabIndex = 0;
            this.pcbBolumEkle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumEkle, "Bölüm Ekle");
            this.pcbBolumEkle.Click += new System.EventHandler(this.pcbBolumEkle_Click);
            // 
            // pcbBolumGuncelle
            // 
            this.pcbBolumGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumGuncelle.Image")));
            this.pcbBolumGuncelle.Location = new System.Drawing.Point(382, 97);
            this.pcbBolumGuncelle.Name = "pcbBolumGuncelle";
            this.pcbBolumGuncelle.Size = new System.Drawing.Size(71, 44);
            this.pcbBolumGuncelle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumGuncelle.TabIndex = 1;
            this.pcbBolumGuncelle.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumGuncelle, "Bölüm Güncelle");
            this.pcbBolumGuncelle.Click += new System.EventHandler(this.pcbBolumGuncelle_Click);
            // 
            // pcbBolumSil
            // 
            this.pcbBolumSil.Image = ((System.Drawing.Image)(resources.GetObject("pcbBolumSil.Image")));
            this.pcbBolumSil.Location = new System.Drawing.Point(420, 47);
            this.pcbBolumSil.Name = "pcbBolumSil";
            this.pcbBolumSil.Size = new System.Drawing.Size(69, 44);
            this.pcbBolumSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBolumSil.TabIndex = 2;
            this.pcbBolumSil.TabStop = false;
            this.toolTip1.SetToolTip(this.pcbBolumSil, "Bölüm Sil");
            this.pcbBolumSil.Click += new System.EventHandler(this.pcbBolumSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bölüm ID:";
            // 
            // txtBolumid
            // 
            this.txtBolumid.Enabled = false;
            this.txtBolumid.Location = new System.Drawing.Point(115, 47);
            this.txtBolumid.Name = "txtBolumid";
            this.txtBolumid.Size = new System.Drawing.Size(181, 28);
            this.txtBolumid.TabIndex = 4;
            // 
            // txtBolumad
            // 
            this.txtBolumad.Location = new System.Drawing.Point(115, 81);
            this.txtBolumad.Name = "txtBolumad";
            this.txtBolumad.Size = new System.Drawing.Size(181, 28);
            this.txtBolumad.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bölüm Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bolumidDataGridViewTextBoxColumn,
            this.bolumAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bolumlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(509, 200);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bolumidDataGridViewTextBoxColumn
            // 
            this.bolumidDataGridViewTextBoxColumn.DataPropertyName = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.HeaderText = "Bolumid";
            this.bolumidDataGridViewTextBoxColumn.Name = "bolumidDataGridViewTextBoxColumn";
            this.bolumidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bolumAdDataGridViewTextBoxColumn
            // 
            this.bolumAdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bolumAdDataGridViewTextBoxColumn.DataPropertyName = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.HeaderText = "BolumAd";
            this.bolumAdDataGridViewTextBoxColumn.Name = "bolumAdDataGridViewTextBoxColumn";
            // 
            // bolumlerBindingSource
            // 
            this.bolumlerBindingSource.DataMember = "Bolumler";
            this.bolumlerBindingSource.DataSource = this.yurtOtomasyonDataSet;
            // 
            // yurtOtomasyonDataSet
            // 
            this.yurtOtomasyonDataSet.DataSetName = "YurtOtomasyonDataSet";
            this.yurtOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bolumlerTableAdapter
            // 
            this.bolumlerTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBolumler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(77)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(508, 371);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBolumad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBolumid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbBolumSil);
            this.Controls.Add(this.pcbBolumGuncelle);
            this.Controls.Add(this.pcbBolumEkle);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBolumler";
            this.Text = "Bölümler";
            this.Load += new System.EventHandler(this.FrmBolumler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumEkle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumGuncelle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBolumSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolumlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbBolumEkle;
        private System.Windows.Forms.PictureBox pcbBolumGuncelle;
        private System.Windows.Forms.PictureBox pcbBolumSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBolumid;
        private System.Windows.Forms.TextBox txtBolumad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YurtOtomasyonDataSet yurtOtomasyonDataSet;
        private System.Windows.Forms.BindingSource bolumlerBindingSource;
        private YurtOtomasyonDataSetTableAdapters.BolumlerTableAdapter bolumlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bolumAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}