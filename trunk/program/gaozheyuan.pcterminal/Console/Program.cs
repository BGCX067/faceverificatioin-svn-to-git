﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Server s=new Server();
            s.executeThread();
        }
    }
}
