using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LAMN_Software
{
    public class StockHandler
    {
        List<Product> allStock = new List<Product>();

        //method to get all the stock items from the DB
        public void GetAllStockFromDB()
        {
            string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "SELECT * FROM product";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        allStock.Add(new Product(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3]), dr[4].ToString(), dr[5].ToString(), Convert.ToDouble(dr[6]), Convert.ToDouble(dr[7]), Convert.ToInt32(dr[8]), dr[9].ToString(), Convert.ToInt32(dr[10])));
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        //method to get a specific product from the list
        public Product GetProduct(int id)
        {
            foreach (Product pd in allStock)
            {
                if (pd.Id == id)
                {
                    return pd;
                }
            }
            return null;
        }

        public List<Product> GetAllProducts()
        {
            return this.allStock;
        }

        //method for adding new products
        public bool AddProduct(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation, int totalSold)
        {
            //take input to insert in DB
            GetAllStockFromDB();
            return true;
            //return false if DB connection failed
        }

        //method to change properties of a product in the DB
        private bool ChangeProduct(int id, string name, int quantityS, int quantityW, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, int totalSold, string addInformation)
        {
            //update given info in DB for product with id.
            GetAllStockFromDB();
            return true;
            //return false if DB connection failed
        }

        //method to delete a product from the DB
        private bool DeleteProduct(Product product)
        {
            int idToDelete = product.Id;
            //remove given id from the DB
            GetAllStockFromDB();
            return true;
            //return false if DB connection failed
        }

    }
}
