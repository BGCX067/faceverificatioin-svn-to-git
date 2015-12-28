using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Connect
{
    class Program
    {
        static void Main(string[] args)
        {
            Connect con = new Connect();
            con.ConnecttoServer("127.0.0.1", 6000);
            con.sendFile(@"C:\Documents and Settings\Administrator\桌面\sample.jpg");
        }
    }
}
