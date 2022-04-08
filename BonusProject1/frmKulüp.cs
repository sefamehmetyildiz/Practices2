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
namespace BonusProject1
{
    public partial class frmKulüp : Form
    {
        public frmKulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GLAR9PS;Initial Catalog=BonusOkul;Integrated Security=True");
        
        void liste()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_clubs", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmKulüp_Load(object sender, EventArgs e)
        {
            liste();

        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_clubs (clubname) values (@p1) ", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulüpAd.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKulüpId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtKulüpAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from tbl_clubs where clubıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulüpId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            liste();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_clubs set clubname=@p1 where clubıd=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKulüpAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKulüpId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            liste();

        }
    }
}
