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
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {   
            if (checkBox1.Checked==true)
            {
                MessageBox.Show("Espere futuras actualizaciones","Esta en Mantenimiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }
    }
}
