using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
namespace PCterminal
{
    public partial class ServerInfoForm : Form
    {
        public MainForm mainform;
        public ServerInfoForm()
        {
            InitializeComponent();
        }
        public ServerInfoForm(MainForm mainform)
        {
            this.mainform = mainform;
            InitializeComponent();
            GetServerIpString();
        }
        public void GetServerIpString()
        {
            IPAddress[] addressList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;
            for (int i = 0; i < addressList.Length;i++ )
            {
                labelipinfo.Text = labelipinfo.Text + addressList[i].ToString() + "\n";
            }
            mainform.server.executeThread();
        }
        private void CloseWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
