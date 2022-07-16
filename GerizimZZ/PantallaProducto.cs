using System.Data;
namespace GerizimZZ
{

    public partial class Producto : UserControl
    {
        private int id = 0;
        private string descripcion = "Esencia que te encantara";
        private double precio = 0;
        public string estado;
        private string nom;
        private string codigobarra;
        private string textBox; 
        public int cantidad = 0;

        public DetalleVenta dgv = new DetalleVenta();

        public Producto()
        {
            InitializeComponent();
            textBox1.Text = "0";

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                if (cantidad < Stockactual)
                {
                    cantidad += 1;
                    textBox1.Text = cantidad.ToString();
                    MessageBox.Show("Cantidad agregada correctamente", "Adiccion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DetalleVenta dgv = new DetalleVenta();
                dgv.llenartablita();


            }
        }

        public void Producto_Load(object sender, EventArgs e)
        {

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string text
        {
            get { return textBox1.Text;  }
            set { textBox1.Text = value;  }

        }
        public string DescripcionProducto
        {
            get
            { return descripcion; }
            set
            { descripcion = value; }
        }

        public string PrecioProducto
        {
            get
            { return label1.Text; }
            set
            { label1.Text = value; }
        }
        public string NombreProducto
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public int Stockactual
        {
            get { return Convert.ToInt32(label3.Text); }
            set { label3.Text = value.ToString(); }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string Codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            if (estado == "2")
            {
                estado = "1";
            }
            else
            {
                estado = "2";
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (cantidad > 0)
                {

                    cantidad -= 1;
                    textBox1.Text = cantidad.ToString();
                    MessageBox.Show("Cantidad reducida correctamente", "Resta correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                DetalleVenta dgv = new DetalleVenta();
                dgv.llenartablita();
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            VentanaInfoProductos pr = new VentanaInfoProductos();
            pr.lblNombre.Text = this.NombreProducto;
            pr.lbldescripcion.Text = this.descripcion;
            pr.lblcodigo.Text = this.codigobarra.ToString();
            pr.lblprecio.Text = this.PrecioProducto.ToString();
            pr.lblstock.Text = this.Stockactual.ToString();
            pr.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int j = 0;
            string precio = this.PrecioProducto;
            textc.Id = this.Id.ToString();
            textc.NombreProducto = this.NombreProducto;


            string cantidadtextbox = textBox1.Text.ToString();
            textc.Cantidad = cantidadtextbox;
            textc.precio = this.PrecioProducto;

            int cantidadtextbox2 = int.Parse(cantidadtextbox);
            string precio2 = this.PrecioProducto.ToString();
            float precio3 = float.Parse(precio2);
            float total = cantidadtextbox2 * precio3;
            textc.total = total.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

