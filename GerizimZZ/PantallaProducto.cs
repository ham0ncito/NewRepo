namespace GerizimZZ
{
    public partial class Producto : UserControl
    {
        private int id = 0;
        private string descripcion = "Esencia que te encantara";
        private double precio = 0;
        public string estado;
        int cantidad = 0;
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

            cantidad += 1;
            textBox1.Text = cantidad.ToString();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            if (estado == "2")
            {
                // Producto.Properties.BackgroundImage = global::GerizimZZ.Properties.Resources._012_Tempting_Azure;
            }
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
        public int Stock
        {
            get { return Convert.ToInt32(label3.Text); }
            set { label3.Text = value.ToString(); }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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

        }
    }
}

