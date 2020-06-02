using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_SkaičiavimoMašinėlė
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirmą skaičių");
            int pirmas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite ženklą");
            char zenklas = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite antra skaiciu");
            int antras = Convert.ToInt32(Console.ReadLine());

            if (zenklas == '+')
            {
                Console.WriteLine(pirmas + antras);
            }
            else if (zenklas == '-' )
            {
                Console.WriteLine(pirmas - antras);
            }
            else if (zenklas == '*')
            {
                Console.WriteLine(pirmas * antras);
            }
            else if (zenklas == '/')
            {
                if (antras != 0)
                {
                    Console.WriteLine((double)pirmas / antras);
                }
                else
                {
                    Console.WriteLine("Dalyba iš 0 negalima");
                }
            }
            else
            {
                Console.WriteLine("Nesuprastas zenklas");
            }
        }
    }
}
