using System.Runtime.Intrinsics.Arm;

namespace Day3
{
    struct Complex
    {
        int real; 
        int imag;

        public void SetReal(int _real)
        {
            if(_real <= 0)
            {
                throw new Exception("invalid data for real");
            }

            real = _real;
        }

        public int GetReal()
        {
            if(real <= 0)
            {
                throw new Exception("can't retrieve invalid data for real");
            }
            return real;
        }

        public void SetImag(int _imag)
        {
            imag = _imag;
        }

        public int GetImag()
        {
            return imag;
        }

        public string GetString()
        {
            char op = imag >= 0 ? '+' : '-';
            return $"{real}{op}{Math.Abs(imag)}i";
        }

    }
    struct Complex2
    {

        // 1. Default  Constructor
        //// 2. Parameterless Constructor
        //public Complex2()
        //{
        //    real = 1;
        //    Imag = -1;
        //}

        // 3. Parameterized Constructor
        public Complex2(int _real)
        {
            //if(_real <= 0)
            //{
            //    throw new Exception();
            //}

            real = _real;
            Imag = -1;
        }

        public Complex2(int _real, int _imag)
        {
            real = _real;
            Imag = _imag;
        }

        //x = 3;
        // Real = 5;
        int real;
        public int Real
        {
            set
            {
                if(value <= 0)
                {
                    throw new Exception("invalid data for real");
                }
                real = value;
                //Real = value; // not accepted
            }

            get
            {
                if(real <= 0)
                {
                    throw new Exception("can't retrieve data from real");
                }

                return real;
                // return Real;  // not accepted
            }
        }
        

        public int Imag { get; set; } // automatic property in IL (setter, getter, private field)

        public string GetString()
        {
            char op = Imag >= 0 ? '+' : '-';
            return $"{real}{op}{Math.Abs(Imag)}i";
        }

    }


    internal class Program
    {

