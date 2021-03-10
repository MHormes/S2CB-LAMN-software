using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class Product
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public int QuantityS
        {
            get; set;
        }

        public int QuantityWH
        {
            get; set;
        }

        public string LocationS
        {
            get; set;
        }

        public string LocationWH
        {
            get; set;
        }

        public double CostPrice
        {
            get; set;
        }

        public double SellPrice
        {
            get; set;
        }

        public int MinimumStockRequired
        {
            get; set;
        }

        public string AddInformation
        {
            get; set;
        }

        public int TotalSold
        {
            get; set;
        }


        public Product(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation, int totalSold)
        {
            Id = id;
            Name = name;
            QuantityS = quantityS;
            QuantityWH = quantityWH;
            LocationS = locationS;
            LocationWH = locationWH;
            CostPrice = costPrice;
            SellPrice = sellPrice;
            MinimumStockRequired = minimumStockRequired;
            AddInformation = addInformation;
            TotalSold = totalSold;
        }

        public override string ToString()
        {
            return $"{Id}:{Name}. WH:{QuantityWH}/{LocationWH}. S:{QuantityS}/{LocationS}. P:{CostPrice}/{SellPrice}";
        }
    }
}
