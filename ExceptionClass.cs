using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLogical
{
    public class ExceptionClass
    {
    }
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message) { }
    }
    public class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message) { }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }

    public class InvalidCityNameException : Exception
    {
        public InvalidCityNameException(string message) : base(message) { }
    }

    public class InvalidStateNameException : Exception
    {
        public InvalidStateNameException(string message) : base(message) { }
    }

    public class InvalidZipException : Exception
    {
        public InvalidZipException(string message) : base(message) { }
    }
}
