using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasopdracht_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> gebruikers = new List<User>();
            User regi = new User("regi");
            User diego = new User("Diego");
            gebruikers.Add(regi);
            gebruikers.Add(diego);
            for (int i = 0; i < gebruikers.Count; i++)
            {
                Console.Write(gebruikers[i].Name);
            };
        }
        public class User
        {
            public string Name;
            public User(string name)
            {
                Name = name;
            }

        };
    }
}
