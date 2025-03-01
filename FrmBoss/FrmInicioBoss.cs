using ApicacionRay.FrmAdmin;
using ApicacionRay.FrmAdmin.Caja;
using ApicacionRay.FrmAdmin.FrmBoleta;
using ApicacionRay.FrmAdmin.FrmClientes;
using ApicacionRay.FrmAdmin.FrmEmpleados;
using ApicacionRay.FrmAdmin.FrmEmpresa;
using ApicacionRay.FrmAdmin.FrmProductos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApicacionRay.FrmBoss
{
    public partial class FrmInicioBoss : Form
    {
        public FrmInicioBoss()
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
            panelSubMenuEmpleados.Visible = false;
            panelSubMenuEmpresa.Visible = false;
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
            if (panelSubMenuEmpleados.Visible == true)
                panelSubMenuEmpleados.Visible = false;
            if (panelSubMenuEmpresa.Visible == true)
                panelSubMenuEmpresa.Visible = false;
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

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuProductos);
        }

        private void brnEmpresa_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEmpresa);
        }

        private void btnBoleta_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuBoleta);
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCaja);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuEmpleados);
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            AdminNuevaVenta adminNuevaVenta = new AdminNuevaVenta();
            MostrarFormularioEnPanel(adminNuevaVenta);
            EsconderSubMenu();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AdminAgregarProductos adminAgregarProductos = new AdminAgregarProductos();
            MostrarFormularioEnPanel(adminAgregarProductos);
            EsconderSubMenu();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto editarProducto = new EditarProducto();
            MostrarFormularioEnPanel(editarProducto);
            EsconderSubMenu();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            AdminEliminarProducto adminEliminarProducto = new AdminEliminarProducto();
            MostrarFormularioEnPanel(adminEliminarProducto);
            EsconderSubMenu();
        }

        private void btnEditarEmpresa_Click(object sender, EventArgs e)
        {
            AdminEditarEmpresa adminEditarEmpresa = new AdminEditarEmpresa();
            MostrarFormularioEnPanel(adminEditarEmpresa);
            EsconderSubMenu();
        }

        private void btnBuscarBoleta_Click(object sender, EventArgs e)
        {
            BuscarBoleta buscarBoleta = new BuscarBoleta();
            MostrarFormularioEnPanel(buscarBoleta);
            EsconderSubMenu();
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
            AdminEliminarClientes adminEliminarClientes = new AdminEliminarClientes();
            MostrarFormularioEnPanel(adminEliminarClientes);
            EsconderSubMenu();
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
            AdminVerVentas adminVerVentas = new AdminVerVentas();
            MostrarFormularioEnPanel(adminVerVentas);
            EsconderSubMenu();
        }

        private void btnAgregarEmpleados_Click(object sender, EventArgs e)
        {
            AgregarEmpleados agregarEmpleados = new AgregarEmpleados();
            MostrarFormularioEnPanel(agregarEmpleados);
            EsconderSubMenu();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            EliminarEmpleado eliminarEmpleado = new EliminarEmpleado();
            MostrarFormularioEnPanel(eliminarEmpleado);
            EsconderSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenuCliente);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin loginForm = new frmLogin();
            loginForm.Show();
        }
    }
}
