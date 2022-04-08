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
    public partial class frmNotlar : Form
    {
        public frmNotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GLAR9PS;Initial Catalog=BonusOkul;Integrated Security=True");
        DataSet1TableAdapters.Tbl_MarksTableAdapter ds = new DataSet1TableAdapters.Tbl_MarksTableAdapter();
        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOGRId.Text));
        }

        private void frmNotlar_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_lessons", baglanti);
            da.Fill(dt);
            cmbDers.DisplayMember = "LessonName";
            cmbDers.ValueMember = "LessonID";
            cmbDers.DataSource = dt;
        }
        int notid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid =int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtOGRId.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtSınav1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSınav2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtSınav3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtProje.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtORT.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


        }
            int sinav1, sinav2, sinav3, proje;
            double ortalama;
            string durum;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            sinav1 = Convert.ToInt16(txtSınav1.Text);
            sinav2 = Convert.ToInt16(txtSınav2.Text);
            sinav3 = Convert.ToInt16(txtSınav3.Text);
            proje = Convert.ToInt16(txtProje.Text);
            ortalama = (sinav1 + sinav2 + sinav3 + proje) / 4;
            txtORT.Text = ortalama.ToString();
            if (ortalama >= 50)
            {
                txtDurum.Text = "True";
            }
            else
            {
                txtDurum.Text = "False";
            }

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.notGüncelle(byte.Parse(cmbDers.SelectedValue.ToString()), int.Parse(txtOGRId.Text), byte.Parse(txtSınav1.Text), byte.Parse(txtSınav2.Text), byte.Parse(txtSınav3.Text), byte.Parse(txtProje.Text), decimal.Parse(txtORT.Text), bool.Parse(txtDurum.Text), notid);
        }
    }
}
