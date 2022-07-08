using IronBarCode;
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
    public partial class frCodigoBarra : Form
    {
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
                        textBox1.Text =codigoLeido.ToString();
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
            else
            {
                errorProvider1.SetError(groupBox1, "");
            }
            string consulta = "select * from Producto where codigoBarra = '" + textBox1.Text + "';";
        }
    }
}
