using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200625_Interface
{
    interface IKomunikacija
    {
        string message { get; set; }
        
        string buffer { get; set; }

        string EndPoint { get; }

        void SendMessage(string message);

        string Atsakymas();

        void FormuotiZinunte(string zinute);

        void SendMessage();

    }

    class DuomenuGavima
    {
        IKomunikacija komunikacija;

        public DuomenuGavima(IKomunikacija coms)
        {
            komunikacija = coms;
        }

        public void FormuotiDuomenis(string data)
        {
            data = "*" + data + "*";
            komunikacija.SendMessage(data);
        }

        public string GavejoAdresas()
        {
            return komunikacija.EndPoint;
        }
    }

    class TCPIPKomunikacija : IKomunikacija
    {

        private string _message;
        public string message 
        { 
            get
            {
                return _message;
            }
            set
            {
                _message = "#" + value + "#";
            }
        }
        public string buffer { get; set; }
        public string EndPoint { get; }

        public void SendMessage(string message)
        {
            Console.WriteLine("Siunciu per TCP/IP zinute: " + message);
        }

        public string Atsakymas()
        {
            return _message;
        }

        public void FormuotiZinunte(string zinute)
        {
            message = zinute;
        }

        public void SendMessage()
        {
            Console.WriteLine("Siunciu per TCP/Ip zinute: " + message);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            TCPIPKomunikacija komunikacija = new TCPIPKomunikacija();

            DuomenuGavima duomenys = new DuomenuGavima(komunikacija);
            duomenys.FormuotiDuomenis("Imk duomenis");
        }
    }
}
