using System;

namespace CSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            int m=GetMax(n1, n2);
            Console.WriteLine(m);
            
        }  
        static int GetMax(int n1,int n2)
        {
            int max=n1 > n2 ? n1 : n2;
            return max;
        }
    }     
}





