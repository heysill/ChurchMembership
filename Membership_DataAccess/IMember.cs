using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipCommon;

namespace Membership_DataAccess
{
    interface IMember
    {
        List<Member> GetAll();
        void AddMember(Member member);
        bool RemoveMember(string name);
    }
}
