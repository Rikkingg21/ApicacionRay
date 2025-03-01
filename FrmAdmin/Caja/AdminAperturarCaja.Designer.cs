namespace ApicacionRay.FrmAdmin.Caja
{
    partial class AdminAperturarCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnIniciarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa monto de Apertura:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(205, 172);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(128, 31);
            this.txtMonto.TabIndex = 1;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // btnIniciarVenta
            // 
            this.btnIniciarVenta.Location = new System.Drawing.Point(219, 222);
            this.btnIniciarVenta.Name = "btnIniciarVenta";
            this.btnIniciarVenta.Size = new System.Drawing.Size(100, 35);
            this.btnIniciarVenta.TabIndex = 2;
            this.btnIniciarVenta.Text = "Iniciar";
            this.btnIniciarVenta.UseVisualStyleBackColor = true;
            this.btnIniciarVenta.Click += new System.EventHandler(this.btnIniciarVenta_Click);
            // 
            // AdminAperturarCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 339);
            this.Controls.Add(this.btnIniciarVenta);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminAperturarCaja";
            this.Text = "AdminAperturarCaja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnIniciarVenta;
    }
}