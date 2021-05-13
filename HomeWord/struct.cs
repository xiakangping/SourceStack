using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    class Htruct
    {
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
}
