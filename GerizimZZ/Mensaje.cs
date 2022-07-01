using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ
{
    public partial class Mensaje : UserControl
    {
        private string nombre_usuario;
        private string fecha = "Hoy";
        private string idMensaje; 
        private string mensajeenviado = "Hola";
        public string Mensajeenviado { get => mensajeenviado; set => mensajeenviado = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }

        SqlConnection conexion = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        public Mensaje()
        {
            InitializeComponent();
        }

       public void activar(FlowLayoutPanel contenedor, string consulta)
        {
                conexion.Open();

                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.CommandType = CommandType.Text;
                SqlDataReader reader = comando.ExecuteReader();

             
              
                while (reader.Read())
                {
                nombre_usuario = reader[0].ToString();
                mensajeenviado = reader[3].ToString();

                   /* Producto sd = new Producto();
                    sd.Id = Convert.ToInt32(idproducto);
                    sd.DescripcionProducto = descripcion_producto;
                    sd.NombreProducto = nombre_producto;
                    sd.PrecioProducto = precio_producto.ToString();
                    sd.estado = estado_producto.ToString();
                    sd.Stockactual = existencia;
                    sd.Codigobarra = codigoBarra_producto;
                    if (sd.estado == "2")
                    {
                        sd.BackgroundImage = null;
                        sd.BackColor = Color.DodgerBlue;
                    }
                    Contenedor.Controls.Add(sd);
                   */
                }

                conexion.Close();
                conexion.Dispose();

            }

        private void Mensaje_Load(object sender, EventArgs e)
        {

        }
    

   
    }
}
