using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LAMN_Software.DataClasses
{
    public class ScheduleTemplateHandler
    {
        List<ScheduleTemplate> weekScheduleTemplate;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //method to get all the schedules from the DB. Get all items from specific week.
        public Exception GetWeekScheduleFromDB()
        {
            weekScheduleTemplate = new List<ScheduleTemplate>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM scheduletemplate";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TimeSlot time = TimeSlot.MORNING;
                        Day day = Day.MONDAY;

                        string DayReturn = dr[0].ToString();
                        string TimeReturn = dr[2].ToString();

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

                        weekScheduleTemplate.Add(new ScheduleTemplate(day, dr[1].ToString(), time));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<ScheduleTemplate> GetScheduleTemplate()
        {
            return this.weekScheduleTemplate;
        }

        public Exception SaveCurrentWeek(Day day, string empBSN, string timeSlot)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO scheduletemplate (Day, EmpBSN, TimeSlot) VALUES (@day, @empBSN, @timeSlot)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

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

        public Exception DeleteWeekSchedule()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM scheduletemplate;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

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
