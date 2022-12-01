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
    public partial class FrmGelirIstatistik : Form
    {
        public FrmGelirIstatistik()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmGelirIstatistik_Load(object sender, EventArgs e)
        {
            // KASADAKİ TOPLAM TUTAR
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblPara.Text = oku[0].ToString() + " TL";
            }
            bgl.baglanti().Close();

            // TEKRARSIZ OLARAK AYLARI COMBOBOX'TA LİSTELEME
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy) from Kasa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

            // GRAFİKLERE VERİTABANINDAN VERİ ÇEKME
            SqlCommand komut3 = new SqlCommand("select OdemeAy, sum(OdemeMiktar) from Kasa group by OdemeAy",bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddXY(oku3[0], oku3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMiktar) from Kasa where OdemeAy=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAyKazanç.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
