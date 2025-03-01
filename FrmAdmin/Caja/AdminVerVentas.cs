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
using static ApicacionRay.FrmAdmin.Caja.AdminVerVentas;

namespace ApicacionRay.FrmAdmin.Caja
{
    public partial class AdminVerVentas : Form
    {
        public AdminVerVentas()
        {
            InitializeComponent();
            rBDetalles.Checked = true;
            DTPInicio.Format = DateTimePickerFormat.Custom;
            DTPInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            DTPFin.Format = DateTimePickerFormat.Custom;
            DTPFin.CustomFormat = "dd/MM/yyyy HH:mm";

            // Establecer fecha actual y primera hora del día para DTPInicio
            DTPInicio.Value = DateTime.Now.Date;
            DTPInicio.Value = DTPInicio.Value.Date;

            DTPFin.Value = DateTime.Now;

            DTPFin.ValueChanged += DTPFin_ValueChanged;
            DTPInicio.ValueChanged += DTPInicio_ValueChanged;

            DGVdatos.CellFormatting += DGVdatos_CellFormatting;

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

    #region GANACIA
        private void MostrarGananciaEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT SUM(GANANCIA) FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        object result = comando.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal sumaGanancia = Convert.ToDecimal(result);
                            lblNota3.Text = $"Ganancias:";
                            lblGanancias.Text =  $"{sumaGanancia:C}";
                        }
                        else
                        {
                            lblNota3.Text = "No hay ganancias registradas.";
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
            MostrarGananciaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarAperturaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEfectivoEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosOtrosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarMontoCajaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
        }

        private void DTPInicio_ValueChanged(object sender, EventArgs e)
        {
            MostrarEgresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarGananciaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarAperturaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosEfectivoEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarIngresosOtrosEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
            MostrarMontoCajaEntreFechas(DTPInicio.Value.Date, DTPFin.Value.Date);
        }
        #region VER EGRESOS
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
            FiltrarDetallesEgresos();
        }
        private void FiltrarDetallesEgresos()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "";

                if (rBDetalles.Checked)
                {
                    // Tu lógica para mostrar detalles sin agrupación por días, semanas o meses
                    query = "SELECT FECHAEMISION, CANTIDAD, DESCRIPCION FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";
                }
                else if (rBDias.Checked)
                {
                    // Agrupar por días
                    query = "SELECT CONVERT(date, FECHAEMISION) AS Fecha, SUM(CANTIDAD) AS Total FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY CONVERT(date, FECHAEMISION)";
                }
                else if (rBSemanas.Checked)
                {
                    // Agrupar por grupos de 7 días (semanas)
                    query = "SELECT DATEADD(week, DATEDIFF(week, 0, FECHAEMISION), 0) AS FechaInicioSemana, SUM(CANTIDAD) AS Total FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY DATEADD(week, DATEDIFF(week, 0, FECHAEMISION), 0)";
                }
                else if (rBMeses.Checked)
                {
                    // Agrupar por meses
                    query = "SELECT DATEADD(month, DATEDIFF(month, 0, FECHAEMISION), 0) AS PrimerDiaMes, SUM(CANTIDAD) AS Total FROM EGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY DATEADD(month, DATEDIFF(month, 0, FECHAEMISION), 0)";
                }

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaEgresos = new DataTable();
                        adaptador.Fill(tablaEgresos);

                        if (tablaEgresos.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaEgresos;
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
        #endregion
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
            FiltrarDetallesVentas();
        }
        private void FiltrarDetallesVentas()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "";

                if (rBDetalles.Checked)
                {
                    // Tu lógica para mostrar detalles sin agrupación por días, semanas o meses
                    query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";
                }
                else if (rBDias.Checked)
                {
                    // Agrupar por días
                    query = "SELECT CONVERT(date, FECHAEMISION) AS Fecha, SUM(CANTIDAD) AS Total FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY CONVERT(date, FECHAEMISION)";
                }
                else if (rBSemanas.Checked)
                {
                    // Agrupar por grupos de 7 días (semanas)
                    query = "SELECT DATEADD(week, DATEDIFF(week, 0, FECHAEMISION), 0) AS FechaInicioSemana, SUM(CANTIDAD) AS Total FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY DATEADD(week, DATEDIFF(week, 0, FECHAEMISION), 0)";
                }
                else if (rBMeses.Checked)
                {
                    // Agrupar por meses
                    query = "SELECT DATEADD(month, DATEDIFF(month, 0, FECHAEMISION), 0) AS PrimerDiaMes, SUM(CANTIDAD) AS Total FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin GROUP BY DATEADD(month, DATEDIFF(month, 0, FECHAEMISION), 0)";
                }

