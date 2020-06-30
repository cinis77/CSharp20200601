using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace _20200630_MockTestavimoPavyzdys
{

    public class Komunikacija : IKomunikacija
    {
        TcpClient _Clientas;
        NetworkStream _Network;
        public string IP { get; }
        public int PortNo { get; }

        public Komunikacija(string ip, int portNo)
        {
            IP = ip;
            PortNo = portNo;

        }

        public bool Connect()
        {
            _Clientas = new TcpClient(IP, PortNo);
            _Network = _Clientas.GetStream();

            return true;
        }

        public void SendMessage(string sendMessage)
        {
            byte[] buffer = new byte[8];

            _Network.Write(buffer, 8, 8);
        }

        public string ReceivedMessage()
        {
            byte[] buffer = new byte[8];
            _Network.Read(buffer, 8, 8);
            return buffer.ToString();
        }
    }


    public class DuomenuParuosimas
    {
        private IKomunikacija Coms;
        private IGautiDuomenisIsFailo Data;

        public DuomenuParuosimas(IKomunikacija komunikacija, IGautiDuomenisIsFailo data)
        {
            Coms = komunikacija;
            Data = data;
        }

        public void SiustiDuomenis()
        {
            string rawData = Data.GetDataLine();
            rawData = "*" + rawData + "*";
            Coms.SendMessage(rawData);
            while (!GerasHandShake(rawData))
            {
                Coms.SendMessage(rawData);
            }
        }

        public bool GerasHandShake(string message)
        {
            var me = message;
            me = message.TrimStart('*');
            me = me.TrimEnd('*');
            if (Data.GetDataLine() == me)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class GautiDuomenisIsFailo : IGautiDuomenisIsFailo
    {
        StreamReader reader;

        public GautiDuomenisIsFailo(string connectionString)
        {
            reader = new StreamReader(connectionString);
        }

        public string GetDataLine()
        {
            return reader.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
