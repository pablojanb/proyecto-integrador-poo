namespace clubdeportivo.igu.ingresos
{
    partial class IngresoActivo
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
            btnAceptar.Location = new Point(224, 116);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblConfirmacion
            // 
            lblConfirmacion.AutoSize = true;
            lblConfirmacion.Font = new Font("Segoe UI", 20F);
            lblConfirmacion.Location = new Point(45, 38);
            lblConfirmacion.Name = "lblConfirmacion";
            lblConfirmacion.Size = new Size(569, 46);
            lblConfirmacion.TabIndex = 19;
            lblConfirmacion.Text = "La persona tiene un ingreso en curso";
            lblConfirmacion.Click += lblConfirmacion_Click;
            // 
            // IngresoActivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 206);
            Controls.Add(btnAceptar);
            Controls.Add(lblConfirmacion);
            Name = "IngresoActivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error ingreso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblConfirmacion;
    }
}