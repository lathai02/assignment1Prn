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
        public Member Member = new Member();


        private void btnLoad_Click(object sender, EventArgs e)
        {

            LoadListMember(getAll());
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

        private List<Member> getAll()
        {
            List<Member> memberList = new List<Member>();
            memberList = (List<Member>)memberRepository.getListMember();
            return memberList;
        }

        private void LoadListMember(List<Member> listMember)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = listMember;

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
                cbCity.DataSource = memberRepository.getListCities();
                cbCountry.DataSource = memberRepository.getListCountry();
                dgvMemberList.DataSource = source;

                if (listMember.Count() == 0)
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
                LoadListMember(getAll());
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
            if (!isAdmin)
            {
                btnDelete.Visible = false;
                btnNew.Visible = false;
                btnSearch.Visible = false;
                cbCity.Visible = false;
                cbCountry.Visible = false;
                btnFind.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Visible = false;
                btnLoad.Visible = false;
                cbSortMember.Visible = false;
                lbFilterCity.Visible = false;
                lbFilterCountry.Visible = false;
                lbSortMember.Visible = false;

                List<Member> members = new List<Member>();
                members.Add(Member);
                LoadListMember(members);
            }
            else
            {
                cbCity.DataSource = memberRepository.getListCities();
                cbCountry.DataSource = memberRepository.getListCountry();
            }
            btnDelete.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add Car",
                isUpdate = false,
                MemberRepository = memberRepository,

            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListMember(getAll());
                source.Position = source.Count - 1;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Update Car",
                isUpdate = true,
                MemberRepository = memberRepository,
                MemberInfo = getMember()
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                LoadListMember(getAll());
                source.Position = source.Count - 1;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                LoadListMember((List<Member>)memberRepository.getListMemberByKeyWord(txtSearch.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete car");
            }
        }

        private void cbSortMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSortMember.Text == "Assending")
            {
                LoadListMember((List<Member>)memberRepository.getListMemberAscending());
            }
            else
            {
                LoadListMember((List<Member>)memberRepository.getListMemberDescending());
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            var city = cbCity.Text;
            var country = cbCountry.Text;
            
            LoadListMember((List<Member>)memberRepository.getListFilterCityAndCountry(country,city));

        }
    }
}
