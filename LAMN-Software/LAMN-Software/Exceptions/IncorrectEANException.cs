using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    class IncorrectEANException: Exception
    {
        public IncorrectEANException(string ean): base($"{ean} is not in correct format (only 13 digit numbers are accepted)")
        {

        }
    }
}
