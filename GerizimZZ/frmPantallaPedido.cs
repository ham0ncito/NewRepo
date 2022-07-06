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
using System.Diagnostics;



namespace GerizimZZ
{
    public partial class frmPantallaPedido : Form
    {
        Productosdst dstProductos;
        DataTable dt;

        //Inicia el formulario
        public frmPantallaPedido()
        {          
            InitializeComponent();         
        }


        private void PantallaDescripcionProducto_Load(object sender, EventArgs e)
        {
            dt = ConexionPedido.GetAll();
            dstProductos = new Productosdst();
            dstProductos.Tables.Add(dt);
            datagridPedidosRecientes.DataSource = dstProductos.Tables[0];
        }

        private void BarraDeBusqueda_TextChanged(object sender, EventArgs e)
        {
            dstProductos.Tables[0].DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "fechapedido", BarraDeBusqueda.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "fechaentrega", BarraDeBusqueda.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "direccionEntrega", BarraDeBusqueda.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "estadoentrega", BarraDeBusqueda.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_factura", BarraDeBusqueda.Text) + " OR " +
            string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "nombreRepartidor", BarraDeBusqueda.Text);
            datagridPedidosRecientes.DataSource = dstProductos.Tables[0].DefaultView;
        }

        private void botonCancelarPedido_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el pedido?","Precaución",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                MessageBox.Show("Pedido Cancelado");
                txtEntrega.Clear();
                txtFechaPedido.Clear();
                txtRepartidor.Clear();
                txtFechaPedido.Clear();
                txtFactura.Clear();
            
            }
        }

        private void datagridPedidosRecientes_Click(object sender, EventArgs e)
        {
            txtFactura.Text = datagridPedidosRecientes.CurrentRow.Cells[4].Value.ToString();
            txtRepartidor.Text = datagridPedidosRecientes.CurrentRow.Cells[5].Value.ToString();
            txtEntrega.Text = datagridPedidosRecientes.CurrentRow.Cells[2].Value.ToString();
            txtFechaPedido.Text = datagridPedidosRecientes.CurrentRow.Cells[0].Value.ToString();
        }

        private void botonCancelarPedido_Click_1(object sender, EventArgs e)
        {
            String estado = datagridPedidosRecientes.CurrentRow.Cells[3].Value.ToString();
            ConexionPedido pedido = new ConexionPedido();
            if (txtEntrega.Text == "" || txtFactura.Text == "" || txtFechaPedido.Text == "" || txtRepartidor.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (estado == "En Proceso")
                {
                    ConexionPedido.cancelarPedido(Convert.ToInt32(txtFactura.Text));
                    dt = ConexionPedido.GetAll();
                    dstProductos = new Productosdst();
                    dstProductos.Tables.Add(dt);
                    datagridPedidosRecientes.DataSource = dstProductos.Tables[0];
                }
                else
                {
                    MessageBox.Show("No se puede Cancelar un pedido Entregado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
