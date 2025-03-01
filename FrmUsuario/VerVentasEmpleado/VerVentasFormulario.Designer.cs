namespace ApicacionRay.FrmUsuario.VerVentasEmpleado
{
    partial class VerVentasFormulario
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
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.DTPFin = new System.Windows.Forms.DateTimePicker();
            this.DTPInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNota7 = new System.Windows.Forms.Label();
            this.lblNota6 = new System.Windows.Forms.Label();
            this.lblMontoEnCaja = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.btnOtros = new System.Windows.Forms.Button();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblOtros = new System.Windows.Forms.Label();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.btnApertura = new System.Windows.Forms.Button();
            this.lblNota5 = new System.Windows.Forms.Label();
            this.lblEgresos = new System.Windows.Forms.Label();
            this.btnVerDetallesEgresos = new System.Windows.Forms.Button();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.btnVerDetallesVenta = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.lblCajaApertura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVdatos
            // 
            this.DGVdatos.AllowUserToAddRows = false;
            this.DGVdatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVdatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVdatos.Location = new System.Drawing.Point(0, 329);
            this.DGVdatos.Name = "DGVdatos";
            this.DGVdatos.ReadOnly = true;
            this.DGVdatos.Size = new System.Drawing.Size(992, 331);
            this.DGVdatos.TabIndex = 27;
            // 
            // DTPFin
            // 
            this.DTPFin.Location = new System.Drawing.Point(12, 62);
            this.DTPFin.Name = "DTPFin";
            this.DTPFin.Size = new System.Drawing.Size(393, 31);
            this.DTPFin.TabIndex = 26;
            this.DTPFin.ValueChanged += new System.EventHandler(this.DTPFin_ValueChanged);
            // 
            // DTPInicio
            // 
            this.DTPInicio.Location = new System.Drawing.Point(12, 15);
            this.DTPInicio.Name = "DTPInicio";
            this.DTPInicio.Size = new System.Drawing.Size(393, 31);
            this.DTPInicio.TabIndex = 25;
            this.DTPInicio.ValueChanged += new System.EventHandler(this.DTPInicio_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNota7);
            this.groupBox1.Controls.Add(this.lblNota6);
            this.groupBox1.Controls.Add(this.lblMontoEnCaja);
            this.groupBox1.Controls.Add(this.lblEfectivo);
            this.groupBox1.Controls.Add(this.lblNota4);
            this.groupBox1.Controls.Add(this.btnOtros);
            this.groupBox1.Controls.Add(this.lblNota2);
            this.groupBox1.Controls.Add(this.lblOtros);
            this.groupBox1.Controls.Add(this.lblNota1);
            this.groupBox1.Controls.Add(this.btnApertura);
            this.groupBox1.Controls.Add(this.lblNota5);
            this.groupBox1.Controls.Add(this.lblEgresos);
            this.groupBox1.Controls.Add(this.btnVerDetallesEgresos);
            this.groupBox1.Controls.Add(this.lblIngresos);
            this.groupBox1.Controls.Add(this.btnVerDetallesVenta);
            this.groupBox1.Controls.Add(this.btnEfectivo);
            this.groupBox1.Controls.Add(this.lblCajaApertura);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 329);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // lblNota7
            // 
            this.lblNota7.AutoSize = true;
            this.lblNota7.Location = new System.Drawing.Point(494, 250);
            this.lblNota7.Name = "lblNota7";
            this.lblNota7.Size = new System.Drawing.Size(158, 25);
            this.lblNota7.TabIndex = 27;
            this.lblNota7.Text = "Monto en Caja:";
            // 
            // lblNota6
            // 
            this.lblNota6.AutoSize = true;
            this.lblNota6.Location = new System.Drawing.Point(12, 177);
            this.lblNota6.Name = "lblNota6";
            this.lblNota6.Size = new System.Drawing.Size(158, 25);
            this.lblNota6.TabIndex = 26;
            this.lblNota6.Text = "Otros Ingresos:";
            // 
            // lblMontoEnCaja
            // 
            this.lblMontoEnCaja.AutoSize = true;
            this.lblMontoEnCaja.Location = new System.Drawing.Point(494, 275);
            this.lblMontoEnCaja.Name = "lblMontoEnCaja";
            this.lblMontoEnCaja.Size = new System.Drawing.Size(77, 25);
            this.lblMontoEnCaja.TabIndex = 22;
            this.lblMontoEnCaja.Text = "s/ 00.0";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Location = new System.Drawing.Point(494, 206);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(77, 25);
            this.lblEfectivo.TabIndex = 25;
            this.lblEfectivo.Text = "s/ 00.0";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(494, 109);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(276, 25);
            this.lblNota4.TabIndex = 25;
            this.lblNota4.Text = "Monto de Apertura de Caja:";
            // 
            // btnOtros
            // 
            this.btnOtros.Location = new System.Drawing.Point(328, 177);
            this.btnOtros.Name = "btnOtros";
            this.btnOtros.Size = new System.Drawing.Size(160, 50);
            this.btnOtros.TabIndex = 20;
            this.btnOtros.Text = "Ver Detalles";
            this.btnOtros.UseVisualStyleBackColor = true;
            this.btnOtros.Click += new System.EventHandler(this.btnOtros_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(494, 40);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(158, 25);
            this.lblNota2.TabIndex = 14;
            this.lblNota2.Text = "Ventas del Día:";
            // 
            // lblOtros
            // 
            this.lblOtros.AutoSize = true;
            this.lblOtros.Location = new System.Drawing.Point(12, 202);
            this.lblOtros.Name = "lblOtros";
            this.lblOtros.Size = new System.Drawing.Size(77, 25);
            this.lblOtros.TabIndex = 19;
            this.lblOtros.Text = "s/ 00.0";
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(12, 109);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(170, 25);
            this.lblNota1.TabIndex = 7;
            this.lblNota1.Text = "Egresos del Día:";
            // 
            // btnApertura
            // 
            this.btnApertura.Location = new System.Drawing.Point(820, 109);
            this.btnApertura.Name = "btnApertura";
            this.btnApertura.Size = new System.Drawing.Size(160, 50);
            this.btnApertura.TabIndex = 14;
            this.btnApertura.Text = "Ver Detalles";
            this.btnApertura.UseVisualStyleBackColor = true;
            this.btnApertura.Click += new System.EventHandler(this.btnApertura_Click);
            // 
            // lblNota5
            // 
            this.lblNota5.AutoSize = true;
            this.lblNota5.Location = new System.Drawing.Point(494, 177);
            this.lblNota5.Name = "lblNota5";
            this.lblNota5.Size = new System.Drawing.Size(213, 25);
            this.lblNota5.TabIndex = 8;
            this.lblNota5.Text = "Ingresos en Efectivo:";
            // 
            // lblEgresos
            // 
            this.lblEgresos.AutoSize = true;
            this.lblEgresos.Location = new System.Drawing.Point(12, 134);
            this.lblEgresos.Name = "lblEgresos";
            this.lblEgresos.Size = new System.Drawing.Size(77, 25);
            this.lblEgresos.TabIndex = 6;
            this.lblEgresos.Text = "s/ 00.0";
            // 
            // btnVerDetallesEgresos
            // 
            this.btnVerDetallesEgresos.Location = new System.Drawing.Point(328, 109);
            this.btnVerDetallesEgresos.Name = "btnVerDetallesEgresos";
            this.btnVerDetallesEgresos.Size = new System.Drawing.Size(160, 50);
            this.btnVerDetallesEgresos.TabIndex = 13;
            this.btnVerDetallesEgresos.Text = "Ver Detalles";
            this.btnVerDetallesEgresos.UseVisualStyleBackColor = true;
            this.btnVerDetallesEgresos.Click += new System.EventHandler(this.btnVerDetallesEgresos_Click);
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Location = new System.Drawing.Point(494, 65);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(77, 25);
            this.lblIngresos.TabIndex = 5;
            this.lblIngresos.Text = "s/ 00.0";
            // 
            // btnVerDetallesVenta
            // 
            this.btnVerDetallesVenta.Location = new System.Drawing.Point(820, 40);
            this.btnVerDetallesVenta.Name = "btnVerDetallesVenta";
            this.btnVerDetallesVenta.Size = new System.Drawing.Size(160, 53);
            this.btnVerDetallesVenta.TabIndex = 12;
            this.btnVerDetallesVenta.Text = "Ver Detalles";
            this.btnVerDetallesVenta.UseVisualStyleBackColor = true;
            this.btnVerDetallesVenta.Click += new System.EventHandler(this.btnVerDetallesVenta_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Location = new System.Drawing.Point(820, 177);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(160, 50);
            this.btnEfectivo.TabIndex = 15;
            this.btnEfectivo.Text = "Ver Detalles";
            this.btnEfectivo.UseVisualStyleBackColor = true;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // lblCajaApertura
            // 
            this.lblCajaApertura.AutoSize = true;
            this.lblCajaApertura.Location = new System.Drawing.Point(494, 134);
            this.lblCajaApertura.Name = "lblCajaApertura";
            this.lblCajaApertura.Size = new System.Drawing.Size(77, 25);
            this.lblCajaApertura.TabIndex = 7;
            this.lblCajaApertura.Text = "s/ 00.0";
            // 
            // VerVentasFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 660);
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.DTPFin);
            this.Controls.Add(this.DTPInicio);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "VerVentasFormulario";
            this.Text = "Ver Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.DateTimePicker DTPFin;
        private System.Windows.Forms.DateTimePicker DTPInicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNota7;
        private System.Windows.Forms.Label lblNota6;
        private System.Windows.Forms.Label lblMontoEnCaja;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.Button btnOtros;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblOtros;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Button btnApertura;
        private System.Windows.Forms.Label lblNota5;
        private System.Windows.Forms.Label lblEgresos;
        private System.Windows.Forms.Button btnVerDetallesEgresos;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Button btnVerDetallesVenta;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Label lblCajaApertura;
    }
}