﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAMN_Software.DataClasses;
using MySql.Data.MySqlClient;

namespace LAMN_Software
{
    class HolidayHandler
    {
        List<Holiday> allHolidayRequests;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        public Exception GetAllHolidaysFromDB()
        {
            allHolidayRequests = new List<Holiday>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM holidays";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Day day = Day.MONDAY;

                        string DayReturn = dr[3].ToString();
                        

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

                        allHolidayRequests.Add(new Holiday(dr[0].ToString(), dr[1].ToString(), (Day)dr[2], (bool)dr[3]));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }


        public List<Holiday> GetAllHolidayRequests()
        {
            return allHolidayRequests;
        }
    }
}
