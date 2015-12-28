using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Windows;
namespace FaceLabel
{
    public partial class Form1 : Form
    {
        private string container;
        private FileInfo[] files;
        private List<double> xVec;
        private List<double> yVec;
        private int currentindex;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            container = textBox1.Text;
            browseFiles();
            try
            {
                openFile(0);
            }
            catch (Exception ee)
            { }
        }
        private void browseFiles()
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(container);
                files = info.GetFiles("*.jpg");
                label2.Text = "0/" + files.Length.ToString();
            }
            catch (Exception ee)
            { }
        }
        private void openFile(int index)
        {
            Bitmap image = new Bitmap(files[index].FullName);
            Bitmap newimage = resize(image);
            pictureBox.Image = newimage;
            currentindex = 0;
        }

        private Bitmap resize(Bitmap original)
        {
            Bitmap b = new Bitmap(pictureBox.Size.Width, pictureBox.Size.Height);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(original, new Rectangle(0, 0, pictureBox.Size.Width, pictureBox.Size.Height), new Rectangle(0, 0, original.Size.Width, original.Size.Height), GraphicsUnit.Pixel);
            g.Dispose();
            return b;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }                           
    }
}
