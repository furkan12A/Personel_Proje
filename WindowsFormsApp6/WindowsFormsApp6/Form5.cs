using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            SqlConnection Üye = new SqlConnection("server=.; Initial Catalog=ÜYEGİRİŞİ;Integrated Security=SSPI");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool cinsiyet = false;

            if (radioButton1.Checked == true)
            {
                cinsiyet = true;
            }
            else if (radioButton2.Checked == true)
            {
                cinsiyet = false;
            }
            else
            {
                cinsiyet = false;
            }

            var ekle = "INSERT INTO kullanicilar(isim,soyisim,telefon,tc,adres,cinsiyet) values (@isim," +
                " @soyisim, @telefon, @tc, @adres, @cinsiyet)";

            SqlCommand komut = new SqlCommand();
           
           

           

            komut.Parameters.AddWithValue("@isim", textBox1.Text);
            komut.Parameters.AddWithValue("@soyisim", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@tc", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@adres", richTextBox1.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyet);

            
           





        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
        }
    }
}
