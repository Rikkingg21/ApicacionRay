using ApicacionRay.FrmAdmin.FrmProductos;
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
using System.IO;



namespace ApicacionRay.FrmAdmin.FrmBoleta
{
    public partial class BuscarBoleta : Form
    {
        public BuscarBoleta()
        {
            InitializeComponent();
            DGV.SelectionChanged += DGV_SelectionChanged;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string comprobante = comboComprobante.SelectedItem?.ToString();
            string dni = txtDNI.Text.Trim();

            // Construir la consulta SQL basada en los valores proporcionados
            string query = "SELECT IDCOMPROBANTE, TIPOCOMPROBANTE, FECHA, DNICLIENTE FROM COMPROBANTE WHERE 1 = 1";

            if (!string.IsNullOrEmpty(codigo))
            {
                query += $" AND IDCOMPROBANTE = '{codigo}'";
            }

            if (!string.IsNullOrEmpty(comprobante))
            {
                query += $" AND TIPOCOMPROBANTE = '{comprobante}'";
            }

            if (!string.IsNullOrEmpty(dni))
            {
                query += $" AND DNICLIENTE = '{dni}'";
            }

            // Llamar al método para cargar los resultados en el DataGridView
            CargarResultados(query);
        }
        private void CargarResultados(string query)
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    adapter.Fill(dataTable);

                    // Asignar los datos al DataGridView
                    DGV.DataSource = dataTable;

                    // Renombrar las columnas según tus nombres deseados
                    DGV.Columns["IDCOMPROBANTE"].HeaderText = "NUMERO";
                    DGV.Columns["FECHA"].HeaderText = "FECHA";
                    DGV.Columns["TIPOCOMPROBANTE"].HeaderText = "TIPO";
                    DGV.Columns["DNICLIENTE"].HeaderText = "DNI";
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra durante la carga de datos
                    MessageBox.Show("Error al cargar los resultados: " + ex.Message);
                }
            }
        }
        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGV.Columns["VER"].Index && e.RowIndex >= 0)
            {
                // Reemplaza "NUMERO" con el nombre real de la columna que contiene el ID del comprobante en tu DataGridView
                int idComprobante = Convert.ToInt32(DGV.Rows[e.RowIndex].Cells["IDCOMPROBANTE"].Value);

                // Realizar una consulta para obtener los detalles y el monto del comprobante seleccionado
                string query = $"SELECT DETALLES, MONTO FROM COMPROBANTE WHERE IDCOMPROBANTE = {idComprobante}";

                // Llamar al método para cargar los resultados en el DataGridView de Detalles (DGVDetalles)
                CargarDetalles(query);

            }
        }
        private void CargarDetalles(string query)
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    adapter.Fill(dataTable);

                    // Asignar los datos al DataGridView DGVDetalles
                    DGVDetalles.DataSource = dataTable;

                    // Renombrar las columnas según tus nombres deseados
                    DGVDetalles.Columns["DETALLES"].HeaderText = "DETALLES";
                    DGVDetalles.Columns["MONTO"].HeaderText = "MONTO";
                }
                catch (Exception ex)
                {
                    // Manejar cualquier excepción que ocurra durante la carga de datos
                    MessageBox.Show("Error al cargar los detalles: " + ex.Message);
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int idComprobante = Convert.ToInt32(txtCodigo.Text);

                // Mostrar un cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este comprobante?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Consulta SQL para eliminar el comprobante de la base de datos
                    string deleteQuery = $"DELETE FROM COMPROBANTE WHERE IDCOMPROBANTE = {idComprobante}";

                    // Ejecutar la consulta para eliminar el comprobante
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        SqlCommand command = new SqlCommand(deleteQuery, connection);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Comprobante eliminado correctamente.");
                                // Volver a cargar los datos en el DataGridView después de eliminar
                                CargarResultados("SELECT IDCOMPROBANTE, TIPOCOMPROBANTE, FECHA, DNICLIENTE FROM COMPROBANTE WHERE 1 = 1");
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el comprobante.");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al intentar eliminar el comprobante: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduce un ID de comprobante válido.");
            }
        }

        private void txtDNI_Enter(object sender, EventArgs e)
        {
            if(txtDNI.Text == "DNI")
            {
                txtDNI.Text = "";
                txtDNI.ForeColor = Color.Black;
            }
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "N°")
            {
                txtCodigo.Text = "";
                txtCodigo.ForeColor = Color.Black;
            }
        }

        private void DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (DGV.SelectedRows.Count > 0)
            {
                // Obtener los valores de las celdas seleccionadas en el DataGridView
                string codigo = DGV.SelectedRows[0].Cells["IDCOMPROBANTE"].Value.ToString();
                string dni = DGV.SelectedRows[0].Cells["DNICLIENTE"].Value.ToString();

                // Asignar los valores a los campos de texto
                txtCodigo.Text = codigo;
                txtDNI.Text = dni;
            }
        }
    }
}
