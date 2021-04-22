using LAMN_Software.DataClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class ScheduleMinimumHandler
    {


        List<SchedulesMinimum> scheduleMinimum;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //Get minimum people per shift from db
        public Exception GetMinimumPeopleFromDB()
        {
            scheduleMinimum = new List<SchedulesMinimum>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM schedulesminimum";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        TimeSlot time = TimeSlot.MORNING;
                        Day day = Day.MONDAY;
                        JobPosition posistion = JobPosition.MANAGER;

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

                        scheduleMinimum.Add(new SchedulesMinimum(day, time, Convert.ToInt32(dr[4]), posistion));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public List<SchedulesMinimum> GetSchedulesMinimum()
        {
            return this.scheduleMinimum;
        }

        public Exception SaveNewMinimumPeople(Day day, TimeSlot timeSlot, int minimumPeople, JobPosition position)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO schedulesminimum (Day, TimeSlot, MinPoeple, Department) VALUES (@day, @timeSlot, @people, @position)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@day", day.ToString());
                    cmd.Parameters.AddWithValue("@timeSlot", timeSlot.ToString());
                    cmd.Parameters.AddWithValue("@people", minimumPeople);
                    cmd.Parameters.AddWithValue("@position", position.ToString());
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

        public Exception DeleteMinimumPeople()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM schedulesminimum;";
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

