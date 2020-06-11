using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200611_AnaUzdavinys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
           
            for (int i = skaicius; i > 0; i--)
            {
                if (ArSkaiciusYraTvarkingas(i))
                {
                    Console.WriteLine("Didziausias skaicius yra " + i);
                    break;
                }
            }
        }

        public static bool ArSkaiciusYraTvarkingas(int skaicius)
        {
            int vnt = skaicius % 10;
            int desimt = skaicius / 10 % 10;

            if (vnt >= desimt)
            {
                skaicius /= 10;
                if (skaicius >= 10)
                {
                    return ArSkaiciusYraTvarkingas(skaicius);
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
