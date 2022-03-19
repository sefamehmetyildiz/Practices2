using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 nesne = new Form2();
            nesne.mesaj1 = textBox1.Text;
            nesne.mesaj2 = textBox2.Text;

            nesne.Show(); //form2 yi görüntülememizi sağlar
        }
    }
}
