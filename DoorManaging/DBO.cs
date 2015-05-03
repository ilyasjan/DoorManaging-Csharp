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
                String sql = String.Format("insert into `student`(sno,name,classs,enable) values({0})", st.getSQLString1());
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
                String sql = String.Format("update `student` {0} where id={1}", stNew.getSQLString2(), stOLd.ID);
                return db.Update(sql);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

    }
}
