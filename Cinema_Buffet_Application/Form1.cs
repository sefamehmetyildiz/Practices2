using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Buffet_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            int till = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int popcorn, water, tea, ticket, total;
            popcorn = Convert.ToInt16(textBox1.Text);
            water = Convert.ToInt16(textBox2.Text);
            tea = Convert.ToInt16(textBox3.Text);
            ticket = Convert.ToInt16(textBox4.Text);
            total = popcorn * 4 + water * 2 + tea * 2 + ticket * 8;
            lblTotal.Text = total.ToString();
            till = till + total;
            lblTıll.Text = till.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox1.Focus();

        }
    }
}
