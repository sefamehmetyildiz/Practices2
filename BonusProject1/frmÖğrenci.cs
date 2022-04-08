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
    public partial class frmÖğrenci : Form
    {
        public frmÖğrenci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GLAR9PS;Initial Catalog=BonusOkul;Integrated Security=True");
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void frmÖğrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListesi();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_clubs", baglanti);
            da.Fill(dt);
            cmbKulüp.DisplayMember = "ClubName";
            cmbKulüp.ValueMember = "ClubID";
            cmbKulüp.DataSource = dt;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ÖğrenciListesi();
        }
        string c = "";

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            
            ds.ÖğrenciEkle(txtOGRAd.Text, txtOGRsoyad.Text, byte.Parse(cmbKulüp.SelectedValue.ToString()), c);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciSil(int.Parse(txtOGRId.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOGRId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOGRAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOGRsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmbKulüp.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()=="Man")
            {
                radioButtonErkek.Checked = true;
            }
            else
            {
                radioButtonKız.Checked = true;
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.ÖğrenciGüncelle(txtOGRAd.Text, txtOGRsoyad.Text, byte.Parse(cmbKulüp.SelectedValue.ToString()), c, int.Parse(txtOGRId.Text));
        }

        private void radioButtonKız_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKız.Checked == true)
            {
                c = "Woman";
            }
          
        }

        private void radioButtonErkek_CheckedChanged(object sender, EventArgs e)
        {
           
            if (radioButtonErkek.Checked == true)
            {
                c = "Man";
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = ds.ÖğrenciGetir(txtAra.Text);
        }
    }
}
