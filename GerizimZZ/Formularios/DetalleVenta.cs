﻿using GerizimZZ.Clases;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Text.RegularExpressions;
namespace GerizimZZ
{
    public partial class DetalleVenta : Form
    {
        private int x = 0;
        private decimal suma;
        private bool bandera = false;
        bool creadas = false;
        private DataGridView dgView;

        public DetalleVenta()
        {
            InitializeComponent();
            nombresCliente();
            DataGridLector();
            datagrid();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            datagrid();
            btnNuevaDireccion.Visible = true;
            btnNuevoTelefono.Visible = true;
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
            this.btnCancelarVenta.BackColor = Color.IndianRed;
        }

        private void button1_MouseLeaves(object sender, EventArgs e)
        {
            this.btnCancelarVenta.BackColor = Color.Transparent;
        }

        private void button2_Hover(object sender, EventArgs e)
        {
            this.btnGenerarVenta.BackColor = Color.Cyan;
        }

        private void button2_MouseLeaves(object sender, EventArgs e)
        {
            this.btnGenerarVenta.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            try
            {
                dgDetalleVenta.Columns.Clear();
                for  (int i = 1; i <= dgDetalleVenta.Rows.Count; i++ )
                {
                    dgDetalleVenta.Rows.Remove(dgDetalleVenta.Rows[i]);
                 }
                dgDetalleVenta.DataSource = null;
                lblTotal.Text = "L 00";
                cmbCliente.Text = "";
                delivery.Checked = false;
                txtNumero.Clear();
                txtDireccion.Clear();
                txtCodigo.Clear();
                                tablita.Columns.Clear();
                tablita.Rows.Clear();
                idlist.Clear();
                cantidadlist.Clear();
                cmbNumero.Items.Clear();
                cmbDireccion.Items.Clear();
                lblCodigoCliente.Text = "";

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
            if (string.IsNullOrEmpty(cmbCliente.Text) == true ||
                string.IsNullOrEmpty(lblNumeroFactura.Text) == true || string.IsNullOrEmpty(cmbPago.Text) == true || lblTotal.Text == "L 00" || dgDetalleVenta.Columns.Count == 0)
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los campos");
                errorProvider1.SetError(dgDetalleVenta, "Ingrese todos los campos");
            }
            else
            {
                errorProvider1.SetError(groupBox1, "");
                errorProvider1.SetError(dgDetalleVenta, "");
                try
                {
                    SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                    conexion.Open();
                    try
                    {
                        SqlCommand comando = new SqlCommand("exec ventaNueva '" + lblNumeroFactura.Text + "', '" + lblCodigoCliente.Text + "','1','1'", conexion);
                        comando.ExecuteNonQuery();
                    }
                    catch (SqlException x)
                    {
                        MessageBox.Show(x.Message);
                    }
                    foreach (DataGridViewRow row in dgDetalleVenta.Rows)
                    {
                        SqlCommand comando = new SqlCommand("exec detalleVenta '" + lblNumeroFactura.Text.ToString() + "','" + row.Cells[2].Value + "' , '" + row.Cells[3].Value + "' , '" + row.Cells[0].Value + "';", conexion);
                        comando.ExecuteNonQuery();
                    }
                    if (delivery.Checked)
                    {
                        Random rand = new Random();
                        int id = rand.Next(1, 5);
                        SqlCommand comando = new SqlCommand("exec nuevoPedido '" + lblNumeroFactura.Text + "','" + id.ToString() + "', '" + cmbDireccion.Text + "', ' " + cmbNumero.Text + "';", conexion);
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
                catch (SqlException x)
                {
                    MessageBox.Show(x.Message);
                }
                Imprimir = new PrintDocument();
                try
                {
                    PrinterSettings ps = new PrinterSettings();
                    MessageBox.Show("Factura " + lblNumeroFactura.Text + " en impresion", "Venta realizada");
                    Imprimir.PrinterSettings = ps;
                    Imprimir.PrintPage += printDocument1_PrintPage;
                    Imprimir.Print();
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
                Limpiar();
                Recargar();
            }
        }

        public static DataTable tablita = new DataTable();
        public static List<string> idlist = new List<string>();
        static public List<int> cantidadlist = new List<int>();

        public DataGridView DgView1 { get => dgView; set => dgView = value; }


        public void DataGridLector()
        {
            dgView = dgDetalleVenta;
        }

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
            int contlista = 0;
            string comparacion = textc.Id;
            int cantidad = int.Parse(textc.Cantidad);
            int cantidadcero = Int16.Parse(textc.Cantidad);

            idlist.Add(comparacion);
            cantidadlist.Add(cantidad);
            contlista += 1;


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
                            cantidadlist.RemoveAt(i);
                            estado = 1;
                            break;
                        }
                        else
                        {
                            tablita.Rows.RemoveAt(i);
                            tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                            idlist.RemoveAt(i);
                            cantidadlist.RemoveAt(i);
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


                //string idrowborrar = "";
                //for(int i = 0; i<tablita.Rows.Count; i++)
                //{
                //    if (cantidadlist[i] == 0)
                //    {
                //        idrowborrar = idlist[i];
                //        break;
                //    }
                //}
                //borrar:
                //for(int i = 0; i<tablita.Rows.Count;i++)
                //{
                //    if (idlist[i] == idrowborrar)
                //    {
                //        tablita.Rows.RemoveAt(i);
                //        idlist.RemoveAt(i);
                //        cantidadlist.RemoveAt(i);
                //        goto borrar;
                //    }
                //}

                if (tablita.Rows.Count == 0)
                {
                    tablita.Columns.Clear();
                    idlist.Clear();
                    cantidadlist.Clear();
                }

            }
        }

        public void DetalleVenta_Load(object sender, EventArgs e)
        {
            datagrid();
            dgDetalleVenta.DataSource = tablita;
            Recargar();
        }

        public void Recargar()
        {
            int numeroFactura = 0;
            SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");

            SqlCommand comando = new SqlCommand("Use Gerizim; select MAX(ID_factura) from Factura ;", conexion);
            comando.Parameters.AddWithValue("ID", lblNumeroFactura.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                numeroFactura = Convert.ToInt32(registro[0]) + 1;
                lblNumeroFactura.Text = numeroFactura.ToString();
            }
            conexion.Close();
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
            Font fuente = new Font("Arial", 12);
            Font Titulo = new Font("Arial", 24, FontStyle.Bold);
            float ubicacion = 460;
            e.Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawString(" Multiservicios Gerizim  ", Titulo, Brushes.Black, new RectangleF(250, 220, 600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(230, 280, 1000, 100));
            e.Graphics.DrawString(String.Concat("   " + lblFecha.Text + "   " + lblHora.Text), fuente, Brushes.Black, new RectangleF(280, 300, 1000, 100));
            e.Graphics.DrawString(String.Concat("Factura #  " + lblNumeroFactura.Text), fuente, Brushes.Black, new RectangleF(360, 320, 1000, 100));
            e.Graphics.DrawString(String.Concat("Cliente  " + cmbCliente.Text), fuente, Brushes.Black, new RectangleF(200, 380, 1000, 100));
            e.Graphics.DrawString("Listado de productos: ", fuente, Brushes.Black, new RectangleF(200, 420, 1000, 100));
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                e.Graphics.DrawString(row.Cells["Nombre"].Value + "      " + row.Cells["Cantidad"].Value + "       "
                    + row.Cells["Precio"].Value + "       " + row.Cells["Total"].Value, fuente, Brushes.Black, new RectangleF(200, ubicacion, 1000, 100));
                ubicacion += 30;
            }
            if (delivery.Checked)
            {
                e.Graphics.DrawString("Su costo de envio es de L100.00 ", fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
                e.Graphics.DrawString("Se le llamará al numero " + cmbNumero.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
                e.Graphics.DrawString("Su direccion de envio es : " + cmbDireccion.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            }
            e.Graphics.DrawString("Su total es de : " + lblTotal.Text, fuente, Brushes.Black, new RectangleF(200, ubicacion += 40, 1000, 100));
            e.Graphics.DrawString("Gracias por confiar en nosotros", fuente, Brushes.Black, new RectangleF(320, ubicacion += 40, 1000, 100));
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

        private void datagrid()
        {
            suma = 0;
            bandera = false;
            foreach (DataGridViewRow row in dgDetalleVenta.Rows)
            {
                suma += Convert.ToDecimal(row.Cells["Total"].Value);
            }
            lblTotal.Text = "L. " + suma.ToString();
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
            if (delivery.Checked && !string.IsNullOrEmpty(cmbNumero.Text) && !string.IsNullOrEmpty(cmbDireccion.Text) && !bandera)
            {
                bandera = true;
                errorProvider1.SetError(groupBox2, "");
                suma += 100;
            }
            else if (!delivery.Checked && (!string.IsNullOrEmpty(cmbNumero.Text) || !string.IsNullOrEmpty(cmbDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
            }
            else if (delivery.Checked && (string.IsNullOrEmpty(cmbNumero.Text) || string.IsNullOrEmpty(cmbDireccion.Text)))
            {
                errorProvider1.SetError(groupBox2, "Ingrese todos los valores si hará un pedido");
            }
            else
            {
                errorProvider1.SetError(groupBox2, "");
            }
            lblTotal.Text = "L. " + suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            datagrid();
            verificacion();
        }

        private void NuevoCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            AddOwnedForm(frmCliente);
            frmCliente.Show();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDireccion.Items.Clear();
            cmbNumero.Items.Clear();
            buscarId();
            lblCodigoCliente.Visible = true;
            lblCodCliente.Visible = true;

            TelefonosDireccions();
        }
        public void direccion()
        {
            SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
            conexion.Open();
            SqlCommand coma = new SqlCommand(" exec Direcciones '" + lblCodigoCliente.Text + "' ; ", conexion);
            SqlDataReader regist = coma.ExecuteReader();
            while (regist.Read() && !(regist.IsDBNull(0) == true))
            {
                cmbDireccion.Items.Add(regist[0].ToString());
            }
            conexion.Close();
        }
        public void TelefonosDireccions()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");
                SqlCommand comando = new SqlCommand(" exec Telefonos '" + lblCodigoCliente.Text + "' ; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read() && !(registro.IsDBNull(0) == true))
                {
                    cmbNumero.Items.Add(registro[0].ToString());
                }

                comando.Dispose();
                conexion.Close();
                direccion();

            }

            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void buscarId()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");

                SqlCommand comando = new SqlCommand(" exec buscarId '" + cmbCliente.Text + "' ; ", conexion);
                conexion.Open();
                SqlDataReader registro = comando.ExecuteReader();
                if (registro.Read())
                {
                    lblCodigoCliente.Text = registro[0].ToString();
                    cmbNumero.Items.Add(registro["telefono"].ToString());
                    cmbDireccion.Items.Add(registro["direccion"].ToString());
                }
                else
                {
                    MessageBox.Show("Tuvimos un problema buscando la informacion del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        public void nombresCliente()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source = localhost ; Initial Catalog = Gerizim; Integrated Security = True");

                SqlCommand comando = new SqlCommand("exec nombres; ", conexion);
                conexion.Open();
                cmbCliente.Items.Clear();
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    cmbCliente.Items.Add(registro["Nombre"]).ToString();
                }
                conexion.Close();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNumero_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //textbox numero regular expression
            Regex tboxnumerore = new Regex(@"^[0-9]{8}$");
            
            if(!tboxnumerore.IsMatch(txtNumero.Text))
            {
                e.Cancel = true;
                txtNumero.Focus();
                errorProvider2.SetError(txtNumero, "Numero de telefono invalido");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(txtNumero, null);
            }

        }
        private void btnNuevoTelefono_Click(object sender, EventArgs e)
        {
            vertelefono();
        }
        private void vertelefono()
        {
            string telefono = "";
            if (InputBox.inputBox("Ingrese su numero de telefono de envio ", "Nuevo Telefono de envio", ref telefono) == DialogResult.OK)
            {

                if (Regex.IsMatch(telefono, @"^[0-9]+$")  && telefono.Length == 8 && !string.Equals(lblCodigoCliente.Text, "00") && (string.Equals(telefono.Substring(0,1),"3") || string.Equals(telefono.Substring(0,1), "2") || string.Equals(telefono.Substring(0,1), "8") || string.Equals(telefono.Substring(0,1), "9")))
                {
                    string consulta = "insert into telefonosClientes (ID_cliente, numeroCliente) values (" + lblCodigoCliente.Text + ", '" + Convert.ToString(telefono) + "';";
                    cmbNumero.Items.Add(telefono);
                    MessageBox.Show("Valores Ingresados", "Ejecución exitosa");
                }
                else
                {
                    MessageBox.Show("Valores no validos", "Ingrese un telefono valido");
                }
            }
        }
        private void btnNuevaDireccion_Click(object sender, EventArgs e)
        {
            verDireccion(); 
        }
        private void verDireccion()
        {
            string direccion = "";
            
            if (InputBox.inputBox("Ingrese su nueva Direccion de envio ", "Direccion de envio", ref direccion) == DialogResult.OK)
            {
                int contador = 0; 
                for (int i = 1; i < direccion.Length; i ++)
                {
                    if (string.Equals(direccion.Substring(i,1), direccion.Substring((i-1), 1)) && direccion.Length > 1)
                    {
                        contador += 1; 
                    }
                    
                }
                if (direccion.Length > 7 && direccion.Length < 100 && contador < Math.Floor(Convert.ToDecimal(direccion.Length / 2) ) && !string.Equals(lblCodigoCliente.Text,"00"))
                {
                    string consulta = "insert into Direcciones (ID_cliente, numeroCliente) values (" + lblCodigoCliente.Text + ", '" + Convert.ToString(direccion) + "';";
                    cmbDireccion.Items.Add(direccion);
                    MessageBox.Show("Valores Ingresados", "Ejecución exitosa");
                }
                else
                {
                    MessageBox.Show("Valores no validos", "Ingrese un telefono valido");
                }

            }

        }

        private void dgDetalleVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            datagrid(); 
        }
    }
}