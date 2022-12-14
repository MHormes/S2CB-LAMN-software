using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace LAMN_Software
{
    public class EmployeeHandler
    {
        List<Employee> allEmployees;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";


        //method to get all the stock items from the DB
        public Exception GetAllEmployeesFromDB()
        {
            allEmployees = new List<Employee>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM employee";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ICERelation ice = ICERelation.OTHER;
                        JobPosition position = JobPosition.MANAGER;

                        string relationReturn = dr[8].ToString();
                        string positionReturn = dr[9].ToString();

                        if (relationReturn == "PARTNER")
                            ice = ICERelation.PARTNER;
                        else if (relationReturn == "FATHER")
                            ice = ICERelation.FATHER;
                        else if (relationReturn == "MOTHER")
                            ice = ICERelation.MOTHER;
                        else if (relationReturn == "BROTHER")
                            ice = ICERelation.BROTHER;
                        else if (relationReturn == "SISTER")
                            ice = ICERelation.SISTER;
                        else if (relationReturn == "UNCLE")
                            ice = ICERelation.UNCLE;
                        else if (relationReturn == "AUNT")
                            ice = ICERelation.AUNT;
                        else if (relationReturn == "COUSIN")
                            ice = ICERelation.COUSIN;
                        else if (relationReturn == "FRIEND")
                            ice = ICERelation.FRIEND;
                        else if (relationReturn == "OTHER")
                            ice = ICERelation.OTHER;

                        if (positionReturn == "MANAGER")
                            position = JobPosition.MANAGER;
                        else if (positionReturn == "HR")
                            position = JobPosition.HR;
                        else if (positionReturn == "SALES")
                            position = JobPosition.SALES;
                        else if (positionReturn == "DEPOT")
                            position = JobPosition.DEPOT;
                        else if (positionReturn == "SECURITY")
                            position = JobPosition.SECURITY;

                        allEmployees.Add(new Employee(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToDateTime(dr[4]), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), ice, position, dr[10].ToString(), dr[11].ToString(),Convert.ToDouble(dr[12]),Convert.ToDateTime(dr[13]), Convert.ToDateTime(dr[14]), dr[15].ToString(), dr[16].ToString(), dr[17].ToString(), dr[18].ToString(), Convert.ToInt32(dr[19]), dr[20].ToString()));
                    }
                }
                return null;
            }

            catch (Exception ex)
            {
                return ex;
            }
        }

        //method to get a specific employee from the list
        public Employee GetEmployee(string bsn)
        {
            foreach (Employee employee in allEmployees)
            {
                if (employee.Bsn == bsn)
                {
                    return employee;
                }
            }
            return null;
        }

        public Employee GetEmployeeByName(string FullName)
        {
            foreach(Employee employee in allEmployees)
            {
                if(employee.GetFullName() == FullName)
                {
                    return employee;
                }
            }
            return null;
        }

        
        public List<Employee> GetManagers()
        {
            List<Employee> managers = new List<Employee>();
            foreach(Employee e in allEmployees)
            {
                if(e.Position == JobPosition.MANAGER)
                {
                    managers.Add(e);
                }
            }
            return managers;
        }

        public List<Employee> GetAllEmployees()
        {
           return this.allEmployees;
        }

        public List<Employee> GetEmployeesWIthRole(JobPosition position)
        {
            List<Employee> empToReturn = new List<Employee>();
            foreach(Employee emp in allEmployees)
            {
                if(emp.Position == position)
                {
                    empToReturn.Add(emp);
                }
            }
            return empToReturn;
        }

        //method for adding new employee. AFTER CALLING THIS METHOD CALL GETALLSTOCKFROMDB!!!
        public Exception AddEmployee(string firstName, string secondName, string userName, string bsn, DateTime dateOfBirth, string email, string phoneNumber, string iceNumber, string iceRelationship, string position, string addInformation, string quittingReason, double salaryPerHour, DateTime startingDate, DateTime endingDate, string contractType, string gender, string degree, string nationality, int contractHours, string adress) 
        {
            try
            {
                if (!Regex.IsMatch(bsn, @"^[0-9]{9}$"))
                {
                    throw new IncorrectBSNException(bsn);
                }

                if (!Regex.IsMatch(phoneNumber, @"^[0-9]{10}$"))
                {
                    throw new IncorrectPhoneNumberException(phoneNumber);
                }

                if (!Regex.IsMatch(iceNumber, @"^[0-9]{10}$"))
                {
                    throw new IncorrectPhoneNumberException(iceNumber);
                }

                if (!Regex.IsMatch(firstName, @"^[A-z]*$"))
                {
                    throw new IncorrectNameException(firstName);
                }

                if (!Regex.IsMatch(secondName, @"^[A-z]*$"))
                {
                    throw new IncorrectNameException(secondName);
                }

                if (phoneNumber == "")
                {
                    throw new IncorrectValueExeption();
                }
                if (contractType == "")
                {
                    throw new IncorrectValueExeption();
                }

                if (gender == "")
                {
                    throw new IncorrectValueExeption();
                }

                if (nationality == "")
                {
                    throw new IncorrectValueExeption();
                }

                if (contractHours == 0)
                {
                    throw new IncorrectValueExeption();
                }
                if (adress == "")
                {
                    throw new IncorrectValueExeption();
                }
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO employee(FirstName, SecondName, UserName, BSN, DateOfBirth, PhoneNumber, Email, ICEnumber, ICErelation, Position, AddInformation, QuittingReason, SalaryPerHour, contractStartingDate, contractEndingDate, contractType, Gender, Degree, Nationality, ContractHours, Adress) VALUES (@firstName, @secondName, @userName, @bsn, @dateOfBirth, @phoneNumber, @email, @iceNumber, @iceRelation, @position, @addInformation, @quittingReason, @salaryPerHour, @startingDate, @endingDate, @contractType, @gender, @degree, @nationality,@contractHours,@adress);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@secondName", secondName);
                    cmd.Parameters.AddWithValue("@userName", userName);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@iceNumber", iceNumber);
                    cmd.Parameters.AddWithValue("@iceRelation", iceRelationship);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@salaryPerHour", salaryPerHour);
                   

                    if (!string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInformation", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addInformation", null); }

                    if (!string.IsNullOrWhiteSpace(quittingReason))
                    { cmd.Parameters.AddWithValue("@quittingReason", quittingReason); }
                    else { cmd.Parameters.AddWithValue("@quittingReason", null); }

                    cmd.Parameters.AddWithValue("@startingDate", startingDate);
                    cmd.Parameters.AddWithValue("@endingDate", endingDate);
                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@nationality", nationality);
                    cmd.Parameters.AddWithValue("@contractHours", contractHours);
                    cmd.Parameters.AddWithValue("@adress", adress);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }


        //method for change an employee. AFTER CALLING THIS METHOD CALL GETALLSTOCKFROMDB!!!
        public Exception ChangeEmployee(string firstName, string secondName, string bsn, DateTime dateOfBirth, string phoneNumber, string iceNumber, string iceRelationship, string position, string addInformation, double salaryPerHour, DateTime startingDate, DateTime endingDate, string contractType, string gender, string degree, string nationality, int contractHours, string adress)
        {
            if (!Regex.IsMatch(bsn, @"^[0-9]{9}$"))
            {
                throw new IncorrectBSNException(bsn);
            }

            if (!Regex.IsMatch(phoneNumber, @"^[0-9]{10}$"))
            {
                throw new IncorrectPhoneNumberException(phoneNumber);
            }

            if (!Regex.IsMatch(iceNumber, @"^[0-9]{10}$"))
            {
                throw new IncorrectPhoneNumberException(iceNumber);
            }

            if (!Regex.IsMatch(firstName, @"^[A-z]*$"))
            {
                throw new IncorrectNameException(firstName);
            }

            if (!Regex.IsMatch(secondName, @"^[A-z]*$"))
            {
                throw new IncorrectNameException(secondName);
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE employee SET FirstName=@firstName, SecondName=@secondName, BSN=@bsn, DateOfBirth=@dateOfBirth, PhoneNumber=@phoneNumber, IceNumber=@iceNumber, IceRelation=@iceRelation, Position=@position, AddInformation=@addInformation, SalaryPerHour=@salaryPerHour, contractStartingDate=@startingDate, contractEndingDate=@endingDate, ContractType=@contractType, Gender=@gender, Degree=@degree, Nationality=@nationality, ContractHours=@contractHours, Adress=@adress WHERE BSN=@bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@secondName", secondName);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@iceNumber", iceNumber);
                    cmd.Parameters.AddWithValue("@iceRelation", iceRelationship);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@salaryPerHour", salaryPerHour);

                    if (!string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInformation", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addInformation", null); }

                    cmd.Parameters.AddWithValue("@startingDate", startingDate);
                    cmd.Parameters.AddWithValue("@endingDate", endingDate);
                    cmd.Parameters.AddWithValue("@contractType", contractType);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@degree", degree);
                    cmd.Parameters.AddWithValue("@nationality", nationality);
                    cmd.Parameters.AddWithValue("@contractHours", contractHours);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }



        public Exception TerminateEmployee(Employee e, string quittingReason)
        {
            string bsn = e.Bsn;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE employee SET  QuittingReason=@quittingReason WHERE BSN=@bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@quittingReason", quittingReason);
                    cmd.Parameters.AddWithValue("@bsn", bsn);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }


        public Exception ApproveEmployeeChange(string bsn, string firstName, string secondName, string phoneNumber, string iceNumber, string iceRelationship, string address)
        {
            if (!Regex.IsMatch(bsn, @"^[0-9]{9}$"))
            {
                throw new IncorrectBSNException(bsn);
            }

            if (!Regex.IsMatch(phoneNumber, @"^[0-9]{10}$"))
            {
                throw new IncorrectPhoneNumberException(phoneNumber);
            }

            if (!Regex.IsMatch(iceNumber, @"^[0-9]{10}$"))
            {
                throw new IncorrectPhoneNumberException(iceNumber);
            }

            if (!Regex.IsMatch(firstName, @"^[A-z]*$"))
            {
                throw new IncorrectNameException(firstName);
            }

            if (!Regex.IsMatch(secondName, @"^[A-z]*$"))
            {
                throw new IncorrectNameException(secondName);
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE employee SET FirstName=@firstName, SecondName=@secondName, BSN=@bsn, PhoneNumber=@phoneNumber, IceNumber=@iceNumber, IceRelation=@iceRelation, Adress=@address  WHERE BSN=@bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@secondName", secondName);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@iceNumber", iceNumber);
                    cmd.Parameters.AddWithValue("@iceRelation", iceRelationship);
                    cmd.Parameters.AddWithValue("@address", address);


                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }


    }
}
