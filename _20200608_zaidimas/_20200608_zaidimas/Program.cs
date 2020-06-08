using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200608_zaidimas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Žaidimas atspėk skaičių");
            Console.WriteLine("Jums riekia sugalvoti skaičių nuo 1 iki 3000");
            Console.WriteLine("Programa toliau mėginst atspėti skaičių, o jūs turėsite nurodyti:");
            Console.WriteLine("Daugiau ar mažiau už jūsų sugalvotą skaičių arba kad atspėjai");
            Console.WriteLine("Norėdami pradėti žaisti žaidimą paspauskite enter klavišą");
            Console.ReadLine();
            //------------------------------------------------------------------------------------
            string atsakymas = string.Empty;
            int max = 3000;
            int min = 1;
            while (atsakymas.ToLower() != "atspejai")
            {
                var spejimas = (min + max) / 2;
                Console.WriteLine("Ar tai yra " + spejimas);
                Console.WriteLine("jei didesnis rasyti daugiau jei mazenis rasyti maziau");
                Console.WriteLine("jei atspejau rasyti atspejai");
                atsakymas = Console.ReadLine();
                if (atsakymas.ToLower() == "maziau")
                {
                    max = spejimas;
                }
                else if (atsakymas.ToLower() == "daugiau")
                {
                    min = spejimas;
                }
            }
            Console.WriteLine("Atspejau!!!!!");
        }
    }
}
