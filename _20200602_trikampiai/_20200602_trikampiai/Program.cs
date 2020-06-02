using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_trikampiai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (c + b > a)
                    {
                        Console.WriteLine("Sudaryti trikampi galima");
                    }
                    else
                    {
                        Console.WriteLine("Sudaryti trikampio negalima");
                    }
                }
                else
                {
                    Console.WriteLine("Sudaryti trikampio negalima");
                }
            }
            else
            {
                Console.WriteLine("Sudaryti trikampio negalima");
            }
        }
    }
}
