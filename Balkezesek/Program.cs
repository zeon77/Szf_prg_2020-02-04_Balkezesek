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

            Console.ReadKey();
        }
    }
}
