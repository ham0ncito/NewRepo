using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GerizimZZ
{
    internal class ConexionPedido
    {
        private static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
            return con;
        }

        public static DataTable GetAll()
        {
            SqlConnection con = GetConnection();
            SqlCommand comando = new SqlCommand();
            comando.Connection = con;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select p.fechapedido, p.fechaentrega, p.direccionEntrega, p.estadoentrega, p.ID_factura, r.nombreRepartidor from Pedidos as p inner join Repartidores as r on r.ID_repartidores = p.ID_repartidores;;";
            using (con)
            {
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
        }

        public static void cancelarPedido(int Factura)
        {
            String cancelado = "Cancelado";
            SqlConnection con = GetConnection();
            string sql = "UPDATE Pedidos SET estadoentrega = '" +
            cancelado + "' WHERE ID_factura = '" +
            Factura + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Pedido Cancelado con exito", "Cancelacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

