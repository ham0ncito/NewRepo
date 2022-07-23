using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionVentascs
    {
        private SqlConnection conectar = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

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