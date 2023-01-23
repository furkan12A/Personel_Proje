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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string KulanıcıAdı = "admin";
        string sifre = "123";
        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            


            if (textBox1.Text == KulanıcıAdı && textBox2.Text == sifre)
            {
                Form2 frm2= new Form2();
                frm2.Show();
                this.Hide();

               
            }
            else
            {
                sayac++;
                MessageBox.Show("Hatalı Giriş Kardeş. Kalan Deneme Hakınız:" + (3-sayac) , "Hata !!", MessageBoxButtons.OK,MessageBoxIcon.Error );

                if (sayac == 3)
                {

                    MessageBox.Show("Deneme Hakınız Kalmadı :(");
                    Application.Exit();
                }
            }
        }
    }
}
