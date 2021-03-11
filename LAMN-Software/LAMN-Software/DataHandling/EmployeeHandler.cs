using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace LAMN_Software
{
    public class EmployeeHandler
    {

        List<Employee> allEmployees;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";


        //method to get all employees from the database
        public Exception GetAllEmployees()
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
                        allEmployees.Add(new Employee(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), Convert.ToDateTime(dr[4]), Convert.ToInt32(dr[5]), dr[6].ToString(), Convert.ToInt32(dr[7]), (ICERelation)Enum.Parse(typeof(ICERelation), dr[8].ToString()), (JobPosition)Enum.Parse(typeof(JobPosition), dr[9].ToString()), Convert.ToDateTime(dr[10]), dr[11].ToString(), dr[12].ToString()));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        //method to change properties of an employee in the database
        public Exception ChangeEmployee(int bsn, int phoneNumber, string email, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE employee SET PhoneNumber=@phoneNumber, Email=@email, ICErelation=@iceRelationship, Position=@position, ContractEnding=@contractEnding, AddInformation=@addInformation WHERE BSN=@bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@iceRelationship", iceRelationship);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.Parameters.AddWithValue("@contractEnding", contractEnding);
                    cmd.Parameters.AddWithValue("@addInf", addInformation);
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

        //method to delete an employee from the database
        public Exception DeleteEmployee(Employee employee)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM employee WHERE BSN = @bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@bsn", employee.Bsn);

                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        //method to add new employees to the database
        public Exception AddEmployee(string firstName, string secondName, string username, int bsn, DateTime dateOfBirth, int phoneNumber, string email, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation, string quittingReason)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO employee(FirstName, SecondName, UserName, BSN, DateOfBirth, PhoneNumber, Email, ICENumber, ICErelation, Position, ContractEnding, AddInformation, QuittingReason) VALUES (@firstName, @secondName, @username, @bsn, @dateOfBirth, @phoneNumber, @email, @iceNumber, @iceRelationship, @position, @contractEnding, @addInformation, @quittingReason);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@secondName", secondName);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@bsn", bsn);
                    cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@iceNumber", iceNumber);
                    cmd.Parameters.AddWithValue("@iceRelationship", iceRelationship);
                    cmd.Parameters.AddWithValue("@position", position);
                    if (contractEnding != null)
                    {
                        cmd.Parameters.AddWithValue("@contractEnding", contractEnding);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@contractEnding", "");
                    }
                    if (addInformation != "")
                    {
                        cmd.Parameters.AddWithValue("@addInformation", addInformation);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@addInformation", "");
                    }
                    if (quittingReason != "")
                    {
                        cmd.Parameters.AddWithValue("@quittingReason", quittingReason);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@quittingReason", "");
                    }
                    
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



        //List<Employee> GetAllEmployees()
        //{
        //    return allEmployees;
        //}

        //Employee GetEmployee(int bsn)
        //{
        //    Employee employee = null;
        //    foreach (Employee e in allEmployees)
        //    {
        //        if (e.Bsn == bsn)
        //            employee = e;
        //    }
        //    return employee;
        //}


        //bool DeleteEmployee(Employee employee)
        //{
        //    int index = -1;
        //    foreach (Employee e in allEmployees)
        //    {
        //        if (e.Bsn == employee.Bsn)
        //            index = allEmployees.IndexOf(e);

        //    }

        //    if (index != -1)
        //    {
        //        allEmployees.RemoveAt(index);
        //        return true;
        //    }

        //    return false;
        //}

        //bool AddEmployee(string firstName, string secondName, string userName, int bsn, DateTime dateOfBirth, string email, int phoneNumber, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation)
        //{
        //    Employee employee = new Employee(firstName, secondName, bsn, dateOfBirth, phoneNumber, iceNumber, iceRelationship, position, contractEnding, addInformation);
        //    allEmployees.Add(employee);
        //    return true;
        //}
    }
}
