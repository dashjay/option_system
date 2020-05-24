using System;
using System.Collections.Generic;
using System.Windows.Forms;
using option_system.singleton;
using utils.debug;
using utils.db;
namespace option_system.option_windows
{
    public partial class opw4 : Form
    {
        TextBox[] AllText;
        private db DB;
        debugger logger = new debugger();
        public opw4(db _DB)
        {
            InitializeComponent();
            DB = _DB;
            AllText = new TextBox[] { kv41, kv42, kv43, kv44, kv45, kv46, kv47, kv48 };
            for (int i = 0; i < AllText.Length; i++)
            {
                AllText[i].Text = DB.GET(AllText[i].Name);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < AllText.Length; i++)
            {
                DB.SET(AllText[i].Name, AllText[i].Text);
            }
            this.Close();
        }

        private void opw4_Load(object sender, EventArgs e)
        {

        }
    }
}
