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

namespace ApicacionRay.FrmAdmin.FrmEmpresa
{
    public partial class AdminEliminarEmpresa : Form
    {
        public AdminEliminarEmpresa()
        {
            InitializeComponent();
        }

        private void btnBuscarRUC_Click(object sender, EventArgs e)
        {
            string rucABuscar = txtRUC.Text;

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT NOMEMPRESA, DIRECCIONEMP, NUMEMPRESA, CORREOEMP, LOGO FROM EMPRESA WHERE RUCEMPRESARIAL = @Ruc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ruc", rucABuscar);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Mostrar los datos en los controles
                            label1.Text = reader["NOMEMPRESA"].ToString();
                            label3.Text = reader["DIRECCIONEMP"].ToString();
                            label4.Text = reader["NUMEMPRESA"].ToString();
                            label5.Text = reader["CORREOEMP"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna empresa con ese RUC.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpiar los campos si no se encuentra el RUC
                            label1.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarEmpresa_Click(object sender, EventArgs e)
        {
            string rucAEliminar = txtRUC.Text;

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "DELETE FROM EMPRESA WHERE RUCEMPRESARIAL = @Ruc";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Ruc", rucAEliminar);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Empresa eliminada correctamente.", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Limpiar los campos después de eliminar
                            label1.Text = "";
                            label3.Text = "";
                            label4.Text = "";
                            label5.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("No se encontró ninguna empresa con ese RUC.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
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
