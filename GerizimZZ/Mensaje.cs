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
        private string idMensaje;
        private string nombreUsuario;
        private string mensajeenviar;
        private string Fecha;

        public string IdMensaje {
            get { return label4.Text; }
            set { label4.Text = value; } 
        }
        public string NombreUsuario
        {
            get { return label3.Text; } 
            set {label3.Text = value; } 
        }
        public string Mensajeenviar { get => mensajeenviar; set => mensajeenviar = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }

        public Mensaje()
        {
            InitializeComponent();
        }

       public void activar(FlowLayoutPanel contenedor, string consulta)
        {
               
        }

        private void Mensaje_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
