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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string malzemeKodu = textBox1.Text;
            string malzemeAdi = textBox2.Text;
            string birim = comboBox1.Text;
            string birimFiyat = textBox3.Text;
            string tedarekçi = textBox4.Text;


            label11.Text = malzemeKodu;
            label12.Text = malzemeAdi;
            label13.Text = birim;
            label14.Text = birimFiyat;
            label15.Text = tedarekçi;

            groupBox1.Visible = true;


        }
    }
}
