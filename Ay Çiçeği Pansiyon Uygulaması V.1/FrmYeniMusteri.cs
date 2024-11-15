using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L5TD0TL\\SQLEXPRESS; Initial Catalog=Db_AycicegiPansiyon; Integrated Security=True");


        private void bttnOda101_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "101";
        }

        private void bttnOda102_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "102";
        }

        private void bttnOda103_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "103";
        }

        private void bttnOda104_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "104";
        }

        private void bttnOda105_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "105";
        }

        private void bttnOda106_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "106";
        }

        private void bttnOda107_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "107";
        }

        private void bttnOda108_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "108";
        }

        private void bttnOda109_Click(object sender, EventArgs e)
        {
            txtOdaNumarasi.Text = "109";
        }

        private void bttnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar DOLU Odaları Gösterir.", "Bilgilendirme");
        }

        private void bttnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar BOŞ Odaları Gösterir.", "Bilgilendirme");
        }

        private void dtTmPckrCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucukTarih = Convert.ToDateTime(dtTmPckrGirisTarihi.Text);
            DateTime buyukTarih = Convert.ToDateTime(dtTmPckrCikisTarihi.Text);

            TimeSpan sonuc = buyukTarih - kucukTarih;

            label11.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(label11.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void bttnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Tbl_MusteriEkle (Adi, Soyadi, Cinsiyet, Telefon, Mail, TCKimlikNo, OdaNo, Ucret, GirisTarihi, CikisTarihi) VALUES ('" + txtAdi.Text + "', '" + txtSoyadi.Text + "', '" + cmbBxCinsiyet.Text + "', '"+ mskdTxtBxTelefon.Text +"', '"+ txtMail.Text +"', '"+ txtTCKimlikNo.Text +"', '"+ txtOdaNumarasi.Text +"', '"+ txtUcret.Text +"', '"+ dtTmPckrGirisTarihi.Value.ToString("yyyy-MM-dd") +"', '"+ dtTmPckrCikisTarihi.Value.ToString("yyyy-MM-dd") +"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı.");

        }
    }
}
