using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Dongusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1, total=0;
            while (i<=5)
            {
                listBox2.Items.Add("Hello Elazıg");
                listBox1.Items.Add(i);
                total = total + i;
                i++;
            }
            MessageBox.Show(total.ToString());
        }
    }
}
