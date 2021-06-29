using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp02
{
    public class Student
    {
        public string name;
        public int age;
        public Student(string name)   // 构造函数 1
        {
            this.name = name;
        }

        public Student(string name, int age)
            : this(name)   // 使用this()调用构造函数 1
        {
            this.age = age;
            Console.WriteLine(name+age);
        }
    }

}
