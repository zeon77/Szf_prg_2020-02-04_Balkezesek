using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.
            List<Játékos> játékosok = new List<Játékos>();
            foreach (var sor in File.ReadAllLines("balkezesek.csv").Skip(1))
            {
                játékosok.Add(new Játékos(sor));
            }

            Console.WriteLine($"3. feladat: {játékosok.Count}");

            //4.
            Console.WriteLine($"4. feladat:");
            játékosok.Where(x => x.UtolsóMeccs.Year == 1999 && x.UtolsóMeccs.Month == 10)
                .ToList().ForEach(x => Console.WriteLine($"\t{x.Név}, {x.MagasságCm:0.0} cm"));

            //5.
            Console.WriteLine($"5. feladat:");
            Console.Write($"Kérek egy 1990 és 1999 közötti évszámot!: ");
            int év = int.Parse(Console.ReadLine());
            while (év < 1990 || év > 1999)
            {
                Console.Write($"Hibás adat, kérek egy 1990 és 1999 közötti évszámot!: ");
                év = int.Parse(Console.ReadLine());
            }

            //6.
            double átlagSúly = játékosok.Where(x => x.ElsőMeccs.Year <= év && x.UtolsóMeccs.Year >= év)
                .Average(x => x.SúlyFont);
            Console.WriteLine($"6. feladat: {átlagSúly:0.00} font");
            
            Console.ReadKey();
        }
    }
}
