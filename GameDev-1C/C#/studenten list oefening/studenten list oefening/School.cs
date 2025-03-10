using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenten_list_oefening
{

    class School
    {
        public string Schoolnaam;
        List<Classroom> klassen = new List<Classroom>();
        public School(string schoolnaam)
        {
            Schoolnaam = schoolnaam;
        }
    }

    
}