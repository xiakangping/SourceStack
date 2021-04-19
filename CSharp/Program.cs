using System;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentids = { 8, 5, 50, 46, 32, 88, 105, 20, 58, 79, 11 };
            for (int i = 0; i < studentids.Length; i++)
            {
                for (int j = 0; j < studentids.Length-1; j++)
                {
                    if (studentids[j] < studentids[j+1])
                    {
                        int box = studentids[j];
                        studentids[j] = studentids[j + 1];
                        studentids[j + 1] = box;
                    }//else.
                }
            }
            for (int i = 0; i< studentids.Length; i++)
            {
                Console.WriteLine(studentids[i]);
            }
           
            


        }
    }
}