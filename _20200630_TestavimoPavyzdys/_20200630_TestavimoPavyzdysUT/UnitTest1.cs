using System;
using _20200630_TestavimoPavyzdys;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _20200630_TestavimoPavyzdysUT
{
    [TestClass]
    public class Rezervacija_UnitTest
    {
        [TestMethod]
        public void AtsauktiRezervacija_KlientasIsAdmin_TikimesGautiTrue()
        {
            // Susikuriami visi reikalingi testui kintamieji
            Rezervacija rezervacija = new Rezervacija(new Klientas());
            Klientas testKlientas = new Klientas() { IsAdmin = true };
            // Atliekami visi testo veiksmai

            var rezultatas = rezervacija.AtsauktiRezervacija(testKlientas);

            // Patikrinama testo salyga
            Assert.IsTrue(rezultatas);
        }

        [TestMethod]
        public void AtsauktiRezervacija_KlientasYraAtsaukejas_TikimesGautiTrue()
        {
            Klientas testKlientas = new Klientas();
            Rezervacija rezervacija = new Rezervacija(testKlientas);

            var rezultatas = rezervacija.AtsauktiRezervacija(testKlientas);

            Assert.IsTrue(rezultatas);
        }

        [TestMethod]
        public void AtsauktiRezervacija_RezervatoriusNeraAtsaukejas_TikimesGautiFalse()
        {
            Rezervacija rezervacija = new Rezervacija(new Klientas());

            var rezultatas = rezervacija.AtsauktiRezervacija(new Klientas());

            Assert.IsFalse(rezultatas);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void GautiRezervacijosKodaIsTeksto_PateikiamasTekstasSuRaidemis_TikimasiKlaidos()
        {
            Rezervacija rezervacija = new Rezervacija(new Klientas());
            string testuojamasTekstas = "abc";

            rezervacija.GautiRezervacijosKodaIsTeksto(testuojamasTekstas);
            
        }

        [TestMethod]
        public void GautiRezervacijosKodaIsTeksto_PateikiamiSkaicia123_TikimasiGauti123()
        {
            Rezervacija rezervacija = new Rezervacija(new Klientas());
            string testuojamasTekstas = "123";

            var rezultatas = rezervacija.GautiRezervacijosKodaIsTeksto(testuojamasTekstas);

            Assert.AreEqual(123, rezultatas);
        }
    }
}
