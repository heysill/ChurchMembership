﻿using MembershipCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Membership_DataAccess
{
    public class TextFileMemberDataAccess : IMember
    {
        List<Member> members = new List<Member>();
        string filePath = "members.txt";
        public TextFileMemberDataAccess()
        {
            GetDataFromFile();
        }
        private void GetDataFromFile()
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split('|');

                members.Add(new Member
                {
                    Name = parts[0],
                    Age = parts[1],
                    Birthdate = parts[2],
                    Address =parts[3],
                    Gmail = parts[4],
                });
            }
        }
        private void WriteDataToFile()
        {
            var lines = new string[members.Count];

            for (int i = 0; i < members.Count; i++)
            {
                lines[i] = $"{members[i].Name}|{members[i].Age}|{members[i].Birthdate}|{members[i].Address}|{members[i].Gmail}";
            }

            File.WriteAllLines(filePath, lines);
        }
        public void AddMember(Member member)
        {

            members.Add(member);
            WriteDataToFile();
        }

        public bool RemoveMember(string name)
        {

            var member = members.Find(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (member != null)
            {
                members.Remove(member);
                WriteDataToFile();
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

                    WriteDataToFile();
                    return true;
                }
            }
            return false;
        }

        public Member GetMember(string name)
        {
            return members.FirstOrDefault(m => m.Name.Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase));
        }

    }
}