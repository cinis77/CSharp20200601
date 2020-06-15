using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200615_DidejantysSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaicius");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int kazkas = 1;
            int kiekis = 0;
            while (kazkas < skaicius)
            {
                kiekis++;
                kazkas *= 2;
            }

            int[] masyvas = new int[kiekis];
            masyvas[0] = 1;
            for (int i = 1; i < masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1] * 2;
            }

            foreach (int sk in masyvas)
            {
                Console.WriteLine(sk);
            }
        }
    }
}
