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
    public partial class frmÖğrenciNotları : Form
    {
        public frmÖğrenciNotları()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-GLAR9PS;Initial Catalog=BonusOkul;Integrated Security=True");
        private void frmÖğrenciNotları_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select lessonname,exam1,exam2,exam3,project,avarage,status from tbl_marks inner join tbl_lessons on tbl_marks.lessonıd=tbl_lessons.lessonıd where studentıd=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            this.Text = numara.ToString();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
