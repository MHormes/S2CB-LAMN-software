using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class SchedulesMinimum
    {
        public Day Day
        { get; set; }

        public TimeSlot TimeSlot
        { get; set; }

        public int MinimumPeople
        { get; set; }

        public JobPosition JobPosition
        { get; set; }

        public SchedulesMinimum(Day day, TimeSlot timeSlot, int minimumPeople, JobPosition jobPosition)
        {
            Day = day;
            TimeSlot = timeSlot;
            MinimumPeople = minimumPeople;
            JobPosition = jobPosition;
        }
    }
}
