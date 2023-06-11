namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            txtMemberCountry = new TextBox();
            txtMemberCity = new TextBox();
            txtMemberPassword = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberName = new TextBox();
            txtMemberID = new TextBox();
            lbCountry = new Label();
            lbCity = new Label();
            lbPassword = new Label();
            labelEmail = new Label();
            lbName = new Label();
            lbID = new Label();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // txtMemberCountry
            // 
            txtMemberCountry.Location = new Point(209, 305);
            txtMemberCountry.Name = "txtMemberCountry";
            txtMemberCountry.Size = new Size(216, 27);
            txtMemberCountry.TabIndex = 23;
            // 
            // txtMemberCity
            // 
            txtMemberCity.Location = new Point(209, 255);
            txtMemberCity.Name = "txtMemberCity";
            txtMemberCity.Size = new Size(216, 27);
            txtMemberCity.TabIndex = 22;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Location = new Point(209, 210);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(216, 27);
            txtMemberPassword.TabIndex = 21;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(209, 166);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(216, 27);
            txtMemberEmail.TabIndex = 20;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(209, 122);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(216, 27);
            txtMemberName.TabIndex = 19;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(209, 77);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(216, 27);
            txtMemberID.TabIndex = 18;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(95, 308);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 17;
            lbCountry.Text = "Country";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(95, 258);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 16;
            lbCity.Text = "City";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(95, 217);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 15;
            lbPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(95, 169);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(106, 20);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Member Email";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(94, 129);
            lbName.Name = "lbName";
            lbName.Size = new Size(109, 20);
            lbName.TabIndex = 13;
            lbName.Text = "Member Name";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(95, 84);
            lbID.Name = "lbID";
            lbID.Size = new Size(80, 20);
            lbID.TabIndex = 12;
            lbID.Text = "MemberID";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(209, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Location = new Point(331, 355);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 25;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 467);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtMemberCountry);
            Controls.Add(txtMemberCity);
            Controls.Add(txtMemberPassword);
            Controls.Add(txtMemberEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(lbCountry);
            Controls.Add(lbCity);
            Controls.Add(lbPassword);
            Controls.Add(labelEmail);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMemberCountry;
        private TextBox txtMemberCity;
        private TextBox txtMemberPassword;
        private TextBox txtMemberEmail;
        private TextBox txtMemberName;
        private TextBox txtMemberID;
        private Label lbCountry;
        private Label lbCity;
        private Label lbPassword;
        private Label labelEmail;
        private Label lbName;
        private Label lbID;
        private Button btnSave;
        private Button btnClose;
    }
}