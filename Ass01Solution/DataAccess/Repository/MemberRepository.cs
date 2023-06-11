using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class MemberRepository : IMemberRepository
    {
        public void addMember(Member member) => MemberDao.getMemberDao.AddMember(member);
        public void deleteMember(Member member) => MemberDao.getMemberDao.DeleteMember(member);
        public IEnumerable<Member> getListMember() => MemberDao.getMemberDao.getAllMember;
        public void getMemberByID(Member member) => MemberDao.getMemberDao.GetMemberByID(member.MemberID);
        public void updateMember(Member member) => MemberDao.getMemberDao.UpdateMember(member);
        public bool getMemberByEmailAndPassword(Member member) => MemberDao.getMemberDao.getMemberByEmailAndPassword(member);
        public IEnumerable<Member> getListMemberByKeyWord(string keyword) => MemberDao.getMemberDao.checkKeyWord(keyword);
        public IEnumerable<Member> getListMemberAscending() => MemberDao.getMemberDao.getListMemberAscending();
        public IEnumerable<Member> getListMemberDescending() => MemberDao.getMemberDao.getListMemberDescending();
        public Member getMemberInfoByEmailAndPassword(Member member) => MemberDao.getMemberDao.getMemberInfoByEmailAndPassword(member);
        public List<string> getListCities() => MemberDao.getMemberDao.getListCity();
        public List<string> getListCountry() => MemberDao.getMemberDao.getListCountry();
        public IEnumerable<Member> getListFilterCityAndCountry(string country, string city) => MemberDao.getMemberDao.getListFilterCityAndCountry(country, city);
    }
}
