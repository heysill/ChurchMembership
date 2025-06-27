using MembershipCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MembershipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        Membership_BL.BusinessLogic businessLogic = new Membership_BL.BusinessLogic();

        [HttpGet("add")]
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
            return businessLogic.AddMember(name, age, birthdate, address, gmail);
        }

        [HttpDelete("cancel")]
        public bool CancelMember(string name)
        {
            return businessLogic.CancelMember(name);
        }

        [HttpGet("members")]
        public List<Member> GetAllMembers()
        {
            return businessLogic.GetAllMembers();
        }

        [HttpGet("member")]
        public Member GetMember(string name)
        {
            return businessLogic.GetMember(name);
        }

        [HttpPatch("update")]
        public bool UpdateMember(string oldName, Member updatedMember)
        {
            return businessLogic.UpdateMember(oldName, updatedMember);
        }
    }
}
