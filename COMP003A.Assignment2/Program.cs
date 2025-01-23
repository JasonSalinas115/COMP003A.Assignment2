namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            int userAge;
            double itemPrice;
            bool isStudent;

            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            Console.Write("How old are you? ");
            userAge = int.Parse(Console.ReadLine());

            Console.Write("What is the price of the item you're interested in?");
            itemPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false)");
            isStudent = bool.Parse(Console.ReadLine());

            Console.WriteLine($"\nHello, {firstName} {lastName}");
        }
    }
}