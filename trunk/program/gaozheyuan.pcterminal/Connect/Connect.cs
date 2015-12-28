using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace Connect
{
    public class Connect
    {
        private Socket clientsocket;
        private FileStream filestream;
        public Connect()
        {
            clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void ConnecttoServer(string ipaddress, Int32 port)
        {
            IPAddress[] IPs = Dns.GetHostAddresses(ipaddress);
            clientsocket.Connect(IPs, port);
        }

        public void sendFile(string filename)
        {
            filestream = new FileStream(filename, FileMode.Open);
            double total = 0;
            while (true)
            {
                byte[] content = new byte[1000];
                int numofbyte=filestream.Read(content,0,1000);
                if (numofbyte > 0)
                {
                    clientsocket.Send(content, numofbyte, SocketFlags.None);
                    total += numofbyte;
                    Console.WriteLine(numofbyte);
                }
                else
                {
                    clientsocket.Close();
                    break;
                }
            }
            Console.WriteLine("total bytes sent:" + total.ToString());
        }
    }
}
