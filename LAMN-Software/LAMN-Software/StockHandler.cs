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
        public Exception GetAllStockFromDB()
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
                return null;
            }
            catch (Exception ex)
            {
                return ex;
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
            if (GetAllStockFromDB() == null)
            {
                return this.allStock;
            }
            return null;
        }

        //method for adding new products. AFTER CALLING THIS METHOD CALL GETALLSTOCKFROMDB!!!
        public Exception AddProduct(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO product VALUES(@name, @quantityS, @quantityWH, @locationS, @locationWH, @costPrice, @sellprice, @minStock, @addInf, @totalSold);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

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
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        //method to change properties of a product in the DB
        public Exception ChangeProduct(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, int totalSold, string addInformation)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE product SET Name=@name, QuantityS=@quantityS, QuantityWH=@quantityWH, LocationS=@locationS, LocationWH=@locationWH, CostPrice=@costPrice, SellPrice@sellprice, MinimumStock=@minStock, AddInformation=@addInf);";
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

        //method to delete a product from the DB
        public Exception DeleteProduct(Product product)
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
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

    }
}
