using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200616_Sarasai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pavadinimas = new List<int>();

            pavadinimas.Add(5);
            pavadinimas.Add(5);
            pavadinimas.Add(6);
            pavadinimas.Add(25);

            foreach (int elementasSarase in pavadinimas)
            {
                Console.WriteLine(elementasSarase);
            }

            pavadinimas.Remove(5);
            foreach (int elementasSarase in pavadinimas)
            {
                Console.WriteLine(elementasSarase);
            }

            pavadinimas.RemoveAt(1);
            foreach (int elementasSarase in pavadinimas)
            {
                Console.WriteLine(elementasSarase);
            }

            Console.WriteLine(pavadinimas.ElementAt(0));
            Console.WriteLine(pavadinimas[0]);
            for (int i = 0; i < pavadinimas.Count; i++)
            {
                Console.WriteLine(pavadinimas[i]);
            }
            pavadinimas.Clear();
        }
    }
}
