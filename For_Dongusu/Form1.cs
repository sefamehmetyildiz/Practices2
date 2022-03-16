using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + " Hello Istanbul");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            for (int i = 0; i < 11; i++)
            {
                total = total + i;
            }
            label2.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number;
            number = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <= number; i++)
            {
                if (number%i == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fakto = 1, number2;
            number2 = Convert.ToInt16(textBox2.Text);
            for (int i = 1; i <= number2; i++)
            {
                fakto = fakto * i;
            }
            listBox3.Items.Add(fakto);
        }
    }
}
