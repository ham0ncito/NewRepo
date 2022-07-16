using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace GerizimZZ
{
    internal class Cl_Repartidores
    {
        SqlConnection conec = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public void infogrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("select * from Repartidores ;", conec);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
        }
    }
}


    

