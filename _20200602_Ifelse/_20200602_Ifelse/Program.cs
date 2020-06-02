using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_Ifelse
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Iveskite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius > 18)
            {
                Console.WriteLine("Jus esate pilnametis");
            }
            else if (amzius > 14)
            {
                Console.WriteLine("Jums yra daugiau nei 14m");
            }
            else
            {
                Console.WriteLine("Jums yra maziau nei 14m");
            }
        }
    }
}
