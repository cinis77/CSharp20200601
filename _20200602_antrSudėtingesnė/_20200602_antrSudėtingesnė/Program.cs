using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200602_antrSudėtingesnė
{
    class Program
    {
        static void Main(string[] args)
        {
            int pirmas = 15;
            int antras = 10;
            int trecias = 5;
            if (pirmas > antras && pirmas < 100)
            {
                Console.WriteLine("Pirma salyga yra ispildyta");
            }
            else if (antras > 0  && antras > pirmas)
            {
                Console.WriteLine("Antra salyga yra ispildyta");
            }
            else if (pirmas > antras && pirmas > trecias || pirmas > 0)
            {
                Console.WriteLine("Treacia salyga yra ispildyta");
            }
            else if (trecias >= 5 && trecias <= 10 || trecias > pirmas || trecias > antras)
            {
                Console.WriteLine("Ketvirta salyga ispildyta");
            }
        }
    }
}
