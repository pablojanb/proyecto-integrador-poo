namespace AltaSocioPrueba
{
    partial class AltaSocio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnCrear = new Button();
            lblTitulo = new Label();
            txtEmail = new TextBox();
            chbAptoFisico = new CheckBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(190, 115);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 39);
            txtNombre.TabIndex = 1;
            txtNombre.Text = "Nombre";
            txtNombre.Click += txtNombre_Click;
            txtNombre.TextChanged += txtNombre_TextChanged;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(190, 170);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(363, 39);
            txtApellido.TabIndex = 3;
            txtApellido.Text = "Apellido";
            txtApellido.Click += txtApellido_Click;
            txtApellido.TextChanged += txtApellido_TextChanged;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14F);
            txtDni.Location = new Point(190, 225);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(363, 39);
            txtDni.TabIndex = 5;
            txtDni.Text = "DNI";
            txtDni.Click += txtDni_Click;
            txtDni.Leave += txtDni_Leave;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 14F);
            txtDireccion.Location = new Point(190, 280);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(363, 39);
            txtDireccion.TabIndex = 7;
            txtDireccion.Text = "Dirección";
            txtDireccion.Click += txtDireccion_Click;
            txtDireccion.Leave += txtDireccion_Leave;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(190, 337);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(363, 39);
            txtTelefono.TabIndex = 9;
            txtTelefono.Text = "Teléfono";
            txtTelefono.Click += txtTelefono_Click;
            txtTelefono.Leave += txtTelefono_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(190, 470);
            label6.Name = "label6";
            label6.Size = new Size(245, 32);
            label6.TabIndex = 10;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 14F);
            dtpFechaNacimiento.Location = new Point(190, 532);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(363, 39);
            dtpFechaNacimiento.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Black;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(661, 113);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(206, 41);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "Limpiar campos";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Black;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(661, 188);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 41);
            btnVolver.TabIndex = 20;
            btnVolver.Text = "Volver atrás";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.Black;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(661, 266);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(206, 41);
            btnCrear.TabIndex = 21;
            btnCrear.Text = "Crear socio";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(341, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 46);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Alta nuevo socio";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(190, 398);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 39);
            txtEmail.TabIndex = 11;
            txtEmail.Text = "Email";
            txtEmail.Click += txtEmail_Click;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // chbAptoFisico
            // 
            chbAptoFisico.AutoSize = true;
            chbAptoFisico.Font = new Font("Segoe UI", 14F);
            chbAptoFisico.Location = new Point(190, 618);
            chbAptoFisico.Name = "chbAptoFisico";
            chbAptoFisico.Size = new Size(153, 36);
            chbAptoFisico.TabIndex = 14;
            chbAptoFisico.Text = "Apto Físico";
            chbAptoFisico.UseVisualStyleBackColor = true;
            // 
            // AltaSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 713);
            Controls.Add(chbAptoFisico);
            Controls.Add(txtEmail);
            Controls.Add(lblTitulo);
            Controls.Add(btnCrear);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AltaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnCrear;
        private Label lblTitulo;
        private TextBox txtEmail;
        private CheckBox chbAptoFisico;
    }
}
