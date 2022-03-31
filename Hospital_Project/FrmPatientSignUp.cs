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
    public partial class FrmPatientSignUp : Form
    {
        public FrmPatientSignUp()
        {
            InitializeComponent();
        }

        ConnectingSql sql = new ConnectingSql();
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("Insert into Tbl_Patients (PatientName,PatientSurname,PatientTC,PatientPhone,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.connection());
            command1.Parameters.AddWithValue("@p1", TxtName.Text);
            command1.Parameters.AddWithValue("@p2", TxtSurname.Text);
            command1.Parameters.AddWithValue("@p3", MskTC.Text);
            command1.Parameters.AddWithValue("@p4", MskPhone.Text);
            command1.Parameters.AddWithValue("@p5", TxtPassword.Text);
            command1.Parameters.AddWithValue("@p6", CmbGender.Text);
            command1.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Registered", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
