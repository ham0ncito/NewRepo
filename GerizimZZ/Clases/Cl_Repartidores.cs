using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_Repartidores : Cl_conexiones
    {

        public void infogrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("select * from Repartidores ;", conex);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            grid.DataSource = dt;
        }
    }
}