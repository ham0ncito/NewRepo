namespace GerizimZZ
{
    public partial class DetalleVenta : Form
    {
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

        //private void button1_Hover(object sender, EventArgs e)
        //{
        //    this.button1.BackColor = Color.IndianRed;
        //}
        //private void button1_MouseLeaves(object sender, EventArgs e)
        //{
        //    this.button1.BackColor = Color.Transparent;
        //}
        //private void button2_Hover(object sender, EventArgs e)
        //{
        //    this.button2.BackColor = Color.Cyan;
        //}
        //private void button2_MouseLeaves(object sender, EventArgs e)
        //{
        //    this.button2.BackColor = Color.Transparent;
        //}
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void DetalleVenta_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btninventariomi_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha_expiracion;
            DateTime thisDay = DateTime.Today;
            this.txtfecha.Text = thisDay.ToString("G");
            fecha_expiracion = thisDay.AddDays(15);
            this.textBox3.Text = fecha_expiracion.ToString("G");
        }
    }
}