namespace clubdeportivo.igu
{
    partial class IngresoSocio
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblTitle = new Label();
            btnNoSocio = new Button();
            txtDni = new TextBox();
            cmbIngreso = new ComboBox();
            cmbDni = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(295, 346);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(48, 346);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(191, 56);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 46);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Nuevo registro Ingreso/Egreso";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnNoSocio
            // 
            btnNoSocio.BackColor = Color.Black;
            btnNoSocio.ForeColor = Color.White;
            btnNoSocio.Location = new Point(533, 346);
            btnNoSocio.Name = "btnNoSocio";
            btnNoSocio.Size = new Size(206, 41);
            btnNoSocio.TabIndex = 8;
            btnNoSocio.Text = "No Socio";
            btnNoSocio.UseVisualStyleBackColor = false;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(235, 264);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 9;
            txtDni.Text = "Ingrese número";
            txtDni.TextChanged += textBox1_TextChanged;
            // 
            // cmbIngreso
            // 
            cmbIngreso.FormattingEnabled = true;
            cmbIngreso.ImeMode = ImeMode.NoControl;
            cmbIngreso.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cmbIngreso.Location = new Point(235, 156);
            cmbIngreso.Name = "cmbIngreso";
            cmbIngreso.Size = new Size(362, 28);
            cmbIngreso.TabIndex = 10;
            // 
            // cmbDni
            // 
            cmbDni.FormattingEnabled = true;
            cmbDni.ImeMode = ImeMode.NoControl;
            cmbDni.Items.AddRange(new object[] { "DNI", "N° de socio" });
            cmbDni.Location = new Point(235, 210);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(362, 28);
            cmbDni.TabIndex = 11;
            // 
            // IngresoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbDni);
            Controls.Add(cmbIngreso);
            Controls.Add(txtDni);
            Controls.Add(btnNoSocio);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "IngresoSocio";
            Text = "IngresoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTitle;
        private Button btnNoSocio;
        private TextBox txtDni;
        private ComboBox cmbIngreso;
        private ComboBox cmbDni;
    }
}