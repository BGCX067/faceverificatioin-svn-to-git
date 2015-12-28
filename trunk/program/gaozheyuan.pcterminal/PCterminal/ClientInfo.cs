using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PCterminal.ConnectDevice;
using System.Drawing;
namespace PCterminal.Clientinfo
{
    public class ClientInfo
    {
        public DeviceInfo.PERSONINFOW person;
        public string birthday = "";
        public string validDate = "";
        public Image capturedImage = null;
        public int maxErrorTextLen = 32;
        public string ConvertDate(string str, int mode)
        {
            string year;
            string month;
            string day;
            if (1 == mode)
            {
                if (str.Length >= 8)
                {
                    year = str.Substring(0, 4);
                    month = str.Substring(4, 2);
                    day = str.Substring(6, 2);
                    return string.Format("{0}年{1}月{2}日", year, month, day);
                }
            }
            else if (2 == mode)
            {
                if (str.Equals("长期"))
                {
                    return "长期";
                }
                else
                {
                    if (str.Length >= 8)
                    {
                        year = str.Substring(0, 4);
                        month = str.Substring(4, 2);
                        day = str.Substring(6, 2);
                        return string.Format("{0}.{1}.{2}", year, month, day);
                    }
                }
            }
            return "";
        }
    }
}
