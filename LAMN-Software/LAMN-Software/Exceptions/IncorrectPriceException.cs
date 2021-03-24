using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.Exceptions
{
    class IncorrectPriceException : Exception
    {
        public IncorrectPriceException(string price) : base($"{price} is not in correct format (1/ 1.40)") { }
    }
}
