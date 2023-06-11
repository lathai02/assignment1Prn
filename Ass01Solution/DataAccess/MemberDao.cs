using BusinessObject;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class MemberDao
    {
        private static List<Member> MemberList = new List<Member>()
        {
            new Member
            {
                MemberID = 1,
                MemberName = "le an thai",
                Email = "leanthai02@gmail.com",
                Password = "Lat1611@",
                City = "Ha Noi",
                Country = "Nghe An",
            }
        };

        public MemberDao() { }

        private static MemberDao memberDao = null;
        private static readonly object memberDaoLock = new object();


        public static MemberDao getMemberDao
        {
            get
            {
                lock (memberDaoLock)
                {
                    if (memberDao == null)
                    {
                        memberDao = new MemberDao();
                    }
                    return memberDao;

                }
            }
        }

        public List<Member> getAllMember => MemberList;

        public Member GetMemberByID(int id)
        {
            return MemberList.SingleOrDefault(member => member.MemberID == id);
        }

        public void AddMember(Member memberAdd)
        {
            Member mem = GetMemberByID(memberAdd.MemberID);
            if (mem == null)
            {
                MemberList.Add(memberAdd);
            }
            else
            {
                throw new Exception("Member has already exists");
            }
        }

        public void UpdateMember(Member memberUpdate)
        {
            Member mem = GetMemberByID(memberUpdate.MemberID);
            if (mem != null)
            {
                MemberList[MemberList.IndexOf(mem)] = memberUpdate;
            }
            else
            {
                throw new Exception("Member does not exist");
            }
        }

        public void DeleteMember(Member memberDelete)
        {
            Member mem = GetMemberByID(memberDelete.MemberID);
            if (mem != null)
            {
                MemberList.Remove(mem);
            }
            else
            {
                throw new Exception("Member does not exist");
            }
        }

        internal bool getMemberByEmailAndPassword(Member memberFind)
        {
            var mem = MemberList.SingleOrDefault(member => (member.Email == memberFind.Email && member.Password == memberFind.Password));
            if (mem != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal IEnumerable<Member> checkKeyWord(string keyword)
        {
            string pattern = @"^\d+$";
           if(Regex.IsMatch(keyword, pattern))
            {
                return getListMemberByID(keyword);
            }
            else
            {
                return getListMemberByName(keyword);
            }
        }

        internal IEnumerable<Member> getListMemberByID(string keyword)
        {
            List<Member> list = new List<Member>();
            list.Add(MemberList.SingleOrDefault(mem => mem.MemberID == int.Parse(keyword)));
            return list;
        }

        internal IEnumerable<Member> getListMemberByName(string keyword)
        {
            List<Member> list = new List<Member>();
            foreach (Member m in MemberList)
            {
                if (m.MemberName.Contains(keyword))
                {
                    list.Add(m);
                }
            }
            return list;
        }

        internal IEnumerable<Member> getListMemberAscending()
        {
            return MemberList.OrderBy(m => m.MemberName).ToList();
        }

        internal IEnumerable<Member> getListMemberDescending()
        {
            return MemberList.OrderByDescending(m => m.MemberName).ToList();
        }

        internal Member getMemberInfoByEmailAndPassword(Member memberFind)
        {
            return MemberList.SingleOrDefault(member => (member.Email == memberFind.Email && member.Password == memberFind.Password));
        }

        internal List<string> getListCity()
        {
            List<string> cities = new List<string>();
            cities = MemberList.Select(member => member.City).ToList();
            return cities;
        }

        internal List<string> getListCountry()
        {
            List<string> countries = new List<string>();
            countries = MemberList.Select(member => member.Country).ToList();
            return countries;
        }

        internal IEnumerable<Member> getListFilterCityAndCountry(string country, string city)
        {
            List<Member> listFilterByCityAndCountry = new List<Member>();
            foreach (Member m in MemberList)
            {
                if (m.City.Equals(city) && m.Country.Equals(country))
                {
                    listFilterByCityAndCountry.Add(m);
                }
            }
            return listFilterByCityAndCountry.ToList();
        }
    }
}