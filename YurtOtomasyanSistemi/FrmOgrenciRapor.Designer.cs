namespace YurtOtomasyanSistemi
{
    partial class FrmOgrenciRapor
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.yurtOtomasyonDataSet9 = new YurtOtomasyanSistemi.YurtOtomasyonDataSet9();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new YurtOtomasyanSistemi.YurtOtomasyonDataSet9TableAdapters.OgrenciTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ogrenciBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "YurtOtomasyanSistemi.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1181, 430);
            this.reportViewer1.TabIndex = 0;
            // 
            // yurtOtomasyonDataSet9
            // 
            this.yurtOtomasyonDataSet9.DataSetName = "YurtOtomasyonDataSet9";
            this.yurtOtomasyonDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.yurtOtomasyonDataSet9;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // FrmOgrenciRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 430);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmOgrenciRapor";
            this.Text = "FrmOgrenciRapor";
            this.Load += new System.EventHandler(this.FrmOgrenciRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yurtOtomasyonDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private YurtOtomasyonDataSet9 yurtOtomasyonDataSet9;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private YurtOtomasyonDataSet9TableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
    }
}