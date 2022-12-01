using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyanSistemi
{
    public partial class FrmGiderListesi : Form
    {
        public FrmGiderListesi()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmGiderListesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet4.Giderler' table. You can move, or remove it, as needed.
            this.giderlerTableAdapter.Fill(this.yurtOtomasyonDataSet4.Giderler);
        }
        public void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Giderler", bgl.baglanti());
            DataSet ds = new DataSet();
            da.Fill(ds, "Giderler");
            dataGridView1.DataSource = ds.Tables["Giderler"];
            bgl.baglanti().Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            frg.su = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            frg.dogalgaz = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            frg.gida = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            frg.personel = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            frg.diger = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            frg.Show();
        }
    }
}
