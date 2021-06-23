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
    class SickDayHandler
    {
        List<string> sickEmployeeDetailBSN;
        List<string> sickEmployeeDetailDay;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        public void GetSickEmp()
        {
            sickEmployeeDetailBSN = new List<string>();
            sickEmployeeDetailDay = new List<string>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM sickdays";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        sickEmployeeDetailBSN.Add(dr[0].ToString());
                        sickEmployeeDetailDay.Add(dr[1].ToString());

                    }
                }

            }

            catch (Exception ex)
            {

            }
        }
        public List<string> GetDetailBSN()
        {
            return sickEmployeeDetailBSN;
        }
        public List<string> GetDetailDay()
        {
            return sickEmployeeDetailDay;
        }

    }
}
