using System;
using System.Collections.Generic;
using System.Text;

namespace DoorManaging
{
    public sealed class DBO
    {
        public static int AddStudent(Entities.Students st)
        {
            try
            {
                Database db = new Database();
                db.init();
                String sql = String.Format("insert into `Users`(ucard,uxh,uname,uclass,uena) values({0})", st.getSQLString1());
                return db.Insert(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static int UpdateStudent(Entities.Students stOLd, Entities.Students stNew)
        {
            try
            {
                Database db = new Database();
                db.init();
                String sql = String.Format("update `Users` {0} where id={1}", stNew.getSQLString2(), stOLd.ID);
                return db.Update(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static System.Data.DataTable getEventLogs(string kh,string mc,string xh,string bj)
        {
            Database db = new Database();
            db.init();
            return db.getTable(String.Format("select * from EventLogs where `学号` like '{0}' and `名称` like '{1}' and `学号` like '{2}' and `班级` like '{3}' ",kh,mc,xh,bj));
        }

        public static System.Data.DataTable getStudents()
        {
            Database db = new Database();
            db.init();
            return db.getTable(String.Format("select * from Users"));
        }

        public static System.Data.DataTable getStudents(string kh, string mc, string xh, string bj)
        {
            Database db = new Database();
            db.init();
            string sql = String.Format("select * from UserInfo where `学号` like '{0}%' and `名称` like '{1}%' and `学号` like '{2}%' and `班级` like '{3}%' ", kh, mc, xh, bj);
            return db.getTable(sql);
        }
    }
}
