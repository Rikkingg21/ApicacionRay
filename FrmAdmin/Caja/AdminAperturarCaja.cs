using ApicacionRay.Data;
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

namespace ApicacionRay.FrmAdmin.Caja
{
    public partial class AdminAperturarCaja : Form
    {
        public AdminAperturarCaja()
        {
            InitializeComponent();
        }

        private void btnIniciarVenta_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMonto.Text, out decimal montoApertura))
            {
                try
                {
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        string query = "INSERT INTO CAJA (FECHA, CANTIDAD, USUARIO) VALUES (@Fecha, @Monto, @Usuario)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Fecha", DateTime.Now);
                            command.Parameters.AddWithValue("@Monto", montoApertura);
                            command.Parameters.AddWithValue("@Usuario", SesionActual.NombreUsuario);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Apertura de caja registrada correctamente.");
                            txtMonto.Clear();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar la apertura de caja: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingresa un monto válido.");
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no es un número, ni el punto decimal y tampoco la tecla de retroceso (borrar), se maneja el evento
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo números y punto decimal", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

            // Si el punto decimal ya está presente, se evita agregar otro
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permite un punto decimal", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
