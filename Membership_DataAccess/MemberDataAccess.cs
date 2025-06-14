using MembershipCommon;
using System.Collections.Generic;

namespace Membership_DataAccess
{
    public class MemberDataAccess
    {
        static IMember memberDataAccess = new InMemoryMemberDataAccess();
        //static IMember memberDataAccess = new JsonFileMemberDataAccess();
        //static IMember memberDataAccess = new TextFileMemberDataAccess();
        //static IMember memberDataAccess = new DBMembershipDataAccess();

        public List<Member> GetAllMembers()
        {
            return memberDataAccess.GetAll();
        }

        public void AddMember(Member member)
        {
            memberDataAccess.AddMember(member);
        }

        public bool RemoveMember(string name)
        {
            return memberDataAccess.RemoveMember(name);
        }

    }
}