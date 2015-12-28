using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using PCterminal.Network;
using PCterminal.Arrangement;
using PCterminal.ConnectDevice;
using PCterminal.Clientinfo;
namespace PCterminal
{
    public partial class MainForm : Form
    {
        public Server server;
        private PictureArrange arrangePics;
        private ClientInfo clientinfo;
        private Bitmap idImage;
        private Bitmap realImage;
        private String realImageAddress;
        private String idImageAddress;
        private List<FileInfo> capturedFileList;
        private int currentIndex = 0;
        public MainForm()
        {
            InitializeComponent();
            server = new Server();
            arrangePics = new PictureArrange();
            clientinfo = new ClientInfo();
            realImageAddress = Path.GetTempPath() + "realperson.jpg";
            idImageAddress = Path.GetTempPath() + "idperson.jpg";
        }

        private void OpenServerBtn_Click(object sender, EventArgs e)
        {
            ServerInfoForm form = new ServerInfoForm(this);
            form.ShowDialog();
            OpenServerBtn.Text = "端口已打开.....";
            OpenServerBtn.Enabled = false;
        }
        private Bitmap ResizeBitmap(Bitmap original, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(original, new Rectangle(0, 0, width, height), new Rectangle(0, 0, original.Size.Width, original.Size.Height), GraphicsUnit.Pixel);
            g.Dispose();
            return b;
        }
        private void GetRecentpicBtn_Click(object sender, EventArgs e)
        {
            capturedFileList = arrangePics.getRecentFiles();
            try
            {
                currentIndex = 0;
                Bitmap person = new Bitmap(capturedFileList[currentIndex].DirectoryName + "\\" + capturedFileList[currentIndex].Name);
                idImage = ResizeBitmap(person, CapturedpictureBox.Size.Width, CapturedpictureBox.Size.Height);
                idImage.Save(idImageAddress);
                this.CapturedpictureBox.Image = idImage;
            }
            catch (Exception ee)
            {

            }
        }

        private void ReadCardBtn_Click(object sender, EventArgs e)
        {
            Int32 result;
            StringBuilder errorText = new StringBuilder(clientinfo.maxErrorTextLen);
            /*参数1为端口号。1表示串口1，2表示串口2，依次类推。1001表示USB。0表示自动选择。
              参数2为标志位。0x02表示启用重复读卡。0x04表示读卡后接着读取新地址。
              各个数值可以用“按位或”运算符组合起来。
              参数3为波特率。使用串口阅读器的程序应正确设置此参数。出厂机器的波特率一般为115200。
            */
            result = DeviceInfo.OpenCardReader(0, 2, 115200);

            errorNumtextBox.Text = Convert.ToString(result);
            DeviceInfo.GetErrorTextW(errorText, (uint)clientinfo.maxErrorTextLen);
            errorinfotextBox.Text = errorText.ToString();
        }

        private void ReadInfoBtn_Click(object sender, EventArgs e)
        {
            Int32 result;
            String imagePath;
            StringBuilder errorText = new StringBuilder(clientinfo.maxErrorTextLen);

            if (clientinfo.capturedImage != null)
            {
                clientinfo.capturedImage.Dispose();
                clientinfo.capturedImage = null;
            }
            imagePath = Path.GetTempPath() + "image.bmp";
            //当程序打开设备后，可以多次调用读取信息函数。
            result = DeviceInfo.GetPersonMsgW(ref clientinfo.person, imagePath);
            errorNumtextBox.Text = Convert.ToString(result);
            DeviceInfo.GetErrorTextW(errorText, (uint)clientinfo.maxErrorTextLen);
            errorinfotextBox.Text = errorText.ToString();

            if (0 == result)
            {
                clientinfo.birthday = clientinfo.ConvertDate(clientinfo.person.birthday, 1);
                clientinfo.validDate = clientinfo.ConvertDate(clientinfo.person.validStart, 2) + "-";
                clientinfo.validDate += clientinfo.ConvertDate(clientinfo.person.validEnd, 2);
                clientinfo.capturedImage = new Bitmap(imagePath);
            }
            else
            {
                clientinfo.birthday = "";
                clientinfo.validDate = "";
            }
            nametextBox.Text = clientinfo.person.name;
            sextextBox.Text = clientinfo.person.sex;
            ethnictextBox.Text = clientinfo.person.nation;
            birthdaytextBox.Text = clientinfo.person.birthday;
            addresstextBox.Text = clientinfo.person.address;
            idnumtextBox.Text = clientinfo.person.cardId;
            authorizetextBox.Text = clientinfo.person.police;
            validdatetextBox.Text = clientinfo.person.validStart + "-" + clientinfo.person.validEnd;
            Bitmap person = new Bitmap(clientinfo.capturedImage);
            realImage = ResizeBitmap(person, cardpictureBox.Size.Width, cardpictureBox.Size.Height);
            cardpictureBox.Image = realImage;
            realImage.Save(realImageAddress);
        }
        private void SendImgBtn_Click(object sender, EventArgs e)
        {
            ConnecttoPolice connector1 = new ConnecttoPolice();
            ConnecttoPolice connector2 = new ConnecttoPolice();
            if (idImage != null && realImage != null)
            {
                connector1.ConnecttoServer("127.0.0.1", 6000);
                connector1.SendFile(idImageAddress);
                connector2.ConnecttoServer("127.0.0.1", 6000);
                connector2.SendFile(realImageAddress);

            }
        }

        private void ShowRecentPicBtn_Click(object sender, EventArgs e)
        {
            capturedFileList = arrangePics.getRecentFiles();
            try
            {
                currentIndex++;
                Bitmap person = new Bitmap(capturedFileList[currentIndex].DirectoryName + "\\" + capturedFileList[currentIndex].Name);
                idImage = ResizeBitmap(person, CapturedpictureBox.Size.Width, CapturedpictureBox.Size.Height);
                idImage.Save(idImageAddress);
                this.CapturedpictureBox.Image = idImage;
            }
            catch (Exception ee)
            {

            }
        }
    }
}
