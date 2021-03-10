using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software
{
    public class Product
    {
        private int id;
        private string name;
        private int quantityS;
        private int quantityWH;
        private string locationS;
        private string locationWH;
        private double costPrice;
        private double sellPrice;
        private int minimumStockRequired;
        private string addInformation;
        private int totalSold;

        public int Id
        {
            get; set;
        }

        public Product(int id, string name, int quantityS, int quantityWH, string locationS, string locationWH, double costPrice, double sellPrice, int minimumStockRequired, string addInformation, int totalSold)
        {
            Id = id;
            this.name = name;
            this.quantityS = quantityS;
            this.quantityWH = quantityWH;
            this.locationS = locationS;
            this.locationWH = locationWH;
            this.costPrice = costPrice;
            this.sellPrice = sellPrice;
            this.minimumStockRequired = minimumStockRequired;
            this.addInformation = addInformation;
            this.totalSold = totalSold;
        }
    }
}
