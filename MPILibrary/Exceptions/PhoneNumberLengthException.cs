using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MPILibrary.Exceptions
{
    public class PhoneNumberLengthException : Exception
    {
        public string PhoneNumber { get; set; }

        public PhoneNumberLengthException( string message ) : base(message) { }

        public PhoneNumberLengthException( string message, string phoneNumber ) : base(message)
        {
            PhoneNumber = phoneNumber;
        }
    }
}
