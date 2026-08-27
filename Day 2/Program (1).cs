//using System;
namespace Day2
{
    internal class Program
    {
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"a = {a}, b = {b}"); // swapped 
        //}

        //public static void Swap(ref int a, ref int b, ref int c)
        //{
        //    // a = b+c

        //    int temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"a = {a}, b = {b}"); // swapped 
        //}

        public static int Divide(int nem, int dem, out int rem)
        {
            rem = nem % dem;
            return nem / dem;
        }

        static void Main(string[] args)
        {
            #region Parsing
            //string str = Console.ReadLine()!;
            // Helpers
            // abc, 12a
            //1.Parse
            //int a = int.Parse(str); // 235
            //double d = double.Parse()

            // 2.TryParse
            //int b = 0;
            //bool isValid = int.TryParse(str, out b);

            //bool isValid = int.TryParse(str, out int b);

            //if(int.TryParse(str, out int b))
            //{
            //    Console.WriteLine(b+1);
            //}

            // 3.Convert
            //int c = Convert.ToInt32(str);
            //Console.WriteLine(c+10);
            #endregion

            #region Formating output
            //int id = 1;
            //string fname = "ola";
            //string lname = "ali";

            //1. String Concatination
            //Console.WriteLine("Id = " + id + ", FullName = " + fname + ' ' + lname);
            //2.string Holders
            //Console.WriteLine("Id = {0}, firstName = {1}, lastname = {2}", id, fname, lname); // okay
            //Console.WriteLine("Id = {0}, firstName = {1}, lastname = {4}", id, fname, lname); // exception
            //Console.WriteLine("Id = {0}, lastname = {2}", id, fname); // excption
            //Console.WriteLine("Id = {0}, lastname = {2}", id, fname, lname); // okay .. false representing data
            //3. String Interpolation
            //Console.WriteLine($"Id = {id}, firstname = {fname}, lname = {lname}");
            #endregion

            #region Escape Sequence
            //int id = 1;
            //string fname = "ola";
            //string lname = "ali";
            //Console.WriteLine($"Id = {id} \t firstname = {fname} \t lname = {lname}");
            //Console.WriteLine($"Id = {id, -8}, firstname = {fname, -8} lname = {lname, -8}");
            //Console.WriteLine($"Id = {id} \n firstname = {fname} \n lname = {lname}");

            //Console.WriteLine("C:\Users\Men3m");
            //Console.WriteLine("C:\\Users\\Men3m");
            //Console.WriteLine(@"C:\Users\Men3m");
            #endregion

            #region Reading Input

            //int x = Console.Read();  // read next char from input stream >> ascii code
            //Console.WriteLine(x);

            //ConsoleKeyInfo result = Console.ReadKey();
            //Console.WriteLine($"\n{result.Key}");

            //string x = Console.ReadLine();
            //Console.WriteLine(x);

            #endregion

            #region Nullable dt
            //int  -2e9:2e9
            //int a = 34;
            ////a = null;
            //Console.WriteLine(a);
            //int? b = int.MaxValue;
            //b = null;
            //Console.WriteLine(b);

            //char c = 'A';
            //c = null;

            //char? c = 'A';
            //c = null;

            //char c = 'A';
            //int a = c;
            //Console.WriteLine(a);

            //Nullable<int> a = 23;
            //a = null;

            #endregion

            #region Control Statements
            // 1. Conditional Statements
            // if
            // if else
            // if else if else
            // switch
            // Ternary Operator

            //double empSalary = 234123;
            //int month = int.Parse(Console.ReadLine());
            //if (month % 2 == 0)
            //{
            //    Console.WriteLine(empSalary * 1.1);
            //} 
            //else
            //{
            //    Console.WriteLine(empSalary*1.2);
            //}



            //int num = int.Parse(Console.ReadLine());
            //if(num == 0)
            //{
            //    Console.WriteLine("Naturel Number");
            //}
            //else if (num % 2 == 0)
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}

            //int month = int.Parse(Console.ReadLine()!);
            /*
               case 1:
               case 13:
                   cw("jan");
                   break;
               case 2:
               case 14:
                   cw("feb");
                   break;
            */

            //switch (month)
            //{
            //    case 1:
            //    case 13:
            //        Console.WriteLine("jan");
            //        break;
            //    case 2:
            //    case 14:
            //        Console.WriteLine("feb");
            //        break;
            //    case 3:
            //    case 15:
            //        Console.WriteLine("MAR");
            //        break;

            //    case 4:
            //        Console.WriteLine("APR");
            //        break;
            //    // ....

