using System.IO;

namespace DuomenuRaymasIrSkaitymas
{
    public class RasymasText : IDuomenuRasymas
    {
        public string FailoKelias { get; }

        public bool ArFailasExistuoja()
        {
            if (File.Exists(FailoKelias))
            {
                return true;
            }
            return false;
        }

        public void Rasyti(string eilute)
        {
            using (StreamWriter writer = new StreamWriter(FailoKelias))
            {
                writer.WriteLine(eilute);
            }
        }

        public void RasytiINaujaFaila(string kelias, string tekstas)
        {
            using (StreamWriter writer = new StreamWriter(kelias))
            {
                writer.WriteLine(tekstas);
            }
        }
    }
}
