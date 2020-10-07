using System;
using System.Text.RegularExpressions;

namespace RegexExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program ");
            string FirstName, LastName, Email, PhoneNo, Password;
            String Pattern;
            while (true)
            {
                Pattern = @"([A-Z]+)[a-zA-Z]{2,}";
                Console.WriteLine("Enter your First Name with First letter in Capitals ");
                FirstName = Console.ReadLine();
                Regex regex = new Regex(Pattern);
                if (regex.IsMatch(FirstName))
                {
                    Console.WriteLine("Valid First Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                }
            }
            while (true)
            {
                Pattern = @"([A-Z]+)[a-zA-Z]{2,}";
                Console.WriteLine("Enter your Last Name with First letter in Capitals ");
                LastName = Console.ReadLine();
                Regex regex = new Regex(Pattern);
                if (regex.IsMatch(LastName))
                {
                    Console.WriteLine("Valid Last Name");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                Email = Console.ReadLine();
                Pattern = "^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
                Regex regex = new Regex(Pattern);
                if (regex.IsMatch(Email))
                {
                    Console.WriteLine("Valid Email-Id");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Email-Id");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter the Valid Phone Number: ");
                PhoneNo = Console.ReadLine();
                Pattern = "^[0-9]{2}[ ][0-9]{10}$";
                Regex regex = new Regex(Pattern);
                if (regex.IsMatch(PhoneNo))
                {
                    Console.WriteLine("Valid Phone Number: " + PhoneNo);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                }
            }
            while (true)
            {
                Console.WriteLine("Set a password: ");
                Password = Console.ReadLine();
                Pattern = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                Regex regex = new Regex(Pattern);
                if (regex.IsMatch(Password))
                {
                    Console.WriteLine("Please enter strong password");
                    break;
                }
                else
                {
                    Console.WriteLine("Enter password again with minimum 8 Characters with one capital letter");
                }
            }
        }
    }
}