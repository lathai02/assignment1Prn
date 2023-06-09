using BusinessObject;
using DataAccess.Repository;
using Newtonsoft.Json;


namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        IMemberRepository MemberRepository = new MemberRepository();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            Member member = new Member
            {
                Email = email,
                Password = password,
            };

            string json = File.ReadAllText("appsettings.json");
            dynamic settings = JsonConvert.DeserializeObject(json);

            string adminEmail = settings["DefaultAccount"]["Email"];
            string adminPassword = settings["DefaultAccount"]["Password"];

            if (email == adminEmail && password == adminPassword)
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.isAdmin = true;
                frmMemberManagement.ShowDialog();
            }
            else if (MemberRepository.getMemberByEmailAndPassword(member))
            {
                MessageBox.Show("Login Successful", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                frmMemberManagement.isAdmin = false;
                frmMemberManagement.ShowDialog();
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
