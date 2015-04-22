using System;
using System.Collections.Generic;
using System.Text;

namespace DoorManaging
{
    public sealed class ConnectException : Exception
    {

        public ConnectException()
            : base("数据库链接失败!")
        {

        }

        public ConnectException(String Message)
            : base(Message)
        {
        }


        public static ConnectException getInstanse()
        {
            return new ConnectException();
        }
        public static ConnectException getInstanse(String Message)
        {
            return new ConnectException(Message);
        }
    }
}
