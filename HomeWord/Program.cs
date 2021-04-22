using System;

namespace HomeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.将之前作业封装成方法（自行思考参数和返回值），并调用执行。

            //且以后作业，如无特别声明，皆需使用方法封装。
            //2.计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //double[] sums= { 75, 80.5, 67.5,99.5, 75.4, 65.8};
            //Console.WriteLine(Math. Round(GetAverage(sums),2));

            //3.完成“猜数字”游戏，方法名GuessMe()：
            //随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ

            //1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //string[] names = { "1", "2", "3", "4", "5" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);    //for循环
            //}

            //int i = -1;
            //while (i < 9)
            //{
            //    i += 2;
            //    Console.WriteLine(i);            //while循环
            //}
            //2.用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
            //string[] names = { "周丁浩", "夏康平", "陈国栋", "胡涛", "姜鹏", "韩佳宝", "刘胜林", "秦慧", "陈元" };
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}
            //3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //int sum = 0;
            //for (int i = 99; i >0; i -= 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //int[] doubles= { 95, 100, 78, 77, 86, 65, 70 ,55};
            ////int max = doubles[0];
            ////for (int i = 1; i < doubles.Length; i++)
            ////{
            ////    if (doubles[i]>max)
            ////    {
            ////        max = doubles[i];
            ////    }
            ////}
            //////else contime
            ////Console.WriteLine(max);             //取最大值
            //int min = doubles[0];
            //for (int i = 0; i < doubles.Length; i++)
            //{
            //    if (doubles[i]<min)
            //    {
            //        min = doubles[i];
            //    }
            //}/*else contime*/                     //取最小值
            //Console.WriteLine(min);
            //5.找到100以内的所有质数（只能被1和它自己整除的数）

            //for (int i = 2; i < 101; i++)
            //{
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {

            //            break;
            //        }
            //        else
            //        {
            //            if (j == i - 1)
            //            {
            //                Console.WriteLine(i);
            //            }//else
            //        }
            //    }
            //}
            //6.生成一个元素（值随机）从小到大排列的数组
            //int[] nums = new int[10];
            //Random random = new Random();
            ////随机数值
            //for (int i = 0; i < 10; i++)
            //{
            //    nums[i] = random.Next(0, 100);
            //}
            ////冒泡排序 从小到大
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length-1; j++)
            //    {
            //        if (nums[j] < nums[i])

            //        {
            //            int temp = nums[i];
            //            nums[i] = nums[j];
            //            nums[j] = temp;
            //        }
            //    }
            //}
            //foreach (int num in nums)
            //{
            //    Console.WriteLine(num);
            //}





            //7.设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()
            //int[,] mda = new int[3, 4];
            //for (int i = 0; i < mda.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mda.GetLength(1); j++)
            //    {
            //        Console.Write(i + j +" ");
            //    }
            //    Console.WriteLine();
            //}

            //    //将源栈同学姓名 / 昵称分别：
            //    //按进栈时间装入一维数组，
            //    //按座位装入二维数组，
            //    //并输出共有多少名同学。
            //string[] time = { "2021/3/2", "2021/4/7", "2021/4/11" };
            //Console.WriteLine(time[0]);      //一维数组

            //string[,] names = new string[4, 3];
            //names[0, 0] = "周丁浩";
            //names[0, 1] = "夏康平";           // 二维数组
            //names[0, 2] = "陈国栋";
            //names[1, 0] = "胡涛";
            //names[1, 1] = "姜鹏";
            //names[2, 0] = "韩佳宝";
            //names[2, 1] = "刘胜林";
            //names[2, 2] = "秦慧";
            //names[3, 0] = "陈元";
            //Console.WriteLine(names[0, 1]);
            //Console.WriteLine(names.Length);
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
        /// <summary>
        /// 求一组数组的平均值
        /// </summary>
        /// <param name="sums">数组里所有的数据</param>
        /// <returns>结果返回值</returns>
        //static double GetAverage(double[] sums)
        //{
        //    double avg = 0;
        //    for (int i = 0; i < sums.Length; i++)
        //    {
        //        avg = sums[i] + avg;
        //    }
        //    return avg / sums.Length;
        //}

    }
}