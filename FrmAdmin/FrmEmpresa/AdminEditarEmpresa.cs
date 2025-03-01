using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApicacionRay.FrmAdmin.FrmEmpresa
{
    public partial class AdminEditarEmpresa : Form
    {
        public AdminEditarEmpresa()
        {
            InitializeComponent();
            CargarRUC();
        }
        private void CargarRUC()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT RUCEMPRESARIAL FROM EMPRESA";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string ruc = reader["RUCEMPRESARIAL"].ToString();
                            comboBoxRUC.Items.Add(ruc);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los RUC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarRUC_Click(object sender, EventArgs e)
        {
            string rucSeleccionado = comboBoxRUC.SelectedItem?.ToString(); // Obtener el RUC seleccionado

            if (!string.IsNullOrEmpty(rucSeleccionado))
            {
                try
                {
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        string query = "SELECT NOMEMPRESA, DIRECCIONEMP, NUMEMPRESA, CORREOEMP, LOGO FROM EMPRESA WHERE RUCEMPRESARIAL = @RucEmpresa";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RucEmpresa", rucSeleccionado);

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                label5.Text = reader["NOMEMPRESA"].ToString();
                                txtDireccion.Text = reader["DIRECCIONEMP"].ToString();
                                txtNumero.Text = reader["NUMEMPRESA"].ToString();
                                txtCorreo.Text = reader["CORREOEMP"].ToString();

                                // Manejar el logo si existe
                                if (reader["LOGO"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["LOGO"];

                                    // Redimensionar la imagen antes de asignarla al pictureBox
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        Image img = Image.FromStream(ms);
                                        pictureBoxLogoEmp.Image = new Bitmap(img, new Size(pictureBoxLogoEmp.Width, pictureBoxLogoEmp.Height));
                                    }
                                }
                                else
                                {
                                    pictureBoxLogoEmp.Image = null; // Si no hay imagen, limpia el pictureBox
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ninguna empresa con ese RUC.", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Puedes agregar aquí alguna lógica adicional si lo necesitas
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el RUC: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un RUC.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogoEmp.ImageLocation = abrirImagen.FileName;
                pictureBoxLogoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void comboBoxRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] allowedChars = { '(', ')', '\'', '\"', '-' };

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar) && !allowedChars.Contains(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS Y CARACTERES ESPECIALES ( ) ' \" -", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
        private void btnActulizarEmpresa_Click(object sender, EventArgs e)
        {
            string rucEmpresa = comboBoxRUC.Text;

            string nombreEmpresa = label5.Text;
            string direccionEmpresa = txtDireccion.Text;
            string numeroEmpresa = txtNumero.Text;
            string correoEmpresa = txtCorreo.Text;

            byte[] logoBytes = null;

            // Obtener la representación de bytes de la imagen si está asignada al pictureBox
            if (pictureBoxLogoEmp.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Verifica si la imagen tiene un formato válido antes de intentar guardarla
                    if (pictureBoxLogoEmp.Image.RawFormat != null)
                    {
                        pictureBoxLogoEmp.Image.Save(ms, pictureBoxLogoEmp.Image.RawFormat);
                        logoBytes = ms.ToArray();
                    }
                }
            }
            else
            {
                // Si la imagen es nula, asigna null a logoBytes para indicar que no se actualiza la imagen
                logoBytes = null;
            }

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "UPDATE EMPRESA SET NOMEMPRESA = @NombreEmpresa, DIRECCIONEMP = @DireccionEmpresa, NUMEMPRESA = @NumeroEmpresa, CORREOEMP = @CorreoEmpresa, LOGO = @Logo WHERE RUCEMPRESARIAL = @RucEmpresa";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreEmpresa", nombreEmpresa);
                        command.Parameters.AddWithValue("@DireccionEmpresa", direccionEmpresa);
                        command.Parameters.AddWithValue("@NumeroEmpresa", numeroEmpresa);
                        command.Parameters.AddWithValue("@CorreoEmpresa", correoEmpresa);
                        command.Parameters.AddWithValue("@Logo", (object)logoBytes ?? DBNull.Value); // Verifica si hay una imagen para actualizar

                        command.Parameters.AddWithValue("@RucEmpresa", rucEmpresa);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar los datos de la empresa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los datos de la empresa: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
