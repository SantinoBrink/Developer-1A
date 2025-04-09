using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Opdract_Santino
{
    class Program
    {

        static List<Command> ListOfComands = new List<Command>();
        static List<User> UserBase = new List<User>();

        static void Main(string[] args)
        {
            bool running = true;


            Command showCommand = new Command("1", "Show alle klanten infomatie", null);
            Command AddComand = new Command("2", "Add ", null);
            Command DeleteCostumer = new Command("3", "Delete", null);
            Command QuitApp = new Command("4", "Quit App", null);
            //^gebruikt niet meer maar miechien kan ik iets hier mee doen
            User Santino = new User("Santino", "Kikkenstein 3141, Amsterdam", "0636383705");
            User Wyrm = new User("Wyrmestra", "MonsterHunter Wilds", "0676561198");


            ListOfComands.Add(showCommand);
            ListOfComands.Add(AddComand);
            ListOfComands.Add(DeleteCostumer);
            ListOfComands.Add(QuitApp);
            //^gebruikt niet meer
            UserBase.Add(Santino);
            UserBase.Add(Wyrm);


            while (running)
            {
               /* for (int i = 0; i < ListOfComands.Count; i++)
                {
                    Console.WriteLine(ListOfComands[i].ComandInfo);
                }
                running = false;*/

            //hierboven negeren, en het volgende doen:
            
                //geef de gebruiker een aantal opties om te doen:
                Console.WriteLine("Welkom in mijn geweldige administratie programma");
            Startpunt:
                Console.WriteLine("\n1 - Gebruikers maken");
                Console.WriteLine("2 - Gebruikers weergeven");

                Console.WriteLine("\nWat wilt u doen?");
                string input = Console.ReadLine();
                int.TryParse(input, out int nummer);
                if (nummer == 1)
                {
                    Console.Clear();
                    Console.WriteLine("voeg een naam toe");
                    string input1 = Console.ReadLine();
                    Console.WriteLine("voeg een Adress toe");
                    string input2 = Console.ReadLine();
                    Console.WriteLine("voeg een nummer toe");
                    string input3 = Console.ReadLine();
                    UserAdd(input1, input2, input3);
                    //gebruiker maken
                    goto Startpunt;
                    
                }
                if (nummer == 2)
                {
                    Console.Clear();
                    for(int t = 0; t < UserBase.Count;t++)
                    {
                        Console.WriteLine(UserBase[t].Naam +" "+ UserBase[t].Adress +" "+ UserBase[t].Telefoonnummer);
                    }
                    //gebruikers weergeven
                    goto Startpunt;
                }


            }
        }


        public static void UserAdd(string naam, string Adress, string nummer)
        {
            User New = new User(naam, Adress, nummer);
            for (int i = 0; i < UserBase.Count; i++)
            {
                if (UserBase[i].Naam == naam)
                {
                    Console.WriteLine("deze gebruiker bestaat al");
                    return;
                }
            }
            UserBase.Add(New);
        }

    }
}
