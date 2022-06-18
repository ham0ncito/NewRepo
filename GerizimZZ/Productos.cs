using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public class Productos
    {
        /* atributos esenciales de los productos */

        private int idproducto;
        private decimal precio_producto;
        private string nombre_producto;
        private string codigoBarra_producto;
        private string descripcion_producto;
        private int estado_producto;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public decimal Precio_producto { get => precio_producto; set => precio_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string CodigoBarra_producto { get => codigoBarra_producto; set => codigoBarra_producto = value; }
        public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
        public int Estado_producto { get => estado_producto; set => estado_producto = value; }

        SqlConnection conexion = new SqlConnection("Data Source =DESKTOP-2H6N4DP ; Initial Catalog =Gerizim " +
            "; Integrated Security=True");


        public void llenado(FlowLayoutPanel Contenedor)
        {
            conexion.Open();
            string consulta = "Select * from Producto";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.Text;
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                idproducto = Convert.ToInt32(reader[0]);
                precio_producto = Convert.ToDecimal(reader[2]);
                nombre_producto = reader[3].ToString();
                codigoBarra_producto = reader[4].ToString();
                descripcion_producto = reader[8].ToString();
                estado_producto = Convert.ToInt32(reader[9]);

                Producto sd = new Producto();
                sd.Id = idproducto;
                sd.DescripcionProducto = descripcion_producto;


                Contenedor.Controls.Add(sd);

            }

            conexion.Close();
        }

    }
}
