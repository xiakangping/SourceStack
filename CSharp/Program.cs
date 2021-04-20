using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Random random = new Random();
            //随机数值
            for (int i = 0; i < 10; i++)
            {
                nums[i] = random.Next(0, 100);
            }
            //冒泡排序 从小到大
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (nums[j] < nums[i])

                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }            
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
           

        }

    }



}

