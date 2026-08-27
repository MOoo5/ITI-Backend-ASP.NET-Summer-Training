namespace Day7
{
    // public delegate returnType delegateName functionSignature
    public delegate int myDelegate(int n1, int n2);    // user defined delegate
    public delegate void myDelegate1(int n1, int n2);  // user defined delegate
    public delegate T myDelegate2<T>(T n1, T n2);      // generic user defined delegate
    public delegate void myDelegate3<T>(T n1, T n2);   // generic user defined delegate

    internal class Program
    {
        static void Main(string[] args)
        {
            #region user defined delegate
            //myDelegate d = new myDelegate(Calculations.Sum); // ok
            //myDelegate d1 = new myDelegate(Calculations.Mul); // error

            //Calculations calc = new();
            //myDelegate d2 = calc.Sub;

            //int sub = d2.Invoke(100, 90);
            //Console.WriteLine(sub);

            //Console.WriteLine(d2(100, 40));


            //d2 = Calculations.Sum;
            //Console.WriteLine( d2(13, 17));

            //Calculations.Operation(12, 123, new myDelegate(Calculations.Sum));

            //myDelegate grant = new(Calculations.Sum);
            //myDelegate deny = Calculations.Mul;

            //Calculations.AccessLocation(false, grant, deny);
            #endregion

            #region multicast user defined delegate
            // multicasting delegate

            //int y = 10;
            //y += 2;
            //y = 3;

            //myDelegate d1 = Calculations.Sum;
            //d1 += Calculations.Mul;
            //d1 = calc.Sub;

            //Console.WriteLine(d1(12, 10));

            //int x = 10;
            //x += 2;
            //x += 3;
            //Calculations calc = new();
            //myDelegate d = Calculations.Sum;
            //d += calc.Sub;
            //d += Calculations.Mul;
            //Console.WriteLine(d(12, 10));

            //Calculations calc = new();
            //myDelegate d = Calculations.Sum;
            //d += calc.Sub;
            //d += Calculations.Sum;
            //d += Calculations.Mul;
            //Console.WriteLine( d.Invoke(5, 6));

            //Calculations calc = new();
            //myDelegate d = Calculations.Sum;
            //d += calc.Sub;
            //d = Calculations.Sum;
            //d += Calculations.Mul;
            //Console.WriteLine( d.Invoke(5, 6));

            //Calculations calc = new();
            //myDelegate d = Calculations.Sum;
            //d += calc.Sub;
            //d -= Calculations.Sum;
            //d += Calculations.Mul;
            //Console.WriteLine( d.Invoke(5, 6));


            //Calculations calc = new();
            //myDelegate d = Calculations.Sum;     
            //d += calc.Sub;
            //d += Calculations.Mul;
            //Calculations.Operation(10, 12, d);

            // sum
            // sub
            // mul
            // 120

            // 22 2 120
            // 120
            // 120 22 2 120
            // 22 -2 120

            //Calculations calculations = new ();
            //myDelegate d1 = Calculations.Sum;
            //d1 += Calculations.Mul;

            //myDelegate d2 = calculations.Sub;
            //d2 += Calculations.Mul;

            ////myDelegate d3 = d1 + d2;
            ////Console.WriteLine(d3.Invoke(12, 12));
            //// sum > mul > sub > mul > 144

            //myDelegate d4 = d1 - d2;
            //Console.WriteLine(d4.Invoke(12, 12));

            // sum mul 144

            //Calculations calculations = new();
            //myDelegate d1 = Calculations.Sum;
            //d1 += calculations.Sub;
            //d1 += Calculations.Mul;

            //myDelegate d2 = calculations.Sub;
            //d2 += Calculations.Mul;

            //myDelegate d4 = d1 - d2;
            //Console.WriteLine(d4.Invoke(12, 12));
            //// sum 24

            //Calculations calculations = new();
            //myDelegate d1 = Calculations.Sum;
            //d1 += Calculations.Mul;
            //d1 += calculations.Sub;

            //myDelegate d2 = calculations.Sub;
            //d2 += Calculations.Mul;

            //myDelegate d4 = d1 - d2;
            //Console.WriteLine(d4.Invoke(12, 12));
            //// sum mul sub 0
            #endregion

            #region generic user defined delegate

            //myDelegate d1 = Calculations.Sum;
            //d1.Invoke("21", "23");

            //myDelegate2<int> d1 = new myDelegate2<int>(Calculations.Sum);
            //Console.WriteLine(d1.Invoke(12, 14));  // int overload
            //Calculations.Operation(12, 14, d1);


            //myDelegate2<string> d2 = Calculations.Sum; // sugar syntax
            //Console.WriteLine(d2.Invoke("@323", "2323"));  // string overload
            //Calculations.Operation("def", "abc", d2);
            //Calculations.Operation<int>(12, 14, d1);

            //myDelegate2<float> dd = new myDelegate2<float>(Calculations.Sum<float>);
            //Calculations.Operation<float>(3.14f, 6.85f, dd);

            //myDelegate2<long> dl = new myDelegate2<long>(Calculations.Sum<long>);
            //Calculations.Operation(10000, 90000, dl);
            #endregion

            #region Built-in Delegates (Generic)
            #region explanation
            // Func => return value
            // Action => no return.
            // Predicate => bool.

            // Func<out T>                       // T func(){}
            // Func<in T, out T>                 // T func(T a){}
            // Func<in T, in T, out T>           // T func(T a, T b){}
            // Func<in T, in T, in T, out T>     // T func(T a, T b, T c){}

            // Action<in T>                      // void func(T a){}
            // Action<in T, in T>                // void func(T a, T b){}
            // Action<in T, in T, in T>          // void func(T a, T b, T c){}

            //Predicate<>
            #endregion

            #region Func
            //Func<int, int, int> btd = new Func<int, int, int>(Calculations.Sum<int>);
            //Console.WriteLine(btd.Invoke(12, 24));

            //Func<int, int, int> btd = Calculations.Sum<int>;
            //Console.WriteLine(btd(12, 24));
            #endregion

            #region Action
            //Action<int, int> md = new Action<int, int>(Calculations.Greet);
            //md.Invoke(12, 17);

            //Action<int, int> md = new Action<int, int>(Calculations.Greet<int>);
            //md.Invoke(12, 17);

            //Action<char, char> md = new Action<char, char>(Calculations.Greet<char>);
            //md.Invoke('A', 'M');

            //Action<bool, bool> md = Calculations.Greet<bool>;
            //md.Invoke(true, false);


            #endregion

            #region Predicate
            //List<int> numbers = new List<int>() { 10, 30, 15, 20, 25};

            //int result = numbers.Find(Calculations.IsGreatedThan20);
            //Console.WriteLine(result);

            //List<int> output = numbers.FindAll(Calculations.IsGreatedThan20);
            //foreach(int x in output)
            //    Console.Write($"{x} ");


            //List<decimal> numbers2 = new List<decimal>() { 10, 30, 15, 20, 25};
            //Predicate<decimal> pred = Calculations.IsGreatedThan20;
            //decimal result = numbers2.Find(pred);
            //Console.WriteLine(result);
            #endregion

            #endregion

            #region Anonymous Methods

            // using keyword delegate
            //List<int> numbers = new List<int>() { 10, 30, 15, 20, 25 };

            //int result1 = numbers.Find(delegate(int num)
            //{
            //    return num > 20;
            //});

            //Console.WriteLine(result1);

            // using lambda expression  // goes to
            //int result2 = numbers.Find(num => num > 20);
            //Console.WriteLine(result2);


            //Func<int, int, int> md0 = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Func<int, int, int> md1 = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Func<int, int, int> md2 = (a, b) => a + b;
            //Func<int, int, string> md3 = (a, b) => 
            //{
            //    int sum = a + b;
            //    return sum.ToString();
            //};

            #endregion

            #region Implicit type variable (last region)
            //int x = 5;

            //var coutnids = 23; // select Count(Id) from Users
            //var count = 2.3m;
            //count = "ali";  // error in compilation time

            //dynamic c = 14; // error in runtime
            //c = "ali";

            //object o = 12;
            //o = "ali";

            //dynamic c = null; // error in runtime
            //c = "ali";

            //object o = null;
            //o = "ali";

            //var x;
            //x= 12;

            //var result1 = null; // error
            //var result2 = (int?)null;
            //int? result3 = null;


            var dic = new Dictionary<int, string>();
            dic.Add(1, "men3m");
            dic.Add(2, "joe");
            foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.Write($"{kvp.Key} {kvp.Value}\n");
            }
            Console.WriteLine("=====================");
            foreach(var kvp in dic)
            {
                Console.Write($"{kvp.Key} {kvp.Value}\n");
            }

            #endregion
        }
    }
}