﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using utils.debug;
using option_system.singleton;
namespace option_system.option_windows
{
    public partial class opw4 : Form
    {
        debugger logger = new debugger();
        public opw4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_SYSCOMMAND && (int)m.WParam == Constants.SC_CLOSE)
            {
                logger.dd("close opw4");
            }
            base.WndProc(ref m);
        }
    }
}
