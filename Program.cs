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
                    throw new InvalidUserNameException("Invalid user name entered");
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
                    throw new InvalidUserNameException("Invalid  name entered");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                Email = Console.ReadLine();
                Pattern = "^[a-zA-Z]+([.+_-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})?$";
                string[] sampleEmail = {"abc@yahoo.com","abc-100@yahoo.com","abc.100@yahoo.com","abc111@abc.com","abc-100@abc.net","abc.100@abc.com.au",
                                    "abc@1.com","abc@gmail.com.com","abc+100@gmail.com","Abc","abc@.com.my" ,"abc123@gmail.1a","abc123@.com","abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc..2002@gmail.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a","abc@gmail.com.aa.au"};
                Console.WriteLine("\n\nThe valid sample emails are :");
                foreach (string sample in sampleEmail)
                {
                    if (Regex.IsMatch(sample,Pattern))
                        Console.WriteLine(sample);
                }
                    Regex regex = new Regex(Pattern);
                if (regex.IsMatch(Email))
                {
                    Console.WriteLine("Valid Email-Id");
                    break;
                }
                else
                {
                    throw new InvalidEmailException("Invalid Email entered");
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
                    throw new InvalidPhnNoException("Invalid Phone Number entered");
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
                    throw new InvalidPasswordException("Invalid Password entered");
                }
            }
        }
    }
}