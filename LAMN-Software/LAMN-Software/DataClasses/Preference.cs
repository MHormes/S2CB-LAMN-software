using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DataClasses
{
    public class Preference
    {
        public Day Day
        { get; set; }

        public string EmployeeBSN
        { get; set; }

        public TimeSlot TimeSlot
        { get; set; }

        public Preference(Day day, string employee, TimeSlot timeSlot)
        {
            Day = day;
            EmployeeBSN = employee;
            TimeSlot = timeSlot;
        }

    }
}
