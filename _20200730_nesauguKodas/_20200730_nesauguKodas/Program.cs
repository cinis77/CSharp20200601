using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200730_nesauguKodas
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
           fixed (char* reiksme = "Nesaugu")
            {
                char* prt = reiksme;
                while (*prt != '\0')
                {
                    Console.WriteLine(*prt);
                    ++prt;
                }
            }

            int var = 20;
            int* p = &var;

            Console.WriteLine("Duomuo yra: "  + var);
            Console.WriteLine("Duomuo yra: " + p->ToString());
            Console.WriteLine("Adresas pagal pointeri: " + (int)p);

            int sk1 = 5;
            int sk2 = 7;
            int* x = &sk1;
            int* y = &sk2;
            Console.WriteLine("Pirmas skaicius yra {0}, o skaicius antras yra {1}", sk1, sk2);
            Apkeitimas(x, y);
            Console.WriteLine("Pirmas skaicius yra {0}, o skaicius antras yra {1}", sk1, sk2);

        }

        private static unsafe void Apkeitimas(int* p, int* s)
        {
            int temp = *p;
            *p = *s;
            *s = temp;
        }
    }
}
