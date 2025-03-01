namespace ApicacionRay.FrmAdmin.FrmEmpresa
{
    partial class AdminEliminarEmpresa
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
            this.labelcorreo = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelnomemp = new System.Windows.Forms.Label();
            this.labelruc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarEmpresa = new System.Windows.Forms.Button();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.btnBuscarRUC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelcorreo
            // 
            this.labelcorreo.AutoSize = true;
            this.labelcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreo.Location = new System.Drawing.Point(51, 246);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(196, 25);
            this.labelcorreo.TabIndex = 29;
            this.labelcorreo.Text = "Correo Electrónico:";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero.Location = new System.Drawing.Point(51, 192);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(237, 25);
            this.labelnumero.TabIndex = 28;
            this.labelnumero.Text = "Número de la Empresa:";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(51, 133);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(252, 25);
            this.labeldireccion.TabIndex = 27;
            this.labeldireccion.Text = "Direccion de la Empresa:";
            // 
            // labelnomemp
            // 
            this.labelnomemp.AutoSize = true;
            this.labelnomemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomemp.Location = new System.Drawing.Point(51, 84);
            this.labelnomemp.Name = "labelnomemp";
            this.labelnomemp.Size = new System.Drawing.Size(237, 25);
            this.labelnomemp.TabIndex = 26;
            this.labelnomemp.Text = "Nombre de la Empresa:";
            // 
            // labelruc
            // 
            this.labelruc.AutoSize = true;
            this.labelruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelruc.Location = new System.Drawing.Point(51, 33);
            this.labelruc.Name = "labelruc";
            this.labelruc.Size = new System.Drawing.Size(210, 25);
            this.labelruc.TabIndex = 25;
            this.labelruc.Text = "Razon Social (RUC):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 34;
            // 
            // btnEliminarEmpresa
            // 
            this.btnEliminarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpresa.Location = new System.Drawing.Point(232, 314);
            this.btnEliminarEmpresa.Name = "btnEliminarEmpresa";
            this.btnEliminarEmpresa.Size = new System.Drawing.Size(142, 44);
            this.btnEliminarEmpresa.TabIndex = 36;
            this.btnEliminarEmpresa.Text = "Eliminar";
            this.btnEliminarEmpresa.UseVisualStyleBackColor = true;
            this.btnEliminarEmpresa.Click += new System.EventHandler(this.btnEliminarEmpresa_Click);
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(323, 30);
            this.txtRUC.MaxLength = 11;
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(188, 31);
            this.txtRUC.TabIndex = 37;
            this.txtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRUC_KeyPress);
            // 
            // btnBuscarRUC
            // 
            this.btnBuscarRUC.FlatAppearance.BorderSize = 0;
            this.btnBuscarRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRUC.Image = global::ApicacionRay.Properties.Resources.icons8_lupa_26;
            this.btnBuscarRUC.Location = new System.Drawing.Point(528, 27);
            this.btnBuscarRUC.Name = "btnBuscarRUC";
            this.btnBuscarRUC.Size = new System.Drawing.Size(101, 37);
            this.btnBuscarRUC.TabIndex = 38;
            this.btnBuscarRUC.UseVisualStyleBackColor = true;
            this.btnBuscarRUC.Click += new System.EventHandler(this.btnBuscarRUC_Click);
            // 
            // AdminEliminarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 710);
            this.Controls.Add(this.btnBuscarRUC);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.btnEliminarEmpresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelcorreo);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnomemp);
            this.Controls.Add(this.labelruc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminEliminarEmpresa";
            this.Text = "AdminEliminarEmpresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelnomemp;
        private System.Windows.Forms.Label labelruc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarEmpresa;
        private System.Windows.Forms.TextBox txtRUC;
        private System.Windows.Forms.Button btnBuscarRUC;
    }
}