                using (SqlConnection conexionBD = conexion.Conectar())
                {
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
            FiltrarDetallesCaja();
        }
        private void FiltrarDetallesCaja()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "SELECT FECHA, CANTIDAD, USUARIO FROM CAJA WHERE FECHA >= @FechaInicio AND FECHA <= @FechaFin";

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaCaja = new DataTable();
                        adaptador.Fill(tablaCaja);

                        if (tablaCaja.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaCaja;
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
                MessageBox.Show("Error al obtener los detalles de caja: " + ex.Message);
            }
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    string query = "SELECT FECHAEMISION, CANTIDAD, GANANCIA, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

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
                            lblNota3.Text = "No hay ganancias registradas.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos: " + ex.Message);
            }
            FiltrarGanancias();
        }
        private void FiltrarGanancias()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "SELECT FECHAEMISION, CANTIDAD, GANANCIA, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin";

                using (SqlConnection conexionBD = conexion.Conectar())
                {
                    using (SqlCommand comando = new SqlCommand(query, conexionBD))
                    {
                        comando.Parameters.AddWithValue("@FechaInicio", fechaHoraInicio);
                        comando.Parameters.AddWithValue("@FechaFin", fechaHoraFin);

                        SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                        DataTable tablaGanancias = new DataTable();
                        adaptador.Fill(tablaGanancias);

                        if (tablaGanancias.Rows.Count > 0)
                        {
                            DGVdatos.DataSource = tablaGanancias;
                        }
                        else
                        {
                            DGVdatos.DataSource = null;
                            lblNota3.Text = "No hay ganancias registradas.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ganancias: " + ex.Message);
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
            FiltrarIngresosEfectivo();
        }
        private void FiltrarIngresosEfectivo()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND METODO = 'EFECTIVO'";

                using (SqlConnection conexionBD = conexion.Conectar())
                {
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
                            lblNota5.Text = "No hay ingresos registrados en efectivo.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos de tipo 'EFECTIVO': " + ex.Message);
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
            FiltrarOtrosMetodosPago();
        }
        private void FiltrarOtrosMetodosPago()
        {
            try
            {
                DateTime fechaHoraInicio = DTPInicio.Value;
                DateTime fechaHoraFin = DTPFin.Value;

                string query = "SELECT FECHAEMISION, CANTIDAD, TIPO, METODO FROM INGRESOS WHERE FECHAEMISION >= @FechaInicio AND FECHAEMISION <= @FechaFin AND (METODO = 'PLIN' OR METODO = 'YAPE' OR METODO = 'TARJETA' OR METODO = 'TRANSFERENCIA')";

                using (SqlConnection conexionBD = conexion.Conectar())
                {
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
                            lblNota5.Text = "No hay ingresos registrados con métodos 'PLIN', 'YAPE', 'TARJETA' o 'TRANSFERENCIA'.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los detalles de ingresos con métodos 'PLIN', 'YAPE', 'TARJETA' o 'TRANSFERENCIA': " + ex.Message);
            }
        }

        private void DGVdatos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                string cellValue = e.Value.ToString();

                switch (cellValue)
                {
                    case "Yape":
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Purple;
                        break;
                    case "Plin":
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightBlue;
                        break;
                    case "Efectivo":
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.LightGreen;
                        break;
                    case "Transferencia":
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Orange;
                        break;
                    case "Tarjeta":
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Yellow;
                        break;
                    // Puedes agregar más casos según tus necesidades
                    default:
                        DGVdatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White; // Color por defecto
                        break;
                }
            }
        }

    }
}
