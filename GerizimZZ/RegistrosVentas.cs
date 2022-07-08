﻿using System;
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
    public partial class RegistrosVentas : Form

    {
       
        public RegistrosVentas()
        {
            InitializeComponent();
            

        }

        ConexionVentascs cmda = new ConexionVentascs();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrosVentas_Load(object sender, EventArgs e)
        {
            cmda.llenargrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            nventa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            fechapago.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            idsucursal.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            idcajas.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            intventasdia.Text = dataGridView1.CurrentRow.Cells[1*4].Value.ToString();
            intsemanal.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

        }

        

        private void barraBusqueda_TextChanged_1(object sender, EventArgs e)
        {

        }
        SqlConnection conectarr = new SqlConnection("Data Source =localhost ; Initial Catalog =Gerizim ; Integrated Security = True");

        private void barraBusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            conectarr.Open();
            SqlCommand cmda = conectarr.CreateCommand();

            cmda.CommandType = CommandType.Text;
            cmda.CommandText = "SELECT * FROM Factura where ID_cliente like ('" + barraBusqueda.Text + "%')";
            cmda.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmda);

            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conectarr.Close();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void VFactura_Click(object sender, EventArgs e)
        {
            pantallafactura rc = new pantallafactura();
            rc.ShowDialog();
        }

        private void VPedido_Click(object sender, EventArgs e)
        {
            //RegistroPedido rc = new RegistroPedido();
            //rc.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }







