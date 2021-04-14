using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input>=0)
            {
                Console.WriteLine("正确");
            }
            else
            {
                Console.WriteLine("错误");
            }
        }
    }
}

