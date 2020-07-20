using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace _20200720_LinqSuDuomenuBazemis
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\CSharp20200601\_20200720_LinqSuDuomenuBazemis\_20200720_LinqSuDuomenuBazemis\CRM.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            var klientus = db.GetTable<Klienta>().OrderBy(x=> x.Pavarde).ThenBy(x=> x.Vardas);
            db.GetTable<Adresai>().DeleteOnSubmit(db.GetTable<Adresai>().Where(x => x.KlientoId == 2).First());
            db.SubmitChanges();
            foreach (var item in klientus)
            {
                Console.WriteLine(item.Vardas + " " + item.Pavarde);
                foreach (var adresas in item.Adresais)
                {
                    Console.WriteLine(adresas.Gatve);
                }
            }

        }

        private void IdetiNaujaIrasa()
        {
            Klienta klientas = new Klienta();
            klientas.Vardas = "Pranas";
            klientas.Pavarde = "Pranauskas";
            klientas.Email = "prpr@er.com";
            Adresai adresas = new Adresai();
            adresas.Gatve = "Vosilos 15";
            adresas.Miestas = "Panevezys";
            adresas.Valstybe = "Lietuva";
            adresas.PastoKodas = "456987";

            klientas.Adresais.Add(adresas);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\GitHub\CSharp20200601\_20200720_LinqSuDuomenuBazemis\_20200720_LinqSuDuomenuBazemis\CRM.mdf;Integrated Security=True";
            DataContext db = new DataContext(connectionString);

            db.GetTable<Klienta>().InsertOnSubmit(klientas);
            db.SubmitChanges();
        }

    }


}
