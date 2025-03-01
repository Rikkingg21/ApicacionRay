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
    public partial class AdminEgresos : Form
    {
        public AdminEgresos()
        {
            InitializeComponent();
        }

        private void btnGuardarEgreso_Click(object sender, EventArgs e)
        {
            string montoEgreso = txtMontoEgreso.Text;
            string motivoEgreso = txtMotivoEgreso.Text;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(montoEgreso) || string.IsNullOrWhiteSpace(motivoEgreso))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            // Obtener la fecha y hora actual en el formato deseado
            string fechaEmision = DateTime.Now.ToString("yyyy-MM-dd HH:mm");

            // Intentar conectar a la base de datos y guardar los datos
            try
            {
                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "INSERT INTO EGRESOS (FECHAEMISION, CANTIDAD, DESCRIPCION) VALUES (@FechaEmision, @Cantidad, @Descripcion)";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaEmision", fechaEmision);
                        comando.Parameters.AddWithValue("@Cantidad", Convert.ToDecimal(montoEgreso));
                        comando.Parameters.AddWithValue("@Descripcion", motivoEgreso);
                        comando.ExecuteNonQuery();

                        MessageBox.Show("Datos guardados exitosamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
        }

        private void txtMontoEgreso_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtMotivoEgreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtMotivoEgreso.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }
    }
}
