using System;

namespace HomeWord
{
    class Program
    {
        static void Main(string[] args)
        {
            

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
        
       
    }
} 