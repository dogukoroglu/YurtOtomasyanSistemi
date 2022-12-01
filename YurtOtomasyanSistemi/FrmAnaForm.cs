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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtOtomasyonDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrKayit frm = new FrmOgrKayit();
            frm.Show();
            this.ogrenciTableAdapter.Fill(this.yurtOtomasyonDataSet1.Ogrenci);
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe frm = new FrmOgrListe();
            frm.Show();
        }

        private void öğrencToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrDuzenle frm = new FrmOgrDuzenle();
            frm.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler frm = new FrmBolumler();
            frm.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe frm = new FrmOgrListe();
            frm.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frm = new FrmOdemeler();
            frm.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGider frm = new FrmGider();
            frm.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderListesi frm = new FrmGiderListesi();
            frm.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGelirIstatistik frm = new FrmGelirIstatistik();
            frm.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYoneticiDuzenle frm = new FrmYoneticiDuzenle();
            frm.Show();
        }

        private void personelDüzenlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel frm = new FrmPersonel();
            frm.Show();
        }

        private void öğrenciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrenciRapor frm = new FrmOgrenciRapor();
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmAnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void giderİstatistikleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }
    }
}
