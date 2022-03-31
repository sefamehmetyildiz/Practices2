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
    public partial class FrmDoctorUpdateInformations : Form
    {
        public FrmDoctorUpdateInformations()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        public string TCNO;

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Update Tbl_Doctors set DoctorName=@p1, DoctorSurname=@p2, DoctorBranch=@p4, Doctorpassword=@p5 where Doctortc=@p6", sql.connection());
            command2.Parameters.AddWithValue("@p1", TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname.Text);  
            command2.Parameters.AddWithValue("@p4", CmbBranch.Text);
            command2.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command2.Parameters.AddWithValue("@p6", MskTC.Text);
            command2.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDoctorUpdateInformations_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNO;
            SqlCommand command = new SqlCommand("Select * From Tbl_DOCTORs where doctorTC=@p1", sql.connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskTC.Text = dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbBranch.Text = dr[3].ToString();
            }
            sql.connection().Close();
        }
    }
}
