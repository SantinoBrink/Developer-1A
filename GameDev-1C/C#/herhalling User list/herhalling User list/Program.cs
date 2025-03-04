using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            User Orchid = new User("Orchid",20);
            User Diego = new User("DiEgo", 22);
            User Regi = new User("Regi", 34);
            User Meg = new User("Megumin", 14);
            User Opal = new User("Opal", 19);
            User Scar = new User("Scarlet", 24);
            User Em = new User("Emma", 21);
            User Trey = new User("Trey", 27);
            User Lil = new User("Lilly", 16);
            User Pres = new User("Preston", 16);
            
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

            /*Console.WriteLine("schrijf iets");
            string Vibe = Console.ReadLine();
            Console.WriteLine("je vibe is" + Vibe);*/
            
            Console.WriteLine("naam");
            string userInput = Console.ReadLine();
            Console.WriteLine("leeftijd");
            int.TryParse(Console.ReadLine(), out int age);
            User user = new User(userInput,age);
            Deelnemers.Add(user);
            
            for (int t = 0; t < Deelnemers.Count; t++)
            {
                Console.WriteLine($"deelnemer {t} is {Deelnemers[t].Naam}");
            }
            
            foreach(User Deelnemer in Deelnemers)
            {
                Console.WriteLine($"{Deelnemer.Naam} is {Deelnemer.Leeftijd}");
            }
        }


    }
}
