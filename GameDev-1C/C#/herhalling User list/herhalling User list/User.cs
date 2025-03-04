using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhalling_User_list
{
    public class User
    {
        public string Naam;
        public int Leeftijd;
        public User(string naam, int leeftijd)
        {
            Naam = naam;
            Leeftijd = leeftijd;
        }
    }
}
