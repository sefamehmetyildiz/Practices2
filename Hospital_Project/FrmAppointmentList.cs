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

namespace Hospital_Project
{
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();

        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Appointments", sql.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
    }
}
