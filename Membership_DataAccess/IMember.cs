using MembershipCommon;

namespace Membership_DataAccess
{
    interface IMember
    {
        List<Member> GetAll();
        void AddMember(Member member);
        bool RemoveMember(string name);
        bool UpdateMember(string oldName, Member updatedMember);
        Member GetMember(string name);
    }
}
