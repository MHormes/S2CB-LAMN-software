using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.DataClasses
{
    public class SellingTracker
    {
        public int Id { get; set; }
        public string Ean { get; set; }
        public string Name { get; set; }
        public string DateAndTime { get; set; }
        public int QuantitySold { get; set; }


        public SellingTracker(int id, string ean, string name, string dateAndTime, int quantity)
        {
            Id = id;
            Ean = ean;
            Name = name;
            DateAndTime = dateAndTime;
            QuantitySold = quantity;
        }

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
