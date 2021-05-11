using LAMN_Software.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMN_Software
{
    public partial class ScheduleCreateAddEmployee : Form
    {
        ScheduleHandler Shandler;
        EmployeeHandler EmpHandler;
        int weekNmr;
        Day day;
        TimeSlot timeSlot;
        List<Schedule> specificShift;
        List<Employee> allEmployees;

        public delegate void RefreshingSchedulePage(object sender, EventArgs e);
        public event RefreshingSchedulePage RefreshPageEvent;

        public ScheduleCreateAddEmployee(EmployeeHandler givenEmpHandler, ScheduleHandler givenSchHandler, int givenWeekNmr, Day selectedDay, TimeSlot chosenTime)
        {
            InitializeComponent();
            Shandler = givenSchHandler;
            EmpHandler = givenEmpHandler;
            weekNmr = givenWeekNmr;
            day = selectedDay;
            timeSlot = chosenTime;
            lblShiftInformation.Text = $"Assigning employees to the {day} {timeSlot} shift of week {weekNmr}";
            GetShift();
        }

        //method for getting the specific shift from the db
        public void GetShift()
        {
            if (Shandler.GetSpecificShiftFromDB(weekNmr, day, timeSlot) == null)
            {
                specificShift = new List<Schedule>();
                specificShift = Shandler.GetSpecificShift();
                allEmployees = new List<Employee>();
                allEmployees = EmpHandler.GetAllEmployees();
                FillListbox();
            }
            else
            {
                MessageBox.Show(Shandler.GetSpecificShiftFromDB(weekNmr, day, timeSlot).Message);
            }

        }

        //method for filling the listboxes
        public void FillListbox()
        {
            foreach (Employee employee in allEmployees)
            {
                foreach (Schedule schedule in specificShift)
                {
                    if (employee.Bsn == schedule.EmployeeBSN)
                    {
                        lbxScheduleCreatePlanned.Items.Add(employee);
                    }
                }
                if (!lbxScheduleCreatePlanned.Items.Contains(employee))
                {
                    lbxScheduleCreateAvailable.Items.Add(employee);
                }
            }
        }

        //onclick for back to schedule page button
        private void btnScheduleCreateDone_Click(object sender, EventArgs e)
        {
            try
            {
                Shandler.DeleteSpecificShift(weekNmr, day, timeSlot);

                foreach (var v in lbxScheduleCreatePlanned.Items)
                {
                    Employee emp = (Employee)v;
                    Shandler.SaveCurrentWeek(weekNmr, day, emp.Bsn, timeSlot.ToString());
                }

                if(RefreshPageEvent != null)
                {
                    RefreshPageEvent(sender, e);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //onclick for remove from schedule button
        private void btnScheduleCreateRemove_Click(object sender, EventArgs e)
        {
            if(lbxScheduleCreatePlanned.SelectedIndex != -1)
            {
                Employee emp = (Employee)lbxScheduleCreatePlanned.SelectedItem;
                lbxScheduleCreatePlanned.Items.Remove(emp);
                lbxScheduleCreateAvailable.Items.Add(emp);
            }
            else
            {
                MessageBox.Show("Please select an employee before clicking the button");
            }
        }

        //onclick for adding an employee to the schedule
        private void btnScheduleCreateAdd_Click(object sender, EventArgs e)
        {
            if (lbxScheduleCreateAvailable.SelectedIndex != -1)
            {
                Employee emp = (Employee)lbxScheduleCreateAvailable.SelectedItem;
                lbxScheduleCreateAvailable.Items.Remove(emp);
                lbxScheduleCreatePlanned.Items.Add(emp);
            }
            else
            {
                MessageBox.Show("Please select an employee before clicking the button");
            }
        }
    }
}
