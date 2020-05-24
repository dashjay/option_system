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
namespace option_system
{
    public partial class main : Form
    {
        db DB = new db();
        public Image Green;
        public Image Red;
        public debugger logger = new debugger();
        public main()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LED1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = DB.GET(LED1.Name);
            if (value == "" ||value == "off")
            {
                DB.SET(LED1.Name, "on");
                LED1.Image = Properties.Resources.green;
            }else{
                DB.SET(LED1.Name, "off");
                LED1.Image = Properties.Resources.red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            opw4 Form = new opw4();
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
            opw5 Form = new opw5();
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op3_Click(object sender, EventArgs e)
        {
            opw3 Form = new opw3();
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op2_Click(object sender, EventArgs e)
        {
            opw2 Form = new opw2();
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void op1_Click(object sender, EventArgs e)
        {
            opw1 Form = new opw1();
            Form.Location = NewPos();
            Form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PictureBox[] LEDS = { this.LED1, this.LED2, this.LED3, this.LED4, this.LED5, this.LED6, this.LED7, this.LED8, this.LED9 };
            for (int i = 0; i < LEDS.Length; i++)
            {
                string value = DB.GET(LEDS[i].Name);
                logger.ddf("value={0}", value);
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
    }
}
