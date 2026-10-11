namespace AltaSocioPrueba
{
    partial class FormAltaSocio
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
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtApellido = new TextBox();
            label3 = new Label();
            txtDni = new TextBox();
            label4 = new Label();
            txtDirección = new TextBox();
            label5 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            btnLimpiar = new Button();
            btnVolver = new Button();
            btnCrear = new Button();
            lblTitulo = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(87, 118);
            label1.Name = "label1";
            label1.Size = new Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14F);
            txtNombre.Location = new Point(245, 115);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 39);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(87, 170);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 2;
            label2.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 14F);
            txtApellido.Location = new Point(245, 170);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(363, 39);
            txtApellido.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(87, 225);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // txtDni
            // 
            txtDni.Font = new Font("Segoe UI", 14F);
            txtDni.Location = new Point(245, 225);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(363, 39);
            txtDni.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(87, 286);
            label4.Name = "label4";
            label4.Size = new Size(119, 32);
            label4.TabIndex = 6;
            label4.Text = "Dirección:";
            // 
            // txtDirección
            // 
            txtDirección.Font = new Font("Segoe UI", 14F);
            txtDirección.Location = new Point(245, 280);
            txtDirección.Margin = new Padding(3, 4, 3, 4);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(363, 39);
            txtDirección.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(84, 337);
            label5.Name = "label5";
            label5.Size = new Size(112, 32);
            label5.TabIndex = 8;
            label5.Text = "Telefono:";
            label5.Click += label5_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 14F);
            txtTelefono.Location = new Point(245, 337);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(363, 39);
            txtTelefono.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(84, 463);
            label6.Name = "label6";
            label6.Size = new Size(245, 32);
            label6.TabIndex = 10;
            label6.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Font = new Font("Segoe UI", 14F);
            dtpFechaNacimiento.Location = new Point(380, 463);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(228, 39);
            dtpFechaNacimiento.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Black;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(657, 91);
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
            btnVolver.Location = new Point(657, 166);
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
            btnCrear.Location = new Point(657, 244);
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
            lblTitulo.Location = new Point(220, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 46);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Alta nuevo socio";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14F);
            txtEmail.Location = new Point(245, 398);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 39);
            txtEmail.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(87, 405);
            label7.Name = "label7";
            label7.Size = new Size(76, 32);
            label7.TabIndex = 23;
            label7.Text = "Email:";
            // 
            // FormAltaSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(txtEmail);
            Controls.Add(label7);
            Controls.Add(lblTitulo);
            Controls.Add(btnCrear);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(txtDirección);
            Controls.Add(label4);
            Controls.Add(txtDni);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAltaSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta socio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtApellido;
        private Label label3;
        private TextBox txtDni;
        private Label label4;
        private TextBox txtDirección;
        private Label label5;
        private TextBox txtTelefono;
        private Label label6;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnLimpiar;
        private Button btnVolver;
        private Button btnCrear;
        private Label lblTitulo;
        private TextBox txtEmail;
        private Label label7;
    }
}
