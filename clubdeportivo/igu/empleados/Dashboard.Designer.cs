namespace clubdeportivo.igu
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            lblTitle = new Label();
            imgFondo = new PictureBox();
            btnAltaSocio = new Button();
            lblUsuario = new Label();
            btnIngresoEgreso = new Button();
            btnEmitirCarnet = new Button();
            btnVencimientos = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)imgFondo).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 30F);
            lblTitle.Location = new Point(227, 73);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(504, 67);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Club deportivo del 29";
            lblTitle.Click += label1_Click;
            // 
            // imgFondo
            // 
            imgFondo.Image = Properties.Resources.bg_dashboard;
            imgFondo.Location = new Point(-2, -1);
            imgFondo.Name = "imgFondo";
            imgFondo.Size = new Size(943, 554);
            imgFondo.TabIndex = 1;
            imgFondo.TabStop = false;
            // 
            // btnAltaSocio
            // 
            btnAltaSocio.BackColor = Color.Black;
            btnAltaSocio.ForeColor = Color.White;
            btnAltaSocio.Location = new Point(600, 212);
            btnAltaSocio.Name = "btnAltaSocio";
            btnAltaSocio.Size = new Size(241, 52);
            btnAltaSocio.TabIndex = 2;
            btnAltaSocio.Text = "Alta socio";
            btnAltaSocio.UseVisualStyleBackColor = false;
            btnAltaSocio.Click += btnAltaSocio_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 20F);
            lblUsuario.Location = new Point(319, 150);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(185, 46);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Bienvenido";
            lblUsuario.Click += lblUsuario_Click;
            // 
            // btnIngresoEgreso
            // 
            btnIngresoEgreso.BackColor = Color.Black;
            btnIngresoEgreso.ForeColor = Color.White;
            btnIngresoEgreso.Location = new Point(600, 270);
            btnIngresoEgreso.Name = "btnIngresoEgreso";
            btnIngresoEgreso.Size = new Size(241, 52);
            btnIngresoEgreso.TabIndex = 4;
            btnIngresoEgreso.Text = "Ingreso/Egreso";
            btnIngresoEgreso.UseVisualStyleBackColor = false;
            btnIngresoEgreso.Click += button2_Click;
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.BackColor = Color.Black;
            btnEmitirCarnet.ForeColor = Color.White;
            btnEmitirCarnet.Location = new Point(600, 328);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(241, 52);
            btnEmitirCarnet.TabIndex = 5;
            btnEmitirCarnet.Text = "Emitir carnet";
            btnEmitirCarnet.UseVisualStyleBackColor = false;
            // 
            // btnVencimientos
            // 
            btnVencimientos.BackColor = Color.Black;
            btnVencimientos.ForeColor = Color.White;
            btnVencimientos.Location = new Point(600, 386);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(241, 52);
            btnVencimientos.TabIndex = 6;
            btnVencimientos.Text = "Vencimientos";
            btnVencimientos.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Black;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(600, 444);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(241, 52);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 551);
            Controls.Add(btnSalir);
            Controls.Add(btnVencimientos);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(btnIngresoEgreso);
            Controls.Add(lblUsuario);
            Controls.Add(btnAltaSocio);
            Controls.Add(lblTitle);
            Controls.Add(imgFondo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFTS 29 - Dashboard";
            FormClosing += Dashboard_FormClosing;
            FormClosed += Dashboard_FormClosed;
            ((System.ComponentModel.ISupportInitialize)imgFondo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox imgFondo;
        private Button btnAltaSocio;
        private Label lblUsuario;
        private Button btnIngresoEgreso;
        private Button btnEmitirCarnet;
        private Button btnVencimientos;
        private Button btnSalir;
    }
}