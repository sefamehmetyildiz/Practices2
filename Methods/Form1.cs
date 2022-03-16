using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void clean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();
        }
        private void colors()
        {
            textBox1.BackColor = Color.AliceBlue;
            textBox2.BackColor = Color.Gold;
            textBox3.BackColor = Color.Firebrick;
            textBox4.BackColor = Color.DarkBlue;
        }
        private void informations()
        {
            textBox1.Text = "Sefa";
            textBox2.Text = "Mehmet";
            textBox3.Text = "Yildiz";
            textBox4.Text = "Game Devoloper";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colors();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            informations();

        }
    }
}
