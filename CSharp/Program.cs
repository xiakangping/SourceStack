using System;

namespace CSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            //定义一个生成数组的方法：int[] GetArray()，其元素随机生成从小到大排列。
            //利用可选参数控制：
            //最小值min（默认为1）
            //相邻两个元素之间的最大差值gap（默认为5）
            //元素个数length（默认为10个）
            GetArray(1,5,10);
            
            /// <summary>
            /// 随机生成一个数组从1-9
            /// </summary>
            /// <param name="min">默认为1</param>
            /// <param name="gap">每次递增5以内</param>
            /// <param name="lenght">数组长度</param>
            /// <returns>返回值</returns>
            static int[] GetArray(int min = 1, int gap = 5, int lenght = 10)
            {
                int[] array = new int[lenght];
                Random random = new Random();
                array[0] = random.Next(min, int.MaxValue);
                Console.WriteLine(array[0]);

                for (int i = 1; i < array.Length; i++)
                {
                    array[i] = random.Next(gap) + array[i - 1];
                    Console.WriteLine(array[i]);
                }
                return array;
            }



        }     
    }
}

