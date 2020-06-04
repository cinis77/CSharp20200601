using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200604_sandauga
{
    class Program
    {
        static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 7; i < 100; i+=7)
            {
                sandauga *= i; // sandauga = saundauga * i
            }
            Console.WriteLine(sandauga);
        }
    }
}
