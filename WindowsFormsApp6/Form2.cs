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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void yeniMalzemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3= new Form3();
            frm3.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            button5.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.PerformClick();
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
