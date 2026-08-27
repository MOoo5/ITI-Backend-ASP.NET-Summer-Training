using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Student : IComparable<Student> //, IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int Id, string Name, int Age)
        {
         
            this.Id = Id;
            this.Age = Age;
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Age = {Age}";
        }

        //public int CompareTo(object? obj)
        //{
        //    if(obj is Student student)
        //    {
        //        //  1  >> id1  > id2
        //        //  0  >> id1 == id2
        //        // -1  >> id1  < id2

        //        if (this.Id == student.Id) return 0;
        //        else if (Id > student.Id) return 1;
        //        else return -1;
        //    }


        //    throw new Exception("Can't Compare two different types.");
        //}

        public int CompareTo(Student? other)
        {
            // sort integers
            // implement IComparable >>> CompareTo

            return Id.CompareTo(other?.Id);
        }
    }
}
