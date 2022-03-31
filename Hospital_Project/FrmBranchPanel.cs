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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            //branşları çekme
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Branches", sql.connection());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert into tbl_branches (branchname) values (@p1)", sql.connection());
            command.Parameters.AddWithValue("@p1", TxtBranchName.Text);
            command.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Branch Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            TxtBranchID.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            TxtBranchName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand commanddelete = new SqlCommand("Delete From Tbl_Branches where BranchID=@p1", sql.connection());
            commanddelete.Parameters.AddWithValue("@p1", TxtBranchID.Text);
            commanddelete.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Branch Deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand commandeupdate = new SqlCommand("Update Tbl_branches set branchname=@p1 where branchID=@p2", sql.connection());
            commandeupdate.Parameters.AddWithValue("@p1", TxtBranchName.Text);
            commandeupdate.Parameters.AddWithValue("@p2", TxtBranchID.Text);
            commandeupdate.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Branch Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
