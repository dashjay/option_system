using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
namespace option_system.option_windows
{
    public partial class opw5 : Form
    {
        debugger logger = new debugger();
        public opw5()
        {
            InitializeComponent();
        }

        private void opw5_Load(object sender, EventArgs e)
        {

        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_SYSCOMMAND && (int)m.WParam == Constants.SC_CLOSE)
            {
                logger.dd("close opw5");
            }
            base.WndProc(ref m);
        }
    }
}
