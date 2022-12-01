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
    public partial class FrmYoneticiDuzenle : Form
    {
        public FrmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet5.Admin);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Admin(YoneticiAd,YoneticiSifre) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yönetici başarılı bir şekilde kayıt edildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Yönetici kayıt işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, sifre,id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sifre = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtKullaniciAd.Text = ad;
            txtSifre.Text = sifre;
            txtYoneticiId.Text = id;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Admin where Yoneticiid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtYoneticiId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yönetici kaydı başarılı bir şekilde silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Yönetici silme işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Admin set YoneticiAd=@p1,YoneticiSifre=@p2 where Yoneticiid=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSifre.Text);
                komut.Parameters.AddWithValue("@p3", txtYoneticiId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.adminTableAdapter.Fill(this.yurtOtomasyonDataSet5.Admin);
            }
            catch (Exception)
            {
                MessageBox.Show("Yönetici güncelleme işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
