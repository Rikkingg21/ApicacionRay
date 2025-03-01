namespace ApicacionRay.FrmAdmin.FrmEmpleados
{
    partial class AgregarEmpleados
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtPasswordUsuario = new System.Windows.Forms.TextBox();
            this.txtDNIUsuario = new System.Windows.Forms.TextBox();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRango = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "RUC de la Empresa:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nombre Usuario:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña:";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.Location = new System.Drawing.Point(386, 262);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(195, 40);
            this.btnAgregarUsuario.TabIndex = 13;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // txtPasswordUsuario
            // 
            this.txtPasswordUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPasswordUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUsuario.Location = new System.Drawing.Point(279, 121);
            this.txtPasswordUsuario.Name = "txtPasswordUsuario";
            this.txtPasswordUsuario.Size = new System.Drawing.Size(302, 31);
            this.txtPasswordUsuario.TabIndex = 12;
            // 
            // txtDNIUsuario
            // 
            this.txtDNIUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDNIUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNIUsuario.Location = new System.Drawing.Point(279, 84);
            this.txtDNIUsuario.MaxLength = 8;
            this.txtDNIUsuario.Name = "txtDNIUsuario";
            this.txtDNIUsuario.Size = new System.Drawing.Size(302, 31);
            this.txtDNIUsuario.TabIndex = 11;
            this.txtDNIUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNIUsuario_KeyPress);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsuario.Location = new System.Drawing.Point(279, 47);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(302, 31);
            this.txtNomUsuario.TabIndex = 10;
            this.txtNomUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsuario_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Rango:";
            // 
            // comboBoxRango
            // 
            this.comboBoxRango.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRango.FormattingEnabled = true;
            this.comboBoxRango.Items.AddRange(new object[] {
            "ADMIN",
            "TRABAJADOR"});
            this.comboBoxRango.Location = new System.Drawing.Point(279, 163);
            this.comboBoxRango.Name = "comboBoxRango";
            this.comboBoxRango.Size = new System.Drawing.Size(302, 33);
            this.comboBoxRango.TabIndex = 24;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(279, 202);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(302, 33);
            this.comboBoxEmpresa.TabIndex = 25;
            this.comboBoxEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEmpresa_KeyPress);
            // 
            // AgregarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 355);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.comboBoxRango);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtPasswordUsuario);
            this.Controls.Add(this.txtDNIUsuario);
            this.Controls.Add(this.txtNomUsuario);
            this.Name = "AgregarEmpleados";
            this.Text = "AgregarEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtPasswordUsuario;
        private System.Windows.Forms.TextBox txtDNIUsuario;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRango;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
    }
}