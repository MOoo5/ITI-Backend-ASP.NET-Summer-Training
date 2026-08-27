using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    class Calculations
    {
        public static int Summation { get; set; }
        public int Subtraction { get; set; }
        public static int Multiplication { get; set; }


        public static int Sum(int a, int b)
        {
            Console.WriteLine("sum");
            Summation = a + b;
            return Summation;
        }

        public static string Sum(string a, string b)
        {
            return a + b;
        }

        public static T Sum<T>(T a, T b) where T : INumber<T>
        {
            Console.WriteLine("sum");
            return a + b;
        }


        public int Sub(int x, int y)
        {
            Console.WriteLine("sub");
            Subtraction = x - y;
            return Subtraction;
        }

        public static int Mul(int a, int b)
        {
            Console.WriteLine("mul");
            Multiplication = a * b;
            return Multiplication;
        }

        public static int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        public static void Operation(int a, int b, myDelegate del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation(int a, int b, myDelegate2<int> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation(int a, int b, Func<int, int, int> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation(in string a, string b, myDelegate2<string> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation(in string a, string b, Func<string, string, string> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation<T>(T a, T b, myDelegate2<T> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Operation<T>(T a, T b, Func<T, T, T> del)
        {
            Console.WriteLine(del.Invoke(a, b));
        }

        public static void Greet<T>(T a, T b)
        {
            Console.WriteLine("generic");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Greet(int a, int b)
        {
            Console.WriteLine("not generic");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void AccessLocation(bool access, myDelegate Grant, myDelegate Deny)
        {
            if (access)
            {
                Console.WriteLine(Grant.Invoke(12, 10));   // sum
            }
            else
            {
                Console.WriteLine(Deny.Invoke(12, 10));  // mul
            }
        }


        public static bool IsGreatedThan20(int num)
        {
            return num > 20;
        }

        public static bool IsGreatedThan20(decimal num)
        {
            return num > 25.12m;
        }

        //public static bool IsGreatedThan20<T>(T num) where T : INumber<T>
        //{
        //    return num > 20;
        //}
    }
}
