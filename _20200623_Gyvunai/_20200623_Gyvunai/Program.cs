using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200623_Gyvunai
{
    class Gyvunas
    {
        public string Vardas { get; set; }
        public int Amzius { get; set; }
        protected double Greitis {get; set;}
        private string Spalva { get; set; }
        public Gyvunas(string vardas)
        {
            Vardas = vardas;
            Greitis = 100;
        }

        public Gyvunas(int amzius)
        {

        }

        public virtual void VirtulusMetodas()
        {
            Console.WriteLine("Iškviečiamas virtualus metodas");
        }
    }

    class Suo : Gyvunas
    {
        public Suo(string var) : base(var)
        {
            Greitis = 10;
            
        }
    }

    class Kate : Gyvunas
    {
        public Kate(string vardas) : base(vardas)
        {

        }

        public override void VirtulusMetodas()
        {
            base.VirtulusMetodas();

            Console.WriteLine("Pridedu ekstra");
        }
    }

    class Ozys : Gyvunas
    {
        public Ozys(string vard) : base(vard)
        {

        }

        public override void VirtulusMetodas()
        {
            Console.WriteLine("Aspirašyti savo implementacija");
        }
    }

    class Dramblys : Gyvunas
    {
        public Dramblys(string vrd) : base(vrd)
        {

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Gyvunas> gyvunai = new List<Gyvunas>();
            gyvunai.Add(new Suo("Suo1") );
            gyvunai.Add(new Suo("Suo1") { Vardas = "Suo2" });
            gyvunai.Add(new Suo("Suo1") { Vardas = "Suo3" });
            gyvunai.Add(new Kate("Suo1") { Vardas = "Cat" });
            gyvunai.Add(new Kate("Suo1") { Vardas = "Cat1" });
            gyvunai.Add(new Kate("Suo1") { Vardas = "Cat2" });
            gyvunai.Add(new Ozys("Suo1") { Vardas = "Oz" });
            gyvunai.Add(new Ozys("Suo1") { Vardas = "Ozys" });
            gyvunai.Add(new Dramblys("Suo1") { Vardas = "Dramblys" });

            Gyvunas gyv = new Gyvunas("Suo1");
          

            foreach (var item in gyvunai)
            {
                Console.WriteLine(item.Vardas);
                item.VirtulusMetodas();
            }
            int kiekisKacius = 0;
            foreach (var item in gyvunai)
            {
                if (item is Kate)
                {
                    kiekisKacius++;
                }
            }

            Console.WriteLine(kiekisKacius);
        }

        private static void MEthod<T>()
        {
            T elemen;
        }
    }
}
