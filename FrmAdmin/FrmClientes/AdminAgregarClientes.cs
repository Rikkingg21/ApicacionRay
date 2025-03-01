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

namespace ApicacionRay.FrmAdmin
{
    public partial class AdminAgregarClientes : Form
    {
        public AdminAgregarClientes()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "INSERT INTO CLIENTES (DNICLIENTE, NOMCLIENTE, APELLIDOCLIENTE, CELULAR) " +
                                   "VALUES (@DNI, @NOMCLIENTE, @APELLIDOCLIENTE, @CELULAR)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asigna los valores de los campos desde los TextBox a los parámetros de la consulta
                        command.Parameters.AddWithValue("@DNI", txtDNIcliente.Text);
                        command.Parameters.AddWithValue("@NOMCLIENTE", txtNomCliente.Text);
                        command.Parameters.AddWithValue("@APELLIDOCLIENTE", txtApellidoCliente.Text);
                        command.Parameters.AddWithValue("@CELULAR", txtCellCliente.Text);

                        command.ExecuteNonQuery(); // Ejecuta la consulta de inserción
                    }
                }

                MessageBox.Show("Los datos se guardaron exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtDNIcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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
    }
}
