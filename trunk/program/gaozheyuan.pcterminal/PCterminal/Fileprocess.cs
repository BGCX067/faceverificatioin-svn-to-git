using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace PCterminal.Arrangement
{
    public class Fileprocess
    {
        private Socket localsocket;
        public Fileprocess(Socket socket)
        {
            localsocket = socket;
        }
        public static void processSocket(object o)
        {
            Fileprocess process = (Fileprocess)o;
            NetworkStream inputStream;
            inputStream = new NetworkStream(process.localsocket);
            string location = "E:\\faceverificatioin\\testdata\\pic\\" + DateTime.Now.ToFileTime().ToString() + ".jpg";
            FileStream fileStream;
            fileStream = new FileStream(location, FileMode.Create);
            if (inputStream.CanRead)
            {
                byte[] data = new byte[1024];
                int len;
                while ((len = inputStream.Read(data, 0, data.Length)) > 0)
                {
                    fileStream.Write(data, 0, len);
                    fileStream.Flush();
                }
                fileStream.Flush();
                fileStream.Close();
            }
            inputStream.Close();
        }
    }
}
