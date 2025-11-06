using MembershipCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MembershipAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly Membership_BL.BusinessLogic _businessLogic;

        public MembersController(Membership_BL.BusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }

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
            return _businessLogic.AddMember(name, age, birthdate, address, gmail);
        }

        [HttpDelete("cancel")]
        public bool CancelMember(string name)
        {
            return _businessLogic.CancelMember(name);
        }

        [HttpGet("members")]
        public List<Member> GetAllMembers()
        {
            return _businessLogic.GetAllMembers();
        }

        [HttpGet("member")]
        public Member GetMember(string name)
        {
            return _businessLogic.GetMember(name);
        }

        [HttpPatch("update")]
        public bool UpdateMember(string oldName, Member updatedMember)
        {
            return _businessLogic.UpdateMember(oldName, updatedMember);
        }
    }
}
