using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200616_suZvaigzdute
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vardai = { "Genute", "Mild", "Rokas", "Povilas", "Meda" };
            Random rng = new Random();
            int kiekis = rng.Next(200);
            List<string> varduSarasas = new List<string>();
            for (int i = 0; i < kiekis; i++)
            {
                varduSarasas.Add(vardai[rng.Next(vardai.Length)]);
            }

            for (int i = 0; i < varduSarasas.Count - 1; i++)
            {
                Console.Write(varduSarasas[i] + ", ");
            }
            Console.WriteLine(varduSarasas.Last());

            //Value ir Reference
            int sk = 1;
            int sk1 = 0;
            //int sk2 = null;
            sk1 = sk;
            // int, string, char, double
            //------------------------------------
            List<int> A = new List<int> {1, 2, 3, 4, 5 };

            List<int> B = new List<int>();
            B = A;
            A.Clear();

            Console.WriteLine(B[0]);



        }
    }
}
