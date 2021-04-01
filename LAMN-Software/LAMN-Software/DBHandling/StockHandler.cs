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
                        allStock.Add(new Product(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), dr[5].ToString(), dr[6].ToString(), Convert.ToDouble(dr[7]), Convert.ToDouble(dr[8]), Convert.ToInt32(dr[9]), dr[10].ToString(), Convert.ToInt32(dr[11]), Convert.ToInt32(dr[12])));
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

        public Exception AddProduct(string ean, string name, string quantityS, string quantityWH, string locationS, string locationWH, string costPrice, string sellPrice, string minimumStockRequired, string addInformation)
        {
            if (!Regex.IsMatch(ean, @"^[0-9]{13}"))
            {
                throw new IncorrectEANException(ean);
            }
            if (!Regex.IsMatch(name, @"[A-z0-9 _]*$"))
            {
                throw new IncorrectStockNameException(name);
            }

            if (!Regex.IsMatch(quantityWH, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityWH);
            }

            if (!Regex.IsMatch(quantityS, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityS);
            }

            if (!Regex.IsMatch(locationS, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationS);
            }

            if (!Regex.IsMatch(locationWH, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationWH);
            }

            if (!Regex.IsMatch(minimumStockRequired, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(minimumStockRequired);
            }

            if (!Regex.IsMatch(costPrice, @"^[0-9]*([.][0-9]*)?$"))
            {
                throw new IncorrectPriceException(costPrice);
            }

            if (!Regex.IsMatch(sellPrice, @"^[0-9]*([.][0-9]*)?$"))
            {
                throw new IncorrectPriceException(sellPrice);
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "INSERT INTO product(EAN, Name, QuantityS, QuantityWH, LocationS, LocationWH, CostPrice, SellPrice, MinimumStock, AddInformation, TotalSold) VALUES (@ean, @name, @quantityS, @quantityWH, @locationS, @locationWH, @costPrice, @sellprice, @minStock, @addInf, @totalSold);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.Parameters.AddWithValue("@ean", ean);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@quantityS", quantityS);
                    cmd.Parameters.AddWithValue("@quantityWH", quantityWH);
                    cmd.Parameters.AddWithValue("@locationS", locationS);
                    cmd.Parameters.AddWithValue("@locationWH", locationWH);
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
        public Exception ChangeProduct(int id, string name, string quantityS, string quantityWH, string locationS, string locationWH, string minimumStockRequired, string addInformation)
        {
            if (!Regex.IsMatch(name, @"[A-z0-9 _]*$"))
            {
                throw new IncorrectStockNameException(name);
            }

            if (!Regex.IsMatch(quantityWH, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityWH);
            }

            if (!Regex.IsMatch(quantityS, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(quantityS);
            }

            if (!Regex.IsMatch(locationS, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationS);
            }

            if (!Regex.IsMatch(locationWH, @"^[A-Z]{2}[-][0-9]{2}$"))
            {
                throw new IncorrectLocationException(locationWH);
            }

            if (!Regex.IsMatch(minimumStockRequired, @"^[0-9]*$"))
            {
                throw new IncorrectQuantityException(minimumStockRequired);
            }

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
                    cmd.Parameters.AddWithValue("@locationS", locationS);
                    cmd.Parameters.AddWithValue("@LocationWH", locationWH);
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

        //method to deactivate a product from the DB
        public Exception DeactivateProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE product SET Active = 0 WHERE ID = @id;";
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

        //method to reactivate a product from the DB
        public Exception ReactivateProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    string sql = "UPDATE product SET Active = 1 WHERE ID = @id;";
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
