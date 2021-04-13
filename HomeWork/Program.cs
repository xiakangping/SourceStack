using System;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //观察一起帮个人资料页面，用合适的变量类型存储页面用户输入信息，并解释为什么
            string head = "头像";
            bool isMale = true; ;
            int birthyear = 1995;
            int birthmonth = 12;
            string starsign = "射手座";
            string keyword = "C#";
            string selfintroduction = "路漫漫其修远兮";

            Console.WriteLine(head);
            Console.WriteLine(birthyear);
            Console.WriteLine(birthmonth);
            Console.WriteLine(starsign);
            Console.WriteLine(keyword);
            Console.WriteLine(selfintroduction);
            Console.Read();
        }
    }
}
