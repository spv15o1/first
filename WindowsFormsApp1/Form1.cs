using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        Timer timer;
        private void Form1_Load(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 30888);
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += Timer_Tick1;
             timer.Start();
         
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            NetworkStream stream = client.GetStream();
            ReadData(stream);
        }

    

        void ReadData(NetworkStream stream)
        {
            List<byte> byte_list = new List<byte>();

            while (stream.DataAvailable)
            {
                Byte[] data = new Byte[1024];
                int numBytesRead = 0;
                numBytesRead = stream.Read(data, 0, data.Length);
                if (numBytesRead == data.Length)
                {
                    byte_list.AddRange(data);
                }
                else if (numBytesRead > 0)
                {
                    byte_list.AddRange(data.Take(numBytesRead));
                }

            }
            if (byte_list.Count != 0)
            {
             
                pictureBox1.BackgroundImage = Image.FromStream(new MemoryStream(byte_list.ToArray()));
            }

        }
    }
}
