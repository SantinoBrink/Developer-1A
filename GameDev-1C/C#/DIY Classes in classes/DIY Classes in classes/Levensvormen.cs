using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIY_Classes_in_classes
{
    class Levensvormen
    {
        public String Leven;
        public List<Order> Orders = new List<Order>();
        public Levensvormen(String leven)
        {
            Leven = leven;
        }
    }
}
