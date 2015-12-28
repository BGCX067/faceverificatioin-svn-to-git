using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using PCterminal.Arrangement;
namespace PCterminal.Network
{
    public class Server
    {
        public Server()
        {
        }
        public static void run()
        {
            Socket serversocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serversocket.Bind(new IPEndPoint(IPAddress.Any, 4702));
            while (true)
            {
                serversocket.Listen(200);
                Socket client = serversocket.Accept();
                Fileprocess p = new Fileprocess(client);
                Thread processThread = new Thread(Fileprocess.processSocket);
                processThread.Start(p);
            }
        }
        public void executeThread()
        {
            Thread serverThread = new Thread(run);
            serverThread.Start();
        }
    }
}
