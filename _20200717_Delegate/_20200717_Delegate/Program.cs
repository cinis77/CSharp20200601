using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200717_Delegate
{
    public delegate string ManoPirmasDelegatas(int sk);


    class ManoKlase
    {
        public readonly Dictionary<string, ManoPirmasDelegatas> StrategyPatern;
        public ManoKlase()
        {
            StrategyPatern = new Dictionary<string, ManoPirmasDelegatas>();
        }


        public void Metodas(string key)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(StrategyPatern[key](i));
            }
        }
    }


    class Program
    {
        //Strategy design pattern


        static void Main(string[] args)
        {
            ManoKlase mano = new ManoKlase();
            mano.StrategyPatern.Add("1", Metodas);
            mano.StrategyPatern.Add("2", MetodasA);
            Console.WriteLine("Iveskite 1 arba 2");
            var duomuo = Console.ReadLine();
            mano.Metodas(duomuo);
        }

        private static string MetodasA(int skaicius)
        {
            return "Tekstas "+ ++skaicius;
        }

        private static string Metodas(int skaicius)
        {
            return skaicius.ToString();
        }
    }
}
