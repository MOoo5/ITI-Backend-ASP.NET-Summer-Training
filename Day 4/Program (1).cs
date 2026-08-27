using System.Security.Cryptography;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Day4
            // Header: Access Modifier + return type + function name +( param data type + parameter name)
            // signature: function name + number of params + order of param >> Overloading 


            //Point p1 = new Point(1,2,3);
            //Console.WriteLine(p1.ToString());

            //Point p2 = new Point(11, 12, 13);
            //Console.WriteLine(p2.ToString());


            //int x;
            //int y = x;
            //Console.WriteLine(x);

            //Point p;
            //p.X = 23;

            //Employee emp;
            //emp.Salary = 1232;

            //int x = 4;
            //int y = 7;
            //y = x;
            //x++;

            //Point p1 = new Point(1,2,3);
            //Point p2 = new Point(10,30,20);
            //p2 = p1;

            //p1.X = 11;

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);


            //Employee emp1 = new Employee(1, "hamza", "hamza@iti.com", 1000);
            //Employee emp2 = new Employee(2, "tag", "tag@iti.com", 950);

            //emp2 = emp1;

            //emp1.Salary = 900;

            //Console.WriteLine(emp1.ToString());
            //Console.WriteLine(emp2.ToString());


            //object o = new object();
            //o = "Ali";
            //o = new Point();
            //o = new Employee();
            //o = true;
            //o = 12;
            //o++;

            //float y = 2.14f;
            //int z = (int)y;


            //int x = (int)o; // explicit casting xxx  >>> unboxing
            //x++;
            //o = x;  // boxing


            //vector<int> v(10,0);
            // stack<object>


            //Employee emp = new();
            //Console.WriteLine( emp.ToString());
            //Console.WriteLine( emp);

            //Employee emp = new();
            //Console.WriteLine(emp.GetType());
            //Console.WriteLine(emp.GetType().Name);
            //Console.WriteLine(emp.GetType().Namespace);
            //Console.WriteLine(emp.GetType().FullName);
            //Console.WriteLine(emp.GetType().BaseType);
            //Console.WriteLine(emp.GetType().GUID);
            //Console.WriteLine("------------");

            //int x = 4;
            //Console.WriteLine(x.GetType().BaseType);
            //Console.WriteLine(x.GetType());

            //Console.WriteLine("------------");

            //Point p1 = new();
            //Console.WriteLine(p1.GetType());
            //Console.WriteLine(p1.GetType().Name);
            //Console.WriteLine(p1.GetType().Namespace);
            //Console.WriteLine(p1.GetType().FullName);
            //Console.WriteLine(p1.GetType().BaseType);
            //Console.WriteLine(p1.GetType().GUID);

            //Point p1 = new(1,2,3);
            //Point p2 = new(1,2,3);
            //if (p1.Equals(p2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}

            //Employee emp1 = new(1,"hatem","hatem@gmail.com", 100);
            //Employee emp2 = new(1,"zizo","zizo@gmail.com", 200);

            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}


            //Employee emp1 = new(1, "hatem", "hatem@gmail.com", 100);
            //Point p1 = new(1, 2, 3);
            //if (emp1.Equals(p1))
            //{
            //    Console.WriteLine("Equals");
            //}
            //else
            //{
            //    Console.WriteLine("Not Equal");
            //}


            //Employee emp11 = new(1, "hatem", "hatem@gmail.com", 100);
            //Employee emp12 = new(1, "zizo", "zizo@gmail.com", 200);

            //Console.WriteLine(emp11.GetHashCode());
            //Console.WriteLine(emp12.GetHashCode());

            //Console.WriteLine("-----------------------");

            //Employee emp1 = new(1, "hatem", "hatem@gmail.com", 100);
            //Employee emp2 = new(1, "zizo", "hatem@gmail.com", 200);

            //Console.WriteLine(emp1.GetHashCode());
            //Console.WriteLine(emp2.GetHashCode());
            #endregion

            #region Overloading

            int x = 5;
            int y = 21;
            int z = x + y;

            x += y; // x = x + y;

            x++;
            x = x + 1;

            // +   -   *  /   %
            //+=  -=  *= /=   %=

            // ++

            // complex + int

            Complex c1 = new Complex(12, 13);
            Complex c2 = new Complex(-4, 9);
            Complex c3 = c1 + c2;
            Console.WriteLine(c3);

            c1 += c2;
            Console.WriteLine(c1);

            c2++;  // complex int
            Console.WriteLine(c2);

            c2--; 
            Console.WriteLine(c2);

            c2 += 5; // c2 = c2 + 5;
            Console.WriteLine(c2);

            c2 -= 3;
            #endregion
        }
    }
}
