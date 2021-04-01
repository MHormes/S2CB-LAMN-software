using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class IncorrectQuantityException : Exception
    {
        public IncorrectQuantityException(string quantity) : base($"{quantity} is not in correct format (Letters not accepted)") { }
    }
}
