using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herhalling_User_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Deelnemers = new List<User>();

            User Orchid = new User("Orchid");
            User Diego = new User("DiEgo");
            User Regi = new User("Regi");
            User Meg = new User("Megumin");
            User Opal = new User("Opal");
            User Scar = new User("Scarlet");
            User Em = new User("Emma");
            User Trey = new User("Trey");
            User Lil = new User("Lilly");
            User Pres = new User("Preston");
            Deelnemers.Add(Orchid);
            Deelnemers.Add(Diego);
            Deelnemers.Add(Regi);
            Deelnemers.Add(Meg);
            Deelnemers.Add(Opal);
            Deelnemers.Add(Scar);
            Deelnemers.Add(Em);
            Deelnemers.Add(Trey);
            Deelnemers.Add(Lil);
            Deelnemers.Add(Pres);
            
            for (int t = 0; t < Deelnemers.Count; t++)
            {
                Console.WriteLine($"deelnemer {t} is {Deelnemers[t].Naam}");
            }
            
            foreach(User Deelnemer in Deelnemers)
            {
                Console.WriteLine($"{Deelnemer.Naam} klaar staat!");
            }
        }

        public class User
        {
            public string Naam;
            public User(string naam)
            {
                Naam = naam;
            }
        }
    }
}
