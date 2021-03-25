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
                    string sql = "SELECT * FROM schedules WHERE Week = @weekNmr";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@weekNmr", weekNmr);

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TimeSlot time = TimeSlot.MORNING;
                        Day day = Day.MONDAY;

                        string DayReturn = dr[1].ToString();
                        string TimeReturn = dr[3].ToString();

                        if (TimeReturn == "MORNING")
                            time = TimeSlot.MORNING;
                        else if (TimeReturn == "AFTERNOON")
                            time = TimeSlot.AFTERNOON;
                        else if (TimeReturn == "EVENING")
                            time = TimeSlot.EVENING;

                        

                        if (DayReturn == "MONDAY")
                            day = Day.MONDAY;
                        else if (DayReturn == "TUESDAY")
                            day = Day.TUESDAY;
                        else if (DayReturn == "WEDNESDAY")
                            day = Day.WEDNESDAY;
                        else if (DayReturn == "THURDAY")
                            day = Day.THURDAY;
                        else if (DayReturn == "FRIDAY")
                            day = Day.FRIDAY;
                        else if (DayReturn == "SATURDAY")
                            day = Day.SATURDAY;
                        else if (DayReturn == "SUNDAY")
                            day = Day.SUNDAY;

                        allSchedules.Add(new Schedule(Convert.ToInt32(dr[0]), day, dr[2].ToString(), time));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<Schedule> GetAllSchedules()
        {
            return this.allSchedules;
        }

        public Exception SaveCurrentWeek(int weeknmr, Day day, string empBSN, string timeSlot)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO schedules (Week, Day, EmpBSN, TimeSlot) VALUES (@weeknmr, @day, @empBSN, @timeSlot)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@weeknmr", weeknmr);
                    cmd.Parameters.AddWithValue("@day", day.ToString());
                    cmd.Parameters.AddWithValue("@empBSN", empBSN);
                    cmd.Parameters.AddWithValue("@timeSlot", timeSlot);
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

        public Exception DeleteWeekSchedule(int weekNmr)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM schedules WHERE Week = @weekNmr;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@weekNmr", weekNmr);

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
