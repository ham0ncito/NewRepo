using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace GerizimZZ
{
    public class Productos
    {
        /* atributos esenciales de los productos */

        private string id_producto;
        private double precio_producto;
        private string nombre;
        private string codigoBarra;
        private string descripcion;
        private int estado;

        public string Id_producto { get => Id_producto; set => Id_producto = value; }
        public double Precio_producto { get => Precio_producto; set => Precio_producto = value; }
        public string Nombre { get => Nombre; set => Nombre = value; }
        public string CodigoBarra { get => CodigoBarra; set => CodigoBarra = value; }
        public string Descripcion { get => Descripcion; set => Descripcion = value; }
        public int Estado { get => Estado; set => Estado = value; }

        string fuente = "DESKTOP-2H6N4DP";
        string bd = "Gerizim";
        string seguridad = "true";
        string id = "";
        string contrasena = "";


        string conector = "Data Source =" + fuente
            + "; Initial Catalog =" + bd
            + "; Integrated Security=" + seguridad
            ;
      
       SqlConnection conection = new SqlConnection();

        
        // metodos

        public void cuadrados (FlowLayoutPanel Panel)
        {
            conection.open();
            string consultas = "select * from dbo.Producto";
            SqlCommand bdconsulta = new SqlCommand(consultas, conection)
            bdconsulta.CommandType CommandType.Text;

            //llenado del panel
            SqlDataReader reader bdconsulta.ExecuteReader();
           
            
            while (reader.Read())
            {
                Id_producto1 = Convert.ToInt32(reader[0]);
                Precio_producto1 = reader[2].toDouble();
                Nombre1 = reader[3].ToString();
                CodigoBarra1 = reader[4].ToString();
                Descripcion1 = reader[8].ToString();
                Estado1 = Convert.ToInt32(reader[9]);
            }
        }
    }
}
