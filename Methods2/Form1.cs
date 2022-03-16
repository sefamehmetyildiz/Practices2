using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Total(int n1, int n2)
        {
            int n3 = n1 + n2;
            return n3;
        } 
        private void button1_Click(object sender, EventArgs e)
        { 
            label1.Text = Total(2, 3).ToString();
            label2.Text = Total(6, 5).ToString();
            label3.Text = Total(7, 3).ToString();
        }
        private int Result(int s1, int s2)
        {
            int s3 = s1 * s2;
            return s3;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = Result(Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox1.Text)).ToString();
        }
        private int square(int number)
        {
            int result = number*number*number;
            return result;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = square(Convert.ToInt16(textBox3.Text)).ToString();
        }
    }
}
