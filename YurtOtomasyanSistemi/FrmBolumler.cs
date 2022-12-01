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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet.Bolumler' table. You can move, or remove it, as needed.
            this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);

        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutEkle = new SqlCommand("insert into Bolumler (BolumAd) values (@p1)", bgl.baglanti());
                komutEkle.Parameters.AddWithValue("@p1", txtBolumad.Text);
                komutEkle.ExecuteNonQuery();
                bgl.baglanti().Close();
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
                MessageBox.Show("Bölüm ekleme başarılı bir şekilde tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Hata, yeniden deneyiniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutSil = new SqlCommand("delete from Bolumler where Bolumid=@p1", bgl.baglanti());
                komutSil.Parameters.AddWithValue("@p1", txtBolumid.Text);
                komutSil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Silme işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtBolumid.Text = id;
            txtBolumad.Text = bolumad;

        }

        private void pcbBolumGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komutGuncelle = new SqlCommand("update Bolumler set BolumAd=@p1 where Bolumid=@p2", bgl.baglanti());
                komutGuncelle.Parameters.AddWithValue("@p2", txtBolumid.Text);
                komutGuncelle.Parameters.AddWithValue("@p1", txtBolumad.Text);
                komutGuncelle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.bolumlerTableAdapter.Fill(this.yurtOtomasyonDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
