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
                        else if (relationReturn == "HR")
                            position = JobPosition.HR;
                        else if (relationReturn == "SALES")
                            position = JobPosition.SALES;
                        else if (relationReturn == "DEPOT")
                            position = JobPosition.DEPOT;
                        else if (relationReturn == "SECURITY")
                            position = JobPosition.SECURITY;

                        allEmployees.Add(new Employee(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), Convert.ToDateTime(dr[3]), Convert.ToInt32(dr[4]), Convert.ToInt32(dr[5]), ice, position, Convert.ToDateTime(dr[8]), dr[9].ToString(), dr[10].ToString()));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        //method to get a specific product from the list
        public Employee GetEmployee(int bsn)
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

        public List<Employee> GetAllEmployees()
        {
            if (GetAllEmployeesFromDB() == null)
            {
                return this.allEmployees;
            }
            return null;
        }

        //method for adding new employee. AFTER CALLING THIS METHOD CALL GETALLSTOCKFROMDB!!!
        public Exception AddEmployee(string firstName, string secondName, string userName, int bsn, DateTime dateOfBirth, string email, int phoneNumber, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation, string quittingReason)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO employee(FirstName, SecondName, UserName, BSN, DateOfBirth, PhoneNumber, Email, ICEnumber, ICErelation, Position, ContractEnding, AddInformation, QuittingReason) VALUES (@firstName, @secondName, @userName, @bsn, @dateOfBirth, @phoneNumber, @email, @iceNumber, @iceRelation, @position, @contractEnding, @addInformation, @quittingReason);";
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
                    cmd.Parameters.AddWithValue("@contractEnding", contractEnding);

                    if (!string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInformation", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addInformation", null); }

                    if (!string.IsNullOrWhiteSpace(quittingReason))
                    { cmd.Parameters.AddWithValue("@quittingReason", quittingReason); }
                    else { cmd.Parameters.AddWithValue("@quittingReason", null); }

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
        public Exception ChangeEmployee(string firstName, string secondName, string userName, int bsn, DateTime dateOfBirth, string email, int phoneNumber, int iceNumber, ICERelation iceRelationship, JobPosition position, DateTime contractEnding, string addInformation, string quittingReason)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE product SET FirstName=@firstName, SecondName=@secondName, UserName=@userName, BSN=@bsn, DateOfBirth=@dateOfBirth, PhoneNumber=@phoneNumber, Email=@email, IceNumber=@iceNumber, IceRelation=@iceRelation, Position=@position, ContractEnding=@contractEnding, AddInformation=@addInformation, QuittingReason=@quittingReason WHERE BSN=@bsn;";
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
                    cmd.Parameters.AddWithValue("@contractEnding", contractEnding);

                    if (!string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInformation", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addInformation", null); }

                    if (!string.IsNullOrWhiteSpace(quittingReason))
                    { cmd.Parameters.AddWithValue("@quittingReason", quittingReason); }
                    else { cmd.Parameters.AddWithValue("@quittingReason", null); }

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



        //method to delete an employee product from the DB
        public Exception DeleteProduct(Employee employee)
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
    }
}