        static void Main(string[] args)
        {
            #region Multi-Dim Array
            //int[] arr = new int[5];
            //int[,] arr = new int[3, 4];

            //int[,] ids = new int[4]; // xxxx

            //string[,] names = new string[4, 5];
            //string[,] subjects = new string[4, 5] {
            //    { "a", "b", "c", "d", "e"},
            //    { "e", "", "", "", ""},
            //    { "", "", "", "", ""},
            //    { "", "", "", "", ""},

            //};

            //string[,] subjects1 = new string[,] {
            //    { "a", "b", "c", "d", "e"},
            //    { "e", "", "", "", ""},
            //    { "", "", "", "", ""},
            //    { "", "", "", "", ""},

            //};

            //string[,] subjects2 = {
            //    { "a", "b", "c", "d", "e"},
            //    { "e", "", "", "", "f"},
            //    { "", "", "", "", ""},
            //    { "", "", "", "", ""},
            //};

            //subjects2[1,4] > f

            //string[,] students = new string[4, 5];

            // students.Length = coursesNumber * studentsNumber = 4*5 = 20
            // students.GetLength(0) = coursesNumber = 4
            // students.GetLength(1) = studentsNumber = 5

            ////idx: [0, 1, 2, 3, 4]
            ////dim: [1, 2, 3, 4, 5]

            //Console.WriteLine(students.Length);
            //Console.WriteLine(students.GetLength(0));
            //Console.WriteLine(students.GetLength(1));
            //Console.WriteLine(students.GetLength(2));

            //Console.Write("Enter Course Number: ");
            //int coursesNumber = int.Parse(Console.ReadLine()!);

            //string[] courses = new string[coursesNumber]; //// C#, DB, EF, LINQ, MVC, WebAPI
            //for (int i = 0; i < courses.Length; i++)
            //{
            //    Console.Write($"Enter Course number {i+1}: ");
            //    courses[i] = Console.ReadLine()!;
            //}

            //Console.Write("Enter number of students registered per course: ");
            //int studentsNumber = int.Parse(Console.ReadLine()!);

            //string[,] students = new string[coursesNumber, studentsNumber];  // 4,5
            //for (int i = 0; i < students.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter Students who are registered in course {courses[i]}");
            //    for (int j = 0; j < students.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter Students number {j+1}: ");
            //        students[i,j] = Console.ReadLine()!;
            //    }
            //}

            //for(int i=0; i<students.GetLength(0) ; i++)
            //{
            //    Console.WriteLine($"Students registered in course {courses[i]}: ");
            //    for(int j=0; j < students.GetLength(1); j++)
            //    {
            //        Console.Write($"{students[i, j]}{(j == students.GetLength(1) - 1 ? '\n' : ", ")}");
            //    }
            //}
            #endregion

            #region Jagged Array

            //Console.Write("Enter Course Number: ");
            //int coursesNumber = int.Parse(Console.ReadLine()!);

            //string[] courses = new string[coursesNumber]; //// C#, DB, EF, LINQ, MVC, WebAPI
            //for (int i = 0; i < courses.Length; i++)
            //{
            //    Console.Write($"Enter Course number {i + 1}: ");
            //    courses[i] = Console.ReadLine()!;
            //}

            //string[][] students = new string[coursesNumber][];
            //for(int i=0; i<students.GetLength(0); i++)
            //{
            //    Console.Write($"Enter students number in course: {courses[i]}: ");
            //    int studentsNumber = int.Parse(Console.ReadLine()!);

            //    students[i] = new string[studentsNumber];
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        Console.Write($"Enter student number {j+1}: ");
            //        students[i][j] = Console.ReadLine()!;
            //    }
            //}

            //for(int i=0; i<students.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Students registered in course {courses[i]}: ");
            //    for (int j = 0; j < students[i].Length; j++)
            //    {
            //        Console.Write($"{students[i][j]}{(j == students[i].Length - 1 ? '\n' : ", ")}");
            //    }
            //}
            #endregion

            #region Struct

            //Complex c = new Complex();
            //c.real = 0;
            //c.real = -5;

            //c.SetReal(-5);
            //c.SetReal(5);

            //Console.WriteLine(c.GetReal());

            //c.SetImag(-7);
            //Console.WriteLine(c.GetImag());

            //Complex c2 = new Complex();
            //c2.SetReal(7);
            //c2.SetImag(-9);
            //Console.WriteLine(c2.GetString());

            //Complex c3 = new Complex();
            //c3.SetReal(17);
            //c3.SetImag(29);
            //Console.WriteLine(c3.GetString());


            //Complex c4 = new Complex();
            //c4.SetReal(0);
            //c4.SetImag(-3);
            //Console.WriteLine(c4.GetString());
            //c4.GetReal();


            // ref: 
            // 1. allocate obj in heap
            // 2. assign address to ref which is declared in the stack
            // 3. call default constructor
            // val
            // 1. call default constructor

            // default ctor >> set default value;


            //int x;
            //Console.WriteLine(x);

            //Complex c = new(); // sugar syntax
            //c.SetReal(5);
            //c.SetImag(-8);
            //Console.WriteLine(c.GetString());

            ////int currentReal = c.GetReal();
            ////c.SetReal(currentReal + 1);

            //c.SetReal(c.GetReal() + 1);
            //Console.WriteLine(c.GetString());

            //int x = 12;
            //x++;
            //x += 34;


            //Complex2 c = new Complex2();
            //c.Real = -5;
            //c.Imag = 7;
            //Console.WriteLine(c.GetString());

            //Complex2 c = new Complex2();
            //c.Real = 5;
            //c.Imag = 7;
            //c.Real++;
            //Console.WriteLine(c.GetString());


            //Complex2 c = new Complex2();
            //Console.WriteLine(c.GetString());

            //Complex2 c2 = new Complex2(5, -7);
            //Console.WriteLine(c2.GetString());

            //Complex2 c3;
            //try
            //{
            //    c3 = new Complex2(-5);
            //    Console.WriteLine(c3.GetString());
            //}
            //catch (Exception ex)
            //{
            //    c3 = new();
            //}


            Complex2 c = new();
            Console.WriteLine(c.GetString());

            #endregion
        }
    }
}
