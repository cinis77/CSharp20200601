using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200723_KartojimasKlientai
{
    class Klientas
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string Adresas { get; set; }
        public long TelefonoNumeris { get; set; }
        public string Email { get; set; }
    }

    class Preke
    {
        public int Kiekis { get; set; }
        public string Pavadinimas { get; set; }
        public string Specifikacija { get; set; }
        public decimal Price { get; set; }
    }
}
