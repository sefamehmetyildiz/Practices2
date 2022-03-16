using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0, avarage;
            int[] marks = { 85, 70, 65, 100, 90 };
            foreach (int x in marks)
            {
                listBox1.Items.Add(x);
                total = total + x;
            }
            label1.Text = total.ToString();
            avarage = total / 5;
            label2.Text = avarage.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total2 = 0, a=0;
            int[] numbers2 = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            foreach (int n in numbers2)
            {
                if (n%4==0)
                {
                    listBox2.Items.Add(n);
                    total2 = total2 + n;
                    a++;
                }
                label5.Text = total2.ToString();
                label6.Text = a.ToString();
               
            }
        }
    }
}
