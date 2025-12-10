namespace formulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gbNacionalidad = new System.Windows.Forms.GroupBox();
            this.rdbArgentino = new System.Windows.Forms.RadioButton();
            this.rdbExtranjero = new System.Windows.Forms.RadioButton();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbNacionalidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Formulario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 119);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(44, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(63, 16);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido: ";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(44, 174);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(138, 16);
            this.lblFechaNacimiento.TabIndex = 5;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 232);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(188, 174);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 8;
            // 
            // gbNacionalidad
            // 
            this.gbNacionalidad.Controls.Add(this.rdbExtranjero);
            this.gbNacionalidad.Controls.Add(this.rdbArgentino);
            this.gbNacionalidad.Location = new System.Drawing.Point(41, 271);
            this.gbNacionalidad.Name = "gbNacionalidad";
            this.gbNacionalidad.Size = new System.Drawing.Size(299, 70);
            this.gbNacionalidad.TabIndex = 9;
            this.gbNacionalidad.TabStop = false;
            this.gbNacionalidad.Text = "Nacionalidad: ";
            // 
            // rdbArgentino
            // 
            this.rdbArgentino.AutoSize = true;
            this.rdbArgentino.Location = new System.Drawing.Point(38, 30);
            this.rdbArgentino.Name = "rdbArgentino";
            this.rdbArgentino.Size = new System.Drawing.Size(97, 20);
            this.rdbArgentino.TabIndex = 0;
            this.rdbArgentino.TabStop = true;
            this.rdbArgentino.Text = "Argentino/a";
            this.rdbArgentino.UseVisualStyleBackColor = true;
            // 
            // rdbExtranjero
            // 
            this.rdbExtranjero.AutoSize = true;
            this.rdbExtranjero.Location = new System.Drawing.Point(163, 30);
            this.rdbExtranjero.Name = "rdbExtranjero";
            this.rdbExtranjero.Size = new System.Drawing.Size(88, 20);
            this.rdbExtranjero.TabIndex = 1;
            this.rdbExtranjero.TabStop = true;
            this.rdbExtranjero.Text = "Extranjero";
            this.rdbExtranjero.UseVisualStyleBackColor = true;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(41, 374);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(94, 32);
            this.btnVerPerfil.TabIndex = 10;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.gbNacionalidad);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbNacionalidad.ResumeLayout(false);
            this.gbNacionalidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox gbNacionalidad;
        private System.Windows.Forms.RadioButton rdbExtranjero;
        private System.Windows.Forms.RadioButton rdbArgentino;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

