using System;
using System.Collections.Generic;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
using utils.db;
namespace option_system.option_windows
{
    public partial class opw5 : Form
    {

        private db DB;
        CheckBox[] AllCheckBox;
        debugger logger = new debugger();
        public opw5(db _DB)
        {
            InitializeComponent();
            DB = _DB;
            AllCheckBox = new CheckBox[] { kv51, kv52, kv53 };
            for (int i = 0; i < AllCheckBox.Length; i++)
            {
                AllCheckBox[i].Checked = DB.GET(AllCheckBox[i].Name) == "on";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllCheckBox.Length; i++)
            {
                if (AllCheckBox[i].Checked)
                {
                    DB.SET(AllCheckBox[i].Name, "on");
                }
                else
                {
                    DB.SET(AllCheckBox[i].Name, "off");
                }
            }
            this.Close();
        }

        private void 开机启动_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
