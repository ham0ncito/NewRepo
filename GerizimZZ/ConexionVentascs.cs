using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GerizimZZ
{
    internal class ConexionVentascs
    {
        SqlConnection conectar = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("Select * from Factura ", conectar);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;


        }

    }
}
