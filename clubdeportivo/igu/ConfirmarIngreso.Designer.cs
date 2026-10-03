namespace clubdeportivo.igu
{
    partial class ConfirmarIngreso
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI", 20F);
            lblConfirmacion.Location = new Point(175, 132);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(455, 46);
            lblConfirmacion.TabIndex = 13;
            lblConfirmacion.Text = "¿Confirmar el nuevo ingreso?";
            lblConfirmacion.Click += lblTitle_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(407, 272);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(206, 41);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(160, 272);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            // 
            // ConfirmarIngreso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblConfirmacion);
            Name = "ConfirmarIngreso";
            Text = "ConfirmarIngreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmacion;
        private Button btnCancelar;
        private Button btnAceptar;
    }
}