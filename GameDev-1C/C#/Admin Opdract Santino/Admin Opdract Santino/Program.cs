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

        static List<User> UserBase = new List<User>();

        static void Main(string[] args)
        {
            bool running = true;

            User Santino = new User("Santino", "Kikkenstein 3141, Amsterdam", "0636383705");
            User Wyrm = new User("Wyrmestra", "MonsterHunter Wilds", "0676561198");
            User CrowFather = new User("Philza", "England", "0701988301");

            //^gebruikt niet meer
            UserBase.Add(Santino);
            UserBase.Add(Wyrm);
            UserBase.Add(CrowFather);
            


            while (running)
            {
            
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
                nummer:
                    Console.WriteLine("voeg een nummer toe");
                    string input3 = Console.ReadLine();
                    if (input3.ToString().Length == 10)
                    {
                        Console.WriteLine("telefoonnummer is goed");
                        UserAdd(input1, input2, input3);
                    }
                    else
                    {
                        Console.WriteLine("telefoonnummer is fout");
                        goto nummer;
                    }
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
        public static void EditUser(string Uname)
        {
            string Edit1 = "";
            string Edit2 = "";
            for (int i = 0; i < UserBase.Count; i++)
            {
                if(Uname == UserBase[i].Naam)
                {
                
                    Console.WriteLine("User gevonden. " + UserBase[i].Naam + " - " + UserBase[i].Adress + " - " + UserBase[i].Telefoonnummer + "\n will je je Adress veranderen?\n Y of N");
                    string confirm2 = Console.ReadLine();
                    if (confirm2 == "Y")
                    {
                        Console.WriteLine("wat is je nieuwe Adress?");
                        Edit1 = Console.ReadLine();
                    }
                    if(confirm2 == "N")
                    {
                        Edit1 = UserBase[i].Adress;
                    }
                StartEdit:
                    Console.WriteLine("will je je telefoonnummer veranderen?\n Y of N");
                    string confirm3 = Console.ReadLine();
                    if (confirm3 == "Y")
                    {
                        Console.WriteLine("Graag ook een nummer");
                        Edit2 = Console.ReadLine();

                        if (Edit2.ToString().Length == 10)
                        {
                            Console.WriteLine("telefoonnummer is goed");
                        }
                        else
                        {
                            Console.WriteLine("telefoonnummer is fout");
                            goto StartEdit;
                        }
                    } if(confirm3 == "N") { Edit2 = UserBase[i].Telefoonnummer.ToString();}
                    
                    Console.WriteLine("klopt " + Uname + " - " + Edit1 + " - " + Edit2 + "? \n Y or N");
                    string Confirm = Console.ReadLine();
                    if(Confirm == "Y")
                    {
                        UserBase[i].Adress = Edit1;
                        UserBase[i].Telefoonnummer = Edit2;
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
