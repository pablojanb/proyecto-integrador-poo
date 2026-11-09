namespace clubdeportivo.igu.ingresos
{
    partial class IngresoDeuda
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
            lblInfo = new Label();
            btnAceptar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 16F);
            lblInfo.Location = new Point(311, 26);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(222, 37);
            lblInfo.TabIndex = 21;
            lblInfo.Text = "Deuda pendiente";
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(292, 165);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 22;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(66, 75);
            label1.Name = "label1";
            label1.Size = new Size(712, 32);
            label1.TabIndex = 23;
            label1.Text = "El socio registra deuda pendiente, debe abonar antes de ingresar.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(183, 107);
            label2.Name = "label2";
            label2.Size = new Size(480, 32);
            label2.TabIndex = 24;
            label2.Text = "Ver sección vencimientos para más detalles.";
            // 
            // IngresoDeuda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 245);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblInfo);
            Controls.Add(btnAceptar);
            Name = "IngresoDeuda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error";
            Load += IngresoDeuda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnAceptar;
        private Label label1;
        private Label label2;
    }
}