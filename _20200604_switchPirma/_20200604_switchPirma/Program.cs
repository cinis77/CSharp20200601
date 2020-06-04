using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_switchPirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            int sk4 = Convert.ToInt32(Convert.ToChar(Console.ReadKey().KeyChar));
           
            switch (sk1)
            {
                case 1:
                    Console.WriteLine(sk1 + sk2 + sk3);
                    break;
                case 2:
                    Console.WriteLine(sk1 - sk3);
                    break;
                case 3:
                    Console.WriteLine(sk2 * sk3);
                    break;
            }
            
        }
    }
}
