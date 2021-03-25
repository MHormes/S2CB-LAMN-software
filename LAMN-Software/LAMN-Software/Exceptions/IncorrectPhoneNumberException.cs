using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class IncorrectPhoneNumberException : Exception
    {
        public IncorrectPhoneNumberException(string bsn) : base($"{bsn} is not in correct format (1234567891)") { }
    }
}
