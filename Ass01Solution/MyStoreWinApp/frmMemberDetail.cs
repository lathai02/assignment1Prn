using BusinessObject;
using DataAccess.Repository;
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
    public partial class frmMemberDetail : Form
    {
        public bool isUpdate { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        public Member MemberInfo { get; set; }


        public frmMemberDetail()
        {
            InitializeComponent();
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !isUpdate;
            if (isUpdate)
            {
                txtMemberID.Text = MemberInfo.MemberID.ToString();
                txtMemberName.Text = MemberInfo.MemberName.ToString();
                txtMemberEmail.Text = MemberInfo.Email.ToString();
                txtMemberPassword.Text = MemberInfo.Password.ToString();
                txtMemberCity.Text = MemberInfo.City.ToString();
                txtMemberCountry.Text = MemberInfo.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Member m = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtMemberEmail.Text,
                    Password = txtMemberPassword.Text,
                    City = txtMemberCity.Text,
                    Country = txtMemberCountry.Text,
                };
                if (isUpdate)
                {
                    MemberRepository.updateMember(m);
                }
                else
                {
                    MemberRepository.addMember(m);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, isUpdate ? "Update a Member" : "Add a Member");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
