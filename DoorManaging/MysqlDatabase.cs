using System;
using System.Collections.Generic;
using System.Text;
using MySQLDriverCS;
using System.Data;
namespace DoorManaging
{
    public sealed class MysqlDatabase : IDatabase
    {

        private MySQLConnection con;
        private static MysqlDatabase db;


        //    string connstr = "Data Source=MySQL;"+"Password=root;User ID=root;Location=localhost";
        //


        /// <summary>
        /// 实现链接 
        /// </summary>
        /// <param name="conString"></param>
        public void Connect(string conString)
        {
            try
            {
                con = new MySQLConnection(conString);
                con.Open();
            }
            catch
            {
                throw ConnectException.getInstanse();
            }
        }

        /// <summary>
        /// 获取此类的实例 (工厂模式)
        /// </summary>
        /// <returns></returns>
        public static MysqlDatabase getInstanse()
        {
            if (db == null)
            {
                db = new MysqlDatabase();

            }
            return db;
        }

        /// <summary>
        /// 实现查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public System.Data.DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                MySQLCommand com = new MySQLCommand(sql, con);
                MySQLDataAdapter adapter = new MySQLDataAdapter(com);
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }
        /// <summary>
        /// 实现关闭链接
        /// </summary>
        public void Close()
        {
            try
            {
                con.Close();
            }
            catch(Exception e)
            {
                throw e;
            }
        }
        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Excute(string sql)
        {
            int p = -1;
            try
            {
                p = new MySQLCommand(sql, con).ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            return p;
        }
    }
}
