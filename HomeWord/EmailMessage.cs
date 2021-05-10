using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口
    //ISendMessage（含Send()方法声
    //z明），用Console.WriteLine() 实现Send()。
    class EmailMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("吃饭");
        }
    }
    public interface ISendMessage
    {
        void Send();
    }
}
