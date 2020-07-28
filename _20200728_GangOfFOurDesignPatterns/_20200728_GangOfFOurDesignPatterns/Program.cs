using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200728_GangOfFOurDesignPatterns
{
    class SingletonoKlase
    {
        

        public static void Metodas()
        {

        }

        public static void MetodasB(int a)
        {

        }


        private SingletonoKlase()
        {

        }

    }

    interface IBuilder
    {
        void BuildParts();
        Produktas GautiProdukta();
    }

    class CementoBuilder : IBuilder
    {
        private Produktas _produktas = new Produktas();

        public void BuildParts()
        {
            _produktas.PridetiComponentus(new List<IComponenet>
            {
                new CementoComponentas("Cementas"), new CementoComponentas("Cementas2") });
        }

        public Produktas GautiProdukta()
        {
            return _produktas;
        }
    }

    class MedzioBuilder : IBuilder
    {
        private Produktas _produktas = new Produktas();

        public void BuildParts()
        {
            _produktas.PridetiComponentus(new List<IComponenet>
            {
                new MedzioCoponentas("Medis"), new MedzioCoponentas("Medis1") });
        }

        public Produktas GautiProdukta()
        {
            return _produktas;
        }
    }

    interface IComponenet { }

    class CementoComponentas : IComponenet
    {
        private string _name;
        public CementoComponentas(string vardas)
        {
            _name = vardas;
        }


        public override string ToString()
        {
            return this.GetType().Name + "[" + _name + "]";
        }
    }

    class MedzioCoponentas : IComponenet
    {
        private string _name;
        public MedzioCoponentas(string vardas)
        {
            _name = vardas;
        }


        public override string ToString()
        {
            return this.GetType().Name + "[" + _name + "]";
        }
    }

    class Produktas
    {
        private List<IComponenet> _componentai = new List<IComponenet>();
        public void PridetiComponentus(List<IComponenet> comps)
        {
            _componentai.AddRange(comps);
        }

        public override string ToString()
        {
            return "Produktai :" + string.Join("", _componentai);
        }
    }

    class Brigada
    {
        public void Konstruoti(IBuilder builder)
        {
            builder.BuildParts();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            SingletonoKlase.Metodas();
            SingletonoKlase.MetodasB(12);


            Brigada brid = new Brigada();
            var B1 = new CementoBuilder();
            var B2 = new MedzioBuilder();

            brid.Konstruoti(B1);
            Console.WriteLine(B1.GautiProdukta());

            brid.Konstruoti(B2);
            Console.WriteLine(B2.GautiProdukta());


        }
    }
}
