using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200630_TestavimoPavyzdys
{
    public class Klientas
    {
        public bool IsAdmin { get; set; }
    }

    public class Rezervacija
    {
        private Klientas Rezervatorius;

        public Rezervacija(Klientas rezervatorius)
        {
            Rezervatorius = rezervatorius;
        }

        public bool AtsauktiRezervacija(Klientas atsaukejas)
        {
            if (atsaukejas.IsAdmin)
            {
                return true;
            }
            else if (atsaukejas == Rezervatorius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GautiRezervacijosKodaIsTeksto(string tekstas)
        {
            return int.Parse(tekstas);
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
