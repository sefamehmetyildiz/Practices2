using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Yeşil";
            rb2.hız = 140;
            rb2.durum = 'i';
            rb2.motor = 1365.58;
            rb2.fiyat = 35800;

            label1.Text = rb2.renk;
            label2.Text = rb2.hız.ToString();
            label3.Text = rb2.durum.ToString();
            label4.Text = rb2.motor.ToString();
            label5.Text = rb2.fiyat.ToString();

            pictureBox1.BackColor = Color.DarkSeaGreen;
        }
    }
}
