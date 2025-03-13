using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIY_Classes_in_classes
{
    class Types
    {
        public String Soort;
        public List<Subspecies> Namen = new List<Subspecies>();
        public Types(string soort)
        {
            Soort = soort;
        }
    }
}
