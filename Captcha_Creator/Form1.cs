using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Captcha_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "+", "-", "*", "/", "#" };
            string[] sembol3 = { "A", "B", "C", "D", "E", "F", "G" };

            Random rast = new Random();
            int s1, s2, s3, s4;
            s1 = rast.Next(0, sembol1.Length);
            s2 = rast.Next(0, sembol2.Length);
            s3 = rast.Next(0, sembol3.Length);
            s4 = rast.Next(0, 10);

            label1.Text = sembol1[s1].ToString() + sembol2[s2].ToString() + sembol3[s3].ToString() + s4.ToString();

        }
    }
}
