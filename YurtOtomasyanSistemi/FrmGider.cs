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
    public partial class FrmGider : Form
    {
        public FrmGider()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Giderler (Elektrik,Su,Dogalgaz,internet,Gıda,Personel,Diger) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("İşlem başarılı, kayıt oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("İşlem başarısız,lütfen tekrar deneyin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmGider_Load(object sender, EventArgs e)
        {

        }
    }
}
