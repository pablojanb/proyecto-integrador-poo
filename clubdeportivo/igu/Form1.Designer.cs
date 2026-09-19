namespace clubdeportivo
{
    partial class Form1
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
            UserText = new TextBox();
            PassText = new TextBox();
            LoginLbl = new Label();
            BTNLogin = new Button();
            SuspendLayout();
            // 
            // UserText
            // 
            UserText.Location = new Point(203, 151);
            UserText.Name = "UserText";
            UserText.Size = new Size(360, 23);
            UserText.TabIndex = 0;
            UserText.TextChanged += UserText_TextChanged;
            // 
            // PassText
            // 
            PassText.Location = new Point(203, 209);
            PassText.Name = "PassText";
            PassText.Size = new Size(360, 23);
            PassText.TabIndex = 1;
            PassText.TextChanged += PassText_TextChanged;
            // 
            // LoginLbl
            // 
            LoginLbl.AutoSize = true;
            LoginLbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginLbl.Location = new Point(320, 49);
            LoginLbl.Name = "LoginLbl";
            LoginLbl.Size = new Size(146, 65);
            LoginLbl.TabIndex = 3;
            LoginLbl.Text = "Login";
            LoginLbl.Click += LoginLbl_Click;
            // 
            // BTNLogin
            // 
            BTNLogin.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTNLogin.Location = new Point(267, 268);
            BTNLogin.Name = "BTNLogin";
            BTNLogin.Size = new Size(245, 74);
            BTNLogin.TabIndex = 4;
            BTNLogin.Text = "Ingresar";
            BTNLogin.UseVisualStyleBackColor = true;
            BTNLogin.Click += BTNLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNLogin);
            Controls.Add(LoginLbl);
            Controls.Add(PassText);
            Controls.Add(UserText);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserText;
        private TextBox PassText;
        private Label LoginLbl;
        private Button BTNLogin;
    }
}
