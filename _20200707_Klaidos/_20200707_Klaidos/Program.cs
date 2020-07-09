using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200707_Klaidos
{
    class Manoklase
    {
        public void MetodasA(int skaicius)
        {
            if (skaicius == 0)
            {
                throw new ArgumentException("Buvo atsiustas 0");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int skaicius = 0;
                Manoklase mano = new Manoklase();
                mano.MetodasA(0);
                Console.WriteLine(skaicius);
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Pateikstas blogas skaicius");
            }
            catch(FormatException ex)
            {

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Pabaiga programos");
            }

            Console.ReadKey();
        }
    }
}
