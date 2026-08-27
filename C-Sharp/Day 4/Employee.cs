using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {
            Name = "";
            Email = string.Empty;
            Salary = 100;
        }

        public Employee(int Id, string Name, string Email, decimal Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
        }

        // p1.Equals(p2)
        // emp1.Equals(emp2)
        // emp1.Equals(p2)
        // p1.Equals(emp2)
        // p1.Equals(null)
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            
            //if(obj is Employee emp)
            //{
            //    return Id == emp.Id;
            //}
            //return false;

            Employee? emp = obj as Employee;
            if (emp == null) return false;
            //return this.Id == emp.Id;
            return this.Id == emp.Id && Email == emp.Email;

            //Employee? emp1 = (Employee)obj;
            //if (emp == null) return false;
            //return this.Id == emp.Id;
        }

        public override int GetHashCode()
        {
            //return Id.GetHashCode();

            return HashCode.Combine(Id, Email);
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Email = {Email}, Salary = {Salary}";
        }

        //public string GetString()
        //{
        //    return $"Id = {Id}, Name = {Name}, Email = {Email}, Salary = {Salary}";
        //}

        // public ~Employee() { } // error

        ~Employee()
        {
            Console.WriteLine("this object has been freed up from memory");
        }
    }
}
