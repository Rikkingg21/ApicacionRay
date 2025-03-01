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

namespace ApicacionRay.FrmUsuario.VerVentasEmpleado
{
    public partial class VerVentasFormulario : Form
    {
        public VerVentasFormulario()
        {
            InitializeComponent();
            DTPInicio.Format = DateTimePickerFormat.Custom;
            DTPInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            DTPFin.Format = DateTimePickerFormat.Custom;
            DTPFin.CustomFormat = "dd/MM/yyyy HH:mm";

            DTPInicio.Value = DateTime.Now.Date;
            DTPInicio.Value = DTPInicio.Value.Date;

            DTPFin.Value = DateTime.Now;

            DTPFin.ValueChanged += DTPFin_ValueChanged;
            DTPInicio.ValueChanged += DTPInicio_ValueChanged;
        }
        #region EGRESOS
        private void MostrarEgresosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(CANTIDAD) FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaEgresos = Convert.ToDecimal(result);
                            lblNota1.Text = $"Egresos:";
                            lblEgresos.Text = $"{sumaEgresos:C}";

                        }
                        else
                        {
                            lblNota1.Text = "No hay egresos registrados";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los egresos: " + ex.Message);
            }
        }
        #endregion

        #region INGRESOS
        private void MostrarIngresosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(CANTIDAD) FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaIngresos = Convert.ToDecimal(result);
                            lblNota2.Text = $"Ingresos:";
                            lblIngresos.Text = $"{sumaIngresos:C}";
                        }
                        else
                        {
                            lblNota2.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los ingresos: " + ex.Message);
            }
        }
        #endregion

        #region APERTURA
        private void MostrarAperturaEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(CANTIDAD) FROM CAJA WHERE FECHA >= @FechaInicio AND FECHA <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaCantidad = Convert.ToDecimal(result);
                            lblNota4.Text = $"Monto de apertura:";
                            lblCajaApertura.Text = $"{sumaCantidad:C}";
                        }
                        else
                        {
                            lblNota4.Text = "No hay apertura registrada.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los ingresos: " + ex.Message);
            }
        }
        #endregion

        #region INGRESOS EFECTIVO
        private void MostrarIngresosEfectivoEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(CANTIDAD) FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND METODO = 'Efectivo'";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaIngresos = Convert.ToDecimal(result);
                            lblNota5.Text = $"Ingresos en efectivo:";
                            lblEfectivo.Text = $"{sumaIngresos:C}";
                        }
                        else
                        {
                            lblNota5.Text = "No hay ingresos en efectivo registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los ingresos en efectivo: " + ex.Message);
            }
        }
        #endregion

        #region INGRESOS VARIOS
        private void MostrarIngresosOtrosEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(CANTIDAD) FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND METODO != 'Efectivo'";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaIngresos = Convert.ToDecimal(result);
                            lblNota6.Text = $"Otros ingresos:";
                            lblOtros.Text = $"{sumaIngresos:C}";
                        }
                        else
                        {
                            lblNota6.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los otros ingresos: " + ex.Message);
            }
        }
        #endregion

        #region MONTO CAJA
        private void MostrarMontoCajaEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    // Obtener el monto de apertura de caja para la fecha de inicio
                    string queryAperturaCaja = "SELECT SUM(CANTIDAD) FROM CAJA WHERE FECHA >= @FechaInicio AND FECHA <= @FechaFin";

                    using (SqlCommand comandoAperturaCaja = new SqlCommand(queryAperturaCaja, conexionBD))
                    {
                        comandoAperturaCaja.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comandoAperturaCaja.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object resultAperturaCaja = comandoAperturaCaja.ExecuteScalar();

                        decimal montoAperturaCaja = 0;

                        if (resultAperturaCaja != DBNull.Value)
                        {
                            montoAperturaCaja = Convert.ToDecimal(resultAperturaCaja);
                        }

                        // Obtener la suma de ingresos en efectivo entre las fechas especificadas
                        string queryIngresosEfectivo = "SELECT SUM(CANTIDAD) FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND METODO = 'Efectivo'";

                        using (SqlCommand comandoIngresosEfectivo = new SqlCommand(queryIngresosEfectivo, conexionBD))
                        {
                            comandoIngresosEfectivo.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                            comandoIngresosEfectivo.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                            object resultIngresosEfectivo = comandoIngresosEfectivo.ExecuteScalar();

                            decimal sumaIngresosEfectivo = 0;

                            if (resultIngresosEfectivo != DBNull.Value)
                            {
                                sumaIngresosEfectivo = Convert.ToDecimal(resultIngresosEfectivo);
                            }

                            // Obtener la suma de egresos entre las fechas especificadas
                            string queryEgresos = "SELECT SUM(CANTIDAD) FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                            using (SqlCommand comandoEgresos = new SqlCommand(queryEgresos, conexionBD))
                            {
                                comandoEgresos.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                                comandoEgresos.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                                object resultEgresos = comandoEgresos.ExecuteScalar();

                                decimal sumaEgresos = 0;

                                if (resultEgresos != DBNull.Value)
                                {
                                    sumaEgresos = Convert.ToDecimal(resultEgresos);
                                }

                                // Calcular el monto total en caja
                                decimal totalEnCaja = montoAperturaCaja + sumaIngresosEfectivo;

                                // Restar el monto de egresos del total en caja
                                decimal montoFinalEnCaja = totalEnCaja - sumaEgresos;

                                lblNota7.Text = $"Monto en caja:";
                                lblMontoEnCaja.Text = $"{montoFinalEnCaja:C}";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el monto en caja: " + ex.Message);
            }
        }
        #endregion

        private void DTPFin_ValueChanged(object sender, EventArgs e)
        {
            MostrarEgresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarAperturaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEfectivoEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosOtrosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarMontoCajaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
        }

        private void DTPInicio_ValueChanged(object sender, EventArgs e)
        {
            MostrarEgresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarAperturaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEfectivoEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosOtrosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarMontoCajaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
        }

        private void btnVerDetallesEgresos_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHAEMISION, CANTIDAD, DESCRIPCION FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaIngresos = new DataTable();
                        adaptador.Fill(tablaIngresos);

                        if (tablaIngresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaIngresos;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota1.Text = "No hay egresos registrados.";
                            lblEgresos.Text = "s/.00.0";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de egresos: " + ex.Message);
            }
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND (METODO = 'PLIN' OR METODO = 'YAPE' OR METODO = 'TARJETA' OR METODO = 'TRANSFERENCIA')";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaIngresos = new DataTable();
                        adaptador.Fill(tablaIngresos);

                        if (tablaIngresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaIngresos;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota5.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos con métodos 'PLIN', 'YAPE', 'TARJETA' o 'TRANSFERENCIA': " + ex.Message);
            }
        }

        private void btnVerDetallesVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaIngresos = new DataTable();
                        adaptador.Fill(tablaIngresos);

                        if (tablaIngresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaIngresos;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota2.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos: " + ex.Message);
            }
        }

        private void btnApertura_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHA, CANTIDAD, USUARIO FROM CAJA WHERE FECHA >= @FechaInicio AND FECHA <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaIngresos = new DataTable();
                        adaptador.Fill(tablaIngresos);

                        if (tablaIngresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaIngresos;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota4.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos: " + ex.Message);
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND METODO = 'EFECTIVO'";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaIngresos = new DataTable();
                        adaptador.Fill(tablaIngresos);

                        if (tablaIngresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaIngresos;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota5.Text = "No hay ingresos registrados.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos de tipo 'EFECTIVO': " + ex.Message);
            }
        }
    }
}
