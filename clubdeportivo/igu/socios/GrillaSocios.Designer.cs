namespace clubdeportivo.igu.socios
{
    partial class GrillaSocios
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
            gridSocios = new DataGridView();
            lblTitulo = new Label();
            btnFiltroTodos = new Button();
            btnFiltroVencidos = new Button();
            btnFiltroVenceHoy = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)gridSocios).BeginInit();
            SuspendLayout();
            // 
            // gridSocios
            // 
            gridSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridSocios.Location = new Point(21, 131);
            gridSocios.Name = "gridSocios";
            gridSocios.RowHeadersWidth = 51;
            gridSocios.Size = new Size(1063, 359);
            gridSocios.TabIndex = 0;
            gridSocios.CellContentClick += gridSocios_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.Location = new Point(365, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(275, 46);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Listado de socios";
            // 
            // btnFiltroTodos
            // 
            btnFiltroTodos.BackColor = Color.Black;
            btnFiltroTodos.ForeColor = Color.White;
            btnFiltroTodos.Location = new Point(21, 71);
            btnFiltroTodos.Name = "btnFiltroTodos";
            btnFiltroTodos.Size = new Size(206, 41);
            btnFiltroTodos.TabIndex = 22;
            btnFiltroTodos.Text = "Todos";
            btnFiltroTodos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroVencidos
            // 
            btnFiltroVencidos.BackColor = Color.Black;
            btnFiltroVencidos.ForeColor = Color.White;
            btnFiltroVencidos.Location = new Point(247, 71);
            btnFiltroVencidos.Name = "btnFiltroVencidos";
            btnFiltroVencidos.Size = new Size(206, 41);
            btnFiltroVencidos.TabIndex = 23;
            btnFiltroVencidos.Text = "Vencidos";
            btnFiltroVencidos.UseVisualStyleBackColor = false;
            // 
            // btnFiltroVenceHoy
            // 
            btnFiltroVenceHoy.BackColor = Color.Black;
            btnFiltroVenceHoy.ForeColor = Color.White;
            btnFiltroVenceHoy.Location = new Point(474, 71);
            btnFiltroVenceHoy.Name = "btnFiltroVenceHoy";
            btnFiltroVenceHoy.Size = new Size(206, 41);
            btnFiltroVenceHoy.TabIndex = 24;
            btnFiltroVenceHoy.Text = "Vence hoy";
            btnFiltroVenceHoy.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.Black;
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(450, 516);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(206, 41);
            btnVolver.TabIndex = 25;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // GrillaSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1119, 590);
            Controls.Add(btnVolver);
            Controls.Add(btnFiltroVenceHoy);
            Controls.Add(btnFiltroVencidos);
            Controls.Add(btnFiltroTodos);
            Controls.Add(lblTitulo);
            Controls.Add(gridSocios);
            Name = "GrillaSocios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado de socios";
            Load += GrillaSocios_Load;
            ((System.ComponentModel.ISupportInitialize)gridSocios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridSocios;
        private Label lblTitulo;
        private Button btnFiltroTodos;
        private Button btnFiltroVencidos;
        private Button btnFiltroVenceHoy;
        private Button btnVolver;
    }
}