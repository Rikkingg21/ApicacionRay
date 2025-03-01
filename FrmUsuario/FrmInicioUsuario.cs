using ApicacionRay.FrmAdmin;
using ApicacionRay.FrmAdmin.Caja;
using ApicacionRay.FrmAdmin.FrmBoleta;
using ApicacionRay.FrmAdmin.FrmClientes;
using ApicacionRay.FrmUsuario.VerVentasEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApicacionRay.FrmUsuario
{
    public partial class FrmInicioUsuario : Form
    {
        public FrmInicioUsuario()
        {
            InitializeComponent();
            PersonalizarDiseño();
            this.MinimumSize = new Size(720, 716);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void PersonalizarDiseño()
        {
            panelSubMenuCaja.Visible = false;
            panelSubMenuBoleta.Visible = false;
            panelSubMenuCliente.Visible = false;
            panelSubMenuProductos.Visible = false;
            panelSubMenuVenta.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if (panelSubMenuCaja.Visible == true)
                panelSubMenuCaja.Visible = false;
            if (panelSubMenuBoleta.Visible == true)
                panelSubMenuBoleta.Visible = false;
            if (panelSubMenuCliente.Visible == true)
                panelSubMenuCliente.Visible = false;
            if (panelSubMenuProductos.Visible == true)
                panelSubMenuProductos.Visible = false;
            if (panelSubMenuVenta.Visible == true)
                panelSubMenuVenta.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        public void MostrarFormularioEnPanel(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(formulario);
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuVenta);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            AdminNuevaVenta adminNuevaVenta = new AdminNuevaVenta();
            MostrarFormularioEnPanel(adminNuevaVenta);
            EsconderSubMenu();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuProductos);
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto editarProducto = new EditarProducto();
            MostrarFormularioEnPanel(editarProducto);
            EsconderSubMenu();
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuBoleta);
        }

        private void btnBuscarBoleta_Click(object sender, EventArgs e)
        {
            BuscarBoleta buscarBoleta = new BuscarBoleta();
            MostrarFormularioEnPanel(buscarBoleta);
            EsconderSubMenu();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCaja);
        }

        private void btnAperturarCaja_Click(object sender, EventArgs e)
        {
            AdminAperturarCaja adminAperturarCaja = new AdminAperturarCaja();
            MostrarFormularioEnPanel(adminAperturarCaja);
            EsconderSubMenu();
        }

        private void btnEgresos_Click(object sender, EventArgs e)
        {
            AdminEgresos adminEgresos = new AdminEgresos();
            MostrarFormularioEnPanel(adminEgresos);
            EsconderSubMenu();
        }

        private void btnVerVentas_Click(object sender, EventArgs e)
        {
            VerVentasFormulario verVentasFormulario = new VerVentasFormulario();
            MostrarFormularioEnPanel(verVentasFormulario);
            EsconderSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCliente);
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AdminAgregarClientes adminAgregarClientes = new AdminAgregarClientes();
            MostrarFormularioEnPanel(adminAgregarClientes);
            EsconderSubMenu();
        }

        private void btnEdiatCliente_Click(object sender, EventArgs e)
        {
            AdminEditarCliente adminEditarCliente = new AdminEditarCliente();
            MostrarFormularioEnPanel(adminEditarCliente);
            EsconderSubMenu();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
