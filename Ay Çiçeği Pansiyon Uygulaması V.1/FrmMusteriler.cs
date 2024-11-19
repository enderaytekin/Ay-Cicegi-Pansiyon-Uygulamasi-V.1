using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-6NMPSDG\\SQLEXPRESS03; Initial Catalog=Db_AycicegiPansiyon; Integrated Security=True");

        private void VerileriGoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Tbl_MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriId"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCKimlikNo"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void bttnVerileriGoster_Click(object sender, EventArgs e)
        {
            VerileriGoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            cmbBxCinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            mskdTxtBxTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTCKimlikNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtOdaNumarasi.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtTmPckrGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            dtTmPckrCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void bttnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Tbl_MusteriEkle WHERE MusteriId=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }

        private void bttnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Clear();
            txtSoyadi.Clear();
            cmbBxCinsiyet.Text = "";
            mskdTxtBxTelefon.Clear();
            txtMail.Clear();
            txtTCKimlikNo.Clear();
            txtOdaNumarasi.Clear();
            txtUcret.Clear();
            dtTmPckrGirisTarihi.Text = "";
            dtTmPckrCikisTarihi.Text = "";
        }

        private void bttnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Tbl_MusteriEkle SET Adi='" + txtAdi.Text + "', Soyadi='" + txtSoyadi.Text + "', Cinsiyet='" + cmbBxCinsiyet.Text + "', Telefon='" + mskdTxtBxTelefon.Text + "', Mail='" + txtMail.Text + "', TCKimlikNo='" + txtTCKimlikNo.Text + "', OdaNo='" + txtOdaNumarasi.Text + "', Ucret='" + txtUcret.Text + "', GirisTarihi='" + dtTmPckrGirisTarihi.Value.ToString("yyyy-MM-dd") + "', CikisTarihi='" + dtTmPckrCikisTarihi.Value.ToString("yyyy-MM-dd") + "' WHERE MusteriId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            VerileriGoster();
        }
    }
}
