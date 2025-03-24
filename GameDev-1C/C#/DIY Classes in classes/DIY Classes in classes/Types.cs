using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIY_Classes_in_classes
{
    class Types
    {
        public              String      Soort;
      //[^toeganelijkheid] [^datetype] [^variablenaam]
        public List<Subspecies> Namen = new List<Subspecies>();
      //[^ zorg ervoor dat er een public lijst wordt gemaakt dat bestaat uit namen van subspiecies class]
        public Types(string soort)
       //[^maakt het dat als je de types variable maakt dat je ook een soort moet toevoegen]
        {
            Soort = soort;
            //[^zodat de variable Soort dezelde naam als soort zal hebben]
        }
    }
}
