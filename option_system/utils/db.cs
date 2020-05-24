using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using utils.debug;
namespace utils.db
{
    public class db
    {
        private debugger logger = new debugger();
        private SQLiteConnection conn = null;  

        public db()
        {

            string dbPath = Environment.CurrentDirectory + "/database.db";
            if (File.Exists(dbPath))
            {
                conn = new SQLiteConnection("Data Source =" + dbPath);
                conn.Open();
            }
            else
            {
                conn = new SQLiteConnection("Data Source =" + dbPath);
                conn.Open();
                string sql = "CREATE TABLE IF NOT EXISTS LED(id integer, name varchar(120), open bool)";
                SQLiteCommand cmdCreateTable = new SQLiteCommand(sql, conn);
                cmdCreateTable.ExecuteNonQuery();
            }
        }
        public bool LED(int id, string name)
        {
            // ID 不合法
            if (id < 0)
            {
                return false;
            }
            // 尝试从数据库中获取
            string sql =string.Format( "SELECT * FROM LED WHERE id = {0} and name = '{1}'", id, name);
            logger.dd(sql);
            SQLiteCommand cmdQ = new SQLiteCommand(sql,this.conn);
            SQLiteDataReader reader = cmdQ.ExecuteReader();
            bool result = false;
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Name = reader.GetString(1);
                bool Open = reader.GetBoolean(2);
                logger.ddf("id={0}, name={1}, open={2}",ID,Name,Open);
                return Open;

            }
            else
            { 
                string insert = "INSERT INTO LED VALUES({0},'{1}',{2})";
                SQLiteCommand cmd = new SQLiteCommand(string.Format(insert,id , name, false),this.conn);
                cmd.ExecuteNonQuery();
                logger.ddf("id={0}, name={1}, open={2}", id, name, false);
                return false;
            }
        }

        public bool LED(int id, string name, bool open)
        {
            // ID 不合法
            if (id < 0)
            {
                return false;
            }
            // 尝试从数据库中获取
            string sql = string.Format("SELECT * FROM LED WHERE id = {0} and name = '{1}'", id, name);
            logger.dd(sql);
            SQLiteCommand cmdQ = new SQLiteCommand(sql, this.conn);
            SQLiteDataReader reader = cmdQ.ExecuteReader();
            bool result = false;
            if (reader.Read())
            {
                int ID = reader.GetInt32(0);
                string Name = reader.GetString(1);
                bool Open = reader.GetBoolean(2);
                string update = string.Format("UPDATE LED SET open = {0} where id = {1} and name = '{2}'", open, id, name);
                SQLiteCommand UPDATE = new SQLiteCommand(update, conn);
                UPDATE.ExecuteNonQuery();
                logger.ddf("id={0}, name={1}, open={2}", ID, Name, open);
                return open;
            }
            else
            {
                return false;
            }
        }
    }
}
