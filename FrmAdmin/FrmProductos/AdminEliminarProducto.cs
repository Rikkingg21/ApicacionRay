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

namespace ApicacionRay.FrmAdmin.FrmProductos
{
    public partial class AdminEliminarProducto : Form
    {
        public AdminEliminarProducto()
        {
            InitializeComponent();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtCodProducto.Text;

            if (!string.IsNullOrEmpty(codigoProducto))
            {
                try
                {
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        string query = "DELETE FROM PRODUCTO WHERE CODPRODUC = @codigo";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@codigo", codigoProducto);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("El producto ha sido eliminado correctamente.");
                            // Limpiar campos después de eliminar
                            txtCodProducto.Text = "";
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el código ingresado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de producto.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtCodProducto.Text;

            if (!string.IsNullOrEmpty(codigoProducto))
            {
                try
                {
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        string query = "SELECT NOMBREPRODUC, CATEGORIA, ESTADO FROM PRODUCTO WHERE CODPRODUC = @codigo";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@codigo", codigoProducto);

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            label5.Text = reader["NOMBREPRODUC"].ToString();
                            label6.Text = reader["CATEGORIA"].ToString();
                            label7.Text = reader["ESTADO"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el código ingresado.");
                            // Limpiar labels si no se encontró el producto
                            label5.Text = "";
                            label6.Text = "";
                            label7.Text = "";
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un código de producto.");
            }
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
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
