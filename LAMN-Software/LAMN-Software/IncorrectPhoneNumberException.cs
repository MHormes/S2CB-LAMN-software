using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    class IncorrectPhoneNumberException : Exception
    {
        public IncorrectPhoneNumberException(string bsn) : base($"{bsn} is not in correct format (123456789)") { }
    }
}
