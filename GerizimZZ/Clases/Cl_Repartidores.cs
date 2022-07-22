using System.Data;
using System.Data.SqlClient;


namespace GerizimZZ.Clases
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




