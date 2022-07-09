using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerizimZZ
{
    public partial class frCodigoBarra : Form
    {
        SqlCommand cmd;
        bool existe = false; 
        SqlConnection connection = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");
        public frCodigoBarra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {


                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    BarcodeResult codigoLeido = BarcodeReader.QuicklyReadOneBarcode(pictureBox1.Image, BarcodeEncoding.QRCode | BarcodeEncoding.Code128, true);

                    if (codigoLeido != null)
                    {
                        textBox1.Text = codigoLeido.ToString();
                    }
                }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) == true || string.IsNullOrEmpty(textBox2.Text) == true))
            {
                errorProvider1.SetError(groupBox1, "Ingrese todos los datos");
            }
            else if (existe == true && string.IsNullOrEmpty(textBox1.Text) == false && string.IsNullOrEmpty(textBox2.Text) == false) 
            {
                errorProvider1.SetError(groupBox1, "");
                SqlCommand consulta = new SqlCommand("Select ID_codigoProducto, precio_producto, nombreProducto, cantidadProducto, estadoPRoducto from Producto where codigoBarra = '" + textBox1.Text + "';",connection);
                connection.Open();
                consulta.Parameters.AddWithValue("codigoBarra", textBox2.Text);
                SqlDataReader registro = consulta.ExecuteReader();
                if (registro.Read())
                {
                   
                    if (Convert.ToInt32(registro[4]) != 0 && Convert.ToInt32(textBox2.Text) < Convert.ToInt32(registro[3]))
                    {
                        DetalleVenta fr = new DetalleVenta();
                        fr.dgDetalleVenta.Rows.Add(registro[0].ToString, registro[2].ToString, textBox2.Text, registro[1].ToString, (Convert.ToInt32(textBox2.Text)* Convert.ToInt32(registro[1])));
                    }
                    else
                    {
                        MessageBox.Show("Algo Salio Mal. Lo sentimos"); 
                    }
                }
            }
            else
            {
                MessageBox.Show("Algo Salio Mal. Lo sentimos");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql; 
            
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                try
                {
                    sql = "Select imagen from Producto where codigoBarra = '" + textBox1.Text+ "'";
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                        cmd = new SqlCommand(sql, connection);
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        
                        if (reader.HasRows)
                        {
                            existe = true;
                            byte[] imag = (byte[])(reader[0]);
                            if (imag == null)
                            {
                                pictureBox1.Image = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_; ;
                            }
                            else
                            {
                                MemoryStream ms = new MemoryStream(imag);
                                pictureBox1.Image = Image.FromStream(ms);
                            }
                            
                        }
                        else
                        {
                            connection.Close();
                            MessageBox.Show("No existe el producto");
                            pictureBox1.Image = GerizimZZ.Properties.Resources.losentimos;
                        }
                    }
                }
                catch (Exception ee)
                {
                    Image imagen = GerizimZZ.Properties.Resources.Imagen1_PhotoRoom__1_;
                    pictureBox1.Image = imagen;
                    
                }
                connection.Close(); 
            } } 
    }
}
