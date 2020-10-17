using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UserRegex

{
    public class Program

    {
        public static string fname, lname, email, phoneNo, password;
        public static string name_pattern, email_pattern, phone_pattern, password_pattern;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");

        }
        public Boolean FirstNameRegex(string fname)
        {
            while (true)
            {
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                if (regex.IsMatch(fname))
                {
                    Console.WriteLine("Valid First Name");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid First Name");
                    return false;
                }
            }
        }
        public Boolean LastNameRegex(string lname)
        {
            while (true)
            {
                name_pattern = @"^[A-Z]{1}[a-z]{2,}";
                Regex regex = new Regex(name_pattern);
                if (regex.IsMatch(lname))
                {
                    Console.WriteLine("Valid Last Name");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Last Name");
                    return false;
                }
            }
        }

        public Boolean Email_Id(string email)
        {
            while (true)
            {
                Console.WriteLine("Enter your Email-id: ");
                email_pattern = @"^[A-Za-z]+[.+-]?[a-z]*[@][A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2})?$";
                Regex regex = new Regex(email_pattern);
                if (regex.IsMatch(email))
                {
                    Console.WriteLine("Valid Email-Id: " + email);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Email-Id");
                    return false;
                }
            }
        }
        public Boolean PhoneNumber(string phoneNo)
        {
            while (true)
            {
                phone_pattern = @"^[0-9]{2}[ ][0-9]{10}$";
                Regex regex = new Regex(phone_pattern);
                if (regex.IsMatch(phoneNo))
                {
                    Console.WriteLine("Valid Phone Number: " + phoneNo);
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid Phone Number");
                    return false;
                }
            }
        }

        public Boolean Password(string password)
        {
            while (true)
            {
                password_pattern = @"(?=.*[A-Z])(?=.*\w)(?=.*\d)(?=[^@$!%*^#?&]*[@$!%*^#?&][^@$!%^*#?&]*$).{8,}$";
                Regex regex = new Regex(password_pattern);
                if (regex.IsMatch(password))
                {
                    Console.WriteLine("Password set Successfully");
                    return true;
                }
                else
                {
                    Console.WriteLine("Enter password again");
                    return false;
                }
            }
        }
    }
}