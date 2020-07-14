using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_Viesbutis
{
    class Kambarys
    {
        public double Kaina { get; set; }
        public bool Uzimtas { get; set; }
        public DateTime UžimtumoPradzia { get; set; }
        public DateTime UžimtumoPabaiga { get; set; }

    }

    class Viesbutis
    {
        public readonly List<Kambarys> Kamabariai;
        public string Pavadinimas { get; set; }


        public Viesbutis()
        {
            Kamabariai = new List<Kambarys>();
        }
    }
}
