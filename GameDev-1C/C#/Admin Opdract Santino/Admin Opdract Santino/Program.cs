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
            User Santino = new User("Santino", "Kikkenstein 3141, Amsterdam", 0636383705);
            User Wyrm = new User("Wyrmestra", "MonsterHunter Wilds", 0676561198);
            User CrowFather = new User("Philza", "England", 420);


            ListOfComands.Add(showCommand);
            ListOfComands.Add(AddComand);
            ListOfComands.Add(DeleteCostumer);
            ListOfComands.Add(QuitApp);
            //^gebruikt niet meer
            UserBase.Add(Santino);
            UserBase.Add(Wyrm);
            UserBase.Add(CrowFather);
            


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
                Console.WriteLine("3 - bewerk een User");
                Console.WriteLine("4 - verwijder een User");
                Console.WriteLine("5 - verlaat Programma");

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
                    int.TryParse(input, out int Phone);
                    UserAdd(input1, input2, Phone);
                    //gebruiker maken
                    goto Startpunt;
                    
                }
                if (nummer == 2)
                {
                    Console.Clear();
                    for(int t = 0; t < UserBase.Count;t++)
                    {
                        Console.WriteLine(UserBase[t].Naam +" - "+ UserBase[t].Adress +" - "+ UserBase[t].Telefoonnummer);
                    }
                    //gebruikers weergeven
                    goto Startpunt;
                }
                if(nummer == 3)
                {
                    Console.Clear();
                    Console.WriteLine("naam?");
                    String input4 = Console.ReadLine();
                    EditUser(input4);
                }
                if(nummer == 4)
                {
                    Console.WriteLine("welke gebruiker?");
                    string input5 = Console.ReadLine();
                    RemoveUser(input5);
                }
                if(nummer == 5)
                {
                    Console.Clear();
                    Console.WriteLine("byee!");
                    Environment.Exit(0);
                }

            }
        }


        public static void UserAdd(string naam, string Adress, int nummer)
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
        public static void EditUser(string Uname)
        {
            for(int i = 0; i < UserBase.Count; i++)
            {
                if(Uname == UserBase[i].Naam)
                {
                StartEdit:
                    Console.WriteLine("User gevonden. " + UserBase[i].Naam + " " + UserBase[i].Adress + " " + UserBase[i].Telefoonnummer + "\n je kan nu je Adress veranderen");
                    string Edit1 = Console.ReadLine();
                    Console.WriteLine("Graag ook een nummer");
                    string Edit2 = Console.ReadLine();
                    int.TryParse(Edit2, out int Tele);
                    Console.WriteLine("klopt " + Uname + " " + Edit1 + " " + Edit2 + "? \n Y or N");
                    string Confirm = Console.ReadLine();
                    if(Confirm == "Y")
                    {
                        UserBase[i].Adress = Edit1;
                        UserBase[i].Telefoonnummer = Tele;
                    }
                    if(Confirm == "N")
                    {
                        Console.WriteLine("will je terug naar start gaan?");
                        string Confirm1 = Console.ReadLine();
                        if(Confirm1 == "N")
                        {
                            goto StartEdit;
                        }
                        if(Confirm1 == "Y")
                        {
                            return;
                        }
                    }
                    
                }
            }
        }
        public static void RemoveUser(string Dname)
        {
            for (int i = 0; i < UserBase.Count; i++)
            {
                if (UserBase[i].Naam == Dname)
                {
                    Console.WriteLine("Gebruiker Gevonden " + UserBase[i].Naam + " " + UserBase[i].Adress + " " + UserBase[i].Telefoonnummer+"\nBenje zeker?");
                    string input = Console.ReadLine();
                    if (input == "Y")
                    {
                        UserBase.RemoveAt(i);
                        Console.WriteLine("User Verwijderd");
                        return;
                    }
                    if (input == "N")
                    {
                        Console.WriteLine("User niet verwijderd");
                        return;
                    }
                }
            }
        }
    }
}
