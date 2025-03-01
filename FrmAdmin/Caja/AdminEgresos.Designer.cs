namespace ApicacionRay.FrmAdmin.Caja
{
    partial class AdminEgresos
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
            this.txtMontoEgreso = new System.Windows.Forms.TextBox();
            this.txtMotivoEgreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardarEgreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMontoEgreso
            // 
            this.txtMontoEgreso.Location = new System.Drawing.Point(267, 82);
            this.txtMontoEgreso.Name = "txtMontoEgreso";
            this.txtMontoEgreso.Size = new System.Drawing.Size(173, 31);
            this.txtMontoEgreso.TabIndex = 0;
            this.txtMontoEgreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoEgreso_KeyPress);
            // 
            // txtMotivoEgreso
            // 
            this.txtMotivoEgreso.Location = new System.Drawing.Point(267, 169);
            this.txtMotivoEgreso.Name = "txtMotivoEgreso";
            this.txtMotivoEgreso.Size = new System.Drawing.Size(173, 31);
            this.txtMotivoEgreso.TabIndex = 1;
            this.txtMotivoEgreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMotivoEgreso_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Motivo del Gasto:";
            // 
            // btnGuardarEgreso
            // 
            this.btnGuardarEgreso.Location = new System.Drawing.Point(133, 264);
            this.btnGuardarEgreso.Name = "btnGuardarEgreso";
            this.btnGuardarEgreso.Size = new System.Drawing.Size(206, 50);
            this.btnGuardarEgreso.TabIndex = 4;
            this.btnGuardarEgreso.Text = "Guardar Egreso";
            this.btnGuardarEgreso.UseVisualStyleBackColor = true;
            this.btnGuardarEgreso.Click += new System.EventHandler(this.btnGuardarEgreso_Click);
            // 
            // AdminEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 366);
            this.Controls.Add(this.btnGuardarEgreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMotivoEgreso);
            this.Controls.Add(this.txtMontoEgreso);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AdminEgresos";
            this.Text = "AdminEgresos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMontoEgreso;
        private System.Windows.Forms.TextBox txtMotivoEgreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardarEgreso;
    }
}