using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200615_Miestai
{
    class Program
    {
        static void Main(string[] args)
        {
            var duomenys = NuskaitytiDuomenys();
            string[] miestai = new string[duomenys.Length];
            string[] valstybes = new string[duomenys.Length];
            for (int i = 0; i < duomenys.Length; i++)
            {
                AtskirtiDuomenuEilute(duomenys[i], out miestai[i], out valstybes[i]);
            }

            for (int i = 0; i < duomenys.Length; i++)
            {
                Console.WriteLine(miestai[i] + " - " + valstybes[i]);
            }
            string[] atsakymasValstybe = new string[0];
            int[] kiekis = new int[0];
            GautiAtsakyma(valstybes, out atsakymasValstybe, out kiekis);
            for (int i = 0; i < atsakymasValstybe.Length; i++)
            {
                Console.WriteLine("Valstybeje {0} yra {1} miestu", atsakymasValstybe[i], kiekis[i]);
            }

        }

        private static void GautiAtsakyma(string[] valstybes, out string[] valstybiuAtsrinka, out int[] kiekisMiestu)
        {
            valstybiuAtsrinka = new string[1] { valstybes[0] };
            kiekisMiestu = new int[1] { 0 };

            for (int i = 0; i < valstybes.Length; i++)
            {
                bool NaujaValstybe = true;
                for (int j = 0; j < valstybiuAtsrinka.Length; j++)
                {
                    if (valstybes[i] == valstybiuAtsrinka[j])
                    {
                        NaujaValstybe = false;
                        kiekisMiestu[j]++;
                        break;
                    }
                }

                if (NaujaValstybe)
                {
                    string[] tempValstybe = valstybiuAtsrinka;
                    int[] tempKiekisMiestu = kiekisMiestu;
                    valstybiuAtsrinka = new string[tempValstybe.Length + 1];
                    for (int k = 0; k < tempValstybe.Length; k++)
                    {
                        valstybiuAtsrinka[k] = tempValstybe[k];
                    }
                    kiekisMiestu = new int[tempKiekisMiestu.Length + 1];
                    for (int k = 0; k < tempKiekisMiestu.Length; k++)
                    {
                        kiekisMiestu[k] = tempKiekisMiestu[k];
                    }
                    valstybiuAtsrinka[valstybiuAtsrinka.Length - 1] = valstybes[i];
                    kiekisMiestu[kiekisMiestu.Length - 1] = 1;
                }
            }
        }

        private static void AtskirtiDuomenuEilute(string eilute, out string miesta, out string valstybe)
        {
            var atskirti = eilute.Split(' ');
            miesta = atskirti[0];
            valstybe = atskirti[1];
        }


        private static string[] NuskaitytiDuomenys()
        {
            System.IO.StreamReader reader = new System.IO.StreamReader("miestai.txt");
            int kiekis = int.Parse(reader.ReadLine());
            string[] duomenys = new string[kiekis];
            for (int i = 0; i < kiekis; i++)
            {
                duomenys[i] = reader.ReadLine();
            }
            reader.Close();
            return duomenys;
        }
    }
}
