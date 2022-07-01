using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ
{
    public partial class frmAvisos : Form
    {
        public frmAvisos()
        {
            InitializeComponent();
        }

        private void frmAvisos_Load(object sender, EventArgs e)
        {
            CsMensajes ms = new CsMensajes();
            string consulta = "select u.nombreUsuario as NombreUsuario, m.fechaEnvio as fechaEnvio, m.Id_Mensaje as IdMensaje, m.mensaje as Mensaje from Usuarios as u inner join Mensajes as m on m.Fk_Usuarios = u.ID_Usuarios where m.estado = 1 order by m.fechaEnvio DESC; ";
            ms.init(this.flowLayoutPanel1, consulta);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
