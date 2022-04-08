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
    public partial class frmDersİşlemleri : Form
    {
        public frmDersİşlemleri()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.Tbl_LessonsTableAdapter ds = new DataSet1TableAdapters.Tbl_LessonsTableAdapter();

        private void frmDersİşlemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersListesi();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ds.DersEkle(txtDersAd.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txtDersId.Text));
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.DersGüncelle(txtDersAd.Text,byte.Parse(txtDersId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDersId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
