using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200615_Vyariausias
{
    class Program
    {
        static void Main(string[] args)
        {
            string vyriausiasVyras = "99999999999";
            string vyriausiaMoteris = "99999999999";
            DateTime vyriausioVyroGimimoData = DateTime.Today;
            DateTime vyriausiosMotersGimimoData = DateTime.Today;
            string atsakymas = "-";
            while (!string.IsNullOrEmpty(atsakymas))
            {
                Console.WriteLine("Iveskite asmens koda");
                atsakymas = Console.ReadLine();
                if (string.IsNullOrEmpty(atsakymas))
                {
                    break;
                }
                var kodas = atsakymas.ToCharArray();
                if (kodas[0] == '3' || kodas[0] == '5')
                {
                    string metai = null;
                    if (kodas[0] == '3')
                    {
                        metai = "19" + kodas[1].ToString() + kodas[2].ToString();
                        
                    }
                    else
                    {
                        metai = "20" + kodas[1].ToString() + kodas[2].ToString();

                    }
                    string menuo = kodas[3].ToString() + kodas[4].ToString();
                    string diena = kodas[5].ToString() + kodas[6].ToString();
                    DateTime gimimoData = new DateTime(year: int.Parse(metai), month: int.Parse(menuo), day: int.Parse(diena));
                    if (gimimoData<vyriausioVyroGimimoData)
                    {
                        vyriausiasVyras = atsakymas;
                        vyriausioVyroGimimoData = gimimoData;
                    }
                    else if (gimimoData == vyriausioVyroGimimoData)
                    {
                        int vyr = int.Parse(vyriausiasVyras.ToCharArray()[7].ToString() 
                            + vyriausiasVyras.ToCharArray()[8]
                            + vyriausiasVyras.ToCharArray()[9]
                            + vyriausiasVyras.ToCharArray()[10]);
                        int tikrinamas = int.Parse(kodas[7].ToString()
                            + kodas[8]
                            + kodas[9]
                            + kodas[10]);
                        if (vyr > tikrinamas)
                        {
                            vyriausiasVyras = kodas.ToString();
                            vyriausioVyroGimimoData = gimimoData;
                        }
                    }
                }
                else
                {
                    string metai = null;
                    if (kodas[0] == '4')
                    {
                        metai = "19" + kodas[1].ToString() + kodas[2].ToString();

                    }
                    else
                    {
                        metai = "20" + kodas[1].ToString() + kodas[2].ToString();

                    }
                    string menuo = kodas[3].ToString() + kodas[4].ToString();
                    string diena = kodas[5].ToString() + kodas[6].ToString();
                    DateTime gimimoData = new DateTime(year: int.Parse(metai), month: int.Parse(menuo), day: int.Parse(diena));
                    if (gimimoData < vyriausiosMotersGimimoData)
                    {
                        vyriausiaMoteris = atsakymas;
                        vyriausiosMotersGimimoData = gimimoData;
                    }
                    else if (gimimoData == vyriausiosMotersGimimoData)
                    {
                        int mot = int.Parse(vyriausiaMoteris.ToCharArray()[7].ToString()
                            + vyriausiaMoteris.ToCharArray()[8]
                            + vyriausiaMoteris.ToCharArray()[9]
                            + vyriausiaMoteris.ToCharArray()[10]);
                        int tikrinamas = int.Parse(kodas[7].ToString()
                            + kodas[8]
                            + kodas[9]
                            + kodas[10]);
                        if (mot > tikrinamas)
                        {
                            vyriausiaMoteris = kodas.ToString();
                            vyriausiosMotersGimimoData = gimimoData;
                        }
                    }
                }
            }
            Console.WriteLine("Vyriausias vyras: " + vyriausioVyroGimimoData.ToShortDateString());
            Console.WriteLine("Vyriausia moteris: " + vyriausiosMotersGimimoData.ToShortDateString());
        }
    }
}
