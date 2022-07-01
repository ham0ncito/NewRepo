using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GerizimZZ
{
   
    internal class CsMensajes
    {
        private string nombre_usuario;
        private string fecha = "Hoy";
        private string idMensaje;
        private string mensajeenviado = "Hola";
        public string Mensajeenviado { get => mensajeenviado; set => mensajeenviado = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }

        SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

    }
}
