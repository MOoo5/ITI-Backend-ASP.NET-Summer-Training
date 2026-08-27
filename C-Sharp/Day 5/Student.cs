using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Subject[] Subjects { get; set; } // asoociation

        public static int Count { get; set; }
      
        static Student()
        {
            Count = 0;
            Console.WriteLine(DateTime.UtcNow);
            //Age = 33;
        }
        
        public Student()
        {
            Count++;
        }
        
        public Student(string Name, int Age)
        {
            Count++;
            Id = Count;
            this.Age = Age;
            this.Name = Name;
        }
        
        public Student(string Name, int Age, Subject[] Subjects)
        {
            Count++;
            Id = Count;
            this.Age = Age;
            this.Name = Name;
            this.Subjects = Subjects;
        }

        public override string ToString()
        {
            StringBuilder sb = new($"Id = {Id}, Name = {Name}, Age = {Age}\n");
            for(int i=0; i<Subjects.Length; i++)
            {
                sb.AppendLine(Subjects[i].ToString());
            }
            return sb.ToString();
        }
    }
}
