using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class IncorrectPhoneNumberException : Exception
    {
        public IncorrectPhoneNumberException(string phone) : base($"Phonenumber: {phone} is not in correct format (only 10 digit numbers accepted)") { }
    }
}
