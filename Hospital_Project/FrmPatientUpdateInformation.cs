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
    public partial class FrmPatientUpdateInformation : Form
    {
        public FrmPatientUpdateInformation()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        public string TCno;
        private void FrmPatientUpdateInformation_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            SqlCommand command = new SqlCommand("Select * From Tbl_Patients where PatientTC=@p1", sql.connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())  
            {
                TxtName.Text = dr[1].ToString();
                TxtSurname.Text = dr[2].ToString();
                MskTC.Text = dr[3].ToString();
                MskPhone.Text =  dr[4].ToString();
                TxtPassword.Text = dr[5].ToString();
                CmbGender.Text = dr[6].ToString();
            }
            sql.connection().Close();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command2 = new SqlCommand("Update Tbl_Patients set PatientName=@p1, PatientSurname=@p2, PatientPhone=@p3, patientPassword=@p4, patientgender=@p5 where patienttc=@p6", sql.connection());
            command2.Parameters.AddWithValue("@p1", TxtName.Text);
            command2.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command2.Parameters.AddWithValue("@p3", MskPhone.Text);
            command2.Parameters.AddWithValue("@p4", TxtPassword.Text);
            command2.Parameters.AddWithValue("@p5", CmbGender.Text);
            command2.Parameters.AddWithValue("@p6", MskTC.Text);
            command2.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
