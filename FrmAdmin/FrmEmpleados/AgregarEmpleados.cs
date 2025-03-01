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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApicacionRay.FrmAdmin.FrmEmpleados
{
    public partial class AgregarEmpleados : Form
    {
        public AgregarEmpleados()
        {
            InitializeComponent();
            CargarEmpresas();
            comboBoxEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRango.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarEmpresas()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT RUCEMPRESARIAL, NOMEMPRESA FROM EMPRESA";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string rucEmpresa = reader["RUCEMPRESARIAL"].ToString();

                            comboBoxEmpresa.Items.Add($"{rucEmpresa}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las empresas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (!CamposCompletos())
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string nombreUsuario = txtNomUsuario.Text;
                string dniUsuario = txtDNIUsuario.Text;
                string passwordUsuario = txtPasswordUsuario.Text;
                string rango = comboBoxRango.SelectedItem.ToString();
                string selectedEmpresa = comboBoxEmpresa.SelectedItem.ToString();
                string empresaId = selectedEmpresa.Split(' ')[0]; // Obtiene el RUC de la empresa seleccionada

                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "INSERT INTO USUARIO (NOMBREUSUARIO, DNI, CONTRASEÑA, RANGO, EMPRESAID) " +
                                   "VALUES (@NombreUsuario, @DNI, @Contraseña, @Rango, @EmpresaId)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@DNI", dniUsuario);
                        command.Parameters.AddWithValue("@Contraseña", passwordUsuario);
                        command.Parameters.AddWithValue("@Rango", rango);
                        command.Parameters.AddWithValue("@EmpresaId", empresaId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos(); // Función para limpiar los campos después de la inserción
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCampos()
        {
            txtNomUsuario.Text = "";
            txtDNIUsuario.Text = "";
            txtPasswordUsuario.Text = "";
            comboBoxRango.SelectedIndex = -1; // Limpia la selección del combo de Rango
            comboBoxEmpresa.SelectedIndex = -1; // Limpia la selección del combo de Empresa
        }

        private void txtNomUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtDNIUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void comboBoxEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private bool CamposCompletos()
        {
            if (string.IsNullOrWhiteSpace(txtNomUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtDNIUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtPasswordUsuario.Text) ||
                comboBoxRango.SelectedItem == null ||
                comboBoxEmpresa.SelectedItem == null)
            {
                return false;
            }

            return true;
        }
    }
}

