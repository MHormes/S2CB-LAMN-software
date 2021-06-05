using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using LAMN_Software.Exceptions;
using LAMN_Software.DataClasses;

namespace LAMN_Software.DBHandling
{
    public class SellTrackerHandler
    {
        List<SellTracker> allSellings;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //method to get all the stock items from the DB
        public Exception GetAllSellingsFromDB()
        {
            allSellings = new List<SellTracker>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM selltracker";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        allSellings.Add(new SellTracker(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), Convert.ToInt32(dr[4])));
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
        public List<SellTracker> GetSellings(string name)
        {
            List<SellTracker> sellings = new List<SellTracker>();
            foreach (SellTracker sellTracker in allSellings)
            {
                if (sellTracker.Name == name)
                {
                    sellings.Add(sellTracker);
                }
            }
            if (sellings.Count != 0)
                return sellings;
            return null;
        }

        public List<SellTracker> GetAllSellings()
        {
            if (GetAllSellingsFromDB() == null)
            {
                return this.allSellings;
            }
            return null;
        }

        public Exception AddSelling(string id, string ean, string name, string dateTime, string quantity)
        {
            try
            {
                if (!Regex.IsMatch(quantity, @"^[0-9]*$"))
                {
                    throw new IncorrectQuantityException(quantity);
                }

                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO selltracker(ID, EAN, Name, DateTime, QuantitySold) VALUES (@id, @ean, @name, @dateTime, @quantity);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
                    cmd.Parameters.AddWithValue("@ean", ean);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@dateTime", dateTime);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

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
    }
}
