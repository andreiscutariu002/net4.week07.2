using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07._2.App
{
    public class Student
    {
        public void AddCourse(int courseId)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var s = new Student();

            //s.AddCourse(1);

            int i = 10;

            //bool result = i.IsGreaterThan(100);

            bool result = IsGreaterThan(10, 4);

            bool result2 = 10.IsGreaterThan(4);

            bool result3 = 10.IsGreaterThan(4);
        }

        public static bool IsGreaterThan(int a, int b)
        {
            return a > b;
        }
    }

    public static class IntExtensions
    {
        // first param - extension type
        // 
        public static bool IsGreaterThan(this int @this, int value)
        {
            return @this > value;
        }
    }
}
