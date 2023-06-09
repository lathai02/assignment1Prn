namespace MyStoreWinApp
{
    partial class frmLogin
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
            btnReset = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbPassword = new Label();
            lbEmail = new Label();
            SuspendLayout();
            // 
            // btnReset
            // 
            btnReset.Location = new Point(304, 210);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 30;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(192, 210);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 29;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(192, 147);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(206, 27);
            txtPassword.TabIndex = 28;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(192, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(206, 27);
            txtEmail.TabIndex = 27;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(116, 150);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 26;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(116, 99);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 25;
            lbEmail.Text = "Email";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 381);
            Controls.Add(btnReset);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReset;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lbPassword;
        private Label lbEmail;
    }
}