using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_KavosAparatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kavos aparatas");
            Console.WriteLine("1-limonadas");
            Console.WriteLine("2-arbata");
            Console.WriteLine("3-kakava");
            Console.WriteLine("4-kava");
            Console.WriteLine("5-nieko");
            Console.WriteLine("Įveskite pasirinkimą");
            char pasirinkimas = Convert.ToChar(Console.ReadKey().KeyChar);
            switch (pasirinkimas)
            {
                case '1':
                    Console.WriteLine(" - jus pasirinkote limonada");
                    break;
                case '2':
                    Console.WriteLine(" - jus pasirinkote arbata");
                    break;
                case '3':
                    Console.WriteLine(" - jus pasirinkote kakava");
                    break;
                case '4':
                    Console.WriteLine(" - jus pasirinkote kava");
                    break;
                case '5':
                    Console.WriteLine(" - jus pasirinkote nieko");
                    break;

                default:
                    Console.WriteLine(" - neatpazintas elementas");
                    break;
            }
        }
    }
}
