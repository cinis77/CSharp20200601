using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Paveldejimai
{

    abstract class InformacijosRasymas
    {
        public abstract void RasytiInformacija();
        
    }

    class RasymasITekstiniFaila : InformacijosRasymas
    {
        public override void RasytiInformacija()
        {
            using (StreamWriter writer = new StreamWriter(""))
            {
                writer.WriteLine();
            }
        }
    }

    class RasymasIConsoleLanga : InformacijosRasymas
    {
        public override void RasytiInformacija()
        {
            Console.WriteLine();
        }
    }


    class ManoKlase
    {
        public int Skaiciai { get; set; }
        public string Tekstas { get; set; }


        public void Metodas()
        {
            Console.WriteLine(Tekstas);
        }

        public virtual void MetodoPavadinimas()
        {

        }
    }


    class Paveldinti : ManoKlase
    {
        public string PapildomiElementai { get; set; }
        
        public void PapildomusMetodus()
        {

        }

        public override void MetodoPavadinimas()
        {
            base.MetodoPavadinimas();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ManoKlase bazineKlase = new Paveldinti();
            Paveldinti paveldinti = (Paveldinti)bazineKlase;

            object abstraktusObjektas;

            abstraktusObjektas = 1;
            abstraktusObjektas = bazineKlase;
            abstraktusObjektas = "Tekstas";
            abstraktusObjektas = 'a';
            abstraktusObjektas = 457.457;




        }
    }
}
