using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200608_skaitymasIsFailo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"pavadinimas.txt"))
            {
                string line = null;
                while ((line = reader.ReadLine()) != null)
                {
                    Convert.ToInt32(line);
                    Console.WriteLine(line);
                }
            }



            using (StreamWriter writer = new StreamWriter("rasyti.ProgramavimoMokykla", true))
            {
                writer.WriteLine("Sveiki");
                writer.WriteLine("Rasau is programos");
                writer.Flush();
         
            }
           
        }
    }
}
