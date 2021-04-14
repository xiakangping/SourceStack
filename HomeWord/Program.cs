using System;

namespace HomeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //用户依次由控制台输入：验证码、用户名和密码：
            string name = "夏康平", password = "123456", captcha = "258";
            //如果验证码输入错误，直接输出：“*验证码错误”；
            //如果用户名不存在，直接输出：“*用户名不存在”；
            //如果用户名或密码错误，输出：“*用户名或密码错误”
            //以上全部正确无误，输出：“恭喜！登录成功！”
            Console.WriteLine("请输入验证码");
            string uscaptcha = Console.ReadLine();
            if (captcha != uscaptcha)
            {
                Console.WriteLine("验证码错误");
            }
            else
            {
                Console.WriteLine("验证码正确");

                Console.WriteLine("请输入用户名");
                string usname = Console.ReadLine();
                if (name != usname)
                {
                    Console.WriteLine("用户名不存在");
                }
                else
                {
                    Console.WriteLine("登录成功");

                    Console.WriteLine("请输入密码");
                    string uspassword = Console.ReadLine();
                    if (uspassword != password)
                    {
                        Console.WriteLine("用户名或密码错误");
                    }
                    else
                    {
                        Console.WriteLine("恭喜！登录成功");
                    }
                }
            }
        }
    }
}