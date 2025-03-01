using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using System.Data;
using static NPOI.HSSF.Util.HSSFColor;

namespace ApicacionRay.FrmAdmin
{
    public partial class AdminAgregarProductos : Form
    {
        public AdminAgregarProductos()
        {
            InitializeComponent();
            CargarCategorias();
            CargarEditoriales();
        }
        private void CargarCategorias()
        {
            List<string> categorias = conexion.ObtenerCategorias();
            cboxCategoria.Items.AddRange(categorias.ToArray());
        }

        private void CargarEditoriales()
        {
            List<string> editoriales = conexion.ObtenerEditoriales();
            cboxEditorial.Items.AddRange(editoriales.ToArray());
        }

        private void btnSubirDB_Click(object sender, EventArgs e)
        {
            if (CamposVacios())
            {
                MessageBox.Show("Complete todos los campos porfavor","Advetencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int codigoProducto = ObtenerCodigoProducto();

            if (ProductoExiste(codigoProducto))
            {
                MessageBox.Show("Espe codigo ya esta agregado en los productos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            AgregarProducto();
            LimpiarCampos();
        }
        private void AgregarProducto()
        {
            string codigoProducto = txtCodProd.Text;
            string nombreProducto = txtNomProd.Text;
            string descripcion = txtDescripcion.Text;
            decimal precioCompra = decimal.Parse(txtPreComProd.Text);
            decimal precioVenta = decimal.Parse(txtPreVenProd.Text);
            string categoria = cboxCategoria.Text;
            string editorial = cboxEditorial.Text;
            string abreviatura = txtAbreviatura.Text;
            string estado = cboxEstado.Text;

            using (SqlConnection connection = conexion.Conectar())
            {
                string query = @"INSERT INTO PRODUCTO (CODPRODUC, NOMBREPRODUC, DESCRIPCION, PRECIOCOMPRAPRUDUC, 
            PRECIOVENTAPRODUC, CATEGORIA, EDITORIAL, ABREVIATURA, ESTADO, FECHAVENTA) 
            VALUES (@Codigo, @Nombre, @Descripcion, @PrecioCompra, @PrecioVenta, @Categoria, 
            @Editorial, @Abreviatura, @Estado, GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", codigoProducto);
                    command.Parameters.AddWithValue("@Nombre", nombreProducto);
                    command.Parameters.AddWithValue("@Descripcion", descripcion);
                    command.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                    command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                    command.Parameters.AddWithValue("@Categoria", categoria);
                    command.Parameters.AddWithValue("@Editorial", editorial);
                    command.Parameters.AddWithValue("@Abreviatura", abreviatura);
                    command.Parameters.AddWithValue("@Estado", estado);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos insertados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private bool ProductoExiste(int codigo)
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                string query = "SELECT COUNT(*) FROM PRODUCTO WHERE CODPRODUC = @Codigo";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Codigo", codigo);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0; // Devuelve verdadero si el producto ya existe
                }
            }
        }
        private bool CamposVacios()
        {
            return string.IsNullOrWhiteSpace(txtNomProd.Text) ||
                   string.IsNullOrWhiteSpace(txtCodProd.Text) ||
                   string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                   string.IsNullOrWhiteSpace(txtPreComProd.Text) ||
                   string.IsNullOrWhiteSpace(txtPreVenProd.Text) ||
                   string.IsNullOrWhiteSpace(cboxCategoria.Text) ||
                   string.IsNullOrWhiteSpace(cboxEditorial.Text) ||
                   string.IsNullOrWhiteSpace(txtAbreviatura.Text) ||
                   string.IsNullOrWhiteSpace(cboxEstado.Text);
        }
        private int ObtenerCodigoProducto()
        {
            return int.Parse(txtCodProd.Text);
        }

        private void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
            // Puedes utilizar otro método para mostrar mensajes al usuario en la interfaz gráfica
        }
        private void LimpiarCampos()
        {
            txtNomProd.Clear();
            txtCodProd.Clear();
            txtDescripcion.Clear();
            txtPreComProd.Clear();
            txtPreVenProd.Clear();
            cboxCategoria.SelectedIndex = -1;
            cboxEditorial.SelectedIndex = -1;
            txtAbreviatura.Clear();
        }
        private void btnSubirProductos_Click(object sender, EventArgs e)
        {
            try
            {
                SubirDatosBaseDeDatos();
                LimpiarDataGridView();
            }
            catch (Exception ex)
            {
                MostrarMensajeError("Error al subir productos a la base de datos: " + ex.Message);
            }
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                ImportarDatosDesdeExcel();
            }
            catch (IOException ex)
            {
                MostrarMensajeError($"El archivo está siendo utilizado por otro proceso: {ex.Message}");
            }
        }

        private void SubirDatosBaseDeDatos()
        {
            using (SqlConnection connection = conexion.Conectar())
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        
                        string nombreProd = row.Cells[1]?.Value?.ToString();
                        string descripcion = row.Cells[2]?.Value?.ToString();
                        string categoria = row.Cells[5]?.Value?.ToString();
                        string editorial = row.Cells[6]?.Value?.ToString();
                        string abreviatura = row.Cells[7]?.Value?.ToString();

                        string codigo = row.Cells[0]?.Value?.ToString();

                        if (!int.TryParse(codigo, out int codigoInt))
                        {
                            continue;
                        }

                        decimal precioCompra;
                        decimal precioVenta;
                        if (!decimal.TryParse(row.Cells[3]?.Value?.ToString(), out precioCompra) ||
                            !decimal.TryParse(row.Cells[4]?.Value?.ToString(), out precioVenta))
                        {
                            continue;
                        }

                        // Estado que se agregará automáticamente
                        string estado = "TIENDA";

                        // Resto de tu lógica de inserción con los parámetros SQL...

                        string query = "INSERT INTO PRODUCTO (CODPRODUC, NOMBREPRODUC, DESCRIPCION, PRECIOCOMPRAPRUDUC, PRECIOVENTAPRODUC, CATEGORIA, EDITORIAL, ABREVIATURA, ESTADO) " +
                               "VALUES (@Codigo, @Nombre, @Descripcion, @PrecioCompra, @PrecioVenta, @Categoria, @Editorial, @Abreviatura, @Estado)";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Codigo", codigoInt);
                        command.Parameters.AddWithValue("@Nombre", nombreProd);
                        command.Parameters.AddWithValue("@Descripcion", descripcion);
                        command.Parameters.AddWithValue("@PrecioCompra", precioCompra);
                        command.Parameters.AddWithValue("@PrecioVenta", precioVenta);
                        command.Parameters.AddWithValue("@Categoria", categoria);
                        command.Parameters.AddWithValue("@Editorial", editorial);
                        command.Parameters.AddWithValue("@Abreviatura", abreviatura);
                        command.Parameters.AddWithValue("@Estado", estado); // Agregar el valor del estado "TIENDA" directamente

                        command.ExecuteNonQuery();
                    }
                }
            }
            // Mensaje indicando que la inserción ha finalizado correctamente
            MessageBox.Show("Datos insertados en la base de datos correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LimpiarDataGridView()
        {
            dataGridView1.Rows.Clear();
        }
        private void MostrarMensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ImportarDatosDesdeExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos de Excel |*.xlsx;*.xls",
                Title = "Seleccionar archivo de Excel"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(fs);
                    ISheet sheet = workbook.GetSheetAt(0);

                    LimpiarDataGridView();

                    for (int i = 0; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);
                        if (row == null) continue;

                        if (i == 0)
                        {
                            continue;
                        }

                        if (row.LastCellNum >= 9)
                        {
                            dataGridView1.Rows.Add(
                                row.GetCell(0)?.ToString(), // CODIGO
                                row.GetCell(1)?.ToString(), // NOMBRE
                                row.GetCell(2)?.ToString(), // DESCRIPCION
                                row.GetCell(3)?.ToString(), // PRECIO DE COMPRA
                                row.GetCell(4)?.ToString(), // PRECIO DE VENTA
                                row.GetCell(5)?.ToString(), // CATEGORIA
                                row.GetCell(6)?.ToString(), // EDITORIAL/MARCA
                                row.GetCell(7)?.ToString(), // ABREVIATURA
                                row.GetCell(8)?.ToString()  // ESTADO
                            );
                        }
                    }
                }
            }
        }

        #region PARAMETROS DE CARACTERES
        private void txtNomProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //PERMITE LETRAS MAYUSCULAS, NUMEROS Y ESPACIOS Y Ñ XD
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                txtNomProd.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void txtCodProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
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

        private void txtPreComProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPreVenProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboxCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                cboxCategoria.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }

        private void cboxEditorial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 'Ñ')
            {
                MessageBox.Show("SOLO MAYÚSCULAS, NÚMEROS Y ESPACIOS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (char.IsLower(e.KeyChar)) // Convertir caracteres ingresados a mayúsculas
            {
                cboxEditorial.SelectedText = char.ToUpper(e.KeyChar).ToString();
                e.Handled = true;
            }
        }
        //FALTA

        private void txtAbreviatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        #endregion

        
    }
}
