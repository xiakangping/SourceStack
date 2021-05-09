using System;
using System.Collections.Generic;
using System.Text;

namespace YZ
{

    public class Person
    {
        public string Name { get; set; }
        public virtual void Eat()
        {
            // Console.WriteLine("开饭");
        }
    }
    public class Student : Person
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name}吃大锅饭");
        }   
    }
    public class Teacher : Person
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name}吃小灶");         
        }    
    }
}
