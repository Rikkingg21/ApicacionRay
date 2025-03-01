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
    public partial class AdminEditarCliente : Form
    {
        public AdminEditarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            string dniCliente = txtDNIcliente.Text;

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
                            txtNomCliente.Text = reader["NOMCLIENTE"].ToString();
                            txtApellidoCliente.Text = reader["APELLIDOCLIENTE"].ToString();
                            txtCellCliente.Text = reader["CELULAR"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos(); // Limpia los campos si no se encuentra el cliente
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNomCliente.Text = "";
            txtApellidoCliente.Text = "";
            txtCellCliente.Text = "";
        }
        private bool VerificarDatosVacios()
        {
            if (string.IsNullOrWhiteSpace(txtNomCliente.Text) ||
                string.IsNullOrWhiteSpace(txtApellidoCliente.Text) ||
                string.IsNullOrWhiteSpace(txtCellCliente.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void txtDNIcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtCellCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (!VerificarDatosVacios())
            {
                return; // Detener la actualización si hay datos vacíos
            }

            string dniCliente = txtDNIcliente.Text;
            string nomCliente = txtNomCliente.Text;
            string apellidoCliente = txtApellidoCliente.Text;
            string celularCliente = txtCellCliente.Text;

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "UPDATE CLIENTES SET NOMCLIENTE = @NomCliente, APELLIDOCLIENTE = @ApellidoCliente, CELULAR = @CelularCliente WHERE DNICLIENTE = @DniCliente";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NomCliente", nomCliente);
                        command.Parameters.AddWithValue("@ApellidoCliente", apellidoCliente);
                        command.Parameters.AddWithValue("@CelularCliente", celularCliente);
                        command.Parameters.AddWithValue("@DniCliente", dniCliente);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos del cliente actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos del cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
