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
        //[^ zorgt dat Ordertypes kan opgeroept worden]
        public List<Types> Sorten = new List<Types>();
        //[^ maakt een lijst aan dat opgemaakt wordt van data van Types]
        public Order(String ordertypes)
       //[^ maakt het dat je een string moet mee te geven dat gelijk is aan ordertypes]
        {
            Ordertypes = ordertypes;
            //[^ Dat Ordertypes het naam van ordertypes zal hebben]
        }
    }
}
