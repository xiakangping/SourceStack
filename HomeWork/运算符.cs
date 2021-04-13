using System;

namespace HomeWork
{
    class 运算符
    {
        static void Main(string[] args)
        {
            //    输出两个整数 / 小数的和 / 差 / 积 / 商
            float a = 5;
            int b = 6;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
        
        //    电脑计算并输出：[(23 + 7)x12-8]÷6的小数值（挑战：精确到小数点以后2位）
            float result=(float)((23 + 7)*12 - 8)/6;
            string i = result.ToString("F2");
            string i2 = result.ToString("0.00");
            Console.WriteLine(i);
            Console.WriteLine(i2);
            
           
        //    想一想以下语句输出的结果：
        //    int i = 15;
        //    Console.WriteLine(i++);
        //    i -= 5;
        //    Console.WriteLine(i);
        //    Console.WriteLine(i >= 10);

            //    Console.WriteLine("i值的最终结果为：" + i);

            //    int j = 20;
            //    Console.WriteLine($"{i}+{j}={i + j}");
            //    想一想如下代码的结果是什么，并说明原因：
            //    int a = 10;
            //    Console.WriteLine(a > 9 && (!(a < 11) || a > 10));
            //    当a为何值时，结果为true？
            //    bool result = (a + 3 > 12) && a < 3.14 * 4 && a != 11;
            Console.Read();
        }
}
}
