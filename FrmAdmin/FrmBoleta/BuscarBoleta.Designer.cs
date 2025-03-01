namespace ApicacionRay.FrmAdmin.FrmBoleta
{
    partial class BuscarBoleta
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.comboComprobante = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.DGVDetalles = new System.Windows.Forms.DataGridView();
            this.VER = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCodigo.Location = new System.Drawing.Point(12, 46);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(226, 31);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Enter += new System.EventHandler(this.txtCodigo_Enter);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // comboComprobante
            // 
            this.comboComprobante.FormattingEnabled = true;
            this.comboComprobante.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "NOTA DE PEDIDO"});
            this.comboComprobante.Location = new System.Drawing.Point(244, 46);
            this.comboComprobante.Name = "comboComprobante";
            this.comboComprobante.Size = new System.Drawing.Size(180, 33);
            this.comboComprobante.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::ApicacionRay.Properties.Resources.icons8_lupa_26;
            this.btnBuscar.Location = new System.Drawing.Point(680, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 38);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Image = global::ApicacionRay.Properties.Resources.compartimiento;
            this.txtEliminar.Location = new System.Drawing.Point(783, 48);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(75, 38);
            this.txtEliminar.TabIndex = 3;
            this.txtEliminar.UseVisualStyleBackColor = true;
            this.txtEliminar.Click += new System.EventHandler(this.txtEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDNI);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtEliminar);
            this.groupBox1.Controls.Add(this.comboComprobante);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1370, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtDNI
            // 
            this.txtDNI.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtDNI.Location = new System.Drawing.Point(445, 48);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(195, 31);
            this.txtDNI.TabIndex = 4;
            this.txtDNI.Tag = "";
            this.txtDNI.Enter += new System.EventHandler(this.txtDNI_Enter);
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VER});
            this.DGV.Dock = System.Windows.Forms.DockStyle.Left;
            this.DGV.Location = new System.Drawing.Point(0, 100);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Size = new System.Drawing.Size(640, 649);
            this.DGV.TabIndex = 18;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            // 
            // DGVDetalles
            // 
            this.DGVDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DGVDetalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDetalles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDetalles.Location = new System.Drawing.Point(640, 100);
            this.DGVDetalles.Name = "DGVDetalles";
            this.DGVDetalles.Size = new System.Drawing.Size(730, 649);
            this.DGVDetalles.TabIndex = 19;
            // 
            // VER
            // 
            this.VER.HeaderText = "VER";
            this.VER.Image = global::ApicacionRay.Properties.Resources.ver;
            this.VER.Name = "VER";
            this.VER.ReadOnly = true;
            this.VER.Width = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "N° Comprobante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI:";
            // 
            // BuscarBoleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.DGVDetalles);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BuscarBoleta";
            this.Text = "BuscarBoleta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox comboComprobante;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button txtEliminar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.DataGridView DGVDetalles;
        private System.Windows.Forms.DataGridViewImageColumn VER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}