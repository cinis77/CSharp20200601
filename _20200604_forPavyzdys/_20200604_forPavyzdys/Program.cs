using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_forPavyzdys
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (double i = 0; i < 20; i+=i*0.02)
            {
                Console.WriteLine(i);
            }
        }
    }
}
