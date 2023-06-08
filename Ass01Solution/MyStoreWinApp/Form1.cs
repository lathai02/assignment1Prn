using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            string json = File.ReadAllText("D:\\SUMMER2023\\PRN211\\Assignment1\\Ass01Solution\\MyStoreWinApp\\appsettings.json");
            dynamic settings = JsonConvert.DeserializeObject(json);
            string defaultEmail = settings["DefaultAccount"]["Email"];
            string defaultPassword = settings["DefaultAccount"]["Password"];

            if (email == defaultEmail && password == defaultPassword)
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Fail", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
