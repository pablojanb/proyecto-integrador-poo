namespace clubdeportivo.igu.carnets
{
    partial class CarnetPopUp
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
            cmbDni = new ComboBox();
            txtDni = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // cmbDni
            // 
            cmbDni.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDni.FormattingEnabled = true;
            cmbDni.ImeMode = ImeMode.NoControl;
            cmbDni.Items.AddRange(new object[] { "DNI", "N° de socio" });
            cmbDni.Location = new Point(58, 104);
            cmbDni.Name = "cmbDni";
            cmbDni.Size = new Size(362, 28);
            cmbDni.TabIndex = 18;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(58, 158);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(362, 27);
            txtDni.TabIndex = 16;
            txtDni.Text = "Ingrese número";
            txtDni.Click += txtDni_Click;
            txtDni.TextChanged += txtDni_TextChanged;
            txtDni.Leave += txtDni_Leave;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(256, 212);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 41);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(58, 212);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Buscar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(131, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 46);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Entrega carnet";
            // 
            // CarnetPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 304);
            Controls.Add(cmbDni);
            Controls.Add(txtDni);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "CarnetPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carnets";
            Load += CarnetPopUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDni;
        private TextBox txtDni;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTitle;
    }
}