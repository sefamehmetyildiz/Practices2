using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Using_Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt16(textBox1.Text);
            switch (days)
            {
                case 1: label3.Text = "MONDAY";break;
                case 2: label3.Text = "TUESDAY"; break;
                case 3: label3.Text = "WEDNESDAY"; break;
                case 4: label3.Text = "THURSDAY"; break;
                case 5: label3.Text = "FRIDAY"; break;
                case 6: label3.Text = "SATURDAY"; break;
                case 7: label3.Text = "SUNDAY"; break;
                default: label3.Text = "WRONG NUMBER";break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1, number2, action;
            number1 = Convert.ToInt16(textBox2.Text);
            number2 = Convert.ToInt16(textBox3.Text);
            action = Convert.ToChar(textBox4.Text);
            switch (action)
            {
                case '+': MessageBox.Show("Result: " + (number1 + number2));break;
                case '-': MessageBox.Show("Result: " + (number1 - number2)); break;
                case '/': MessageBox.Show("Result: " + (number1 / number2)); break;
                case '*': MessageBox.Show("Result: " + (number1 * number2)); break;

                default: MessageBox.Show("WRONG ACTION");break;
                    
            }
        }
    }
}
