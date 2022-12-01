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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        private void FrmOgrKayit_Load(object sender, EventArgs e)
        {
            // Bölümleri Listeleme Komutları
            SqlCommand komut = new SqlCommand("select BolumAd from Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOgrBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            // Boş Odaları Listeleme Komutları
            SqlCommand komut2 = new SqlCommand("select Odano from Odalar where OdaKapasite != OdaAktif", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // ÖĞRENCİ BİLGİLERİNİ KAYIT ETME
            try
            {
                SqlCommand komutKaydet = new SqlCommand("insert into Ogrenci (OgrAd,OgrSoyad,OgrTC,OgrTelefon,OgrDogum,OgrBolum,OgrMail,OgrOdaNo,OgrVeliAdSoyad,OgrVeliTelefon,OgrVeliAdres) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutKaydet.Parameters.AddWithValue("@p1", txtOgrAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", mskOgrTc.Text);
                komutKaydet.Parameters.AddWithValue("@p4", mskOgrTel.Text);
                komutKaydet.Parameters.AddWithValue("@p5", mskDogumTarihi.Text);
                komutKaydet.Parameters.AddWithValue("@p6", cmbOgrBolum.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtOgrMail.Text);
                komutKaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p9", txtVeliadsoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutKaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Oluşturuldu!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

                // ÖĞRENCİ ID LABEL'E YAZDIRMA
                SqlCommand komut = new SqlCommand("select Ogrid from Ogrenci", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();


                // ÖĞRENCİ BORÇ ALANI OLUŞTURMA
                // label12'ye öğrenci id kaydettirdik ve visible özelliğini false yaptık
                SqlCommand komutKaydet2 = new SqlCommand("insert into Borclar (Ogrid,OgrAd,OgrSoyad) values (@b1,@b2,@b3)", bgl.baglanti());
                komutKaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutKaydet2.Parameters.AddWithValue("@b2", txtOgrAd.Text);
                komutKaydet2.Parameters.AddWithValue("@b3", txtOgrSoyad.Text);
                komutKaydet2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!, lütfen yeniden deneyin","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            // ÖĞRENCİ ODA KONTENJANINI ARTTIRMA(ders51)
            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif=OdaAktif+1 where OdaNo=@oda1",bgl.baglanti());
            komutOda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
            komutOda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
// Data Source=LAPTOP-GPMKKC5N\SQLEXPRESS;Initial Catalog=YurtOtomasyon;Integrated Security=True
