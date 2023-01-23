using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        double odenecek = 0;


        public Form6()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxTutar.Clear();
            odenecek = 0;
            textBoxUrunAd.Clear();
            textBoxUrunFiyat.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double urunKDVsiz = Convert.ToDouble(textBoxUrunFiyat.Text);
            double urunKDV = (urunKDVsiz * 0.18) + urunKDVsiz;
            double urunSonFiyat = 0;
            if (radioButtonOgrenci.Checked == true)
            {
                urunSonFiyat = Math.Round((urunKDV - (urunKDV * 0.03)), 2);
                odenecek += urunSonFiyat;

            }
            else if (radioButtonYasli.Checked == true)
            {

                urunSonFiyat = Math.Round((urunKDV - (urunKDV * 0.05)), 2);
                odenecek += urunSonFiyat;
            }
            else if (radioButtonHicbiri.Checked == true)
            {
                urunSonFiyat = Math.Round(urunKDV, 2);
                odenecek += urunSonFiyat;
            }


            listBox1.Items.Add(textBoxUrunAd.Text + " " + urunSonFiyat + " TL");
            textBoxTutar.Text = odenecek + " TL";
            textBoxUrunAd.Clear();
            textBoxUrunFiyat.Clear();
        }
    }
}
