using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_IfPirmaUžduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            if (sk > sk1)
            {
                Console.WriteLine("Pirmas skaicius yra didesnis uz antra skaiciu");
            }
            if (sk < sk1)
            {
                Console.WriteLine("Antras skaicius yra didesnis uz pirma skaiciu");
            }
            if (sk == sk1)
            {
                Console.WriteLine("Abu skaiciai yra lygus");
            }
            //-----------------------------------------------------------
            // Antra uzduotis
            if (sk % 2 != 0)
            {
                Console.WriteLine("Skaicius yra nelyginis");
            }
            int liekana = sk % 2;
            if (liekana == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }

            bool salyga = sk % 2 == 0;
            if (salyga)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
        }
    }
}
