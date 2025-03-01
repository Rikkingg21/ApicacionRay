namespace ApicacionRay.FrmAdmin
{
    partial class AdminAgregarEmpresa
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
            this.btnGuardarAgregarEmpresa = new System.Windows.Forms.Button();
            this.textcorreo = new System.Windows.Forms.TextBox();
            this.textnumero = new System.Windows.Forms.TextBox();
            this.textdireccion = new System.Windows.Forms.TextBox();
            this.textnomemp = new System.Windows.Forms.TextBox();
            this.textruc = new System.Windows.Forms.TextBox();
            this.labelcorreo = new System.Windows.Forms.Label();
            this.labelnumero = new System.Windows.Forms.Label();
            this.labeldireccion = new System.Windows.Forms.Label();
            this.labelnomemp = new System.Windows.Forms.Label();
            this.labelruc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxLogoEmp = new System.Windows.Forms.PictureBox();
            this.btnImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardarAgregarEmpresa
            // 
            this.btnGuardarAgregarEmpresa.BackColor = System.Drawing.Color.Lime;
            this.btnGuardarAgregarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnGuardarAgregarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAgregarEmpresa.Location = new System.Drawing.Point(256, 381);
            this.btnGuardarAgregarEmpresa.Name = "btnGuardarAgregarEmpresa";
            this.btnGuardarAgregarEmpresa.Size = new System.Drawing.Size(207, 46);
            this.btnGuardarAgregarEmpresa.TabIndex = 23;
            this.btnGuardarAgregarEmpresa.Text = "Guardar";
            this.btnGuardarAgregarEmpresa.UseVisualStyleBackColor = false;
            this.btnGuardarAgregarEmpresa.Click += new System.EventHandler(this.btnGuardarAgregarEmpresa_Click);
            // 
            // textcorreo
            // 
            this.textcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcorreo.Location = new System.Drawing.Point(379, 182);
            this.textcorreo.Name = "textcorreo";
            this.textcorreo.Size = new System.Drawing.Size(222, 31);
            this.textcorreo.TabIndex = 22;
            // 
            // textnumero
            // 
            this.textnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnumero.Location = new System.Drawing.Point(379, 145);
            this.textnumero.MaxLength = 9;
            this.textnumero.Name = "textnumero";
            this.textnumero.Size = new System.Drawing.Size(222, 31);
            this.textnumero.TabIndex = 21;
            this.textnumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnumero_KeyPress);
            // 
            // textdireccion
            // 
            this.textdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textdireccion.Location = new System.Drawing.Point(379, 108);
            this.textdireccion.Name = "textdireccion";
            this.textdireccion.Size = new System.Drawing.Size(222, 31);
            this.textdireccion.TabIndex = 20;
            this.textdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textdireccion_KeyPress);
            // 
            // textnomemp
            // 
            this.textnomemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textnomemp.Location = new System.Drawing.Point(379, 71);
            this.textnomemp.Name = "textnomemp";
            this.textnomemp.Size = new System.Drawing.Size(222, 31);
            this.textnomemp.TabIndex = 19;
            this.textnomemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textnomemp_KeyPress);
            // 
            // textruc
            // 
            this.textruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textruc.Location = new System.Drawing.Point(379, 34);
            this.textruc.MaxLength = 11;
            this.textruc.Name = "textruc";
            this.textruc.Size = new System.Drawing.Size(222, 31);
            this.textruc.TabIndex = 18;
            this.textruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textruc_KeyPress);
            // 
            // labelcorreo
            // 
            this.labelcorreo.AutoSize = true;
            this.labelcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcorreo.Location = new System.Drawing.Point(110, 188);
            this.labelcorreo.Name = "labelcorreo";
            this.labelcorreo.Size = new System.Drawing.Size(190, 25);
            this.labelcorreo.TabIndex = 17;
            this.labelcorreo.Text = "Correo Electrónico";
            // 
            // labelnumero
            // 
            this.labelnumero.AutoSize = true;
            this.labelnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumero.Location = new System.Drawing.Point(110, 151);
            this.labelnumero.Name = "labelnumero";
            this.labelnumero.Size = new System.Drawing.Size(231, 25);
            this.labelnumero.TabIndex = 16;
            this.labelnumero.Text = "Número de la Empresa";
            // 
            // labeldireccion
            // 
            this.labeldireccion.AutoSize = true;
            this.labeldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldireccion.Location = new System.Drawing.Point(110, 114);
            this.labeldireccion.Name = "labeldireccion";
            this.labeldireccion.Size = new System.Drawing.Size(246, 25);
            this.labeldireccion.TabIndex = 15;
            this.labeldireccion.Text = "Direccion de la Empresa";
            // 
            // labelnomemp
            // 
            this.labelnomemp.AutoSize = true;
            this.labelnomemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnomemp.Location = new System.Drawing.Point(110, 77);
            this.labelnomemp.Name = "labelnomemp";
            this.labelnomemp.Size = new System.Drawing.Size(231, 25);
            this.labelnomemp.TabIndex = 14;
            this.labelnomemp.Text = "Nombre de la Empresa";
            // 
            // labelruc
            // 
            this.labelruc.AutoSize = true;
            this.labelruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelruc.Location = new System.Drawing.Point(110, 40);
            this.labelruc.Name = "labelruc";
            this.labelruc.Size = new System.Drawing.Size(204, 25);
            this.labelruc.TabIndex = 13;
            this.labelruc.Text = "Razon Social (RUC)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "DATOS DE LA EMPRESA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Logo (Opcional)";
            // 
            // pictureBoxLogoEmp
            // 
            this.pictureBoxLogoEmp.Location = new System.Drawing.Point(379, 219);
            this.pictureBoxLogoEmp.Name = "pictureBoxLogoEmp";
            this.pictureBoxLogoEmp.Size = new System.Drawing.Size(222, 143);
            this.pictureBoxLogoEmp.TabIndex = 25;
            this.pictureBoxLogoEmp.TabStop = false;
            // 
            // btnImagen
            // 
            this.btnImagen.FlatAppearance.BorderSize = 0;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.Location = new System.Drawing.Point(115, 281);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(190, 39);
            this.btnImagen.TabIndex = 26;
            this.btnImagen.Text = "Seleccionar Foto";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // AdminAgregarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.pictureBoxLogoEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarAgregarEmpresa);
            this.Controls.Add(this.textcorreo);
            this.Controls.Add(this.textnumero);
            this.Controls.Add(this.textdireccion);
            this.Controls.Add(this.textnomemp);
            this.Controls.Add(this.textruc);
            this.Controls.Add(this.labelcorreo);
            this.Controls.Add(this.labelnumero);
            this.Controls.Add(this.labeldireccion);
            this.Controls.Add(this.labelnomemp);
            this.Controls.Add(this.labelruc);
            this.Controls.Add(this.label1);
            this.Name = "AdminAgregarEmpresa";
            this.Text = "AdminAgregarEmpresa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarAgregarEmpresa;
        private System.Windows.Forms.TextBox textcorreo;
        private System.Windows.Forms.TextBox textnumero;
        private System.Windows.Forms.TextBox textdireccion;
        private System.Windows.Forms.TextBox textnomemp;
        private System.Windows.Forms.TextBox textruc;
        private System.Windows.Forms.Label labelcorreo;
        private System.Windows.Forms.Label labelnumero;
        private System.Windows.Forms.Label labeldireccion;
        private System.Windows.Forms.Label labelnomemp;
        private System.Windows.Forms.Label labelruc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLogoEmp;
        private System.Windows.Forms.Button btnImagen;
    }
}