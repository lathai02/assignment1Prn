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
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }

        public bool isAdmin;
        BindingSource source;
        IMemberRepository memberRepository = new MemberRepository();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadListCar();
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtMemberEmail.Text = string.Empty;
            txtMemberPassword.Text = string.Empty;
            txtMemberCity.Text = string.Empty;
            txtMemberCountry.Text = string.Empty;
        }

        private void LoadListCar()
        {
            var memberList = memberRepository.getListMember();
            try
            {
                source = new BindingSource();
                source.DataSource = memberList;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtMemberEmail.DataBindings.Clear();
                txtMemberPassword.DataBindings.Clear();
                txtMemberCity.DataBindings.Clear();
                txtMemberCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtMemberEmail.DataBindings.Add("Text", source, "Email");
                txtMemberPassword.DataBindings.Add("Text", source, "Password");
                txtMemberCity.DataBindings.Add("Text", source, "City");
                txtMemberCountry.DataBindings.Add("Text", source, "Country");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;

                if (memberList.Count() == 0)
                {
                    btnDelete.Enabled = false;
                    ClearText();
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load car List");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Member member = getMember();
                memberRepository.deleteMember(member);
                LoadListCar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete car");
            }
        }

        private Member getMember()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberID = int.Parse(txtMemberID.Text),
                    MemberName = txtMemberName.Text,
                    Email = txtMemberEmail.Text,
                    Password = txtMemberPassword.Text,
                    City = txtMemberCity.Text,
                    Country = txtMemberCountry.Text,
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get car");
            }
            return member;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }
    }
}
