namespace CSharp
{
  class Student
    {
        public double Score { get; set; }
        public int Age { get; set; }
        public static bool operator >(Student a,Student b)
        {
            return false;
        }
        public static bool operator <(Student a, Student b)
        {
            return false;
        }

    }

}
