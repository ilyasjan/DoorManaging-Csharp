using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DoorManaging
{
    public sealed class SqlDatabase : IDatabase
    {
        private SqlConnection con;

        private static SqlDatabase db;
        public void Connect(string conString)
        {
            con = new SqlConnection(conString);
        }

        public static SqlDatabase getInstanse()
        {
            if (db == null)
            {
                db = new SqlDatabase();
            }
            return db;
        }

        public System.Data.DataTable Query(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand com = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public void Close()
        {
            try
            {
                con.Close();
            }
            catch
            {
            }
        }

        public int Excute(string sql)
        {
            int p = -1;
            try
            {
                p = new SqlCommand(sql, con).ExecuteNonQuery();
            }
            catch
            {
            }
            return p;
        }
    }
}
