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
        public int cantidad = 0;

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
                int x = 0;
                textc.contcolumnas = 0;
                if (x > 0)
                {
                    dgv.funcionllenardg();
                    for (int h = 0; h < dgv.dgDetalleVenta.Rows.Count; h++)
                    {
                        if (dgv.dgDetalleVenta.Rows[x].Cells[0].Value != this.id.ToString())
                        {
                            textc.contcolumnas += 1;
                            dgv.funcionllenardg();
                        }
                    }

                }

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
            if (cantidad > 0)
            {
                cantidad -= 1;
                textBox1.Text = cantidad.ToString();
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
            DetalleVenta dgv = new DetalleVenta();
            int n = dgv.dgDetalleVenta.Rows.Add();
            int j = 0;
            string precio = this.PrecioProducto;
            textc.Id = this.Id.ToString();
            textc.NombreProducto = this.NombreProducto;
            dgv.dgDetalleVenta.Rows[n].Cells[j].Value = textc.Id;
            dgv.dgDetalleVenta.Rows[n].Cells[j += 1].Value = textc.NombreProducto;



            string cantidadtextbox = textBox1.Text.ToString();
            textc.Cantidad = cantidadtextbox;
            textc.precio = this.PrecioProducto;

            int cantidadtextbox2 = int.Parse(cantidadtextbox);
            string precio2 = this.PrecioProducto.ToString();
            float precio3 = float.Parse(precio2);
            float total = cantidadtextbox2 * precio3;
            textc.total = total.ToString();
        }
    }
}

