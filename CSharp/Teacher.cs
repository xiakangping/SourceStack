using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp
{
    public abstract class Teacher
    {
        public void Grow()
        {

        }
        public int Age { get; set; }
        public string Name { get; set; }
        public abstract void Eat();

    }
    class Student : Teacher, Ilearn,IPlay
    {
        public double Score { get; set; }
      
        public sealed override void Eat()
        {
            Console.WriteLine("大锅饭");
        }

        public void Golesson()
        {
            Console.WriteLine("上学");
        }

        void IPlay.Practise()
        {
            Console.WriteLine("玩电脑");
        }

        void Ilearn.Practise()
        {
            Console.WriteLine("运动");
        }
     
    }
    public interface Ilearn
    {
        public double Score { get; set; }
        void Golesson();
        void Practise();
    }
    public interface IPlay
    {
        void Practise();
    }

}
