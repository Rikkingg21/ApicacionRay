namespace ApicacionRay.FrmAdmin
{
    partial class AdminNuevaVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSumarVenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.GANANCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioButtonYape = new System.Windows.Forms.RadioButton();
            this.radioButtonPlin = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.radioButtonTransferencia = new System.Windows.Forms.RadioButton();
            this.radioButtonTarjeta = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSumaPrecio = new System.Windows.Forms.Label();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.cboxComprobante = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblIDcomprobante = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblRUC = new System.Windows.Forms.Label();
            this.lblIDcomprobanteMasUno = new System.Windows.Forms.Label();
            this.pictureBoxLogoEmp = new System.Windows.Forms.PictureBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSumarVenta
            // 
            this.btnSumarVenta.FlatAppearance.BorderSize = 0;
            this.btnSumarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumarVenta.Location = new System.Drawing.Point(320, 52);
            this.btnSumarVenta.Name = "btnSumarVenta";
            this.btnSumarVenta.Size = new System.Drawing.Size(101, 31);
            this.btnSumarVenta.TabIndex = 20;
            this.btnSumarVenta.Text = "+";
            this.btnSumarVenta.UseVisualStyleBackColor = true;
            this.btnSumarVenta.Click += new System.EventHandler(this.btnSumarVenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingresa Codigo";
            // 
            // txtCodID
            // 
            this.txtCodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodID.Location = new System.Drawing.Point(12, 52);
            this.txtCodID.MaxLength = 10;
            this.txtCodID.Name = "txtCodID";
            this.txtCodID.Size = new System.Drawing.Size(302, 31);
            this.txtCodID.TabIndex = 18;
            this.txtCodID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodID_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.PRODUCTO,
            this.PRECIO,
            this.EDITAR,
            this.ELIMINAR,
            this.GANANCIA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 316);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(691, 238);
            this.dataGridView1.TabIndex = 17;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            this.PRODUCTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PRECIO
            // 
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.ReadOnly = true;
            this.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EDITAR
            // 
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::ApicacionRay.Properties.Resources.editar_25x25;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::ApicacionRay.Properties.Resources.eliminar_25x25;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // GANANCIA
            // 
            this.GANANCIA.HeaderText = "GANANCIA";
            this.GANANCIA.Name = "GANANCIA";
            this.GANANCIA.ReadOnly = true;
            this.GANANCIA.Visible = false;
            // 
            // radioButtonYape
            // 
            this.radioButtonYape.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonYape.AutoSize = true;
            this.radioButtonYape.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonYape.Location = new System.Drawing.Point(20, 560);
            this.radioButtonYape.Name = "radioButtonYape";
            this.radioButtonYape.Size = new System.Drawing.Size(81, 29);
            this.radioButtonYape.TabIndex = 22;
            this.radioButtonYape.TabStop = true;
            this.radioButtonYape.Text = "Yape";
            this.radioButtonYape.UseVisualStyleBackColor = true;
            this.radioButtonYape.CheckedChanged += new System.EventHandler(this.radioButtonYape_CheckedChanged);
            // 
            // radioButtonPlin
            // 
            this.radioButtonPlin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonPlin.AutoSize = true;
            this.radioButtonPlin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPlin.Location = new System.Drawing.Point(20, 595);
            this.radioButtonPlin.Name = "radioButtonPlin";
            this.radioButtonPlin.Size = new System.Drawing.Size(66, 29);
            this.radioButtonPlin.TabIndex = 23;
            this.radioButtonPlin.TabStop = true;
            this.radioButtonPlin.Text = "Plin";
            this.radioButtonPlin.UseVisualStyleBackColor = true;
            this.radioButtonPlin.CheckedChanged += new System.EventHandler(this.radioButtonPlin_CheckedChanged);
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEfectivo.Location = new System.Drawing.Point(137, 560);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(107, 29);
            this.radioButtonEfectivo.TabIndex = 24;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            this.radioButtonEfectivo.CheckedChanged += new System.EventHandler(this.radioButtonEfectivo_CheckedChanged);
            // 
            // radioButtonTransferencia
            // 
            this.radioButtonTransferencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonTransferencia.AutoSize = true;
            this.radioButtonTransferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTransferencia.Location = new System.Drawing.Point(20, 630);
            this.radioButtonTransferencia.Name = "radioButtonTransferencia";
            this.radioButtonTransferencia.Size = new System.Drawing.Size(162, 29);
            this.radioButtonTransferencia.TabIndex = 25;
            this.radioButtonTransferencia.TabStop = true;
            this.radioButtonTransferencia.Text = "Transferencia";
            this.radioButtonTransferencia.UseVisualStyleBackColor = true;
            this.radioButtonTransferencia.CheckedChanged += new System.EventHandler(this.radioButtonTransferencia_CheckedChanged);
            // 
            // radioButtonTarjeta
            // 
            this.radioButtonTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.radioButtonTarjeta.AutoSize = true;
            this.radioButtonTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonTarjeta.Location = new System.Drawing.Point(137, 595);
            this.radioButtonTarjeta.Name = "radioButtonTarjeta";
            this.radioButtonTarjeta.Size = new System.Drawing.Size(97, 29);
            this.radioButtonTarjeta.TabIndex = 26;
            this.radioButtonTarjeta.TabStop = true;
            this.radioButtonTarjeta.Text = "Tarjeta";
            this.radioButtonTarjeta.UseVisualStyleBackColor = true;
            this.radioButtonTarjeta.CheckedChanged += new System.EventHandler(this.radioButtonTarjeta_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total:";
            // 
            // lblSumaPrecio
            // 
            this.lblSumaPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSumaPrecio.AutoSize = true;
            this.lblSumaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumaPrecio.Location = new System.Drawing.Point(587, 625);
            this.lblSumaPrecio.Name = "lblSumaPrecio";
            this.lblSumaPrecio.Size = new System.Drawing.Size(71, 25);
            this.lblSumaPrecio.TabIndex = 28;
            this.lblSumaPrecio.Text = "00.00";
            // 
            // btnRecibo
            // 
            this.btnRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibo.FlatAppearance.BorderSize = 0;
            this.btnRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibo.Location = new System.Drawing.Point(500, 653);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(197, 46);
            this.btnRecibo.TabIndex = 29;
            this.btnRecibo.Text = "Generar Venta";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Ingresa DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nombre:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(111, 145);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(79, 25);
            this.lblCliente.TabIndex = 32;
            this.lblCliente.Text = "Cliente";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.Location = new System.Drawing.Point(146, 99);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(168, 31);
            this.txtDNI.TabIndex = 34;
            this.txtDNI.Text = "00000000";
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.Location = new System.Drawing.Point(520, 134);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(172, 36);
            this.btnAddCliente.TabIndex = 35;
            this.btnAddCliente.Text = "Agregar Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 223);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(120, 25);
            this.lblFecha.TabIndex = 36;
            this.lblFecha.Text = "00/00/0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Cajero:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(401, 223);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(87, 25);
            this.lblUsuario.TabIndex = 38;
            this.lblUsuario.Text = "Nombre";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "EDITAR";
            this.dataGridViewImageColumn1.Image = global::ApicacionRay.Properties.Resources.editar_25x25;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 128;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = global::ApicacionRay.Properties.Resources.eliminar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 127;
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.FlatAppearance.BorderSize = 0;
            this.btnBuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.Image = global::ApicacionRay.Properties.Resources.icons8_lupa_26;
            this.btnBuscarDNI.Location = new System.Drawing.Point(320, 96);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(101, 37);
            this.btnBuscarDNI.TabIndex = 33;
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // cboxComprobante
            // 
            this.cboxComprobante.AllowDrop = true;
            this.cboxComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxComprobante.FormattingEnabled = true;
            this.cboxComprobante.Items.AddRange(new object[] {
            "BOLETA",
            "FACTURA",
            "NOTA DE PEDIDO"});
            this.cboxComprobante.Location = new System.Drawing.Point(238, 260);
            this.cboxComprobante.Name = "cboxComprobante";
            this.cboxComprobante.Size = new System.Drawing.Size(250, 33);
            this.cboxComprobante.TabIndex = 39;
            this.cboxComprobante.SelectedIndexChanged += new System.EventHandler(this.cboxComprobante_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tipo de Comprobante:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(471, 564);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Sub Total:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(447, 589);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "I.G.V. (18%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(592, 562);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(66, 25);
            this.lblSubTotal.TabIndex = 43;
            this.lblSubTotal.Text = "00.00";
            // 
            // lblIGV
            // 
            this.lblIGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIGV.AutoSize = true;
            this.lblIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIGV.Location = new System.Drawing.Point(592, 589);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(66, 25);
            this.lblIGV.TabIndex = 44;
            this.lblIGV.Text = "00.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(494, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "N°";
            // 
            // lblIDcomprobante
            // 
            this.lblIDcomprobante.AutoSize = true;
            this.lblIDcomprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDcomprobante.Location = new System.Drawing.Point(332, 263);
            this.lblIDcomprobante.Name = "lblIDcomprobante";
            this.lblIDcomprobante.Size = new System.Drawing.Size(144, 25);
            this.lblIDcomprobante.TabIndex = 46;
            this.lblIDcomprobante.Text = "00000000000";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(495, 16);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(97, 25);
            this.lblEmpresa.TabIndex = 47;
            this.lblEmpresa.Text = "Empresa";
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRUC.Location = new System.Drawing.Point(530, 52);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(144, 25);
            this.lblRUC.TabIndex = 48;
            this.lblRUC.Text = "00000000000";
            // 
            // lblIDcomprobanteMasUno
            // 
            this.lblIDcomprobanteMasUno.AutoSize = true;
            this.lblIDcomprobanteMasUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDcomprobanteMasUno.Location = new System.Drawing.Point(584, 268);
            this.lblIDcomprobanteMasUno.Name = "lblIDcomprobanteMasUno";
            this.lblIDcomprobanteMasUno.Size = new System.Drawing.Size(108, 25);
            this.lblIDcomprobanteMasUno.TabIndex = 51;
            this.lblIDcomprobanteMasUno.Text = "00000000";
            // 
            // pictureBoxLogoEmp
            // 
            this.pictureBoxLogoEmp.Location = new System.Drawing.Point(574, 176);
            this.pictureBoxLogoEmp.Name = "pictureBoxLogoEmp";
            this.pictureBoxLogoEmp.Size = new System.Drawing.Size(100, 83);
            this.pictureBoxLogoEmp.TabIndex = 52;
            this.pictureBoxLogoEmp.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(17, 64);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(13, 13);
            this.lblCorreo.TabIndex = 53;
            this.lblCorreo.Tag = "";
            this.lblCorreo.Text = "..";
            // 
            // AdminNuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 711);
            this.Controls.Add(this.pictureBoxLogoEmp);
            this.Controls.Add(this.lblIDcomprobanteMasUno);
            this.Controls.Add(this.lblRUC);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboxComprobante);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRecibo);
            this.Controls.Add(this.lblSumaPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButtonTarjeta);
            this.Controls.Add(this.radioButtonTransferencia);
            this.Controls.Add(this.radioButtonEfectivo);
            this.Controls.Add(this.radioButtonPlin);
            this.Controls.Add(this.radioButtonYape);
            this.Controls.Add(this.btnSumarVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblIDcomprobante);
            this.Controls.Add(this.lblCorreo);
            this.Name = "AdminNuevaVenta";
            this.Text = "AdminNuevaVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSumarVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonYape;
        private System.Windows.Forms.RadioButton radioButtonPlin;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.RadioButton radioButtonTransferencia;
        private System.Windows.Forms.RadioButton radioButtonTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSumaPrecio;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ComboBox cboxComprobante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GANANCIA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDcomprobante;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblRUC;
        private System.Windows.Forms.Label lblIDcomprobanteMasUno;
        private System.Windows.Forms.PictureBox pictureBoxLogoEmp;
        private System.Windows.Forms.Label lblCorreo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}