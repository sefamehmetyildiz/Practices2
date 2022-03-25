using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_Kayit
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-GLAR9PS;Initial Catalog=PersonalVeriTabani;Integrated Security=True");

        void temizle()
        {
            Txtid.Text = "";
            Txtad.Text = "";
            TxtSoyad.Text = "";
            CmbSehirler.Text = "";
            MskMaas.Text = "";
            TxtMeslek.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            Txtad.Focus();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personalVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personalVeriTabaniDataSet.Tbl_Personel);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum,PerID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p0)", bağlantı);
            komut.Parameters.AddWithValue("@p0", Txtid.Text);
            komut.Parameters.AddWithValue("@p1", Txtad.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbSehirler.Text);
            komut.Parameters.AddWithValue("@p4", MskMaas.Text);
            komut.Parameters.AddWithValue("@p5", TxtMeslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery(); //çalıştırma işine yarıyor
            bağlantı.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked== true)
            {
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false)
            {
                label8.Text = "False";
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbSehirler.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if(label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Personel Where PerID=@k1", bağlantı);
            komutsil.Parameters.AddWithValue("@k1", Txtid.Text);
            komutsil.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Kayıt Silindi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            bağlantı.Open();
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Personel Set perad=@a1,persoyad=@a2,persehir=@a3,permaas=@a4,perdurum=@a5,permeslek=@a6,perıd=@a7 where PerID=@a7",bağlantı);
            komutguncelle.Parameters.AddWithValue("@a1", Txtad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", TxtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", CmbSehirler.Text);
            komutguncelle.Parameters.AddWithValue("@a4", MskMaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", TxtMeslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Txtid.Text);
            komutguncelle.ExecuteNonQuery();
            bağlantı.Close();
            MessageBox.Show("Personel Bilgi Güncellendi");
        }

        private void Btnİstatistikler_Click(object sender, EventArgs e)
        {
            Frmistatistik fr = new Frmistatistik();
            fr.Show();
        }

        private void BtnGrafikler_Click(object sender, EventArgs e)
        {
            Frmgrafikler frg = new Frmgrafikler();
            frg.Show();
        }


    }
}
