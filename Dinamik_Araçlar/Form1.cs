using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araçlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20 , 20);
            btn.Location = btnkonum;
            btn.Name = "Button1";
            btn.Text = "CLICK";
            btn.BackColor = Color.ForestGreen;
            btn.Height = 60;
            btn.Width = 180;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblkonum = new Point(250, 20);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "SefaMehmet";
            lbl.BackColor = Color.Yellow;
            lbl.Height = 60;
            lbl.Width = 180;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

            for (int i = 1; i < 6; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(350, i*30);
                txt.Location = txtkonum;
                txt.Name = "TextBox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);
            }
        }
    }
}
