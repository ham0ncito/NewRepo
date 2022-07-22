using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class ConexionPedido
    {
        SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public void llenargrid(DataGridView grid)
        {
            SqlCommand cm = new SqlCommand("Select * From Pedidos", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt); //Para llenar la tabla con lo que está dentro de DataAdapter

            grid.DataSource = dt;

        }
    }
}

