using ApicacionRay.Data;
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
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Diagnostics;
using System.IO;
using System.Drawing.Printing;
using ICSharpCode.SharpZipLib.Core;
using NPOI.SS.Formula.Functions;
using Microsoft.Win32;
using System.Reflection;
using static NPOI.HSSF.Util.HSSFColor;
using PdfiumViewer;
using PdfDocument = PdfiumViewer.PdfDocument;

namespace ApicacionRay.FrmAdmin
{
    public partial class AdminNuevaVenta : Form
    {
        public event Action<string, decimal> PrecioActualizado;
        private int instanciasAbiertas = 0;
        public AdminNuevaVenta()
        {
            InitializeComponent();
            MostrarNombreUsuario();
            MostrarDatosEmpresa();
            Load += Form_Load;
            ActualizarHoraCadaSegundo();
            MostrarCorreoEmpresa();

            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        #region FUNCION PARA AGREGAR PRODUCTOS A DGV
        List<string> codigosAgregados = new List<string>();
        private void btnSumarVenta_Click(object sender, EventArgs e)
        {
            string codigoProducto = txtCodID.Text.Trim();

            if (string.IsNullOrEmpty(codigoProducto))
            {
                MessageBox.Show("Ingrese un código de producto válido.");
                return;
            }

            string query = "SELECT NOMBREPRODUC, PRECIOVENTAPRODUC, ESTADO FROM PRODUCTO WHERE CODPRODUC = @CodigoProducto";

            using (SqlConnection connection = conexion.Conectar())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                    try
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string estadoProducto = reader["ESTADO"].ToString();

                            if (estadoProducto == "TIENDA")
                            {
                                string nombreProducto = reader["NOMBREPRODUC"].ToString();
                                decimal precioProducto = Convert.ToDecimal(reader["PRECIOVENTAPRODUC"]);

                                if (!codigosAgregados.Contains(codigoProducto))
                                {
                                    dataGridView1.Rows.Add(codigoProducto, nombreProducto, precioProducto);
                                    codigosAgregados.Add(codigoProducto);

                                    // Llamada a la función para recalcular la suma de precios
                                    decimal sumaTotalPrecios = CalcularColumnaPrecio();
                                    lblSumaPrecio.Text = sumaTotalPrecios.ToString();
                                    CalcularIGV();
                                    CalcularSubTotal();
                                   
                                }
                                else
                                {
                                    MessageBox.Show("El producto ya ha sido agregado.");
                                }
                            }
                            else if (estadoProducto == "VENDIDO")
                            {
                                MessageBox.Show("Este producto ya está vendido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encontró un producto con el código proporcionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener los datos del producto: " + ex.Message);
                    }
                }
            }
        }
        #endregion

        #region NUMERO DE COMPROBANTE

        private void cboxComprobante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoComprobante = cboxComprobante.SelectedItem.ToString();
            string query = string.Empty;

            switch (tipoComprobante)
            {
                case "BOLETA":
                    query = "SELECT MAX(IDBOLETA) AS UltimoID FROM BOLETA";
                    break;
                case "FACTURA":
                    query = "SELECT MAX(IDFACTURA) AS UltimoID FROM FACTURA";
                    break;
                case "NOTA DE PEDIDO":
                    query = "SELECT MAX(IDNOTADEPEDIDO) AS UltimoID FROM NOTADEPEDIDO";
                    break;
                default:
                    // Manejar otro tipo de comprobante o error
                    break;
            }

