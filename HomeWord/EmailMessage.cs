using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    //引入两个子类EmailMessage和DBMessage，和他们继承的接口
    //ISendMessage（含Send()方法声
    //z明），用Console.WriteLine() 实现Send()。

    //一起帮还可以在好友间发私信，所有又有了IChat接口，其中也有一个Send()方法声明。
    //假设User类同时继承了ISendMessage和IChat，如何处理？
    //class EmailMessage : ISendMessage
    //{
    //    //public void Send()
    //    //{
    //    //    Console.WriteLine("吃饭");
    //    //}    
    //    void ISendMessage.Send()
    //    {
    //        Console.WriteLine("吃饭");
    //    }
    //}
    //public interface ISendMessage
    //{
    //    void Send();
    //}
    //public interface IChat
    //{
    //    void Send();
    //}
}
