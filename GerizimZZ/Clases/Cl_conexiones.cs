using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GerizimZZ.Clases
{
    public class Cl_conexiones
    {
        public SqlDataReader read;
        public SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public SqlConnection Conexion { get => conexion; set => conexion = value; }
        public SqlCommand cm;

        public void init(string comando)
        {
            SqlCommand cm = new SqlCommand(comando, Conexion);
            Conexion.Open();

        }
        public void cerrarconexion()
        {
            Conexion.Close();
        }
        public void buscarInfo()
        {
        }
    }
}
