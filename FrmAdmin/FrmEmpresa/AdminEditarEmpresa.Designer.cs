namespace ApicacionRay.FrmAdmin.FrmEmpresa
{
    partial class AdminEditarEmpresa
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pictureBoxLogoEmp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.labelcorreo = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelnomemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActulizarEmpresa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxRUC = new System.Windows.Forms.ComboBox();
            this.btnBuscarRUC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "RUC:";
            // 
            // btnImagen
            // 
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(86, 322);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(190, 39);
            this.btnImagen.TabIndex = 50;
            this.btnImagen.Text = "Seleccionar Foto";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pictureBoxLogoEmp
            // 
            this.pictureBoxLogoEmp.Location = new System.Drawing.Point(355, 260);
            this.pictureBoxLogoEmp.Name = "pictureBoxLogoEmp";
            this.pictureBoxLogoEmp.Size = new System.Drawing.Size(304, 228);
            this.pictureBoxLogoEmp.TabIndex = 49;
            this.pictureBoxLogoEmp.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Logo (Opcional)";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(350, 223);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(309, 31);
            this.txtCorreo.TabIndex = 47;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(350, 186);
            this.txtNumero.MaxLength = 9;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(309, 31);
            this.txtNumero.TabIndex = 46;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(350, 149);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(309, 31);
            this.txtDireccion.TabIndex = 45;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // labelcorreo
            // 
            this.labelcorreo.AutoSize = true;
            this.labelcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreo.Location = new System.Drawing.Point(81, 229);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(190, 25);
            this.labelcorreo.TabIndex = 43;
            this.labelcorreo.Text = "Correo Electrónico";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero.Location = new System.Drawing.Point(81, 192);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(231, 25);
            this.labelnumero.TabIndex = 42;
            this.labelnumero.Text = "Número de la Empresa";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(81, 155);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(246, 25);
            this.labeldireccion.TabIndex = 41;
            this.labeldireccion.Text = "Direccion de la Empresa";
            // 
            // labelnomemp
            // 
            this.labelnomemp.AutoSize = true;
            this.labelnomemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomemp.Location = new System.Drawing.Point(81, 118);
            this.labelnomemp.Name = "labelnomemp";
            this.labelnomemp.Size = new System.Drawing.Size(231, 25);
            this.labelnomemp.TabIndex = 40;
            this.labelnomemp.Text = "Nombre de la Empresa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 51;
            this.label1.Text = "Actualizar Datos";
            // 
            // btnActulizarEmpresa
            // 
            this.btnActulizarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnActulizarEmpresa.Location = new System.Drawing.Point(251, 506);
            this.btnActulizarEmpresa.Name = "btnActulizarEmpresa";
            this.btnActulizarEmpresa.Size = new System.Drawing.Size(190, 35);
            this.btnActulizarEmpresa.TabIndex = 52;
            this.btnActulizarEmpresa.Text = "Actulizar";
            this.btnActulizarEmpresa.UseVisualStyleBackColor = true;
            this.btnActulizarEmpresa.Click += new System.EventHandler(this.btnActulizarEmpresa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 54;
            // 
            // comboBoxRUC
            // 
            this.comboBoxRUC.FormattingEnabled = true;
            this.comboBoxRUC.Location = new System.Drawing.Point(350, 70);
            this.comboBoxRUC.MaxLength = 11;
            this.comboBoxRUC.Name = "comboBoxRUC";
            this.comboBoxRUC.Size = new System.Drawing.Size(190, 33);
            this.comboBoxRUC.TabIndex = 57;
            this.comboBoxRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRUC_KeyPress);
            // 
            // btnBuscarRUC
            // 
            this.btnBuscarRUC.FlatAppearance.BorderSize = 0;
            this.btnBuscarRUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRUC.Image = global::ApicacionRay.Properties.Resources.icons8_lupa_26;
            this.btnBuscarRUC.Location = new System.Drawing.Point(558, 66);
            this.btnBuscarRUC.Name = "btnBuscarRUC";
            this.btnBuscarRUC.Size = new System.Drawing.Size(101, 37);
            this.btnBuscarRUC.TabIndex = 56;
            this.btnBuscarRUC.UseVisualStyleBackColor = true;
            this.btnBuscarRUC.Click += new System.EventHandler(this.btnBuscarRUC_Click);
            // 
            // AdminEditarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 710);
            this.Controls.Add(this.comboBoxRUC);
            this.Controls.Add(this.btnBuscarRUC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnActulizarEmpresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pictureBoxLogoEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.labelcorreo);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnomemp);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AdminEditarEmpresa";
            this.Text = "Editar Empresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pictureBoxLogoEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelnomemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActulizarEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxRUC;
        private System.Windows.Forms.Button btnBuscarRUC;
    }
}