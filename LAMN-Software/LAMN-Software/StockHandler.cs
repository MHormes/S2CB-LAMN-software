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
    public class StockHandler
    {
        List<Product> allStock;
        string connStr = "Server=studmysql01.fhict.local;Uid=dbi456806;Database=dbi456806;Pwd=LAMNSoftware;";

        //method to get all the stock items from the DB
        public bool GetAllStockFromDB()
        {
            allStock = new List<Product>();
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
                return true;
            }
            catch (Exception ex)
            {
                return false;
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
            if (GetAllStockFromDB())
            {
                return this.allStock;
            }
            return null;
        }

        //method for adding new products. AFTER CALLING THIS METHOD CALL GETALLSTOCKFROMDB!!!
        public bool AddProduct(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO product VALUES(@id, @name, @quantityS, @quantityWH, @locationS, @locationWH, @costPrice, @sellprice, @minStock, @addInf, @totalSold);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantityS", quantityS);
                    cmd.Parameters.AddWithValue("@quantityWH", quantityWH);
                    cmd.Parameters.AddWithValue("@locationS", locationS);
                    cmd.Parameters.AddWithValue("@locationWH", locationWH);
                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                    cmd.Parameters.AddWithValue("@sellPrice", sellPrice);
                    cmd.Parameters.AddWithValue("@minStock", minimumStockRequired);
                    cmd.Parameters.AddWithValue("@addInf", addInformation);
                    cmd.Parameters.AddWithValue("@totalSold", 0);
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //method to change properties of a product in the DB
        public bool ChangeProduct(int id, string name, int quantityS, int quantityW, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, int totalSold, string addInformation)
        {
            //update given info in DB for product with id.
            GetAllStockFromDB();
            return true;
            //return false if DB connection failed
        }

        //method to delete a product from the DB
        public bool DeleteProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "DELETE FROM product WHERE id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", product.Id);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
