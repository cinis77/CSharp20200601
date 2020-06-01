using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200601_pirmaUzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vardas = "Dominykas";
            string PAvarde = "Rentelis";
            int Amzius = 28;
            double Ugis = 181.5;
            double Svoris = 95.5;
            string AukstojiMokykla;
            string AkademineGrupe;
            int Kursas;
            string StudijuProgramosPavadinimas;
            int AtsiskaitytaKreditu;

            Console.WriteLine("STUDENTO DUOMENYS");
            Console.WriteLine("{0} {1} ({2} m.)", Vardas, PAvarde, Amzius);
            Console.WriteLine("Jo ugis yra {0}, o svoris yra {1}", Ugis, Svoris);

            Console.WriteLine("Iveskite zodi arba sakini");
            string zodisArbaSakinys = Console.ReadLine();
            Console.WriteLine("Jusu ivestas tekstas");
            Console.WriteLine(zodisArbaSakinys);

            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite megiamiausios spalvos pirma raide");
            char raide = Convert.ToChar(Console.ReadKey().KeyChar);
            Console.WriteLine("\nIveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas yra {0}, spalvos pirma raide - {1}" +
                "atsitiktiniai skaiciai {2}, {3}", vardas, raide, sk, sk1);
        }
    }
}
