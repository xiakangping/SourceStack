using System;

namespace HomeWord
{
    class Program
    {
        //1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9

        //2.用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
        //3.让电脑计算并输出：99+97+95+93+...+1的值
        //4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
        //5.找到100以内的所有质数（只能被1和它自己整除的数）
        //6.生成一个元素（值随机）从小到大排列的数组
        static void Main(string[] args)
        {
            //1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            // string[] names = { "1", "2", "3", "4", "5" };
            //for (int i = 0; i < names.Length; i++)
            //{
            // Console.WriteLine(names[i]);    //for循环
            //}

            //int i = -1;
            //while (i < 9)
            //{
            //    i += 2;
            //    Console.WriteLine(i);            //while循环
            //}
            //2.用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
            //3.让电脑计算并输出：99+97+95+93+...+1的值
            //4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //5.找到100以内的所有质数（只能被1和它自己整除的数）
            //6.生成一个元素（值随机）从小到大排列的数组

            //    //将源栈同学姓名 / 昵称分别：
            //    //按进栈时间装入一维数组，
            //    //按座位装入二维数组，
            //    //并输出共有多少名同学。
            //    string[] time = { "2021/3/2", "2021/4/7", "2021/4/11" };
            //    Console.WriteLine(time[0]);      //一维数组

            //    string[,] name = new string[4, 3];
            //    name[0, 0] = "周丁浩";
            //    name[0, 1] = "夏康平";           // 二维数组
            //    name[0, 2] = "陈国栋";
            //    name[1, 0] = "胡涛";
            //    name[1, 1] = "姜鹏";
            //    name[2, 0] = "韩佳宝";
            //    name[2, 1] = "刘胜林";
            //    name[2, 2] = "秦慧";
            //    name[3, 0] = "陈元";
            //    Console.WriteLine(name[0,1]);
            //    Console.WriteLine(name.Length);
            //用户依次由控制台输入：验证码、用户名和密码：
            //如果验证码输入错误，直接输出：“*验证码错误”；
            //如果用户名不存在，直接输出：“*用户名不存在”；
            //如果用户名或密码错误，输出：“*用户名或密码错误”
            //以上全部正确无误，输出：“恭喜！登录成功！”
            //string name = "夏康平", password = "123456", captcha = "258";
            //Console.WriteLine("请输入验证码");
            //string uscaptcha = Console.ReadLine();
            //if (captcha != uscaptcha)
            //{
            //    Console.WriteLine("验证码错误");
            //}
            //else
            //{
            //    Console.WriteLine("验证码正确");

            //    Console.WriteLine("请输入用户名");
            //    string usname = Console.ReadLine();
            //    if (name != usname)
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //    else
            //    {
            //        Console.WriteLine("登录成功");

            //        Console.WriteLine("请输入密码");
            //        string uspassword = Console.ReadLine();
            //        if (uspassword != password)
            //        {
            //            Console.WriteLine("用户名或密码错误");
            //        }
            //        else
            //        {
            //            Console.WriteLine("恭喜！登录成功");
            //        }
            //    }
            //}

        }
    }
}