            if (!string.IsNullOrEmpty(query))
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        try
                        {
                            object result = command.ExecuteScalar();

                            if (result != DBNull.Value && result != null)
                            {
                                int ultimoID = Convert.ToInt32(result);
                                lblIDcomprobante.Text = ultimoID.ToString();

                                if (int.TryParse(lblIDcomprobante.Text, out int ultimoIDConvertido))
                                {
                                    int siguienteID = ultimoIDConvertido + 1;
                                    lblIDcomprobanteMasUno.Text = siguienteID.ToString();
                                }
                                else
                                {
                                    lblIDcomprobanteMasUno.Text = "No válido";
                                }
                            }
                            else
                            {
                                lblIDcomprobante.Text = "No hay registros";
                                lblIDcomprobanteMasUno.Text = "No hay registros";
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al obtener el último ID: " + ex.Message);
                        }
                    }
                }
            }
        }
        #endregion

        #region GENERAR VENTA BOLETA
        private string filePathPDFGenerado = "";
        private void btnRecibo_Click(object sender, EventArgs e)
        {
            if (!VerificaComprobanteVacio() || !VerificarMetodoPagoVacio())
            {
                return;
            }
            if (codigosAgregados.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = conexion.Conectar())
                    {
                        string tipoComprobante = cboxComprobante.SelectedItem.ToString();
                        string tablaComprobante = string.Empty;

                        switch (tipoComprobante)
                        {
                            case "BOLETA":
                                tablaComprobante = "BOLETA";
                                break;
                            case "FACTURA":
                                tablaComprobante = "FACTURA";
                                break;
                            case "NOTA DE PEDIDO":
                                tablaComprobante = "NOTADEPEDIDO";
                                break;
                            default:
                                // Manejar otro tipo de comprobante o error
                                break;
                        }

                        if (!string.IsNullOrEmpty(tablaComprobante))
                        {
                            foreach (string codigo in codigosAgregados)
                            {

                                int codigoProductoAVender = Convert.ToInt32(codigo);

                                // Obtener la fecha del label lblFecha
                                DateTime fechaVenta = DateTime.ParseExact(lblFecha.Text, "dd-MM-yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                                #region ACTUALIZAR ESTADO DE PRODUCTO Y CALCULAR GANANCIA
                                // Actualizar el estado del producto y calcular la ganancia
                                string updateProductoQuery = "UPDATE PRODUCTO SET ESTADO = 'VENDIDO', FECHAVENTA = @FechaVenta WHERE CODPRODUC = @CodigoProducto";
                                string insertIngresosQuery = "INSERT INTO INGRESOS (IDINGRESOS, FECHAEMISION, CANTIDAD, GANANCIA, TIPO, METODO) VALUES (@IDIngresos, @FechaEmision, @Cantidad, @Ganancia, @Tipo, @Metodo)";

                                decimal ganancia = 0;

                                using (SqlCommand commandUpdateProducto = new SqlCommand(updateProductoQuery, connection))
                                {
                                    commandUpdateProducto.Parameters.AddWithValue("@FechaVenta", fechaVenta);
                                    commandUpdateProducto.Parameters.AddWithValue("@CodigoProducto", codigoProductoAVender);

                                    commandUpdateProducto.ExecuteNonQuery();

                                    // Calcular la ganancia del producto
                                    string queryGanancia = "SELECT (PRECIOVENTAPRODUC - PRECIOCOMPRAPRUDUC) AS Ganancia FROM PRODUCTO WHERE CODPRODUC = @CodigoProducto";

                                    using (SqlCommand commandGanancia = new SqlCommand(queryGanancia, connection))
                                    {
                                        commandGanancia.Parameters.AddWithValue("@CodigoProducto", codigoProductoAVender);

                                        object result = commandGanancia.ExecuteScalar();
                                        if (result != null)
                                        {
                                            ganancia = Convert.ToDecimal(result);
                                        }
                                    }
                                }
                                #endregion

                                // Insertar en la tabla INGRESOS
                                using (SqlCommand commandInsertIngresos = new SqlCommand(insertIngresosQuery, connection))
                                {
                                    commandInsertIngresos.Parameters.AddWithValue("@IDIngresos", lblIDcomprobanteMasUno.Text);
                                    commandInsertIngresos.Parameters.AddWithValue("@FechaEmision", fechaVenta);
                                    commandInsertIngresos.Parameters.AddWithValue("@Cantidad", lblSumaPrecio.Text);
                                    commandInsertIngresos.Parameters.AddWithValue("@Ganancia", ganancia);
                                    commandInsertIngresos.Parameters.AddWithValue("@Tipo", cboxComprobante.SelectedItem.ToString());
                                    commandInsertIngresos.Parameters.AddWithValue("@Metodo", tipoPagoSeleccionado);

                                    commandInsertIngresos.ExecuteNonQuery();
                                }
                                string insertComprobanteQuery = $"INSERT INTO {tablaComprobante} (ID{tablaComprobante}) VALUES (@IDComprobante)";

                                using (SqlCommand commandInsertComprobante = new SqlCommand(insertComprobanteQuery, connection))
                                {
                                    commandInsertComprobante.Parameters.AddWithValue("@IDComprobante", lblIDcomprobanteMasUno.Text);
                                    commandInsertComprobante.ExecuteNonQuery();
                                }
                            }

                            GenerarPDF();

                            dataGridView1.Rows.Clear();
                            codigosAgregados.Clear();
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cambiar el estado del producto: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay productos agregados.");
            }
        }
        #endregion

        private bool VerificaComprobanteVacio()
        {
            if (cboxComprobante.SelectedItem == null || string.IsNullOrEmpty(cboxComprobante.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor, seleccione un tipo de comprobante.");
                return false;
            }
            return true;
        }

        #region GERNERAR PDF
        private void GenerarPDF()
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Boletas");


            // Si la carpeta "Boletas" no existe, la crea
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = $"{cboxComprobante.SelectedItem.ToString()}_{lblIDcomprobanteMasUno.Text}_{DateTime.Now.ToString("ddMMyyyy_HHmm")}.pdf";
            string filePath = Path.Combine(folderPath, fileName);

            string paginahtml_texto = Properties.Resources.Plantilla.ToString();

            //paginahtml_texto = paginahtml_texto.Replace("@Logo", LogoEmpresa);
            paginahtml_texto = paginahtml_texto.Replace("@NombreEmpresa", lblEmpresa.Text);
            paginahtml_texto = paginahtml_texto.Replace("@RUCempresa", lblRUC.Text);
            paginahtml_texto = paginahtml_texto.Replace("@Correo", lblCorreo.Text);
            paginahtml_texto = paginahtml_texto.Replace("@TipoComprobante", cboxComprobante.SelectedItem.ToString());
            paginahtml_texto = paginahtml_texto.Replace("@lblIDcomprobanteMasUno", lblIDcomprobanteMasUno.Text);
            paginahtml_texto = paginahtml_texto.Replace("@lblFecha", lblFecha.Text);
            paginahtml_texto = paginahtml_texto.Replace("@tipoPagoSeleccionado", tipoPagoSeleccionado);
            paginahtml_texto = paginahtml_texto.Replace("@txtDNI", txtDNI.Text);
            paginahtml_texto = paginahtml_texto.Replace("@lblCliente", lblCliente.Text);

            string filas = string.Empty;
            
            foreach (DataGridViewRow row  in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["PRODUCTO"].Value.ToString() + "</td>";
                
                filas += "<td>" + row.Cells["PRECIO"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            
            paginahtml_texto = paginahtml_texto.Replace("@Filas", filas);
            paginahtml_texto = paginahtml_texto.Replace("@lblSubTotal", lblSubTotal.Text);
            paginahtml_texto = paginahtml_texto.Replace("@lblIGV", lblIGV.Text);
            paginahtml_texto = paginahtml_texto.Replace("@lblSumaPrecio", lblSumaPrecio.Text);

            paginahtml_texto = paginahtml_texto.Replace("@lblUsuario", lblUsuario.Text);


            
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                    Document pdfDoc = new Document(PageSize.A4, 10, 10, 10, 10);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(new Phrase(""));

                    byte[] imagenBytes = ImagenABytes(pictureBoxLogoEmp.Image);

                    if (imagenBytes != null)
                    {
                        // Crea una imagen en iTextSharp usando el arreglo de bytes
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagenBytes);

                        img.ScaleToFit(80, 60);
                        float distanciaDesdeIzquierda = 70f; // 36mm de margen desde la izquierda
                        float posX = pdfDoc.LeftMargin + distanciaDesdeIzquierda;
                        img.SetAbsolutePosition(posX, pdfDoc.Top - 60);
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }
                    pdfDoc.Close();
                    stream.Close();
            }
            //ImprimirPDF(filePath);
            MostrarPDFEnNavegadorYImprimir(filePath);
            //MostrarPDFEnWebBrowser(filePath);
            
            InsertarComprobanteEnBaseDeDatos();
        }
        private byte[] ImagenABytes(System.Drawing.Image imagen)
        {
            if (imagen == null)
                return null;

            using (System.IO.MemoryStream stream = new System.IO.MemoryStream())
            {
                // Convierte la imagen a un arreglo de bytes
                imagen.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }
        #region comprobante db
        private void InsertarComprobanteEnBaseDeDatos()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    List<string> detallesProductos = new List<string>();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        string nombreProducto = row.Cells["PRODUCTO"].Value.ToString();
                        detallesProductos.Add(nombreProducto);
                    }

                    string detallesConcatenados = string.Join(", ", detallesProductos);

                    string query = "INSERT INTO COMPROBANTE (IDCOMPROBANTE, TIPOCOMPROBANTE, FECHA, DNICLIENTE, DETALLES, MONTO) " +
                                   "VALUES (@IDComprobante, @TipoComprobante, @Fecha, @DNICliente, @Detalles, @Monto)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDComprobante", lblIDcomprobanteMasUno.Text);
                    command.Parameters.AddWithValue("@TipoComprobante", cboxComprobante.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@Fecha", DateTime.Now);
                    command.Parameters.AddWithValue("@DNICliente", txtDNI.Text);
                    command.Parameters.AddWithValue("@Monto", lblSumaPrecio.Text);
                    command.Parameters.AddWithValue("@Detalles", detallesConcatenados);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar en la base de datos: " + ex.Message);
                throw;
            }
        }
        #endregion

        #endregion

        #region IMPRIMIR PDF
        private void ImprimirPDF(string filePath)
        {
            try
            {
                // Abre el archivo PDF con el visor predeterminado del sistema
                ProcessStartInfo info = new ProcessStartInfo(filePath)
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process.Start(info);
            }
            catch (Win32Exception ex)
            {
                // 0x80004005: No hay impresora instalada o no se puede acceder a ella
                if (ex.ErrorCode == unchecked((int)0x80004005))
                {
                    MessageBox.Show("No se encontró ninguna impresora disponible. Comprueba tu configuración de impresoras.", "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error al imprimir el archivo PDF: " + ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al imprimir el archivo PDF: " + ex.Message, "Error de impresión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPDFEnWebBrowser(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("El archivo PDF no existe.", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Abre el archivo PDF en un control WebBrowser
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Navigate(filePath);

                Form form = new Form();
                form.Text = "Vista previa del PDF";
                form.Controls.Add(webBrowser);
                form.Size = new System.Drawing.Size(800, 600); // Establece un tamaño adecuado para la ventana

                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar el archivo PDF: " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarPDFEnNavegadorYImprimir(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("El archivo PDF no existe.", "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Process.Start(filePath);

                System.Threading.Thread.Sleep(1000); // Espera 5 segundos (ajusta según sea necesario)

                SendKeys.SendWait("^p"); // Ctrl + P para imprimir
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("{ENTER}");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar o imprimir el archivo PDF: " + ex.Message, "Error de visualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region IGV
        private decimal CalcularColumnaPrecio()
        {
            decimal sumaPrecios = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    decimal precio = Convert.ToDecimal(row.Cells[2].Value);
                    sumaPrecios += precio;
                }
            }

            return sumaPrecios;
        }
        private decimal CalcularIGV()
        {
            decimal sumaPrecios = 0;

            // Suma los precios de la columna
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    decimal precio = Convert.ToDecimal(row.Cells[2].Value);
                    sumaPrecios += precio;
                }
            }

            // Calcula el IGV (18%)
            decimal igv = sumaPrecios * 0.18m;
            lblIGV.Text = igv.ToString("0.00");

            return igv; // Devuelve el valor del IGV si lo necesitas en otra parte del código
        }
        private decimal CalcularSubTotal()
        {
            decimal sumaPrecios = 0;

            // Suma los precios de la columna
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[2].Value != null && row.Cells[2].Value != DBNull.Value)
                {
                    decimal precio = Convert.ToDecimal(row.Cells[2].Value);
                    sumaPrecios += precio;
                }
            }
            decimal sub = sumaPrecios * 0.82m;
            lblSubTotal.Text = sub.ToString("0.00");

            return sub;
        }
        #endregion

        #region APARTADO METODO DE PAGO
        private bool VerificarMetodoPagoVacio()
        {
            // Verifica si no se ha seleccionado un método de pago
            if (string.IsNullOrEmpty(tipoPagoSeleccionado))
            {
                MessageBox.Show("Por favor, seleccione un método de pago.");
                return false; // Detiene la ejecución si el método de pago no está seleccionado
            }
            return true; // Indica que la validación se cumple
        }
        private string tipoPagoSeleccionado = "";

        private void VerificarComprobanteDePago(string tipoPago)
        {
            tipoPagoSeleccionado = tipoPago;
        }

        private void radioButtonYape_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYape.Checked)
            {
                VerificarComprobanteDePago(radioButtonYape.Text);
            }
        }

        private void radioButtonPlin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPlin.Checked)
            {
                VerificarComprobanteDePago(radioButtonPlin.Text);
            }
        }

        private void radioButtonTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTransferencia.Checked)
            {
                VerificarComprobanteDePago(radioButtonTransferencia.Text);
            }
        }

        private void radioButtonEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEfectivo.Checked)
            {
                VerificarComprobanteDePago(radioButtonEfectivo.Text);
            }
        }

        private void radioButtonTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTarjeta.Checked)
            {
                VerificarComprobanteDePago(radioButtonTarjeta.Text);
            }
        }

        #endregion

        #region APRTADO DNI
        private void btnBuscarDNI_Click(object sender, EventArgs e)
        {
            // Obtener el DNI ingresado en txtDNI
            string dniCliente = txtDNI.Text;

            // Aquí deberías buscar el cliente en tu base de datos
            string nombreCliente = ObtenerNombreClientePorDNI(dniCliente);

            if (!string.IsNullOrEmpty(nombreCliente))
            {
                lblCliente.Text = nombreCliente;
            }
            else
            {
                lblCliente.Text = "Cliente no encontrado";
            }
        }
        private string ObtenerNombreClientePorDNI(string dni)
        {
            string nombreCliente = string.Empty;

            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT NOMCLIENTE FROM CLIENTES WHERE DNICLIENTE = @DNI";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI", dni);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            nombreCliente = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return nombreCliente;

        }
        #endregion

        #region APARTADO NUEVO CLIENTE
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            AdminAgregarClientes formAgregarCliente = new AdminAgregarClientes();
            formAgregarCliente.ShowDialog();
        }
        #endregion

        #region APARTADO HORA
        private void Form_Load(object sender, EventArgs e)
        {
            ActualizarHora();
        }
        private async void ActualizarHoraCadaSegundo()
        {
            while (true)
            {
                ActualizarHora();
                await Task.Delay(1000);
            }
        }

        private void ActualizarHora()
        {
            string fechaHoraActual = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            lblFecha.Text = fechaHoraActual;
        }

        #endregion

        #region APARTADO CARGAR NOMBRE DEL CAJERO
        private void MostrarNombreUsuario()
        {
            lblUsuario.Text = SesionActual.NombreUsuario;
        }
        #endregion

        #region MOSTAR DATOS EMPRESA
        private void MostrarDatosEmpresa()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT NOMEMPRESA, RUCEMPRESARIAL, LOGO FROM EMPRESA WHERE IDEMPRESA = 1"; // Asumiendo IDEMPRESA = 1

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            string nombreEmpresa = reader["NOMEMPRESA"].ToString();
                            string rucEmpresa = reader["RUCEMPRESARIAL"].ToString();

                            lblEmpresa.Text = $"{nombreEmpresa}";
                            lblRUC.Text = $"{rucEmpresa}";

                            // Manejar el logo si existe
                                if (reader["LOGO"] != DBNull.Value)
                                {
                                    byte[] imageData = (byte[])reader["LOGO"];

                                    // Redimensionar la imagen antes de asignarla al pictureBox
                                    using (MemoryStream ms = new MemoryStream(imageData))
                                    {
                                        System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
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
                            lblEmpresa.Text = "Empresa no encontrada";
                            lblRUC.Text = string.Empty; // Limpiar el RUC si no se encuentra la empresa
                            pictureBoxLogoEmp.Image = null; // Limpiar el PictureBox si no se encuentra la empresa
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos de la empresa: " + ex.Message);
            }
        }

        #endregion

        #region FUNCION PARA DGV
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["ELIMINAR"].Index && e.RowIndex >= 0)
            {
                string codigoProducto = dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                decimal precioProducto = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["PRECIO"].Value);

                // Remover el producto de la lista y actualizar el total
                codigosAgregados.Remove(codigoProducto);
                dataGridView1.Rows.RemoveAt(e.RowIndex);

                decimal sumaTotalPrecios = CalcularColumnaPrecio();
                lblSumaPrecio.Text = sumaTotalPrecios.ToString();
                CalcularIGV();
                CalcularSubTotal();
            }
            else if (e.ColumnIndex == dataGridView1.Columns["EDITAR"].Index && e.RowIndex >= 0)
            {
                string codigoProducto = dataGridView1.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
                decimal precioProducto = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["PRECIO"].Value);

                // Abres el formulario para editar el precio
                AdminEditarPrecioProducto editarPrecioForm = new AdminEditarPrecioProducto(codigoProducto, precioProducto);
                editarPrecioForm.FormClosed += (s, args) =>
                {
                    if (editarPrecioForm.DialogResult == DialogResult.OK)
                    {
                        // Obtiene el nuevo precio del formulario AdminEditarPrecioProducto
                        decimal nuevoPrecio = editarPrecioForm.NuevoPrecio;

                        // Actualiza el precio en el dataGridView1 si se ha modificado el precio
                        if (nuevoPrecio != precioProducto)
                        {
                            dataGridView1.Rows[e.RowIndex].Cells["PRECIO"].Value = nuevoPrecio;
                            decimal sumaTotalPrecios = CalcularColumnaPrecio();
                            lblSumaPrecio.Text = sumaTotalPrecios.ToString();
                            CalcularIGV();
                            CalcularSubTotal();
                        }
                    }
                };

                editarPrecioForm.ShowDialog();
            }

        }
        #endregion

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }
        #region PARAMETROS
        private void txtCodID_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion

        #region IMPORTAR CORREO EMPRESA
        private void MostrarCorreoEmpresa()
        {
            try
            {
                using (SqlConnection connection = conexion.Conectar())
                {
                    string query = "SELECT CORREOEMP FROM EMPRESA WHERE IDEMPRESA = 1"; // Consulta para obtener el correo de la empresa con IDEMPRESA igual a 1
                    SqlCommand command = new SqlCommand(query, connection);

                    string correoEmpresa = (string)command.ExecuteScalar(); // Ejecutar la consulta y obtener el correo

                    // Mostrar el correo en lblCorreo
                    lblCorreo.Text = correoEmpresa;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        #endregion
        
    }
}
