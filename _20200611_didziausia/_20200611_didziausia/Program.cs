using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200611_didziausia
{
    class Program
    {
        static void Main(string[] args)
        {
            int maziausias = int.MaxValue;
            int didziausia = int.MinValue;

            int[] masyvas = new int[6];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] < maziausias)
                {
                    maziausias = masyvas[i];
                }

                if (masyvas[i] > didziausia)
                {
                    didziausia = masyvas[i];
                }
            }
            Console.WriteLine(didziausia);
            Console.WriteLine(maziausias);
            Console.WriteLine(masyvas.Max());
            Console.WriteLine(masyvas.Min());
        }
    }
}
