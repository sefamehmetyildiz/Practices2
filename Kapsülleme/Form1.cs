using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kapsülleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba(); //Araba sınıfından rb adında nesne türettik.

            rb.renk = "Mavi";
            rb.hız = 160;
            rb.durum = 's';
            rb.motor = 1265.58;
            rb.fiyat = 50000;
            rb.YIL = -2016;  //MUTLAK DEĞERİNİ ALACAK
            rb.MARKA = "golf";  //GİRİLEN HER KARAKTERİ BÜYÜK HARF YAPACAK
            rb.plaka = "34 SA 2022"; //ArabaDetay sınıfından gelen değişkendir.
            rb.muayene = 2020;  //ArabaDetay sınıfından gelen değişkendir.
            rb.sahip = "Sefa Mehmet Yıldız";  //ArabaDetay sınıfından gelen değişkendir.

            label1.Text = rb.renk;
            label2.Text = rb.hız.ToString();
            label3.Text = rb.durum.ToString();
            label4.Text = rb.motor.ToString();
            label5.Text = rb.fiyat.ToString();
            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKA;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.sahip;
            label10.Text = rb.plaka;

            pictureBox1.BackColor = Color.DarkBlue;
        }
    }
}
