using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMN_Software.Exceptions
{
    public class IncorrectStockMoreThanStore : Exception
    {
        public IncorrectStockMoreThanStore() : base($"The amount of product you want to sell is more than the available in the store.") { }
    }
}
