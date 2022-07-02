using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GerizimZZ
{
    internal class Cl_ConexionDB
    {
        private static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return con;
        }
    }
}
