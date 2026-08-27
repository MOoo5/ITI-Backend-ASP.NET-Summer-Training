using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    static class Math2
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int CountWords1(string s)
        {
            return s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count();
        }

        // extension method = (class:static, method:static, caller:this
        public static int CountWords(this string s)
        {
            return s.Split(' ').Count();
        }

        public static int CalculateAge(this DateTime birthDate)
        {
            return DateTime.UtcNow.Year - birthDate.Year;
        }
    }
}
