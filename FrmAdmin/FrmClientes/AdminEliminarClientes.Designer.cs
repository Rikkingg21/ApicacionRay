namespace ApicacionRay.FrmAdmin.FrmClientes
{
    partial class AdminEliminarClientes
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
            this.btnBuscarDNI = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.labelCell = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelnomemp = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarDNI
            // 
            this.btnBuscarDNI.FlatAppearance.BorderSize = 0;
            this.btnBuscarDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDNI.Image = global::ApicacionRay.Properties.Resources.icons8_lupa_26;
            this.btnBuscarDNI.Location = new System.Drawing.Point(531, 51);
            this.btnBuscarDNI.Name = "btnBuscarDNI";
            this.btnBuscarDNI.Size = new System.Drawing.Size(101, 37);
            this.btnBuscarDNI.TabIndex = 60;
            this.btnBuscarDNI.UseVisualStyleBackColor = true;
            this.btnBuscarDNI.Click += new System.EventHandler(this.btnBuscarDNI_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(326, 54);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(188, 31);
            this.txtDNI.TabIndex = 59;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.FlatAppearance.BorderSize = 0;
            this.btnEliminarCliente.Location = new System.Drawing.Point(224, 281);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(142, 44);
            this.btnEliminarCliente.TabIndex = 58;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // labelCell
            // 
            this.labelCell.AutoSize = true;
            this.labelCell.Location = new System.Drawing.Point(321, 216);
            this.labelCell.Name = "labelCell";
            this.labelCell.Size = new System.Drawing.Size(0, 25);
            this.labelCell.TabIndex = 57;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(321, 157);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(0, 25);
            this.labelApellido.TabIndex = 56;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(321, 108);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(0, 25);
            this.labelNombre.TabIndex = 55;
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero.Location = new System.Drawing.Point(54, 216);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(86, 25);
            this.labelnumero.TabIndex = 54;
            this.labelnumero.Text = "Celular:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(54, 157);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(95, 25);
            this.labeldireccion.TabIndex = 53;
            this.labeldireccion.Text = "Apellido:";
            // 
            // labelnomemp
            // 
            this.labelnomemp.AutoSize = true;
            this.labelnomemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomemp.Location = new System.Drawing.Point(54, 108);
            this.labelnomemp.Name = "labelnomemp";
            this.labelnomemp.Size = new System.Drawing.Size(93, 25);
            this.labelnomemp.TabIndex = 52;
            this.labelnomemp.Text = "Nombre:";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDNI.Location = new System.Drawing.Point(54, 57);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(53, 25);
            this.labelDNI.TabIndex = 51;
            this.labelDNI.Text = "DNI;";
            // 
            // AdminEliminarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 710);
            this.Controls.Add(this.btnBuscarDNI);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.labelCell);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnomemp);
            this.Controls.Add(this.labelDNI);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminEliminarClientes";
            this.Text = "AdminEliminarClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Label labelCell;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelnomemp;
        private System.Windows.Forms.Label labelDNI;
    }
}