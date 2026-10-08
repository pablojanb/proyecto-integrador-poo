namespace clubdeportivo.igu
{
    partial class AltaSocioPopUp
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
            btnAceptar = new Button();
            lblTitulo = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblNumAfiliado = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(172, 311);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 21;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(56, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(442, 46);
            lblTitulo.TabIndex = 20;
            lblTitulo.Text = "Socio creado correctamente";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14F);
            lblNombre.Location = new Point(160, 94);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14F);
            lblApellido.Location = new Point(160, 139);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 32);
            lblApellido.TabIndex = 24;
            lblApellido.Text = "Apellido:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 14F);
            lblDni.Location = new Point(160, 193);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(60, 32);
            lblDni.TabIndex = 25;
            lblDni.Text = "DNI:";
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Font = new Font("Segoe UI", 14F);
            lblNumAfiliado.Location = new Point(160, 244);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(134, 32);
            lblNumAfiliado.TabIndex = 26;
            lblNumAfiliado.Text = "N° Afiliado:";
            // 
            // AltaSocioPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 382);
            Controls.Add(lblNumAfiliado);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Name = "AltaSocioPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AltaSocioPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblNumAfiliado;
    }
}