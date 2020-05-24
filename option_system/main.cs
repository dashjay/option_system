using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils.debug;
using option_system.option_windows;
using utils.db;
using System.Resources;
using System.Net.Sockets;      
using System.Net;
using System.Threading;
namespace option_system
{
    public partial class main : Form
    {
        db DB = new db();
        public Image Green;
        public Image Red;
        public debugger logger = new debugger();
        
        // tcp client 
        private TcpClient MainTcpClient;
        private NetworkStream MainNetWorkSteam;
        private Thread ServeThread;

        public main()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button4_Click(object sender, EventArgs e)
        {
            opw4 Form = new opw4(DB);
            Form.Location = NewPos();
            Form.ShowDialog();
        }
        public Point NewPos()
        {
            int xWidth = SystemInformation.PrimaryMonitorSize.Width;
            int yHeight = SystemInformation.PrimaryMonitorSize.Height;
            return new Point(xWidth / 2, yHeight / 2);
        }

        private void op5_Click(object sender, EventArgs e)
        {
            opw5 Form = new opw5(DB);
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op3_Click(object sender, EventArgs e)
        {
            opw3 Form = new opw3(DB);
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op2_Click(object sender, EventArgs e)
        {
            opw2 Form = new opw2(DB);
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op1_Click(object sender, EventArgs e)
        {
            opw1 Form = new opw1(DB);
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] LEDS = { this.LED1, this.LED2, this.LED3, this.LED4, this.LED5, this.LED6, this.LED7, this.LED8, this.LED9 };
            for (int i = 0; i < LEDS.Length; i++)
            {
                string value = DB.GET(LEDS[i].Name);
                if (value == "on")
                {
                    LEDS[i].Image = Properties.Resources.green;
                    DB.SET(LEDS[i].Name, "off");
                }
                else
                {
                    LEDS[i].Image = Properties.Resources.red;
                    DB.SET(LEDS[i].Name, "on");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress IP = IPAddress.Parse(ip.Text);
            int Port = Convert.ToInt32(port.Text);
            IPEndPoint Addr = new IPEndPoint(IP, Port);
            MainTcpClient = new TcpClient();
            logger.dd("prepare for connection.");
            try
            {
                MainTcpClient.Connect(Addr);
                if (MainTcpClient != null)
                {
                    MessageBox.Show("服务器连接成功");
                    MainNetWorkSteam = MainTcpClient.GetStream();
                }
                else
                {
                    MessageBox.Show("connect fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
