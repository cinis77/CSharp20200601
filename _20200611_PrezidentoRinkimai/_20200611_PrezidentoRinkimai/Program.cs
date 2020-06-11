using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200611_PrezidentoRinkimai
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("kandidatai.txt");
            string[] duomenys = reader.ReadLine().Split(' ');
            reader.Close();
            int maxRaidziuKiekis = 0;
            int laimetojas = -1;
            for (int i = 0; i < duomenys.Length; i++)
            {
                int raides = KiekisUnikaliuRaidziu(duomenys[i].ToLower().ToCharArray());
                if (raides > maxRaidziuKiekis)
                {
                    maxRaidziuKiekis = raides;
                    laimetojas = i;
                }
            }
            Console.WriteLine("Laimetojas yra " + duomenys[laimetojas]);

        }


        public static int KiekisUnikaliuRaidziu(char[] raides)
        {
            int kiekisUnikaliuRaidziu = 0;
            for (int i = 0; i < raides.Length; i++)
            {
                bool unikaliRaide = true;
                for (int j = i+1; j < raides.Length; j++)
                {
                    if (raides[i] == raides[j])
                    {
                        unikaliRaide = false;
                        break;
                    }
                }

                if (unikaliRaide)
                {
                    kiekisUnikaliuRaidziu++;
                }
            }
            return kiekisUnikaliuRaidziu;
        }
    }
}
