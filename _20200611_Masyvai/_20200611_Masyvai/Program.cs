using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200611_Masyvai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masyvas = { 0, 8, -6, 8, 7, 6, 2 };
            Console.WriteLine(masyvas[0]);
            Console.WriteLine(masyvas[masyvas.Length - 1]);

            int[] m = new int[10];
            m[0] = 1;
            m[1] = 2;
            m[2] = 3;
            m[3] = 4;
            m[4] = 5;
            m[6] = 6;


            Console.WriteLine("Iveskite skaicius juo atskiriant tarpu");
            string data = Console.ReadLine();
            string[] atskirtiDuomenys = data.Split(' ');
            string dd;
            Console.WriteLine(atskirtiDuomenys.Length);
            int[] duomenuSkaiciai = new int[atskirtiDuomenys.Length];
            for (int i = 0; i < atskirtiDuomenys.Length; i++)
            {
                duomenuSkaiciai[i] = Convert.ToInt32(atskirtiDuomenys[i]);
            }







            Console.WriteLine("Iveskite viena zodi");
            string zodis = Console.ReadLine();
            char[] raides = zodis.ToCharArray();
            string[][][] mas = new string[10][][];
            dd = "";
        }
    }
}
