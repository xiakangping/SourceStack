using System;

namespace CSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            //随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ
            GuessMe();




        }
        static void GuessMe()
        {
            int nums = new Random().Next(1, 1000);
            //Console.WriteLine("随机数是:" + nums);
            Console.WriteLine("请输入数字");
            for (int i = 0; i < 11; i++)
            {
                int input = Convert.ToInt32(Console.ReadLine());

                if (input > nums)
                {

                    Console.WriteLine($"太大了，还剩{10 - i}次");
                }
                else if (input < nums)
                {
                    Console.WriteLine($"太小了，还剩{10 - i}次");
                }
                else
                {
                    Console.WriteLine("恭喜你，猜中了");
                    if (i <= 5)
                    {
                        Console.WriteLine("你真牛逼！");
                    }
                    else if (i <= 8)
                    {
                        Console.WriteLine("不错嘛！");
                    }
                    else if (i<=10)
                    {
                        Console.WriteLine("太菜了！！！");
                    }
                    else if (input != nums && i >= 10)
                    {
                        Console.WriteLine("(～￣(OO)￣)ブ");
                    }//else
                    break;

                }
              
            }
        }
    }
}




