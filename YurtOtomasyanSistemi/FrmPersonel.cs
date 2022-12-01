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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet6.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet6.Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersoneAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde eklendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet6.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt ekleme işlemi başarısız, lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Personel where Personelid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde silindi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet6.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt silme işlemi başarısız, lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Personel set PersonelAdSoyad=@p1,PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersoneAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                komut.Parameters.AddWithValue("@p3", txtPersonelId.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde güncellendi!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.personelTableAdapter.Fill(this.yurtOtomasyonDataSet6.Personel);
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt güncelleme işlemi başarısız, lütfen tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, gorev, id;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            gorev = dataGridView1.Rows[secilen].Cells[2].Value.ToString();

            txtPersoneAd.Text = ad;
            txtPersonelGorev.Text = gorev;
            txtPersonelId.Text = id;
        }
    }
}
