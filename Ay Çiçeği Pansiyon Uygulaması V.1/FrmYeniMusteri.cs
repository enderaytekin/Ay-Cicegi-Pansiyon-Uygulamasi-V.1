using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ay_Çiçeği_Pansiyon_Uygulaması_V._1
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

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
    }
}
