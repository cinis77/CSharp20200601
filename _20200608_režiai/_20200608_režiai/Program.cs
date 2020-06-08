using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200608_režiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskit pradzia");
            int pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite pabaiga");
            int pabaiga = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            int kiekis = 0;
            for (int i = pradzia; i < pabaiga; i++)
            {
                suma += i;
                kiekis++;
            }

            Console.WriteLine((double)suma/kiekis);
        }
    }
}
