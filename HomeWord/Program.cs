﻿using Homework;
using System;
using static Homework.Htruct;

namespace HomeWord
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 
        //static void Publish(ContentService contentService)
        //{
        //    contentService.Publish();
        //}
        static void Main(string[] args)
        {                                

            //Bed bed;                            //用代码证明struct定义的类型是值类型
            //bed._number = 30;
            //Console.WriteLine(bed._number);

            //ISendMessage x = new DBMessage();
            //x.Send();
            //ISendMessage xia = new EmailMessage();//实现Send接口 显示实现
            //xia.Send();
            //EmailMessage xia = new EmailMessage();
            //xia.Send();
            //DBMessage x = new DBMessage(); //实现Send接口 隐示实现
            //x.Send();
            //ISendMessage xia = new User();
            //xia.Send();   //同时继承了ISendMessage和IChat 显示实现
            //IChat x = new User();
            //x.Send();
            //    Publish(new Article { Name = "Article"});
            //    Publish(new Problem { Name = "Problem"});
            //    Publish(new Suggest { Name = "Suggest"});//多态
            //    // 观察“一起帮”的：
            //注册 / 登录功能，定义一个User类，
            //包含字段：Name（用户名）、Password（密码）
            //和 邀请人（InvitedBy），和方法：Register()、Login()
            //求助版块，定义一个类Problem，
            //包含字段：标题（Title）、正文（Body）、悬赏（Reward）、发布时间（PublishDateTime）和作者（Author），和方法Publish()
            //帮帮币版块，定义一个类HelpMoney，表示一行帮帮币交易数据，包含你认为应该包含的字段和方法

            //为这些类的字段和方法设置合适的访问修饰符。
            //1.定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。利用可选参数控制：
            //2.最小值min（默认为1）
            //3.相邻两个元素之间的最大差值gap（默认为5）
            //  元素个数length（默认为10个）
            //GetArray(1, 5, 10);

            //4.实现二分查找，方法名BinarySeek(int[] numbers, int target)：
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //int target = BinarySeek(numbers, 2);
            //Console.WriteLine(target);
            //  传入一个有序（从大到小 / 从小到大）数组和数组中要查找的元素
            //  如果找到，返回该元素所在的下标；否则，返回 - 1
            //1.利用ref调用Swap()方法交换两个同学的床位号
            //int n1 = 201, n2 = 202;
            //Test(ref n1, ref n2);
            //2.将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            //true / false，表示登陆是否成功
            //string，表示登陆失败的原因
            //LogOn();

            //1.将之前作业封装成方法（自行思考参数和返回值），并调用执行。
            //且以后作业，如无特别声明，皆需使用方法封装。
            //2.计算得到源栈同学的平均成绩（精确到两位小数），方法名GetAverage()
            //double[] sums = { 75, 80.5, 67.5, 99.5, 75.4, 65.8 };
            //Console.WriteLine(Math.Round(GetAverage(sums), 2));

            //3.完成“猜数字”游戏，方法名GuessMe()：
            //随机生成一个大于0小于1000的整数
            //用户输入一个猜测值，系统进行判断，告知用户猜测的数是“大了”，还是“小了”
            //没猜中可以继续猜，但最多不能超过10次
            //如果5次之内猜中，输出：你真牛逼！
            //如果8次之内猜中，输出：不错嘛！
            //10次还没猜中，输出：(～￣(OO)￣)ブ
            //GuessMe();
            //1.利用ref调用Swap()方法交换两个同学的床位号
            //2.将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
            //  true / false，表示登陆是否成功
            //  string，表示登陆失败的原因
            //1.分别用for循环和while循环输出：1,2,3,4,5 和 1,3,5,7,9
            //string[] names = { "1", "2", "3", "4", "5" };
            //Font(names);
            //Whiles(names);
            //2.用for循环输出存储在一维/二维数组里的源栈所有同学姓名/昵称
            //string[] names = { "周丁浩", "夏康平", "陈国栋", "胡涛", "姜鹏", "韩佳宝", "刘胜林", "秦慧", "陈元" };
            //Font2(names);
            //3.让电脑计算并输出：99 + 97 + 95 + 93 + ...+1的值
            //Int(47);
            //4.将源栈同学的成绩存入一个double数组中，用循环找到最高分和最低分
            //MaxMin(12.5);
            //5.找到100以内的所有质数（只能被1和它自己整除的数）
            //Mach(2);
            //6.生成一个元素（值随机）从小到大排列的数组
            //Bubbing();
            //7.设立并显示一个多维数组的值，元素值等于下标之和。Console.Write()           
            //Orcode(2);
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
        /// 随机数组
        /// </summary>
        /// <param name="min">默认值为1</param>
        /// <param name="gap">在5以内递增</param>
        /// <param name="lenght">数组长度，默认为10</param>
        /// <returns></returns>
        //static int[] GetArray(int min = 1, int gap = 5, int lenght = 10)
        //{
        //    int[] array = new int[lenght];
        //    Random random = new Random();
        //    array[0] = random.Next(min, int.MaxValue);
        //    Console.WriteLine(array[0]);

        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        array[i] = random.Next(gap) + array[i - 1];
        //        Console.WriteLine(array[i]);
        //    }
        //    return array;
        //}
        /// <summary>
        /// 二分查找
        /// </summary>
        /// <param name="numbers">数组</param>
        /// <param name="target">目标</param>
        /// <returns></returns>
        //static int BinarySeek(int[] numbers, int target)
        //{
        //    int left = 0, right = numbers.Length - 1;

        //    while (left <= right)
        //    {
        //        int middle = (left + right) / 2;
        //        if (target == numbers[middle])
        //        {
        //            return middle;
        //        }
        //        else if (target > numbers[middle])
        //        {
        //            left = middle + 1;
        //        }
        //        else if (target < numbers[middle])
        //        {
        //            right = middle - 1;
        //        }//else
        //    }
        //    return -1;
        //}
        /// <summary>
        /// 用户登录方法
        /// </summary>
        /// //2.将登陆的过程封装成一个方法LogOn()，调用之后能够获得：
        //true / false，表示登陆是否成功
        //string，表示登陆失败的原因
        //static bool LogOn()
        //{
        //    string name = "夏康平", password = "123", reason = "用户名密码错误";
        //    Console.WriteLine("输入用户名");
        //    string usname = Console.ReadLine();
        //    if (usname != name)
        //    {
        //        Console.WriteLine(reason);
        //        return false;
        //    }
        //    else
        //    {
        //        Console.WriteLine("请输入密码");
        //        string uspassword = Console.ReadLine();
        //        if (uspassword != password)
        //        {
        //            Console.WriteLine(reason);
        //            return false;
        //        }
        //        else
        //        {

        //            Console.WriteLine("true");
        //            return true;
        //        }
        //    }
        //}
        /// <summary>
        /// 用ref调换床位
        /// </summary>
        /// <param name="n1">201</param>
        /// <param name="n2">202</param>
        //static void Test(ref int n1, ref int n2)
        //{           
        //    int temp = n1;
        //    n1 = n2;
        //    n2 = temp;
        //    Console.WriteLine(n1);
        //    Console.WriteLine(n2);
        //    return;
        //}
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
        ///猜数字游戏
        ///
        //static void GuessMe()
        //{
        //    int nums = new Random().Next(1, 1000);
        //    Console.WriteLine("随机数是:" + nums);
        //    Console.WriteLine("请输入数字");
        //    for (int i = 0; i < 11; i++)
        //    {
        //        int input = Convert.ToInt32(Console.ReadLine());

        //        if (input > nums)
        //        {

        //            Console.WriteLine($"太大了，还剩{10 - i}次");
        //        }
        //        else if (input < nums)
        //        {
        //            Console.WriteLine($"太小了，还剩{10 - i}次");
        //        }
        //        else
        //        {
        //            Console.WriteLine("恭喜你，猜中了");
        //            if (i <= 5)
        //            {
        //                Console.WriteLine("你真牛逼！");
        //            }
        //            else if (i <= 8)
        //            {
        //                Console.WriteLine("不错嘛！");
        //            }
        //            else if (i <= 10)
        //            {
        //                Console.WriteLine("太菜了！！！");
        //            }
        //            else if (input != nums && i >= 10)
        //            {
        //                Console.WriteLine("(～￣(OO)￣)ブ");
        //            }//else
        //            break;

        //        }



        //    }
        //    return;
        //}
        /// <summary>
        /// 设立显示一个二维数组
        /// </summary>
        /// <param name="moos"></param>
        //static void Orcode(int moos)
        //{
        //    int[,] mda = new int[3, 4];
        //    for (int i = 0; i < mda.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < mda.GetLength(1); j++)
        //        {
        //            Console.Write(i + j + " ");
        //        }
        //        Console.WriteLine();
        //    }
        /// <summary>
        /// 随机数组从小到大排序
        /// </summary>
        //static void Bubbing()
        //{
        //    int[] nums = new int[10];
        //    Random random = new Random();

        //    //随机数值
        //    for (int i = 0; i < 10; i++)
        //    {
        //        nums[i] = random.Next(0, 100);
        //    }
        //    //冒泡排序 从小到大
        //    for (int i = 1; i < nums.Length; i++)
        //    {
        //        for (int j = 0 ; j < nums.Length - i; j++)
        //        {
        //            if (nums[j] > nums[j+1])

        //            {
        //                int temp = nums[j];
        //                nums[j] = nums[j+1];
        //                nums[j+1] = temp;
        //            }//eles
        //        }
        //    }
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        Console.WriteLine(nums[i]);
        //    }
        //    return;
        //}
        /// <summary>
        /// 找到100以内的质数
        /// </summary>
        /// <param name="find"></param>
        //static void Mach(int find)
        //{
        //    for (int i = 2; i < 101; i++)
        //    {
        //        for (int j = 2; j < i; j++)
        //        {
        //            if (i % j == 0)
        //            {

        //                break;
        //            }
        //            else
        //            {
        //                if (j == i - 1)
        //                {
        //                    Console.WriteLine(i);
        //                }//else
        //            }
        //        }
        //    }
        //}
        /// <summary>
        /// 求一组数组的最大值和最小值
        /// </summary>
        /// <param name="sums"></param>
        //static void MaxMin(double sums)
        //{
        //    int[] doubles = { 95, 100, 78, 77, 86, 65, 70, 55 };
        //    int max = doubles[0], min = doubles[0];
        //    for (int i = 1; i < doubles.Length; i++)
        //    {
        //        if (doubles[i] > max)
        //        {
        //            max = doubles[i];
        //        }
        //        else if (doubles[i] < min)
        //        {
        //            min = doubles[i];
        //        }
        //    }
        //    Console.WriteLine($"最大值{max},最小值{min}");
        //    return;
        //}
        /// <summary>
        /// 用for循环求和
        /// </summary>从99开始每次递减2
        /// <param name="ums"></param>
        //static void Int(int ums)
        //{
        //    int sum = 0;
        //    for (int i = 99; i > 0; i -= 2)
        //    {
        //        sum += i;
        //    }
        //    Console.WriteLine(sum);
        //    return;
        //}
        /// <summary>
        /// 用for循环输出数组里的字符
        /// </summary>
        /// <param name="names">一串数组</param>
        //static void Font2(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        Console.WriteLine(names[i]);

        //    }
        //    return;
        //}
        /// <summary>
        /// 用While输出数字，每次增加2，到9停止
        /// </summary>
        /// <param name="number">输出的数组</param>
        //static void Whiles(string[] number)
        //{
        //    int i = -1;
        //    while (i < 9)
        //    {
        //        i += 2;
        //        Console.WriteLine(i);            //while循环
        //    }
        //    return;
        //}

        /// <summary>
        /// 用for循环输出数组的内容
        /// </summary>
        /// <param name="names">一个数组</param>
        //static void Font(string[]names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        Console.WriteLine(names[i]);    //for循环
        //    }
        //    return;
        //}


    }

    //internal class Suggest : ContentService
    //{
    //    public string Name { get; set; }
    //}

    //internal class Problem : ContentService
    //{
    //    public string Name { get; set; }
    //}

    //internal class Article : ContentService
    //{
    //    public string Name { get; set; }
    //}
}
