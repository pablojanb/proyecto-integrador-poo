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
            btnPrimerIngreo = new Button();
            txtDni = new TextBox();
            cmbIngreso = new ComboBox();
            cmbDni = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(213, 287);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 41);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(30, 287);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 6;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(64, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(478, 46);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Nuevo registro Ingreso/Egreso";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnPrimerIngreo
            // 
            btnPrimerIngreo.BackColor = Color.Black;
            btnPrimerIngreo.ForeColor = Color.White;
            btnPrimerIngreo.Location = new Point(394, 287);
            btnPrimerIngreo.Name = "btnPrimerIngreo";
            btnPrimerIngreo.Size = new Size(164, 41);
            btnPrimerIngreo.TabIndex = 8;
            btnPrimerIngreo.Text = "Primer ingreso";
            btnPrimerIngreo.UseVisualStyleBackColor = false;
            btnPrimerIngreo.Click += btnNoSocio_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(117, 227);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 9;
            txtDni.Text = "Ingrese número";
            txtDni.MouseClick += txtDni_MouseClick;
            txtDni.TextChanged += textBox1_TextChanged;
            txtDni.Leave += txtDni_Leave;
            // 
            // cmbIngreso
            // 
            cmbIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngreso.FormattingEnabled = true;
            cmbIngreso.ImeMode = ImeMode.NoControl;
            cmbIngreso.Items.AddRange(new object[] { "Ingreso", "Egreso" });
            cmbIngreso.Location = new Point(117, 119);
            cmbIngreso.Name = "cmbIngreso";
            cmbIngreso.Size = new Size(362, 28);
            cmbIngreso.TabIndex = 10;
            cmbIngreso.SelectedIndexChanged += cmbIngreso_SelectedIndexChanged;
            // 
            // cmbDni
            // 
            cmbDni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDni.FormattingEnabled = true;
            cmbDni.ImeMode = ImeMode.NoControl;
            cmbDni.Items.AddRange(new object[] { "DNI", "N° de socio" });
            cmbDni.Location = new Point(117, 173);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(362, 28);
            cmbDni.TabIndex = 11;
            // 
            // IngresoSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 367);
            Controls.Add(cmbDni);
            Controls.Add(cmbIngreso);
            Controls.Add(txtDni);
            Controls.Add(btnPrimerIngreo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "IngresoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IngresoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTitle;
        private Button btnPrimerIngreo;
        private TextBox txtDni;
        private ComboBox cmbIngreso;
        private ComboBox cmbDni;
    }
}