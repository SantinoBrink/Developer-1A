using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIY_Classes_in_classes
{
    class Order
    {
        public String Ordertypes;
        public List<Types> Sorten = new List<Types>();
        public Order(String ordertypes)
        {
            Ordertypes = ordertypes;
        }
    }
}
