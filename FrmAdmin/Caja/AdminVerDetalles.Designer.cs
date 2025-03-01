namespace ApicacionRay.FrmAdmin.Caja
{
    partial class AdminVerDetalles
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
            this.btnPDF = new System.Windows.Forms.Button();
            this.panelVerDetalles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(237, 307);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(119, 43);
            this.btnPDF.TabIndex = 1;
            this.btnPDF.Text = "Descargar PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            // 
            // panelVerDetalles
            // 
            this.panelVerDetalles.Location = new System.Drawing.Point(13, 13);
            this.panelVerDetalles.Name = "panelVerDetalles";
            this.panelVerDetalles.Size = new System.Drawing.Size(568, 288);
            this.panelVerDetalles.TabIndex = 2;
            // 
            // AdminVerDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 362);
            this.Controls.Add(this.panelVerDetalles);
            this.Controls.Add(this.btnPDF);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminVerDetalles";
            this.Text = "AdminVerDetalles";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Panel panelVerDetalles;
    }
}