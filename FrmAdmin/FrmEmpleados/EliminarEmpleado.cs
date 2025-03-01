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

namespace ApicacionRay.FrmAdmin.FrmEmpleados
{
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                string dniBuscar = txtDNIUsuario.Text;

                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT NOMBREUSUARIO, CONTRASEÑA, RANGO, EMPRESAID FROM USUARIO WHERE DNI = @DniBuscar";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DniBuscar", dniBuscar);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Mostrar los datos en los labels
                            label6.Text = reader["NOMBREUSUARIO"].ToString();
                            label7.Text = reader["CONTRASEÑA"].ToString();
                            label8.Text = reader["RANGO"].ToString();
                            string empresaId = reader["EMPRESAID"].ToString();

                            // Ahora, si deseas mostrar el RUC de la empresa en label9:
                            MostrarRucEmpresa(empresaId);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún empleado con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpiar los labels si no se encuentra el empleado
                            label6.Text = "";
                            label7.Text = "";
                            label8.Text = "";
                            label9.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarRucEmpresa(string empresaId)
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT RUCEMPRESARIAL FROM EMPRESA WHERE RUCEMPRESARIAL = @EmpresaId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmpresaId", empresaId);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            label9.Text = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el RUC de la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnElminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string dniEliminar = txtDNIUsuario.Text;

                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "DELETE FROM USUARIO WHERE DNI = @DniEliminar";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DniEliminar", dniEliminar);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario eliminado correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarLabels(); // Limpia los labels después de la eliminación exitosa
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún usuario con ese DNI.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarLabels()
        {
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
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
    }
}
