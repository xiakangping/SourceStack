using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsid = { 1, 2, 3, 4, 5, 7, 8, 9, 10, 15 };
            
            for (int i = 0; i < studentsid.Length; i++)
            {
                if (studentsid[i] == 5)
                {
                    Console.WriteLine($"找到了，在数组中第{(i + 1)}位");
                    break;
                }
                else
                {
                    if (i==studentsid.Length-1)
                    {
                        Console.WriteLine("没找到");
                    }
                   
                }/*else*/
            }
        }
    }
}

