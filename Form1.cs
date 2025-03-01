using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using ApicacionRay.FrmBoss;
using ApicacionRay.FrmUsuario;
using ApicacionRay.Data;

namespace ApicacionRay
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string contraseña = txtPassword.Text;

            if (string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingresa nombre de usuario y contraseña.");
                return;
            }

            SqlConnection conexion = ApicacionRay.conexion.Conectar();

            // Consulta SQL para verificar el inicio de sesión y obtener el rango
            string consulta = "SELECT RANGO FROM USUARIO WHERE NOMBREUSUARIO = @NombreUsuario AND CONTRASEÑA = @Contraseña";

            using (SqlCommand cmd = new SqlCommand(consulta, conexion))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                string rango = cmd.ExecuteScalar() as string;

                if (!string.IsNullOrEmpty(rango))
                {
                    SesionActual.IniciarSesion(nombreUsuario);
                    MessageBox.Show("Inicio de sesión exitoso.");

                    // Abre el formulario correspondiente según el rango
                    this.Hide();
                    if (rango == "SUPERADMIN")
                    {
                        FrmInicioSuperAdmin formularioInicio = new FrmInicioSuperAdmin();
                        formularioInicio.Show();
                    }
                    else if (rango == "ADMIN")
                    {
                        FrmInicioBoss formularioInicio = new FrmInicioBoss();
                        formularioInicio.Show();
                    }
                    else if (rango == "TRABAJADOR")
                    {
                        FrmInicioUsuario formularioInicio = new FrmInicioUsuario();
                        formularioInicio.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                }
            }

            conexion.Close();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

            if (!char.IsControl(e.KeyChar) && !char.IsUpper(e.KeyChar))
            {
                MessageBox.Show("SOLO MAYÚSCULAS", "Ojo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
