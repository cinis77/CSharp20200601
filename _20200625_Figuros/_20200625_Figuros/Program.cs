using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Figuros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuros = new List<Figura>();
            figuros.Add(new Apskritimas() { R = 5 });
            figuros.Add(new Staciakampis() { a = 25, b = 15 });
            figuros.Add(new Trikampis() { a = 3, b = 4 });
            figuros.Add(new Kvadratas() { a = 9 });
            
            foreach (var figura in figuros)
            {
                Console.WriteLine("Plotas = {0}, Perimetras = {1}, Figura= {2}", 
                    figura.Plotas(), figura.Perimetras(), figura.GetType());

            }
        }
    }
}
