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
namespace Personel_Kayit
{
    public partial class Frmgrafikler : Form
    {
        public Frmgrafikler()
        {
            InitializeComponent();
        }

        SqlConnection bağlantı = new SqlConnection("Data Source=DESKTOP-GLAR9PS;Initial Catalog=PersonalVeriTabani;Integrated Security=True");
        private void Frmgrafikler_Load(object sender, EventArgs e)
        {

            // Sehirlerdeki insan sayısı
            bağlantı.Open();
            SqlCommand komutg1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by PerSehir", bağlantı);
            SqlDataReader drg1 = komutg1.ExecuteReader();
            while (drg1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(drg1[0], drg1[1]);
            }

            bağlantı.Close();

            // Mesleklerin maaşları
            bağlantı.Open();
            SqlCommand komutg2 = new SqlCommand("Select Permeslek,Avg(PerMaas) From Tbl_Personel group by permeslek", bağlantı);
            SqlDataReader drg2 = komutg2.ExecuteReader();
            while (drg2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(drg2[0], drg2[1]);
            }
            bağlantı.Close();
        }
    }
}
