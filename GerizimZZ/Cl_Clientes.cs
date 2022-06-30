using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GerizimZZ
{
    internal class Cl_Clientes
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Gerizim; Integrated Security=True;");
        private string iD_cliente;
        private string primerNombre_Cliente;
        private string segundoNombre_Cliente;
        private string primerApellido_Cliente;
        private string segunndoApellido_Cliente;
        private string direccion_Cliente;
        private string telefono_Cliente;

        public string ID_cliente { get => iD_cliente; set => iD_cliente = value; }
        public string PrimerNombre_Cliente { get => primerNombre_Cliente; set => primerNombre_Cliente = value; }
        public string SegundoNombre_Cliente { get => segundoNombre_Cliente; set => segundoNombre_Cliente = value; }
        public string PrimerApellido_Cliente { get => primerApellido_Cliente; set => primerApellido_Cliente = value; }
        public string SegunndoApellido_Cliente { get => segunndoApellido_Cliente; set => segunndoApellido_Cliente = value; }
        public string Direccion_Cliente { get => direccion_Cliente; set => direccion_Cliente = value; }
        public string Telefono_Cliente { get => telefono_Cliente; set => telefono_Cliente = value; }

        public void Agregar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Telefono_Cliente, string Direccion_Cliente )
        {
            try
            {
                string sql = "INSERT INTO Cliente(ID_cliente, primerNombre, segundoNombre, primerApellido, SegunndoApellido, telefono, direccion) VALUES ('"
                + ID_cliente + "','" + primerNombre_Cliente + "','" + segundoNombre_Cliente + "','"
                + primerApellido_Cliente + "','" + segundoApellido_Cliente + "','" + Telefono_Cliente  + "','" + Direccion_Cliente + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro agregado con exito", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Datos ingresados erronamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Modificar_Cliente(string ID_cliente, string primerNombre_Cliente, string segundoNombre_Cliente, string primerApellido_Cliente, string segundoApellido_Cliente, string Direccion_Cliente, string Telefono_Cliente)
        {
            string sql = "UPDATE Clientes SET primerNombre = '" +
                primerNombre_Cliente + "', segundoNombre = '" +
                segundoNombre_Cliente + "', primerApellido = '" +
                primerApellido_Cliente + "', SegunndoApellido = '" +
                segundoApellido_Cliente + "', telefono = '" +
                Telefono_Cliente + "', direccion  = '" +
                Direccion_Cliente + "' WHERE ID_cliente = '" +
                ID_cliente + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public void Eliminar_Cliente(string ID_cliente)
        {
            string sql = "DELETE FROM Clientes WHERE ID_cliente = '" + ID_cliente + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
