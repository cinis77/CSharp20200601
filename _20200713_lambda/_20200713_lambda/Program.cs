using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200713_lambda
{

    class Vartotojas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public int Amzius { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>() { 1, 2, 4, 3, 8, 9, 8, 100 };
            int i = 5;
            List<Vartotojas> vartotojai = new List<Vartotojas>();
            var vyriausias = vartotojai.Where(vartotojas => vartotojas.Amzius == vartotojai.Max(y => y.Amzius));
            Action action = () =>
            {
                Console.WriteLine("Sveikas pasaulis");
                int y = 0;
                Console.WriteLine(y);
            };

            action();
            Func<int, bool> filtras = x => x > i;
            var elementai = skaiciai.Where(filtras);
            elementai.ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
