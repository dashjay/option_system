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
using utils.debug;
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

            PictureBox[] LEDS = { this.LED1, this.LED2, this.LED3, this.LED4, this.LED5, this.LED6, this.LED7, this.LED8, this.LED9 };
            for (int i = 0; i < LEDS.Length; i++)
            {
                LEDS[i].Image = (DB.LED(int.Parse((string)LEDS[i].Tag), LEDS[i].Name.ToString()) ? Properties.Resources.green : Properties.Resources.red);
            }
               
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
            if (DB.LED(int.Parse((string)LED1.Tag), LED1.Name))
            {
                DB.LED(int.Parse((string)LED1.Tag), LED1.Name, false);
                LED1.Image = Properties.Resources.red;
            }else{
                 DB.LED(int.Parse((string)LED1.Tag), LED1.Name, true);
                 LED1.Image = Properties.Resources.green;
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
    }
}
