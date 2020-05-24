using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;
using utils.debug;
namespace utils.db
{
    public class KCVVs
    {
        public Dictionary<string, string> KV;
        public Dictionary<string, bool> KC;
    }
    public class db
    {
        private debugger logger = new debugger();
        string dbPath = Environment.CurrentDirectory + "/database.db";
        
        // try connect the file
        private SQLiteConnection conn;

        public db()
        {
            if (File.Exists(dbPath))
            {
                if ((int)MessageBox.Show("数据库已存在，是否重置？","提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) != 1)
                {
                    File.Delete(dbPath);
                    this.conn = new SQLiteConnection("Data Source =" + dbPath);
                    conn.Open();
                    this.migrate();
                }
                this.conn = new SQLiteConnection("Data Source =" + dbPath);
                conn.Open();
            }
           
            
        }

        public void migrate()
        {
            
            string[] allkey = { "kv11", "kv12", "kv13", "kv14", "kv15", "kv16",
                                "kv21", "kv22",
                                "kv31", "kv32",
                                "kv41","kv42","kv43","kv44","kv45","kv46", "kv47", "kv48",
                                "kv51", "kv52", "kv53",
                                "LED1","LED2","LED3","LED4","LED5","LED6","LED8","LED9"};

    

            // create the KCV 
            string sql = "CREATE TABLE IF NOT EXISTS KCV(name varchar(120), open bool, value varchar(240))";
            SQLiteCommand createKcv = new SQLiteCommand(sql, conn);
            createKcv.ExecuteNonQuery();
            for (int i = 1; i <= 8; i++)
            {
                sql = string.Format("INSERT INTO KCV VALUES('kcv{0}', {1}, '{2}')", i, false, "");
                SQLiteCommand kcvInsert = new SQLiteCommand(sql, conn);
                kcvInsert.ExecuteNonQuery();
            }

            // create the kv table
            sql = "CREATE TABLE IF NOT EXISTS KV(name varchar(120), value varchar(240))";
            SQLiteCommand createKV = new SQLiteCommand(sql, conn);
            createKV.ExecuteNonQuery();
            for (int i = 0; i < allkey.Length; i++)
            {
                sql = string.Format("INSERT INTO KV VALUES ('{0}','')", allkey[i]);
                SQLiteCommand insertKv = new SQLiteCommand(sql, this.conn);
                insertKv.ExecuteNonQuery();
            }
        }
        public string GET(string name)
        {
       
            // 尝试从数据库中获取
            string sql =string.Format( "SELECT * FROM KV WHERE name = '{0}'", name);
            logger.dd(sql);
            SQLiteCommand cmdQ = new SQLiteCommand(sql,this.conn);
            SQLiteDataReader reader = cmdQ.ExecuteReader();
            if (reader.Read())
            {
                string Name = reader.GetString(0);
                string Value = reader.GetString(1);
                logger.ddf(" name={0}, value={1}",Name,Value);
                return Value;
            }
            return "";
        }

        public void SET(string name, string value)
        {
            // 尝试从数据库中获取
            string sql = string.Format("UPDATE KV SET value = '{0}' WHERE name = '{1}'", value, name);
            logger.dd(sql);
            SQLiteCommand cmdQ = new SQLiteCommand(sql, this.conn);
            cmdQ.ExecuteNonQuery();
        }

        public KCVVs ALLKCV()
        {
            KCVVs temp = new KCVVs();
            temp.KC = new Dictionary<string, bool>();
            temp.KV = new Dictionary<string, string>();
            string sql = "SELECT * FROM KCVV";
            SQLiteCommand cmdQ = new SQLiteCommand(sql, this.conn);
            SQLiteDataReader reader =  cmdQ.ExecuteReader();

            while (reader.Read())
            {
                string Name = reader.GetString(0);
                bool Open = reader.GetBoolean(1);
                string Value = reader.GetString(2);
                temp.KV[Name] = Value;
                temp.KC[Name] = Open;
            }
            return temp;
        }
    }
}
