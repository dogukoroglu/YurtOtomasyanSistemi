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
using System.Net.Configuration;
using System.Data.Common;

namespace YurtOtomasyanSistemi
{
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }

       
        public string id, ad, soyad, tc,telefon,dogum,bolum,mail,odano,veliad,velitel,adres;

        private void btnSil_Click(object sender, EventArgs e)
        {
            // ÖĞRENCİ SİLME İŞLEMİ
            SqlCommand komutSil = new SqlCommand("delete from Ogrenci where Ogrid=@k1", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@k1", txtOgrid.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            DataGVYenile();
            MessageBox.Show("Öğrenci kayıdı silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ODANIN AKTİF ÖĞRENCİ SAYISINI AZALTMA
            SqlCommand komutOda = new SqlCommand("update Odalar set OdaAktif=OdaAktif-1 where OdaNo=@oda",bgl.baglanti());
            komutOda.Parameters.AddWithValue("@oda", cmbOdaNo.Text);
            komutOda.ExecuteNonQuery();
            DataGVYenile();
            bgl.baglanti().Close();
        }

        void DataGVYenile()
        {
            FrmOgrListe frm1 = (FrmOgrListe)Application.OpenForms["FrmOgrListe"];
            frm1.listele();
        }

        SqlBaglanti bgl = new SqlBaglanti();
        
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set OgrAd=@p2,OgrSoyad=@p3,OgrTC=@p4,OgrTelefon=@p5,OgrDogum=@p6,OgrBolum=@p7,OgrMail=@p8,OgrOdaNo=@p9,OgrVeliAdSoyad=@p10,OgrVeliTelefon=@p11,OgrVeliAdres=@p12 where Ogrid=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrid.Text);
                komut.Parameters.AddWithValue("@p2", txtOgrAd.Text);
                komut.Parameters.AddWithValue("@p3", txtOgrSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskOgrTc.Text);
                komut.Parameters.AddWithValue("@p5", mskOgrTel.Text);
                komut.Parameters.AddWithValue("@p6", mskDogumTarihi.Text);
                komut.Parameters.AddWithValue("@p7", cmbOgrBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtOgrMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliadsoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                DataGVYenile();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleştirildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Güncelleme işlemi başarısız, tekrar deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void cmbBolumDoldurma()
        {
            // BÖLÜMLERİ COMBOBOX'A ÇEKME
            SqlCommand komutBolumListeleme = new SqlCommand("select * from Bolumler", bgl.baglanti());
            SqlDataReader dr = komutBolumListeleme.ExecuteReader();
            while (dr.Read())
            {
                cmbOgrBolum.Items.Add(dr["BolumAd"]);
            }
            bgl.baglanti().Close();
        }

        void cmbOdaNoDoldurma()
        {
            // ODA NUMARALARINI COMBOBOX'A ÇEKME
            SqlCommand komutOdaListeleme = new SqlCommand("select * from Odalar", bgl.baglanti());
            SqlDataReader dr2 = komutOdaListeleme.ExecuteReader();
            while (dr2.Read())
            {
                cmbOdaNo.Items.Add(dr2["OdaNo"]);
            }
            bgl.baglanti().Close();
        }

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrid.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            mskOgrTc.Text = tc;
            mskOgrTel.Text = telefon;
            mskDogumTarihi.Text = dogum;
            cmbOgrBolum.Text = bolum;
            txtOgrMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliadsoyad.Text = veliad;
            mskVeliTelefon.Text = velitel;
            rchAdres.Text = adres;
            cmbBolumDoldurma();
            cmbOdaNoDoldurma();
        }
    }
}
