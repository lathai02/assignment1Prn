namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbID = new Label();
            lbName = new Label();
            labelEmail = new Label();
            lbPassword = new Label();
            lbCity = new Label();
            lbCountry = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtMemberEmail = new TextBox();
            txtMemberPassword = new TextBox();
            txtMemberCity = new TextBox();
            txtMemberCountry = new TextBox();
            dgvMemberList = new DataGridView();
            btnNew = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            txtFilterByCity = new TextBox();
            txtFilterByCountry = new TextBox();
            btnFind = new Button();
            lbFilterCity = new Label();
            lbFilterCountry = new Label();
            cbSortMember = new ComboBox();
            label1 = new Label();
            btnLoad = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(18, 34);
            lbID.Name = "lbID";
            lbID.Size = new Size(80, 20);
            lbID.TabIndex = 0;
            lbID.Text = "MemberID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(17, 79);
            lbName.Name = "lbName";
            lbName.Size = new Size(109, 20);
            lbName.TabIndex = 1;
            lbName.Text = "Member Name";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(18, 119);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(106, 20);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "Member Email";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(18, 167);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password";
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(18, 208);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(18, 258);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 5;
            lbCountry.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(132, 27);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(216, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(132, 72);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(216, 27);
            txtMemberName.TabIndex = 7;
            // 
            // txtMemberEmail
            // 
            txtMemberEmail.Location = new Point(132, 116);
            txtMemberEmail.Name = "txtMemberEmail";
            txtMemberEmail.Size = new Size(216, 27);
            txtMemberEmail.TabIndex = 8;
            // 
            // txtMemberPassword
            // 
            txtMemberPassword.Location = new Point(132, 160);
            txtMemberPassword.Name = "txtMemberPassword";
            txtMemberPassword.Size = new Size(216, 27);
            txtMemberPassword.TabIndex = 9;
            // 
            // txtMemberCity
            // 
            txtMemberCity.Location = new Point(132, 205);
            txtMemberCity.Name = "txtMemberCity";
            txtMemberCity.Size = new Size(216, 27);
            txtMemberCity.TabIndex = 10;
            // 
            // txtMemberCountry
            // 
            txtMemberCountry.Location = new Point(132, 255);
            txtMemberCountry.Name = "txtMemberCountry";
            txtMemberCountry.Size = new Size(216, 27);
            txtMemberCountry.TabIndex = 11;
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(12, 325);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new Size(970, 169);
            dgvMemberList.TabIndex = 12;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(771, 258);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 13;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(557, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(881, 20);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(659, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 27);
            txtSearch.TabIndex = 16;
            // 
            // txtFilterByCity
            // 
            txtFilterByCity.Location = new Point(659, 72);
            txtFilterByCity.Name = "txtFilterByCity";
            txtFilterByCity.Size = new Size(218, 27);
            txtFilterByCity.TabIndex = 17;
            // 
            // txtFilterByCountry
            // 
            txtFilterByCountry.Location = new Point(659, 119);
            txtFilterByCountry.Name = "txtFilterByCountry";
            txtFilterByCountry.Size = new Size(216, 27);
            txtFilterByCountry.TabIndex = 18;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(881, 72);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(94, 74);
            btnFind.TabIndex = 19;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // lbFilterCity
            // 
            lbFilterCity.AutoSize = true;
            lbFilterCity.Location = new Point(557, 75);
            lbFilterCity.Name = "lbFilterCity";
            lbFilterCity.Size = new Size(34, 20);
            lbFilterCity.TabIndex = 21;
            lbFilterCity.Text = "City";
            // 
            // lbFilterCountry
            // 
            lbFilterCountry.AutoSize = true;
            lbFilterCountry.Location = new Point(557, 122);
            lbFilterCountry.Name = "lbFilterCountry";
            lbFilterCountry.Size = new Size(60, 20);
            lbFilterCountry.TabIndex = 22;
            lbFilterCountry.Text = "Country";
            // 
            // cbSortMember
            // 
            cbSortMember.FormattingEnabled = true;
            cbSortMember.Items.AddRange(new object[] { "Assending", "Descending" });
            cbSortMember.Location = new Point(659, 164);
            cbSortMember.Name = "cbSortMember";
            cbSortMember.Size = new Size(216, 28);
            cbSortMember.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(557, 167);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 24;
            label1.Text = "Sort member";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(671, 258);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 25;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(881, 258);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 26;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 506);
            Controls.Add(btnClose);
            Controls.Add(btnLoad);
            Controls.Add(label1);
            Controls.Add(cbSortMember);
            Controls.Add(lbFilterCountry);
            Controls.Add(lbFilterCity);
            Controls.Add(btnFind);
            Controls.Add(txtFilterByCountry);
            Controls.Add(txtFilterByCity);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(dgvMemberList);
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
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private Label lbName;
        private Label labelEmail;
        private Label lbPassword;
        private Label lbCity;
        private Label lbCountry;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtMemberEmail;
        private TextBox txtMemberPassword;
        private TextBox txtMemberCity;
        private TextBox txtMemberCountry;
        private DataGridView dgvMemberList;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearch;
        private TextBox txtFilterByCity;
        private TextBox txtFilterByCountry;
        private Button btnFind;
        private Label lbFilterCity;
        private Label lbFilterCountry;
        private ComboBox cbSortMember;
        private Label label1;
        private Button btnLoad;
        private Button btnClose;
    }
}