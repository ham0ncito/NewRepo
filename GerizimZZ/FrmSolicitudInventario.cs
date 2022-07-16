using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GerizimZZ
{
    public partial class FrmSolicitudInventario : Form
    {

        Cl_SolicitarInventario inventario = new Cl_SolicitarInventario();
        Productosdst dstInventario;
        DataTable dtInventario;
       
        int codigo, cantidadproducto, cantidadminima, estadoproducto;
        double PrecioProducto, pesoproducto;

        private void btnSolicitar_Click(object sender, EventArgs e)
        {

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
                //cantidad = Convert.ToInt32(txtCantidadProducto.Text);
                codigo = Convert.ToInt32(txtID_CodigoProducto.Text);
                cantidadproducto = Convert.ToInt32(txtCantidadProducto.Text);
                cantidadminima = Convert.ToInt32(txtCantidadMinima.Text);
                estadoproducto = Convert.ToInt32(txtEstadoProducto.Text);
                PrecioProducto = Convert.ToDouble(txtPrecioProducto.Text);
                pesoproducto = Convert.ToDouble(txtPesoProducto.Text);
                //Llama a la clase de Solicitar Inventario 
                
                inventario.Agregar_Solicitud(codigo, PrecioProducto, txtNombreOriginal.Text, pesoproducto, txtCodigoBarra.Text, txtCodigoCatalogo.Text, cantidadproducto, cantidadminima, txtDescripcion.Text, estadoproducto,  txtFechaIngresoo.Text);
                SqlConnection conec = new SqlConnection("Data Source=TATO180\\SQLEXPRESS;Initial Catalog=Gerizim; Integrated Security=True;");
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
        }
    }
}
