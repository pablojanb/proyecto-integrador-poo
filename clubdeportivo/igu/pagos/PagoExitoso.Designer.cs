namespace clubdeportivo.igu.pagos
{
    partial class PagoExitoso
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
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(132, 99);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 17;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F);
            lblTitulo.Location = new Point(31, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(379, 37);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Pago ingresado correctamente";
            // 
            // PagoExitoso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 191);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Name = "PagoExitoso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pago exitoso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblTitulo;
    }
}