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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            TxtName.Focus();

            //datagride veri çekme  
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doctors", sql.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            //branşları cmbboxa aktarma
            SqlCommand command10 = new SqlCommand("Select BranchName From Tbl_Branches", sql.connection());
            SqlDataReader dr2 = command10.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            sql.connection().Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Insert into Tbl_Doctors (doctorname,doctorsurname,doctorbranch,doctortc,doctorpassword) values (@p1,@p2,@p3,@p4,@p5)", sql.connection());
            command2.Parameters.AddWithValue("@p1",TxtName.Text);
            command2.Parameters.AddWithValue("@p2",TxtSurname.Text);
            command2.Parameters.AddWithValue("@p3",CmbBranch.Text);
            command2.Parameters.AddWithValue("@p5",TxtPassword.Text);
            command2.Parameters.AddWithValue("@p4", MskTC.Text);
            command2.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Doctor Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
            TxtSurname.Text = dataGridView1.Rows[selected].Cells[2].Value.ToString();
            CmbBranch.Text = dataGridView1.Rows[selected].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[selected].Cells[4].Value.ToString();
            TxtPassword.Text = dataGridView1.Rows[selected].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Delete from Tbl_Doctors where doctortc=@p1", sql.connection());
            command2.Parameters.AddWithValue("@p1", MskTC.Text);
            command2.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Doctor Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command3 = new SqlCommand("Update tbl_doctors set doctorname=@p1,doctorsurname=@p2,doctorbranch=@p3,doctorpassword=@p5 where doctortc=@p4 ", sql.connection());
            command3.Parameters.AddWithValue("@p1", TxtName.Text);
            command3.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command3.Parameters.AddWithValue("@p3", CmbBranch.Text);
            command3.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command3.Parameters.AddWithValue("@p4", MskTC.Text);
            command3.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Doctor Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
