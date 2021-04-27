using System;

namespace CSharp
{

    class Program
    {

        static void Main(string[] args)
        {
            int x = Program.GetMax(1, 3);
            Console.WriteLine(x);
        }

        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

    }
}

