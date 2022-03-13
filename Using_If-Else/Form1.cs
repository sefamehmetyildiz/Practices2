using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            if (number % 2 == 0 && number >= 10)
            {
                label1.Text = "Sayi çift veya 10dan büyük";
            }
            else
            {
                label1.Text = "Sayi tek veya 10dan küçük";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ex1, ex2, result, project;
            ex1 = Convert.ToDouble(textBox2.Text);
            ex2 = Convert.ToDouble(textBox3.Text);
            project = Convert.ToDouble(textBox4.Text);
            result = (ex1 + ex2 + project) / 3;
            if (result >= 50)
            {
                textBox5.Text = result.ToString("0.00") + "/Passed";
            }
            else
            {
                textBox5.Text = result.ToString("0.00") + "/Failed";
            }
        }
    }
}
