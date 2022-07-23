using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    internal class Cl_conexiones
    {
        public SqlDataReader read;
        protected SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        
        public SqlCommand cm;
    }
}