using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = true;
            int number = 0;
            Console.WriteLine("请输入内容");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("您的输入有误");
                b = false;
            }
            if (b)
            {
                Console.WriteLine(number*2);
            }//else

        }
    }
}
    





