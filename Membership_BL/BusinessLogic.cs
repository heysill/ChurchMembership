using MembershipCommon;
using Membership_DataAccess;

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

            
                EmailService emailService = new EmailService();
                string subject = "Membership Confirmed!";
                string body = $"{DateTime.Now:yyyy-MM-dd hh:mm tt} : {member.Name} your officially added as a member at SCHCBC.\n";

                emailService.SendEmail(subject, body);
            

            return true;
        }

        public bool CancelMember(string name)
        {
            bool result = memberAccess.RemoveMember(name);

            if (result)
            {
                EmailService emailService = new EmailService();
                string subject = "Membership Cancelled!";
                string body = $"{DateTime.Now:yyyy-MM-dd hh:mm tt} : {name} has requested to cancel the membership.\n";

                emailService.SendEmail (subject, body);
            }

            return result;
        }

        public List<Member> GetAllMembers()
        {
            return memberAccess.GetAllMembers();
        }

        public Member GetMember(string name)
        {
            return memberAccess.GetMember(name);
        }

        public bool UpdateMember(string oldName, Member updatedMember)
        {
            bool result = memberAccess.UpdateMember(oldName, updatedMember);

            if (result)
            {
                EmailService emailService = new EmailService();
                string subject = "Membership Updated!";
                string body = $"{DateTime.Now:yyyy-MM-dd hh:mm tt} : {oldName} membership has been updated.\n";

                emailService.SendEmail(subject, body);
            }

            return result;
        }

    }
}
