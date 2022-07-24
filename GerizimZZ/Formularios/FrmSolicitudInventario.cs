using GerizimZZ.Clases;
using GerizimZZ.Datasets;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace GerizimZZ
{
    public partial class FrmSolicitudInventario : Form
    {
        private Cl_SolicitarInventario inventario = new Cl_SolicitarInventario();
        private Productosdst dstInventario;
        private DataTable dtInventario;

        private int codigo, cantidadproducto, cantidadminima, estadoproducto;
        private double PrecioProducto, pesoproducto;

        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su solicitud se ha completado con exito", "Solicitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dstInventario.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_codigoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Precio_producto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "NombreProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "PesoProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoBarra", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CodigoCatologo", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "CantidadMinima", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "DescripcionProducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "EstadoPRoducto", txtBuscar.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "Fechaingreso", txtBuscar.Text);
            dgvInventario.DataSource = dstInventario.Tables[0].DefaultView;
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (dgvInventario.Rows.Count > 0)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "PDF (*.pdf)|*.pdf";
                guardar.FileName = "Resultado.pdf";
                bool errormessage = false;
                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(guardar.FileName))
                    {
                        try
                        {
                            File.Delete(guardar.FileName);
                        }
                        catch (Exception ex)
                        {
                            errormessage = true;
                            MessageBox.Show(ex.Message);
                        }
                    }
                    if (!errormessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvInventario.Columns.Count);
                            pTable.DefaultCell.Padding = 4;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn col in dgvInventario.Columns)
                            {
                                PdfPCell pcell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pcell);
                            }
                            foreach (DataGridViewRow viewrow in dgvInventario.Rows)
                            {
                                if (viewrow.Selected == true)
                                {
                                    foreach (DataGridViewCell dcell in viewrow.Cells)
                                    {
                                        pTable.AddCell(dcell.Value.ToString());
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(guardar.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4.Rotate(), 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("Informacion guardara correctamente", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay informacion en la tabla(datagrid)", "Info");
            }
        }

        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtFechaIngresoo_TextChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
            txtFechaIngresoo.Text = DateTime.Now.ToString("d");
        }

        public void limpiar()
        {
            txtNombreOriginal.Clear();
            txtBuscar.Clear();
            txtCodigoCatalogo.Clear();
            txtCantidadProducto.Clear();
            txtCantidadMinima.Clear();
            txtCodigoBarra.Clear();
            txtEstadoProducto.Clear();
            txtDescripcion.Clear();
            txtPesoProducto.Clear();
            txtPrecioProducto.Clear();

            txtID_CodigoProducto.Clear();
        }

        //Este es el boton que imprime
        private void btnImpresion_Click(object sender, EventArgs e)
        {
            ImprimirSolicitud = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            ImprimirSolicitud.PrinterSettings = ps;
           // ImprimirSolicitud.PrintPage += imp;
            ImprimirSolicitud.Print();
            Impresion.Show();//Esta hace que imprima

        }



        private void ImprimirSolicitud_PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Drawing.Font fuente = new System.Drawing.Font("Arial", 15, FontStyle.Regular, GraphicsUnit.Point);
            ////Graphics.DrawImage(pictureBox1.Image, 350, 60, 150, 150);
            e.Graphics.DrawImage(ImgLogoGerizim.Image, 370, 100, 150, 150); //(Desplazamiento Izquierda/Derecha, Altura en el Doc, Ancho, Alto)
            e.Graphics.DrawString(" Multiservicios Gerizim  ", fuente, Brushes.Green, new RectangleF(330, 240, 600, 60));
            e.Graphics.DrawString(" Barrio Paz Barahona  1 Calle  2 Avenida  22505876 ", fuente, Brushes.Black, new RectangleF(200, 280, 1000, 100));
            e.Graphics.DrawString("Nombre Original: " + txtNombreOriginal.Text, fuente, Brushes.Black, new RectangleF(190, 350, 1000, 100));
            e.Graphics.DrawString("Cantidad Producto: " + txtCantidadProducto.Text, fuente, Brushes.Black, new RectangleF(190, 380, 1000, 100));
            e.Graphics.DrawString("Codigo Barra: " + txtCodigoBarra.Text, fuente, Brushes.Black, new RectangleF(190, 410, 1000, 100));
            e.Graphics.DrawString("Estado Producto: " + txtEstadoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 440, 1000, 100));
            e.Graphics.DrawString("Peso Producto: " + txtPesoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 470, 1000, 100));
            e.Graphics.DrawString("Cantidad Minima: " + txtCantidadMinima.Text, fuente, Brushes.Black, new RectangleF(190, 500, 1000, 100));
            e.Graphics.DrawString("Codigo Producto: " + txtID_CodigoProducto.Text, fuente, Brushes.Black, new RectangleF(190, 530, 1000, 100));
            e.Graphics.DrawString("Codigo Catalogo: " + txtCodigoCatalogo.Text, fuente, Brushes.Black, new RectangleF(190, 560, 1000, 100));
            e.Graphics.DrawString("Precio Producto: " + txtPrecioProducto.Text, fuente, Brushes.Black, new RectangleF(190, 590, 1000, 100));
            e.Graphics.DrawString("Descripcion: " + txtDescripcion.Text, fuente, Brushes.Black, new RectangleF(190, 620, 500, 100));

        }

        public FrmSolicitudInventario()
        {
            InitializeComponent();
        }

        private void FrmSolicitudInventario_Load(object sender, EventArgs e)
        {
            dtInventario = Cl_SolicitarInventario.GetAll();
            dstInventario = new Productosdst();
            dstInventario.Tables.Add(dtInventario);
            dgvInventario.DataSource = dstInventario.Tables[0];
            txtFechaIngresoo.Text = DateTime.Now.ToString("d");
        }

        private void dgvSolicitudInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvInventario.SelectedRows)
            {

                txtID_CodigoProducto.Text = item.Cells[0].Value.ToString();
                txtPrecioProducto.Text = item.Cells[1].Value.ToString();
                txtNombreOriginal.Text = item.Cells[2].Value.ToString();
                txtPesoProducto.Text = item.Cells[3].Value.ToString();
                txtCodigoBarra.Text = item.Cells[4].Value.ToString();
                txtCodigoCatalogo.Text = item.Cells[5].Value.ToString();
                txtCantidadProducto.Text = item.Cells[6].Value.ToString();
                txtCantidadMinima.Text = item.Cells[7].Value.ToString();
                txtDescripcion.Text = item.Cells[8].Value.ToString();
                txtEstadoProducto.Text = item.Cells[9].Value.ToString();
                txtFechaIngresoo.Text = item.Cells[10].Value.ToString();
            }
        }

        //Este es el boton de  Solicitud
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCantidadMinima.Text == "" || txtCantidadProducto.Text == "" || txtCodigoBarra.Text == "" || txtCodigoCatalogo.Text == "" || txtDescripcion.Text == "" || txtEstadoProducto.Text == "" || txtFechaIngresoo.Text == "" || txtID_CodigoProducto.Text == "" || txtNombreOriginal.Text == "" || txtPesoProducto.Text == "" || txtPrecioProducto.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //cantidad = Convert.ToInt32(txtCantidadProducto.Text);
                    codigo = Convert.ToInt32(txtID_CodigoProducto.Text);
                    cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                    cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                    estadoproducto = Convert.ToInt32(txtEstadoProducto.Text);
                    PrecioProducto = Convert.ToDouble(txtPrecioProducto.Text);
                    pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                    //Llama a la clase de Solicitar Inventario 

                    inventario.Agregar_Solicitud(codigo, PrecioProducto, txtNombreOriginal.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatalogo.Text, cantidadproducto, cantidadminima, txtDescripcion.Text, estadoproducto, Convert.ToDateTime(txtFechaIngresoo.Text));
                    SqlConnection conec = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                    SqlDataAdapter coman = new SqlDataAdapter();
                    string sql = "SELECT * FROM Producto";
                    coman.SelectCommand = new SqlCommand(sql, conec);
                    dtInventario = Cl_SolicitarInventario.GetAll();
                    dstInventario = new Productosdst();
                    dstInventario.Tables.Add(dtInventario);
                    dgvInventario.DataSource = dstInventario.Tables[0];
                    conec.Close();
                    MessageBox.Show("Registro modificado con exito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
    }
}