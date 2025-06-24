using MembershipCommon;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Membership_DataAccess
{
    public class InMemoryMemberDataAccess : IMember
    {
        private readonly List<Member> _members = new List<Member>();

        public InMemoryMemberDataAccess()
        {
            CreateMembers();
        }

        private void CreateMembers()
        {
            _members.Add(new Member
            {
                Name = "Ashanti Bas",
                Age = "17",
                Birthdate = "2008-02-29",
                Address = "Iligan St.",
                Gmail = "ashanti@gmail.com"
            });

            _members.Add(new Member
            {
                Name = "Trisha Tumabiao",
                Age = "19",
                Birthdate = "2006-07-02",
                Address = "Tawi-tawi St.",
                Gmail = "trisha@gmail.com"
            });

            _members.Add(new Member
            {
                Name = "Bambi Ramos",
                Age = "21",
                Birthdate = "2004-02-14",
                Address = "Jolo St.",
                Gmail = "bambi@gmail.com"
            });
        }

        public void AddMember(Member member)
        {
            _members.Add(member);
        }

        public bool RemoveMember(string name)
        {
            var member = _members.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (member != null)
            {
                _members.Remove(member);
                return true;
            }
            return false;
        }

        public List<Member> GetAll()
        {
            return _members;
        }

        public bool UpdateMember(string oldName, Member updatedMember)
        {
            foreach (var member in _members)
            {
                if (member.Name == oldName)
                {
                    member.Name = updatedMember.Name;
                    member.Age = updatedMember.Age;
                    member.Birthdate = updatedMember.Birthdate;
                    member.Address = updatedMember.Address;
                    member.Gmail = updatedMember.Gmail;
                    return true;
                }
            }
            return false;
        }

        public Member GetMember(string name)
        {
            return _members.FirstOrDefault(m => m.Name.Trim().Equals(name.Trim(), System.StringComparison.OrdinalIgnoreCase));
        }
    }
}