namespace _20200630_MockTestavimoPavyzdys
{
    public interface IKomunikacija
    {
        string IP { get; }
        int PortNo { get; }

        bool Connect();
        string ReceivedMessage();
        void SendMessage(string sendMessage);
    }
}