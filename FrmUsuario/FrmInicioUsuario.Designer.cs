namespace ApicacionRay.FrmUsuario
{
    partial class FrmInicioUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnBoleta = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.panelSubMenuCaja = new System.Windows.Forms.Panel();
            this.btnVerVentas = new System.Windows.Forms.Button();
            this.btnEgresos = new System.Windows.Forms.Button();
            this.btnAperturarCaja = new System.Windows.Forms.Button();
            this.panelSubMenuCliente = new System.Windows.Forms.Panel();
            this.btnEdiatCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.panelSubMenuBoleta = new System.Windows.Forms.Panel();
            this.btnBuscarBoleta = new System.Windows.Forms.Button();
            this.panelSubMenuProductos = new System.Windows.Forms.Panel();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.panelSubMenuVenta = new System.Windows.Forms.Panel();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelMenuLateral.SuspendLayout();
            this.panelSubMenuCaja.SuspendLayout();
            this.panelSubMenuCliente.SuspendLayout();
            this.panelSubMenuBoleta.SuspendLayout();
            this.panelSubMenuProductos.SuspendLayout();
            this.panelSubMenuVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnCaja);
            this.panel1.Controls.Add(this.btnBoleta);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 55);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Red;
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Image = global::ApicacionRay.Properties.Resources.cerrar_sesion;
            this.btnCerrarSesion.Location = new System.Drawing.Point(795, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 55);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Red;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::ApicacionRay.Properties.Resources.objetivo;
            this.btnClientes.Location = new System.Drawing.Point(616, 0);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(179, 55);
            this.btnClientes.TabIndex = 13;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.Red;
            this.btnCaja.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Image = global::ApicacionRay.Properties.Resources.cajero_automatico;
            this.btnCaja.Location = new System.Drawing.Point(462, 0);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCaja.Size = new System.Drawing.Size(154, 55);
            this.btnCaja.TabIndex = 12;
            this.btnCaja.Text = "Caja";
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnBoleta
            // 
            this.btnBoleta.BackColor = System.Drawing.Color.Red;
            this.btnBoleta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBoleta.FlatAppearance.BorderSize = 0;
            this.btnBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoleta.ForeColor = System.Drawing.Color.White;
            this.btnBoleta.Image = global::ApicacionRay.Properties.Resources.cheque;
            this.btnBoleta.Location = new System.Drawing.Point(308, 0);
            this.btnBoleta.Name = "btnBoleta";
            this.btnBoleta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBoleta.Size = new System.Drawing.Size(154, 55);
            this.btnBoleta.TabIndex = 8;
            this.btnBoleta.Text = "Boleta";
            this.btnBoleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBoleta.UseVisualStyleBackColor = false;
            this.btnBoleta.Click += new System.EventHandler(this.btnBoleta_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Red;
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Image = global::ApicacionRay.Properties.Resources.comic;
            this.btnProductos.Location = new System.Drawing.Point(154, 0);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(154, 55);
            this.btnProductos.TabIndex = 4;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = System.Drawing.Color.Red;
            this.btnVenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Image = global::ApicacionRay.Properties.Resources.anadir_a_la_cesta_24x24;
            this.btnVenta.Location = new System.Drawing.Point(0, 0);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVenta.Size = new System.Drawing.Size(154, 55);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVenta.UseVisualStyleBackColor = false;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.Yellow;
            this.panelMenuLateral.Controls.Add(this.panelSubMenuCaja);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuCliente);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuBoleta);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuProductos);
            this.panelMenuLateral.Controls.Add(this.panelSubMenuVenta);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 55);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(274, 694);
            this.panelMenuLateral.TabIndex = 2;
            // 
            // panelSubMenuCaja
            // 
            this.panelSubMenuCaja.Controls.Add(this.btnVerVentas);
            this.panelSubMenuCaja.Controls.Add(this.btnEgresos);
            this.panelSubMenuCaja.Controls.Add(this.btnAperturarCaja);
            this.panelSubMenuCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCaja.Location = new System.Drawing.Point(0, 294);
            this.panelSubMenuCaja.Name = "panelSubMenuCaja";
            this.panelSubMenuCaja.Size = new System.Drawing.Size(274, 177);
            this.panelSubMenuCaja.TabIndex = 6;
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVerVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerVentas.FlatAppearance.BorderSize = 0;
            this.btnVerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerVentas.ForeColor = System.Drawing.Color.White;
            this.btnVerVentas.Location = new System.Drawing.Point(0, 118);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVerVentas.Size = new System.Drawing.Size(274, 59);
            this.btnVerVentas.TabIndex = 5;
            this.btnVerVentas.Text = "Ver Ventas";
            this.btnVerVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerVentas.UseVisualStyleBackColor = false;
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // btnEgresos
            // 
            this.btnEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEgresos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEgresos.FlatAppearance.BorderSize = 0;
            this.btnEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgresos.ForeColor = System.Drawing.Color.White;
            this.btnEgresos.Location = new System.Drawing.Point(0, 59);
            this.btnEgresos.Name = "btnEgresos";
            this.btnEgresos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEgresos.Size = new System.Drawing.Size(274, 59);
            this.btnEgresos.TabIndex = 4;
            this.btnEgresos.Text = "Egresos";
            this.btnEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEgresos.UseVisualStyleBackColor = false;
            this.btnEgresos.Click += new System.EventHandler(this.btnEgresos_Click);
            // 
            // btnAperturarCaja
            // 
            this.btnAperturarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAperturarCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAperturarCaja.FlatAppearance.BorderSize = 0;
            this.btnAperturarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAperturarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturarCaja.ForeColor = System.Drawing.Color.White;
            this.btnAperturarCaja.Location = new System.Drawing.Point(0, 0);
            this.btnAperturarCaja.Name = "btnAperturarCaja";
            this.btnAperturarCaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAperturarCaja.Size = new System.Drawing.Size(274, 59);
            this.btnAperturarCaja.TabIndex = 3;
            this.btnAperturarCaja.Text = "Aperturar Caja";
            this.btnAperturarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAperturarCaja.UseVisualStyleBackColor = false;
            this.btnAperturarCaja.Click += new System.EventHandler(this.btnAperturarCaja_Click);
            // 
            // panelSubMenuCliente
            // 
            this.panelSubMenuCliente.Controls.Add(this.btnEdiatCliente);
            this.panelSubMenuCliente.Controls.Add(this.btnAgregarCliente);
            this.panelSubMenuCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuCliente.Location = new System.Drawing.Point(0, 176);
            this.panelSubMenuCliente.Name = "panelSubMenuCliente";
            this.panelSubMenuCliente.Size = new System.Drawing.Size(274, 118);
            this.panelSubMenuCliente.TabIndex = 5;
            // 
            // btnEdiatCliente
            // 
            this.btnEdiatCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdiatCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdiatCliente.FlatAppearance.BorderSize = 0;
            this.btnEdiatCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdiatCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdiatCliente.ForeColor = System.Drawing.Color.White;
            this.btnEdiatCliente.Location = new System.Drawing.Point(0, 59);
            this.btnEdiatCliente.Name = "btnEdiatCliente";
            this.btnEdiatCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnEdiatCliente.Size = new System.Drawing.Size(274, 59);
            this.btnEdiatCliente.TabIndex = 5;
            this.btnEdiatCliente.Text = "Editar Clientes";
            this.btnEdiatCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdiatCliente.UseVisualStyleBackColor = false;
            this.btnEdiatCliente.Click += new System.EventHandler(this.btnEdiatCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregarCliente.Size = new System.Drawing.Size(274, 59);
            this.btnAgregarCliente.TabIndex = 4;
            this.btnAgregarCliente.Text = "Agregar Clientes";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCliente.UseVisualStyleBackColor = false;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // panelSubMenuBoleta
            // 
            this.panelSubMenuBoleta.Controls.Add(this.btnBuscarBoleta);
            this.panelSubMenuBoleta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuBoleta.Location = new System.Drawing.Point(0, 117);
            this.panelSubMenuBoleta.Name = "panelSubMenuBoleta";
            this.panelSubMenuBoleta.Size = new System.Drawing.Size(274, 59);
            this.panelSubMenuBoleta.TabIndex = 4;
            // 
            // btnBuscarBoleta
            // 
            this.btnBuscarBoleta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarBoleta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarBoleta.FlatAppearance.BorderSize = 0;
            this.btnBuscarBoleta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarBoleta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBoleta.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBoleta.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarBoleta.Name = "btnBuscarBoleta";
            this.btnBuscarBoleta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarBoleta.Size = new System.Drawing.Size(274, 59);
            this.btnBuscarBoleta.TabIndex = 1;
            this.btnBuscarBoleta.Text = "Buscar Boletas";
            this.btnBuscarBoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarBoleta.UseVisualStyleBackColor = false;
            this.btnBuscarBoleta.Click += new System.EventHandler(this.btnBuscarBoleta_Click);
            // 
            // panelSubMenuProductos
            // 
            this.panelSubMenuProductos.Controls.Add(this.btnBuscarProducto);
            this.panelSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuProductos.Location = new System.Drawing.Point(0, 58);
            this.panelSubMenuProductos.Name = "panelSubMenuProductos";
            this.panelSubMenuProductos.Size = new System.Drawing.Size(274, 59);
            this.panelSubMenuProductos.TabIndex = 2;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBuscarProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(0, 0);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBuscarProducto.Size = new System.Drawing.Size(274, 59);
            this.btnBuscarProducto.TabIndex = 8;
            this.btnBuscarProducto.Text = "Buscar Producto";
            this.btnBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // panelSubMenuVenta
            // 
            this.panelSubMenuVenta.Controls.Add(this.btnNuevaVenta);
            this.panelSubMenuVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuVenta.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenuVenta.Name = "panelSubMenuVenta";
            this.panelSubMenuVenta.Size = new System.Drawing.Size(274, 58);
            this.panelSubMenuVenta.TabIndex = 1;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevaVenta.FlatAppearance.BorderSize = 0;
            this.btnNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaVenta.ForeColor = System.Drawing.Color.White;
            this.btnNuevaVenta.Location = new System.Drawing.Point(0, 0);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNuevaVenta.Size = new System.Drawing.Size(274, 59);
            this.btnNuevaVenta.TabIndex = 2;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaVenta.UseVisualStyleBackColor = false;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(274, 55);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(733, 694);
            this.panelContenedor.TabIndex = 3;
            // 
            // FrmInicioUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 749);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenuLateral);
            this.Controls.Add(this.panel1);
            this.Name = "FrmInicioUsuario";
            this.Text = "FrmInicioUsuario";
            this.panel1.ResumeLayout(false);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelSubMenuCaja.ResumeLayout(false);
            this.panelSubMenuCliente.ResumeLayout(false);
            this.panelSubMenuBoleta.ResumeLayout(false);
            this.panelSubMenuProductos.ResumeLayout(false);
            this.panelSubMenuVenta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnBoleta;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelSubMenuCaja;
        private System.Windows.Forms.Button btnVerVentas;
        private System.Windows.Forms.Button btnEgresos;
        private System.Windows.Forms.Button btnAperturarCaja;
        private System.Windows.Forms.Panel panelSubMenuCliente;
        private System.Windows.Forms.Button btnEdiatCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Panel panelSubMenuBoleta;
        private System.Windows.Forms.Button btnBuscarBoleta;
        private System.Windows.Forms.Panel panelSubMenuProductos;
        private System.Windows.Forms.Panel panelSubMenuVenta;
        private System.Windows.Forms.Button btnNuevaVenta;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}