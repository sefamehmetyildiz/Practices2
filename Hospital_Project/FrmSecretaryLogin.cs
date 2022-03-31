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
    public partial class FrmSecretaryLogin : Form
    {
        public FrmSecretaryLogin()
        {
            InitializeComponent();
        }

        ConnectingSql sql = new ConnectingSql();

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Secretaries where SecretaryTC=@p1 and SecretaryPassword=@p2", sql.connection());
            command.Parameters.AddWithValue("@p1", MskTC.Text);
            command.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmSecretaryInformations fr = new FrmSecretaryInformations();
                fr.TC = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or Password", "Mistake", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sql.connection().Close();
        }
    }
}
