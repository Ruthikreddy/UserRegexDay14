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
        public Boolean FirstNameRegex()
        {
            while (true)
            {
                fname = "Ruthik";
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
        public Boolean LastNameRegex()
        {
            while (true)
            {
                lname = "Reddy";
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

        public Boolean Email_Id()
        {
            while (true)
            {
                email = "something@gmail.com";
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
        public Boolean PhoneNumber()
        {
            while (true)
            {
                phoneNo = "91 1234567890 ";
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

        public Boolean Password()
        {
            while (true)
            {
                password = "Ruthik992*";
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