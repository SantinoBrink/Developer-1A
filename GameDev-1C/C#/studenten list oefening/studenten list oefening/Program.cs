using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studenten_list_oefening
{
    class Program
    {
        static void Main(string[] args)
        {
            School roc = new School("ROC");

            Classroom msdsdo24c = new Classroom("msdsdo24C");
            Classroom MH = new Classroom("Hunting Buddies");

            Student jesse = new Student("Jesse");
            Student regi = new Student("regi");
            Student meg = new Student("megan");
            Student will = new Student("William");
            Student Wyrm = new Student("Wyrmestra");
            Student SD = new Student("Santino");

            Console.WriteLine("Name please");
            string NieuweStudent = Console.ReadLine();
            Student NieweStudent = new Student(NieuweStudent);

            MH.students.Add(regi);
            MH.students.Add(Wyrm);
            MH.students.Add(NieweStudent);
            MH.students.Add(will);
            msdsdo24c.students.Add(jesse);
            msdsdo24c.students.Add(SD);
            msdsdo24c.students.Add(meg);
            roc.classrooms.Add(msdsdo24c);
            roc.classrooms.Add(MH);

            for(int i = 0; i < roc.classrooms.Count; i++)
            {
                Console.WriteLine(roc.classrooms[i].Klasnaam);
                for(int j = 0;j < roc.classrooms[i].students.Count; j++)
                {
                    Console.WriteLine(roc.classrooms[i].students[j].Studentnaam);
                }
            }

        }
    }
}
