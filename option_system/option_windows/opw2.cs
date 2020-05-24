using System;
using System.Collections.Generic;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
namespace option_system.option_windows
{
    public partial class opw2 : Form
    {
        public opw2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
