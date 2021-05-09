using System;
using YZ;

namespace CSharp
{

    class Program
    {
        static void ServeLunch(Person person)
        {
            person.Eat();
        }
        static void Main(string[] args)
        {
            ServeLunch(new Teacher { Name = "fg" });
            ServeLunch(new Student { Name = "xia" });
        }


    }
}
