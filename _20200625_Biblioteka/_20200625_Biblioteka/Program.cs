using DuomenuRaymasIrSkaitymas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Biblioteka
{
    class ConsoleRasymas : IDuomenuRasymas
    {
        public string FailoKelias { get; }

        public bool ArFailasExistuoja()
        {
            return true;
        }

        public void Rasyti(string eilute)
        {
            Console.WriteLine(eilute);
        }

        public void RasytiINaujaFaila(string kelias, string tekstas)
        {
            Console.WriteLine(tekstas);
        }
    }

    class ConsoleDuomenuSkaitymas : IDuomenuSkaitymas
    {
        public string FailoKelias { get; }

        IDuomenuRasymas Rasymas;

        public ConsoleDuomenuSkaitymas(IDuomenuRasymas rasymas)
        {
            Rasymas = rasymas;
        }

        public bool ArFailasExistuoja()
        {
            return true;
        }

        public string Skaityti()
        {
            return Console.ReadLine();
        }

        public void SkaitytiIrRasytiInauja(string kelias)
        {
            Rasymas.RasytiINaujaFaila(kelias, Console.ReadLine());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleRasymas rasymas = new ConsoleRasymas();
            ConsoleDuomenuSkaitymas skaitymas = new ConsoleDuomenuSkaitymas(rasymas);
            TekstoTxtSkaitymasIrRasymas tesk = new TekstoTxtSkaitymasIrRasymas(rasymas, skaitymas);
            tesk.PerrasytiFaila("kazkas");
        }
    }
}
