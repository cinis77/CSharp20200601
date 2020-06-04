using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_pirminiaiSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 2; i < 1000; i++)
            {
                bool pirminis = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        pirminis = false;
                        break;
                    }
                }

                if (pirminis)
                {
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
