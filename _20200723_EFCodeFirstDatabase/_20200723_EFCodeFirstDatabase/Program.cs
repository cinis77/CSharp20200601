using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace _20200723_EFCodeFirstDatabase
{

    class Klientas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime GimimoMetai { get; set; }
        public double Ugis { get; set; }
        public Adresas Adresas { get; set; }
    }

    class Adresas
    {
        public int Id { get; set; }
        public string Gatve { get; set; }
        public int NamoNr { get; set; }
        public string Miestas { get; set; }
        public string Valstybe { get; set; }
        public string PostCode { get; set; }

    }

    class VartotojuDB : DbContext
    {
        public DbSet<Klientas> Klientai { get; set; }
        public DbSet<Adresas> Adresas { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            VartotojuDB dB = new VartotojuDB();
            Klientas klient = new Klientas();
            klient.Vardas = "smt smt";
            klient.Pavarde = "kaz kaz";
            klient.GimimoMetai = DateTime.Now;
            
            dB.Klientai.Add(klient);
            dB.SaveChanges();
        }
    }
}
