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
    public partial class AdminAgregarEmpresa : Form
    {
        public AdminAgregarEmpresa()
        {
            InitializeComponent();
        }

        private void btnGuardarAgregarEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "INSERT INTO EMPRESA (RUCEMPRESARIAL, NOMEMPRESA, DIRECCIONEMP, NUMEMPRESA, CORREOEMP, LOGO) " +
                                   "VALUES (@Ruc, @Nombre, @Direccion, @Numero, @Correo, @Logo)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Asigna los valores de los campos desde los TextBox a los parámetros de la consulta
                        command.Parameters.AddWithValue("@Ruc", textruc.Text);
                        command.Parameters.AddWithValue("@Nombre", textnomemp.Text);
                        command.Parameters.AddWithValue("@Direccion", textdireccion.Text);
                        command.Parameters.AddWithValue("@Numero", textnumero.Text);
                        command.Parameters.AddWithValue("@Correo", textcorreo.Text);

                        // Manejo del logo
                        if (pictureBoxLogoEmp.ImageLocation != null)
                        {
                            byte[] imageData;
                            using (System.IO.FileStream fs = new System.IO.FileStream(pictureBoxLogoEmp.ImageLocation, System.IO.FileMode.Open))
                            {
                                imageData = new byte[fs.Length];
                                fs.Read(imageData, 0, (int)fs.Length);
                            }
                            command.Parameters.AddWithValue("@Logo", imageData);
                        }
                        else
                        {
                            // Si no se selecciona una imagen, asigna un valor nulo al parámetro del logo
                            command.Parameters.AddWithValue("@Logo", DBNull.Value);
                        }

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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();

            if (abrirImagen.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogoEmp.ImageLocation = abrirImagen.FileName;
                pictureBoxLogoEmp.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 &&  e.KeyChar <= 47) || (e.KeyChar >= 58 &&  e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números","Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        #region PARAMETROS PARA TEXT BOX
        
        private void textnomemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                textnomemp.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void textdireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                textdireccion.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void textnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        #endregion
    }
}
