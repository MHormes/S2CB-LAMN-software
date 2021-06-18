using LAMN_Software.DataClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DataClasses
{
    public class PreferenceHandler
    {
        List<Preference> allPreferences;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";




        public Exception GetAllPreferencesFromDB()
        {
            allPreferences = new List<Preference>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM employeepreferences";
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

                        allPreferences.Add(new Preference(day, dr[1].ToString(), time));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }


        public List<Preference> GetAllPreferences()
        {
            return allPreferences;
        }


    }
}
