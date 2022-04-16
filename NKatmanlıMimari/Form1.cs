using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> perList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = perList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAD.Text;
            ent.Soyad = txtSoyAD.Text;
            ent.Sehir = txtSehir.Text;
            ent.Gorev = txtGörev.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Ad = txtAD.Text;
            ent.Soyad = txtSoyAD.Text;
            ent.Sehir = txtSehir.Text;
            ent.Gorev = txtGörev.Text;
            ent.Maas = short.Parse(txtMaas.Text);
            LogicPersonel.LLPersonelGüncelle(ent);

        }
    }
}
