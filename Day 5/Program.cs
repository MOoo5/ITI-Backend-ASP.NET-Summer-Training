namespace Day5
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Static Field, Static Method, Static Property, Static Class, extension method

            //Student s1 = new("a", 21);

            //s1.Count // xxxx

            //Student s2 = new("b", 22);
            //Student s3 = new("c", 23);
            //Student s4 = new("d", 24);

            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.WriteLine(s3);
            //Console.WriteLine(s4);

            //Console.WriteLine($"Count = {Student.Count}");

            //Calculator c = new Calculator();
            //Console.WriteLine(c.Sum(2, 3)); // xxxxxx

            //Console.WriteLine(Calculator.Sum(23,1));

            //Math2 m = new Math2();

            //double c = Math.PI;

            //Console.WriteLine(Math2.Sum(23, 12));
            //string str = "Hey    G6 students. wlcm @ iti";
            //Console.WriteLine(Math2.CoWSuntWords1(str));
            //// extension method
            //Console.WriteLine($"using extension method: {str.CountWords()}");

            //DateTime bdate = new DateTime(month: 1, day: 1, year: 1990);
            //Console.WriteLine(bdate.CalculateAge());

            #region class Relations
            /*
                IS_A => Generalization, Type_OF, Inheritance
                USES_A => Dependency
                HAS_A => Association, Aggregation
                CONSIST_OF => Composition
            */

            //// Uses_A
            //Printer printer = new();
            //Employee employee = new Employee();
            //employee.PrintFile(printer);

            //EmailService emailService = new EmailService();
            //OrderService orderService = new OrderService();
            //orderService.CreateOrder(emailService);

            //// Has_A

            //var subjects = new Subject[] {
            //    new("#12343424", "C#", 25),
            //    new("#12343425", "DB", 20),
            //    new("#12343426", "EF", 15),
            //    new("#12343427", "APIs", 20),
            //};
            //Student student = new Student("Gamal", 20, subjects);
            //Student student2 = new Student("basmala", 20, subjects);  // within same track



            //Console.WriteLine(student);

            //// Consist_OF

            //Laptop laptop = new Laptop();
            // 1. Modification
            // 2. Sharing Data
            // 3. Unit Testing 

            //Parent p = new Parent(5);  // p:y:private, x:public, show: public, ctor
            //p.Show();

            //Child c = new Child(7, 5);   // 

            //Console.WriteLine($"x={c.x}, z={c.z}");
            //c.Show();



            //public void fun(parent p)
            // fun(c)
            //Parent p = new Parent();
            //Parent p = new Child();
            //Parent p = new SubChild(10,20,30);
            //p.Show();
            #endregion


            #region Sealed & Abstract

            //SealedClass c = new SealedClass();
            //AbstractClass abs = new AbstractClass();
            //c.Salary = 1000;

            #endregion

        }
    }
}
