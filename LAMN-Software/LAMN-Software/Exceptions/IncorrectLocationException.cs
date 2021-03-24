using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    class IncorrectLocationException : Exception
    {
        public IncorrectLocationException(string location) : base($"{location} is not in correct format (AB-12)") { }
    }
}
