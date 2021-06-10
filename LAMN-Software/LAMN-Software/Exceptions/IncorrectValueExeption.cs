using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class IncorrectValueExeption : Exception
    {
        public IncorrectValueExeption(): base($"Required Field is Empty") { }
    }
}
