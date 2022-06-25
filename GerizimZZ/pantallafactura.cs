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
    public partial class pantallafactura : Form
    {
        public pantallafactura()
        {
            InitializeComponent();
        }
        conexionfactura cme = new conexionfactura();

        private void pantallafactura_Load(object sender, EventArgs e)
        {
            cme.datosgrid(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            insucursal.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            incliente.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            infecha.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            id.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            indetalle.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            intotal.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            ////idcajas.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void infecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void intotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
