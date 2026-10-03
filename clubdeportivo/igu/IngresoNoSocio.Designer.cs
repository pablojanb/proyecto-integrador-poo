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
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(242, 268);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 16;
            txtDni.Text = "DNI";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(437, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(190, 348);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(198, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 46);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Nuevo registro Ingreso/Egreso";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(242, 212);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(362, 27);
            txtApellido.TabIndex = 17;
            txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(242, 161);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(362, 27);
            txtNombre.TabIndex = 18;
            txtNombre.Text = "Nombre";
            // 
            // IngresoNoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtDni);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "IngresoNoSocio";
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
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}