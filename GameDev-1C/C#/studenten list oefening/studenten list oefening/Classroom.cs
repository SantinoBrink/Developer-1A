using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenten_list_oefening
{
    public class Classroom
    {
        public string Klasnaam;
        public List<Student> students = new List<Student>();

        public Classroom(string klasnaam)
        {
            Klasnaam = klasnaam;
        }
    }
}
