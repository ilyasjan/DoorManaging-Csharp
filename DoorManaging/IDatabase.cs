using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
namespace DoorManaging
{
    public interface IDatabase
    {
        /// <summary>
        /// 链接
        /// </summary>
        /// <param name="conString">链接字符串</param>
        void Connect(String conString);
        /// <summary>
        /// 查询函数
        /// </summary>
        /// <param name="sql">查询语句</param>
        /// <returns></returns>
        DataTable Query(String sql);
        /// <summary>
        /// 关闭数据库链接
        /// </summary>
        void Close();
        /// <summary>
        /// 执行SQL语句(删除，插入，更新等操作)
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        int Excute(String sql);
    }
}
