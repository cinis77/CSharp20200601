using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20200609_pirmasKlasės
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int suma = 0;
            while (sk > 0)
            {
                int liekana = sk % 10;
                //654321
                suma += liekana;
                sk /= 10;
                //65432
                //6543
                //654
                //65
                //4
            }
            Console.WriteLine(suma);
        }
    }
}
