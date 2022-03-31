using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hospital_Project
{
    class ConnectingSql
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-GLAR9PS;Initial Catalog=Hospital_Project;Integrated Security=True");
            connect.Open();
            return connect;
        }
      
       
    }
}
