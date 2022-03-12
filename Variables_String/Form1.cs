using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text;
            text = "Sefa Mehmet Yildiz";
            label1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name, surname;
            name = "sefa mehmet";
            surname = "yildiz";
            label2.Text = name;
            label3.Text = surname;
        }
    }
}
