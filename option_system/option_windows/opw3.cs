using System;
using System.Collections.Generic;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
using utils.db;
namespace option_system.option_windows
{
    public partial class opw3 : Form
    {

        private db DB;
        debugger logger = new debugger();
        public opw3(db _DB)
        {
            InitializeComponent();
            DB = _DB;
            kv31.Text = DB.GET(kv31.Name);
            kv32.Text = DB.GET(kv32.Name);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DB.SET(kv31.Name, kv31.Text);
            DB.SET(kv32.Name, kv32.Text);
            this.Close(); 
        }
    }
}
