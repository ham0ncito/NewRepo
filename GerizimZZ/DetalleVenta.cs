using System.Data;

namespace GerizimZZ
{
    public partial class DetalleVenta : Form
    {
        int x = 0;
        public DetalleVenta()
        {

            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

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

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        static public DataTable tablita = new DataTable();
        static public List<string> idlist = new List<string>();

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
            string comparacion = textc.Id;


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
                        tablita.Rows.RemoveAt(i);
                        tablita.Rows.Add(textc.Id, textc.NombreProducto, textc.Cantidad, textc.precio, textc.total);
                        idlist[i].Remove(i);
                        estado = 1;
                        break;
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

            dgDetalleVenta.DataSource = tablita;

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
            CodigoBarra.Show();
            
        }

    }
}
