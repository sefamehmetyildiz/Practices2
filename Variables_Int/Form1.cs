using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables_Int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            number = 36;
            label1.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kenar, alan, cevre;
            kenar = 10;
            alan = kenar * kenar;
            cevre = kenar * 4;
            label2.Text = "Alan : " + alan;
            label3.Text = "Cevre : " + cevre;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number2;
            number2 = Convert.ToInt16(textBox1.Text);
            label5.Text = number2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number3, number4, toplam, fark, bolum, carp;
            number3 = Convert.ToInt16(textBox2.Text);
            number4 = Convert.ToInt16(textBox3.Text);
            toplam = number3 + number4;
            carp = number4 * number3;
            fark = number3 - number4;
            bolum = number3 / number4;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark: " + fark + "\n" + "Carpım:" + carp + "\n" + "Bolum: " + bolum);
            
        }
    }
}
