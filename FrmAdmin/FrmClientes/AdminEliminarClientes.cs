using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApicacionRay.FrmAdmin.FrmClientes
{
    public partial class AdminEliminarClientes : Form
    {
        public AdminEliminarClientes()
        {
            InitializeComponent();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dniCliente = txtDNI.Text; // Obtener el DNI ingresado

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT NOMCLIENTE, APELLIDOCLIENTE, CELULAR FROM CLIENTES WHERE DNICLIENTE = @DniCliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DniCliente", dniCliente);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            labelNombre.Text = reader["NOMCLIENTE"].ToString();
                            labelApellido.Text = reader["APELLIDOCLIENTE"].ToString();
                            labelCell.Text = reader["CELULAR"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarLabels(); // Limpia los labels si no se encuentra el cliente
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarLabels()
        {
            labelNombre.Text = "";
            labelApellido.Text = "";
            labelCell.Text = "";
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            string dniCliente = txtDNI.Text; // Obtener el DNI ingresado

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "DELETE FROM CLIENTES WHERE DNICLIENTE = @DniCliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DniCliente", dniCliente);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarLabels(); // Limpia los labels después de eliminar
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
