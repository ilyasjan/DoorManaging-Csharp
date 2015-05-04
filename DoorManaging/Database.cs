using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace DoorManaging
{
    public class Database
    {
        private static Database self;
        private IDatabase db;
        // private const string connectionString = "Data Source=MySQL;" + "Password=akak;User ID=root;Location=localhost;charset=utf8";

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 单例模式
        public static Database getInstanse()
        {
            if (self == null)
                self = new Database();
            return self;
        }
        public Database()
        {
            db = MysqlDatabase.getInstanse();
        }

        public void init()
        {
            Config c = new Config();
            string connectionString = String.Format("Data Source=MySQL; Password={0};User ID=ilyas;Location={1};charset=utf8",c.getValue("mpass"),c.getValue("mhost"));
            db.Connect(connectionString);
        }

        /// <summary>
        /// 某一列的内容
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public List<T> getaRow<T>(String sql)
        {
            List<T> list = new List<T>();
            DataTable dt = db.Query(sql);
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                Object obj = reader.GetValue(0);
                list.Add((T)obj);
            }

            return list;
        }

        public int Insert(String sql)
        {
            return db.Excute(sql);
        }

        public int Update(String sql)
        {
            return db.Excute(sql);
        }

        /// <summary>
        /// 析构函数(当此类被释放时被系统调用)
        /// 目的是为了释放数据库的连接资源
        /// </summary>
        ~Database()
        {
            db.Close();
        }
    }
}
