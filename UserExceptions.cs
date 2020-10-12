using System;
using System.Collections.Generic;
using System.Text;

namespace RegexExp
{
    class InvalidUserNameException : Exception
    {
        public InvalidUserNameException(string message) : base(message)
        {

        }
    }
    class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message)
        {

        }
    }
    class InvalidPhnNoException : Exception
    {
        public InvalidPhnNoException(string message) : base(message)
        {

        }
    }
    class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }
}
