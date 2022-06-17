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
    public partial class Producto : UserControl
    {
        private int id = 0;
        private string descripcion = "Esencia que te encantara";
        public Producto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Producto_Load(object sender, EventArgs e)
        {

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        /*
        public Image IngProducto
        {
            /*
            get 
            { return guna2PictureBox1.Image; }
            set
            {
                guna2PictureBox1.Image value;
            }
            /
        }
        */
        public string DescripcionProducto
        {
            get
            { return descripcion; }
            set
            { descripcion = value; }
        }

    }
}
