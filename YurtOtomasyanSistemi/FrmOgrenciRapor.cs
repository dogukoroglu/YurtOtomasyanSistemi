using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtOtomasyanSistemi
{
    public partial class FrmOgrenciRapor : Form
    {
        public FrmOgrenciRapor()
        {
            InitializeComponent();
        }

        private void FrmOgrenciRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet9.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet9.Ogrenci);

            this.reportViewer1.RefreshReport();
        }
    }
}
