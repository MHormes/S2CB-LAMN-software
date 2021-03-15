using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DataClasses
{
    class Schedule
    {
        public int Week
        { get; set; }

        public Day Day
        { get; set; }

        public string Employee
        { get; set; }

        public TimeSlot TimeSlot
        { get; set; }

        public Schedule(int week, Day day, string employee, TimeSlot timeSlot)
        {
            Week = week;
            Day = day;
            Employee = employee;
            TimeSlot = timeSlot;
        }
    }
}
