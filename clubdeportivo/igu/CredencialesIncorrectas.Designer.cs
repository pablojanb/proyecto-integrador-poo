namespace clubdeportivo.igu
{
    partial class CredencialesIncorrectas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredencialesIncorrectas));
            lblConfirmacion = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI", 12F);
            lblConfirmacion.Location = new Point(37, 58);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(493, 28);
            lblConfirmacion.TabIndex = 19;
            lblConfirmacion.Text = "Credenciales incorrectas, por favor, intente nuevamente";
            lblConfirmacion.Click += lblConfirmacion_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(167, 136);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CredencialesIncorrectas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 272);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnAceptar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CredencialesIncorrectas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Credenciales incorrectas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmacion;
        private Button btnAceptar;
    }
}