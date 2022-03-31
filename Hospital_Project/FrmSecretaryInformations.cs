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
    public partial class FrmSecretaryInformations : Form
    {
        public FrmSecretaryInformations()
        {
            InitializeComponent();
        }
        public string TC;
        ConnectingSql sql = new ConnectingSql();
        private void FrmSecretaryInformations_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //AD SOYAD ÇEKME
            SqlCommand command1 = new SqlCommand("Select SecretaryNameSurname From Tbl_Secretaries where secretarytc=@p1", sql.connection());
            command1.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr1 = command1.ExecuteReader();
            if (dr1.Read())
            {
                LblNameSurname.Text = dr1[0].ToString();
            }
            sql.connection().Close();

            //Branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Branches", sql.connection());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktorları aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as Doctors,DoctorBranch From Tbl_Doctors", sql.connection());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşları cmbboxa aktarma
            SqlCommand command2 = new SqlCommand("Select BranchName From Tbl_Branches", sql.connection());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBranch.Items.Add(dr2[0]);
            }
            sql.connection().Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandsave = new SqlCommand("Insert into Tbl_Appointments (AppointmentDate,appointmenttime,appointmentbranch,appointmentdoctor) values (@p1,@p2,@p3,@p4)", sql.connection());
            commandsave.Parameters.AddWithValue("@p1", MskDate.Text);
            commandsave.Parameters.AddWithValue("@p2", MskTime.Text);
            commandsave.Parameters.AddWithValue("@p3", CmbBranch.Text);
            commandsave.Parameters.AddWithValue("@p4", CmbDoctor.Text);
            commandsave.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Appointment Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoctor.Items.Clear();
            SqlCommand command3 = new SqlCommand("Select DoctorName,DoctorSurname From Tbl_Doctors where DoctorBranch=@p1", sql.connection());
            command3.Parameters.AddWithValue("@p1", CmbBranch.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoctor.Items.Add(dr3[0] +" "+ dr3[1]);
            }
            sql.connection().Close();
        }

        private void BtnCreateAnnouncement_Click(object sender, EventArgs e)
        {
            SqlCommand command4 = new SqlCommand("Insert into Tbl_Announcement (Announcement) values (@p1)", sql.connection());
            command4.Parameters.AddWithValue("@p1", RchAnnouncement.Text);
            command4.ExecuteNonQuery();
            sql.connection().Close();
            MessageBox.Show("Announcement Created", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel fr = new FrmDoctorPanel();
            fr.Show();
        }

        private void BtnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel fr = new FrmBranchPanel();
            fr.Show();
        }

        private void BtnAppointmentList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList fr = new FrmAppointmentList();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }
    }
}
