﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_Arası_Veri_Aktarımı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string mesaj1, mesaj2;
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = mesaj1;
            label2.Text = mesaj2;
            comboBox1.Items.Add(mesaj1);
            comboBox1.Items.Add(mesaj2);
        }
    }
}
