using System.Data.SqlClient;

namespace GerizimZZ.Clases
{
    public class Cl_conexiones
    {
        public SqlDataReader read;
        protected SqlConnection _conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");


        public SqlCommand cm;

        public SqlConnection Conexion { get => _conexion; set => _conexion = value; }

        /* public void init(string comando)
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
         } */
    }
}
