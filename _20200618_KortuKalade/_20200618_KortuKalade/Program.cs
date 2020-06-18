using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200618_KortuKalade
{
    class Korta
    {
        public string Tipas { get; }
        public string Skaičius { get; }

        public Korta(string tipas, int skaicius)
        {
            Tipas = tipas;
            Skaičius = PaverstiIsSkaiciausISimoboli(skaicius);
        }

        private string PaverstiIsSkaiciausISimoboli(int skaicius)
        {
            string elementas = "";
            switch (skaicius)
            {
                case 1:
                    elementas = "A";
                    break;
                case 11:
                    elementas = "J";
                    break;
                case 12:
                    elementas = "Q";
                    break;
                case 13:
                    elementas = "K";
                    break;
                default:
                    elementas = skaicius.ToString();
                    break;
            }

            return elementas;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Korta> kalade = new List<Korta>();
            Random rng = new Random();
            string[] tipai = { "Š", "B", "K", "P" };
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(tipai[rng.Next(tipai.Length)], rng.Next(1, 14));
                bool naujaKorta = true;
                foreach (var kortele in kalade)
                {
                    if (kortele.Skaičius == korta.Skaičius && korta.Tipas == kortele.Tipas)
                    {
                        naujaKorta = false;
                        break;
                    }
                }

                if (naujaKorta)
                {
                    kalade.Add(korta);
                    i++;
                }
            }


            foreach (var korta in kalade)
            {
                Console.WriteLine(korta.Tipas + " " + korta.Skaičius);
            }
        }
    }
}
