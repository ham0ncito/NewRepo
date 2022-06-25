
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
        public string[] valores = new string[2]; 
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
            if (cantidad < Stockactual)
            {
                cantidad += 1;
                textBox1.Text = cantidad.ToString();
                MessageBox.Show("Cantidad agregada correctamente", "Adiccion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Cantidad modificada correctamente", "Modificacion correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (Convert.ToInt32(this.textBox1.Text) != 0)
            {
                valores[0] = id.ToString();
                valores[1] = nom;
                valores[2] = cantidad.ToString();
                
            }
        }
    }
}

