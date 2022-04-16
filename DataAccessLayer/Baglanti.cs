using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class Baglanti
    {
        public static SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-GLAR9PS;Initial Catalog=DbPersonel;Integrated Security=True");
    }
}
