using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Opdract_Santino
{
    class User
    {
        public string Naam;
        public string Adress;
        public string Telefoonnummer;
        
        public User(string naam,string adress, string telefoonnummer)
        {
            Naam = naam;
            Adress = adress;
            Telefoonnummer = telefoonnummer;
        }

        
    }
}
