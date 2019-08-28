using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SendUDP
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 0;
            Int32.TryParse(args[1], out port);
            UdpClient udpClient = new UdpClient();
            IPAddress ipAddress = IPAddress.Parse(args[0]);
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);

            Byte[] sendBytes = Encoding.ASCII.GetBytes(args[2]);
            try
            {
                udpClient.Send(sendBytes, sendBytes.Length, ipEndPoint);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}