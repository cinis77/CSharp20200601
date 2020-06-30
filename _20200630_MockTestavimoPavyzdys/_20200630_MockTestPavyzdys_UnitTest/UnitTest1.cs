using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _20200630_MockTestavimoPavyzdys;
using System.Runtime.Remoting.Messaging;

namespace _20200630_MockTestPavyzdys_UnitTest
{
    [TestClass]
    public class DuomenuParuosimas_UnitTest
    {
        [TestMethod]
        public void GerasHandShake_PateiksimeZodiLabas_TikimesGautiTrue()
        {
            FakeKomunikacija komunikacija = new FakeKomunikacija();
            FakeGautiDuomenis gautiDuomenis = new FakeGautiDuomenis();
            DuomenuParuosimas testuojamiDuomenys = new DuomenuParuosimas(komunikacija, gautiDuomenis);

            gautiDuomenis.SendString = "Labas";
            var rezultatas = testuojamiDuomenys.GerasHandShake("*Labas*");


            Assert.IsTrue(rezultatas);
        }

        [TestMethod]
        public void GerasHandShake_PateiksimeZodiLabas_TikimesGautiFalse()
        {
            FakeGautiDuomenis gautiDuomenis = new FakeGautiDuomenis();
            FakeKomunikacija komunikacija = new FakeKomunikacija();
            DuomenuParuosimas testuojamiDuomenys = new DuomenuParuosimas(komunikacija, gautiDuomenis);

            gautiDuomenis.SendString = "Sveiki";
            var rezultatas = testuojamiDuomenys.GerasHandShake("*Labas*");

            Assert.IsFalse(rezultatas);
        }

        [TestMethod]
        public void SiustiDuomenis_SiusimeZinuteLabas_TikimesGautiFormatuotaLabas()
        {
            FakeKomunikacija komunikacija = new FakeKomunikacija();
            FakeGautiDuomenis gautiDuomenis = new FakeGautiDuomenis();
            DuomenuParuosimas duomenys = new DuomenuParuosimas(komunikacija, gautiDuomenis);

            gautiDuomenis.SendString = "Labas";
            duomenys.SiustiDuomenis();
            var rezultatas = komunikacija.Message;

            Assert.AreEqual("*Labas*", rezultatas);
        }
    }

    class FakeKomunikacija : IKomunikacija
    {
        public string Message { get; set; }

        public string IP { get; set; }

        public int PortNo { get; set; }

        public bool Connect()
        {
            return true;
        }

        public string ReceivedMessage()
        {
            return Message;
        }

        public void SendMessage(string sendMessage)
        {
            Message = sendMessage;
        }
    }

    class FakeGautiDuomenis : IGautiDuomenisIsFailo
    {
        public string SendString { get; set; }

        public string GetDataLine()
        {
            return SendString;
        }
    }
}
