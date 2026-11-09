namespace clubdeportivo.igu.carnets
{
    partial class CarnetVistaPrevia
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
            btnCancelar = new Button();
            btnEntregar = new Button();
            panel1 = new Panel();
            lblFechaAlta = new Label();
            lblNumAfiliado = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            lblTituloCarnet = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DarkRed;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(405, 369);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 41);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEntregar
            // 
            btnEntregar.BackColor = Color.Black;
            btnEntregar.ForeColor = Color.White;
            btnEntregar.Location = new Point(207, 369);
            btnEntregar.Name = "btnEntregar";
            btnEntregar.Size = new Size(164, 41);
            btnEntregar.TabIndex = 15;
            btnEntregar.Text = "Entregar";
            btnEntregar.UseVisualStyleBackColor = false;
            btnEntregar.Click += btnEntregar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblFechaAlta);
            panel1.Controls.Add(lblNumAfiliado);
            panel1.Controls.Add(lblDni);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblTituloCarnet);
            panel1.Location = new Point(137, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(553, 256);
            panel1.TabIndex = 17;
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.Font = new Font("Segoe UI", 12F);
            lblFechaAlta.Location = new Point(31, 182);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(103, 28);
            lblFechaAlta.TabIndex = 5;
            lblFechaAlta.Text = "Fecha alta:";
            // 
            // lblNumAfiliado
            // 
            lblNumAfiliado.AutoSize = true;
            lblNumAfiliado.Font = new Font("Segoe UI", 12F);
            lblNumAfiliado.Location = new Point(283, 128);
            lblNumAfiliado.Name = "lblNumAfiliado";
            lblNumAfiliado.Size = new Size(112, 28);
            lblNumAfiliado.TabIndex = 4;
            lblNumAfiliado.Text = "N° Afiliado:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F);
            lblDni.Location = new Point(31, 128);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(50, 28);
            lblDni.TabIndex = 3;
            lblDni.Text = "DNI:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 12F);
            lblApellido.Location = new Point(283, 74);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(90, 28);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F);
            lblNombre.Location = new Point(31, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblTituloCarnet
            // 
            lblTituloCarnet.AutoSize = true;
            lblTituloCarnet.Font = new Font("Segoe UI", 16F);
            lblTituloCarnet.Location = new Point(154, 24);
            lblTituloCarnet.Name = "lblTituloCarnet";
            lblTituloCarnet.Size = new Size(276, 37);
            lblTituloCarnet.TabIndex = 0;
            lblTituloCarnet.Text = "Club deportivo del 29";
            // 
            // CarnetVistaPrevia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntregar);
            Name = "CarnetVistaPrevia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vista previa";
            Load += CarnetVistaPrevia_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCancelar;
        private Button btnEntregar;
        private Panel panel1;
        private Label lblFechaAlta;
        private Label lblNumAfiliado;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblTituloCarnet;
    }
}