namespace clubdeportivo.igu.pagos
{
    partial class PagosPopUp
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
            lblTitulo = new Label();
            cmbIngreso = new ComboBox();
            txtDni = new TextBox();
            cmbMonto = new ComboBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtMonto = new TextBox();
            cmbCantCuotas = new ComboBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(83, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(270, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar nuevo pago";
            // 
            // cmbIngreso
            // 
            cmbIngreso.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIngreso.FormattingEnabled = true;
            cmbIngreso.ImeMode = ImeMode.NoControl;
            cmbIngreso.Items.AddRange(new object[] { "Número de socio", "DNI" });
            cmbIngreso.Location = new Point(29, 93);
            cmbIngreso.Name = "cmbIngreso";
            cmbIngreso.Size = new Size(362, 28);
            cmbIngreso.TabIndex = 12;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(29, 145);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 11;
            txtDni.Text = "Ingrese número";
            txtDni.Click += txtDni_Click;
            txtDni.Leave += txtDni_Leave;
            // 
            // cmbMonto
            // 
            cmbMonto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonto.FormattingEnabled = true;
            cmbMonto.ImeMode = ImeMode.NoControl;
            cmbMonto.Items.AddRange(new object[] { "Efectivo", "Tarjeta" });
            cmbMonto.Location = new Point(29, 193);
            cmbMonto.Name = "cmbMonto";
            cmbMonto.Size = new Size(362, 28);
            cmbMonto.TabIndex = 14;
            cmbMonto.SelectedIndexChanged += cmbMonto_SelectedIndexChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(216, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 41);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(33, 344);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(29, 295);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(362, 27);
            txtMonto.TabIndex = 17;
            txtMonto.Text = "Ingrese monto";
            txtMonto.Click += txtMonto_Click;
            txtMonto.Leave += txtMonto_Leave;
            // 
            // cmbCantCuotas
            // 
            cmbCantCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCantCuotas.FormattingEnabled = true;
            cmbCantCuotas.ImeMode = ImeMode.NoControl;
            cmbCantCuotas.Items.AddRange(new object[] { "3 cuotas", "6 cuotas" });
            cmbCantCuotas.Location = new Point(29, 247);
            cmbCantCuotas.Name = "cmbCantCuotas";
            cmbCantCuotas.Size = new Size(362, 28);
            cmbCantCuotas.TabIndex = 18;
            // 
            // PagosPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 430);
            Controls.Add(cmbCantCuotas);
            Controls.Add(txtMonto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(cmbMonto);
            Controls.Add(cmbIngreso);
            Controls.Add(txtDni);
            Controls.Add(lblTitulo);
            Name = "PagosPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ComboBox cmbIngreso;
        private TextBox txtDni;
        private ComboBox cmbMonto;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtMonto;
        private ComboBox cmbCantCuotas;
    }
}