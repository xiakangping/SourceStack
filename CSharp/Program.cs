using System;
namespace CSharp
{

    class Program
    {
        static void Main(string[] args)
        {
            DateTime mimicNow = new DateTime(2021, 5, 13);
            Console.WriteLine(mimicNow.Day+1);
            Console.WriteLine(mimicNow.Month+1);
            Console.WriteLine(mimicNow.Day*7);

           
        }


    }

    
}
