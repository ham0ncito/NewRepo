using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GerizimZZ
{
    internal class Cconexiones
    {
        public SqlDataReader read;
        SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        public SqlCommand cm;
        public void init (string comando)
        {
            SqlCommand cm = new SqlCommand(comando, conexion);
            conexion.Open();

        }
        public void cerrarconexion()
        {
            conexion.Close();
        }
        public void buscarInfo()
        {
            
            
        }
    }
}
