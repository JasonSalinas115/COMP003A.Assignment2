/*
 Author: Jason Salinas
 Course: COMP-003A
 Faculty: Jonathan Cruz
 Purpose: Discount Calculator
*/
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

            Console.Write("What is the price of the item you're interested in? ");
            itemPrice = double.Parse(Console.ReadLine());

            Console.Write("Are you a student? (true/false) ");
            isStudent = bool.Parse(Console.ReadLine());

            int futureAge = userAge + 5;
            double ifStudent = itemPrice * 0.9;
            double ifSenior = itemPrice * 0.8;

            Console.WriteLine($"\nHello, {firstName} {lastName}!");
            Console.WriteLine($"Your current age is {userAge}");
            Console.WriteLine($"In 5 years, you will be {futureAge}");
            Console.WriteLine($"The original price of the item is {itemPrice}");
            Console.WriteLine($"As a student, your discounted price of the item is {ifStudent}");
            Console.WriteLine($"As a senior, your discounted price of the item is {ifSenior}");
        }
    }
}