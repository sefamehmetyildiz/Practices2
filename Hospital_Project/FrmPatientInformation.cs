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
    public partial class FrmPatientInformation : Form
    {
        public FrmPatientInformation()
        {
            InitializeComponent();
        }
        public string tc;
        ConnectingSql sql = new ConnectingSql();
        private void FrmPatientInformation_Load(object sender, EventArgs e)
        {

            LblTC.Text = tc;

            //ad soyad çekme
            SqlCommand command = new SqlCommand("Select PatientName,PatientSurname From Tbl_Patients where PatientTC=@p1", sql.connection());
            command.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                LblNameSurname.Text = dr[0] + " " + dr[1];
            }
            sql.connection().Close();

            //randevu geçmişi

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Appointments where PatientTC="+ tc, sql.connection());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branş çekme
            SqlCommand command2 = new SqlCommand("Select branchname From Tbl_Branches", sql.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            sql.connection().Close();

        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Appointments where AppointmentBranch='" + CmbBranch.Text + "'" + " and AppointmentDoctor= '"+CmbDoctor.Text + "' and appointmentstatus=0", sql.connection());
            da1.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select DoctorName, DoctorSurname From Tbl_Doctors where DoctorBranch=@p1", sql.connection());
            command3.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0]+" "+ dr3[1]);
            }
            sql.connection().Close();
        }

        private void LnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientUpdateInformation fr1 = new FrmPatientUpdateInformation
            {
                TCno = LblTC.Text
            };
            fr1.Show();
        }

        private void BtnMaAppointment_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_appointments set appointmentstatus=1, patienttc=@p2, patientcomplaint=@p3 where appointmentID=@p1", sql.connection());
            command.Parameters.AddWithValue("@p1", TxtID.Text);
            command.Parameters.AddWithValue("@p2", LblTC.Text);
            command.Parameters.AddWithValue("@p3",RchComplaint.Text);
            command.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Appointment Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString();
        }
    }
}
