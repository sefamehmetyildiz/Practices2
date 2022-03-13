using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int truen = 0, falsen = 0, question = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnStart.Enabled = true;

            label4.Text = BtnB.Text;
            if (label5.Text == label4.Text)
            {
                truen++;
                lblTrue.Text = truen.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsen++;
                lblFalse.Text = falsen.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnStart.Enabled = true;

            label4.Text = BtnC.Text;
            if (label5.Text == label4.Text)
            {
                truen++;
                lblTrue.Text = truen.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsen++;
                lblFalse.Text = falsen.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnStart.Enabled = true;

            label4.Text = BtnD.Text;
            if (label5.Text == label4.Text)
            {
                truen++;
                lblTrue.Text = truen.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsen++;
                lblFalse.Text = falsen.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnStart.Enabled = true;

            label4.Text = BtnA.Text;
            if (label5.Text == label4.Text)
            {
                truen++;
                lblTrue.Text = truen.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                falsen++;
                lblFalse.Text = falsen.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnStart.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            question++;
            lblQuestion.Text = question.ToString();
            BtnStart.Text = "NEXT";

            if (question == 1)
            { 
            richTextBox1.Text = "CUMHURIYET KAC YILINDA KURULMUSTUR?";
            BtnA.Text = "1920";
            BtnB.Text = "1921";
            BtnC.Text = "1922";
            BtnD.Text = "1923";
                label5.Text = "1923";
            }
            if (question == 2)
            {
            richTextBox1.Text = "HANGI SEHIR EGE BOLGEMIZDE BULUNMAZ?";
            BtnA.Text = "IZMIR";
            BtnB.Text = "BALIKESIR";
            BtnC.Text = "MANISA";
            BtnD.Text = "AYDIN";
                label5.Text = "BALIKESIR";
            }
            if (question == 3)
            {
                richTextBox1.Text = "SON KUSLAR HANGI YAZARIMIZA AITTIR?";
                BtnA.Text = "SAIT FAIK";
                BtnB.Text = "ATTILA ILHAN";
                BtnC.Text = "CEMAL SUREYA";
                BtnD.Text = "RESAT NURI";
                BtnStart.Text = "RESULTS";
                label5.Text = "SAIT FAIK";
            }
            if (question == 4 )
            {
                MessageBox.Show("----FINISHED----"+"\n"+"True: " + truen + "\n" + "False: " + falsen);
                BtnStart.Text = "FINISHED";
            }
        }
        
	

	}

    }

