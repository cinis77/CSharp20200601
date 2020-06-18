using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200616_Klasės
{


    class Program
    {
        static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Audi", "A4", 2005, 195000);
            Automobilis auto1 = new Automobilis();
            auto1.MetodasB()
            auto.Rida = 250000;
        }
    }
}
