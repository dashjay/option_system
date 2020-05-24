using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace option_system
{
    public partial class LED : Component
    {
        public LED()
        {
            InitializeComponent();
        }

        public LED(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public void switchStatus()
        {
            this.Pic.Image = Properties.Resources.red;
        }
    }
}
