using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ.Clases
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
        private int existencia;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public decimal Precio_producto { get => precio_producto; set => precio_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string CodigoBarra_producto { get => codigoBarra_producto; set => codigoBarra_producto = value; }
        public string Descripcion_producto { get => descripcion_producto; set => descripcion_producto = value; }
        public int Estado_producto { get => estado_producto; set => estado_producto = value; }
        public int Existencia { get => existencia; set => existencia = value; }

        SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");


        public void llenado(FlowLayoutPanel Contenedor, string consulta)
        {
            conexion.Open();
            try
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    idproducto = Convert.ToInt32(reader[0]);
                    precio_producto = Convert.ToDecimal(reader[1]);
                    nombre_producto = reader[2].ToString();
                    codigoBarra_producto = reader[4].ToString();
                    descripcion_producto = reader[8].ToString();
                    estado_producto = Convert.ToInt32(reader[9]);
                    existencia = Convert.ToInt32(reader[6]);

                    Producto sd = new Producto();
                    sd.Id = Convert.ToInt32(idproducto);
                    sd.DescripcionProducto = descripcion_producto;
                    sd.NombreProducto = nombre_producto;
                    sd.PrecioProducto = precio_producto.ToString();
                    sd.estado = estado_producto.ToString();
                    sd.Stockactual = existencia;
                    sd.Codigobarra = codigoBarra_producto;
                    sd.text = "0";
                    Contenedor.Controls.Add(sd);
                }
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
            conexion.Close();
            conexion.Dispose();
        }

    }


}


