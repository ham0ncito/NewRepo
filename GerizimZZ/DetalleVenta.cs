using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Windows.Markup;


namespace GerizimZZ
{
    public partial class DetalleVenta : Form
    {
        int x = 0;
        double suma;
        bool bandera = false;
        private DataGridView dgView; 


        public DetalleVenta()
        {

            InitializeComponent();
            DataGridLector(); 
            datagrid();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            
            datagrid();
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
            try
            {
                dgDetalleVenta.Columns.Clear();
                txtTotal.Text = "L 00";
                cmbCliente.Text = "Cliente";
                delivery.Checked = false;
                txtNumero.Clear();
                txtDireccion.Clear();

                Inicio Principal = Owner as Inicio;
                Principal.IniciarFlowLayout(); 
                Principal.FlpDatos.Controls.Clear(); 
                Principal.Llenado();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message); 
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            datagrid();
            verificacion();
            if (string.IsNullOrEmpty(cmbCliente.Text) == true  ||
                string.IsNullOrEmpty(txtFactura.Text) == true || string.IsNullOrEmpty(cmbPago.Text) == true || txtTotal.Text == "L 00")
            {
                errorProvider1.SetError(button2, "Ingrese todos los campos");
            }
            else
            { 
                errorProvider1.SetError(groupBox1, "");
                Imprimir = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                Imprimir.PrinterSettings = ps;
                Imprimir.PrintPage += printDocument1_PrintPage;
                Imprimir.Print();
            }

            //Foreach row in dgDetalleVenta
            //{
               
            //}

        }

        static public DataTable tablita = new DataTable();
        static public List<string> idlist = new List<string>();

        public DataGridView DgView1 { get => dgView; set => dgView = value; }
        public void DataGridLector()
        {
            dgView = dgDetalleVenta; 
        }
        public void llenartablita()
        {
            int cont = 0;
            if (tablita.Rows.Count == 0 )
            {
                tablita.Columns.Add("Id");
                tablita.Columns.Add("Nombre");
                tablita.Columns.Add("Cantidad");
                tablita.Columns.Add("Precio");
                tablita.Columns.Add("Total");

            }
            string comparacion = textc.Id;
            int cantidadcero = Int16.Parse(textc.Cantidad);

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
                        if (cantidadcero == 0)
                        {
                            tablita.Rows.RemoveAt(i);
                            idlist.RemoveAt(i);
                            estado = 1;
                            break;
                        }
                        else
                        {
                            tablita.Rows.RemoveAt(i);
                            tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                            idlist.RemoveAt(i);
                            estado = 1;
                            break;
                        }
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
            datagrid();
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
            AddOwnedForm(CodigoBarra);
            CodigoBarra.Show();
            
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Arial",12);
            Font Titulo = new Font("Arial", 24,FontStyle.Bold);
            float ubicacion = 460; 
            e.Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawString(" Multiservicios Gerizim  ", Titulo, Brushes.Black, new RectangleF(250,220,600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(230, 280, 1000, 100));
            e.Graphics.DrawString(String.Concat("   " +lblFecha.Text + "   " + lblHora.Text) , fuente, Brushes.Black, new RectangleF(280, 300, 1000, 100));
            e.Graphics.DrawString(String.Concat("Factura #  " + txtFactura.Text), fuente, Brushes.Black, new RectangleF(360, 320, 1000, 100));
            e.Graphics.DrawString(String.Concat("Cliente  " + cmbCliente.Text), fuente, Brushes.Black, new RectangleF(360, 340, 1000, 100));
            e.Graphics.DrawString("Listado de productos: ", fuente, Brushes.Black, new RectangleF(200, 400, 1000, 100));
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                e.Graphics.DrawString(row.Cells["Id"].Value + "      " + row.Cells["Nombre"].Value + "      " + row.Cells["Cantidad"].Value + "       "
                    + row.Cells["Precio"].Value + "       " + row.Cells["Total"].Value, fuente, Brushes.Black, new RectangleF(200, ubicacion, 1000, 100));
                ubicacion += 30;
            }
            if (delivery.Checked)
            {
                e.Graphics.DrawString("Su costo de envio es de L100.00 " ,fuente, Brushes.Black, new RectangleF(200, ubicacion +=40, 1000, 100));
                e.Graphics.DrawString("Se le llamará al numero " + txtNumero.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
                e.Graphics.DrawString("Su direccion de envio es : " + txtDireccion.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            }
            e.Graphics.DrawString("Su total es de : " + txtTotal.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            e.Graphics.DrawString("Gracias por confiar en nosotros", fuente, Brushes.Black, new RectangleF(320, ubicacion += 40, 1000,100));


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

        private void datagrid ()
        {
            suma = 0;
            bandera = false; 
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                suma += Convert.ToInt32(row.Cells["Total"].Value);
                
            }
            txtTotal.Text = "L. " + suma.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void verificacion()
        {
            if (delivery.Checked && !string.IsNullOrEmpty(txtNumero.Text) && !string.IsNullOrEmpty(txtDireccion.Text) && !bandera)
            {
                bandera = true;
                errorProvider1.SetError(groupBox2, "");
                suma += 100;
                

            }
            else if (!delivery.Checked && (!string.IsNullOrEmpty(txtNumero.Text) || !string.IsNullOrEmpty(txtDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
                
            }
            else if (delivery.Checked && (string.IsNullOrEmpty(txtNumero.Text) || string.IsNullOrEmpty(txtDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
            }
            txtTotal.Text = "L. " + suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagrid();
            verificacion();
            
        }
    }
}
