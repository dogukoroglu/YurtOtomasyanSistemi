using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyanSistemi
{
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string id, ad, soyad, kalan;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            txtKalan.Text = kalan;
            txtOgrid.Text = id;

        }

        void Temizle()
        {
            txtOgrid.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtOdenen.Clear();
            txtKalan.Clear();
            txtOdenenAy.Clear();
            txtOgrid.Focus();
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            // ÖDENEN TUTARI KALAN TUTARDAN DÜŞME İŞLEMİ
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt16(txtOdenen.Text);
            kalan = Convert.ToInt16(txtKalan.Text);
            yeniborc = kalan - odenen;
            txtKalan.Text = yeniborc.ToString();

            // YENİ TUTARI VERİ TABANINDA GÜNCELLEME
            SqlCommand komut = new SqlCommand("update Borclar set OgrKalanBorc=@p1 where Ogrid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", txtOgrid.Text);
            komut.Parameters.AddWithValue("@p1", txtKalan.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödemesi Yapıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.borclarTableAdapter.Fill(this.yurtOtomasyonDataSet2.Borclar);
            Temizle();

            // KASA TABLOSUNA EKLEME YAPMA
            SqlCommand komut2 = new SqlCommand("insert into Kasa (OdemeAy,OdemeMiktar) values (@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
