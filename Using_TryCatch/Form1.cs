using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, total;
                n1 = Convert.ToInt16(textBox1.Text);
                n2 = Convert.ToInt16(textBox2.Text);
                total = n1 + n2;
                MessageBox.Show("Result=" + total);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check numbers");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, total;
                n1 = Convert.ToInt16(textBox3.Text);
                n2 = Convert.ToInt16(textBox4.Text);
                total = n1 + n2;
                MessageBox.Show("Result=" + total);

            }
            catch (Exception mistake)
            {
                MessageBox.Show(mistake.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int n1, n2, total;
                n1 = Convert.ToInt16(textBox5.Text);
                n2 = Convert.ToInt16(textBox6.Text);
                total = n1 + n2;
                MessageBox.Show("Result=" + total);

            }
            catch (Exception)
            {
                MessageBox.Show("Please check numbers");
            }
            finally
            {
                MessageBox.Show("Hata olsada olmasada nu kod çalışır");
            }
        }
    }
}
