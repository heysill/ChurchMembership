using Microsoft.Data.SqlClient;
using MembershipCommon;

namespace Membership_DataAccess
{
    public class DBMembershipDataAccess : IMember
    {
        private static string connectionString =
            "Data Source=DESKTOP-H4NQ51A\\SQLEXPRESS01;Initial Catalog=Membership;Integrated Security=True;TrustServerCertificate=True;";

        private static SqlConnection sqlConnection;

        public DBMembershipDataAccess()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void AddMember(Member member)
        {
            var insertStatement = "INSERT INTO Members (Name, Age, BirthDate, Address, Gmail) VALUES (@Name, @Age, @BirthDate, @Address, @Gmail)";

            SqlCommand command = new SqlCommand(insertStatement, sqlConnection);
            command.Parameters.AddWithValue("@Name", member.Name);
            command.Parameters.AddWithValue("@Age", member.Age);
            command.Parameters.AddWithValue("@BirthDate", member.Birthdate);
            command.Parameters.AddWithValue("@Address", member.Address);
            command.Parameters.AddWithValue("@Gmail", member.Gmail);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public Member GetMember(string name)
        {
            var selectStatement = "SELECT Name, Age, Birthdate, Address, Gmail FROM Members WHERE Name = @Name";
            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);
            command.Parameters.AddWithValue("@Name", name);

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            Member member = null;
            if (reader.Read())
            {
                member = new Member
                {
                    Name = reader["Name"].ToString(),
                    Age = reader["Age"].ToString(),
                    Birthdate = reader["Birthdate"].ToString(),
                    Address = reader["Address"].ToString(),
                    Gmail = reader["Gmail"].ToString()
                };
            }

            sqlConnection.Close();
            return member;
        }

        public List<Member> GetAll()
        {
            var selectStatement = "SELECT Name, Age, Birthdate, Address, Gmail FROM Members";
            SqlCommand command = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            SqlDataReader reader = command.ExecuteReader();

            List<Member> members = new List<Member>();
            while (reader.Read())
            {
                members.Add(new Member
                {
                    Name = reader["Name"].ToString(),
                    Age = reader["Age"].ToString(),
                    Birthdate =reader["Birthdate"].ToString(),
                    Address = reader["Address"].ToString(),
                    Gmail = reader["Gmail"].ToString()
                });
            }

            sqlConnection.Close();
            return members;
        }

        public bool RemoveMember(string name)
        {
            var deleteStatement = "DELETE FROM Members WHERE Name = @Name";
            SqlCommand command = new SqlCommand(deleteStatement, sqlConnection);
            command.Parameters.AddWithValue("@Name", name);

            sqlConnection.Open();
            int affectedRows = command.ExecuteNonQuery();
            sqlConnection.Close();

            return affectedRows > 0;
        }

        public bool UpdateMember(string oldName, Member updatedMember)
        {
            var updateStatement = @"
                UPDATE Members 
                SET Name = @NewName, 
                    Age = @Age, 
                    Birthdate = @Birthdate, 
                    Address = @Address, 
                    Gmail = @Gmail 
                WHERE LTRIM(RTRIM(Name)) COLLATE SQL_Latin1_General_CP1_CI_AS = LTRIM(RTRIM(@OldName))";

            SqlCommand command = new SqlCommand(updateStatement, sqlConnection);
            command.Parameters.AddWithValue("@NewName", updatedMember.Name);
            command.Parameters.AddWithValue("@Age", updatedMember.Age);
            command.Parameters.AddWithValue("@Birthdate", updatedMember.Birthdate);
            command.Parameters.AddWithValue("@Address", updatedMember.Address);
            command.Parameters.AddWithValue("@Gmail", updatedMember.Gmail);
            command.Parameters.AddWithValue("@OldName", oldName.Trim());

            sqlConnection.Open();
            int affectedRows = command.ExecuteNonQuery();
            sqlConnection.Close();

            return affectedRows > 0;
        }


    }


}
