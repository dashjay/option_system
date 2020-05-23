using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using utils.debug;
using option_system.option_windows;
namespace option_system
{
    public partial class main : Form
    {
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
            if (this.LED1.Image.Tag == "off")           

            {
                this.LED1.Image = Properties.Resources.green;
                this.LED1.Image.Tag = "on";
            }
            else
            {
                 this.LED1.Image = Properties.Resources.red;
                 this.LED1.Image.Tag = "off";
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
    }
}
