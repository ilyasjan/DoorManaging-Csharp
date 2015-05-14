using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
namespace DoorManaging
{
    public sealed class OledbDatabase : IDatabase
    {
        private OleDbConnection con;
        private static OledbDatabase db;

        /// <summary>
        /// 实现链接 
        /// </summary>
        /// <param name="conString"></param>
        public void Connect(string conString)
        {
            try
            {
                con = new OleDbConnection(conString);
                con.Open();
            }
            catch {
                throw ConnectException.getInstanse();
            }
        }

        /// <summary>
        /// 获取此类的实例 (工厂模式)
        /// </summary>
        /// <returns></returns>
        public static OledbDatabase getInstanse()
        {
            if (db == null)
            {
                db = new OledbDatabase();
                
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
                OleDbCommand com = new OleDbCommand(sql, con);
                OleDbDataAdapter adapter = new OleDbDataAdapter(com);
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
                //throw e;
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
                p = new OleDbCommand(sql, con).ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw e;
            }
            return p;
        }
    }
}
