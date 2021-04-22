using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.Exceptions
{
    public class IncorrectStockNameException : Exception
    {
        public IncorrectStockNameException(string name) : base($"Name: {name} is not in correct format (Only letters and numbers accepted)") { }
    }
}
