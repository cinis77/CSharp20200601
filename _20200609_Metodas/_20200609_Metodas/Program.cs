using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200609_Metodas
{
    class Program
    {
        /// <summary>
        /// Pasisveikinimo programa
        /// </summary>
        public static void Pasisveikinti()
        {
            Console.WriteLine("Sveikas pasauli");
        }

        /// <summary>
        /// Savo komentara
        /// </summary>
        /// <param name="a">Cia bus gaunamas skacius</param>
        /// <param name="b">Cia bus gaunamas zodis</param>
        /// <param name="c">Cia bus gaunama raide</param>
        public static void Pavadinimas(int a, string b, char c)
        {
            // rasom koda
        }

        void Metodas()
        {

        }

        private static int Suma(int a, int b)
        {
            return a + b;
        }

        private static int Skirtumas(int a, int b)
        {
            return a - b;
        }

        private static int Sandauga(int a, int b)
        {
            return a * b;
        }

        private static double Dalyba(int a, int b)
        {
            return (double)a / b;
        }

        public static void TekstoMetodas(string tekstas)
        {
            Console.WriteLine(tekstas);
        }

        static void Main(string[] args)
        {
            Pasisveikinti();
            Program p = new Program();
            p.Metodas();
            TekstoMetodas("Mano tekstas");
            Pavadinimas(b: "zodis", a: 654, c: 'R');
            Program.Pasisveikinti();
            int skaicius = 100;
            string zodis = "LAbas";
            char raide = 'r';
            Pavadinimas(skaicius, zodis, raide);
            Pavadinimas(100, "zodis", 'r');
            int result;
            
            int.TryParse("10", out result);
        }
    }
}
