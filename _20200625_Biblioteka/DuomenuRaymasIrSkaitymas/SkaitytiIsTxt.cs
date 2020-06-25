using System.IO;

namespace DuomenuRaymasIrSkaitymas
{
    class SkaitytiIsTxt : IDuomenuSkaitymas
    {
        public string FailoKelias { get; }
        private IDuomenuRasymas Rasymas;

        public SkaitytiIsTxt(string failoKelias, IDuomenuRasymas rasymas)
        {
            FailoKelias = failoKelias;
            Rasymas = rasymas;
        }

        public bool ArFailasExistuoja()
        {
            if (System.IO.File.Exists(FailoKelias))
            {
                return true;
            }
            return false;
        }

        public string Skaityti()
        {
            using (StreamReader reader = new StreamReader(FailoKelias))
            {
                return reader.ReadToEnd();
            }
        }

        public void SkaitytiIrRasytiInauja(string kelias)
        {
            using (StreamReader reader = new StreamReader(FailoKelias))
            {
                Rasymas.RasytiINaujaFaila(kelias, reader.ReadToEnd());
            }
        }
    }
}
