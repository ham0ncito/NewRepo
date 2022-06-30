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
    public partial class FrmCliente : Form
    {
        Cl_Clientes clientes = new Cl_Clientes();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void lbldireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblID_cliente_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsegundoApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprimerApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblsegundoApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblprimerApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblsegundoNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblprimerNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Gerizimdst.Cliente' table. You can move, or remove it, as needed.
            this.clienteTableAdapter.Fill(this.Gerizimdst.Clientes);
        }

        private void dgvCliente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvCliente.SelectedRows)
            {
                txtID_cliente.Text = item.Cells[0].Value.ToString();
                txtprimerNombre.Text = item.Cells[1].Value.ToString();
                txtsegundoNombre.Text = item.Cells[2].Value.ToString();
                txtprimerApellido.Text = item.Cells[3].Value.ToString();
                txtsegundoApellido.Text = item.Cells[4].Value.ToString();
                txtTelefono.Text = item.Cells[5].Value.ToString();
                txtdireccion.Text = item.Cells[6].Value.ToString();
            }
        }

        private void btneliminar_Cliente_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Esta seguro que desea eliminar este registro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.Yes)
            {
                string ID_cliente;
                foreach (DataGridViewRow item in this.dgvCliente.SelectedRows)
                {
                    ID_cliente = item.Cells[0].Value.ToString();
                    clientes.Eliminar_Cliente(ID_cliente);
                }
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
                SqlDataAdapter comando = new SqlDataAdapter();
                string sql = "SELECT * FROM Cliente";
                comando.SelectCommand = new SqlCommand(sql, con);
                DataTable tabla = new DataTable();
                comando.Fill(tabla);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = tabla;
                dgvCliente.DataSource = bSource;
                con.Close();
                MessageBox.Show("Registro eliminado con exito", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnmodificar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clientes.Modificar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
            }
        }

        private void btnagregar_Cliente_Click(object sender, EventArgs e)
        {
            if (txtdireccion.Text == "" || txtID_cliente.Text == "" || txtprimerApellido.Text == "" || txtprimerNombre.Text == "" || txtsegundoApellido.Text == "" || txtsegundoNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Los campos no pueden ir vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                clientes.Agregar_Cliente(txtID_cliente.Text, txtprimerNombre.Text, txtsegundoNombre.Text, txtprimerApellido.Text, txtsegundoApellido.Text, txtTelefono.Text, txtdireccion.Text);
                MessageBox.Show("Registro modificado con exito", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            SqlDataAdapter comando = new SqlDataAdapter();
            string sql = "SELECT * FROM Cliente";
            comando.SelectCommand = new SqlCommand(sql, con);
            DataTable tabla = new DataTable();
            comando.Fill(tabla);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = tabla;
            dgvCliente.DataSource = bSource;
            con.Close();
        }

        private void txtBuscar_Cliente_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dgvCliente.DataSource;
            bs.Filter = string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "ID_cliente",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "primerNombre",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "segundoNombre",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "primerApellido",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "segundoApellido",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "telefono",
                txtBuscar_Cliente.Text) + " OR " +
                string.Format("Convert([{0}], 'System.String') LIKE '{1}%'", "direccion",
                txtBuscar_Cliente.Text);
            dgvCliente.DataSource = bs;
        }
    }
}
