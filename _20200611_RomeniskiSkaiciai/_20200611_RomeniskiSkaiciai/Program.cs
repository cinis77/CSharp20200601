using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200611_RomeniskiSkaiciai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());

            int tuskt = skaicius / 1000;
            int simtai = skaicius / 100 % 10; // 1356 / 100 = 13 % 10 = 3
            int desimtys = skaicius / 10 % 10; // 1356 / 10 = 135 % 10 = 5
            int vnt = skaicius % 10; // 1356 % 10 = 6

            string atsakymas = KonvertavimasIsSkaiciausIRomoniskai(tuskt, "M", "M", "M");
            atsakymas += KonvertavimasIsSkaiciausIRomoniskai(simtai, "C", "D", "M");
            atsakymas += KonvertavimasIsSkaiciausIRomoniskai(desimtys, "X", "L", "C");
            atsakymas += KonvertavimasIsSkaiciausIRomoniskai(vnt, "I", "V", "X");
            Console.WriteLine(atsakymas);
        }

        public static string KonvertavimasIsSkaiciausIRomoniskai(int sk, string vnt, string penki, string desimt)
        {
            if (sk == 4)
            {
                return vnt + penki;
            }
            else if ( sk == 9)
            {
                return vnt + desimt;
            }
            else
            {
                string atsakymas = "";
                int arReikia5 = sk / 5;
                if (arReikia5 == 1)
                {
                    atsakymas += penki;
                }
                int vienetuSkaicius = sk % 5;
                for (int i = 0; i < vienetuSkaicius; i++)
                {
                    atsakymas += vnt;
                }
                return atsakymas;
            }
        }
    }
}
