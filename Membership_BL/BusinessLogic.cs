using MembershipCommon;
using Membership_DataAccess;
using System.Collections.Generic;

namespace Membership_BL
{
    public class BusinessLogic
    {
        MemberDataAccess memberAccess = new MemberDataAccess();

        public bool AddMember(string name, string age, string birthdate, string address, string gmail)
        {
            var member = new Member
            {
                Name = name,
                Age = age,
                Birthdate = birthdate,
                Address = address,
                Gmail = gmail
            };

            memberAccess.AddMember(member);
            return true;
        }

        public bool CancelMember(string name)
        {
            return memberAccess.RemoveMember(name);
        }

        public List<Member> GetAllMembers()
        {
            return memberAccess.GetAllMembers();
        }

    }
}
