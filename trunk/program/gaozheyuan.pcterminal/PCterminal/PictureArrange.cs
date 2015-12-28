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
    public class PictureArrange
    {
        private DirectoryInfo directry;
        private string address = @"E:\faceverificatioin\testdata\pic";
        public PictureArrange()
        {
            directry = new DirectoryInfo(address);
        }

        public List<FileInfo> getRecentFiles()
        {
            FileInfo[] fileinfos = directry.GetFiles();
            List<FileInfo> result = new List<FileInfo>();
            for (int i = fileinfos.Length - 1; (i >= 0); i--)
            {
                result.Add(fileinfos[i]);
            }
            return result;
        }
    }
}
