using System;
using System.Collections.Generic;
using System.Text;


namespace CSharp
{
    public abstract class Teacher
    {

    }
    public struct Bed
    {
        public int _number;
        public double Price { get; set; }
        public Bed(int number)
        {
            _number = number;
            Price = 50;
        }
    }
}
