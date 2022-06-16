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

        public string id_producto;
        public double precio_producto;
        public string nombre;
        public string codigoBarra;
        public string descripcion;
        public int estado;

        string fuente = "DESKTOP-2H6N4DP";
        string bd = "Gerizim";
        string seguridad = "true";
        string id = "";
        string contrasena = "";


        string conector = "Data Source =" + fuente
            + "; Initial Catalog =" + bd
            + "; Integrated Security=" + seguridad
            ;
      
           SqlConnection conection = new SqlConnection(conector);
           conection.Open();

        // metodos


    }
}
