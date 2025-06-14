using Membership_BL;
using MembershipCommon;

namespace ChurchMembershipForm
{
    internal class Program
    {
        static string[] actions = new string[] { "[1] Add Member", "[2] View Members", "[3] Cancel Membership", "[4] Exit" };
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
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter between 1 - 3 only");
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
                string info = $"{member.Name} - {member.Age} - {member.Birthdate} - {member.Address} - {member.Gmail}";

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

    }
}