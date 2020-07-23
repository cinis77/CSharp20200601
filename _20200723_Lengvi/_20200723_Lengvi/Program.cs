using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200723_Lengvi
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------
            int[] M = { 10, 58, -9, 65, -1000, 6, 8, 9, 8, 0, 654, 8, 32147, 8520, 285, 98741, 10365, 1, -6325, 21 };
            M = M.OrderBy(x => x).ToArray();
            foreach (var item in M)
            {
                Console.Write(item + " ");
            }
            //-----------------------
            Console.WriteLine();
            Random rng = new Random();
            int skaicius = rng.Next(-10000, 10000);
            for (int i = 1; i <= skaicius; i++)
            {
                if (skaicius % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            //------------------------
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.Write(((double)1 / i).ToString("F3") + " ");
            }
            Console.WriteLine();
        }
    }
}
