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

namespace ApicacionRay.FrmAdmin.FrmProductos
{
    public partial class AdminEditarPrecioProducto : Form
    {
        private string codigoProducto;
        private decimal precioActual;

        public AdminEditarPrecioProducto(string codigoProducto, decimal precioActual)
        {
            InitializeComponent();
            this.codigoProducto = codigoProducto;
            this.precioActual = precioActual;
        }
        public decimal NuevoPrecio { get; private set; }
        private void btnActualizarPrecio_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNewPrecio.Text, out decimal nuevoPrecio))
        {
            ActualizarPrecioEnBD(codigoProducto, nuevoPrecio);

            // Actualizar la propiedad NuevoPrecio con el valor introducido
            NuevoPrecio = nuevoPrecio;

            // Cerrar el formulario
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        else
        {
            MessageBox.Show("Ingrese un precio válido.");
        }
        }
        private void ActualizarPrecioEnBD(string codigoProducto, decimal nuevoPrecio)
        {
            string query = "UPDATE PRODUCTO SET PRECIOVENTAPRODUC = @NuevoPrecio WHERE CODPRODUC = @CodigoProducto";

            using (SqlConnection connection = conexion.Conectar())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                    command.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("¡Precio actualizado en la base de datos!");
                            // Devuelve el nuevo precio
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar el precio en la base de datos.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el precio: " + ex.Message);
                    }
                }
            }
        }
        private void AdminEditarPrecioProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        
    }
}
