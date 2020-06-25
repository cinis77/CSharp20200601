using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Figuros
{
    class Preke
    {
        public int ID { get; set; }
        public string Pavadinimas { get; set; }
        public DateTime Galiojimas { get; set; }
        public double Kaina { get; set; }
    }

    class Krepselis
    {
        private readonly List<Preke> _PirkiniuKrepselis;
        public readonly List<Preke> VisosPrekes;

        private const int DAUGIKLIS = 3;

        public Krepselis()
        {
            _PirkiniuKrepselis = new List<Preke>();
          
            VisosPrekes = new List<Preke>();
        }

        public void IdetiPreke(Preke preke)
        {
            _PirkiniuKrepselis.Add(preke);
            _PirkiniuKrepselis = new List<Preke>();
        }

        public double SkaiciuotiSuma()
        {
            double suma = 0;
            foreach (var item in _PirkiniuKrepselis)
            {
                suma += item.Kaina;
            }
            return suma;
        }

        public void IsimtiPreke(Preke preke)
        {
            _PirkiniuKrepselis.Remove(preke);
        }
    }

    class Klientas
    {
        public Krepselis pirkiniai;
        public string Adresas { get; set; }
        public string Vardas { get; set; }
        public int Id { get; set; }
    }


}
