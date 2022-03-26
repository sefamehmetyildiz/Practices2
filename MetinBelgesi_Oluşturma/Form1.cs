using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MetinBelgesi_Oluşturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StreamWriter sw;
        string dosyaadi, dosyayolu;

        private void button2_Click(object sender, EventArgs e)
        {
            dosyaadi = textBox2.Text;
            sw = File.CreateText(dosyayolu + "//" + dosyaadi + ".txt");
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir = sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog1.Title = "Metin Dosyasi Olusturma";
            saveFileDialog1.ShowDialog();
            StreamWriter sw2 = new StreamWriter(saveFileDialog1.FileName);
            sw2.WriteLine(richTextBox1.Text);
            sw2.Close();
            MessageBox.Show("Kayit Olusturuldu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                dosyayolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }
        }
    }
}
