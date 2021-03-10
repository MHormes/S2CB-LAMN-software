using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class EmployeeHandler
    {
        List<Employee> allEmployees;

        List<Employee> GetAllEmployees()
        {
            return allEmployees;
        }

        Employee GetEmployee(int bsn)
        {
            Employee employee = null;
            foreach(Employee e in allEmployees)
            {
                if (e.Bsn == bsn)
                    employee = e;
            }
            return employee;
        }

        //bool ChangeEmployee(int bsn, string email, int phoneNumber, int iceNumber, ICERelation iceRelationship, jobPosition position, DateTime contractEnding, string addInformation)
        //{
        //}

        bool DeleteEmployee(Employee employee)
        {
            int index = -1;
            foreach (Employee e in allEmployees)
            {
                if (e.Bsn == employee.Bsn)
                    index = allEmployees.IndexOf(e);
                    
            }

            if(index != -1)
            {
                allEmployees.RemoveAt(index);
                return true;
            }

            return false;
        }

        bool AddEmployee(string firstName, string secondName, string userName, int bsn, DateTime dateOfBirth, string email, int phoneNumber, int iceNumber, ICERelation iceRelationship, jobPosition position, DateTime contractEnding, string addInformation)
        {
            Employee employee = new Employee(firstName, secondName, bsn, dateOfBirth, phoneNumber, iceNumber, iceRelationship, position, contractEnding, addInformation);
            allEmployees.Add(employee);
            return true;
        }
    }
}
