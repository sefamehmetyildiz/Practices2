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
    public partial class FrmDoctorInformations : Form
    {
        public FrmDoctorInformations()
        {
            InitializeComponent();
        }
        ConnectingSql sql = new ConnectingSql();
        public string tcno;

        private void FrmDoctorInformations_Load(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            FrmDoctorUpdateInformations fr = new FrmDoctorUpdateInformations();
            fr.TCNO = LblTC.Text;
            fr.Show();
        }

        private void BtnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements fr = new FrmAnnouncements();
            fr.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            RchComplaint.Text = dataGridView1.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
