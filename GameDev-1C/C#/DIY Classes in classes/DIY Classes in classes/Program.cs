using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIY_Classes_in_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Levensvormen Valka = new Levensvormen("Valka");

            Order Dieren = new Order("Anamalia");
            Order Flora = new Order("Flora");

            Types Mimics = new Types("Mimus.sp");
            Types Draken = new Types("Dracoforms.sp");
            Types Wyverns = new Types("Wyrmiforms.sp");
            Types BlackWood = new Types("Cupressa.Noct");
            Types Rompiles = new Types("rompiles[nog niet bedacht]");
            Types OldOak = new Types("Ginkgo.Antpuus");
            Subspecies Huntsmen = new Subspecies("M.phag");

            Valka.Orders.Add(Dieren);
            Valka.Orders.Add(Flora);
            Dieren.Sorten.Add(Mimics);
            Dieren.Sorten.Add(Draken);
            Dieren.Sorten.Add(Wyverns);
            Flora.Sorten.Add(BlackWood);
            Flora.Sorten.Add(Rompiles);
            Flora.Sorten.Add(OldOak);
            Mimics.Namen.Add(Huntsmen);

            for(int i = 0;i < Valka.Orders.Count; i++)
            {
                Console.WriteLine(Valka.Orders[i].Ordertypes);
                for(int j = 0;j < Valka.Orders[i].Sorten.Count; j++)
                {
                    Console.WriteLine(Valka.Orders[i].Sorten[j].Soort);
                    for(int s = 0;s < Valka.Orders[i].Sorten[j].Namen.Count;s++)
                    {
                        Console.WriteLine(Valka.Orders[i].Sorten[j].Namen[s].Name);
                    }
                }
            }
        }
    }
}
