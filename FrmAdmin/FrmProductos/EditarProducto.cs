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

namespace ApicacionRay
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }


        private void btnBuscarProduc_Click(object sender, EventArgs e)
        {
            // Verificar si se ingresó un código válido
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigoProducto = int.Parse(txtCodigo.Text);

                // Realizar la conexión a la base de datos usando tu clase de conexión
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT * FROM PRODUCTO WHERE CODPRODUC = @Codigo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Codigo", codigoProducto);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        // Mostrar los datos del producto en los TextBox correspondientes
                        txtNombre.Text = reader["NOMBREPRODUC"].ToString();
                        txtDescripcion.Text = reader["DESCRIPCION"].ToString();
                        txtPrecioCompra.Text = reader["PRECIOCOMPRAPRUDUC"].ToString();
                        txtPrecioVenta.Text = reader["PRECIOVENTAPRODUC"].ToString();
                        txtCategoria.Text = reader["CATEGORIA"].ToString();
                        txtEditorial.Text = reader["EDITORIAL"].ToString();
                        txtAbreviatura.Text = reader["ABREVIATURA"].ToString();
                        cboxEstado.Text = reader["ESTADO"].ToString();

                        // Puedes añadir más campos aquí si existen en tu tabla
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado");
                        LimiarCampos(); // Limpiar los campos si no se encontró el producto
                    }

                    reader.Close();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código de producto válido");
            }
        }
        

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (!VerificarDatosVacios())
            {
                return; // Detiene el proceso si hay campos vacíos
            }
            // Verificar si se ingresó un código válido
            if (!string.IsNullOrEmpty(txtCodigo.Text))
            {
                int codigoProducto = int.Parse(txtCodigo.Text);

                // Realizar la conexión a la base de datos usando tu clase de conexión
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = @"UPDATE PRODUCTO SET 
                            NOMBREPRODUC = @Nombre,
                            DESCRIPCION = @Descripcion,
                            PRECIOCOMPRAPRUDUC = @PrecioCompra,
                            PRECIOVENTAPRODUC = @PrecioVenta,
                            CATEGORIA = @Categoria,
                            EDITORIAL = @Editorial,
                            ABREVIATURA = @Abreviatura,
                            ESTADO = @Estado
                            WHERE CODPRODUC = @Codigo";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    command.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);
                    command.Parameters.AddWithValue("@PrecioCompra", decimal.Parse(txtPrecioCompra.Text));
                    command.Parameters.AddWithValue("@PrecioVenta", decimal.Parse(txtPrecioVenta.Text));
                    command.Parameters.AddWithValue("@Categoria", txtCategoria.Text);
                    command.Parameters.AddWithValue("@Editorial", txtEditorial.Text);
                    command.Parameters.AddWithValue("@Abreviatura", txtAbreviatura.Text);
                    command.Parameters.AddWithValue("@Estado", cboxEstado.Text);
                    command.Parameters.AddWithValue("@Codigo", codigoProducto);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente");
                        LimiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto");
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese un código de producto válido");
            }
        }

        private void LimiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();
            txtCategoria.Clear();
            txtEditorial.Clear();
            txtAbreviatura.Clear();
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

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtNombre.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtDescripcion.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void txtCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtNombre.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void txtEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtNombre.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void txtAbreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
        private bool VerificarDatosVacios()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioCompra.Text) ||
                string.IsNullOrWhiteSpace(txtPrecioVenta.Text) ||
                string.IsNullOrWhiteSpace(txtCategoria.Text) ||
                string.IsNullOrWhiteSpace(txtEditorial.Text) ||
                string.IsNullOrWhiteSpace(txtAbreviatura.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false; // Hay campos vacíos, detiene el proceso
            }

            return true; // Todos los campos están llenos, puede continuar con el proceso
        }
    }
}
