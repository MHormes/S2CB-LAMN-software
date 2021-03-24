using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    class IncorrectNameException : Exception
    {
        public IncorrectNameException(string name) : base($"{name} is not in correct format (Only letters accepted)") { }
    }
}
