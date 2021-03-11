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
    public class LoginHandler
    {
        //list of login details and connection string with address and password
        List<Login> allLogin;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //method to get all the stock items from the DB
        public Exception GetAllLoginFromDB()
        {
            //get all the the login details from the db
            allLogin = new List<Login>();
            try
            {
                //using the connection string
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    //query
                    string sql = "SELECT * FROM logindetails";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    //connection established, data added to the list
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        allLogin.Add(new Login(dr[0].ToString(), dr[1].ToString()));
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        //get login list
        public List<Login> GetAllLogin()
        {
            if (GetAllLoginFromDB() == null)
            {
                return this.allLogin;
            }
            return null;
        }
    }
}
