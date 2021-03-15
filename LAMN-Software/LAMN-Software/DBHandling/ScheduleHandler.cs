using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LAMN_Software.DataClasses
{
    public class ScheduleHandler
    {
        List<Schedule> allSchedules;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //method to get all the stock items from the DB. Get all items from specific week.
        public Exception GetAllSchedulesFromDB(int weekNmr)
        {
            allSchedules = new List<Schedule>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM schedule WHERE Week = @weekNrm";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@weekNmr", weekNmr);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        allSchedules.Add(new Schedule(Convert.ToInt32(dr[0]), (Day)dr[1], dr[2].ToString(), (TimeSlot)dr[3])));
                    }
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
