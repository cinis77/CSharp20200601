using System;
using System.Net.Http.Headers;

namespace DuomenuRaymasIrSkaitymas
{
    public interface IDuomenuRasymas
    {
        string FailoKelias { get; }

        bool ArFailasExistuoja();

        void Rasyti(string eilute);

        void RasytiINaujaFaila(string kelias, string tekstas);

    }

    public interface IDuomenuSkaitymas
    {

        string FailoKelias { get; }

        bool ArFailasExistuoja();

        string Skaityti();

        void SkaitytiIrRasytiInauja(string kelias);

    }


    public class TekstoTxtSkaitymasIrRasymas
    {
        IDuomenuRasymas rasymas;
        IDuomenuSkaitymas skaitymas;
        string FailoKelias; 

        public TekstoTxtSkaitymasIrRasymas()
        {
            rasymas = new RasymasText();
            skaitymas = new SkaitytiIsTxt(rasymas: rasymas, failoKelias: FailoKelias);
        }

        public TekstoTxtSkaitymasIrRasymas(IDuomenuRasymas specRasymas, IDuomenuSkaitymas specSkaitymas)
        {
            rasymas = specRasymas;
            skaitymas = specSkaitymas;
        }

        public string SkaitytiFaila()
        {
            if (skaitymas.ArFailasExistuoja())
            {
                return skaitymas.Skaityti();
            }
            else
            {
                return null;
            }
        }

        public void RasytiFaila(string tesktas)
        {
            rasymas.Rasyti(tesktas);
        }

        public void PerrasytiFaila(string tikslinisFailas)
        {
            skaitymas.SkaitytiIrRasytiInauja(tikslinisFailas);
        }
    }
}
