using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practices2
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        private void btnDecide_Click(object sender, EventArgs e)
        {
            string title = "Decide";
            string text = "Are you sure?";
            MessageBox.Show(text,title,MessageBoxButtons.YesNo);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "SefaMehmet";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "Sefa Mehmet";
            label6.Text = "YILDIZ";
            label8.Text = "Game Devoloper";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Dijital Oyun Tasarımı";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label9.Text = textBox2.Text;
            label10.Text = textBox3.Text;
            label11.Text = textBox4.Text;
        }
    }
}
