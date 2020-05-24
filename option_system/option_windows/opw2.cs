using System;
using System.Collections.Generic;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
using utils.db;
namespace option_system.option_windows
{
    public partial class opw2 : Form
    {
        private db DB;
        public opw2(db _DB)
        {
            InitializeComponent();
            DB = _DB;
            kv21.Text = DB.GET(kv21.Name);
            kv22.Text = DB.GET(kv22.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.SET(kv21.Name, kv21.Text);
            DB.SET(kv22.Name, kv22.Text);
            this.Close();
        }
    }
}
