namespace clubdeportivo.igu
{
    partial class FormatoInvalido
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
            lblTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(239, 180);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(164, 41);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Acepar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(116, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(402, 46);
            lblTitle.TabIndex = 21;
            lblTitle.Text = "Error en datos ingresados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(38, 107);
            label1.Name = "label1";
            label1.Size = new Size(570, 37);
            label1.TabIndex = 23;
            label1.Text = "Por favor, verifique el formato en el formulario.";
            // 
            // FormatoInvalido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 255);
            Controls.Add(label1);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitle);
            Name = "FormatoInvalido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Label lblTitle;
        private Label label1;
    }
}