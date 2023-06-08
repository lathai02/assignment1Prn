using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<Member> getListMember();
        void getMemberByID(Member member);
        void deleteMember(Member member);
        void updateMember(Member member);
        void addMember(Member member);
    }
}
