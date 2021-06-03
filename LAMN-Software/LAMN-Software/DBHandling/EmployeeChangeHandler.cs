using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LAMN_Software.DataClasses;

namespace LAMN_Software.DBHandling
{
    public class EmployeeChangeHandler
    {
        List<EmployeeChange> allChangedEmployees;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";
        EmployeeHandler EH = new EmployeeHandler();



        public Exception GetAllEmployeesFromDB()
        {
            allChangedEmployees = new List<EmployeeChange>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM employeechange";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ICERelation ice = ICERelation.OTHER;

                        string relationReturn = dr[6].ToString();
                        relationReturn = relationReturn.ToUpper();

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

                        allChangedEmployees.Add(new EmployeeChange(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), ice, dr[7].ToString()));

                    }
                }
                return null;
            }

            catch (Exception ex)
            {
                return ex;
            }
        }


        public Exception DeleteEmployee(EmployeeChange employeeChange)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM employeechange WHERE BSN = @bsn;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@bsn", employeeChange.Bsn);

                    cmd.ExecuteNonQuery();
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<Employee> GetAllChangedEmployees()
        {
            List<Employee> emp = new List<Employee>();

            if (EH.GetAllEmployeesFromDB() == null)
            {
                foreach (EmployeeChange ECH in allChangedEmployees)
                {
                    foreach (Employee E in EH.GetAllEmployees())
                    {
                        if (ECH.Bsn == E.Bsn)
                        {
                            emp.Add(E);
                        }
                    }
                }
            }
            return emp;
        }


        public EmployeeChange GetEmployeeChange(string BSN)
        {
            foreach(EmployeeChange e in allChangedEmployees)
            {
                if(BSN==e.Bsn)
                {
                    return e;
                }
            }
            return null;
        }





    }
}
