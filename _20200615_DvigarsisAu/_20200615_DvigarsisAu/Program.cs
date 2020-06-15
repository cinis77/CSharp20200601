using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200615_DvigarsisAu
{
    class Program
    {
        static void Main(string[] args)
        {
            int kiekis = 0;
            string ivedima = "*";
            while (!string.IsNullOrEmpty(ivedima))
            {
                var data = ivedima.Split(' ');
                foreach (var zodis in data)
                {
                    char[] raides = zodis.ToLower().ToCharArray();
                    for (int i = 1; i < raides.Length; i++)
                    {
                        if (raides[i-1] == 'a' && raides[i] == 'u')
                        {
                            kiekis++;
                        }
                    }
                }
                ivedima = Console.ReadLine();
            }
            Console.WriteLine("Misriuju dvigarsiu au buvo: " + kiekis);
        }
    }
}
