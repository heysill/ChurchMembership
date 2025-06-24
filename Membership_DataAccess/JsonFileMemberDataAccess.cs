using MembershipCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Membership_DataAccess
{
    public class JsonFileMemberDataAccess : IMember
    {
        List<Member> members = new List<Member>();
        string filePath = "members.json";
        public JsonFileMemberDataAccess()
        {
            ReadJsonDataFromFile();
        }

        private void ReadJsonDataFromFile()
        {
            string jsonText = File.ReadAllText(filePath);

            members = JsonSerializer.Deserialize<List<Member>>(jsonText,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }
        private void WriteJsonDataToFile()
        {
            string jsonString = JsonSerializer.Serialize(members, new JsonSerializerOptions
            { WriteIndented = true });

            File.WriteAllText(filePath, jsonString);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            WriteJsonDataToFile();
        }

        public bool RemoveMember(string name)
        {
            var member = members.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (member != null)
            {
                members.Remove(member);
                WriteJsonDataToFile();
                return true;
            }
            return false;
        }

        public List<Member> GetAll()
        {
            return members;
        }

        public bool UpdateMember(string oldName, Member updatedMember)
        {
            foreach (var member in members)
            {
                if (member.Name == oldName)
                {
                    member.Name = updatedMember.Name;
                    member.Age = updatedMember.Age;
                    member.Birthdate = updatedMember.Birthdate;
                    member.Address = updatedMember.Address;
                    member.Gmail = updatedMember.Gmail;

                    WriteJsonDataToFile();
                    return true;
                }
            }
            return false;
        }

        public Member GetMember(string name)
        {
            return members.Find(m => m.Name.Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase));
        }
    }
}