using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class IncorrectBSNException: Exception
    {
        public IncorrectBSNException(string bsn): base($"{bsn} is not in correct format (only 9 digit numbers accepted)") { }
    }
}
