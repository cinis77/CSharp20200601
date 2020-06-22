using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _20200615_TemperaturuVidurkis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite visas temperaturas, kurias norite fiksuoti atskiriant per tarpa");
            var duomenys = Console.ReadLine().Split(' ');
            int[] temperaturos = new int[duomenys.Length];
            int suma = 0;
            for (int i = 0; i < temperaturos.Length; i++)
            {
                temperaturos[i] = int.Parse(duomenys[i]);
            }
            for (int i = 0; i < temperaturos.Length; i++)
            {
                if (temperaturos[i] < temperaturos.Average())
                {
                    suma += temperaturos[i];
                }
            }


            Console.WriteLine("Temperaturu vidurkis yra: " + temperaturos.Average());
            Console.WriteLine("Didziausia temperatura yra: " + temperaturos.Max());
            Console.WriteLine("Maziausia temperatura yra: " + temperaturos.Min());
            Console.WriteLine("Suma mazesniu nei vidurkis yra: " + suma);
        }
    }
}
