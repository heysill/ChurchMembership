using Membership_BL;
using MembershipCommon;

namespace ChurchMembershipForm
{
    internal class Program
    {
        static string[] actions = new string[] { "[1] Add Member", "[2] View Members", "[3] Cancel Membership", "[4] Update Member", "[5] Exit" };
        static BusinessLogic businessLogic = new BusinessLogic();

        static void Main(string[] args)
        {
            Console.WriteLine("SOUTH CITY HOMES CHRISTIAN BIBLE CHURCH");
            Console.WriteLine("Church Membership Form\n");

            while (true)
            {
                DisplayOption();
                Console.Write("Enter Option: ");
                if (!int.TryParse(Console.ReadLine(), out int userAction))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1-4.");
                    continue;
                }
                switch (userAction)
                {
                    case 1:
                        AddMember();
                        break;

                    case 2:
                        ViewMembers();
                        break;

                    case 3:
                        CancelMembership();
                        break;

                    case 4:
                        UpdateMember();
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter between 1 - 5 only");
                        break;
                }
            }
        }


        static void DisplayOption()
        {
            foreach (var action in actions)
            {
                Console.WriteLine(action);
            }
            Console.WriteLine("----------------------------");
        }

        static void AddMember()
        {
            Console.Write("Name: ");
            string Name = Console.ReadLine();

            Console.Write("Age: ");
            string Age = Console.ReadLine();

            Console.Write("Birthdate [YYYY-MM-DD]: ");
            string Birthdate = Console.ReadLine();

            Console.Write("Address: ");
            string Address = Console.ReadLine();

            Console.Write("Gmail: ");
            string Gmail = Console.ReadLine();

            BusinessLogic businessDataLogic = new BusinessLogic();

            businessDataLogic.AddMember(Name, Age, Birthdate, Address, Gmail);
            Console.WriteLine("Successfully Added!\n");
            Console.WriteLine("----------------------------");
        }

        static void ViewMembers()
        {
            var members = businessLogic.GetAllMembers();

            if (members.Count == 0)
            {
                Console.WriteLine("The List Is EMPTY\n");
                return;
            }

            Console.WriteLine("All Members");

            foreach (var member in members)
            {
                string info = $"{member.Name.Trim()} - {member.Age.Trim()} - {member.Birthdate.Trim()} - {member.Address.Trim()} - {member.Gmail.Trim()}";
                Console.WriteLine(info);
            }

            Console.WriteLine("");
            Console.WriteLine("----------------------------");
        }


        static void CancelMembership()
        {
            var members = businessLogic.GetAllMembers();

            if (members.Count == 0)
            {
                Console.WriteLine("The List Is EMPTY\n");
                return;
            }

            Console.Write("Enter name of member to cancel: ");
            string name = Console.ReadLine();

            bool removed = businessLogic.CancelMember(name);

            if (removed)
            {
                Console.WriteLine("Membership Cancelled\n");
            }
            else
            {
                Console.WriteLine("Member not found.\n");
            }
            Console.WriteLine("---------------------");
        }

        static void UpdateMember()
        {
            var members = businessLogic.GetAllMembers();

            if (members.Count == 0)
            {
                Console.WriteLine("The List IS EMPTY\n");
                return;
            }

            Console.Write("Enter the name of the member to update: ");
            string oldName = Console.ReadLine()?.Trim();

            var member = businessLogic.GetMember(oldName);

            if (member == null)
            {
                Console.WriteLine("Member not found.\n");
                return;
            }

            Console.Write($"New Name (current: {member.Name.Trim()}): ");
            string newName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newName)) newName = member.Name.Trim();

            Console.Write($"New Age (current: {member.Age.Trim()}): ");
            string newAge = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newAge)) newAge = member.Age.Trim();

            Console.Write($"New Birthdate (current: {member.Birthdate.Trim()}): ");
            string newBirthdate = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newBirthdate)) newBirthdate = member.Birthdate.Trim();

            Console.Write($"New Address (current: {member.Address.Trim()}): ");
            string newAddress = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newAddress)) newAddress = member.Address.Trim();

            Console.Write($"New Gmail (current: {member.Gmail.Trim()}): ");
            string newGmail = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newGmail)) newGmail = member.Gmail.Trim();


            var updatedMember = new Member
            {
                Name = newName,
                Age = newAge,
                Birthdate = newBirthdate,
                Address = newAddress,
                Gmail = newGmail
            };

            bool updated = businessLogic.UpdateMember(oldName, updatedMember);

            Console.WriteLine(updated ? "Member successfully updated.\n" : "Update failed.\n");
            Console.WriteLine("---------------------");
        }



    }
}

