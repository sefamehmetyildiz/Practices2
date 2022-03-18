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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();

            rb.renk = "Mavi";
            rb.hız = 160;
            rb.durum = 's';
            rb.motor = 1265.58;
            rb.fiyat = 50000;

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.durum.ToString();
            label4.Text = rb.motor.ToString();
            label5.Text = rb.fiyat.ToString();

            pictureBox1.BackColor = Color.DarkBlue;
        }
    }
}
