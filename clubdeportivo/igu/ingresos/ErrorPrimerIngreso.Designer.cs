namespace clubdeportivo.igu.ingresos
{
    partial class ErrorPrimerIngreso
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
            lblConfirmacion = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(179, 123);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 18;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI", 20F);
            lblConfirmacion.Location = new Point(34, 45);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(517, 46);
            lblConfirmacion.TabIndex = 17;
            lblConfirmacion.Text = "La persona tiene ingresos previos";
            // 
            // ErrorPrimerIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 227);
            Controls.Add(btnAceptar);
            Controls.Add(lblConfirmacion);
            Name = "ErrorPrimerIngreso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblConfirmacion;
    }
}