namespace clubdeportivo.igu
{
    partial class IngresoNoSocio
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
            txtDni = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblTitle = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(118, 208);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 16;
            txtDni.Text = "DNI";
            txtDni.Click += txtDni_Click;
            txtDni.Leave += txtDni_Leave;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(304, 394);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(121, 394);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(65, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 46);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Nuevo registro Ingreso/Egreso";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(118, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(362, 27);
            txtNombre.TabIndex = 19;
            txtNombre.Text = "Nombre";
            txtNombre.Click += txtNombre_Click;
            txtNombre.TextChanged += textBox1_TextChanged;
            txtNombre.Leave += textBox1_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(118, 160);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(362, 27);
            txtApellido.TabIndex = 20;
            txtApellido.Text = "Apellido";
            txtApellido.Click += txtApellido_Click;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(118, 252);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(362, 27);
            txtDireccion.TabIndex = 21;
            txtDireccion.Text = "Dirección";
            txtDireccion.Click += txtDireccion_Click;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(118, 299);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(362, 27);
            txtTelefono.TabIndex = 22;
            txtTelefono.Text = "Teléfono";
            txtTelefono.Click += txtTelefono_Click;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(118, 344);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(362, 27);
            txtEmail.TabIndex = 23;
            txtEmail.Text = "Email";
            txtEmail.Click += txtEmail_Click;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // IngresoNoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 470);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "IngresoNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresoNoSocio";
            Load += IngresoNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtDni;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTitle;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
    }
}