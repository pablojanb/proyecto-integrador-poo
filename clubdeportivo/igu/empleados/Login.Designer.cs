namespace clubdeportivo
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lblTitulo = new Label();
            btnAceptar = new Button();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(244, 245);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(411, 27);
            txtUsername.TabIndex = 0;
            txtUsername.Text = "Ingrese su usuario";
            txtUsername.Click += txtUsername_Click;
            txtUsername.TextChanged += UserText_TextChanged;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(244, 307);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.ScrollBars = ScrollBars.Vertical;
            txtPassword.Size = new Size(411, 27);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Ingrese su contraseña";
            txtPassword.Click += txtPassword_Click;
            txtPassword.TextChanged += PassText_TextChanged;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(180, 76);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(605, 81);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Club deportivo del 29";
            lblTitulo.Click += LoginLbl_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Black;
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(346, 385);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(206, 41);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Ingresar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F);
            lblLogin.Location = new Point(406, 177);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(118, 46);
            lblLogin.TabIndex = 15;
            lblLogin.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblLogin);
            Controls.Add(btnAceptar);
            Controls.Add(lblTitulo);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IFTS  - 29 Club deportivo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblTitulo;
        private Button btnAceptar;
        private Label lblLogin;
    }
}
