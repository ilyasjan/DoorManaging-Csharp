using System;
using System.Collections.Generic;
using System.Text;
using DoorManaging.Entities;
namespace DoorManaging
{
    public sealed class DBO
    {
        public static int AddStudent(Entities.Students st)
        {
            Database db = new Database();
            db.init();
            String sql = String.Format("insert into `Users`(ucard,uxh,uname,uclass,uena) values({0})", st.getSQLString1());
            return db.Insert(sql);
        }

        public static int UpdateStudent(Entities.Students stOLd, Entities.Students stNew)
        {
            Database db = new Database();
            db.init();
            String sql = String.Format("update `Users` set {0} where id={1}", stNew.getSQLString2(), stOLd.ID);
            return db.Update(sql);
        }

        public static System.Data.DataTable getErrLog()
        {
            Database db = new Database();
            db.init();
            String sql = "";
            return db.getTable(sql);
        }

        public static System.Data.DataTable getEventLogs(string kh, string mc, string xh, string bj)
        {
            Database db = new Database();
            db.init();
            return db.getTable(String.Format("select * from EventLogs where `卡号` like '{0}%' and `名称` like '{1}%' and `学号` like '{2}%' and `班级` like '{3}%' ", kh, mc, xh, bj));
        }

        public static System.Data.DataTable getStudents()
        {
            return getStudents("", "", "", "");
        }

        public static System.Data.DataTable getStudents(string kh, string mc, string xh, string bj)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("select * from UserInfo where `卡号` like '{0}%' and `名称` like '{1}%' and `学号` like '{2}%' and `班级` like '{3}%' ", kh, mc, xh, bj);
            return db.getTable(sql);
        }

        public static Students getStudent(string kh)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("select * from Users where `id` = {0}", kh);
            System.Data.DataTable dt = db.getTable(sql);
            Students st = new Students(dt);
            return st;
        }

        public static Students getStudentKH(string kh)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("select * from Users where `ucard` = '{0}'", kh);
            System.Data.DataTable dt = db.getTable(sql);
            if (dt.Rows.Count > 0)
                return new Students(dt);
            return null;
        }

        public static void Record(Students st, String date, String evnt)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("insert into `EventLog` (uid,dtime,event) values({0},'{1}','{2}')", st.ID, date, evnt);
            db.Insert(sql);
        }

        public static void Err(Exception msg)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("insert into `ErrLog` (errmsg,dtime) values('{0}','{1}')", msg.Message.Replace('\'', '\"'), DateTime.Now.ToString());
            db.Insert(sql);
        }
    }
}
