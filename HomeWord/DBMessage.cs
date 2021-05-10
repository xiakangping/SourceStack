using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class DBMessage : ISendMessage
    {
        public void Send()
        {
            Console.WriteLine("睡觉");
        }
    }
}
