using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using utils.db;
using utils.debug;
namespace option_system.option_windows
{
    public partial class opw1 : Form
    {

        private debugger logger = new debugger();
        public db DB;
        private KCVVs state;
        TextBox[] allV ;
        CheckBox[] allC;
        TextBox[] AllText;
        public opw1(db _DB)
        {
            InitializeComponent();
            allV = new TextBox[] { kcv1v, kcv2v, kcv3v, kcv4v, kcv5v, kcv6v, kcv7v, kcv8v };
            allC = new CheckBox[] { kcv1, kcv2, kcv3, kcv4, kcv5, kcv6, kcv7, kcv8 };
            AllText = new TextBox[] { kv11, kv12, kv13, kv14, kv15, kv16 };
            DB = _DB;
            this.init();
        }

        private void init()
        {
            state = DB.ALLKCV();
            for (int i = 0; i < allV.Length; i++)
            {
                logger.ddf("key={0}, value={1}, open={2}", allC[i].Name, state.KV[allC[i].Name], state.KC[allC[i].Name]);
                allV[i].Text = state.KV[allC[i].Name];
                allC[i].Checked = state.KC[allC[i].Name];
            }

            for (int i = 0; i < AllText.Length; i++)
            {
                AllText[i].Text = DB.GET(AllText[i].Name);
                logger.ddf("key={0}, value={1}", AllText[i].Name, AllText[i].Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < allC.Length; i++)
            {
                state.KV[allC[i].Name] = allV[i].Text;
                state.KC[allC[i].Name] = allC[i].Checked;
            }
            DB.SETKCV(state);
            for (int i = 0; i < AllText.Length; i++)
            {
                DB.SET(AllText[i].Name, AllText[i].Text);
            }
            this.Close();
        }
    }
}
