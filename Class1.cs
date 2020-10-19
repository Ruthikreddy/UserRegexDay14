using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class User
    {/// <summary>
    /// Intilisation and defining Rules
    /// </summary>
        public string firstName { get; set; }
        private string _regexFirstName = "^[A-Z][a-z]{2,}$";
        public string lastName { get; set; }
        private string _regexLastName = "^[A-Z][a-z]{2,}$";

        public string email { get; set; }
        private string _regexEmail = "^[A-Za-z0-9]+([._+-][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$";
        public string password { get; set; }
        public static string spcl = ".,:;'!@#$%^&*_+=|(){}[?\\";
        private string _regexPassword = "^(?=.*[A-Z])(?=.*[0-9])(?=[A-Za-z0-9]*[-~!@#$%^&*()_+=`,.<>?/][A-Za-z0-9]*$).{8,}$";
        public string mobileNumber { get; set; }
        private string _regexMobileNumber = "^[0-9]{2}[ ][1-9][0-9]{9}$";
        /// <summary>
        /// Validates the first name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns></returns>
        /// <exception cref="UserException">Invalid First Name</exception>
        public bool ValidateFirstName(string firstName) => Regex.IsMatch(firstName, _regexFirstName) ? true : throw new UserException(UserException.error.Invalid_Name, "Invalid First Name");
        /// <summary>
        /// Validates the last name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns></returns>
        /// <exception cref="UserException">Invalid Last Name</exception>
        public bool ValidateLastName(string lastName) => Regex.IsMatch(lastName, _regexLastName) ? true : throw new UserException(UserException.error.Invalid_Name, "Invalid Last Name");
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        /// <exception cref="UserException">Invalid Email</exception>
/        public bool ValidateEmail(string email) => Regex.IsMatch(email, _regexEmail) ? true : throw new UserException(UserException.error.Invalid_Email, "Invalid Email");
        /// <summary>
        /// Validates the password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns></returns>
/        public bool ValidatePassword(string password) => Regex.IsMatch(password, _regexPassword) ? true : throw new UserException(UserException.error.Invalid_Password, "Invalid Password");
        public bool ValidateMobileNumber(string mobileNumber) => Regex.IsMatch(mobileNumber, _regexMobileNumber) ? true : throw new UserException(UserException.error.Invalid_Mobile, "Invalid Mobile Number");

    }
}