using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200623_PavyzdysPaveldejimai
{
    class A
    {
        public string Tekstas { get; set; }
        public int Skaicius { get; set; }


        public void Metodas()
        {
            Console.WriteLine(Tekstas + Skaicius);
        }
    }

    class B : A
    {
        public double Elementas { get; set; }
    }

    class C : A
    {
        public char Raide { get; set; }

    }

    class D : B
    {
        public DateTime Šiandiena { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            C objektas = new C();
            B ele = new B();
            objektas.Tekstas = "";
            ele.Skaicius = 99;

            A bazinesKlasesElementas = new A();
            bazinesKlasesElementas = new B();
            bazinesKlasesElementas = new C();
            bazinesKlasesElementas = new D();


            A a = new A();
            a = new B();
            a = new B() { Elementas = 657 };

            List<A> aaaa = new List<A>();
            aaaa.Add(ele);
            aaaa.Add(objektas);
            aaaa.Add(new D());

            Console.WriteLine( ((B)a).Elementas);
            ManoMetodas(a);
            ManoMetodas(new D());
            ManoMetodas(ele);
        }

        private static void ManoMetodas(A elementas)
        {

        }
    }
}
