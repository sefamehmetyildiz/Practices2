using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 5)
            {
                this.BackColor = Color.Red;
            }
            if (sayac==10)
            {
                this.BackColor = Color.Blue;
                sayac = 0;
            }
        }
        int second = 0, minute=0, hour=0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            second++;
            label2.Text = second.ToString();
            if (second == 60)
            {
                minute++;
                second = 0;
                label3.Text = minute.ToString();
                if (minute == 3)
                {
                    hour++;
                    minute = 0;
                    label4.Text = hour.ToString();
                }
            }
        }
    }
}
