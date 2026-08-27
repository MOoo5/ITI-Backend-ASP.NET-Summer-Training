namespace Day6
{
    internal class Program
    {
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
       
        //public static void Swap(ref string a, ref string b)
        //{
        //    string temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap<dt>(ref dt a, ref dt b)
        //{
        //    dt temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void Swap<dt1, dt2>(ref dt1 a, ref dt2 b)
        //{
        //    dt1 temp = a;
        //    a = (dt1)b;
        //    b = (dt2)temp;
        //}

        //public static void Show<T1, T2>(T1 a, T2 b)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}

        //public static void Show1<T1, T2>(T1 a, T2 b)
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //}


        static void Main(string[] args)
        {
            #region interface & builtin interfaces
            //PartTimeEmployee pEmp = new();
            //if(pEmp.Login("men3m", "men3m@iti.com"))
            //{
            //    Console.WriteLine("Logged in successfully");
            //}
            //else
            //{
            //    Console.WriteLine("Login failed");
            //}

            //int[] ages = new int[] { 12,64, 15, 39, 20, 28};
            //Array.Sort(ages);
            //foreach(int age in ages)
            //{ 
            //    Console.Write($"{age} ");
            //}

            //Student[] students = new Student[]
            //{
            //    new Student(5, "Tark", 20),
            //    new Student(2, "Ali", 24),
            //    new Student(3, "Yousef", 23),
            //    new Student(4, "Youssef", 21),
            //    new Student(1, "Mohamed", 22),
            //};

            //Array.Sort(students);
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}
            #endregion

            #region Generic Methods
            //int x = 5;
            //int y = 12;
            //Program.Swap(ref x, ref y);
            //Console.WriteLine($"x = {x}, y = {y}");

            //string x1 = "def";
            //string y1 = "abc";
            //Program.Swap(ref x1, ref y1);
            //Console.WriteLine($"x = {x1}, y = {y1}");

            //float x2 = 12.23f;
            //float y2 = 13.16f;

            //Program.Swap<float>(ref x2, ref y2);
            //Console.WriteLine($"x = {x2}, y = {y2}");


            //Program.Show<char, bool>('a', false);
            //Program.Show1<int, int>(23, 23);
            #endregion

            #region Generic Classes & not Generic

            //Stack st = new Stack();

            ////st.Pop();

            //st.Push(12);
            //st.Push(15);
            //st.Push(13);
            //st.Push(14);
            //st.Push(11);

            ////Console.WriteLine(st.Pop()); // 11
            ////st.Push(100);

            //bool isPopped = st.Pop(out int poppedValue);

            //int[] data = st.GetData();   // 12 15 13 14 11
            //                             //
            //foreach(int x in data)
            //{
            //    Console.Write($"{x} ");
            //}



            //Stack<string> names = new Stack<string>(7);

            //if(names.Pop(out string name))
            //{
            //    Console.WriteLine($"popped name = {name}");
            //} 
            //else
            //{
            //    Console.WriteLine("No elements to pop");
            //}

            //names.Push("men3m");
            //names.Push("ali");
            //names.Push("saleh");
            //names.Push("rami");
            //names.Push("salah");

            //string sname = names.Pop();
            //Console.WriteLine(names.Peek());

            ////names.Push("ahmed");
            ////names.Push("wael");

            //string[] data = names.GetData();

            //for(int i=0; i<data.Length; i++)
            //{
            //    Console.Write($"{data[i]} ");
            //}


            //StackOnFire<char> sof = new StackOnFire<char>();
            //sof.Push('M');
            #endregion

            #region Collection
            // List 
            //List<int> grades = [1, 2, 34, 12];
            //List<int> grades = new List<int>();

            //grades.Add(100);  // 0
            //grades.Add(200);  // 1>2
            //grades.Add(300);  // 2>3
            //grades.Add(200);  // 3>4
            //grades.Add(400);  // 4>5

            //grades.Insert(1, 50); // 1

            //grades.AddRange(10, 20, 30);
            //grades.RemoveRange(1, 3);

            //grades.Remove(200);
            //grades.RemoveAt(4);

            //for(int i=0; i<grades.Count; i++)
            //{
            //    Console.Write($"{grades[i]} ");
            //}

            //foreach(int grade in grades)
            //{
            //    Console.Write($"{grade} ");
            //}

            //if (grades.Contains(500))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}


            // Dictionary
            Dictionary<string, string> mobileNotes = new Dictionary<string, string>();
            mobileNotes.Add("012345", "ahmed");
            mobileNotes.Add("012334", "ali");
            mobileNotes.Add("014334", "ali");
            mobileNotes.Add("013334", "ali");
            mobileNotes.Add("015335", "ali");

            //if (mobileNotes.ContainsKey("015335"))
            //{
            //    Console.WriteLine("exists");
            //}
            //else {
            //    Console.WriteLine("not exists");
            //}

            //KeyValuePair<string, string> kvp = new KeyValuePair<string, string>("232323", "23232");
            //if (mobileNotes.Contains(kvp))
            //{
            //    Console.WriteLine("exists");
            //}
            //else
            //{
            //    Console.WriteLine("not exists");
            //}


            //string name = mobileNotes["018334"];  // ok|ex
            //Console.WriteLine(name);

            //bool isFound = mobileNotes.TryGetValue("018334", out string? fname);
            //if (isFound)
            //{
            //    Console.WriteLine($"{fname}");
            //}
            //else
            //{
            //    Console.WriteLine($"doesn't exist");
            //}

            //foreach (KeyValuePair<string, string> mobile in mobileNotes)
            //{
            //    Console.WriteLine($"{mobile.Key} {mobile.Value}");
            //}


            HashSet<string> vipGuests = new HashSet<string>();

            bool isAdded1 = vipGuests.Add("Men3m");
            bool isAdded2 = vipGuests.Add("tarek");
            bool isAdded3 = vipGuests.Add("Men3m");

            //bool isRemoved1 = vipGuests.Remove("tarek");
            //Console.WriteLine(isRemoved1);

            //bool isRemoved2 = vipGuests.Remove("Messi");
            //Console.WriteLine(isRemoved2);

            //Console.WriteLine(vipGuests.Contains("men3m"));
            //Console.WriteLine(vipGuests.Contains("Men3m"));

            HashSet<string> guests = new HashSet<string>();
            guests.Add("yousef");
            guests.Add("youssef");
            guests.Add("Men3m");

            //vipGuests.UnionWith(guests);
            //foreach (string vipGuest in vipGuests)
            //{
            //    Console.Write($"{vipGuest} ");
            //}

            //vipGuests.IntersectWith(guests);
            //foreach (string vipGuest in vipGuests)
            //{
            //    Console.Write($"{vipGuest} ");
            //}

            //vipGuests.ExceptWith(guests);
            //foreach (string vipGuest in vipGuests)
            //{
            //    Console.Write($"{vipGuest} ");
            //}

            //guests.ExceptWith(vipGuests);
            //foreach (string guest in guests)
            //{
            //    Console.Write($"{guest} ");
            //}


            //IEnumerable<string> newVipGuests = vipGuests.Union(guests);
            //foreach (string vipGuest in newVipGuests)
            //{
            //    Console.Write($"{vipGuest} ");
            //}

            #endregion
        }
    }
}
