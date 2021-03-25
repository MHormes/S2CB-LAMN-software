using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using LAMN_Software.Exceptions;

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

        public Exception AddProduct(string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation)
        {
            if (!Regex.IsMatch(name, @"[A-z0-9 _]*$"))
            {
                throw new IncorrectStockNameException(name);
            }

            if (!Regex.IsMatch(quantityWH.ToString(), @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityWH.ToString());
            }

            if (!Regex.IsMatch(quantityS.ToString(), @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityS.ToString());
            }

            if (!Regex.IsMatch(locationS, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationS);
            }

            if (!Regex.IsMatch(locationWH, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationWH);
            }

            if (!Regex.IsMatch(minimumStockRequired.ToString(), @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(minimumStockRequired.ToString());
            }

            if (!Regex.IsMatch(costPrice.ToString(), @"^[0-9]*([.][0-9]*)?$"))
            {
                throw new IncorrectPriceException(costPrice.ToString());
            }

            if (!Regex.IsMatch(sellPrice.ToString(), @"^[0-9]*([.][0-9]*)?$"))
            {
                throw new IncorrectPriceException(sellPrice.ToString());
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO product(Name, QuantityS, QuantityWH, LocationS, LocationWH, CostPrice, SellPrice, MinimumStock, AddInformation, TotalSold) VALUES (@name, @quantityS, @quantityWH, @locationS, @locationWH, @costPrice, @sellprice, @minStock, @addInf, @totalSold);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantityS", quantityS);
                    cmd.Parameters.AddWithValue("@quantityWH", quantityWH);
                    if (!string.IsNullOrWhiteSpace(locationS))
                    { cmd.Parameters.AddWithValue("@locationS", locationS); }
                    else{ cmd.Parameters.AddWithValue("@locationS", null); }
                    if (!string.IsNullOrWhiteSpace(locationWH))
                    { cmd.Parameters.AddWithValue("@locationWH", locationWH); }
                    else { cmd.Parameters.AddWithValue("@locationWH", null); }
                    cmd.Parameters.AddWithValue("@costPrice", costPrice);
                    cmd.Parameters.AddWithValue("@sellPrice", sellPrice);
                    cmd.Parameters.AddWithValue("@minStock", minimumStockRequired);
                    if (!string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInf", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addinf", null); }
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
        public Exception ChangeProduct(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, int minimumStockRequired, string addInformation)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE product SET Name=@name, QuantityS=@quantityS, QuantityWH=@quantityWH, LocationS=@locationS, LocationWH=@locationWH, MinimumStock=@minStock, AddInformation=@addInf WHERE ID=@id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantityS", quantityS);
                    cmd.Parameters.AddWithValue("@quantityWH", quantityWH);
                    if (string.IsNullOrWhiteSpace(locationS)){ cmd.Parameters.AddWithValue("@locationS", locationS); }
                    else{ cmd.Parameters.AddWithValue("@LocationS", null); }
                    if (string.IsNullOrWhiteSpace(locationWH))
                    { cmd.Parameters.AddWithValue("@LocationWH", locationWH); }
                    else { cmd.Parameters.AddWithValue("@LocationWH", null); }
                    cmd.Parameters.AddWithValue("@minStock", minimumStockRequired);
                    if (string.IsNullOrWhiteSpace(addInformation))
                    { cmd.Parameters.AddWithValue("@addInf", addInformation); }
                    else { cmd.Parameters.AddWithValue("@addinf", null); }
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
