namespace clubdeportivo.igu.socios
{
    partial class CamposObligatorios
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
            lblConfirmacion = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI", 16F);
            lblConfirmacion.Location = new Point(35, 37);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(427, 37);
            lblConfirmacion.TabIndex = 19;
            lblConfirmacion.Text = "Todos los campos son obligatorios";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(141, 105);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // CamposObligatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 194);
            Controls.Add(lblConfirmacion);
            Controls.Add(btnAceptar);
            Name = "CamposObligatorios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error Alta Socio";
            Load += CamposObligatorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmacion;
        private Button btnAceptar;
    }
}