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

        string fuente = "DESKTOP-2H6N4DP";
        string bd = "Gerizim";
        string seguridad = "true";
        string id = "";
        string contrasena = "";


        string conector = "Data Source =" + fuente
            + "; Initial Catalog =" + bd
            + "; Integrated Security=" + seguridad
            ;
      
        public string Id_producto { get => id_producto; set => id_producto = value; }
        public double Precio_producto { get => precio_producto; set => precio_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }

        conection = new SqlConnection();
          

        // metodos

        public void cuadrados (FlowLayoutPanel Panel)
        {
            conection.open();
            string consultas = "select * from dbo.Producto";

        }
    }
}