            //    default:
            //        Console.WriteLine("invalid month");
            //        break;
            //}

            //int x = 5;
            //string output = (x % 2 == 0) ? "Event" : "Odd";
            //Console.WriteLine(output);

            //Console.WriteLine((x % 2 == 0) ? "Event" : "Odd");



            // 2. Loops Statements
            // for
            // while 
            // do ... while
            // foreach


            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");

            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");

            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");
            //Console.WriteLine("Hey G6");

            //Console.WriteLine("Hey G6");

            //for(declare counter;condition;step){ }

            // declare counter;
            //for(;;){condition;   step; }

            //for (int i=0; i<10; i++)
            //{
            //    Console.WriteLine("Hey G6");
            //}

            //int idx = 1;
            //while (idx <= 5)
            //{
            //    Console.WriteLine($"{idx}. wlcm @ iti");
            //    idx++;
            //}

            //int idx = 1;
            //for (  ;  idx <= 5; )
            //{
            //    Console.WriteLine($"{idx}. wlcm @ iti");
            //    idx++;
            //}

            //int idx = 1;
            //do
            //{
            //    Console.WriteLine($"{idx}. wlcm @ iti");
            //    idx++;
            //} while (idx <= 5);
            #endregion

            #region Array (1D)
            // ahmed, ali, mona
            //  1      2    3

            //int id1 = 1;
            //int id2 = 2;
            //int id3 = 3; 

            // fixed size
            // same data type
            // store in heap
            // index is unique & zero based (0:size-1)

            //int[5] arr; // xxxx
            //int arr[5]; // xxxxxxxxxxxxxxxxxxxxxxxxxxxxx

            //int[] arr = new int[5];
            //for(int i=0; i<5; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //int[] arr1 = new int[5] { 1, 2, 3, 4, 5 }; // okay
            //int[] arr1 = new int[5] { 1, 2, 3, 5 };    // error
            //int[] arr1 = new int[] { 1, 2, 3, 5 };    // length = 4
            //int[] arr1 = { 1, 2, 3, 5 };    // length = 4  // sugar syntax


            //Console.WriteLine("Enter size of array");
            //int size = int.Parse(Console.ReadLine()!);

            //int[] arr = new int[size];
            //for(int i=0; i<size; i++)
            //{
            //    Console.WriteLine($"Enter element number {i+1}");
            //    //int x = int.Parse(Console.ReadLine()!);
            //    //arr[i] = x;
            //    arr[i] = int.Parse(Console.ReadLine()!);
            //}

            //for(int  i=0; i<arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}{((i == arr.Length - 1) ? '\n' : ' ')}");
            //}
            //Console.WriteLine("all numbers printed");

            //Console.WriteLine("Enter size of array");
            //int size = int.Parse(Console.ReadLine()!);

            //int[] arr = new int[size];
            //for(int idx = 0; idx<arr.Length; idx++)
            //{
            //    Console.WriteLine($"Enter age of student number {idx + 1}");

            //    //int age = int.Parse(Console.ReadLine()!);
            //    //arr[idx] = age;

            //    arr[idx] = int.Parse(Console.ReadLine()!);
            //}

            //double averageAge = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    averageAge += arr[i];
            //}

            ////averageAge /= size;
            //averageAge /= arr.Length;

            //Console.WriteLine($"avg age = {averageAge}");

            //Console.WriteLine("Enter size of array");
            //int size = int.Parse(Console.ReadLine()!);

            //double averageAge = 0;
            //int[] arr = new int[size];
            //for(int idx = 0; idx<arr.Length; idx++)
            //{
            //    Console.WriteLine($"Enter age of student number {idx + 1}");
            //    arr[idx] = int.Parse(Console.ReadLine()!);
            //    averageAge += arr[idx];
            //}

            //averageAge /= arr.Length;

            //Console.WriteLine($"avg age = {averageAge}");
            #endregion

            #region ref, out

            //int x = 5;
            //int y = 7;

            //// Call by value
            ////Console.WriteLine($"x = {x}, y = {y}"); // before: 5, 7
            ////Program.Swap(x, y);
            ////Console.WriteLine($"x = {x}, y = {y}"); // after: 7,5

            //// Call by reference
            //Console.WriteLine($"x = {x}, y = {y}"); // before: 5, 7
            //Program.Swap(ref x, ref y);
            //Console.WriteLine($"x = {x}, y = {y}"); // after: 7,5


            int a = 40;
            int b = 35;
            int div = Divide(a, b, out int rem);
            Console.WriteLine($"division = {div}, reminder = {rem}");







            #endregion
        }
    }
}
