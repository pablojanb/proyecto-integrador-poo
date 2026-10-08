namespace clubdeportivo.igu
{
    partial class SesionTimer
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
            lblTimer = new Label();
            lblTitulo = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 14F);
            lblTimer.Location = new Point(198, 106);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(101, 32);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "lblTimer";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(148, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(200, 46);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "¿Seguis ahí?";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(142, 168);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 16;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // SesionTimer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 260);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Controls.Add(lblTimer);
            Name = "SesionTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SesionTimer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTimer;
        private Label lblTitulo;
        private Button btnAceptar;
    }
}