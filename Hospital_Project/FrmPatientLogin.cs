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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        private void FrmPatientLogin_Load(object sender, EventArgs e)
        {

        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignUp fr = new FrmPatientSignUp();
            fr.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1 and PatientPassword=@p2", sql.connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientInformation fr = new FrmPatientInformation();
                fr.tc = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or Password","MISTAKE",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            sql.connection().Close();
        }
    }
}
