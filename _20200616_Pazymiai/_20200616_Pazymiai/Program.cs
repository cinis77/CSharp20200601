using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200616_Pazymiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int kiekReikiaSkaiciu = rng.Next(21); // 0 ... 20
            List<int> Pazymiai = new List<int>();
            for (int i = 0; i < kiekReikiaSkaiciu; i++)
            {
                Pazymiai.Add(rng.Next(1, 11)); // 1 .. 10
               
            }

            Console.WriteLine("Didziausias skaicius yra: " + Pazymiai.Max());
            Console.WriteLine("Maziausias skaicius yra: " + Pazymiai.Min());
            Console.WriteLine("Vidurkis yra: " + Pazymiai.Average());
            Console.WriteLine("Pirmas pazymys yra: " + Pazymiai.First());
            Console.WriteLine("Paskutinis pazymys yra: " + Pazymiai.Last());
            Console.WriteLine("Is viso yra pazymiu: " + Pazymiai.Count);
        }
    }
}
