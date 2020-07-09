using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200707_ExceptionsWinForm
{

    class VykstaVeiksmas
    {
        public void Metodas()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    throw new BibliotekaSugeneravauPatsException("Mano klaida");
                }

            }
        }
    }


    class BibliotekaSugeneravauPatsException : Exception
    {
        public string Kazkas { get; set; }

        public BibliotekaSugeneravauPatsException()
        {

        }

        public BibliotekaSugeneravauPatsException(string message):base(message)
        {
            
        }

        public void Metodas()
        {

        }
    }

    class IvykoKlada : Exception
    {

    }
}
