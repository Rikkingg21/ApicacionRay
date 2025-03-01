namespace ApicacionRay.FrmAdmin.FrmProductos
{
    partial class AdminEditarPrecioProducto
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
            this.txtNewPrecio = new System.Windows.Forms.TextBox();
            this.btnActualizarPrecio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNewPrecio
            // 
            this.txtNewPrecio.Location = new System.Drawing.Point(62, 94);
            this.txtNewPrecio.Name = "txtNewPrecio";
            this.txtNewPrecio.Size = new System.Drawing.Size(161, 31);
            this.txtNewPrecio.TabIndex = 0;
            // 
            // btnActualizarPrecio
            // 
            this.btnActualizarPrecio.Location = new System.Drawing.Point(89, 158);
            this.btnActualizarPrecio.Name = "btnActualizarPrecio";
            this.btnActualizarPrecio.Size = new System.Drawing.Size(115, 38);
            this.btnActualizarPrecio.TabIndex = 1;
            this.btnActualizarPrecio.Text = "Actualizar";
            this.btnActualizarPrecio.UseVisualStyleBackColor = true;
            this.btnActualizarPrecio.Click += new System.EventHandler(this.btnActualizarPrecio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar el nuevo Precio";
            // 
            // AdminEditarPrecioProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 227);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnActualizarPrecio);
            this.Controls.Add(this.txtNewPrecio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminEditarPrecioProducto";
            this.Text = "Editar Precio";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewPrecio;
        private System.Windows.Forms.Button btnActualizarPrecio;
        private System.Windows.Forms.Label label1;
    }
}