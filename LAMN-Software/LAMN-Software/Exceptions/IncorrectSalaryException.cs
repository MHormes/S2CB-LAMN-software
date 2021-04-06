using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.Exceptions
{
    public class IncorrectSalaryException: Exception
    {
        public IncorrectSalaryException(string salary) : base($"Salary: {salary} is not in correct format (only digits in format 1/1.40 accepted)") { }

    }
}
