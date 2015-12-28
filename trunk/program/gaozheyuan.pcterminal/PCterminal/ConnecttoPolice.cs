using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Drawing;
using System.Drawing.Imaging;
namespace PCterminal.Network
{
    public class ConnecttoPolice
    {
        private Socket clientsocket;
        private FileStream filestream;
        public ConnecttoPolice()
        {
            clientsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void ConnecttoServer(string ipaddress, Int32 port)
        {
            IPAddress[] IPs = Dns.GetHostAddresses(ipaddress);
            clientsocket.Connect(IPs, port);
        }

        public void SendFile(string filename)
        {
            filestream = new FileStream(filename, FileMode.Open);
            double total = 0;
            while (true)
            {
                byte[] content = new byte[1000];
                int numofbyte = filestream.Read(content, 0, 1000);
                if (numofbyte > 0)
                {
                    clientsocket.Send(content, numofbyte, SocketFlags.None);
                    total += numofbyte;
                    Console.WriteLine(numofbyte);
                }
                else
                {
                    clientsocket.Close();
                    filestream.Close();
                    break;
                }
            }
        }
    }
}
