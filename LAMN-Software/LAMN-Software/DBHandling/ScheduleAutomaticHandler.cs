using LAMN_Software.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DBHandling
{
    public class ScheduleAutomaticHandler
    {
        int peopleCounter;
        List<Employee> employeeList;
        List<SchedulesMinimum> shiftList;
        List<Schedule> scheduleList;



        public List<Schedule> CreateAutomaticSchedule2(int weekNmr, List<SchedulesMinimum> shiftList, List<Employee> employeeList)
        {
            this.shiftList = shiftList;             // list of all shifts
            this.employeeList = employeeList;       // list of all employees
            scheduleList = new List<Schedule>();    // list of schedules for chosen week - need a list of schedules from the database
            this.employeeList.Sort();

            //for statement to loop through the shifts
            for (int i = 0; i < shiftList.Count(); i++)
            {



            }






                return this.scheduleList;
        }













        public List<Schedule> CreateAutomaticSchedule(int weekNmr, List<SchedulesMinimum> shiftList, List<Employee> employeeList)
        {
            this.shiftList = shiftList;
            this.employeeList = employeeList;
            scheduleList = new List<Schedule>();
            this.employeeList.Sort();

            

            //for statement to loop through the shifts
            for (int i = 0; i < shiftList.Count(); i++)
            {
                peopleCounter = 0;

                //check if minimum people has been met
                if (shiftList[i].MinimumPeople == peopleCounter)
                {
                    continue;
                }

                //take an employee and check if present in the scheduleList
                for (int a = 0; a < employeeList.Count(); a++)
                {
                    if (EmployeeAvailableForThisDay(employeeList[a], shiftList[i]))
                    {
                        scheduleList.Add(new Schedule(weekNmr, shiftList[i].Day, employeeList[a].Bsn, shiftList[i].TimeSlot));
                        peopleCounter++;
                        if (shiftList[i].MinimumPeople == peopleCounter)
                        {
                            break;
                        }
                    }
                }
            }
            return this.scheduleList;
        }

        //method to see if emp is already scheduled 
        private bool EmployeeAvailableForThisDay(Employee emp, SchedulesMinimum minSch)
        {
            foreach (Schedule sch in scheduleList)
            {
                //check if the same day, and if the bsn is present
                if (sch.Day == minSch.Day && sch.EmployeeBSN == emp.Bsn)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
