using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Markup;


namespace GerizimZZ
{
    public partial class DetalleVenta : Form
    {
        int x = 0;
        public DetalleVenta()
        {

            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Hover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.IndianRed;
        }
        private void button1_MouseLeaves(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Transparent;
        }
        private void button2_Hover(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Cyan;
        }
        private void button2_MouseLeaves(object sender, EventArgs e)
        {
            this.button2.BackColor = Color.Transparent;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Imprimir.PrinterSettings = ps;
            Imprimir.PrintPage += printDocument1_PrintPage;
            Imprimir.Print(); 




        }

        static public DataTable tablita = new DataTable();
        static public List<string> idlist = new List<string>();

        public void llenartablita()
        {
            int cont = 0;
            if (tablita.Rows.Count == 0)
            {
                tablita.Columns.Add("Id");
                tablita.Columns.Add("Nombre");
                tablita.Columns.Add("Cantidad");
                tablita.Columns.Add("Precio");
                tablita.Columns.Add("Total");

            }
            string comparacion = textc.Id;


            idlist.Add(comparacion);


            if (tablita.Rows.Count == 0)
            {
                tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
            }
            else
            {
                int estado = 0;
                for (int i = 0; i < tablita.Rows.Count; i++)
                {
                  
                    if (idlist[i] == textc.Id)
                    {
                        tablita.Rows.RemoveAt(i);
                        tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                        idlist[i].Remove(i);
                        estado = 1;
                        break;
                    }
                    if (idlist[i] != textc.Id)
                    {
                        estado = 2;
                    }
                }
                if (estado == 2)
                {
                    tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                }

            }




        }
        public void DetalleVenta_Load(object sender, EventArgs e)
        {

            dgDetalleVenta.DataSource = tablita;
            int numeroFactura = 0; 
            SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
            
            SqlCommand comando = new SqlCommand("Use Gerizim; select MAX(ID_factura) from Factura ;", conexion);
            comando.Parameters.AddWithValue("ID", txtFactura.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if(registro.Read())
            {
                numeroFactura = Convert.ToInt32(registro[0]) + 1;
                txtFactura.Text = numeroFactura.ToString(); 
            }


        }

        public void dgDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        

        }

        private void dgDetalleVenta_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frCodigoBarra CodigoBarra = new frCodigoBarra();
            CodigoBarra.Show();
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial",12);
            Font Titulo = new Font("Arial", 24,FontStyle.Bold);
            e.Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawString(" Multiservicios Gerizim  ", Titulo, Brushes.Black, new RectangleF(250,220,600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(230, 280, 1000, 100));
            e.Graphics.DrawString(String.Concat("   " +lblFecha.Text + "   " + lblHora.Text) , fuente, Brushes.Black, new RectangleF(280, 300, 1000, 100));
            e.Graphics.DrawString(String.Concat("Factura #  " + txtFactura.Text), fuente, Brushes.Black, new RectangleF(360, 320, 1000, 100));
            e.Graphics.DrawString(String.Concat("Cliente  " + txtCliente.Text), fuente, Brushes.Black, new RectangleF(340, 340, 1000, 100));

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            lblFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss:ff");
        }

        private void txtFactura_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
